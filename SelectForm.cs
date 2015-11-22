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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace COMmunicator
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            //prevent rescaling window

            refreshList(); //get list on start
        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //close app
        }

        private void b_refresh_Click(object sender, EventArgs e)
        {
            refreshList(); //calling refreshing
        }

        private void refreshList()
        {
            c_port.Items.Clear(); //remove old ports

            string[] list = SerialPort.GetPortNames(); //getting list of ports
            foreach (string port in list) //iterate for ports in list
            {
                c_port.Items.Add(port);
            }
        }

        private void b_select_Click(object sender, EventArgs e)
        {
            string chosenPort = c_port.Text;

            l_portnomore.Visible = false;
            this.Enabled = false; //prevent changes to form
            refreshList();

            if (c_port.Items.Contains(chosenPort)) //determine if port is still available
            {
                GlobalValues.portName = chosenPort; //save port name to GlobalVars

                DialogResult = DialogResult.OK;
                Close(); //select dialog result and finish form job
            }
            else //if port exists never more - show error message
            {
                l_portnomore.Visible = true;
                this.Enabled = true;
            }
                
        }
    }
}
