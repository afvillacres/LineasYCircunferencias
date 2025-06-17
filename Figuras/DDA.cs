using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    class DDA
    {
        private PictureBox pb;
        private ListBox lst;

        public DDA(PictureBox pictureBox, ListBox listBox)
        {
            pb = pictureBox;
            lst = listBox;
        }

        public async Task DibujarLineaAsync(int x0, int y0, int x1, int y1)
        {
            Graphics g = pb.CreateGraphics();
            int centroX = pb.Width / 2;
            int centroY = pb.Height / 2;

            float dx = x1 - x0;
            float dy = y1 - y0;

            float pasos = Math.Max(Math.Abs(dx), Math.Abs(dy));
            float incrementoX = dx / pasos;
            float incrementoY = dy / pasos;

            float x = x0;
            float y = y0;

            for (int i = 0; i <= pasos; i++)
            {
                int px = centroX + (int)Math.Round(x);
                int py = centroY - (int)Math.Round(y);
                g.FillRectangle(Brushes.Red, px, py, 1, 1);
                lst.Items.Add($"({Math.Round(x)}, {Math.Round(y)})");
                lst.TopIndex = lst.Items.Count - 1;

                x += incrementoX;
                y += incrementoY;
                await Task.Delay(20);
            }
        }
    }
}


