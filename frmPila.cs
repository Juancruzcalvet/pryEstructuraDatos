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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }
        clsCola Cola = new clsCola();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigoNuevo == null & txtNombreNuevo == null & txtTramite == null)
            {
                MessageBox.Show("Ingresar datos");
            }
            else
            {
                clsNodo objNodo = new clsNodo();
                objNodo.Nombre = txtNombreNuevo.Text;
                objNodo.Tramite = txtTramite.Text;
                objNodo.Codigo = Convert.ToInt32(txtCodigoNuevo.Text);
                Cola.Agregar(objNodo);
                Cola.Recorrer();
                Cola.Recorrer(dgvEstructuraPila);
                Cola.Recorrer(lstListaPila);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            if(Cola != null) 
            {
                lblTramite.Text = objNodo.Tramite;
                lblNombre.Text = objNodo.Nombre;
                lblCodigo.Text = Convert.ToString(objNodo.Codigo);
                Cola.Eliminar();
            }
            else
            {
                lblCodigo.Text = null;
                lblNombre.Text = null;
                lblTramite.Text = null;
            }
            Cola.Recorrer();
            Cola.Recorrer(dgvEstructuraPila);
            Cola.Recorrer(lstListaPila);

        }


    }
}
