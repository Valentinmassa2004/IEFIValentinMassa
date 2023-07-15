using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEFIValentinMassa
{
    public partial class frmProductos : Form
    {
        frmListados Listado = new frmListados();
        int indicefila = 0;
        public frmProductos()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (dtpFechaRegistro.Value >= DateTime.Today)
            {
                MessageBox.Show("Vamos a registrar su producto");

                int n = dtgvRegistro.Rows.Add();

                dtgvRegistro.Rows[n].Cells[0].Value = txtID.Text;
                dtgvRegistro.Rows[n].Cells[1].Value = txtNombredelProducto.Text;
                dtgvRegistro.Rows[n].Cells[2].Value = dtpFechaRegistro.Text;
                 
                Listado.matrizProducto[indicefila, 0] = txtID.Text;
                Listado.matrizProducto[indicefila, 1] = txtNombredelProducto.Text;
                Listado.matrizProducto[indicefila, 2] = dtpFechaRegistro.Text;

                indicefila++;

            }
            else
            {
                MessageBox.Show("Ingrese una fecha actual");
                dtpFechaRegistro.Value=DateTime.Today;
                dtpFechaRegistro.Focus();

            }
            
    }

        private void btnListado_Click(object sender, EventArgs e)
        {
            Listado.ShowDialog();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {

        }
    }
}


