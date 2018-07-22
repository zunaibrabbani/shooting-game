using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shooting_game_2
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.button1.Text = "START";
            this.button2.Text = "ABOUT";
            this.button3.Text = "EXIT";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            
        }
    }
}
