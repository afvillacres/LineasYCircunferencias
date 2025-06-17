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
    public partial class FrmLinea : Form
    {
        private Line objLine = new Line();
        public FrmLinea()
        {
            InitializeComponent();
        }

        private static FrmLinea instancia;
        public static FrmLinea ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmLinea();
            }
            return instancia;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            objLine.InitializeData(picCanvas);
        }

        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            objLine.DrawLineMouse(e, (PictureBox)sender);
        }
    }
}
