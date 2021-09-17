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


namespace Device_LED_Control
{
    public partial class Mainwindow : Form
    {
        bool isConnected = false;
        string[] ports;
        Button[] buttons;
        bool[] butstat = new bool[6];
        bool[] ledsts = new bool[6];
        SerialPort port;
        // Cycle global variables:
        int Hz_num = 0;
        int break_s = 0;
        int Hz_time = 0;
        int cycle_num = 0;


        public Mainwindow()
        {
            InitializeComponent();

            //initiating ports into combobox ports list
            ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                port_comboBox.Items.Add(port);
                Console.WriteLine(port);

            }
            buttons = new Button[6] { led1_statusbut, led2_statusbut, led3_statusbut, led4_statusbut, led5_statusbut, led6_statusbut }; //initiating buttuns array
            for (int i = 0; i < 6; i++)
            {
                butstat[i] = false;
                ledsts[i] = false;
            }
        }


        //functions related to port connection
        private void port_but_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isConnected)
                    connectToArduino();
                else
                    disconnectFromArduino();
            }
            catch
            {
                port_but.BackColor = Color.Yellow;
            }

        }
        private void connectToArduino()
        {
            isConnected = true;
            string selectedPort = port_comboBox.GetItemText(port_comboBox.SelectedItem);
            port = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
            port.Open();
            port.Write("#STAR\n");
            port_but.BackColor = Color.Green;
        }
        private void disconnectFromArduino()
        {
            try
            {
                isConnected = false;
                port.Write("#STOP\n");
                port.Close();
            }
            catch { }
            port_but.BackColor = Color.Red;
        }
        private void port_comboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            disconnectFromArduino();
        }
        private void Mainwindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            disconnectFromArduino();
        }

        //functions related to buttons on/off and leds on/off
        /// <summary>
        /// This function turn buttons and led connection on and off (depending on the previous button state).
        /// </summary>
        /// <param name="buti"> index integer of the button (should be button number minus 1)</param>
        private void butclicked(int buti)
        {
            if (isConnected)
            {
                if (butstat[buti])
                {

                    setButStat(buti, false);
                    setLED(buti + 1, false);
                }
                else
                {
                    setButStat(buti, true);
                    setLED(buti + 1, true);
                }
            }
        }
        private void setButStat(int buti, bool sts)
        {
            if (sts)
            {
                buttons[buti].BackColor = Color.Black;
                buttons[buti].Text = "ON";
                buttons[buti].ForeColor = Color.White;
                butstat[buti] = sts;
            }
            else
            {
                buttons[buti].BackColor = SystemColors.Control;
                buttons[buti].Text = "OFF";
                buttons[buti].ForeColor = Color.Black;
                butstat[buti] = sts;
            }
        }
        private void setLED(int ledi, bool sts)
        {
            string comnd;
            if (sts)
                comnd = "#LED" + ledi.ToString() + "ON\n";
            else
                comnd = "#LED" + ledi.ToString() + "OFF\n";
            port.Write(comnd);
            ledsts[ledi - 1] = sts;
        }


        private void led1statusbut_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            butclicked(0);
            if (led1_freq.Value != 0)
                timer1.Enabled = true;
        }
        private void led2_statusbut_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            butclicked(1);
            if (led2_freq.Value != 0)
                timer2.Enabled = true;
        }
        private void led3_statusbut_Click(object sender, EventArgs e)
        {
            timer3.Enabled = false;
            butclicked(2);
            if (led3_freq.Value != 0)
                timer3.Enabled = true;
        }
        private void led4_statusbut_Click(object sender, EventArgs e)
        {
            timer4.Enabled = false;
            butclicked(3);
            if (led4_freq.Value != 0)
                timer4.Enabled = true;
        }
        private void led5_statusbut_Click(object sender, EventArgs e)
        {
            timer5.Enabled = false;
            butclicked(4);
            if (led5_freq.Value != 0)
                timer5.Enabled = true;
        }
        private void led6_statusbut_Click(object sender, EventArgs e)
        {
            timer6.Enabled = false;
            butclicked(5);
            if (led6_freq.Value != 0)
                timer6.Enabled = true;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isConnected && butstat[0])
            {
                if (ledsts[0])
                {
                    setLED(1, false);
                }
                else
                {
                    setLED(1, true);
                }
            }
        }
        private void led1_freq_ValueChanged(object sender, EventArgs e)
        {
            if (this.led1_freq.Value == 0)
            {
                this.timer1.Enabled = false;
            }
            else
            {
                this.timer1.Interval = Convert.ToInt32(this.led1_freq.Value);
                if (butstat[0])
                    this.timer1.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isConnected && butstat[1])
            {
                if (ledsts[1])
                {
                    setLED(2, false);
                }
                else
                {
                    setLED(2, true);
                }
            }
        }
        private void led2_freq_ValueChanged(object sender, EventArgs e)
        {
            if (this.led2_freq.Value == 0)
            {
                this.timer2.Enabled = false;
            }
            else
            {
                this.timer2.Interval = Convert.ToInt32(this.led2_freq.Value);
                if (butstat[1])
                    this.timer2.Enabled = true;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (isConnected && butstat[2])
            {
                if (ledsts[2])
                {
                    setLED(3, false);
                }
                else
                {
                    setLED(3, true);
                }
            }
        }
        private void led3_freq_ValueChanged(object sender, EventArgs e)
        {
            if (this.led3_freq.Value == 0)
            {
                this.timer3.Enabled = false;
            }
            else
            {
                this.timer3.Interval = Convert.ToInt32(this.led3_freq.Value);
                if (butstat[2])
                    this.timer3.Enabled = true;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (isConnected && butstat[3])
            {
                if (ledsts[3])
                {
                    setLED(4, false);
                }
                else
                {
                    setLED(4, true);
                }
            }
        }
        private void led4_freq_ValueChanged(object sender, EventArgs e)
        {
            if (this.led4_freq.Value == 0)
            {
                this.timer4.Enabled = false;
            }
            else
            {
                this.timer4.Interval = Convert.ToInt32(this.led4_freq.Value);
                if (butstat[3])
                    this.timer4.Enabled = true;
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (isConnected && butstat[4])
            {
                if (ledsts[4])
                {
                    setLED(5, false);
                }
                else
                {
                    setLED(5, true);
                }
            }
        }
        private void led5_freq_ValueChanged(object sender, EventArgs e)
        {
            if (this.led5_freq.Value == 0)
            {
                this.timer5.Enabled = false;
            }
            else
            {
                this.timer5.Interval = Convert.ToInt32(this.led5_freq.Value);
                if (butstat[4])
                    this.timer5.Enabled = true;
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (isConnected && butstat[5])
            {
                if (ledsts[5])
                {
                    setLED(6, false);
                }
                else
                {
                    setLED(6, true);
                }
            }
        }
        private void led6_freq_ValueChanged(object sender, EventArgs e)
        {
            if (this.led6_freq.Value == 0)
            {
                this.timer6.Enabled = false;
            }
            else
            {
                this.timer6.Interval = Convert.ToInt32(this.led6_freq.Value);
                if (butstat[5])
                    this.timer6.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                setButStat(i, true);
                setLED(i + 1, true);
            }
            if (led1_freq.Value != 0)
                timer1.Enabled = true;
            if (led2_freq.Value != 0)
                timer2.Enabled = true;
            if (led3_freq.Value != 0)
                timer3.Enabled = true;
            if (led4_freq.Value != 0)
                timer4.Enabled = true;
            if (led5_freq.Value != 0)
                timer5.Enabled = true;
            if (led6_freq.Value != 0)
                timer6.Enabled = true;
        }

        private void turnAllOFF_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                setButStat(i, false);
                setLED(i + 1, false);
            }
            if (led1_freq.Value != 0)
                timer1.Enabled = false;
            if (led2_freq.Value != 0)
                timer2.Enabled = false;
            if (led3_freq.Value != 0)
                timer3.Enabled = false;
            if (led4_freq.Value != 0)
                timer4.Enabled = false;
            if (led5_freq.Value != 0)
                timer5.Enabled = false;
            if (led6_freq.Value != 0)
                timer6.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Hz_UpDown_ValueChanged(object sender, EventArgs e)
        {
           Hz_num = Convert.ToInt32(this.Hz_UpDown.Value);
           
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            break_s = Convert.ToInt32(this.Break_UpDown.Value);
        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void port_label_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            Hz_time = Convert.ToInt32(this.Time_UpDown.Value);
            //Console.WriteLine(Hz_time);
        }

        private void CyclesUpDown_ValueChanged(object sender, EventArgs e)
        {
            cycle_num = Convert.ToInt32(this.CyclesUpDown.Value);
        }

        private void CycleStart_Click(object sender, EventArgs e)
        {
            //port.Write("#CYC" + Hz_num + break_ms.ToString() + Hz_time.ToString() + cycle_num.ToString() + "\n");
            //port.Write("#CYC4\n");
            port.Write("#CYC"+ Hz_num + "A" + Hz_time + "B" + break_s + "C" + cycle_num+ "D" + "\n");
        }


    }
}