
namespace Com_test
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
            this.components = new System.ComponentModel.Container();
            this.Connection = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cBox_DataBit = new System.Windows.Forms.ComboBox();
            this.cBox_Parity = new System.Windows.Forms.ComboBox();
            this.cBox_StopBit = new System.Windows.Forms.ComboBox();
            this.cBox_BaudRate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBox_port = new System.Windows.Forms.ComboBox();
            this.btn_Disconnect = new System.Windows.Forms.Button();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressbar = new System.Windows.Forms.ProgressBar();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Status_lable = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBox_E2 = new System.Windows.Forms.TextBox();
            this.txtBox_E1 = new System.Windows.Forms.TextBox();
            this.txtBox_A4 = new System.Windows.Forms.TextBox();
            this.txtBox_A3 = new System.Windows.Forms.TextBox();
            this.txtBox_A2 = new System.Windows.Forms.TextBox();
            this.txtBox_A1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Connection.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Connection
            // 
            this.Connection.Controls.Add(this.label7);
            this.Connection.Controls.Add(this.label6);
            this.Connection.Controls.Add(this.label5);
            this.Connection.Controls.Add(this.label4);
            this.Connection.Controls.Add(this.cBox_DataBit);
            this.Connection.Controls.Add(this.cBox_Parity);
            this.Connection.Controls.Add(this.cBox_StopBit);
            this.Connection.Controls.Add(this.cBox_BaudRate);
            this.Connection.Controls.Add(this.label1);
            this.Connection.Controls.Add(this.cBox_port);
            this.Connection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connection.Location = new System.Drawing.Point(21, 23);
            this.Connection.Name = "Connection";
            this.Connection.Size = new System.Drawing.Size(443, 254);
            this.Connection.TabIndex = 0;
            this.Connection.TabStop = false;
            this.Connection.Text = "Port Porperties";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Parity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "StopBit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "DataBit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "BaudRate";
            // 
            // cBox_DataBit
            // 
            this.cBox_DataBit.AllowDrop = true;
            this.cBox_DataBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_DataBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox_DataBit.FormattingEnabled = true;
            this.cBox_DataBit.Items.AddRange(new object[] {
            "7",
            "8"});
            this.cBox_DataBit.Location = new System.Drawing.Point(153, 112);
            this.cBox_DataBit.Name = "cBox_DataBit";
            this.cBox_DataBit.Size = new System.Drawing.Size(150, 33);
            this.cBox_DataBit.TabIndex = 7;
            // 
            // cBox_Parity
            // 
            this.cBox_Parity.AllowDrop = true;
            this.cBox_Parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_Parity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox_Parity.FormattingEnabled = true;
            this.cBox_Parity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cBox_Parity.Location = new System.Drawing.Point(154, 190);
            this.cBox_Parity.Name = "cBox_Parity";
            this.cBox_Parity.Size = new System.Drawing.Size(150, 33);
            this.cBox_Parity.TabIndex = 6;
            // 
            // cBox_StopBit
            // 
            this.cBox_StopBit.AllowDrop = true;
            this.cBox_StopBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_StopBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox_StopBit.FormattingEnabled = true;
            this.cBox_StopBit.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cBox_StopBit.Location = new System.Drawing.Point(154, 151);
            this.cBox_StopBit.Name = "cBox_StopBit";
            this.cBox_StopBit.Size = new System.Drawing.Size(150, 33);
            this.cBox_StopBit.TabIndex = 5;
            // 
            // cBox_BaudRate
            // 
            this.cBox_BaudRate.AllowDrop = true;
            this.cBox_BaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_BaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox_BaudRate.FormattingEnabled = true;
            this.cBox_BaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "14400"});
            this.cBox_BaudRate.Location = new System.Drawing.Point(154, 73);
            this.cBox_BaudRate.Name = "cBox_BaudRate";
            this.cBox_BaudRate.Size = new System.Drawing.Size(150, 33);
            this.cBox_BaudRate.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ports";
            // 
            // cBox_port
            // 
            this.cBox_port.AllowDrop = true;
            this.cBox_port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox_port.FormattingEnabled = true;
            this.cBox_port.Location = new System.Drawing.Point(153, 34);
            this.cBox_port.Name = "cBox_port";
            this.cBox_port.Size = new System.Drawing.Size(150, 33);
            this.cBox_port.TabIndex = 2;
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Disconnect.Location = new System.Drawing.Point(154, 27);
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.Size = new System.Drawing.Size(129, 34);
            this.btn_Disconnect.TabIndex = 1;
            this.btn_Disconnect.TabStop = false;
            this.btn_Disconnect.Text = "Disconnect";
            this.btn_Disconnect.UseVisualStyleBackColor = true;
            this.btn_Disconnect.Click += new System.EventHandler(this.btn_Disconnect_Click);
            // 
            // btn_Connect
            // 
            this.btn_Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Connect.Location = new System.Drawing.Point(6, 27);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(129, 34);
            this.btn_Connect.TabIndex = 0;
            this.btn_Connect.TabStop = false;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressbar);
            this.groupBox1.Controls.Add(this.btn_Disconnect);
            this.groupBox1.Controls.Add(this.btn_Connect);
            this.groupBox1.Controls.Add(this.btn_Reset);
            this.groupBox1.Location = new System.Drawing.Point(21, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 103);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // progressbar
            // 
            this.progressbar.BackColor = System.Drawing.Color.Gray;
            this.progressbar.Location = new System.Drawing.Point(6, 72);
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(277, 21);
            this.progressbar.TabIndex = 3;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(305, 27);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(129, 66);
            this.btn_Reset.TabIndex = 2;
            this.btn_Reset.TabStop = false;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status_lable});
            this.statusStrip1.Location = new System.Drawing.Point(0, 397);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(809, 29);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Status_lable
            // 
            this.Status_lable.Name = "Status_lable";
            this.Status_lable.Size = new System.Drawing.Size(56, 23);
            this.Status_lable.Text = "Status";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBox_E2);
            this.groupBox2.Controls.Add(this.txtBox_E1);
            this.groupBox2.Controls.Add(this.txtBox_A4);
            this.groupBox2.Controls.Add(this.txtBox_A3);
            this.groupBox2.Controls.Add(this.txtBox_A2);
            this.groupBox2.Controls.Add(this.txtBox_A1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(484, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 363);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Receive";
            // 
            // txtBox_E2
            // 
            this.txtBox_E2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_E2.Location = new System.Drawing.Point(153, 305);
            this.txtBox_E2.Name = "txtBox_E2";
            this.txtBox_E2.ReadOnly = true;
            this.txtBox_E2.Size = new System.Drawing.Size(130, 34);
            this.txtBox_E2.TabIndex = 11;
            this.txtBox_E2.TabStop = false;
            this.txtBox_E2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBox_E1
            // 
            this.txtBox_E1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_E1.Location = new System.Drawing.Point(153, 253);
            this.txtBox_E1.Name = "txtBox_E1";
            this.txtBox_E1.ReadOnly = true;
            this.txtBox_E1.Size = new System.Drawing.Size(130, 34);
            this.txtBox_E1.TabIndex = 10;
            this.txtBox_E1.TabStop = false;
            this.txtBox_E1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBox_A4
            // 
            this.txtBox_A4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_A4.Location = new System.Drawing.Point(153, 182);
            this.txtBox_A4.Name = "txtBox_A4";
            this.txtBox_A4.ReadOnly = true;
            this.txtBox_A4.Size = new System.Drawing.Size(130, 34);
            this.txtBox_A4.TabIndex = 9;
            this.txtBox_A4.TabStop = false;
            this.txtBox_A4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBox_A3
            // 
            this.txtBox_A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_A3.Location = new System.Drawing.Point(153, 132);
            this.txtBox_A3.Name = "txtBox_A3";
            this.txtBox_A3.ReadOnly = true;
            this.txtBox_A3.Size = new System.Drawing.Size(130, 34);
            this.txtBox_A3.TabIndex = 8;
            this.txtBox_A3.TabStop = false;
            this.txtBox_A3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBox_A2
            // 
            this.txtBox_A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_A2.Location = new System.Drawing.Point(153, 83);
            this.txtBox_A2.Name = "txtBox_A2";
            this.txtBox_A2.ReadOnly = true;
            this.txtBox_A2.Size = new System.Drawing.Size(130, 34);
            this.txtBox_A2.TabIndex = 7;
            this.txtBox_A2.TabStop = false;
            this.txtBox_A2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBox_A1
            // 
            this.txtBox_A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_A1.Location = new System.Drawing.Point(153, 34);
            this.txtBox_A1.Name = "txtBox_A1";
            this.txtBox_A1.ReadOnly = true;
            this.txtBox_A1.Size = new System.Drawing.Size(130, 34);
            this.txtBox_A1.TabIndex = 6;
            this.txtBox_A1.TabStop = false;
            this.txtBox_A1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(29, 305);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 29);
            this.label11.TabIndex = 5;
            this.label11.Text = "Event 2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 29);
            this.label10.TabIndex = 4;
            this.label10.Text = "Event 1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 29);
            this.label9.TabIndex = 3;
            this.label9.Text = "Analog 4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 29);
            this.label8.TabIndex = 2;
            this.label8.Text = "Analog 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Analog 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Analog 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 426);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Connection);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Connection.ResumeLayout(false);
            this.Connection.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Connection;
        private System.Windows.Forms.ComboBox cBox_port;
        private System.Windows.Forms.Button btn_Disconnect;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressbar;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBox_DataBit;
        private System.Windows.Forms.ComboBox cBox_Parity;
        private System.Windows.Forms.ComboBox cBox_StopBit;
        private System.Windows.Forms.ComboBox cBox_BaudRate;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Status_lable;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.TextBox txtBox_E2;
        private System.Windows.Forms.TextBox txtBox_E1;
        private System.Windows.Forms.TextBox txtBox_A4;
        private System.Windows.Forms.TextBox txtBox_A3;
        private System.Windows.Forms.TextBox txtBox_A2;
        private System.Windows.Forms.TextBox txtBox_A1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

