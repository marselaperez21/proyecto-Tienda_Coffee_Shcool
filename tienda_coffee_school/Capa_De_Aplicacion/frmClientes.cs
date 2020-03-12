using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_De_Aplicacion
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void CargarFechas()
        {
            for (int dia = 1; dia <= 31; dia++)
            {
                cmbDia.Items.Add(dia);
            }
            int aux = DateTime.Now.Year;
            for (int anyo = 1900; anyo <= aux; anyo++)
            {
                cmbAnyo.Items.Add(anyo);
            }

        }

        private void txtPrimerNombre_TextChanged(object sender, EventArgs e)
        {
            Validacion();
            //GuardarEnBD();

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

    }

}



