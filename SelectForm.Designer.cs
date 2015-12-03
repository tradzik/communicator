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
    partial class SelectForm
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
            this.l_select = new System.Windows.Forms.Label();
            this.b_exit = new System.Windows.Forms.Button();
            this.b_select = new System.Windows.Forms.Button();
            this.b_refresh = new System.Windows.Forms.Button();
            this.l_choice = new System.Windows.Forms.Label();
            this.c_port = new System.Windows.Forms.ComboBox();
            this.l_portnomore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l_select
            // 
            this.l_select.AutoSize = true;
            this.l_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.l_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_select.Location = new System.Drawing.Point(54, 38);
            this.l_select.Name = "l_select";
            this.l_select.Size = new System.Drawing.Size(375, 16);
            this.l_select.TabIndex = 0;
            this.l_select.Text = "Please select COM port, which will be used for communication:";
            // 
            // b_exit
            // 
            this.b_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_exit.Location = new System.Drawing.Point(12, 228);
            this.b_exit.Name = "b_exit";
            this.b_exit.Size = new System.Drawing.Size(441, 23);
            this.b_exit.TabIndex = 1;
            this.b_exit.Text = "Cancel";
            this.b_exit.UseVisualStyleBackColor = true;
            this.b_exit.Click += new System.EventHandler(this.b_exit_Click);
            // 
            // b_select
            // 
            this.b_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_select.Location = new System.Drawing.Point(12, 190);
            this.b_select.Name = "b_select";
            this.b_select.Size = new System.Drawing.Size(441, 32);
            this.b_select.TabIndex = 2;
            this.b_select.Text = "Select and start COMmunicator!";
            this.b_select.UseVisualStyleBackColor = true;
            this.b_select.Click += new System.EventHandler(this.b_select_Click);
            // 
            // b_refresh
            // 
            this.b_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_refresh.Location = new System.Drawing.Point(12, 12);
            this.b_refresh.Name = "b_refresh";
            this.b_refresh.Size = new System.Drawing.Size(98, 23);
            this.b_refresh.TabIndex = 3;
            this.b_refresh.Text = "Refresh list";
            this.b_refresh.UseVisualStyleBackColor = true;
            this.b_refresh.Click += new System.EventHandler(this.b_refresh_Click);
            // 
            // l_choice
            // 
            this.l_choice.AutoSize = true;
            this.l_choice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_choice.Location = new System.Drawing.Point(117, 104);
            this.l_choice.Name = "l_choice";
            this.l_choice.Size = new System.Drawing.Size(66, 18);
            this.l_choice.TabIndex = 4;
            this.l_choice.Text = "Choice:";
            // 
            // c_port
            // 
            this.c_port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c_port.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c_port.FormattingEnabled = true;
            this.c_port.Location = new System.Drawing.Point(222, 105);
            this.c_port.Name = "c_port";
            this.c_port.Size = new System.Drawing.Size(121, 21);
            this.c_port.TabIndex = 5;
            // 
            // l_portnomore
            // 
            this.l_portnomore.AutoSize = true;
            this.l_portnomore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_portnomore.ForeColor = System.Drawing.Color.Red;
            this.l_portnomore.Location = new System.Drawing.Point(102, 149);
            this.l_portnomore.Name = "l_portnomore";
            this.l_portnomore.Size = new System.Drawing.Size(273, 16);
            this.l_portnomore.TabIndex = 6;
            this.l_portnomore.Text = "This port seems to be accesible never more!";
            this.l_portnomore.Visible = false;
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 265);
            this.Controls.Add(this.l_portnomore);
            this.Controls.Add(this.c_port);
            this.Controls.Add(this.l_choice);
            this.Controls.Add(this.b_refresh);
            this.Controls.Add(this.b_select);
            this.Controls.Add(this.b_exit);
            this.Controls.Add(this.l_select);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Select COM port - COMmunicator ";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SelectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_select;
        private System.Windows.Forms.Button b_exit;
        private System.Windows.Forms.Button b_select;
        private System.Windows.Forms.Button b_refresh;
        private System.Windows.Forms.Label l_choice;
        private System.Windows.Forms.ComboBox c_port;
        private System.Windows.Forms.Label l_portnomore;
    }
}