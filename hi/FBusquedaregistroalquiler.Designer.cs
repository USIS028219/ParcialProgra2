namespace Torres_Anibal_Parcial
{
    partial class FBusquedaregistroalquiler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvregistroalquiler = new System.Windows.Forms.DataGridView();
            this.idalquiler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaprestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechadevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnseleccionar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvregistroalquiler)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvregistroalquiler);
            this.panel1.Location = new System.Drawing.Point(0, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 267);
            this.panel1.TabIndex = 5;
            // 
            // dgvregistroalquiler
            // 
            this.dgvregistroalquiler.AllowUserToAddRows = false;
            this.dgvregistroalquiler.AllowUserToDeleteRows = false;
            this.dgvregistroalquiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvregistroalquiler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idalquiler,
            this.idcliente,
            this.idpelicula,
            this.fechaprestamo,
            this.fechadevolucion,
            this.valor});
            this.dgvregistroalquiler.Location = new System.Drawing.Point(7, 3);
            this.dgvregistroalquiler.Name = "dgvregistroalquiler";
            this.dgvregistroalquiler.ReadOnly = true;
            this.dgvregistroalquiler.Size = new System.Drawing.Size(642, 249);
            this.dgvregistroalquiler.TabIndex = 1;
            // 
            // idalquiler
            // 
            this.idalquiler.HeaderText = "ID Registro";
            this.idalquiler.Name = "idalquiler";
            this.idalquiler.ReadOnly = true;
            // 
            // idcliente
            // 
            this.idcliente.HeaderText = "ID Cliente";
            this.idcliente.Name = "idcliente";
            this.idcliente.ReadOnly = true;
            // 
            // idpelicula
            // 
            this.idpelicula.HeaderText = "ID Pelicula";
            this.idpelicula.Name = "idpelicula";
            this.idpelicula.ReadOnly = true;
            // 
            // fechaprestamo
            // 
            this.fechaprestamo.HeaderText = "Fecha de Prestamo";
            this.fechaprestamo.Name = "fechaprestamo";
            this.fechaprestamo.ReadOnly = true;
            // 
            // fechadevolucion
            // 
            this.fechadevolucion.HeaderText = "Fecha de Devolucion";
            this.fechadevolucion.Name = "fechadevolucion";
            this.fechadevolucion.ReadOnly = true;
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btncancelar);
            this.panel2.Controls.Add(this.btnseleccionar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(653, 61);
            this.panel2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Buscar";
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(466, 17);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(103, 31);
            this.btncancelar.TabIndex = 6;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseleccionar.Location = new System.Drawing.Point(325, 16);
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.Size = new System.Drawing.Size(105, 32);
            this.btnseleccionar.TabIndex = 5;
            this.btnseleccionar.Text = "Seleccionar";
            this.btnseleccionar.UseVisualStyleBackColor = true;
            this.btnseleccionar.Click += new System.EventHandler(this.btnseleccionar_Click);
            // 
            // FBusquedaregistroalquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 346);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FBusquedaregistroalquiler";
            this.Text = "FBusquedaregistroalquiler";
            this.Load += new System.EventHandler(this.FBusquedaregistroalquiler_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvregistroalquiler)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvregistroalquiler;
        private System.Windows.Forms.DataGridViewTextBoxColumn idalquiler;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaprestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechadevolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnseleccionar;
    }
}