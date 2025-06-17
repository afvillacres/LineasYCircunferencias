using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    internal class MidPointCircle
    {
        public int Xc { get; set; }
        public int Yc { get; set; }
        public int R { get; set; }

        public async Task DibujarAsync(Bitmap lienzo, PictureBox picPizarra, ListBox lstPuntos, int centroX, int centroY, Color color)
        {
            int x = 0, y = R;
            int p = 1 - R;

            List<(int, int)> pares = new List<(int, int)>();
            pares.Add((x, y));

            while (x < y)
            {
                x++;
                if (p < 0)
                    p += 2 * x + 1;
                else
                {
                    y--;
                    p += 2 * (x - y) + 1;
                }
                pares.Add((x, y));
            }

            var puntosTemp = new List<Point>[pares.Count];
            Parallel.For(0, pares.Count, i =>
            {
                var (px, py) = pares[i];
                var lista = new List<Point>();

                lista.Add(new Point(px, py));
                lista.Add(new Point(-px, py));
                lista.Add(new Point(px, -py));
                lista.Add(new Point(-px, -py));
                lista.Add(new Point(py, px));
                lista.Add(new Point(-py, px));
                lista.Add(new Point(py, -px));
                lista.Add(new Point(-py, -px));

                puntosTemp[i] = lista;
            });

            foreach (var lista in puntosTemp)
            {
                foreach (var pt in lista)
                {
                    int pantallaX = centroX + pt.X + Xc;
                    int pantallaY = centroY - (pt.Y + Yc);

                    if (pantallaX >= 0 && pantallaX < lienzo.Width && pantallaY >= 0 && pantallaY < lienzo.Height)
                    {
                        lienzo.SetPixel(pantallaX, pantallaY, color);

                        lstPuntos.Items.Add($"({pt.X + Xc}, {pt.Y + Yc})");
                        lstPuntos.TopIndex = lstPuntos.Items.Count - 1;

                        picPizarra.Image = (Bitmap)lienzo.Clone();
                        await Task.Delay(30);
                    }
                }
            }
        }
    }
}