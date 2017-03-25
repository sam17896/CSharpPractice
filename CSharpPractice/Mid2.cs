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
    public partial class Mid2 : Form
    {
        int i;
        public Mid2()
        {
            InitializeComponent();
            i = 0;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if(fd.ShowDialog() == DialogResult.OK)
            richTextBox1.SelectionFont = fd.Font;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = cd.Color;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(richTextBox1.SelectionFont.Bold == true)
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Regular);
            else
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Italic == true)
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Regular);
            else
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Underline == true)
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Regular);
            else
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Underline);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("notepad");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            linkLabel2.LinkVisited = true;
            linkLabel2.LinkBehavior = LinkBehavior.HoverUnderline;
            System.Diagnostics.Process.Start("http://www.google.com");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            linkLabel3.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.facebook.com");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Add(textBox2.Text);
            comboBox1.Items.Insert(i, textBox2.Text);
            checkedListBox1.Items.Add(textBox2.Text);
            i++;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            comboBox1.Items.Remove(comboBox1.SelectedItem);
            checkedListBox1.Items.Remove(checkedListBox1.SelectedItem);
        }

        private void button11_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            comboBox1.Items.Clear();
            checkedListBox1.Items.Clear();
            i = 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string value = "";
            if (radioButton1.Checked) 
            {
                value = radioButton1.Text;
            }
            if (radioButton2.Checked)
            {
                value = radioButton2.Text;
            }
            if (radioButton3.Checked)
            {
                value = radioButton3.Text;
            }
            MessageBox.Show(value);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string value = "";
            if (radioButton4.Checked)
            {
                value = radioButton4.Text;
            }
            if (radioButton5.Checked)
            {
                value = radioButton5.Text;
            }
            if (radioButton6.Checked)
            {
                value = radioButton6.Text;
            }
            MessageBox.Show(value);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string value = "";
            if (checkBox1.Checked)
            {
                value += checkBox1.Text;
            }
            if (checkBox2.Checked)
            {
                value += checkBox2.Text;
            }
            if (checkBox3.Checked)
            {
                value += checkBox3.Text;
            }
            if (checkBox4.Checked)
            {
                value += checkBox4.Text;
            }
            MessageBox.Show(value);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem("Ahsan");
            lvi.SubItems.Add("123 Main Street");
            lvi.SubItems.Add("17-8-96");

            listView1.Items.Add(lvi);

        }

        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listView1.SelectedItems[0].SubItems[0].Text);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems[0].Remove();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("People");
            treeView1.Nodes.Add("Animal");

            treeView1.Nodes[0].Nodes.Add("Ahsan");
            treeView1.Nodes[0].Nodes.Add("Iqra");
            treeView1.Nodes[0].Nodes.Add("Saad");

            treeView1.Nodes[1].Nodes.Add("Dogs");
            treeView1.Nodes[1].Nodes.Add("Cats");

            treeView1.Nodes[1].Nodes[0].Nodes.Add("Spot");



        }

        private void button19_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
        }
        List<TreeNode> lnc = new List<TreeNode>();
        private void button21_Click(object sender, EventArgs e)
        {
            RemoveChecked(treeView1.Nodes);
        }
        public void RemoveChecked(TreeNodeCollection tnc)
        {
            foreach (TreeNode tn in tnc)
            {
                if (tn.Checked) lnc.Add(tn);
                else if (tn.Nodes.Count != 0) RemoveChecked(tn.Nodes);
            }
            foreach (TreeNode tn in lnc)
            {
                treeView1.Nodes.Remove(tn);
            }
        }
    }
}
