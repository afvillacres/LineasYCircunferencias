using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Figuras
{
    internal class FloodFiller
    {
        private Bitmap bitmap;
        private PictureBox pictureBox;

        public FloodFiller(Bitmap bmp, PictureBox pb)
        {
            bitmap = bmp;
            pictureBox = pb;
        }

        public void Fill(int x, int y, Color fillColor, ListBox lstPuntos = null, int delayMs = 50)
        {
            if (x < 0 || y < 0 || x >= bitmap.Width || y >= bitmap.Height)
                return;

            Color targetColor = bitmap.GetPixel(x, y);
            if (targetColor.ToArgb() == fillColor.ToArgb())
                return;

            Queue<Point> queue = new Queue<Point>();
            queue.Enqueue(new Point(x, y));

            while (queue.Count > 0)
            {
                Point p = queue.Dequeue();

                if (p.X < 0 || p.X >= bitmap.Width || p.Y < 0 || p.Y >= bitmap.Height)
                    continue;

                if (bitmap.GetPixel(p.X, p.Y).ToArgb() != targetColor.ToArgb())
                    continue;

                bitmap.SetPixel(p.X, p.Y, fillColor);

                // Forzar actualización visual
                pictureBox.Invalidate();
                Application.DoEvents();

                if (lstPuntos != null)
                {
                    lstPuntos.Items.Add($"({p.X}, {p.Y})");
                    lstPuntos.TopIndex = lstPuntos.Items.Count - 1;
                }

                Thread.Sleep(delayMs);

                queue.Enqueue(new Point(p.X + 1, p.Y));
                queue.Enqueue(new Point(p.X - 1, p.Y));
                queue.Enqueue(new Point(p.X, p.Y + 1));
                queue.Enqueue(new Point(p.X, p.Y - 1));
            }
        }
    }
}