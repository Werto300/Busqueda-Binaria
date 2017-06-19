using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Busqueda_Binaria
{
    public partial class Form1 : Form
    {
        Vector busqueda;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            busqueda = new Vector(Convert.ToInt32(txtTamaño.Text), Convert.ToInt32(txtLimite.Text));

        }

        private void btnLlenar_Click(object sender, EventArgs e)
        {
            busqueda.llenar();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            busqueda.ordenar();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            int resultado = busqueda.busqueda(Convert.ToInt32(txtBusqueda.Text));

            if(resultado != -1)
            {
                txtSalida.Text = "Se encontro en la posición: " + resultado.ToString() + Environment.NewLine;
            }
            else
            {
                txtSalida.Text = "No se encontro" + Environment.NewLine;
            }

            txtSalida.Text += "Comparaciones realizadas: " + busqueda.comparaciones;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            txtSalida.Text = busqueda.ToString();
        }
    }
}
