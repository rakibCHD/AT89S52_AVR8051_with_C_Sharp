﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.IO.Ports;

namespace AT89S52_AVR8051_Programmer
{
    public partial class Port_Form : Form
    {
        public static string portName;

        bool isBrowseExe = false;
        bool isBrowseConfig = false;
        public static bool isBrowseHex = false;
        int Pflag = 0;
        int Cflag = 0;
        int Hflag = 0;


        public Port_Form()
        {
            InitializeComponent();
        }

        private void Port_Form_Load(object sender, EventArgs e)
        {
            this.ActiveControl = Browse_Exe;
            Gvar.count++;
            label5.Text = " ";
            arrow.Hide();
            flash.Hide();
            LeftArrow.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FindPort();
        }

        private void FindPort()
        {
            if (isAnyBrowse())
            {
                if (isAllBrowse())
                {
                    string[] previousPorts = SerialPort.GetPortNames();

                    string previousPortsString = string.Join(", ", previousPorts);

                    string newPort = WaitForNewPort(previousPorts, TimeSpan.FromSeconds(30));


                    if (newPort == null)
                    {
                         DialogResult result = MessageBox.Show("No new port detected within 30 Second!", "Timeout", MessageBoxButtons.OK);
                        if (result == DialogResult.OK)
                        {
                            MessageBox.Show("Operation canceled.");
                            this.Hide();
                        }
                    }
                    else
                    {
                        portName = newPort.Trim();

                        label5.Text += "Port- " + newPort + " is connected and ready to flash.";
                        arrow.Show();
                        flash.Show();
                    }
                }
                if (!isBrowseExe)
                {
                    MessageBox.Show("Browse Programmer.exe file.");
                    errorProvider1.SetError(ExePath_tb, "Please select a valid file.");

                }
                if (!isBrowseConfig)
                    MessageBox.Show("Browse ChipConfig.conf file.");
                if (!isBrowseHex)
                    MessageBox.Show("Browse .Hex file.");
            }
            else
                MessageBox.Show("Browse the necessary files.");

        }


        private string WaitForNewPort(string[] previousPorts, TimeSpan timeout)
        {
            SystemSounds.Asterisk.Play();
            MessageBox.Show("You have 30 Second to connect your Arduino after press 'ok'.");

            DateTime startTime = DateTime.Now;

            while (DateTime.Now - startTime < timeout)
            {
                string[] currentPorts = SerialPort.GetPortNames();

                foreach (string port in currentPorts)
                {
                    if (!Array.Exists(previousPorts, element => element == port))
                    {
                        return port;
                    }
                }
                System.Threading.Thread.Sleep(1000);
            }

            return null;
        }


        private void Browse_Exe_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                errorProvider1.SetError(ExePath_tb, string.Empty);

