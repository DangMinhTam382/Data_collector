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


namespace Com_test
{
    public partial class Form1 : Form
    {
        string data_IN = string.Empty;
        string data_IN_Save = string.Empty;
        string data_OUT = string.Empty;

        string start_value_voltage = "0.00";
        string start_value_event = "0000";

        string[] arr_data_split;
        string[] data_Event_Processed = new string [2];

        int def_Baudrate = 9600;
        int def_Databit = 8;

        Int16 data_Event_num1 = 0;
        Int16 data_Event_num2 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBox_port.Items.AddRange(ports);
            cBox_BaudRate.Text = Convert.ToString(def_Baudrate);
            cBox_DataBit.Text  = Convert.ToString(def_Databit);
            cBox_StopBit.Text = "One";
            cBox_Parity.Text  = "None";

            No_connect_status();
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cBox_port.Text;
                serialPort1.BaudRate = Convert.ToInt32(cBox_BaudRate.Text);
                serialPort1.DataBits = Convert.ToInt32(cBox_DataBit.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBox_StopBit.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBox_Parity.Text);

                serialPort1.Open();

                Connect_status();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Disconnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                No_connect_status();
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                data_OUT = "R";
                serialPort1.WriteLine(data_OUT);
                Clear_textBox_value();
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            data_IN = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(Showdata));
        }

        private void Showdata(object sender, EventArgs e)
        {


            if (data_IN == "x")             // Xuat len Text box sau khi nhat tat ca du lieu
            {
                arr_data_split = data_IN_Save.Split(',');
                // xuat data ra text box:
                txtBox_A1.Text = arr_data_split[0];
                txtBox_A2.Text = arr_data_split[1];
                txtBox_A3.Text = arr_data_split[2];
                txtBox_A4.Text = arr_data_split[3];

                
                event_Process(arr_data_split[4], arr_data_split[5]);

                txtBox_E1.Text = data_Event_Processed[0];
                txtBox_E2.Text = data_Event_Processed[1];

                /*
                txtBox_E1.Text = arr_data_split[4];
                txtBox_E2.Text = arr_data_split[5];
                */
                data_IN_Save = string.Empty;
            } 
            else 
            { 
                data_IN_Save += data_IN;
            }
            
        }

        void No_connect_status()         //Trang thai ko ket noi:
        {
            //Button
            Status_lable.Text = "No Port Connected!";
            progressbar.Value = 0;
            btn_Connect.Enabled = true;
            btn_Disconnect.Enabled = false;
            btn_Reset.Enabled = false;

            //ComboBox
            cBox_port.Enabled = true;
            cBox_BaudRate.Enabled = true;
            cBox_DataBit.Enabled = true;
            cBox_StopBit.Enabled = true;
            cBox_Parity.Enabled = true;

            //Data off:
            Clear_textBox_value();

            txtBox_A1.Enabled = false;
            txtBox_A4.Enabled = false;
            txtBox_A3.Enabled = false;
            txtBox_A2.Enabled = false;

            txtBox_E1.Enabled = false;
            txtBox_E2.Enabled = false;
        }

        void Connect_status()           //Trang thai ket noi:
        {
            //Button
            progressbar.Value = 100;
            Status_lable.Text = "Connected!";
            btn_Connect.Enabled = false;
            btn_Disconnect.Enabled = true;
            btn_Reset.Enabled = true;

            //ComboBox
            cBox_port.Enabled = false;
            cBox_BaudRate.Enabled = false;
            cBox_DataBit.Enabled = false;
            cBox_StopBit.Enabled = false;
            cBox_Parity.Enabled = false;

            //Text Box
            txtBox_A1.Enabled = true;
            txtBox_A4.Enabled = true;
            txtBox_A3.Enabled = true;
            txtBox_A2.Enabled = true;

            txtBox_E1.Enabled = true;
            txtBox_E2.Enabled = true;
        }

        void Clear_textBox_value()
        {
            txtBox_A1.Text = start_value_voltage;
            txtBox_A4.Text = start_value_voltage;
            txtBox_A3.Text = start_value_voltage;
            txtBox_A2.Text = start_value_voltage;

            txtBox_E1.Text = start_value_event;
            txtBox_E2.Text = start_value_event;
        }   //Xoa txt box

        void event_Process(string data_Event1, string data_Event2)      //them "0" neu can thiet
        {
            data_Event_num1 = Convert.ToInt16(data_Event1);
            data_Event_num2 = Convert.ToInt16(data_Event2);
            int[] arr_Event_data = { data_Event_num1, data_Event_num2 };

            for (short i = 0; i < 2; i++)
            {
                if (arr_Event_data[i] < 10) data_Event_Processed[i] = "000" + Convert.ToString(arr_Event_data[i]);
                else if (arr_Event_data[i] < 100) data_Event_Processed[i] = "00" + Convert.ToString(arr_Event_data[i]);
                else if (arr_Event_data[i] < 1000) data_Event_Processed[i] = "0" + Convert.ToString(arr_Event_data[i]);             
            }
            
        }
    }
}
