using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Torres_Anibal_Parcial
{
    public partial class FBusquedapeliculas : Form
    {
        ConexionDB objConexion = new ConexionDB();
        public int _idpelicula;
        public FBusquedapeliculas()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (dgvpeliculas.RowCount > 0)
            {
                _idpelicula = int.Parse(dgvpeliculas.CurrentRow.Cells["idpelicula"].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de peliculas",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarDatos(txtbuscar.Text);
        }
        void FiltrarDatos(string valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvpeliculas.DataSource;
            bs.Filter = "descripcion like '%" + valor + "%' or genero like '%" + valor + "%' or sinopsis like '%" + valor + "%'";
            dgvpeliculas.DataSource = bs;
        }

        private void FBusquedapeliculas_Load(object sender, EventArgs e)
        {

            dgvpeliculas.DataSource =
            objConexion.Obtener_datos().Tables["peliculas"].DefaultView;

        }
    }
}
