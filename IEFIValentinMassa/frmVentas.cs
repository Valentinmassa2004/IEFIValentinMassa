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
    public partial class frmVentas : Form
    {
        frmPrincipal objetoMain = new frmPrincipal();
        string[,] matrizVentas = new string[10, 4];
        int Indicefila = 0;
        private int indiceFila;

        public frmVentas()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            string id, producto, fecha, cantidad;
            id = txtID.Text.ToString();
            producto = txtProducto.Text.ToString();
            fecha = dtpFechaCarga.Text.ToString();
            cantidad = nupCantidad.Text.ToString();

            //CARGAMOS DATOS EN LA MATRIZ
            matrizVentas[indiceFila, 0] = id;
            matrizVentas[indiceFila, 1] = producto;
            matrizVentas[indiceFila, 2] = fecha;
            matrizVentas[indiceFila, 3] = cantidad;
           
            MessageBox.Show(matrizVentas[indiceFila, 1] + " agregado correctamente.");
            indiceFila = indiceFila + 1;

        }

    private void brnConsultar_Click(object sender, EventArgs e)
    {
        dtgvRegistro.Rows.Clear();
        for (int i = 0; i < matrizVentas.GetLength(0); i++)
        {
            if (matrizVentas[i, 0] != null)
            {
                dtgvRegistro.Rows.Add(matrizVentas[i, 0], matrizVentas[i, 1], matrizVentas[i, 2], matrizVentas[i, 3]);

            }
        }
    }

    private void btnConsultar_Click(object sender, EventArgs e)
    {
        frmListados listados = new frmListados("Ventas", matrizVentas);
            listados.ShowDialog();
        }

    private void btnComenzar_Click(object sender, EventArgs e)
    {
        dtgvRegistro.Rows.Clear();
        string producto;
        producto = txtFiltro.Text;
        if (rdbCantidad.Checked)
        {
            for (int f = 0; f < matrizVentas.GetLength(0); f++)
            {
                if (matrizVentas[f, 3] != null && int.Parse(matrizVentas[f, 3]) > 10)
                {
                    dtgvRegistro.Rows.Add(matrizVentas[f, 0], matrizVentas[f, 1], matrizVentas[f, 2], matrizVentas[f, 3]);
                }
            }
        }
        else if (rdbProductos.Checked)
        {
            for (int f = 0; f < matrizVentas.GetLength(0); f++)
            {
                if (matrizVentas[f, 1] != null && matrizVentas[f, 1] == producto)
                {
                    MessageBox.Show(producto + "=" + matrizVentas[f, 1]);
                    dtgvRegistro.Rows.Add(matrizVentas[f, 0], matrizVentas[f, 1], matrizVentas[f, 2], matrizVentas[f, 3]);
                }
            }
        }

    }
}
}

