using System;
using System.Drawing;
using System.Windows.Forms;

namespace Canvas
{
    public partial class Form1 : Form
    {
        private bool drawing;
        private Point previousPoint;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                drawing = true;
                previousPoint = e.Location;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                using (Graphics g = CreateGraphics())
                {
                    g.DrawLine(Pens.Black, previousPoint, e.Location);
                    previousPoint = e.Location;
                }
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            drawing = false;
        }
    }
}
