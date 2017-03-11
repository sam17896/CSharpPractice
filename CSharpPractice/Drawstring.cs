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
    public partial class Drawstring : Form
    {
        public Drawstring()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            SolidBrush sb = new SolidBrush(Color.Blue);
            Graphics g = panel1.CreateGraphics();

            FontFamily ff = new FontFamily("Arial");
            System.Drawing.Font font = new System.Drawing.Font(ff, 50);
            g.DrawString("Ahsan", font, sb, new PointF(20, 20));

        }
    }
}
