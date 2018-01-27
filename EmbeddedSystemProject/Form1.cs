using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;
using System.Timers;
using System.Windows.Forms.DataVisualization.Charting;

namespace EmbeddedSystemProject
{
    public partial class Form1 : Form
    { 
        private float fTemp = 0;
        private float fHumid = 0;

        private int historyCounter = 0;
        private int oldHistoryCounter = 0;

        private List<DateTime> dateList = new List<DateTime>();
        private List<float> minHumidList = new List<float>();
        private List<float> maxHumidList = new List<float>();
        private List<float> minTempList = new List<float>();
        private List<float> maxTempList = new List<float>();

        private ConnectDb oConnectDb = new ConnectDb("server='192.168.137.54'; database=weatherLog; user=user; password = pass;");

        private System.Timers.Timer timer;
        System.Media.SoundPlayer player;
        private bool jariSang = false;

        private delegate void DELEGATE();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //connect to MySql-database
            oConnectDb.createDbConnection();

            this.Size = new Size(1220, 700);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Estetään ikkunan koon muuttaminen
            this.FormBorderStyle = FormBorderStyle.FixedDialog;    
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            aGaugeHumid.MaximumSize = new Size(600, 600);
            aGaugeTemp.MaximumSize  = new Size(600, 600);

            //tehdään timer
            timer = new System.Timers.Timer(1000);
            timer.Start();
            timer.Elapsed += readDataFromDb;
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            // Tabit pysyvät formin kokomuutosten mukana
            tabControl1.Dock = DockStyle.Fill;

            // Kuvat skaalaavat näin controllin mukaan,
            // Pidetään controlli dockattuna laidassa ja
            // center määrää viisarin olinpaikan controllin verrattuna (ei formin)
            aGaugeTemp.BackgroundImageLayout = ImageLayout.Stretch;
            aGaugeTemp.Dock = DockStyle.Left;
            aGaugeTemp.Center = new Point(290, 530);
            
            aGaugeHumid.BackgroundImageLayout = ImageLayout.Stretch;
            aGaugeHumid.Dock = DockStyle.Right;
            aGaugeHumid.Center = new Point(310, 530);
        }

        private void readDataFromDb(object source, ElapsedEventArgs e)
        {
            
            oConnectDb.getLiveDataFromDb();

            historyCounter = oConnectDb.getHistoryDataCounter();

            if (historyCounter > oldHistoryCounter)
            {
                //minimi kosteusarvot
                for (int i = 1; i < historyCounter + 1; i++)
                {
                    minHumidList.Add(oConnectDb.getHistoryDataFromDb(i, "humidMin"));
                }

                //maksimi kosteusarvot
                for (int i = 1; i < historyCounter + 1; i++)
                {
                    maxHumidList.Add(oConnectDb.getHistoryDataFromDb(i, "humidMax"));
                }

                //minimi lämpötila-arvot
                for (int i = 1; i < historyCounter + 1; i++)
                {
                    minTempList.Add(oConnectDb.getHistoryDataFromDb(i, "tempMin"));
                }

                //maksimi lämpötila-arvot
                for (int i = 1; i < historyCounter + 1; i++)
                {
                    maxTempList.Add(oConnectDb.getHistoryDataFromDb(i, "tempMax"));
                }

                //päivämäärät
                for (int i = 1; i < historyCounter + 1; i++)
                {
                    dateList.Add(oConnectDb.getDatesFromDb(i));
                }


                for (int i = 0; i < dateList.Count; i++)
                {
                    chartHumHistory.Series["Max Humidity"].Points.AddXY(dateList[i], maxHumidList[i]);
                    chartHumHistory.Series["Min Humidity"].Points.AddXY(dateList[i], minHumidList[i]);
                }

                for(int i = 0; i < dateList.Count; i++)
                {
                    chartTempHistory.Series["Max Temperature"].Points.AddXY(dateList[i], maxTempList[i]);
                    chartTempHistory.Series["Min Temperature"].Points.AddXY(dateList[i], minTempList[i]);
                }
                oldHistoryCounter = historyCounter;
            }
            Delegate del = new DELEGATE(WriteData);
            this.Invoke(del);
        }

