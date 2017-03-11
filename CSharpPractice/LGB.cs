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
    public partial class LGB : Form
    {
        public LGB()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            LinearGradientBrush lgb = new LinearGradientBrush(new Point(20, 20), new Point(20, 70), Color.Red, Color.Yellow);
            Graphics g = panel1.CreateGraphics();

            g.FillRectangle(lgb, 20, 20, 50, 50);
        }
    }
}
