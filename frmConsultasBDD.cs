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
    public partial class frmConsultasBDD : Form
    {
        public frmConsultasBDD()
        {
            InitializeComponent();
        }
        clsBaseDeDatos BD = new clsBaseDeDatos();
        private void btnListar_Click(object sender, EventArgs e)
        {
            if (txtConsulta.Text == string.Empty)
            {
                MessageBox.Show("Inserte una consulta");
            }
            else
            {
                string query = txtConsulta.Text;
                BD.Listar(dgvConsultaBDD, query);
            }
        }

        private void frmConsultasBDD_Load(object sender, EventArgs e)
        {
            BD.Listar(dgvConsultaBDD);
        }
    }
}
