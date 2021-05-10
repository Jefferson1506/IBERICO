using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_IBERICO
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lbTitulo_Click(object sender, EventArgs e)//label titulo no va hacer nadad
        {

        }

        private void button1_Click(object sender, EventArgs e)//boton salir por alguna razon no me cambia el nombre
        {
            this.Close();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {

        }

        private void btRegistro_Click(object sender, EventArgs e)
        {
            Presentacion.Registro_Empleados registro_Empleados =
                new Presentacion.Registro_Empleados();
            registro_Empleados.Show();

        }

        private void label1_Click(object sender, EventArgs e) { }//no va hacer nada 

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

       
    }
}
