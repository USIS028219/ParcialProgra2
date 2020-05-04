namespace Torres_Anibal_Parcial
{
    partial class FBusquedapeliculas
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnseleccionar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvpeliculas = new System.Windows.Forms.DataGridView();
            this.idpelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinopsis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtbuscar);
            this.panel2.Controls.Add(this.lblbuscar);
            this.panel2.Controls.Add(this.btncancelar);
            this.panel2.Controls.Add(this.btnseleccionar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(553, 61);
            this.panel2.TabIndex = 8;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(75, 21);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(230, 20);
            this.txtbuscar.TabIndex = 8;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbuscar.Location = new System.Drawing.Point(12, 22);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(56, 16);
            this.lblbuscar.TabIndex = 7;
            this.lblbuscar.Text = "Buscar";
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(446, 14);
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
            this.btnseleccionar.Location = new System.Drawing.Point(311, 14);
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.Size = new System.Drawing.Size(105, 32);
            this.btnseleccionar.TabIndex = 5;
            this.btnseleccionar.Text = "Seleccionar";
            this.btnseleccionar.UseVisualStyleBackColor = true;
            this.btnseleccionar.Click += new System.EventHandler(this.btnseleccionar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvpeliculas);
            this.panel1.Location = new System.Drawing.Point(0, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 295);
            this.panel1.TabIndex = 7;
            // 
            // dgvpeliculas
            // 
            this.dgvpeliculas.AllowUserToAddRows = false;
            this.dgvpeliculas.AllowUserToDeleteRows = false;
            this.dgvpeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpeliculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpelicula,
            this.descripcion,
            this.sinopsis,
            this.genero,
            this.duracion});
            this.dgvpeliculas.Location = new System.Drawing.Point(6, 19);
            this.dgvpeliculas.Name = "dgvpeliculas";
            this.dgvpeliculas.ReadOnly = true;
            this.dgvpeliculas.Size = new System.Drawing.Size(543, 252);
            this.dgvpeliculas.TabIndex = 1;
            // 
            // idpelicula
            // 
            this.idpelicula.HeaderText = "ID Pelicula";
            this.idpelicula.Name = "idpelicula";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            // 
            // sinopsis
            // 
            this.sinopsis.HeaderText = "Sinopsis";
            this.sinopsis.Name = "sinopsis";
            // 
            // genero
            // 
            this.genero.HeaderText = "Genero";
            this.genero.Name = "genero";
            // 
            // duracion
            // 
            this.duracion.HeaderText = "Duracion";
            this.duracion.Name = "duracion";
            // 
            // FBusquedapeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 366);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FBusquedapeliculas";
            this.Text = "Busqueda peliculas";
            this.Load += new System.EventHandler(this.FBusquedapeliculas_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpeliculas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnseleccionar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvpeliculas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinopsis;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracion;
    }
}