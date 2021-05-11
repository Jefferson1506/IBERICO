using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_IBERICO.Presentacion
{
    public partial class Contaduria : Form
    {
        public Contaduria()
        {
            InitializeComponent();
            Cargar_combos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void Cargar_combos()
        {
            Combo_cargo.Items.Add("Manipulacion de Alimentos");
            Combo_cargo.Items.Add("Cajero");
            Combo_cargo.Items.Add("Contaduria");
            Combo_cargo.Items.Add("Administracion de Personal");
            Combo_cargo.Items.Add("Administrador Jefe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Contaduria_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
