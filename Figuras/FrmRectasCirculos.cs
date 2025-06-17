using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    public partial class FrmRectasCirculos : Form
    {
        private Bitmap lienzo;
        private Graphics g;
        private Point? puntoClick = null;


        public FrmRectasCirculos()
        {
            InitializeComponent();
            lienzo = new Bitmap(picPizarra.Width, picPizarra.Height);
            g = Graphics.FromImage(lienzo);
            picPizarra.Image = lienzo;
            picPizarra.MouseClick += picPizarra_MouseClick;
        }

        private static FrmRectasCirculos instancia;
        public static FrmRectasCirculos ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmRectasCirculos();
            }
            return instancia;
        }

        private async void btnDDA_Click(object sender, EventArgs e)
        {
            try
            {
                string[] inicio = txtPuntoInicial.Text.Split(',');
                string[] fin = txtPuntoFinal.Text.Split(',');

                int x0 = int.Parse(inicio[0]);
                int y0 = int.Parse(inicio[1]);
                int x1 = int.Parse(fin[0]);
                int y1 = int.Parse(fin[1]);

                lstPuntos.Items.Clear();
                DDA dda = new DDA(picPizarra, lstPuntos);
                await dda.DibujarLineaAsync(x0, y0, x1, y1);
            }
            catch
            {
                MessageBox.Show("Por favor ingresa los puntos en el formato correcto: x,y");
            }
        }

        private async void btnBresenham_Click(object sender, EventArgs e)
        {
            try
            {
                string[] inicio = txtPuntoInicial.Text.Split(',');
                string[] fin = txtPuntoFinal.Text.Split(',');

                int x0 = int.Parse(inicio[0]);
                int y0 = int.Parse(inicio[1]);
                int x1 = int.Parse(fin[0]);
                int y1 = int.Parse(fin[1]);

                lstPuntos.Items.Clear();
                Bresenham bres = new Bresenham(picPizarra, lstPuntos);
                await bres.DibujarLineaAsync(x0, y0, x1, y1);
            }
            catch
            {
                MessageBox.Show("Por favor ingresa los puntos en el formato x,y");
            }
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White); // Limpia el Bitmap con fondo blanco
            picPizarra.Image = lienzo;
            txtPuntoInicial.Clear();
            txtPuntoFinal.Clear();
            txtPuntoOrigen.Clear();
            txtRadio.Clear();
            puntoClick = null;
            lstPuntos.Items.Clear();
        }

        private async void btnCirculo_Click(object sender, EventArgs e)
        {
            try
            {
                lstPuntos.Items.Clear();
                g.Clear(Color.White);

                int centroX = picPizarra.Width / 2;
                int centroY = picPizarra.Height / 2;

                string[] partes = txtPuntoOrigen.Text.Split(',');
                int xc = int.Parse(partes[0].Trim());
                int yc = int.Parse(partes[1].Trim());
                int radio = int.Parse(txtRadio.Text.Trim());

                MidPointCircle circulo = new MidPointCircle
                {
                    Xc = xc,
                    Yc = yc,
                    R = radio
                };

                await circulo.DibujarAsync(lienzo, picPizarra, lstPuntos, centroX, centroY, Color.DarkGreen);

                picPizarra.Image = lienzo;
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Usa el formato correcto.\nEjemplo punto: 0,0   Radio: 30");
            }
        }

        private void btnRellenar_Click(object sender, EventArgs e)
        {
            if (puntoClick == null)
            {
                MessageBox.Show("Haz clic dentro del círculo primero.");
                return;
            }

            try
            {
                string[] origen = txtPuntoOrigen.Text.Split(',');
                int xCentro = int.Parse(origen[0].Trim());
                int yCentro = int.Parse(origen[1].Trim());
                int radio = int.Parse(txtRadio.Text.Trim());

                int cx = picPizarra.Width / 2;
                int cy = picPizarra.Height / 2;

                int pantallaXC = cx + xCentro;
                int pantallaYC = cy - yCentro;

                double distancia = Math.Sqrt(Math.Pow(puntoClick.Value.X - pantallaXC, 2) +
                                             Math.Pow(puntoClick.Value.Y - pantallaYC, 2));

                if (distancia <= radio)
                {
                    FloodFiller flood = new FloodFiller(lienzo, picPizarra);
                    lstPuntos.Items.Clear();
                    flood.Fill(puntoClick.Value.X, puntoClick.Value.Y, Color.Purple, lstPuntos, 50);

                    picPizarra.Image = lienzo;
                }
                else
                {
                    MessageBox.Show("Haz clic dentro del círculo para aplicar el relleno.");
                }
            }
            catch
            {
                MessageBox.Show("Error en datos del círculo. Asegúrate de que estén correctamente ingresados.");
            }
        }

        private void picPizarra_MouseClick(object sender, MouseEventArgs e)
        {
            puntoClick = e.Location;
            MessageBox.Show($"Punto seleccionado: ({e.X}, {e.Y})");
        }
    }
}
