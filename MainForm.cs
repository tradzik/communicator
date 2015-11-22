/*
The MIT License (MIT)

Copyright (c) 2015 Tymon Radzik

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/ 
using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Threading;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace COMmunicator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        string port = GlobalValues.portName;

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!File.Exists("MResults.log")) { using (var myFile = File.Create("MResults.log")) { } }
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            //to prevent rescaling the window

            l_port.Text = port; //port name in bottom of form
            serialPort.PortName = port; //port name to port handler 
        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            serialPort.Close();
            Application.Exit(); // turns application off
        }

        private void b_conn_Click(object sender, EventArgs e)
        {
            int baud = 0;

            try
            {

                baud = Int32.Parse(t_baud.Text);
            }
            catch
            {
                MessageBox.Show("ERROR during parsing baud rate to integer!");
                return;
            }

            try
            {
                serialPort.BaudRate = baud;
            }
            catch
            {
                MessageBox.Show("Baud rate you entered is improper!");
            }

            try
            {
                serialPort.Open();
            }
            catch
            {
                MessageBox.Show("ERROR: Unable to connect to the port!");
                return;
            }

            if (serialPort.IsOpen)
            {
                b_conn.Enabled = false;
                t_baud.Enabled = false;
                l_connected.Visible = true;
                g_conntools.Enabled = true;
            }

        }

        private void t_baud_KeyPress(object sender, KeyPressEventArgs e)
        {
            //baud only numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void b_sendsignal_Click(object sender, EventArgs e)
        {
            serialPort.Write("x");
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string bstr = serialPort.ReadTo("\n");
                ushort number = Convert.ToUInt16(bstr);
                t_value.Text = number.ToString();
                float f = Convert.ToSingle(number);
                f *= 20;
                f /= 16383;
                f -= 10;
                t_inch.Text = f.ToString();
                f *= (float)249.089;
                f /= (float)8.026216;
                t_mm.Text = f.ToString();
                serialPort.DiscardInBuffer();

            }
            catch (Exception ex)
            {
                MessageBox.Show("I met this error: " + ex.Message + " - tell that to Tymon");
            }
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            if (t_value.Text == "")
            {
                MessageBox.Show("No measurement has been made yet!");
                return;
            }

            using (StreamWriter sw = File.AppendText("MResults.log"))
            {
                sw.WriteLine("[" + DateTime.Now + "]");
                sw.WriteLine();
                sw.WriteLine("raw value: " + t_value.Text);
                sw.WriteLine("inch liquid: " + t_inch.Text);
                sw.WriteLine("mm liquid: " + t_mm.Text);
                sw.WriteLine();
                sw.WriteLine("notes:");
                sw.WriteLine(t_note.Text);
                sw.WriteLine();
                sw.WriteLine("*********************");
                sw.WriteLine();
            }

        }


        //
        //
        //
        //
        //

    }
}
