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

namespace COMmunicator
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.b_exit = new System.Windows.Forms.Button();
            this.l_connection = new System.Windows.Forms.Label();
            this.l_port = new System.Windows.Forms.Label();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.l_baud = new System.Windows.Forms.Label();
            this.t_baud = new System.Windows.Forms.TextBox();
            this.b_conn = new System.Windows.Forms.Button();
            this.g_conntools = new System.Windows.Forms.GroupBox();
            this.b_save = new System.Windows.Forms.Button();
            this.l_mm = new System.Windows.Forms.Label();
            this.l_inch = new System.Windows.Forms.Label();
            this.l_value = new System.Windows.Forms.Label();
            this.t_mm = new System.Windows.Forms.TextBox();
            this.t_inch = new System.Windows.Forms.TextBox();
            this.t_value = new System.Windows.Forms.TextBox();
            this.l_split1 = new System.Windows.Forms.Label();
            this.t_note = new System.Windows.Forms.TextBox();
            this.l_notes = new System.Windows.Forms.Label();
            this.l_answer = new System.Windows.Forms.Label();
            this.b_sendsignal = new System.Windows.Forms.Button();
            this.l_connected = new System.Windows.Forms.Label();
            this.g_conntools.SuspendLayout();
            this.SuspendLayout();
            // 
            // b_exit
            // 
            this.b_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_exit.Location = new System.Drawing.Point(490, 403);
            this.b_exit.Name = "b_exit";
            this.b_exit.Size = new System.Drawing.Size(86, 23);
            this.b_exit.TabIndex = 0;
            this.b_exit.Text = "Exit";
            this.b_exit.UseVisualStyleBackColor = true;
            this.b_exit.Click += new System.EventHandler(this.b_exit_Click);
            // 
            // l_connection
            // 
            this.l_connection.AutoSize = true;
            this.l_connection.Location = new System.Drawing.Point(12, 408);
            this.l_connection.Name = "l_connection";
            this.l_connection.Size = new System.Drawing.Size(180, 13);
            this.l_connection.TabIndex = 1;
            this.l_connection.Text = "You are currently connected to port: ";
            // 
            // l_port
            // 
            this.l_port.AutoSize = true;
            this.l_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_port.Location = new System.Drawing.Point(209, 408);
            this.l_port.Name = "l_port";
            this.l_port.Size = new System.Drawing.Size(0, 13);
            this.l_port.TabIndex = 2;
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // l_baud
            // 
            this.l_baud.AutoSize = true;
            this.l_baud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_baud.Location = new System.Drawing.Point(11, 9);
            this.l_baud.Name = "l_baud";
            this.l_baud.Size = new System.Drawing.Size(438, 20);
            this.l_baud.TabIndex = 3;
            this.l_baud.Text = "Please specify baud rate of device connected to chosen port:";
            // 
            // t_baud
            // 
            this.t_baud.Location = new System.Drawing.Point(476, 9);
            this.t_baud.MaxLength = 6;
            this.t_baud.Name = "t_baud";
            this.t_baud.Size = new System.Drawing.Size(100, 20);
            this.t_baud.TabIndex = 4;
            this.t_baud.Text = "9600";
            this.t_baud.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_baud_KeyPress);
            // 
            // b_conn
            // 
            this.b_conn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_conn.Location = new System.Drawing.Point(476, 36);
            this.b_conn.Name = "b_conn";
            this.b_conn.Size = new System.Drawing.Size(100, 23);
            this.b_conn.TabIndex = 5;
            this.b_conn.Text = "Connect";
            this.b_conn.UseVisualStyleBackColor = true;
            this.b_conn.Click += new System.EventHandler(this.b_conn_Click);
            // 
            // g_conntools
            // 
            this.g_conntools.Controls.Add(this.b_save);
            this.g_conntools.Controls.Add(this.l_mm);
            this.g_conntools.Controls.Add(this.l_inch);
            this.g_conntools.Controls.Add(this.l_value);
            this.g_conntools.Controls.Add(this.t_mm);
            this.g_conntools.Controls.Add(this.t_inch);
            this.g_conntools.Controls.Add(this.t_value);
            this.g_conntools.Controls.Add(this.l_split1);
            this.g_conntools.Controls.Add(this.t_note);
            this.g_conntools.Controls.Add(this.l_notes);
            this.g_conntools.Controls.Add(this.l_answer);
            this.g_conntools.Controls.Add(this.b_sendsignal);
            this.g_conntools.Enabled = false;
            this.g_conntools.Location = new System.Drawing.Point(15, 65);
            this.g_conntools.Name = "g_conntools";
            this.g_conntools.Size = new System.Drawing.Size(561, 332);
            this.g_conntools.TabIndex = 6;
            this.g_conntools.TabStop = false;
            this.g_conntools.Text = "Connection tools";
            // 
            // b_save
            // 
            this.b_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_save.Location = new System.Drawing.Point(10, 66);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(167, 60);
            this.b_save.TabIndex = 13;
            this.b_save.Text = "Save results to file!";
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // l_mm
            // 
            this.l_mm.AutoSize = true;
            this.l_mm.Location = new System.Drawing.Point(163, 266);
            this.l_mm.Name = "l_mm";
            this.l_mm.Size = new System.Drawing.Size(63, 13);
            this.l_mm.TabIndex = 12;
            this.l_mm.Text = "Liquid (mm):";
            // 
            // l_inch
            // 
            this.l_inch.AutoSize = true;
            this.l_inch.Location = new System.Drawing.Point(159, 222);
            this.l_inch.Name = "l_inch";
            this.l_inch.Size = new System.Drawing.Size(61, 13);
            this.l_inch.TabIndex = 11;
            this.l_inch.Text = "H2O (inch):";
            // 
            // l_value
            // 
            this.l_value.AutoSize = true;
            this.l_value.Location = new System.Drawing.Point(159, 179);
            this.l_value.Name = "l_value";
            this.l_value.Size = new System.Drawing.Size(61, 13);
            this.l_value.TabIndex = 10;
            this.l_value.Text = "Raw value:";
            // 
            // t_mm
            // 
            this.t_mm.Location = new System.Drawing.Point(257, 263);
            this.t_mm.Name = "t_mm";
            this.t_mm.ReadOnly = true;
            this.t_mm.Size = new System.Drawing.Size(146, 20);
            this.t_mm.TabIndex = 9;
            // 
            // t_inch
            // 
            this.t_inch.Location = new System.Drawing.Point(257, 219);
            this.t_inch.Name = "t_inch";
            this.t_inch.ReadOnly = true;
            this.t_inch.Size = new System.Drawing.Size(146, 20);
            this.t_inch.TabIndex = 8;
            // 
            // t_value
            // 
            this.t_value.Location = new System.Drawing.Point(257, 176);
            this.t_value.Name = "t_value";
            this.t_value.ReadOnly = true;
            this.t_value.Size = new System.Drawing.Size(146, 20);
            this.t_value.TabIndex = 7;
            // 
            // l_split1
            // 
            this.l_split1.AutoSize = true;
            this.l_split1.Location = new System.Drawing.Point(99, 124);
            this.l_split1.Name = "l_split1";
            this.l_split1.Size = new System.Drawing.Size(355, 13);
            this.l_split1.TabIndex = 6;
            this.l_split1.Text = "__________________________________________________________";
            // 
            // t_note
            // 
            this.t_note.Location = new System.Drawing.Point(322, 67);
            this.t_note.MaxLength = 255;
            this.t_note.Multiline = true;
            this.t_note.Name = "t_note";
            this.t_note.Size = new System.Drawing.Size(233, 54);
            this.t_note.TabIndex = 5;
            // 
            // l_notes
            // 
            this.l_notes.AutoSize = true;
            this.l_notes.Location = new System.Drawing.Point(182, 70);
            this.l_notes.Name = "l_notes";
            this.l_notes.Size = new System.Drawing.Size(134, 13);
            this.l_notes.TabIndex = 4;
            this.l_notes.Text = "Notes about measurement:";
            // 
            // l_answer
            // 
            this.l_answer.AutoSize = true;
            this.l_answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_answer.Location = new System.Drawing.Point(6, 146);
            this.l_answer.Name = "l_answer";
            this.l_answer.Size = new System.Drawing.Size(104, 13);
            this.l_answer.TabIndex = 2;
            this.l_answer.Text = "Device\'s answer:";
            // 
            // b_sendsignal
            // 
            this.b_sendsignal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_sendsignal.Location = new System.Drawing.Point(6, 30);
            this.b_sendsignal.Name = "b_sendsignal";
            this.b_sendsignal.Size = new System.Drawing.Size(549, 30);
            this.b_sendsignal.TabIndex = 0;
            this.b_sendsignal.Text = "Send measurement signal! ";
            this.b_sendsignal.UseVisualStyleBackColor = true;
            this.b_sendsignal.Click += new System.EventHandler(this.b_sendsignal_Click);
            // 
            // l_connected
            // 
            this.l_connected.AutoSize = true;
            this.l_connected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_connected.ForeColor = System.Drawing.Color.Green;
            this.l_connected.Location = new System.Drawing.Point(327, 406);
            this.l_connected.Name = "l_connected";
            this.l_connected.Size = new System.Drawing.Size(157, 15);
            this.l_connected.TabIndex = 7;
            this.l_connected.Text = "CONNECTION OPENED";
            this.l_connected.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 438);
            this.Controls.Add(this.l_connected);
            this.Controls.Add(this.g_conntools);
            this.Controls.Add(this.b_conn);
            this.Controls.Add(this.t_baud);
            this.Controls.Add(this.l_baud);
            this.Controls.Add(this.l_port);
            this.Controls.Add(this.l_connection);
            this.Controls.Add(this.b_exit);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COMmunicator - tool to gather data from COM ports";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.g_conntools.ResumeLayout(false);
            this.g_conntools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_exit;
        private System.Windows.Forms.Label l_connection;
        private System.Windows.Forms.Label l_port;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Label l_baud;
        private System.Windows.Forms.TextBox t_baud;
        private System.Windows.Forms.Button b_conn;
        private System.Windows.Forms.GroupBox g_conntools;
        private System.Windows.Forms.Label l_connected;
        private System.Windows.Forms.Button b_sendsignal;
        private System.Windows.Forms.Label l_answer;
        private System.Windows.Forms.Label l_split1;
        private System.Windows.Forms.TextBox t_note;
        private System.Windows.Forms.Label l_notes;
        private System.Windows.Forms.Label l_inch;
        private System.Windows.Forms.Label l_value;
        private System.Windows.Forms.TextBox t_mm;
        private System.Windows.Forms.TextBox t_inch;
        private System.Windows.Forms.TextBox t_value;
        private System.Windows.Forms.Label l_mm;
        private System.Windows.Forms.Button b_save;
    }
}

