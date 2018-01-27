namespace EmbeddedSystemProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelTempTxt = new System.Windows.Forms.Label();
            this.labelHumidTxt = new System.Windows.Forms.Label();
            this.labelTempValue = new System.Windows.Forms.Label();
            this.labelHumidValue = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chartLiveData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chartHumHistory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chartTempHistory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.aGaugeTemp = new System.Windows.Forms.AGauge();
            this.aGaugeHumid = new System.Windows.Forms.AGauge();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLiveData)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartHumHistory)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTempHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTempTxt
            // 
            this.labelTempTxt.AutoSize = true;
            this.labelTempTxt.BackColor = System.Drawing.Color.Transparent;
            this.labelTempTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempTxt.Location = new System.Drawing.Point(260, 750);
            this.labelTempTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTempTxt.Name = "labelTempTxt";
            this.labelTempTxt.Size = new System.Drawing.Size(115, 20);
            this.labelTempTxt.TabIndex = 4;
            this.labelTempTxt.Text = "Temperature";
            // 
            // labelHumidTxt
            // 
            this.labelHumidTxt.AutoSize = true;
            this.labelHumidTxt.BackColor = System.Drawing.Color.Transparent;
            this.labelHumidTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHumidTxt.Location = new System.Drawing.Point(1120, 750);
            this.labelHumidTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHumidTxt.Name = "labelHumidTxt";
            this.labelHumidTxt.Size = new System.Drawing.Size(83, 20);
            this.labelHumidTxt.TabIndex = 5;
            this.labelHumidTxt.Text = "Humidity";
            this.labelHumidTxt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelTempValue
            // 
            this.labelTempValue.AutoSize = true;
            this.labelTempValue.BackColor = System.Drawing.Color.Transparent;
            this.labelTempValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempValue.Location = new System.Drawing.Point(396, 750);
            this.labelTempValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTempValue.Name = "labelTempValue";
            this.labelTempValue.Size = new System.Drawing.Size(37, 25);
            this.labelTempValue.TabIndex = 6;
            this.labelTempValue.Text = "°C";
            // 
            // labelHumidValue
            // 
            this.labelHumidValue.AutoSize = true;
            this.labelHumidValue.BackColor = System.Drawing.Color.Transparent;
            this.labelHumidValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHumidValue.Location = new System.Drawing.Point(1215, 750);
            this.labelHumidValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHumidValue.Name = "labelHumidValue";
            this.labelHumidValue.Size = new System.Drawing.Size(31, 25);
            this.labelHumidValue.TabIndex = 7;
            this.labelHumidValue.Text = "%";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(17, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(956, 532);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BackgroundImage = global::EmbeddedSystemProject.Properties.Resources.Background;
            this.tabPage1.Controls.Add(this.labelHumidValue);
            this.tabPage1.Controls.Add(this.labelTempValue);
            this.tabPage1.Controls.Add(this.labelTempTxt);
            this.tabPage1.Controls.Add(this.labelHumidTxt);
            this.tabPage1.Controls.Add(this.aGaugeTemp);
            this.tabPage1.Controls.Add(this.aGaugeHumid);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(948, 503);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Real-Time Gauges";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chartLiveData);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(948, 503);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Live Chart";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chartLiveData
            // 
            chartArea1.AxisY.Title = "Temperature °C, Humidity %";
            chartArea1.Name = "ChartArea1";
            this.chartLiveData.ChartAreas.Add(chartArea1);
            this.chartLiveData.Cursor = System.Windows.Forms.Cursors.Default;
            this.chartLiveData.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartLiveData.Legends.Add(legend1);
            this.chartLiveData.Location = new System.Drawing.Point(4, 4);
            this.chartLiveData.Margin = new System.Windows.Forms.Padding(4);
            this.chartLiveData.Name = "chartLiveData";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Humidity";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Temperature";
            this.chartLiveData.Series.Add(series1);
            this.chartLiveData.Series.Add(series2);
            this.chartLiveData.Size = new System.Drawing.Size(940, 495);
            this.chartLiveData.TabIndex = 0;
            this.chartLiveData.Text = "chart1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chartHumHistory);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(948, 503);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Humidity History Chart";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chartHumHistory
            // 
            chartArea2.Name = "ChartArea1";
            this.chartHumHistory.ChartAreas.Add(chartArea2);
            this.chartHumHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartHumHistory.Legends.Add(legend2);
            this.chartHumHistory.Location = new System.Drawing.Point(4, 4);
            this.chartHumHistory.Margin = new System.Windows.Forms.Padding(4);
            this.chartHumHistory.Name = "chartHumHistory";
            series3.ChartArea = "ChartArea1";
            series3.IsXValueIndexed = true;
            series3.Legend = "Legend1";
            series3.Name = "Min Humidity";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series4.ChartArea = "ChartArea1";
            series4.IsXValueIndexed = true;
            series4.Legend = "Legend1";
            series4.Name = "Max Humidity";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.chartHumHistory.Series.Add(series3);
            this.chartHumHistory.Series.Add(series4);
            this.chartHumHistory.Size = new System.Drawing.Size(940, 495);
            this.chartHumHistory.TabIndex = 0;
            this.chartHumHistory.Text = "chart1";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.chartTempHistory);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(948, 503);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Temperature History Chart";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // chartTempHistory
            // 
            chartArea3.Name = "ChartArea1";
            this.chartTempHistory.ChartAreas.Add(chartArea3);
            this.chartTempHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chartTempHistory.Legends.Add(legend3);
            this.chartTempHistory.Location = new System.Drawing.Point(4, 4);
            this.chartTempHistory.Margin = new System.Windows.Forms.Padding(4);
            this.chartTempHistory.Name = "chartTempHistory";
            series5.ChartArea = "ChartArea1";
            series5.IsXValueIndexed = true;
            series5.Legend = "Legend1";
            series5.Name = "Min Temperature";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series6.ChartArea = "ChartArea1";
            series6.IsXValueIndexed = true;
            series6.Legend = "Legend1";
            series6.Name = "Max Temperature";
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.chartTempHistory.Series.Add(series5);
            this.chartTempHistory.Series.Add(series6);
            this.chartTempHistory.Size = new System.Drawing.Size(940, 495);
            this.chartTempHistory.TabIndex = 0;
            this.chartTempHistory.Text = "chart1";
            // 
            // aGaugeTemp
            // 
            this.aGaugeTemp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.aGaugeTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(145)))), ((int)(((byte)(88)))));
            this.aGaugeTemp.BackgroundImage = global::EmbeddedSystemProject.Properties.Resources.Siltsu;
            this.aGaugeTemp.BaseArcColor = System.Drawing.Color.Brown;
            this.aGaugeTemp.BaseArcRadius = 0;
            this.aGaugeTemp.BaseArcStart = 200;
            this.aGaugeTemp.BaseArcSweep = 140;
            this.aGaugeTemp.BaseArcWidth = 0;
            this.aGaugeTemp.Center = new System.Drawing.Point(100, 100);
            this.aGaugeTemp.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGaugeTemp.Location = new System.Drawing.Point(7, 61);
            this.aGaugeTemp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aGaugeTemp.MaxValue = 100F;
            this.aGaugeTemp.MinValue = -20F;
            this.aGaugeTemp.Name = "aGaugeTemp";
            this.aGaugeTemp.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Red;
            this.aGaugeTemp.NeedleColor2 = System.Drawing.Color.DarkRed;
            this.aGaugeTemp.NeedleRadius = 150;
            this.aGaugeTemp.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGaugeTemp.NeedleWidth = 8;
            this.aGaugeTemp.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGaugeTemp.ScaleLinesInterInnerRadius = 80;
            this.aGaugeTemp.ScaleLinesInterOuterRadius = 80;
            this.aGaugeTemp.ScaleLinesInterWidth = 0;
            this.aGaugeTemp.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGaugeTemp.ScaleLinesMajorInnerRadius = 80;
            this.aGaugeTemp.ScaleLinesMajorOuterRadius = 80;
            this.aGaugeTemp.ScaleLinesMajorStepValue = 20F;
            this.aGaugeTemp.ScaleLinesMajorWidth = 2;
            this.aGaugeTemp.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGaugeTemp.ScaleLinesMinorInnerRadius = 80;
            this.aGaugeTemp.ScaleLinesMinorOuterRadius = 80;
            this.aGaugeTemp.ScaleLinesMinorTicks = 0;
            this.aGaugeTemp.ScaleLinesMinorWidth = 0;
            this.aGaugeTemp.ScaleNumbersColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(3)))));
            this.aGaugeTemp.ScaleNumbersFormat = "";
            this.aGaugeTemp.ScaleNumbersRadius = 175;
            this.aGaugeTemp.ScaleNumbersRotation = 1;
            this.aGaugeTemp.ScaleNumbersStartScaleLine = 0;
            this.aGaugeTemp.ScaleNumbersStepScaleLines = 1;
            this.aGaugeTemp.Size = new System.Drawing.Size(500, 400);
            this.aGaugeTemp.TabIndex = 2;
            this.aGaugeTemp.Text = "aGauge1";
            this.aGaugeTemp.Value = 0F;
            this.aGaugeTemp.SizeChanged += new System.EventHandler(this.aGaugeTemp_SizeChanged);
            // 
            // aGaugeHumid
            // 
            this.aGaugeHumid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.aGaugeHumid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(145)))), ((int)(((byte)(88)))));
            this.aGaugeHumid.BackgroundImage = global::EmbeddedSystemProject.Properties.Resources.SiltsuRotate;
            this.aGaugeHumid.BaseArcColor = System.Drawing.Color.MidnightBlue;
            this.aGaugeHumid.BaseArcRadius = 0;
            this.aGaugeHumid.BaseArcStart = 200;
            this.aGaugeHumid.BaseArcSweep = 140;
            this.aGaugeHumid.BaseArcWidth = 0;
            this.aGaugeHumid.Center = new System.Drawing.Point(100, 100);
            this.aGaugeHumid.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGaugeHumid.Location = new System.Drawing.Point(513, 61);
            this.aGaugeHumid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aGaugeHumid.MaxValue = 100F;
            this.aGaugeHumid.MinValue = 0F;
            this.aGaugeHumid.Name = "aGaugeHumid";
            this.aGaugeHumid.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Blue;
            this.aGaugeHumid.NeedleColor2 = System.Drawing.Color.MidnightBlue;
            this.aGaugeHumid.NeedleRadius = 150;
            this.aGaugeHumid.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGaugeHumid.NeedleWidth = 8;
            this.aGaugeHumid.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGaugeHumid.ScaleLinesInterInnerRadius = 80;
            this.aGaugeHumid.ScaleLinesInterOuterRadius = 80;
            this.aGaugeHumid.ScaleLinesInterWidth = 0;
            this.aGaugeHumid.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGaugeHumid.ScaleLinesMajorInnerRadius = 80;
            this.aGaugeHumid.ScaleLinesMajorOuterRadius = 80;
            this.aGaugeHumid.ScaleLinesMajorStepValue = 20F;
            this.aGaugeHumid.ScaleLinesMajorWidth = 2;
            this.aGaugeHumid.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGaugeHumid.ScaleLinesMinorInnerRadius = 80;
            this.aGaugeHumid.ScaleLinesMinorOuterRadius = 80;
            this.aGaugeHumid.ScaleLinesMinorTicks = 0;
            this.aGaugeHumid.ScaleLinesMinorWidth = 0;
            this.aGaugeHumid.ScaleNumbersColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(39)))), ((int)(((byte)(3)))));
            this.aGaugeHumid.ScaleNumbersFormat = null;
            this.aGaugeHumid.ScaleNumbersRadius = 175;
            this.aGaugeHumid.ScaleNumbersRotation = 1;
            this.aGaugeHumid.ScaleNumbersStartScaleLine = 0;
            this.aGaugeHumid.ScaleNumbersStepScaleLines = 1;
            this.aGaugeHumid.Size = new System.Drawing.Size(500, 400);
            this.aGaugeHumid.TabIndex = 3;
            this.aGaugeHumid.Text = "aGauge2";
            this.aGaugeHumid.Value = 0F;
            this.aGaugeHumid.SizeChanged += new System.EventHandler(this.aGaugeHumid_SizeChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 562);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Weather station";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartLiveData)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartHumHistory)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTempHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.AGauge aGaugeTemp;
        private System.Windows.Forms.AGauge aGaugeHumid;
        private System.Windows.Forms.Label labelTempTxt;
        private System.Windows.Forms.Label labelHumidTxt;
        private System.Windows.Forms.Label labelTempValue;
        private System.Windows.Forms.Label labelHumidValue;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLiveData;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHumHistory;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTempHistory;
    }
}

