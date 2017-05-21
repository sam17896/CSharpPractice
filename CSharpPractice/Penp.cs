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
    public partial class Penp : Form
    {
        public Penp()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Pen p = new Pen(Color.Red);
            Graphics g = panel1.CreateGraphics();

            g.DrawRectangle(p, 20, 20, 50, 50);
        }

    }
}
