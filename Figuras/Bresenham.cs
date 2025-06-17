using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    class Bresenham
    {
        private PictureBox pb;
        private ListBox lst;

        public Bresenham(PictureBox pictureBox, ListBox listBox)
        {
            pb = pictureBox;
            lst = listBox;
        }

        public async Task DibujarLineaAsync(int x0, int y0, int x1, int y1)
        {
            Graphics g = pb.CreateGraphics();
            int centroX = pb.Width / 2;
            int centroY = pb.Height / 2;

            int dx = Math.Abs(x1 - x0);
            int dy = Math.Abs(y1 - y0);
            int sx = x0 < x1 ? 1 : -1;
            int sy = y0 < y1 ? 1 : -1;

            int x = x0, y = y0;

            if (dx > dy)
            {
                int p = 2 * dy - dx;
                for (int k = 0; k <= dx; k++)
                {
                    int px = centroX + x;
                    int py = centroY - y;
                    g.FillRectangle(Brushes.DarkBlue, px, py, 1, 1);
                    lst.Items.Add($"({x}, {y})");
                    lst.TopIndex = lst.Items.Count - 1;

                    if (p < 0)
                        p += 2 * dy;
                    else
                    {
                        y += sy;
                        p += 2 * (dy - dx);
                    }
                    x += sx;
                    await Task.Delay(20);
                }
            }
            else
            {
                int p = 2 * dx - dy;
                for (int k = 0; k <= dy; k++)
                {
                    int px = centroX + x;
                    int py = centroY - y;
                    g.FillRectangle(Brushes.DarkBlue, px, py, 1, 1);
                    lst.Items.Add($"({x}, {y})");
                    lst.TopIndex = lst.Items.Count - 1;

                    if (p < 0)
                        p += 2 * dx;
                    else
                    {
                        x += sx;
                        p += 2 * (dx - dy);
                    }
                    y += sy;
                    await Task.Delay(20);
                }
            }
        }
    }
}


