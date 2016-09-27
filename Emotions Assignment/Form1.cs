using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emotions_Assignment
{
    public partial class fr1 : Form
    {
        public fr1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblResult.Text = "Make sure Mr.Hardman doesn't yell at you!";
        }

        private void fr1_Load(object sender, EventArgs e)
        {
            lblResult.Text = "";
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            lblResult.Text = "Mr.Hardman yelled at you didn't he...";
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            lblResult.Text = "Be the best you can be!";
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            lblResult.Text = "It's Friday!";
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            lblResult.Text = "Sleep later, work now.";
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            lblResult.Text = "Watch 'How to get away with Murder' on Netflix.";
        }
    }
}
