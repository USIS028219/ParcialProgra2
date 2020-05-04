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
    public partial class FAlquiler : Form
    {
        ConexionDB objConexion = new ConexionDB();
        int posicion = 0;
        string accion = "Nuevo";
        DataTable tbl = new DataTable();
        public FAlquiler()
        {
            InitializeComponent();
        }
        private void FAlquiler_Load(object sender, EventArgs e)
        {
            ActualizarDs();
            MostrarDatos();
        }
        void ActualizarDs()
        {
            tbl = objConexion.Obtener_datos().Tables["alquiler"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["idalquiler"] };
        }
        void MostrarDatos()
        {
            try
            {
                lblidalquiler.Text = tbl.Rows[posicion].ItemArray[0].ToString();

                cboclientes.DataSource = objConexion.Obtener_datos().Tables["clientes"];
                cboclientes.DisplayMember = "nombre";
                cboclientes.ValueMember = "clientes.idcliente";
                cboclientes.SelectedValue = tbl.Rows[posicion].ItemArray[1].ToString();

                cbopeliculas.DataSource = objConexion.Obtener_datos().Tables["peliculas"];
                cbopeliculas.DisplayMember = "descripcion";
                cbopeliculas.ValueMember = "peliculas.idpelicula";
                cbopeliculas.SelectedValue = tbl.Rows[posicion].ItemArray[2].ToString();

                txtfprestamo.Text = tbl.Rows[posicion].ItemArray[3].ToString();
                txtfdevolucion.Text = tbl.Rows[posicion].ItemArray[4].ToString();
                txtvalor.Text = tbl.Rows[posicion].ItemArray[5].ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay Datos que mostrar", "Registros de alquiler",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar_cajas();
            }
        }

        void Limpiar_cajas()
        {
            txtfprestamo.Text = "";
            txtfdevolucion.Text = "";
            txtvalor.Text = "";
        }
        void Controles(Boolean valor)
        {
            grbnavegacion.Enabled = valor;
            btneliminar.Enabled = valor;
            btnbuscar.Enabled = valor;
            panel1.Enabled = !valor;
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
                    lblidalquiler.Text,
                    cboclientes.SelectedValue.ToString(),
                    cbopeliculas.SelectedValue.ToString(),
                    txtfprestamo.Text,
                    txtfdevolucion.Text,
                    txtvalor.Text,
                };
                objConexion.movimiento_alquiler(valores, accion);
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
            if (MessageBox.Show("Esta seguro de eliminar la fecha " + txtfprestamo.Text,"Registro de Alquiler",
              MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = { lblidalquiler.Text };
                objConexion.movimiento_alquiler(valores, "Eliminar");

                ActualizarDs();
                posicion = posicion > 0 ? posicion - 1 : 0;
                MostrarDatos();
            }
        }

        private void btnbuscar_Click_1(object sender, EventArgs e)
        {
            FBusquedaregistroalquiler cambio = new FBusquedaregistroalquiler();
            this.Hide();
            cambio.ShowDialog();
            this.Close();
        }

        private void btnmenu_Click_1(object sender, EventArgs e)
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
