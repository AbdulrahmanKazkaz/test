using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using System.Media;

namespace Final.UC
{
    public partial class Dashboard : UserControl
    {
        bool status = false; // button x-or
        public bool Status { get { return status; } set { status = value; } }
        string serialRead;
        string[] data;
        bool flag1 = false;
        bool flag2 = false;
        bool flag3 = false;

        SoundPlayer soundBuzzer;

        public Dashboard()
        {
            InitializeComponent();  
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < SerialPort.GetPortNames().Length; i++)
            {
                comSerialCom.Items.Add(SerialPort.GetPortNames()[i]);
            }
            Buttons.Enabled = false;
            soundBuzzer = new SoundPlayer("buzzer.wav");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (Status == false) // Defulte Status is false
            {
                try
                { 
                    serialPort1.PortName = comSerialCom.Text;
                    serialPort1.Open();
                    timer1.Start();
                    btnRefresh.Enabled = false;
                    Buttons.Enabled = true;
                    Status = true;
                    btnStart.Text = "Stop";
                    btnStart.BackColor = Color.Green;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                try
                {
                    serialPort1.Close();
                    timer1.Stop();
                    btnRefresh.Enabled = true;
                    Buttons.Enabled = false;
                    Status = false;
                    btnStart.Text = "Start";
                    soundBuzzer.Stop();
                    this.BackColor = Color.Transparent;
                    btnStart.BackColor = Color.Red;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            comSerialCom.Items.Clear();
            comSerialCom.Text = null;
            for (int i = 0; i < SerialPort.GetPortNames().Length; i++)
            {
                comSerialCom.Items.Add(SerialPort.GetPortNames()[i]);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                serialRead = serialPort1.ReadLine().ToString();
                data = serialRead.Split(';');

                int temp = Convert.ToInt32(data[0]);
                int humi = Convert.ToInt32(data[1]);
                int gaz = Convert.ToInt32(data[2]);
                int water = Convert.ToInt32(data[3]);

                circleH.Value = humi;
                barH.Value = humi;
                lblHumidity.Text = humi.ToString();


                circleG.Value = gaz;
                barG.Value = gaz;
                if (gaz == 1)
                {
                    lblGaz.Text = "No Gaz Detected ";
                    circleG.Value = 0;
                    barG.Value = 0;
                    this.BackColor = Color.Transparent;
                    soundBuzzer.Stop();
                    gaz = 0;
                }
                else
                {
                    lblGaz.Text = "Gaz Detected !!";
                    circleG.Value = 100;
                    barG.Value = 100;
                    this.BackColor = Color.IndianRed;
                    soundBuzzer.Play();
                }

                circleT.Value = temp;
                barT.Value = temp;
                lblTemp.Text = temp.ToString();

                if (water > 300)
                {
                    piclevelWater.Image = Properties.Resources.full;
                }
                else
                {
                    piclevelWater.Image = Properties.Resources.empty;
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
             
        }

        private void swMix_OnValueChange(object sender, EventArgs e)
        {
            if(Status == true)
            {
                if(flag1 == false)
                {
                    serialPort1.Write("on1");
                    flag1 = true;
                }
                else
                {
                    serialPort1.Write("off1");
                    flag1 = false;
                }
            }
            
        }

        private void swPlan1_OnValueChange(object sender, EventArgs e)
        {
            if (Status == true)
            {
                if (flag2 == false)
                {
                    serialPort1.Write("on2");
                    flag2 = true;
                }
                else
                {
                    serialPort1.Write("off2");
                    flag2 = false;
                }
            }
        }

        private void swClean_OnValueChange(object sender, EventArgs e)
        {
            if (Status == true)
            {
                if (flag3 == false)
                {
                    serialPort1.Write("on3");
                    flag3 = true;
                }
                else
                {
                    serialPort1.Write("off3");
                    flag3 = false;
                }
            }
        }

        private void swMix_MouseClick(object sender, MouseEventArgs e)
        {
          if(swMix.Value == true)
            {
                swClean.Enabled = false;
                swPlan1.Enabled = false;
            }
            else
            {
                swClean.Enabled = true;
                swPlan1.Enabled = true;
            }
        }

        private void swPlan1_MouseClick(object sender, MouseEventArgs e)
        {
            if(swPlan1.Value == true)
            {
                swClean.Enabled = false;
                swMix.Enabled = false;
            }
            else
            {
                swClean.Enabled = true;
                swMix.Enabled = true;
            }
        }

        private void swClean_MouseClick(object sender, MouseEventArgs e)
        {
            if(swClean.Value == true)
            {
                swMix.Enabled = false;
                swPlan1.Enabled = false;
            }
            else
            {
                swMix.Enabled = true;
                swPlan1.Enabled = true;
            }
        }
    }
}
