using System;
namespace IEFIValentinMassa {  
    partial class frmProductos
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.mrcCargadeproductos = new System.Windows.Forms.GroupBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.lblFechaRegisro = new System.Windows.Forms.Label();
            this.txtNombredelProducto = new System.Windows.Forms.TextBox();
            this.lblNombredelProducto = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.mrcListadoProductos = new System.Windows.Forms.GroupBox();
            this.btnListado = new System.Windows.Forms.Button();
            this.dtgvRegistro = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_de_Registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.btnVolver = new System.Windows.Forms.Button();
            this.mrcCargadeproductos.SuspendLayout();
            this.mrcListadoProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Window;
            this.txtID.Location = new System.Drawing.Point(20, 48);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(261, 22);
            this.txtID.TabIndex = 0;
            // 
            // mrcCargadeproductos
            // 
            this.mrcCargadeproductos.Controls.Add(this.btnCargar);
            this.mrcCargadeproductos.Controls.Add(this.dtpFechaRegistro);
            this.mrcCargadeproductos.Controls.Add(this.lblFechaRegisro);
            this.mrcCargadeproductos.Controls.Add(this.txtNombredelProducto);
            this.mrcCargadeproductos.Controls.Add(this.lblNombredelProducto);
            this.mrcCargadeproductos.Controls.Add(this.lblID);
            this.mrcCargadeproductos.Controls.Add(this.txtID);
            this.mrcCargadeproductos.Location = new System.Drawing.Point(24, 30);
            this.mrcCargadeproductos.Name = "mrcCargadeproductos";
            this.mrcCargadeproductos.Size = new System.Drawing.Size(592, 209);
            this.mrcCargadeproductos.TabIndex = 1;
            this.mrcCargadeproductos.TabStop = false;
            this.mrcCargadeproductos.Text = "Carga de productos";
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.Teal;
            this.btnCargar.Font = new System.Drawing.Font("Pristina", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(449, 88);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(90, 54);
            this.btnCargar.TabIndex = 6;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Location = new System.Drawing.Point(20, 168);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(261, 22);
            this.dtpFechaRegistro.TabIndex = 5;
            // 
            // lblFechaRegisro
            // 
            this.lblFechaRegisro.AutoSize = true;
            this.lblFechaRegisro.Location = new System.Drawing.Point(17, 149);
            this.lblFechaRegisro.Name = "lblFechaRegisro";
            this.lblFechaRegisro.Size = new System.Drawing.Size(99, 16);
            this.lblFechaRegisro.TabIndex = 4;
            this.lblFechaRegisro.Text = "Fecha Registro";
            // 
            // txtNombredelProducto
            // 
            this.txtNombredelProducto.Location = new System.Drawing.Point(20, 108);
            this.txtNombredelProducto.Name = "txtNombredelProducto";
            this.txtNombredelProducto.Size = new System.Drawing.Size(261, 22);
            this.txtNombredelProducto.TabIndex = 3;
            // 
            // lblNombredelProducto
            // 
            this.lblNombredelProducto.AutoSize = true;
            this.lblNombredelProducto.Location = new System.Drawing.Point(17, 88);
            this.lblNombredelProducto.Name = "lblNombredelProducto";
            this.lblNombredelProducto.Size = new System.Drawing.Size(135, 16);
            this.lblNombredelProducto.TabIndex = 2;
            this.lblNombredelProducto.Text = "Nombre del Producto";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(17, 29);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 16);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID";
            // 
            // mrcListadoProductos
            // 
            this.mrcListadoProductos.Controls.Add(this.btnListado);
            this.mrcListadoProductos.Controls.Add(this.dtgvRegistro);
            this.mrcListadoProductos.Location = new System.Drawing.Point(24, 280);
            this.mrcListadoProductos.Name = "mrcListadoProductos";
            this.mrcListadoProductos.Size = new System.Drawing.Size(908, 194);
            this.mrcListadoProductos.TabIndex = 2;
            this.mrcListadoProductos.TabStop = false;
            this.mrcListadoProductos.Text = "Listado de Productos";
            // 
            // btnListado
            // 
            this.btnListado.BackColor = System.Drawing.Color.Teal;
            this.btnListado.Font = new System.Drawing.Font("Pristina", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListado.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnListado.Location = new System.Drawing.Point(742, 124);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(145, 58);
            this.btnListado.TabIndex = 2;
            this.btnListado.Text = "Listado";
            this.btnListado.UseVisualStyleBackColor = false;
            this.btnListado.Click += new System.EventHandler(this.btnListado_Click);
            // 
            // dtgvRegistro
            // 
            this.dtgvRegistro.AllowUserToAddRows = false;
            this.dtgvRegistro.AllowUserToDeleteRows = false;
            this.dtgvRegistro.AllowUserToResizeColumns = false;
            this.dtgvRegistro.AllowUserToResizeRows = false;
            this.dtgvRegistro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvRegistro.BackgroundColor = System.Drawing.Color.Teal;
            this.dtgvRegistro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvRegistro.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Fecha_de_Registro});
            this.dtgvRegistro.Enabled = false;
            this.dtgvRegistro.EnableHeadersVisualStyles = false;
            this.dtgvRegistro.GridColor = System.Drawing.Color.Black;
            this.dtgvRegistro.Location = new System.Drawing.Point(20, 31);
            this.dtgvRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvRegistro.MultiSelect = false;
            this.dtgvRegistro.Name = "dtgvRegistro";
            this.dtgvRegistro.RowHeadersVisible = false;
            this.dtgvRegistro.RowHeadersWidth = 51;
            this.dtgvRegistro.Size = new System.Drawing.Size(560, 133);
            this.dtgvRegistro.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            // 
            // Fecha_de_Registro
            // 
            this.Fecha_de_Registro.HeaderText = "Fecha de Registro";
            this.Fecha_de_Registro.MinimumWidth = 6;
            this.Fecha_de_Registro.Name = "Fecha_de_Registro";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Teal;
            this.btnVolver.Font = new System.Drawing.Font("Pristina", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(381, 510);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(121, 58);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1067, 580);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.mrcListadoProductos);
            this.Controls.Add(this.mrcCargadeproductos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProductos";
            this.Text = "Cargar Productos";
            this.mrcCargadeproductos.ResumeLayout(false);
            this.mrcCargadeproductos.PerformLayout();
            this.mrcListadoProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRegistro)).EndInit();
            this.ResumeLayout(false);
        }




        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox mrcCargadeproductos;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblFechaRegisro;
        private System.Windows.Forms.TextBox txtNombredelProducto;
        private System.Windows.Forms.Label lblNombredelProducto;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.GroupBox mrcListadoProductos;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button btnListado;
        private System.Windows.Forms.DataGridView dtgvRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_de_Registro;
        private System.Windows.Forms.Button btnVolver;
        }
}


#endregion