        private void WriteData()
        {            
            //valtterin mittareihin välitettävät datat:
            //fHumid ja fTemp
            fTemp = oConnectDb.getTemperature();
            fHumid = oConnectDb.getHumidity();

            aGaugeTemp.Value = fTemp;
            labelTempValue.Text = fTemp.ToString()+" "+ "°C";
           
            aGaugeHumid.Value = fHumid;
            labelHumidValue.Text = fHumid.ToString()+" "+"%";

            // Siltsu Bitch
            if (fTemp > 25 && jariSang == false)
            {
                player = new System.Media.SoundPlayer(EmbeddedSystemProject.Properties.Resources.Ei_ikina_enaa_fade);
                player.Play();
                jariSang = true;
            }

            //live data kaavio
            //määritellään scrollbarit
            double maxX = chartLiveData.ChartAreas["ChartArea1"].AxisX.Maximum;
            chartLiveData.ChartAreas["ChartArea1"].AxisX.ScrollBar.Size = 10;
            chartLiveData.ChartAreas["ChartArea1"].AxisX.ScrollBar.Enabled = true;
            chartLiveData.ChartAreas["ChartArea1"].AxisX.ScrollBar.IsPositionedInside = true;
            
            //kaavion pisteet
            chartLiveData.Series["Temperature"].Points.AddY(fTemp);
            chartLiveData.Series["Humidity"].Points.AddY(fHumid);
            chartLiveData.ChartAreas["ChartArea1"].AxisX.ScaleView.Zoom(maxX -15, maxX);


            //päivitetään historia kaavioiden maksimi- ja minimi arvojen muutokset
            //..kosteusarvot
            if (maxHumidList[maxHumidList.Count - 1] < fHumid || minHumidList[minHumidList.Count - 1] > fHumid)
            {
                if (maxHumidList[maxHumidList.Count - 1] < fHumid)
                {
                    maxHumidList.RemoveAt(maxHumidList.Count - 1);
                    maxHumidList.Add(oConnectDb.getHistoryDataFromDb(historyCounter, "humidMax"));

                    chartHumHistory.Series["Max Humidity"].Points.Clear();

                    for (int i = 0; i < dateList.Count; i++)
                    {
                        chartHumHistory.Series["Max Humidity"].Points.AddXY(dateList[i], maxHumidList[i]);
                    }
                }

                if (minHumidList[minHumidList.Count - 1] > fHumid)
                {
                    minHumidList.RemoveAt(minHumidList.Count - 1);
                    minHumidList.Add(oConnectDb.getHistoryDataFromDb(historyCounter, "humidMin"));

                    chartHumHistory.Series["Min Humidity"].Points.Clear();

                    for (int i = 0; i < dateList.Count; i++)
                    {
                        chartHumHistory.Series["Min Humidity"].Points.AddXY(dateList[i], minHumidList[i]);
                    }
                }


            }

            //..lämpötila-arvot
            if (maxTempList[maxTempList.Count - 1] < fTemp || minTempList[minTempList.Count - 1] > fTemp)
            {
                if (maxTempList[maxTempList.Count - 1] < fTemp)
                {
                    maxTempList.RemoveAt(maxTempList.Count - 1);
                    maxTempList.Add(oConnectDb.getHistoryDataFromDb(historyCounter, "tempMax"));

                    chartTempHistory.Series["Max Temperature"].Points.Clear();

                    for (int i = 0; i < dateList.Count; i++)
                    {
                        chartTempHistory.Series["Max Temperature"].Points.AddXY(dateList[i], maxHumidList[i]);

                    }
                }

                if (minTempList[minTempList.Count - 1] > fTemp)
                {
                    minTempList.RemoveAt(minTempList.Count - 1);
                    minTempList.Add(oConnectDb.getHistoryDataFromDb(historyCounter, "tempMin"));

                    chartTempHistory.Series["Min Temperature"].Points.Clear();

                    for (int i = 0; i < dateList.Count; i++)
                    {
                        chartTempHistory.Series["Min Temperature"].Points.AddXY(dateList[i], minHumidList[i]);
                    }
                }

            }
        }

