using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    internal class Line
    {
 
        private Graphics mGraph;
        private Point mStartPoint;
        private Point mEndPoint;
        Pen mLinePen;
        Pen mEllipsePen;


        public Line()
        {
            mStartPoint = new Point(0, 0);
            mEndPoint = new Point(0, 0);
        }

        public void InitializeData(PictureBox picCanvas)
        {
            mStartPoint.X = 0; mStartPoint.Y = 0;
            mEndPoint.X = 0; mEndPoint.Y = 0;
            picCanvas.Refresh();
        }
        public void DrawLineMouse(MouseEventArgs e, PictureBox picCanvas)
        {
            if (e.Button == MouseButtons.Left)
            {
                mGraph = picCanvas.CreateGraphics();
                
                mLinePen = new Pen(Color.Blue, 1);

                mEllipsePen = new Pen(Color.Red, 1);

                mStartPoint = mEndPoint;
                
                mEndPoint = new Point(e.X, e.Y);

                mGraph.DrawLine(mLinePen, mStartPoint, mEndPoint);

                mGraph.DrawEllipse(mEllipsePen, e.X - 2, e.Y - 2, 6, 6);

                mLinePen.Dispose();

                mEllipsePen.Dispose();

                mGraph.Dispose();
            }
        }
    }
}
