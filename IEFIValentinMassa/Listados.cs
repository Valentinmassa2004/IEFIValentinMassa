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
    public partial class Listados : Form
    {

        public string[,] matrizProducto = new string[10, 3];
        public string[,] matrizRegistro = new string[10, 4];

        public Listados()
        {
            InitializeComponent();
        }

        private void Listados_Load(object sender, EventArgs e)
        {

        }
    }
}
