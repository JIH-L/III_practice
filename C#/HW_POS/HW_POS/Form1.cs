using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_POS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void btnThor_Click(object sender, EventArgs e)
        {
            clsTotal.Thor += 1200;
            clsTotal.ThorCount += 1;
            clsTotal.total += 1200;
            SUMtotal();
        }
        private void btnCA_Click(object sender, EventArgs e)
        {
            clsTotal.total += 1500;
            clsTotal.Captain += 1500;
            clsTotal.CaptainCount += 1;
            SUMtotal();
        }

        private void btnIronMan_Click(object sender, EventArgs e)
        {
            clsTotal.total += 1800;
            clsTotal.IronMan += 1800;
            clsTotal.IronManCount += 1;
            SUMtotal();
        }

        private void btnPepper_Click(object sender, EventArgs e)
        {
            clsTotal.total += 2500;
            clsTotal.Hulk += 2500;
            clsTotal.HulkCount += 1;
            SUMtotal();
        }
        private void btnCash_Click(object sender, EventArgs e)
        {
            CheckOut();
        }

        private void btnCD_Click(object sender, EventArgs e)
        {
            //clsTotal.total = (int)(clsTotal.total * 1.03);
            //CheckOut();
            if (clsTotal.total != 0)
            {
                DialogResult result =
                MessageBox.Show($"總金額: {clsTotal.total*1.03}\n手續費: {clsTotal.total*0.03}", "別怕", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("錢再賺就有惹", "水啦", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTotal();
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("你484按錯惹?", "?????", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    //ClearTotal();
                }
            }
            else
            {
                MessageBox.Show("左邊忘記多按幾下囉", "哈囉?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void SUMtotal()
        {
            lablist2.Text = "";
            if (clsTotal.ThorCount > 0)
            {
                lablist2.Text += $"Thor * {clsTotal.ThorCount}，共 {clsTotal.Thor} 元\n";
            }
            if (clsTotal.CaptainCount > 0)
            {
                lablist2.Text += $"Captain * {clsTotal.CaptainCount}，共 {clsTotal.Captain} 元\n";
            }
            if (clsTotal.IronManCount > 0)
            {
                lablist2.Text += $"IronMan * {clsTotal.IronManCount}，共 {clsTotal.IronMan} 元\n";
            }
            if (clsTotal.HulkCount > 0)
            {
                lablist2.Text += $"Hulk * {clsTotal.HulkCount}，共 {clsTotal.Hulk} 元";
            }
            labtotal2.Text = $"NT$ {clsTotal.total}";
        }

        void ClearTotal()
        {
            clsTotal.total = 0;
            labtotal2.Text = $"NT$ {clsTotal.total}";
            lablist2.Text = "尚未選取";
            clsTotal.ThorCount = 0;
            clsTotal.Thor = 0;
            clsTotal.Captain = 0;
            clsTotal.CaptainCount = 0;
            clsTotal.IronMan = 0;
            clsTotal.IronManCount = 0;
            clsTotal.Hulk = 0;
            clsTotal.HulkCount = 0;
        }

        void CheckOut()
        {
            if (clsTotal.total != 0)
            {
                DialogResult result =
                MessageBox.Show("總金額: " + clsTotal.total, "別怕", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("錢再賺就有惹", "水啦", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTotal();
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("你484按錯惹?", "?????", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    //ClearTotal();
                }
            }
            else
            {
                MessageBox.Show("左邊忘記多按幾下囉", "哈囉?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTotal();

        }
    }
}
