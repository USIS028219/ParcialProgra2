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
    public partial class FBusquedaregistroalquiler : Form
    {

        ConexionDB objConexion = new ConexionDB();
        public int _idalquiler;

        public FBusquedaregistroalquiler()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            FAlquiler cambio = new FAlquiler();
            this.Hide();
            cambio.ShowDialog();
            this.Close();
        }

        private void FBusquedaregistroalquiler_Load(object sender, EventArgs e)
        {

            dgvregistroalquiler.DataSource =
            objConexion.Obtener_datos().Tables["alquiler"].DefaultView;

        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {

            if (dgvregistroalquiler.RowCount > 0)
            {
                _idalquiler = int.Parse(dgvregistroalquiler.CurrentRow.Cells["idalquiler"].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de peliculas",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            FiltrarDatos(textBox1.Text);

        }

        void FiltrarDatos(string valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvregistroalquiler.DataSource;
            bs.Filter = "fechaprestamo like '%" + valor + "%' or fechadevolucion like '%" + valor + "%' or valor like '%" + valor + "%'";
            dgvregistroalquiler.DataSource = bs;
        }

    }
}
