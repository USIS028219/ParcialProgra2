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
    public partial class FClientes : Form
    {
        ConexionDB objConexion = new ConexionDB();
        int posicion = 0;
        public string accion = "Nuevo";
        DataTable tbl = new DataTable();
        public FClientes()
        {
            InitializeComponent();
        }

        
        void ActualizarDs()
        {
            tbl = objConexion.Obtener_datos().Tables["clientes"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["idcliente"] };
            MostrarDatos();
        }
        void MostrarDatos()
        {
            try
            {
                lblidc.Text = tbl.Rows[posicion].ItemArray[0].ToString();
                txtnombre.Text = tbl.Rows[posicion].ItemArray[1].ToString();
                txtdireccion.Text = tbl.Rows[posicion].ItemArray[2].ToString();
                txttelefono.Text = tbl.Rows[posicion].ItemArray[3].ToString();
                txtdui.Text = tbl.Rows[posicion].ItemArray[4].ToString();

                lblregistro.Text = (posicion + 1) + " de " + tbl.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay Datos que mostrar", "Registros de clientes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar_cajas();
            }
        }
        void Limpiar_cajas()
        {
            txtnombre.Text = "";
            txtdireccion.Text = "";
            txttelefono.Text = "";
            txtdui.Text = "";
        }
        void Controles(Boolean valor)
        {
            panelcontrol.Enabled = valor;
            btneliminar.Enabled = valor;
            btnbuscar.Enabled = valor;
            grdatos.Enabled = !valor;
        }
        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (btnagregar.Text == "Nuevo")
            {
                btnagregar.Text = "Guardar";
                btnmodificar.Text = "Cancelar";
                accion = "Nuevo";

                Limpiar_cajas();
                Controles(false);
            }
            else
            {
                String[] valores = {
                    lblidc.Text,
                    txtnombre.Text,
                    txtdireccion.Text,
                    txttelefono.Text,
                    txtdui.Text,
                };
                objConexion.movimiento_clientes(valores, accion);
                ActualizarDs();
                posicion = tbl.Rows.Count - 1;
                MostrarDatos();

                Controles(true);

                btnagregar.Text = "Nuevo";
                btnmodificar.Text = "Modificar";
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (btnmodificar.Text == "Modificar")
            {
                btnagregar.Text = "Guardar";
                btnmodificar.Text = "Cancelar";
                accion = "Modificar";

                Controles(false);

                btnagregar.Text = "Guardar";
                btnmodificar.Text = "Cancelar";
            }
            else
            {
                Controles(true);
                MostrarDatos();

                btnagregar.Text = "Nuevo";
                btnmodificar.Text = "Modificar";
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de elimina a " + txtnombre.Text, "Registro de Clientes",
              MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = { lblidc.Text };
                objConexion.movimiento_clientes(valores, "Eliminar");

                ActualizarDs();
                posicion = posicion > 0 ? posicion - 1 : 0;
                MostrarDatos();
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            FBusquedaclientes frmBusquedaclientes = new FBusquedaclientes();
            frmBusquedaclientes.ShowDialog();

            if (frmBusquedaclientes._idcliente > 0)
            {
                posicion = tbl.Rows.IndexOf(tbl.Rows.Find(frmBusquedaclientes._idcliente));
                MostrarDatos();
            }
        }

        private void btnprimero_Click(object sender, EventArgs e)
        {
            posicion = 0;
            MostrarDatos();
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                MostrarDatos();
            }
            else
            {
                MessageBox.Show("Primer Registro...", "Registros de Cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnadelante_Click(object sender, EventArgs e)
        {
            if (posicion < tbl.Rows.Count - 1)
            {
                posicion++;
                MostrarDatos();
            }
            else
            {
                MessageBox.Show("Ultimo Registro...", "Registros de Cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnultimo_Click(object sender, EventArgs e)
        {
            posicion = tbl.Rows.Count - 1;
            MostrarDatos();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Fmenu cambio = new Fmenu();
            this.Hide();
            cambio.ShowDialog();
            this.Close();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
