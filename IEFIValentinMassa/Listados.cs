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
    public partial class frmListados : Form
    {

        public string[,] matrizProducto = new string[10, 3];
        public string[,] matrizRegistro = new string[10, 4];

        public frmListados()
        {
            InitializeComponent();
        }

        private void frmListados_Load(object sender, EventArgs e)
        {
            // recorre matriz
            for (int i = 0; i < 10; i++)
            {   //
                if (matrizRegistro[i, 1] != null)
                {   //analiza si el elemento ya existe
                    if (lstVentas.Items.Contains(matrizRegistro[i, 1]) == false)
                    { // si no existe se agrega
                        lstVentas.Items.Add(matrizRegistro[i, 1]);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {       // recorre matriz
            for (int i = 0; i < matrizProducto.GetLength(0); i++)
            {      //
                if (matrizProducto[i, 1] != null)
                { // agrega a las filas
                    dtgvRegistro.Rows.Add(matrizProducto[i, 0], matrizProducto[i, 1], matrizProducto[i, 2]);
                }
            }
    }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (rdbProductos.Checked == true)
            {       
                for (int i = 0; i < matrizProducto.GetLength(0); i++)
                {
                    if (matrizProducto[i, 1] != null)
                    {
                        dtgvRegistro.Rows.Add(matrizProducto[i, 0], matrizProducto[i, 1], matrizProducto[i, 2]);
                    }
                }
            }
            else
            {

                for (int i = 0; i < matrizRegistro.GetLength(0); i++)
                {
                    if (lstVentas.Text == matrizRegistro[i, 1])
                    {
                        dtgvRegistro.Rows.Add(matrizRegistro[i, 0], matrizRegistro[i, 1], matrizRegistro[i, 2]);
                    }
                }
            }

        }

        private void rdbVentas_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbVentas.Checked)
            {
                lstVentas.Enabled = true;
            }
        }

        private void frmListados_Load_1(object sender, EventArgs e)
        {

        }
    }
    }
