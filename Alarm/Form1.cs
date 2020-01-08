using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Alarm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
   
        int saat, deq, san;
        string alarmsaat, alarmdeq;
        string ringname;
        string filename12;
        System.IO.Stream str = Properties.Resources.analog_watch_alarm_daniel_simion;
        
        private void Form1_Load(object sender, EventArgs e)
        {
     
            timer1.Start();
            for(int i = 0; i < 24; i++)
            {
                comboBox1.Items.Add(i);
            }

            for (int j = 0; j < 60; j++)
            {
                comboBox2.Items.Add(j);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                alarmsaat = comboBox1.Text;
                alarmdeq = comboBox2.Text;

                label9.Text = alarmsaat + " : "  + alarmdeq;

               
             


            



           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saat = DateTime.Now.Hour;
            deq = DateTime.Now.Minute;
            san = DateTime.Now.Second;
            label3.Text = saat.ToString();
            label4.Text =deq.ToString();
            label5.Text = san.ToString();
            alarm1();


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.IO.Stream str1 = Properties.Resources.analog_watch_alarm_daniel_simion;
            System.Media.SoundPlayer snd123 = new System.Media.SoundPlayer(str1);
            snd123.Stop();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void alarm1()
        {
            if(alarmsaat == saat.ToString() && alarmdeq == deq.ToString() && san.ToString() == "0")
            {
                // axWindowsMediaPlayer1.URL = @"D:\alarms\" + filename12;

                System.Media.SoundPlayer snd12 = new System.Media.SoundPlayer(str);
                snd12.Play();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
