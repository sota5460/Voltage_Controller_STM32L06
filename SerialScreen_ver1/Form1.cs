


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Diagnostics;




namespace SerialScreen_ver1
{
    


    public partial class Form1 : Form
    {

        public int b_rate = 0;
        public int rx_setting = 0; // 0: 指定バイトで読み取り 1:改行コードまで読み取り 2: 1バイトだけ読み取り
        public int buf_thresh_setting = 0;

        public bool Amp_flag = false;

        public string Code_SWOn = "G";
        public string Code_SWoff = "H";
        public string Code_Dac_1byte = "N";
        public string Code_LEDOn = "D";
        public string Code_LEDOff = "E";

        public byte[] Code_Dac_1byte_bin = { 0x4e,0};

        public int zero_Vcon = (int)(255 * (1.6 / 3.3));

        public long slope = 500;
        public long intercept = -400;



        public Form1()
        {
            //short_buf_init();
            InitializeComponent();
            init_manual();

            //グラフの初期化しなくても動作するけど、これしとかないとグラフが真っ白になって見た目がよくない。


            
        }

        public void init_manual()
        {
 

        }




        private void button_autoopen_Click(object sender, EventArgs e)
        {
            MySerialPort sp_ = new MySerialPort(serialPort1);
            AutoSelect comAuto = new AutoSelect("stm32f4", sp_);

            if (serialPort1.IsOpen == false)
            {
                MessageBox.Show("STM32が見つかりません。");
                return;
            }


            button_autoopen.Enabled = false;

        }

        private void button_close_Click(object sender, EventArgs e)
        {
           

            serialPort1.DiscardInBuffer();
            Shutdown_Voltage();

            serialPort1.Close();

            button_autoopen.Enabled = true;


        }








        private void button_VoltageON_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                MessageBox.Show("stm32L06seriesを接続してください。");
                return;
            }

            try
            {
                if (int.Parse(textBox_VoltageOut.Text) > 2000) { };
            }
            catch
            {
                MessageBox.Show("値が不正です。");
                return;
            }


            if (int.Parse(textBox_VoltageOut.Text) > 2000)
            {
                //メッセージボックスを表示する
                DialogResult result = MessageBox.Show("印可電圧が2000Vを超えます。続行しますか？",
                    "確認",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2);

                //何が選択されたか調べる
                if (result == DialogResult.Yes)
                {
                    //「はい」が選択された時
                    //Console.WriteLine("「はい」が選択されました");
                }
                else if (result == DialogResult.No)
                {
                    //「いいえ」が選択された時
                    //Console.WriteLine("「いいえ」が選択されました");
                    return;
                }
                else if (result == DialogResult.Cancel)
                {
                    //「キャンセル」が選択された時
                    //Console.WriteLine("「キャンセル」が選択されました");
                    return;
                }
            }


            //ascii();
            if (Amp_flag==false)
            {
                float Vcon = 0;

                try
                {
                     Vcon = (float.Parse(textBox_VoltageOut.Text) - 400) / (500);
                }
                catch
                {
                    MessageBox.Show("値が不正です。");
                    return;
                }

                //出力が0VになるVconを先に出しておく。
                serialPort1.Write(Code_Dac_1byte + (char)zero_Vcon);
                System.Threading.Thread.Sleep(100);

                //アンプをオンにする。
                serialPort1.Write(Code_SWOn);

                //出力したいVconを出力する。
                int Vcon_255bit = (int)(255 * (Vcon / (float)3.3));
                //byte列に直す（int型変換の場合、4byteに変換するので、通信には0番目だけ使う）
                byte[] Vcon_Bin = BitConverter.GetBytes(Vcon_255bit);

                //string Code_DAC = Code_Dac_1byte + (char)Vcon_255bit;
                byte[] Code_DAC = { 0x4e, Vcon_Bin[0] };


                serialPort1.Write(Code_DAC,0,2);

                Amp_flag = true;
                System.Threading.Thread.Sleep(100);



            }
            else
            {
                float Vcon = 0;

                try
                {
                    Vcon = (float.Parse(textBox_VoltageOut.Text) - 400) / (500);
                }
                catch
                {
                    MessageBox.Show("値が不正です。");
                    return;
                }

                //出力したいVconを出力する。
                int Vcon_255bit = (int)(255 * (Vcon / (float)3.3));
                //byte列に直す（int型変換の場合、4byteに変換するので、通信には0番目だけ使う）
                byte[] Vcon_Bin = BitConverter.GetBytes(Vcon_255bit); 

                //string Code_DAC = Code_Dac_1byte + (char)Vcon_255bit;
                byte[] Code_DAC = { 0x4e, Vcon_Bin[0] };


                serialPort1.Write(Code_DAC, 0, 2);

            }

