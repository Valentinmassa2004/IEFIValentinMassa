namespace IEFIValentinMassa
{
    partial class frmListados
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
            this.mrcFiltro = new System.Windows.Forms.GroupBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lstVentas = new System.Windows.Forms.ComboBox();
            this.rdbVentas = new System.Windows.Forms.RadioButton();
            this.rdbProductos = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.dtgvRegistro = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_de_Registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrcFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcFiltro
            // 
            this.mrcFiltro.Controls.Add(this.btnFiltrar);
            this.mrcFiltro.Controls.Add(this.lstVentas);
            this.mrcFiltro.Controls.Add(this.rdbVentas);
            this.mrcFiltro.Controls.Add(this.rdbProductos);
            this.mrcFiltro.Location = new System.Drawing.Point(9, 10);
            this.mrcFiltro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mrcFiltro.Name = "mrcFiltro";
            this.mrcFiltro.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mrcFiltro.Size = new System.Drawing.Size(492, 81);
            this.mrcFiltro.TabIndex = 0;
            this.mrcFiltro.TabStop = false;
            this.mrcFiltro.Text = "Filtro";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.Teal;
            this.btnFiltrar.Font = new System.Drawing.Font("Pristina", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(382, 24);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(92, 32);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // lstVentas
            // 
            this.lstVentas.FormattingEnabled = true;
            this.lstVentas.Location = new System.Drawing.Point(214, 34);
            this.lstVentas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstVentas.Name = "lstVentas";
            this.lstVentas.Size = new System.Drawing.Size(92, 21);
            this.lstVentas.TabIndex = 2;
            // 
            // rdbVentas
            // 
            this.rdbVentas.AutoSize = true;
            this.rdbVentas.Location = new System.Drawing.Point(157, 37);
            this.rdbVentas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbVentas.Name = "rdbVentas";
            this.rdbVentas.Size = new System.Drawing.Size(58, 17);
            this.rdbVentas.TabIndex = 1;
            this.rdbVentas.TabStop = true;
            this.rdbVentas.Text = "Ventas";
            this.rdbVentas.UseVisualStyleBackColor = true;
            this.rdbVentas.CheckedChanged += new System.EventHandler(this.rdbVentas_CheckedChanged);
            // 
            // rdbProductos
            // 
            this.rdbProductos.AutoSize = true;
            this.rdbProductos.Location = new System.Drawing.Point(50, 37);
            this.rdbProductos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbProductos.Name = "rdbProductos";
            this.rdbProductos.Size = new System.Drawing.Size(73, 17);
            this.rdbProductos.TabIndex = 0;
            this.rdbProductos.TabStop = true;
            this.rdbProductos.Text = "Productos";
            this.rdbProductos.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Pristina", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(42, 96);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Listar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.dtgvRegistro.Location = new System.Drawing.Point(9, 141);
            this.dtgvRegistro.MultiSelect = false;
            this.dtgvRegistro.Name = "dtgvRegistro";
            this.dtgvRegistro.RowHeadersVisible = false;
            this.dtgvRegistro.RowHeadersWidth = 51;
            this.dtgvRegistro.Size = new System.Drawing.Size(492, 171);
            this.dtgvRegistro.TabIndex = 3;
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
            // frmListados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(520, 334);
            this.Controls.Add(this.dtgvRegistro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mrcFiltro);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmListados";
            this.Text = "Listados";
            this.Load += new System.EventHandler(this.frmListados_Load_1);
            this.mrcFiltro.ResumeLayout(false);
            this.mrcFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRegistro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcFiltro;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox lstVentas;
        private System.Windows.Forms.RadioButton rdbVentas;
        private System.Windows.Forms.RadioButton rdbProductos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtgvRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_de_Registro;
    }
}