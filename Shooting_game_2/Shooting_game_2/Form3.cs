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
    public partial class Form3 : Form
    { Form1 f1;
        public Form3(Form1 ff1)
        {
            f1=ff1;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.label1.Text =f1.label1.Text;
            this.label2.Text =f1.label2.Text;
            this.label3.Text=f1.label3.Text;

            
        
    }
}
