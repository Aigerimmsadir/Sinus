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

namespace Sinus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        GraphicsPath gp = new GraphicsPath();
        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.Black;
        }
        static double x = -110;
        static double y = 110;
        private void timer1_Tick(object sender, EventArgs e)
        {
            float prevx = (float)x; float prevy = (float)y;
            x++;
            y= 20 * Math.Sin(x / 20);
            float _x = (float)x; float _y = (float)y;
            if(prevy!=110)
            gp.AddLine(110 + prevx, 110 + prevy, 110 + _x, 110+_y);
            Refresh();

        }


        Pen pen = new Pen(Color.Cyan);
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(pen, 0,110,1000,110);
         
            e.Graphics.DrawPath(pen, gp);

        }
    }
}
