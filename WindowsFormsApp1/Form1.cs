using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string correct = "魅";
        string incorrect = "魑";

        public Form1()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            label1.Text = panel1.Controls.Count.ToString();

            Random rnd = new Random();
            int answer = rnd.Next(25);

            for (int i = 0; i < panel1.Controls.Count; i++)
            {
                if (i == answer)
                    panel1.Controls[i].Text = correct;
                else
                    panel1.Controls[i].Text = incorrect;
                
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttons_click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == correct)
                label1.Text = "ばっちり！:)";
            else
                label1.Text = "ざんねん:(";
        }
    }
}
