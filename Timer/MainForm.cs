﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Threading;
using System.IO.Ports;

namespace Timer
{
    public partial class MainForm : Form
    {
        DispatcherTimer dt = new DispatcherTimer();
        Stopwatch sw = new Stopwatch();
        string currentTime = string.Empty;
        int speech_num = -1;
        Boolean com_connected = false;
        int counter_60sec = 60;

        struct _speechTime
        {
            public string name;
            public TimeSpan time_Green;
            public TimeSpan time_Yellow;
            public TimeSpan time_Red;
            public TimeSpan time_End;

            public _speechTime(string name, TimeSpan time_Green, TimeSpan time_Yellow, TimeSpan time_Red, TimeSpan time_End)
            {
                this.name = name;
                this.time_Green = time_Green;
                this.time_Yellow = time_Yellow;
                this.time_Red = time_Red;
                this.time_End = time_End;
            }
        };

        _speechTime[] SpeechTime =
        {
            new _speechTime("テーブルトピックス (1-2分)",
                           TimeSpan.FromMinutes(1.0),
                           TimeSpan.FromMinutes(1.5),
                           TimeSpan.FromMinutes(2.0),
                           TimeSpan.FromMinutes(2.5)),
            new _speechTime("準備スピーチ（4-6分)",
                           TimeSpan.FromMinutes(4.0),
                           TimeSpan.FromMinutes(5.0),
                           TimeSpan.FromMinutes(6.0),
                           TimeSpan.FromMinutes(6.5)),
            new _speechTime("準備スピーチ (5-7分)",
                           TimeSpan.FromMinutes(5.0),
                           TimeSpan.FromMinutes(6.0),
                           TimeSpan.FromMinutes(7.0),
                           TimeSpan.FromMinutes(7.5)),
            new _speechTime("準備スピーチ (8-10分)",
                           TimeSpan.FromMinutes(8.0),
                           TimeSpan.FromMinutes(9.0),
                           TimeSpan.FromMinutes(10.0),
                           TimeSpan.FromMinutes(10.5)),
            new _speechTime("準備スピーチ (10-12分)",
                           TimeSpan.FromMinutes(10.0),
                           TimeSpan.FromMinutes(11.0),
                           TimeSpan.FromMinutes(12.0),
                           TimeSpan.FromMinutes(12.5)),
            new _speechTime("準備スピーチ (12-15分)",
                           TimeSpan.FromMinutes(12.0),
                           TimeSpan.FromMinutes(13.5),
                           TimeSpan.FromMinutes(15.0),
                           TimeSpan.FromMinutes(15.5)),
            new _speechTime("論評 (2-3分)",
                           TimeSpan.FromMinutes(2.0),
                           TimeSpan.FromMinutes(2.5),
                           TimeSpan.FromMinutes(3.0),
                           TimeSpan.FromMinutes(3.5)),
            new _speechTime("コンテスト (5-7分)",
                           TimeSpan.FromMinutes(5.0),
                           TimeSpan.FromMinutes(6.0),
                           TimeSpan.FromMinutes(7.0),
                           TimeSpan.FromMinutes(59.0)),
            new _speechTime("**テストモード** (3秒毎)",
                           TimeSpan.FromSeconds(3.0),
                           TimeSpan.FromSeconds(6.0),
                           TimeSpan.FromSeconds(9.0),
                           TimeSpan.FromSeconds(12.0))
        };

        public MainForm()
        {
            InitializeComponent();
            this.Color_panel.BackColor = System.Drawing.Color.FromArgb(0x00, 0x00, 0x00);

            dt.Tick += new EventHandler(dt_Tick);
            dt.Interval = new TimeSpan(0, 0, 0, 0, 1);

            this.Text = "TM_Timer";
            button_A.Text = "開始";
            button_B.Text = "クリア";
            button_Z.Text = "終了";
            button_D.Text = "コメントタイム(60秒)";

            this.label1.Text = "Ver.0.2.11";
            this.ActiveControl = this.comboBox1;

            button_C.Text = "接続";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i< SpeechTime.Length ; i++)
            {
                comboBox1.Items.Add(SpeechTime[i].name.ToString());
            }

            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboBox2.Items.Add(port);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            speech_num = comboBox1.SelectedIndex;

            Time_Records.AppendText(SpeechTime[speech_num].name.ToString());
            Time_Records.AppendText("\r\n");

            button_A.Select();
        }

