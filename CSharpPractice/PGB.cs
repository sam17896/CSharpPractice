using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpPractice
{
    public partial class PGB : Form
    {
        public PGB()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(20, 20, 50, 50);
            PathGradientBrush pgb = new PathGradientBrush(gp);
            pgb.CenterColor = Color.Red;
            pgb.SurroundColors = new Color[] {Color.Yellow};
            Graphics g = panel1.CreateGraphics();
            g.FillEllipse(pgb, 20, 20, 50, 50);
        }
    }
}
