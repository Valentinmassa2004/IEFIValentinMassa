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
        frmPrincipal objetoMain = new frmPrincipal();
        int indiceFila = 0;

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
                 
                objetoMain.listados.matrizProducto[indiceFila, 0] = txtID.Text;
                objetoMain.listados.matrizProducto[indiceFila, 1] = txtNombredelProducto.Text;
                objetoMain.listados.matrizProducto[indiceFila, 2] = dtpFechaRegistro.Text;

                indiceFila++;

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
            objetoMain.listados.Show();
        }
    }