        private void button_A_Click(object sender, EventArgs e)
        {
            if(sw.IsRunning)
            {
                sw.Stop();
                button_A.Text = "開始";
            }
            else
            {
                if( comboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("スピーチを選択してください。");
                } else
                {
                    sw.Start();
                    dt.Start();
                    button_A.Text = "停止";
                }
                
            }
        }

        private void button_B_Click(object sender, EventArgs e)
        {
            TimeSpan ts = sw.Elapsed;

            if( comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("スピーチを選択してください。");
            }
            else
            {
                if( ! SpeechTime[speech_num].name.Equals("コンテスト (5-7分)") )
                {
                    currentTime = String.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);
                    if( currentTime != "00:00")
                    {
                        Time_Records.AppendText( currentTime );
                        if( ts > SpeechTime[speech_num].time_End )
                        {
                            Time_Records.AppendText("(++)");
                        } else if(ts < SpeechTime[speech_num].time_Green)
                        {
                            Time_Records.AppendText("(--)");
                        }
                        Time_Records.AppendText("\r\n");
                    }
                    
                }

                sw.Stop();
                sw.Reset();
                dt.Stop();

                this.Color_panel.BackColor = System.Drawing.Color.FromArgb(0x00, 0x00, 0x00);
                if ( com_connected )
                {
                    serialPort1.Write("B");
                }
                TextBox_ElapsedTime.Text = "00:00";
                button_A.Text = "開始";
            }

        }

        void dt_Tick(object sender, EventArgs e)
        {
            if (sw.IsRunning)
            {
                TimeSpan ts = sw.Elapsed;
                currentTime = String.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);
                TextBox_ElapsedTime.Text = currentTime;

                if (ts.Minutes == SpeechTime[speech_num].time_Green.Minutes && 
                    ts.Seconds == SpeechTime[speech_num].time_Green.Seconds)
                {
                    this.Color_panel.BackColor = System.Drawing.Color.FromArgb(0x00, 0x80, 0x00);
                    if ( com_connected )
                    {
                        serialPort1.Write("G");
                    }
                }
                else if (ts.Minutes == SpeechTime[speech_num].time_Yellow.Minutes && 
                         ts.Seconds == SpeechTime[speech_num].time_Yellow.Seconds)
                {
                    this.Color_panel.BackColor = System.Drawing.Color.FromArgb(0xFF, 0xFF, 0x00);
                    if ( com_connected )
                    {
                        serialPort1.Write("Y");
                    }
                }
                else if (ts.Minutes == SpeechTime[speech_num].time_Red.Minutes && 
                         ts.Seconds == SpeechTime[speech_num].time_Red.Seconds)
                {
                    this.Color_panel.BackColor = System.Drawing.Color.FromArgb(0xFF, 0x00, 0x00);
                    if ( com_connected )
                    {
                        serialPort1.Write("R");
                    }
                }
                else if (ts.Minutes == SpeechTime[speech_num].time_End.Minutes && 
                         ts.Seconds == SpeechTime[speech_num].time_End.Seconds)
                {
                    this.Color_panel.BackColor = System.Drawing.Color.FromArgb(0x00, 0x00, 0x00);
                    if ( com_connected )
                    {
                        serialPort1.Write("B");
                    }
                }
            }
        }

        private void button_Z_Click(object sender, EventArgs e)
        {
            sw.Stop();
            dt.Stop();
            this.Close();
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text != "")
            {
                try
                {
                    serialPort1.PortName = comboBox2.SelectedItem.ToString();
                    serialPort1.Open();

                    serialPort1.Write("S");
                    System.Threading.Thread.Sleep(200);
                    string data = serialPort1.ReadExisting();
                    if (!string.IsNullOrEmpty(data) && data == "O")
                    {
                        button_C.Enabled = false;
                        comboBox2.Enabled = false;
                        com_connected = true;
                        this.ActiveControl = this.button_A;
                    }
                    else
                    {
                        serialPort1.Close();
                        MessageBox.Show("接続できませんでした。");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("COM portを選択して下さい。");
            }
        }

        private void button_D_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            counter_60sec = 60;
            textBox1.Text = "60";
            timer1.Enabled = true;
            textBox1.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter_60sec--;

            if( counter_60sec == 0)
            {
                timer1.Enabled = false;
                textBox1.Visible = false;
                textBox1.Text = counter_60sec.ToString();
                this.ActiveControl = this.button_A;
            } else
                textBox1.Text = counter_60sec.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
