
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button_close = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_LED_ON = new System.Windows.Forms.Button();
            this.button_LED_OFF = new System.Windows.Forms.Button();
            this.button_autoopen = new System.Windows.Forms.Button();
            this.timer_stopwatch = new System.Windows.Forms.Timer(this.components);
            this.button_VoltageON = new System.Windows.Forms.Button();
            this.textBox_VoltageOut = new System.Windows.Forms.TextBox();
            this.button_100up = new System.Windows.Forms.Button();
            this.button_100down = new System.Windows.Forms.Button();
            this.textBox_voltageDisaplay = new System.Windows.Forms.TextBox();
            this.button_voltageOFF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.ReadBufferSize = 50000;
            this.serialPort1.ReadTimeout = 1000;
            this.serialPort1.ReceivedBytesThreshold = 200;
            // 
            // button_close
            // 
            this.button_close.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_close.Location = new System.Drawing.Point(12, 61);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(144, 42);
            this.button_close.TabIndex = 2;
            this.button_close.Text = "接続を解除";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // button_LED_ON
            // 
            this.button_LED_ON.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_LED_ON.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_LED_ON.Location = new System.Drawing.Point(12, 112);
            this.button_LED_ON.Name = "button_LED_ON";
            this.button_LED_ON.Size = new System.Drawing.Size(111, 41);
            this.button_LED_ON.TabIndex = 29;
            this.button_LED_ON.Text = "LED ON";
            this.button_LED_ON.UseVisualStyleBackColor = true;
            this.button_LED_ON.Click += new System.EventHandler(this.button_LED_ON_Click);
            // 
            // button_LED_OFF
            // 
            this.button_LED_OFF.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_LED_OFF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_LED_OFF.Location = new System.Drawing.Point(12, 159);
            this.button_LED_OFF.Name = "button_LED_OFF";
            this.button_LED_OFF.Size = new System.Drawing.Size(111, 42);
            this.button_LED_OFF.TabIndex = 30;
            this.button_LED_OFF.Text = "LED OFF";
            this.button_LED_OFF.UseVisualStyleBackColor = true;
            this.button_LED_OFF.Click += new System.EventHandler(this.button_LED_OFF_Click);
            // 
            // button_autoopen
            // 
            this.button_autoopen.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_autoopen.Location = new System.Drawing.Point(12, 12);
            this.button_autoopen.Name = "button_autoopen";
            this.button_autoopen.Size = new System.Drawing.Size(144, 43);
            this.button_autoopen.TabIndex = 41;
            this.button_autoopen.Text = "STM32と接続";
            this.button_autoopen.UseVisualStyleBackColor = true;
            this.button_autoopen.Click += new System.EventHandler(this.button_autoopen_Click);
            // 
            // timer_stopwatch
            // 
            this.timer_stopwatch.Interval = 1000;
            // 
            // button_VoltageON
            // 
            this.button_VoltageON.Font = new System.Drawing.Font("MS UI Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_VoltageON.Location = new System.Drawing.Point(381, 13);
            this.button_VoltageON.Name = "button_VoltageON";
            this.button_VoltageON.Size = new System.Drawing.Size(92, 61);
            this.button_VoltageON.TabIndex = 42;
            this.button_VoltageON.Text = "ON";
            this.button_VoltageON.UseVisualStyleBackColor = true;
            this.button_VoltageON.Click += new System.EventHandler(this.button_VoltageON_Click);
            // 
            // textBox_VoltageOut
            // 
            this.textBox_VoltageOut.Font = new System.Drawing.Font("MS UI Gothic", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_VoltageOut.Location = new System.Drawing.Point(190, 13);
            this.textBox_VoltageOut.Name = "textBox_VoltageOut";
            this.textBox_VoltageOut.Size = new System.Drawing.Size(185, 61);
            this.textBox_VoltageOut.TabIndex = 43;
            this.textBox_VoltageOut.Text = "0";
            // 
            // button_100up
            // 
            this.button_100up.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_100up.ForeColor = System.Drawing.Color.Red;
            this.button_100up.Location = new System.Drawing.Point(190, 80);
            this.button_100up.Name = "button_100up";
            this.button_100up.Size = new System.Drawing.Size(88, 41);
            this.button_100up.TabIndex = 44;
            this.button_100up.Text = "100▲";
            this.button_100up.UseVisualStyleBackColor = true;
            this.button_100up.Click += new System.EventHandler(this.button_100up_Click);
            // 
            // button_100down
            // 
            this.button_100down.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_100down.ForeColor = System.Drawing.Color.Blue;
            this.button_100down.Location = new System.Drawing.Point(287, 80);
            this.button_100down.Name = "button_100down";
            this.button_100down.Size = new System.Drawing.Size(88, 41);
            this.button_100down.TabIndex = 45;
            this.button_100down.Text = "100▼";
            this.button_100down.UseVisualStyleBackColor = true;
            this.button_100down.Click += new System.EventHandler(this.button_100down_Click);
            // 
            // textBox_voltageDisaplay
            // 
            this.textBox_voltageDisaplay.BackColor = System.Drawing.Color.Black;
            this.textBox_voltageDisaplay.Font = new System.Drawing.Font("MS UI Gothic", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_voltageDisaplay.ForeColor = System.Drawing.Color.Chartreuse;
            this.textBox_voltageDisaplay.Location = new System.Drawing.Point(190, 140);
            this.textBox_voltageDisaplay.Name = "textBox_voltageDisaplay";
            this.textBox_voltageDisaplay.Size = new System.Drawing.Size(185, 61);
            this.textBox_voltageDisaplay.TabIndex = 46;
            this.textBox_voltageDisaplay.Text = "OFF";
            // 
            // button_voltageOFF
            // 
            this.button_voltageOFF.Font = new System.Drawing.Font("MS UI Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_voltageOFF.Location = new System.Drawing.Point(381, 80);
            this.button_voltageOFF.Name = "button_voltageOFF";
            this.button_voltageOFF.Size = new System.Drawing.Size(92, 61);
            this.button_voltageOFF.TabIndex = 47;
            this.button_voltageOFF.Text = "OFF";
            this.button_voltageOFF.UseVisualStyleBackColor = true;
            this.button_voltageOFF.Click += new System.EventHandler(this.button_voltageOFF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(516, 219);
            this.Controls.Add(this.button_voltageOFF);
            this.Controls.Add(this.textBox_voltageDisaplay);
            this.Controls.Add(this.button_100down);
            this.Controls.Add(this.button_100up);
            this.Controls.Add(this.textBox_VoltageOut);
            this.Controls.Add(this.button_VoltageON);
            this.Controls.Add(this.button_autoopen);
            this.Controls.Add(this.button_LED_OFF);
            this.Controls.Add(this.button_LED_ON);
            this.Controls.Add(this.button_close);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "STM32L06series 高圧電源コントローラー";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           


        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private SerialDataReceivedEventHandler serialPort1_DataReceived;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_LED_ON;
        private System.Windows.Forms.Button button_LED_OFF;
        private System.Windows.Forms.Button button_autoopen;
        private System.Windows.Forms.Timer timer_stopwatch;
        private System.Windows.Forms.Button button_VoltageON;
        private System.Windows.Forms.TextBox textBox_VoltageOut;
        private System.Windows.Forms.Button button_100up;
        private System.Windows.Forms.Button button_100down;
        private System.Windows.Forms.TextBox textBox_voltageDisaplay;
        private System.Windows.Forms.Button button_voltageOFF;
    }
}

