using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewP lvp = new ListViewP();
            lvp.MdiParent = this;
            lvp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TreeView tv = new TreeView();
            tv.MdiParent = this;
            tv.Show();
        }
    }
}
