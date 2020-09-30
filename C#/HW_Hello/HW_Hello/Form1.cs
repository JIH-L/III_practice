using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Hello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            
            string Name = txtName.Text; 
            string EnName = txtEnName.Text;
            string Sex = txtSex.Text;
            string Zodiac = txtZodiac.Text;
            System.Windows.Forms.MessageBox.Show("Hello , 我是" + Name + "," + 
                "\n英文名字是" + EnName + "," +
                "\n性別是" + Sex +"," +
                "\n星座是" + Zodiac + "," +
                "\n很高興認識你!");
        }

        private void btnSayHi_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string EnName = txtEnName.Text;
            string Sex = txtSex.Text;
            string Zodiac = txtZodiac.Text;
            System.Windows.Forms.MessageBox.Show("Hi , 我是" + Name + "," +
                "\n英文名字是" + EnName + "," +
                "\n性別是" + Sex + "," +
                "\n星座是" + Zodiac + "," +
                "\n很高興認識你!");
        }
    }
}
