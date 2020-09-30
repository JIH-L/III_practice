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
    public partial class Form2 : Form
    {
        internal Form1 F1;

        public Form2()
        {
            InitializeComponent();
        }
        public class F2
        {
            public Form1 F1 = null;
        }

        // form的lab, Modifier屬性改成internal

    }
}
