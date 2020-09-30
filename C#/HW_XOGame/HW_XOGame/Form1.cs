using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_XOGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool O = true;

        private void button1_Click(object sender, EventArgs e) 
        {
            button1.Text = (O) ? "O" : "X";
            O = !O;
            button1.Enabled = false;
            judgment();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = (O) ? "O" : "X";
            O = !O;
            button2.Enabled = false;
            judgment();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = (O) ? "O" : "X";
            O = !O;
            button3.Enabled = false;
            judgment();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = (O) ? "O" : "X";
            O = !O;
            button4.Enabled = false;
            judgment();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = (O) ? "O" : "X";
            O = !O;
            button5.Enabled = false;
            judgment();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = (O) ? "O" : "X";
            O = !O;
            button6.Enabled = false;
            judgment();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = (O) ? "O" : "X";
            O = !O;
            button7.Enabled = false;
            judgment();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = (O) ? "O" : "X";
            O = !O;
            button8.Enabled = false;
            judgment();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = (O) ? "O" : "X";
            O = !O;
            button9.Enabled = false;
            judgment();
        }

        private void judgment()
        {
            if(button1.Text == "O" && button2.Text == "O" && button3.Text == "O"||
               button1.Text == "O" && button5.Text == "O" && button9.Text == "O"||
               button1.Text == "O" && button4.Text == "O" && button7.Text == "O"||
               button4.Text == "O" && button5.Text == "O" && button6.Text == "O"||
               button7.Text == "O" && button8.Text == "O" && button9.Text == "O"||
               button2.Text == "O" && button5.Text == "O" && button8.Text == "O"||
               button3.Text == "O" && button6.Text == "O" && button9.Text == "O"||
               button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("O贏了");
                button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = true;
                button1.Text = button2.Text = button3.Text = button4.Text = button5.Text = button6.Text = button7.Text = button8.Text = button9.Text = null;
            }

            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X" ||
               button1.Text == "X" && button5.Text == "X" && button9.Text == "X" ||
               button1.Text == "X" && button4.Text == "X" && button7.Text == "X" ||
               button4.Text == "X" && button5.Text == "X" && button6.Text == "X" ||
               button7.Text == "X" && button8.Text == "X" && button9.Text == "X" ||
               button2.Text == "X" && button5.Text == "X" && button8.Text == "X" ||
               button3.Text == "X" && button6.Text == "X" && button9.Text == "X" ||
               button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("X贏了");
                button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = true;
                button1.Text = button2.Text = button3.Text = button4.Text = button5.Text = button6.Text = button7.Text = button8.Text = button9.Text = null;
            }

            if((button1.Enabled || button2.Enabled || button3.Enabled ||
                button4.Enabled || button5.Enabled || button6.Enabled || 
                button7.Enabled || button8.Enabled || button9.Enabled) == false)
            {
                MessageBox.Show("平局!");
                button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = true;
                button1.Text = button2.Text = button3.Text = button4.Text = button5.Text = button6.Text = button7.Text = button8.Text = button9.Text = null;
            }
        }
        
            private void btnReset_Click(object sender, EventArgs e)
        {
            button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = true;
            button1.Text = button2.Text = button3.Text = button4.Text = button5.Text = button6.Text = button7.Text = button8.Text = button9.Text = null;
            O = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
                this.Close();
        }
    }
}
