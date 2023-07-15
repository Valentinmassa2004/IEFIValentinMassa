namespace IEFIValentinMassa
{
    partial class frmVentas
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
            this.tabVentas = new System.Windows.Forms.TabControl();
            this.tabRegistro = new System.Windows.Forms.TabPage();
            this.btnCargar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaCarga = new System.Windows.Forms.DateTimePicker();
            this.nupCantidad = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.tabConsulta = new System.Windows.Forms.TabPage();
            this.brnConsultar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.rdbCantidad = new System.Windows.Forms.RadioButton();
            this.rdbProductos = new System.Windows.Forms.RadioButton();
            this.dtgvRegistro = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_de_Registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.tabVentas.SuspendLayout();
            this.tabRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidad)).BeginInit();
            this.tabConsulta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // tabVentas
            // 
            this.tabVentas.Controls.Add(this.tabRegistro);
            this.tabVentas.Controls.Add(this.tabConsulta);
            this.tabVentas.Location = new System.Drawing.Point(28, 21);
            this.tabVentas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabVentas.Name = "tabVentas";
            this.tabVentas.SelectedIndex = 0;
            this.tabVentas.Size = new System.Drawing.Size(723, 362);
            this.tabVentas.TabIndex = 0;
            this.tabVentas.Tag = "";
            // 
            // tabRegistro
            // 
            this.tabRegistro.BackColor = System.Drawing.Color.Teal;
            this.tabRegistro.Controls.Add(this.btnCargar);
            this.tabRegistro.Controls.Add(this.label2);
            this.tabRegistro.Controls.Add(this.dtpFechaCarga);
            this.tabRegistro.Controls.Add(this.nupCantidad);
            this.tabRegistro.Controls.Add(this.label1);
            this.tabRegistro.Controls.Add(this.txtProducto);
            this.tabRegistro.Controls.Add(this.lblProducto);
            this.tabRegistro.Controls.Add(this.lblID);
            this.tabRegistro.Controls.Add(this.txtID);
            this.tabRegistro.ForeColor = System.Drawing.Color.Black;
            this.tabRegistro.Location = new System.Drawing.Point(4, 22);
            this.tabRegistro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabRegistro.Name = "tabRegistro";
            this.tabRegistro.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabRegistro.Size = new System.Drawing.Size(715, 336);
            this.tabRegistro.TabIndex = 0;
            this.tabRegistro.Text = "Registro";
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.Teal;
            this.btnCargar.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(305, 278);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(112, 56);
            this.btnCargar.TabIndex = 9;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fecha de Carga";
            // 
            // dtpFechaCarga
            // 
            this.dtpFechaCarga.Location = new System.Drawing.Point(4, 237);
            this.dtpFechaCarga.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFechaCarga.Name = "dtpFechaCarga";
            this.dtpFechaCarga.Size = new System.Drawing.Size(683, 20);
            this.dtpFechaCarga.TabIndex = 7;
            // 
            // nupCantidad
            // 
            this.nupCantidad.Location = new System.Drawing.Point(4, 171);
            this.nupCantidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nupCantidad.Name = "nupCantidad";
            this.nupCantidad.Size = new System.Drawing.Size(682, 20);
            this.nupCantidad.TabIndex = 6;
            this.nupCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cantidad";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(4, 107);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(683, 20);
            this.txtProducto.TabIndex = 3;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(4, 79);
            this.lblProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(107, 26);
            this.lblProducto.TabIndex = 2;
            this.lblProducto.Text = "Producto";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(4, 11);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(36, 26);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(4, 40);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(683, 20);
            this.txtID.TabIndex = 0;
            // 
            // tabConsulta
            // 
            this.tabConsulta.BackColor = System.Drawing.Color.Teal;
            this.tabConsulta.Controls.Add(this.brnConsultar);
            this.tabConsulta.Controls.Add(this.groupBox1);
            this.tabConsulta.Controls.Add(this.dtgvRegistro);
            this.tabConsulta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabConsulta.Location = new System.Drawing.Point(4, 22);
            this.tabConsulta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabConsulta.Name = "tabConsulta";
            this.tabConsulta.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabConsulta.Size = new System.Drawing.Size(715, 336);
            this.tabConsulta.TabIndex = 1;
            this.tabConsulta.Text = "Consulta";
            // 
            // brnConsultar
            // 
            this.brnConsultar.BackColor = System.Drawing.Color.Teal;
            this.brnConsultar.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnConsultar.Location = new System.Drawing.Point(537, 250);
            this.brnConsultar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.brnConsultar.Name = "brnConsultar";
            this.brnConsultar.Size = new System.Drawing.Size(129, 52);
            this.brnConsultar.TabIndex = 6;
            this.brnConsultar.Text = "Consultar";
            this.brnConsultar.UseVisualStyleBackColor = false;
            this.brnConsultar.Click += new System.EventHandler(this.brnConsultar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnComenzar);
            this.groupBox1.Controls.Add(this.txtFiltro);
            this.groupBox1.Controls.Add(this.rdbCantidad);
            this.groupBox1.Controls.Add(this.rdbProductos);
            this.groupBox1.Location = new System.Drawing.Point(445, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(255, 200);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnComenzar
            // 
            this.btnComenzar.BackColor = System.Drawing.Color.Teal;
            this.btnComenzar.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComenzar.Location = new System.Drawing.Point(92, 120);
            this.btnComenzar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(70, 40);
            this.btnComenzar.TabIndex = 3;
            this.btnComenzar.Text = "Comenzar";
            this.btnComenzar.UseVisualStyleBackColor = false;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(24, 70);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(198, 20);
            this.txtFiltro.TabIndex = 2;
            // 
            // rdbCantidad
            // 
            this.rdbCantidad.AutoSize = true;
            this.rdbCantidad.Location = new System.Drawing.Point(135, 34);
            this.rdbCantidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbCantidad.Name = "rdbCantidad";
            this.rdbCantidad.Size = new System.Drawing.Size(64, 17);
            this.rdbCantidad.TabIndex = 1;
            this.rdbCantidad.TabStop = true;
            this.rdbCantidad.Text = "Canidad";
            this.rdbCantidad.UseVisualStyleBackColor = true;
            // 
            // rdbProductos
            // 
            this.rdbProductos.AutoSize = true;
            this.rdbProductos.Location = new System.Drawing.Point(38, 34);
            this.rdbProductos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbProductos.Name = "rdbProductos";
            this.rdbProductos.Size = new System.Drawing.Size(73, 17);
            this.rdbProductos.TabIndex = 0;
            this.rdbProductos.TabStop = true;
            this.rdbProductos.Text = "Productos";
            this.rdbProductos.UseVisualStyleBackColor = true;
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
            this.dtgvRegistro.Location = new System.Drawing.Point(5, 26);
            this.dtgvRegistro.MultiSelect = false;
            this.dtgvRegistro.Name = "dtgvRegistro";
            this.dtgvRegistro.RowHeadersVisible = false;
            this.dtgvRegistro.RowHeadersWidth = 51;
            this.dtgvRegistro.Size = new System.Drawing.Size(380, 238);
            this.dtgvRegistro.TabIndex = 4;
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
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Teal;
            this.btnConsultar.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(323, 409);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(124, 41);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Lista";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(793, 459);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.tabVentas);
            this.Name = "frmVentas";
            this.Text = "Cargar ventas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.tabVentas.ResumeLayout(false);
            this.tabRegistro.ResumeLayout(false);
            this.tabRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidad)).EndInit();
            this.tabConsulta.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRegistro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabVentas;
        private System.Windows.Forms.TabPage tabRegistro;
        private System.Windows.Forms.TabPage tabConsulta;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.NumericUpDown nupCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaCarga;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.DataGridView dtgvRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_de_Registro;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.RadioButton rdbCantidad;
        private System.Windows.Forms.RadioButton rdbProductos;
        private System.Windows.Forms.Button brnConsultar;
    }
}