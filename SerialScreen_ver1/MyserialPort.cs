using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.IO.Ports;

namespace SerialScreen_ver1
{
    public class MySerialPort
    {
        public SerialPort SrPort { get; private set; }

        public MySerialPort(SerialPort port) { SrPort = port; }

        // open serial port
        public bool Open(string name)
        {
            SrPort.PortName = ComPort.GetNumber(name);
            try
            {
                SrPort.Open();
                return true;
            }
            catch
            {
                System.Threading.Thread.Sleep(50);
                return false;
            }
        }

        //send string to com port
        public void SendTo(string str)
        {
            try { SrPort.Write(str + "\r"); }
            catch (Exception ex) { ExceptionCatch(ex); }
        }

        public void ExceptionCatch(Exception ex)
        {
#if DEBUG
            MessageBox.Show(ex.Message + "," + ex.Source + "," + ex.TargetSite.ToString());
#endif
        }
    }
}
