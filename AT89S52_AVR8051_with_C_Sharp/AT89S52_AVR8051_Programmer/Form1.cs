using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Media;
using System.IO;
using System.IO.Ports;
using System.Diagnostics;

namespace AT89S52_AVR8051_Programmer
{
    public partial class Form1 : Form
    {
        SerialPort sp = new SerialPort();
        public static bool isNewHexUpload = false;
        public static int portFlag = 0;
        public static bool isUploadHex = false;
        public bool isPortDisConected = false;

        private System.Windows.Forms.Timer valueDetectionTimer;

        public Form1()
        {
            InitializeComponent();
            valueDetectionTimer = new System.Windows.Forms.Timer();
            valueDetectionTimer.Interval = 10;
            valueDetectionTimer.Tick += ValueDetectionTimer_Tick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = AT89S52_about;
                       
            hexLabel.Text = "";
            label2.Hide();
            Port.Text = "";
            Reconnect.Hide();
            disconnect.Hide();
            valueDetectionTimer.Start();
        }
        private void ValueDetectionTimer_Tick(object sender, EventArgs e)
        {
            if (Gvar.count > 1 && Gvar.isDhexUploaded)
            {
                if (isNewHexUpload)
                {
                    hexLabel.Text = "                               A Hex file is Uploaded via " + Port_Form.portName+" in AT89S52.";
                    UploadHex.BackColor = Color.SeaGreen;

                }
                else
                {
                    hexLabel.Text = "Dedicated Hex file is Uploaded via " + Port_Form.portName;
                    UploadHex.BackColor = Color.SeaGreen;

                }
            }
        }


        private void AT89S52_about_Click(object sender, EventArgs e)
        {
            AT89S52_about form = new AT89S52_about();
            form.ShowDialog();
        }

        private void UploadHex_Click(object sender, EventArgs e)
        {
            if (portFlag == 0)
            {
                SystemSounds.Asterisk.Play();

                DialogResult result = MessageBox.Show("Is your Arduino already connected ?", "Connected??", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    
                    Port_Form pf = new Port_Form();
                    pf.ShowDialog();

                    if (Gvar.isDhexUploaded)
                    {
                        Port.Text = Port_Form.portName;
                        hexLabel.Text = "Dedicated Hex file is Uploaded via " + Port.Text + " .Now Arduino is act as an ISP Programmer.";
                        UploadHex.BackColor = Color.SeaGreen;
                        label2.Show();
                        Reconnect.Show();
                        disconnect.Show();
                    }
                }
                else
                {
                    Form2 customMessageBox = new Form2();
                    customMessageBox.MessageText = "Disconnect your Arduino.";
                    customMessageBox.NextButtonText = "Next";
                    customMessageBox.ShowDialog();

                    if (!Gvar.isForm2Closed)
                    {

                        Port_Form pf = new Port_Form();
                        pf.ShowDialog();

                        Port.Text = Port_Form.portName;
                        hexLabel.Text = "Dedicated Hex file is Uploaded via " + Port.Text + " .Now Arduino is act as an ISP Programmer.";
                        UploadHex.BackColor = Color.SeaGreen;
                        label2.Show();
                        Reconnect.Show();
                        disconnect.Show();
                    }
                }

            }
            else
            {
                if (isPortDisConected==false && Gvar.isDhexUploaded)
                {
                    DialogResult result = MessageBox.Show("Do you want to upload any Hex file?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                          Port_Form pf = new Port_Form();
                            pf.Show();

                            if (Gvar.count > 1)
                            {
                                pf.label1.Text = "      Upload Any hex file for AT89S52";
                                pf.button1.Hide();
                                pf.Browse_Exe.Hide();
                                pf.Browse_Config.Hide();
                                pf.label2.Hide();
                                pf.label3.Hide();
                                pf.ExePath_tb.Hide();
                                pf.ConfigPath_tb.Hide();

                                pf.label4.Text = "(.hex)";
                                pf.Browse_hex.Location = new Point(220, 100);
                                pf.label4.Location = new Point(280, 103);
                                pf.HexPath_tb.Location = new Point(100, 140);


                                pf.label5.Text += " " + Port_Form.portName + " is connected and ready to flash. ";
                                pf.arrow.Show();
                                pf.flash.Show();
                            }
                        
                    }
                }
                else
                    MessageBox.Show("Connect the " + Port_Form.portName + " first.");


            }
        }
        private void Guideline_Label_Click(object sender, EventArgs e)
        {
            GuideLine form = new GuideLine();
            form.ShowDialog();
        }

        private void Reconnect_Click(object sender, EventArgs e)
        {
            isPortDisConected = false;
            MessageBox.Show("Reconnected port " + Port_Form.portName + " sucessfully");
            label2.Text = "Connected port";
            Reconnect.BackColor = Color.SeaGreen;
            disconnect.BackColor = Color.LightGray;
        }

        private void disconnect_Click(object sender, EventArgs e)
        {
            isPortDisConected = true;
            MessageBox.Show("Disconnected port " + Port_Form.portName + " sucessfully");
            label2.Text = "Disconnected port";
            disconnect.BackColor = Color.IndianRed;
            Reconnect.BackColor = Color.LightGray;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SystemSounds.Asterisk.Play();
            if (MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.FormClosing -= Form1_FormClosing;
                Application.Exit();
            }
            else
                e.Cancel = true;
        }
    }
}