            textBox_voltageDisaplay.Text = textBox_VoltageOut.Text + "V";
        }

        private void button_voltageOFF_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                MessageBox.Show("stm32L06seriesを接続してください。");
                return;
            }

            if(Amp_flag == true)
            {
                serialPort1.Write(Code_SWoff);
                textBox_voltageDisaplay.Text = "0V";
                Amp_flag = false;
            }
        }

        public void Shutdown_Voltage()
        {
            serialPort1.Write(Code_SWoff);
            Amp_flag = false;
            textBox_voltageDisaplay.Text = "OFF";
        }

        private void ascii()
        {
            for(int i = 0; i < 256; i++)
            {
                char ascii = (char)i;
                string aaa = i.ToString() + "is" + ascii;
                Debug.Print(aaa);
            }
        }

        private void button_LED_ON_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen == false)
            {
                MessageBox.Show("stm32L06seriesを接続してください。");
                return;
            }
            serialPort1.Write(Code_LEDOn);
        }

        private void button_LED_OFF_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                MessageBox.Show("stm32L06seriesを接続してください。");
                return;
            }
            serialPort1.Write(Code_LEDOff);
        }

        private void button_100up_Click(object sender, EventArgs e)
        {
            int current_voltage = 0;
            try
            {
                current_voltage = int.Parse(textBox_VoltageOut.Text);
            }
            catch
            {
                MessageBox.Show("値が不正です。");
                return;
            }

            current_voltage +=100;
            if (current_voltage > 2000)
            {
                //メッセージボックスを表示する
                DialogResult result = MessageBox.Show("印可電圧が2000Vを超えます。続行しますか？",
                    "確認",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2);

                //何が選択されたか調べる
                if (result == DialogResult.Yes)
                {
                    //「はい」が選択された時
                   // Console.WriteLine("「はい」が選択されました");
                }
                else if (result == DialogResult.No)
                {
                    //「いいえ」が選択された時
                    //Console.WriteLine("「いいえ」が選択されました");
                    return;
                }
                else if (result == DialogResult.Cancel)
                {
                    //「キャンセル」が選択された時
                    //Console.WriteLine("「キャンセル」が選択されました");
                    return;
                }
            }

            textBox_VoltageOut.Text=current_voltage.ToString();
        }

        private void button_100down_Click(object sender, EventArgs e)
        {
            int current_voltage = 0;
            try
            {
                current_voltage = int.Parse(textBox_VoltageOut.Text);
            }
            catch
            {
                MessageBox.Show("値が不正です。");
                return;
            }
            
            current_voltage -=100;

            if (current_voltage < 0)
            {
                return;
            }
            textBox_VoltageOut.Text = current_voltage.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Amp_flag)
            {
                //メッセージボックスを表示する
                DialogResult result = MessageBox.Show("電圧が印可しています。このままソフトを閉じますか？",
                    "確認",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2);

                //何が選択されたか調べる
                if (result == DialogResult.Yes)
                {
                    //「はい」が選択された時
                    // Console.WriteLine("「はい」が選択されました");
                }
                else if (result == DialogResult.No)
                {
                    //「いいえ」が選択された時
                    //Console.WriteLine("「いいえ」が選択されました");
                    e.Cancel = true;
                    return;
                }
                else if (result == DialogResult.Cancel)
                {
                    //「キャンセル」が選択された時
                    //Console.WriteLine("「キャンセル」が選択されました");
                    e.Cancel = true;
                    return;
                }
            }
            else
            {
                //dac出力を０にして終了する。
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(Code_Dac_1byte_bin, 0, 2);
                    serialPort1.Close();
                }
               
            }
        }


    }

    
}
