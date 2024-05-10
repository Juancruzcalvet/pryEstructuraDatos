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
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }
        clsArbol Arbol = new clsArbol();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigoNuevo.Text);
            ObjNodo.Nombre = txtNombreNuevo.Text;
            ObjNodo.Tramite = txtTramite.Text;
            Arbol.Agregar(ObjNodo);
            Arbol.RecorrerAsc(dgvArbol);
            Arbol.Recorrer(tvArbol);
            Arbol.RecorrerAsc(lstArbol);
            Arbol.RecorrerAsc(cmbCodigo);
            txtCodigoNuevo.Text = "";
            txtNombreNuevo.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Arbol.Raiz != null)
            {
                Int32 x = Convert.ToInt32(cmbCodigo.Text);
                Arbol.Eliminar(x); Arbol.RecorrerAsc(dgvArbol);
                Arbol.RecorrerAsc(cmbCodigo);
                Arbol.RecorrerAsc(lstArbol);
                Arbol.Recorrer(tvArbol);
                cmbCodigo.Text = "";
            }
            else
            {
                cmbCodigo.Text = "";
            }
        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            Arbol.Equilibrar();
            Arbol.RecorrerAsc(dgvArbol);
            Arbol.RecorrerAsc(cmbCodigo);
            Arbol.RecorrerAsc(lstArbol);
            Arbol.Recorrer(tvArbol);
        }

        private void optOrdAsc_CheckedChanged(object sender, EventArgs e)
        {
            Arbol.RecorrerAsc(dgvArbol);
            Arbol.RecorrerAsc(cmbCodigo);
            Arbol.RecorrerAsc(lstArbol);
        }

        private void optOrdDesc_CheckedChanged(object sender, EventArgs e)
        {
            Arbol.RecorrerDesc(dgvArbol);
            Arbol.RecorrerDesc(cmbCodigo);
            Arbol.RecorrerDesc(lstArbol);
        }

        private void optPost_CheckedChanged(object sender, EventArgs e)
        {
            Arbol.RecorrerPre(dgvArbol);
            Arbol.RecorrerPre(cmbCodigo);
            Arbol.RecorrerPre(lstArbol);
        }

        private void optPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            Arbol.RecorrerPost(dgvArbol);
            Arbol.RecorrerPost(cmbCodigo);
            Arbol.RecorrerPost(lstArbol);
        }
    }
}
