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
    public partial class ListViewP : Form
    {
        public ListViewP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem lv1 = new ListViewItem(textBox1.Text);
            lv1.SubItems.Add(textBox3.Text);
            lv1.SubItems.Add(textBox2.Text);

            listView1.Items.Add(lv1);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void getNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                foreach (ListViewItem lv in listView1.SelectedItems)
                    MessageBox.Show(lv.SubItems[0].Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lv in listView1.Items)
            {
                if (lv.Checked)
                {
                    lv.Remove();
                }
            }
            
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                foreach (ListViewItem lv in listView1.SelectedItems)
                    lv.Remove();
            }
        }

        private void removeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Clear();
        }


    }
}
