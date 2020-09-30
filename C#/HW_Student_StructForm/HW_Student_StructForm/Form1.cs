using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Student_StructForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtName.Focus();
        }
        
        string result;
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if(txtName.Text == "")
            {
                MessageBox.Show("請輸入姓名", "Oops!");
            }
            int CN;
            bool Covert1 = int.TryParse(txtCN.Text, out CN);
            if (Covert1 == false)
            {
                MessageBox.Show("國文請輸入數字","Oops!");
                return;
            }
            int EN;
            bool Covert2 = int.TryParse(txtEN.Text, out EN);
            if (Covert2 == false)
            {
                MessageBox.Show("英文請輸入數字", "Oops!");
                return;
            }
            int Math;
            bool Covert3 = int.TryParse(txtMath.Text, out Math);
            if (Covert3 == false)
            {
                MessageBox.Show("數學請輸入數字", "Oops!");
                return;
            }

            Student s;
            s.Name = txtName.Text;
            s.CN = CN;
            s.EN = EN;
            s.Math = Math;

            result = $"姓名：{s.Name}\n國文：{s.CN}分\n英文：{s.EN}分\n數學：{s.Math}分";
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            labShow.Text = result;

        }

        private void btnHighLow_Click(object sender, EventArgs e)
        {
            string[] SubName = { "國文", "英文", "數學" };
            int[] Score = { int.Parse(txtCN.Text), int.Parse(txtEN.Text),int.Parse(txtMath.Text) };
            int[] sort = new int[3];
            
            for(int i = 0; i < Score.Length; i++)
            {
                sort[i] = Score[i];
            }
            Array.Sort(sort);
            int intIndex = Array.IndexOf(Score, sort[sort.Length - 1]);

            labShowHL.Text = "最高分科目：" + SubName[intIndex] + Score.Max().ToString()+"分";

            Array.Sort(sort);
            Array.Reverse(sort);
            int intIndex2 = Array.IndexOf(Score, sort[sort.Length - 1]);
            labShowHL.Text += "\n最低分科目：" + SubName[intIndex2] + Score.Min().ToString()+"分";
        }

    }
}
