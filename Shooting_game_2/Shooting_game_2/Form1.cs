using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMPLib;

namespace Shooting_game_2
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
        }
        Random r = new Random();
        int score = 0;
        int total_shots = 0;
        int miss_shot = 0;
        void shot_voice()
        {
            
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\AsmAr nArejo\Downloads\1.wav");
            player.Play();
        }
        void fn_shot()
        {
            score++;
            label1.Text = "score=" + score;
            total_shots++;
            label3.Text = "Total Shots=" + total_shots;
            shot_voice();
        }
        void fn_miss_shot()
        {
            miss_shot++;
            label2.Text = "Misiing Shots=" + miss_shot;
            total_shots++;
            label3.Text = "Total Shots=" + total_shots;
            shot_voice();
        }
        void reset()
        {
            score = 0;
            miss_shot = 0;
            total_shots = 0;
            label2.Text = "Misiing Shots=" + miss_shot;
            label3.Text = "Total Shots=" + total_shots;
            label1.Text = "score=" + score;
            timer1.Start();
 
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            player.URL = "380_gunshot_single-mike-koenig";
            player.controls.play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            int x, y;
            x = r.Next(0, 500);
            y = r.Next(200, 400);
            pictureBox1.Location = new Point(x, y);
            if (miss_shot >= 10)
            {
                timer1.Stop();
                label1.Text = "Game Over";
                label2.Text = " ";
                label3.Text =" ";
                //this.MouseClick
                Form3 f3 = new Form3(this);
                f3.Show();
                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            fn_shot();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            fn_miss_shot();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
