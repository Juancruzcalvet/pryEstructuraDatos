using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDatos
{
    public partial class frmVentanaPrincipal : Form
    {
        public frmVentanaPrincipal()
        {
            InitializeComponent();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosDesarrollador frmDatosDesarrollador = new frmDatosDesarrollador();
            frmDatosDesarrollador.Show();
            this.Hide();
        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstructuraLinealCola frmEstructuraLinealCola = new frmEstructuraLinealCola();
            frmEstructuraLinealCola.Show();
            
        }

        private void simpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSimple frmListaSimple = new frmListaSimple();
            frmListaSimple.Show();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila frmPila = new frmPila();
            frmPila.ShowDialog();
        }

        private void tsmDoble_Click(object sender, EventArgs e)
        {
            frmListaDoble frmListaDoble = new frmListaDoble();
            frmListaDoble.Show();
        }
    }
}
