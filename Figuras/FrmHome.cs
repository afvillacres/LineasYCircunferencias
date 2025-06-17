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
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void dibujarLineasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLinea frmLines = FrmLinea.ObtenerInstancia();
            frmLines.MdiParent = this;
            if (!frmLines.Visible)
            {
                frmLines.Show();
            }
            else
            {
                frmLines.BringToFront();
            }
        }

        private void rectasYCircunferenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRectasCirculos frmRectasCirculos = FrmRectasCirculos.ObtenerInstancia();
            frmRectasCirculos.MdiParent = this;
            if (!frmRectasCirculos.Visible)
            {
                frmRectasCirculos.Show();
            }
            else
            {
                frmRectasCirculos.BringToFront();
            }
        }
    }
}
