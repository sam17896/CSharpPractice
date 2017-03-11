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
    public partial class ColorBlends : Form
    {
        public ColorBlends()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            LinearGradientBrush lgb = new LinearGradientBrush(new Point(20, 20), new Point(20, 70), Color.Red, Color.White);
            Graphics g = panel1.CreateGraphics();

            ColorBlend cb = new ColorBlend();
            cb.Colors = new Color[] { Color.White, Color.Black, Color.Blue };
            cb.Positions = new float[] { 0, 0.5F, 1F };
            lgb.InterpolationColors = cb;
            g.FillRectangle(lgb, 20, 20, 50, 50);
        }
    }
}
