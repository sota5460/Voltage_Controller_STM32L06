
using System;
using System.IO.Ports;

namespace SerialScreen_ver1
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(30D, "40,50,0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(25D, "20,21,0,0");
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button_close = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_BufThresh = new System.Windows.Forms.ComboBox();
            this.label_BufTh = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_rxsetting = new System.Windows.Forms.ComboBox();
            this.comboBox_baudrate = new System.Windows.Forms.ComboBox();
            this.label_setting_title = new System.Windows.Forms.Label();
            this.button_chart_clear = new System.Windows.Forms.Button();
            this.chart_MCA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_chart_res = new System.Windows.Forms.Label();
            this.comboBox_horizon = new System.Windows.Forms.ComboBox();
            this.comboBox_adc_res = new System.Windows.Forms.ComboBox();
            this.panel_mca_setting = new System.Windows.Forms.Panel();
            this.button_close_mca = new System.Windows.Forms.Button();
            this.textBox_csv_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_pulse_num = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_mca_setting = new System.Windows.Forms.Button();
            this.label_Pulse_Num = new System.Windows.Forms.Label();
            this.label_mca_specific = new System.Windows.Forms.Label();
            this.button_mca_setting_display = new System.Windows.Forms.Button();
            this.button_MCA_ON = new System.Windows.Forms.Button();
            this.button_MCA_OFF = new System.Windows.Forms.Button();
            this.button_mca_clear = new System.Windows.Forms.Button();
            this.btn_rx_buf_clear = new System.Windows.Forms.Button();
            this.button_adc_setting = new System.Windows.Forms.Button();
            this.panel_adc_setting = new System.Windows.Forms.Panel();
            this.button_close_adc = new System.Windows.Forms.Button();
            this.button_adc_setting_off = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button_csv_out = new System.Windows.Forms.Button();
            this.mcu_setting_btn = new System.Windows.Forms.Button();
            this.mcu_setting_panel = new System.Windows.Forms.Panel();
            this.clear_one_samplenum_btn = new System.Windows.Forms.Button();
            this.clear_thresh_btn = new System.Windows.Forms.Button();
            this.label_adc_threshold_dis = new System.Windows.Forms.Label();
            this.button_mcu_setting_panel_off = new System.Windows.Forms.Button();
            this.button_mcu_setting_on = new System.Windows.Forms.Button();
            this.textBox_pulse_num = new System.Windows.Forms.TextBox();
            this.label_adc_sample_num = new System.Windows.Forms.Label();
            this.label_adc_threshold = new System.Windows.Forms.Label();
            this.textBox_threshold = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button_autoopen = new System.Windows.Forms.Button();
            this.button_adcStart = new System.Windows.Forms.Button();
            this.button_adcStop = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_MCA)).BeginInit();
            this.panel_mca_setting.SuspendLayout();
            this.panel_adc_setting.SuspendLayout();
            this.mcu_setting_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.ReadBufferSize = 50000;
            this.serialPort1.ReadTimeout = 1000;
            this.serialPort1.ReceivedBytesThreshold = 200;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived_1);
            // 
            // button_close
            // 
            this.button_close.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_close.Location = new System.Drawing.Point(13, 609);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(144, 42);
            this.button_close.TabIndex = 2;
            this.button_close.Text = "接続を解除";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.LightGray;
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(590, 17);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.YValuesPerPoint = 4;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(823, 527);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Interval_function);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.comboBox_BufThresh);
            this.panel1.Controls.Add(this.label_BufTh);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox_rxsetting);
            this.panel1.Controls.Add(this.comboBox_baudrate);
            this.panel1.Location = new System.Drawing.Point(1256, 233);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 135);
            this.panel1.TabIndex = 16;
            // 
            // comboBox_BufThresh
            // 
            this.comboBox_BufThresh.FormattingEnabled = true;
            this.comboBox_BufThresh.Items.AddRange(new object[] {
            "1",
            "200",
            "500",
            "1000",
            "2000",
            "10000"});
            this.comboBox_BufThresh.Location = new System.Drawing.Point(142, 69);
            this.comboBox_BufThresh.Name = "comboBox_BufThresh";
            this.comboBox_BufThresh.Size = new System.Drawing.Size(212, 20);
            this.comboBox_BufThresh.TabIndex = 21;
            // 
            // label_BufTh
            // 
            this.label_BufTh.AutoSize = true;
            this.label_BufTh.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_BufTh.Location = new System.Drawing.Point(9, 68);
            this.label_BufTh.Name = "label_BufTh";
            this.label_BufTh.Size = new System.Drawing.Size(89, 16);
            this.label_BufTh.TabIndex = 20;
            this.label_BufTh.Text = "バッファ閾値";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(9, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "受信バッファ設定";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(9, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "BaudRate";
            // 
            // comboBox_rxsetting
            // 
            this.comboBox_rxsetting.FormattingEnabled = true;
            this.comboBox_rxsetting.Items.AddRange(new object[] {
            "指定byte数で読み取り",
            "改行コード区切りで読み取り",
            "Exisiting読み取り"});
            this.comboBox_rxsetting.Location = new System.Drawing.Point(142, 39);
            this.comboBox_rxsetting.Name = "comboBox_rxsetting";
            this.comboBox_rxsetting.Size = new System.Drawing.Size(212, 20);
            this.comboBox_rxsetting.TabIndex = 18;
            this.comboBox_rxsetting.SelectedIndexChanged += new System.EventHandler(this.comboBox_rxsetting_SelectedIndexChanged);
            // 
            // comboBox_baudrate
            // 
            this.comboBox_baudrate.FormattingEnabled = true;
            this.comboBox_baudrate.Items.AddRange(new object[] {
            "115200",
            "9600"});
            this.comboBox_baudrate.Location = new System.Drawing.Point(142, 10);
            this.comboBox_baudrate.Name = "comboBox_baudrate";
            this.comboBox_baudrate.Size = new System.Drawing.Size(212, 20);
            this.comboBox_baudrate.TabIndex = 17;
            this.comboBox_baudrate.Text = "115200";
            // 
            // label_setting_title
            // 
            this.label_setting_title.AutoSize = true;
            this.label_setting_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_setting_title.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_setting_title.Location = new System.Drawing.Point(488, 572);
            this.label_setting_title.Name = "label_setting_title";
            this.label_setting_title.Size = new System.Drawing.Size(91, 21);
            this.label_setting_title.TabIndex = 20;
            this.label_setting_title.Text = "詳細設定";
            // 
            // button_chart_clear
            // 
            this.button_chart_clear.Location = new System.Drawing.Point(1276, 394);
            this.button_chart_clear.Name = "button_chart_clear";
            this.button_chart_clear.Size = new System.Drawing.Size(121, 23);
            this.button_chart_clear.TabIndex = 25;
            this.button_chart_clear.Text = "クリア";
            this.button_chart_clear.UseVisualStyleBackColor = true;
            // 
            // chart_MCA
            // 
            this.chart_MCA.BackColor = System.Drawing.Color.LightGray;
            this.chart_MCA.BorderlineColor = System.Drawing.Color.Black;
            this.chart_MCA.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "ChartArea1";
            this.chart_MCA.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_MCA.Legends.Add(legend2);
            this.chart_MCA.Location = new System.Drawing.Point(12, 17);
            this.chart_MCA.Name = "chart_MCA";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_MCA.Series.Add(series2);
            this.chart_MCA.Size = new System.Drawing.Size(572, 527);
            this.chart_MCA.TabIndex = 26;
            this.chart_MCA.Text = "chart2";
            // 
            // label_chart_res
            // 
            this.label_chart_res.AutoSize = true;
            this.label_chart_res.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_chart_res.Location = new System.Drawing.Point(485, 329);
            this.label_chart_res.Name = "label_chart_res";
            this.label_chart_res.Size = new System.Drawing.Size(42, 16);
            this.label_chart_res.TabIndex = 22;
            this.label_chart_res.Text = "横軸";
            // 
            // comboBox_horizon
            // 
            this.comboBox_horizon.FormattingEnabled = true;
            this.comboBox_horizon.Items.AddRange(new object[] {
            "4096(12bit)",
            "1024(10bit)",
            "256(8bit)"});
            this.comboBox_horizon.Location = new System.Drawing.Point(474, 348);
            this.comboBox_horizon.Name = "comboBox_horizon";
            this.comboBox_horizon.Size = new System.Drawing.Size(79, 20);
            this.comboBox_horizon.TabIndex = 21;
            this.comboBox_horizon.SelectedIndexChanged += new System.EventHandler(this.comboBox_horizon_SelectedIndexChanged);
            // 
            // comboBox_adc_res
            // 
            this.comboBox_adc_res.FormattingEnabled = true;
            this.comboBox_adc_res.Items.AddRange(new object[] {
            "4096(12bit)",
            "1024(10bit)",
            "256(8bit)"});
            this.comboBox_adc_res.Location = new System.Drawing.Point(118, 67);
            this.comboBox_adc_res.Name = "comboBox_adc_res";
            this.comboBox_adc_res.Size = new System.Drawing.Size(69, 20);
            this.comboBox_adc_res.TabIndex = 23;
            // 
            // panel_mca_setting
            // 
            this.panel_mca_setting.Controls.Add(this.button_close_mca);
            this.panel_mca_setting.Controls.Add(this.textBox_csv_name);
            this.panel_mca_setting.Controls.Add(this.label7);
            this.panel_mca_setting.Controls.Add(this.comboBox_pulse_num);
            this.panel_mca_setting.Controls.Add(this.label5);
            this.panel_mca_setting.Controls.Add(this.button_mca_setting);
            this.panel_mca_setting.Controls.Add(this.comboBox_adc_res);
            this.panel_mca_setting.Controls.Add(this.label_Pulse_Num);
            this.panel_mca_setting.Controls.Add(this.label_mca_specific);
            this.panel_mca_setting.Location = new System.Drawing.Point(33, 305);
            this.panel_mca_setting.Name = "panel_mca_setting";
            this.panel_mca_setting.Size = new System.Drawing.Size(200, 227);
            this.panel_mca_setting.TabIndex = 27;
            // 
            // button_close_mca
            // 
            this.button_close_mca.Location = new System.Drawing.Point(30, 191);
            this.button_close_mca.Name = "button_close_mca";
            this.button_close_mca.Size = new System.Drawing.Size(60, 23);
            this.button_close_mca.TabIndex = 28;
            this.button_close_mca.Text = "閉じる";
            this.button_close_mca.UseVisualStyleBackColor = true;
            this.button_close_mca.Click += new System.EventHandler(this.button_close_mca_Click);
            // 
            // textBox_csv_name
            // 
            this.textBox_csv_name.Location = new System.Drawing.Point(120, 168);
            this.textBox_csv_name.Name = "textBox_csv_name";
            this.textBox_csv_name.Size = new System.Drawing.Size(67, 19);
            this.textBox_csv_name.TabIndex = 27;
            this.textBox_csv_name.Text = "csv_1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(11, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "csvファイル名";
            // 
            // comboBox_pulse_num
            // 
            this.comboBox_pulse_num.FormattingEnabled = true;
            this.comboBox_pulse_num.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.comboBox_pulse_num.Location = new System.Drawing.Point(118, 37);
            this.comboBox_pulse_num.Name = "comboBox_pulse_num";
            this.comboBox_pulse_num.Size = new System.Drawing.Size(69, 20);
            this.comboBox_pulse_num.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(9, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "ADC分解能";
            // 
            // button_mca_setting
            // 
            this.button_mca_setting.Location = new System.Drawing.Point(112, 192);
            this.button_mca_setting.Name = "button_mca_setting";
            this.button_mca_setting.Size = new System.Drawing.Size(75, 23);
            this.button_mca_setting.TabIndex = 3;
            this.button_mca_setting.Text = "設定を反映";
            this.button_mca_setting.UseVisualStyleBackColor = true;
            this.button_mca_setting.Click += new System.EventHandler(this.button_mca_setting_Click);
            // 
            // label_Pulse_Num
            // 
            this.label_Pulse_Num.AutoSize = true;
            this.label_Pulse_Num.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_Pulse_Num.Location = new System.Drawing.Point(9, 38);
            this.label_Pulse_Num.Name = "label_Pulse_Num";
            this.label_Pulse_Num.Size = new System.Drawing.Size(88, 15);
            this.label_Pulse_Num.TabIndex = 1;
            this.label_Pulse_Num.Text = "1Pulse_Point";
            // 
            // label_mca_specific
            // 
            this.label_mca_specific.AutoSize = true;
            this.label_mca_specific.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_mca_specific.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_mca_specific.Location = new System.Drawing.Point(12, 9);
            this.label_mca_specific.Name = "label_mca_specific";
            this.label_mca_specific.Size = new System.Drawing.Size(112, 17);
            this.label_mca_specific.TabIndex = 0;
            this.label_mca_specific.Text = "MCA_詳細設定";
            // 
            // button_mca_setting_display
            // 
            this.button_mca_setting_display.Location = new System.Drawing.Point(474, 420);
            this.button_mca_setting_display.Name = "button_mca_setting_display";
            this.button_mca_setting_display.Size = new System.Drawing.Size(75, 23);
            this.button_mca_setting_display.TabIndex = 28;
            this.button_mca_setting_display.Text = "詳細設定";
            this.button_mca_setting_display.UseVisualStyleBackColor = true;
            this.button_mca_setting_display.Click += new System.EventHandler(this.button_mca_setting_display_Click);
            // 
            // button_MCA_ON
            // 
            this.button_MCA_ON.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_MCA_ON.ForeColor = System.Drawing.Color.Red;
            this.button_MCA_ON.Location = new System.Drawing.Point(313, 562);
            this.button_MCA_ON.Name = "button_MCA_ON";
            this.button_MCA_ON.Size = new System.Drawing.Size(111, 41);
            this.button_MCA_ON.TabIndex = 29;
            this.button_MCA_ON.Text = "MCA ON";
            this.button_MCA_ON.UseVisualStyleBackColor = true;
            this.button_MCA_ON.Click += new System.EventHandler(this.button_MCA_ON_Click);
            // 
            // button_MCA_OFF
            // 
            this.button_MCA_OFF.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_MCA_OFF.ForeColor = System.Drawing.Color.Blue;
            this.button_MCA_OFF.Location = new System.Drawing.Point(313, 609);
            this.button_MCA_OFF.Name = "button_MCA_OFF";
            this.button_MCA_OFF.Size = new System.Drawing.Size(111, 42);
            this.button_MCA_OFF.TabIndex = 30;
            this.button_MCA_OFF.Text = "MCA OFF";
            this.button_MCA_OFF.UseVisualStyleBackColor = true;
            this.button_MCA_OFF.Click += new System.EventHandler(this.button_MCA_OFF_Click);
            // 
            // button_mca_clear
            // 
            this.button_mca_clear.Location = new System.Drawing.Point(487, 469);
            this.button_mca_clear.Name = "button_mca_clear";
            this.button_mca_clear.Size = new System.Drawing.Size(75, 23);
            this.button_mca_clear.TabIndex = 31;
            this.button_mca_clear.Text = "MCAクリア";
            this.button_mca_clear.UseVisualStyleBackColor = true;
            this.button_mca_clear.Click += new System.EventHandler(this.button_mca_clear_Click);
            // 
            // btn_rx_buf_clear
            // 
            this.btn_rx_buf_clear.ForeColor = System.Drawing.Color.Fuchsia;
            this.btn_rx_buf_clear.Location = new System.Drawing.Point(53, 657);
            this.btn_rx_buf_clear.Name = "btn_rx_buf_clear";
            this.btn_rx_buf_clear.Size = new System.Drawing.Size(104, 34);
            this.btn_rx_buf_clear.TabIndex = 32;
            this.btn_rx_buf_clear.Text = "受信バッファをクリア";
            this.btn_rx_buf_clear.UseVisualStyleBackColor = true;
            this.btn_rx_buf_clear.Click += new System.EventHandler(this.btn_rx_buf_clear_Click);
            // 
            // button_adc_setting
            // 
            this.button_adc_setting.Location = new System.Drawing.Point(1322, 490);
            this.button_adc_setting.Name = "button_adc_setting";
            this.button_adc_setting.Size = new System.Drawing.Size(75, 23);
            this.button_adc_setting.TabIndex = 33;
            this.button_adc_setting.Text = "詳細設定";
            this.button_adc_setting.UseVisualStyleBackColor = true;
            this.button_adc_setting.Click += new System.EventHandler(this.button_adc_setting_Click);
            // 
            // panel_adc_setting
            // 
            this.panel_adc_setting.Controls.Add(this.button_close_adc);
            this.panel_adc_setting.Controls.Add(this.button_adc_setting_off);
            this.panel_adc_setting.Controls.Add(this.label6);
            this.panel_adc_setting.Location = new System.Drawing.Point(871, 233);
            this.panel_adc_setting.Name = "panel_adc_setting";
            this.panel_adc_setting.Size = new System.Drawing.Size(314, 225);
            this.panel_adc_setting.TabIndex = 34;
            // 
            // button_close_adc
            // 
            this.button_close_adc.Location = new System.Drawing.Point(158, 187);
            this.button_close_adc.Name = "button_close_adc";
            this.button_close_adc.Size = new System.Drawing.Size(60, 23);
            this.button_close_adc.TabIndex = 29;
            this.button_close_adc.Text = "閉じる";
            this.button_close_adc.UseVisualStyleBackColor = true;
            this.button_close_adc.Click += new System.EventHandler(this.button_close_adc_Click);
            // 
            // button_adc_setting_off
            // 
            this.button_adc_setting_off.Location = new System.Drawing.Point(224, 187);
            this.button_adc_setting_off.Name = "button_adc_setting_off";
            this.button_adc_setting_off.Size = new System.Drawing.Size(75, 23);
            this.button_adc_setting_off.TabIndex = 26;
            this.button_adc_setting_off.Text = "設定を反映";
            this.button_adc_setting_off.UseVisualStyleBackColor = true;
            this.button_adc_setting_off.Click += new System.EventHandler(this.button_adc_setting_off_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(12, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "ADC_詳細設定";
            // 
            // button_csv_out
            // 
            this.button_csv_out.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_csv_out.ForeColor = System.Drawing.Color.Purple;
            this.button_csv_out.Location = new System.Drawing.Point(313, 657);
            this.button_csv_out.Name = "button_csv_out";
            this.button_csv_out.Size = new System.Drawing.Size(111, 34);
            this.button_csv_out.TabIndex = 35;
            this.button_csv_out.Text = "MCAをcsv出力";
            this.button_csv_out.UseVisualStyleBackColor = true;
            this.button_csv_out.Click += new System.EventHandler(this.button_csv_out_Click);
            // 
            // mcu_setting_btn
            // 
            this.mcu_setting_btn.Location = new System.Drawing.Point(559, 15);
            this.mcu_setting_btn.Name = "mcu_setting_btn";
            this.mcu_setting_btn.Size = new System.Drawing.Size(124, 34);
            this.mcu_setting_btn.TabIndex = 38;
            this.mcu_setting_btn.Text = "マイコンの詳細設定";
            this.mcu_setting_btn.UseVisualStyleBackColor = true;
            this.mcu_setting_btn.Click += new System.EventHandler(this.mcu_setting_btn_Click);
            // 
            // mcu_setting_panel
            // 
            this.mcu_setting_panel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mcu_setting_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mcu_setting_panel.Controls.Add(this.clear_one_samplenum_btn);
            this.mcu_setting_panel.Controls.Add(this.clear_thresh_btn);
            this.mcu_setting_panel.Controls.Add(this.label_adc_threshold_dis);
            this.mcu_setting_panel.Controls.Add(this.button_mcu_setting_panel_off);
            this.mcu_setting_panel.Controls.Add(this.button_mcu_setting_on);
            this.mcu_setting_panel.Controls.Add(this.textBox_pulse_num);
            this.mcu_setting_panel.Controls.Add(this.label_adc_sample_num);
            this.mcu_setting_panel.Controls.Add(this.label_adc_threshold);
            this.mcu_setting_panel.Controls.Add(this.textBox_threshold);
            this.mcu_setting_panel.Location = new System.Drawing.Point(3, 3);
            this.mcu_setting_panel.Name = "mcu_setting_panel";
            this.mcu_setting_panel.Size = new System.Drawing.Size(320, 142);
            this.mcu_setting_panel.TabIndex = 40;
            // 
            // clear_one_samplenum_btn
            // 
            this.clear_one_samplenum_btn.Location = new System.Drawing.Point(233, 66);
            this.clear_one_samplenum_btn.Name = "clear_one_samplenum_btn";
            this.clear_one_samplenum_btn.Size = new System.Drawing.Size(56, 23);
            this.clear_one_samplenum_btn.TabIndex = 42;
            this.clear_one_samplenum_btn.Text = "clear";
            this.clear_one_samplenum_btn.UseVisualStyleBackColor = true;
            this.clear_one_samplenum_btn.Click += new System.EventHandler(this.clear_one_samplenum_btn_Click);
            // 
            // clear_thresh_btn
            // 
            this.clear_thresh_btn.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.clear_thresh_btn.Location = new System.Drawing.Point(181, 4);
            this.clear_thresh_btn.Name = "clear_thresh_btn";
            this.clear_thresh_btn.Size = new System.Drawing.Size(56, 23);
            this.clear_thresh_btn.TabIndex = 41;
            this.clear_thresh_btn.Text = "clear";
            this.clear_thresh_btn.UseVisualStyleBackColor = true;
            this.clear_thresh_btn.Click += new System.EventHandler(this.clear_thresh_btn_Click);
            // 
            // label_adc_threshold_dis
            // 
            this.label_adc_threshold_dis.AutoSize = true;
            this.label_adc_threshold_dis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label_adc_threshold_dis.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_adc_threshold_dis.Location = new System.Drawing.Point(180, 39);
            this.label_adc_threshold_dis.Name = "label_adc_threshold_dis";
            this.label_adc_threshold_dis.Size = new System.Drawing.Size(109, 16);
            this.label_adc_threshold_dis.TabIndex = 40;
            this.label_adc_threshold_dis.Text = "0-4095を入力";
            // 
            // button_mcu_setting_panel_off
            // 
            this.button_mcu_setting_panel_off.Location = new System.Drawing.Point(84, 99);
            this.button_mcu_setting_panel_off.Name = "button_mcu_setting_panel_off";
            this.button_mcu_setting_panel_off.Size = new System.Drawing.Size(75, 23);
            this.button_mcu_setting_panel_off.TabIndex = 34;
            this.button_mcu_setting_panel_off.Text = "閉じる";
            this.button_mcu_setting_panel_off.UseVisualStyleBackColor = true;
            this.button_mcu_setting_panel_off.Click += new System.EventHandler(this.button_mcu_setting_panel_off_Click);
            // 
            // button_mcu_setting_on
            // 
            this.button_mcu_setting_on.Location = new System.Drawing.Point(174, 99);
            this.button_mcu_setting_on.Name = "button_mcu_setting_on";
            this.button_mcu_setting_on.Size = new System.Drawing.Size(115, 23);
            this.button_mcu_setting_on.TabIndex = 33;
            this.button_mcu_setting_on.Text = "すべての設定を反映";
            this.button_mcu_setting_on.UseVisualStyleBackColor = true;
            this.button_mcu_setting_on.Click += new System.EventHandler(this.button_mcu_setting_on_Click);
            // 
            // textBox_pulse_num
            // 
            this.textBox_pulse_num.Location = new System.Drawing.Point(154, 66);
            this.textBox_pulse_num.Name = "textBox_pulse_num";
            this.textBox_pulse_num.Size = new System.Drawing.Size(73, 19);
            this.textBox_pulse_num.TabIndex = 32;
            this.textBox_pulse_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_pulse_num_KeyPress);
            // 
            // label_adc_sample_num
            // 
            this.label_adc_sample_num.AutoSize = true;
            this.label_adc_sample_num.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_adc_sample_num.Location = new System.Drawing.Point(25, 66);
            this.label_adc_sample_num.Name = "label_adc_sample_num";
            this.label_adc_sample_num.Size = new System.Drawing.Size(123, 15);
            this.label_adc_sample_num.TabIndex = 31;
            this.label_adc_sample_num.Text = "1パルスのサンプル数";
            // 
            // label_adc_threshold
            // 
            this.label_adc_threshold.AutoSize = true;
            this.label_adc_threshold.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_adc_threshold.Location = new System.Drawing.Point(15, 10);
            this.label_adc_threshold.Name = "label_adc_threshold";
            this.label_adc_threshold.Size = new System.Drawing.Size(81, 14);
            this.label_adc_threshold.TabIndex = 29;
            this.label_adc_threshold.Text = "ADCトリガー";
            this.label_adc_threshold.MouseLeave += new System.EventHandler(this.label_adc_threshold_MouseLeave);
            this.label_adc_threshold.MouseHover += new System.EventHandler(this.label_adc_threshold_MouseHover);
            // 
            // textBox_threshold
            // 
            this.textBox_threshold.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_threshold.Location = new System.Drawing.Point(102, 5);
            this.textBox_threshold.Name = "textBox_threshold";
            this.textBox_threshold.Size = new System.Drawing.Size(73, 21);
            this.textBox_threshold.TabIndex = 30;
            this.textBox_threshold.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_threshold_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(418, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "マイコン設定";
            // 
            // button_autoopen
            // 
            this.button_autoopen.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_autoopen.Location = new System.Drawing.Point(13, 559);
            this.button_autoopen.Name = "button_autoopen";
            this.button_autoopen.Size = new System.Drawing.Size(144, 43);
            this.button_autoopen.TabIndex = 41;
            this.button_autoopen.Text = "STM32と接続";
            this.button_autoopen.UseVisualStyleBackColor = true;
            this.button_autoopen.Click += new System.EventHandler(this.button_autoopen_Click);
            // 
            // button_adcStart
            // 
            this.button_adcStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_adcStart.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_adcStart.Location = new System.Drawing.Point(163, 560);
            this.button_adcStart.Name = "button_adcStart";
            this.button_adcStart.Size = new System.Drawing.Size(144, 42);
            this.button_adcStart.TabIndex = 42;
            this.button_adcStart.Text = "ADCスタート";
            this.button_adcStart.UseVisualStyleBackColor = false;
            this.button_adcStart.Click += new System.EventHandler(this.button_adcStart_Click);
            // 
            // button_adcStop
            // 
            this.button_adcStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_adcStop.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_adcStop.Location = new System.Drawing.Point(163, 608);
            this.button_adcStop.Name = "button_adcStop";
            this.button_adcStop.Size = new System.Drawing.Size(144, 42);
            this.button_adcStop.TabIndex = 43;
            this.button_adcStop.Text = "ADCストップ";
            this.button_adcStop.UseVisualStyleBackColor = false;
            this.button_adcStop.Click += new System.EventHandler(this.button_adcStop_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.mcu_setting_panel);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.mcu_setting_btn);
            this.panel2.Location = new System.Drawing.Point(590, 562);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(823, 152);
            this.panel2.TabIndex = 44;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(1253, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(144, 90);
            this.panel3.TabIndex = 45;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1425, 721);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button_adcStop);
            this.Controls.Add(this.button_adcStart);
            this.Controls.Add(this.button_autoopen);
            this.Controls.Add(this.button_csv_out);
            this.Controls.Add(this.button_mca_clear);
            this.Controls.Add(this.panel_adc_setting);
            this.Controls.Add(this.button_adc_setting);
            this.Controls.Add(this.btn_rx_buf_clear);
            this.Controls.Add(this.comboBox_horizon);
            this.Controls.Add(this.label_chart_res);
            this.Controls.Add(this.button_MCA_OFF);
            this.Controls.Add(this.button_MCA_ON);
            this.Controls.Add(this.button_mca_setting_display);
            this.Controls.Add(this.panel_mca_setting);
            this.Controls.Add(this.button_chart_clear);
            this.Controls.Add(this.label_setting_title);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.chart_MCA);
            this.Controls.Add(this.chart1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "STM32F4series MCAアプリケーション";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_MCA)).EndInit();
            this.panel_mca_setting.ResumeLayout(false);
            this.panel_mca_setting.PerformLayout();
            this.panel_adc_setting.ResumeLayout(false);
            this.panel_adc_setting.PerformLayout();
            this.mcu_setting_panel.ResumeLayout(false);
            this.mcu_setting_panel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboBox_com.Items.Add(port);
            }
            if (comboBox_com.Items.Count > 0)
                comboBox_com.SelectedIndex = 0;
        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private SerialDataReceivedEventHandler serialPort1_DataReceived;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_rxsetting;
        private System.Windows.Forms.ComboBox comboBox_baudrate;
        private System.Windows.Forms.Label label_setting_title;
        private System.Windows.Forms.ComboBox comboBox_BufThresh;
        private System.Windows.Forms.Label label_BufTh;
        private System.Windows.Forms.Button button_chart_clear;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_MCA;
        private System.Windows.Forms.Label label_chart_res;
        private System.Windows.Forms.ComboBox comboBox_horizon;
        private System.Windows.Forms.ComboBox comboBox_adc_res;
        private System.Windows.Forms.Panel panel_mca_setting;
        private System.Windows.Forms.Label label_Pulse_Num;
        private System.Windows.Forms.Label label_mca_specific;
        private System.Windows.Forms.Button button_mca_setting;
        private System.Windows.Forms.Button button_mca_setting_display;
        private System.Windows.Forms.Button button_MCA_ON;
        private System.Windows.Forms.Button button_MCA_OFF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_mca_clear;
        private System.Windows.Forms.ComboBox comboBox_pulse_num;
        private System.Windows.Forms.Button btn_rx_buf_clear;
        private System.Windows.Forms.Button button_adc_setting;
        private System.Windows.Forms.Panel panel_adc_setting;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_adc_setting_off;
        private System.Windows.Forms.Button button_csv_out;
        private System.Windows.Forms.TextBox textBox_csv_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_close_mca;
        private System.Windows.Forms.Button button_close_adc;
        private System.Windows.Forms.Button mcu_setting_btn;
        private System.Windows.Forms.Panel mcu_setting_panel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_mcu_setting_panel_off;
        private System.Windows.Forms.Button button_mcu_setting_on;
        private System.Windows.Forms.TextBox textBox_pulse_num;
        private System.Windows.Forms.Label label_adc_sample_num;
        private System.Windows.Forms.Label label_adc_threshold;
        private System.Windows.Forms.TextBox textBox_threshold;
        private System.Windows.Forms.Label label_adc_threshold_dis;
        private System.Windows.Forms.Button clear_one_samplenum_btn;
        private System.Windows.Forms.Button clear_thresh_btn;
        private System.Windows.Forms.Button button_autoopen;
        private System.Windows.Forms.Button button_adcStart;
        private System.Windows.Forms.Button button_adcStop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

