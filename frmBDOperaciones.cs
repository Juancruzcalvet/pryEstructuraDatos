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
    public partial class frmBDOperaciones : Form
    {
        public frmBDOperaciones()
        {
            InitializeComponent();
        }
        clsBaseDeDatos objBaseDatos = new clsBaseDeDatos();

        private void btnProyeccionSimple_Click(object sender, EventArgs e)
        {
            String consulta = "SELECT TITULO " + "FROM LIBRO " + "ORDER BY TITULO ASC";
            objBaseDatos.Listar(dgvBaseDatos, consulta);
        }

        private void btnProyeccionMultiatributo_Click(object sender, EventArgs e)
        {
            String consulta = "SELECT TITULO, AÑO " + "FROM LIBRO " + "ORDER BY 1 DESC";
            objBaseDatos.Listar(dgvBaseDatos, consulta);
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            String consulta = "SELECT * " + "FROM LIBRO, IDIOMA " + "WHERE LIBRO.IdIdioma = IDIOMA.IdIdioma";
            objBaseDatos.Listar(dgvBaseDatos, consulta);
        }

        private void btnSeleccionSimple_Click(object sender, EventArgs e)
        {
            String consulta = "SELECT * " + "FROM LIBRO " + "WHERE IDIDIOMA = 1 " + "UNION " + "SELECT * " + "FROM LIBRO " + "WHERE IDIDIOMA = 13 " + "UNION " + "SELECT * " + "FROM LIBRO " + "WHERE IDIDIOMA = 3";
            objBaseDatos.Listar(dgvBaseDatos, consulta);
        }

        private void btnSeleccionMultiatributo_Click(object sender, EventArgs e)
        {
            String consulta = "SELECT * " + "FROM LIBRO " + "WHERE IDLIBRO " + "IN " + "(SELECT DISTINCT IDLIBRO " + "FROM LIBRO " + "WHERE IDLIBRO < 20)";
            objBaseDatos.Listar(dgvBaseDatos, consulta);
        }

        private void btnSeleccionPorConvolucion_Click(object sender, EventArgs e)
        {
            String consulta = "SELECT * " + "FROM " + "(SELECT * " + "FROM LIBRO " + "AS T1 " + "WHERE T1.CANTIDAD > 5) " + "AS T2 " + "WHERE T2.IDPAIS > 20";
            objBaseDatos.Listar(dgvBaseDatos, consulta);
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            String consulta = "SELECT * " + "FROM LIBRO " + "WHERE IDIDIOMA = 2 " + "UNION " + "SELECT * " + "FROM LIBRO " + "WHERE IDAUTOR = 5 " + "UNION " + "SELECT * " + "FROM LIBRO " + "WHERE IDPAIS = 3";
            objBaseDatos.Listar(dgvBaseDatos, consulta);
        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            String consulta = "SELECT * " + "FROM IDIOMA " + "WHERE IDIDIOMA " + "IN (SELECT IDIDIOMA FROM LIBRO)";
            objBaseDatos.Listar(dgvBaseDatos, consulta);
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            String consulta = "SELECT * " + "FROM AUTOR " + "WHERE IDAUTOR " + "NOT IN (SELECT IDAUTOR FROM LIBRO)";
            objBaseDatos.Listar(dgvBaseDatos, consulta);
        }
    }
}
