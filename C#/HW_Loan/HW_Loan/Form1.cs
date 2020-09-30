using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Loan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 每月等額還本付息額 = 本金*{月利率*(1+月利率)^期數}/{[(1+月利率)^期數]-1}
        // 月利率 = 年利率/12 , 月數 = 貸款年期*12

        // -----------------------------------------------------------------

        private void btnPMT_Click(object sender, EventArgs e)
        {
            int Loan = int.Parse(txtLoan.Text);
            int Year = int.Parse(txtYear.Text) * 12;
            double Rate = int.Parse(txtRate.Text) *0.01 / 12;
            int First = int.Parse(txtFirst.Text);

            double payRate = Convert.ToInt32((Loan-First) * (Rate * Math.Pow(1 + Rate, Year)) / (Math.Pow(1 + Rate, Year) - 1));

            MessageBox.Show("月付額：" + payRate.ToString() + "元");
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            int Loan = int.Parse(txtLoan.Text);
            int Year = int.Parse(txtYear.Text) * 12;
            double Rate = int.Parse(txtRate.Text) * 0.01 / 12;
            int First = int.Parse(txtFirst.Text);
            double payRate = Convert.ToInt32((Loan - First) * (Rate * Math.Pow(1 + Rate, Year)) / (Math.Pow(1 + Rate, Year) - 1));

            double Total = payRate * Year;
            MessageBox.Show("總付款：" + Total.ToString() + "元");
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.F1 = this;
            F2.Show();

            F2.labLoan2.Text = txtLoan.Text;
            F2.labYear2.Text = txtYear.Text;
            F2.labRate2.Text = txtRate.Text;

            int Loan = int.Parse(txtLoan.Text);
            int Year = int.Parse(txtYear.Text) * 12;
            double Rate = int.Parse(txtRate.Text) * 0.01 / 12;
            int First = int.Parse(txtFirst.Text);
            double payRate = Convert.ToInt32((Loan - First) * (Rate * Math.Pow(1 + Rate, Year)) / (Math.Pow(1 + Rate, Year) - 1));

            double Total = payRate * Year;
            F2.labPayRate2.Text = payRate.ToString();
            F2.labPayTotal2.Text = Total.ToString();
        }
    }
}
