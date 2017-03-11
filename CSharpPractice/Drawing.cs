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
    public partial class Drawing : Form
    {
        public Drawing()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            SolidBrush sb = new SolidBrush(Color.Green);

            Graphics g = panel1.CreateGraphics();
            g.FillRectangle(sb, 20, 20, 50, 50);
        }
    }
}