        // Pidetään näin siltsut neliöinä
        private void aGaugeHumid_SizeChanged(object sender, EventArgs e)
        {
            aGaugeHumid.Width = aGaugeHumid.Height;
        }
        private void aGaugeTemp_SizeChanged(object sender, EventArgs e)
        {
            aGaugeTemp.Width = aGaugeTemp.Height;
        }
    }

    public class ConnectDb
    {
        private float mHistoryValue = 0;
        private float mHumid = 0;
        private float mTemp = 0;

        private int mCounter = 0;
        private DateTime mDate;

        private string mconnectionString;
        private string mySqlCommandString;
        private MySqlConnection myConnection;
        private MySqlDataReader dataReader;
      

        public ConnectDb(string givenConnection)
        {
            mconnectionString = givenConnection;
        }

        public void createDbConnection()
        {
            myConnection = new MySqlConnection(mconnectionString);

            try
            {
                //yrittää yhdistää tietokantaan
                myConnection.Open();
            }
            catch (MySqlException)
            {
                //Jos yhteyttä tietokantaan ei ole näytetään messagebox
                MessageBox.Show("Cannot connect to database. Check your network" + Environment.NewLine + "Program will be closed");

            }
            finally
            {
                //Jos yhteyttä ei saada ohjelma sammuu
                if (!(myConnection.State == ConnectionState.Open))
                    Application.Exit();
            }

            if (myConnection.State != ConnectionState.Open)
                MessageBox.Show("Cannot open database");
            else
                Console.WriteLine("Database opened");
        }

        public void getLiveDataFromDb()
        {
            try
            {
                MySqlCommand mySqlCommandGetValues = new MySqlCommand("SELECT * FROM dataLog ORDER BY id DESC LIMIT 1", myConnection);

                using (dataReader = mySqlCommandGetValues.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Console.WriteLine(dataReader.GetFloat(2).ToString());
                        mTemp = dataReader.GetFloat(2);
                        mHumid = dataReader.GetFloat(3);
                    }
                }
                mySqlCommandGetValues.Dispose();
            }
            catch (MySqlException)
            {
                Console.WriteLine("DataReader was not closed properly the first time");
            }
        }

        public float getHumidity()
        {
            return mHumid;
        }

        public float getTemperature()
        {
            return mTemp;
        }

        public int getHistoryDataCounter()
        {
            try
            {
                MySqlCommand mySqlCommandGetValues = new MySqlCommand("SELECT MAX(id) FROM historyLog", myConnection);

                using (dataReader = mySqlCommandGetValues.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        mCounter = dataReader.GetInt16(0);
                    }
                }
                //while (!dataReader.IsClosed) dataReader.Close(); // ONKO TÄMÄ TARPEELLINEN?
            }
            catch (MySqlException)
            {
                Console.WriteLine("DataReader was not closed properly the first time");
            }
            return mCounter;
        }

        public DateTime getDatesFromDb(int givenIndex)
        {
            try
            {
                MySqlCommand mySqlCommandGetValues = new MySqlCommand("SELECT date FROM historyLog WHERE id = @id", myConnection);
                mySqlCommandGetValues.Parameters.AddWithValue("@id", givenIndex);

                using (dataReader = mySqlCommandGetValues.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        mDate = dataReader.GetDateTime(0);
                    }
                }
            }
            catch (MySqlException)
            {
                Console.WriteLine("DataReader was not closed properly the first time");
            }
            return mDate;
        }

        public float getHistoryDataFromDb(int givenIndex, string valueType)
        { 
            switch(valueType)
            {
                case "humidMax":
                    mySqlCommandString = "SELECT humidity_max FROM historyLog WHERE id = @id";
                    break;

                case "humidMin":
                    mySqlCommandString = "SELECT humidity_min FROM historyLog WHERE id = @id";
                    break;

                case "tempMax":
                    mySqlCommandString = "SELECT temperature_max FROM historyLog WHERE id = @id";
                    break;

                case "tempMin":
                    mySqlCommandString = "SELECT temperature_min FROM historyLog WHERE id = @id";
                    break;
            }

            try
            {
                MySqlCommand mySqlCommandGetValues = new MySqlCommand(mySqlCommandString, myConnection);
                mySqlCommandGetValues.Parameters.AddWithValue("@id", givenIndex);

                using (dataReader = mySqlCommandGetValues.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        mHistoryValue = dataReader.GetFloat(0);
                    }
                }
            }
            catch (MySqlException)
            {
                Console.WriteLine("DataReader was not closed properly the first time");
            }
            return mHistoryValue;
        }
    }
}
