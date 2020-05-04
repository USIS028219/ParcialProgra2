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
    public partial class FBusquedaclientes : Form
    {
        ConexionDB objConexion = new ConexionDB();
        public int _idcliente;
        public FBusquedaclientes()
        {
            InitializeComponent();
            dgvclientes.DataSource = objConexion.Obtener_datos().Tables["clientes"].DefaultView;
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {

            if (dgvclientes.RowCount > 0)
            {
                _idcliente = int.Parse(dgvclientes.CurrentRow.Cells["idcliente"].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de clientes",
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
            bs.DataSource = dgvclientes.DataSource;
            bs.Filter = "nombre like '%" + valor + "%' or direccion like '%" + valor + "%' or telefono like '%" + valor + "%'";
            dgvclientes.DataSource = bs;
        }

        private void FBusquedaclientes_Load(object sender, EventArgs e)
        {

            dgvclientes.DataSource =
            objConexion.Obtener_datos().Tables["clientes"].DefaultView;

        }
    }
}