                if (!openFileDialog1.FileName.Contains("Programmer.exe"))
                {
                    errorProvider1.SetError(ExePath_tb, "Please select a valid file.");
                    ExePath_tb.Text = string.Empty;
                    this.ActiveControl = Browse_Exe;
                    button1.Enabled = false;
                }
                else
                {
                    button1.Enabled = true;
                    this.ActiveControl = Browse_Config;
                    ExePath_tb.Text = openFileDialog1.FileName;
                    Gvar.ExePath = openFileDialog1.FileName;
                    isBrowseExe = true;
                    Pflag = 1;
                }
                if (isAllBrowse())
                {
                    LeftArrow.Show();
                    this.ActiveControl = button1;
                }
            }
        }

        private void Browse_Config_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {

                errorProvider1.SetError(ConfigPath_tb, string.Empty);

                if (!openFileDialog2.FileName.Contains("ChipConfig.conf"))
                {
                    errorProvider1.SetError(ConfigPath_tb, "Please select a valid file.");
                    ConfigPath_tb.Text = string.Empty;
                    this.ActiveControl = Browse_Config;

                    button1.Enabled = false;
                }
                else
                {
                    button1.Enabled = true;
                    this.ActiveControl = Browse_hex;
                    ConfigPath_tb.Text = openFileDialog2.FileName;
                    Gvar.ConfigPath = openFileDialog2.FileName;

                    isBrowseConfig = true;
                    Cflag = 1;
                }
                if (isAllBrowse())
                {
                    LeftArrow.Show();
                    this.ActiveControl = button1;
                }
            }
        }

        private void Browse_hex_Click(object sender, EventArgs e)
        {
            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                errorProvider1.SetError(HexPath_tb, string.Empty);

                if (!Gvar.isDhexUploaded)
                {
                    if (openFileDialog3.FileName.Contains("ArduinoISP.ino.standard.hex"))
                    {
                        button1.Enabled = true;
                        this.ActiveControl = button1;
                        HexPath_tb.Text = openFileDialog3.FileName;
                        isBrowseHex = true;
                        Hflag = 1;
                    }
                    else
                    {
                        errorProvider1.SetError(HexPath_tb, "Please select a valid file.");
                        HexPath_tb.Text = string.Empty;
                        this.ActiveControl = Browse_hex;
                        button1.Enabled = false;
                    }
                    if (isAllBrowse())
                    {
                        LeftArrow.Show();
                        this.ActiveControl = button1;
                    }
                }
                else
                {
                    if (openFileDialog3.FileName.Contains(".hex") && !openFileDialog3.FileName.Contains("ArduinoISP.ino.standard.hex"))
                    {
                        this.ActiveControl = button1;
                        HexPath_tb.Text = openFileDialog3.FileName;
                        Gvar.isNewHexUpload = true;

                    }
                    else
                    {
                        errorProvider1.SetError(HexPath_tb, "Please select a valid file.");
                        HexPath_tb.Text = string.Empty;
                        Gvar.isNewHexUpload = false;
                    }
                }
            }
        }

        private bool isAllBrowse()
        {
            if (Pflag == 1 && Cflag == 1 && Hflag == 1)
                return true;
            else
                return false;
        }

        private bool isAnyBrowse()
        {
            if (Pflag == 1 || Cflag == 1 || Hflag == 1)
                return true;
            else
                return false;
        }

        private void flash_Click(object sender, EventArgs e)
        {
            if (Form1.isUploadHex ==false)
            {
                if (HexPath_tb.Text != string.Empty)
                {
                    string ExePath = @Gvar.ExePath;
                    string configPath = @Gvar.ConfigPath;
                    string programmer = "arduino";
                    string targetChip = "m328p";

                    int baudRate = 115200;
                    string hexFilePath = @openFileDialog3.FileName;


                    string arguments = $"-C \"{configPath}\" -c {programmer} -p {targetChip} -P {portName} -b {baudRate} -U flash:w:\"{hexFilePath}\":a";

                    MessageBox.Show("Flashing process will Start.");

                    Process process = Process.Start(ExePath, arguments);
                    process.WaitForExit();

                    MessageBox.Show("Flashing successful.");

                    Form1.isUploadHex = true;
                    Form1.portFlag = 1;

                    this.Hide();

                    if (!Gvar.isNewHexUpload)
                    {
                        Gvar.isDhexUploaded = true;
                        Form1.isNewHexUpload = false;
                    }
                }
                else
                    MessageBox.Show("Browse a hex file first");
            }
            else
            {
                if (HexPath_tb.Text != string.Empty)
                {
                    string ExePath = @Gvar.ExePath;
                    string configPath = @Gvar.ConfigPath;
                    string programmer = "stk500v1";
                    string targetChip = "89s52";

                    int baudRate = 19200;
                    string hexFilePath = @openFileDialog3.FileName;


                    string arguments = $"-C \"{configPath}\" -c {programmer} -p {targetChip} -P {portName} -b {baudRate} -U flash:w:\"{hexFilePath}\":a";

                    MessageBox.Show("Flashing process will Start.");

                    Process process = Process.Start(ExePath, arguments);
                    process.WaitForExit();

                    MessageBox.Show("Flashing successful.");

                    this.Hide();

                    if (Gvar.isDhexUploaded)
                    {
                        Gvar.count++;
                        Form1.isNewHexUpload = true;
                    }                   
                }
                else
                    MessageBox.Show("Browse a hex file first");
            }
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
