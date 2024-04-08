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
    public partial class frmEstructuraLinealCola : Form
    {
        public frmEstructuraLinealCola()
        {
            InitializeComponent();
        }
        clsCola Fila = new clsCola();

        private void frmEstructuraLinealCola_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Si no anota nada, sale error.
            if (txtCodigoNuevo.Text == null & txtNombreNuevo.Text == null & txtTramite == null)
            {
                txtTramite.Text = "";
                txtNombreNuevo.Text = "";
                txtCodigoNuevo.Text = "";
                
            }
            else //Llenamos grilla, lista y archivo, agregamos datos y limpiamos textbox
            {
                clsNodo objNodo = new clsNodo();
                objNodo.Nombre = txtNombreNuevo.Text;
                objNodo.Codigo = Convert.ToInt32(txtCodigoNuevo.Text);
                objNodo.Tramite= txtTramite.Text;
                Fila.Agregar(objNodo);
                Fila.Recorrer();
                Fila.Recorrer(lstLista);
                Fila.Recorrer(dgvEstructuraCola);
                txtTramite.Text = "";
                txtNombreNuevo.Text = "";
                txtCodigoNuevo.Text = "";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            lblCodigo.Text = Convert.ToString(Fila.Ultimo.Codigo);
            lblTramite.Text = Fila.Ultimo.Tramite;
            lblNombre.Text = Fila.Ultimo.Nombre;
            Fila.Eliminar();
            Fila.Recorrer();
            Fila.Recorrer(lstLista);
            Fila.Recorrer(dgvEstructuraCola);
        }
    }
}
