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
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }
        clsListaSimple Lista = new clsListaSimple();

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
            btnAgregar.Enabled = false;
            
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoNuevo.Text != null && txtNombreNuevo.Text != null && txtTramite.Text != null)
            {
                btnAgregar.Enabled = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Int32 x = Convert.ToInt32(cmbCodigo.Text);
            Lista.Eliminar(x);
            Lista.Recorrer(dgvEstructuraCola);
            Lista.Recorrer(lstLista);
            Lista.Recorrer(cmbCodigo);
            Lista.Recorrer();
            btnEliminar.Enabled = false;
        }

        private void cmbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEliminar.Enabled = true;
        }
    }
}
