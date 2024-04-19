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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }

        clsListaDoble Lista = new clsListaDoble();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigoNuevo.Text);
            ObjNodo.Nombre = txtNombreNuevo.Text;
            ObjNodo.Tramite = txtTramite.Text;
            Lista.Agregar(ObjNodo);
            Lista.Recorrer(dgvEstructuraCola);
            Lista.Recorrer(lstLista);
            Lista.Recorrer(cmbCodigo);
            Lista.Recorrer();
            txtCodigoNuevo.Text = "";
            txtNombreNuevo.Text = "";
            txtTramite.Text = "";
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Int32 x = Convert.ToInt32(cmbCodigo.Text);
            Lista.Eliminar(x);
            Lista.Recorrer(dgvEstructuraCola);
            Lista.Recorrer(lstLista);
            Lista.Recorrer(cmbCodigo);
            Lista.Recorrer();
            
        }

        private void optDescendiente_CheckedChanged(object sender, EventArgs e)
        {
            Lista.RecorrerDescendiente(dgvEstructuraCola);

        }

        private void optAscendente_CheckedChanged(object sender, EventArgs e)
        {
            Lista.Recorrer(dgvEstructuraCola);

        }
    }
}
