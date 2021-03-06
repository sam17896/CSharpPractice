﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpPractice.ServiceReference2;

namespace CSharpPractice
{
    public partial class MainForm : Form
    {
        public MainForm()
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

        private void button3_Click(object sender, EventArgs e)
        {
            Drawing dr = new Drawing();
            dr.MdiParent = this;
            dr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Penp p = new Penp();
            p.MdiParent = this;
            p.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Drawstring ds = new Drawstring();
            ds.MdiParent = this;
            ds.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LGB lgb = new LGB();
            lgb.MdiParent = this;
            lgb.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ColorBlends cb = new ColorBlends();
            cb.MdiParent = this;
            cb.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PGB pgb = new PGB();
            pgb.MdiParent = this;
            pgb.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PaintProgram.Form1 f = new PaintProgram.Form1();
            f.MdiParent = this;
            f.Show();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication3.Form1 f = new WindowsFormsApplication3.Form1();
            f.MdiParent = this;
            f.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            simpleCalculator.Form1 f = new simpleCalculator.Form1();
            f.MdiParent = this;
            f.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Mid2 mid2 = new Mid2();
            mid2.MdiParent = this;
            mid2.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var cal = new CalculatorClient();
            MessageBox.Show(cal.AddString("Hello"));

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Db db = new Db();
            db.MdiParent = this;
            db.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            DataGridView dgv = new DataGridView();
            dgv.Show();
        }
    }
}
