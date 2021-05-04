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
    public partial class Registro_Usuarios : Form
    {
        public Registro_Usuarios()
        {
            InitializeComponent();
           
            panel_Provvrerdo.Visible = false;
        }
        
       

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCliente.Checked)
            {
                checEmpleado.Visible = false;
                checProveedor.Visible = false;
            }
            else
            {
                checEmpleado.Visible = true;
                checProveedor.Visible = true;
                panel_Provvrerdo.Visible = false;
            }

        }

        private void checEmpleado_CheckedChanged(object sender, EventArgs e)
        {

            if (checEmpleado.Checked)
            {
                checkCliente.Visible = false;
                checProveedor.Visible = false;

            }
            else
            {
                checkCliente.Visible = true;
                checProveedor.Visible = true;
                panel_Provvrerdo.Visible = false;
            }


        }

        private void checProveedor_CheckedChanged(object sender, EventArgs e)
        {
            if (checProveedor.Checked)
            {
                checkCliente.Visible = false;
                checEmpleado.Visible = false;
                panel_Provvrerdo.Visible = true;
                
            }
            else
            {
                checkCliente.Visible = true;
                checEmpleado.Visible = true;
                panel_Provvrerdo.Visible = false;
            }
        }


        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void camposProveedor() 
        {
            lbCod_Hierro.Visible = true;
            lbDireccion_Proveedor.Visible = true;
            lbNom_Proveedor.Visible = true;
            lbCod_Proveedor.Visible = true;
            lbCalle_Provee.Visible = true;
            lbZona_Proveedor.Visible = true;
            lbManzana_Proveedor.Visible = true;
            lbBarrio_Prove.Visible = true;

            txtZona_Proveedor.Visible = true;
            txtNombre_Proveedor.Visible = true;
            txtManaza_proveedor.Visible = true;
            txtCod_Proveedor.Visible = true;
            txtCod_Hierro.Visible = true;
            txtCalle_proveedor.Visible = true;
            txtBarrio_Proveedor.Visible = true;

        }

        private void camposCliente() { }


        private void camposEmpleado() { }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Registro_Usuarios_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }
