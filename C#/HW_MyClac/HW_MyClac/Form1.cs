using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_MyClac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            int Plus;

            bool C1 = int.TryParse(txtNum1.Text, out Plus);
            if (C1 == false)
            {
                MessageBox.Show("請輸入數字", "Oops!");
                return;
            }
            bool C2 = int.TryParse(txtNum2.Text, out Plus);
            if (C2 == false)
            {
                MessageBox.Show("請輸入數字", "Oops!");
                return;
            }

            Plus = int.Parse(txtNum1.Text) + int.Parse(txtNum2.Text);
            labANS.Text = Plus.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int Minus;
            
            bool C1 = int.TryParse(txtNum1.Text, out Minus);
            if (C1 == false)
            {
                MessageBox.Show("請輸入數字", "Oops!");
                return;
            }
            bool C2 = int.TryParse(txtNum2.Text, out Minus);
            if (C2 == false)
            {
                MessageBox.Show("請輸入數字", "Oops!");
                return;
            }


            Minus = int.Parse(txtNum1.Text) - int.Parse(txtNum2.Text);
            labANS.Text = Minus.ToString();
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            int Times;

            bool C1 = int.TryParse(txtNum1.Text, out Times);
            if (C1 == false)
            {
                MessageBox.Show("請輸入數字", "Oops!");
                return;
            }
            bool C2 = int.TryParse(txtNum2.Text, out Times);
            if (C2 == false)
            {
                MessageBox.Show("請輸入數字", "Oops!");
                return;
            }

            Times = int.Parse(txtNum1.Text) * int.Parse(txtNum2.Text);
            labANS.Text = Times.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            float Div;

            bool C1 = float.TryParse(txtNum1.Text, out Div);
            if (C1 == false)
            {
                MessageBox.Show("請輸入數字", "Oops!");
                return;
            }
            bool C2 = float.TryParse(txtNum2.Text, out Div);
            if (C2 == false)
            {
                MessageBox.Show("請輸入數字", "Oops!");
                return;
            }

            Div = float.Parse(txtNum1.Text) / float.Parse(txtNum2.Text);
            labANS.Text = Div.ToString();
        }
    }
}
