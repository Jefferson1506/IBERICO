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
    public partial class Registro_Empleados : Form
    {
        public Registro_Empleados()
        {
            InitializeComponent();
            llenarCombos();
        }

        private void llenarCombos()
        {
           for(int i =1; i<=31; i++)
            {
                comboDia.Items.Add(i);
            }

            for (int i = 1; i <= 12; i++)
            {
                comboMes.Items.Add(i);
            }

            for (int i = 1914; i <= 2020; i++)
            {
                comboAño.Items.Add(i);
            }

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btRegistro_Click(object sender, EventArgs e)
        {
            string registro;
            registro= espaciosBlanco();

            if (registro.Equals("OK"))
            {

            }
        }


       
        private string espaciosBlanco()
        {
            string accion="";
            string auxDia, auxMes, auxAño;

            if (comboDia.SelectedItem is null)
            {
                auxDia ="0";
            }
            else
            {
                auxDia = comboDia.SelectedItem.ToString();
            }

            if (comboMes.SelectedItem is null)
            {
                auxMes = "0";
            }
            else
            {
                auxMes = comboMes.SelectedItem.ToString();
            }

            if (comboAño.SelectedItem is null)
            {
                auxAño = "0";
            }
            else
            {
                auxAño = comboAño.SelectedItem.ToString();
            }
            



            Logica.Validacion validacion = new Logica.Validacion();
            accion = validacion.controlEspaciosEmpleado(txtNombre_P.Text, txtNombre2.Text,
                txtApellido1.Text, txtApellido2.Text, txtCedula.Text,
                txtTelefono.Text, txtContraseña.Text, txtBarrio.Text,
                txtZona.Text, txtCalle.Text, txtManzana.Text,auxDia, auxMes
                ,auxAño);

            MessageBox.Show(accion);
            
            return accion;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Registro_Empleados_Load(object sender, EventArgs e)
        {

        }

    }
}
