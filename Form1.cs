using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingPad
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        Boolean cursorMovement = false;
        Pen cursorPen;
        int cursorX = -1;
        int cursorY = -1;

        public Form1()
        {
            InitializeComponent();
            graphics = canvas.CreateGraphics();
            cursorPen = new Pen(Color.Black , 5);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            cursorPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            cursorPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void blackBox_Click(object sender, EventArgs e)
        {
            //when click, want to cast the sender as picturebox to set color
            PictureBox color = (PictureBox)sender;
            cursorPen.Color = color.BackColor;
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            cursorMovement = true;
            cursorX = e.X;
            cursorY = e.Y;
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            cursorMovement= false;
            cursorX = -1;
            cursorY = -1;
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (cursorX != -1 && cursorY !=-1 && cursorMovement == true)
            {
                //location of the mouse and new point of the cursor are tgt draw line.
                graphics.DrawLine(cursorPen, new Point(cursorX, cursorY), e.Location);
                cursorX = e.X;
                cursorY = e.Y;  
            }
        }
    }
}
