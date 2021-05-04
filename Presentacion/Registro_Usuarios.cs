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
            ocultarCampos();
        }
        
        private  void ocultarCampos()
        {
            lbCod_Hierro.Visible = false;
            lbDireccion_Proveedor.Visible = false;
            lbNom_Proveedor.Visible = false;
            lbCod_Proveedor.Visible = false;
            lbCalle_Provee.Visible = false;
            lbZona_Proveedor.Visible = false;
            lbManzana_Proveedor.Visible = false;
            lbBarrio_Prove.Visible = false;

            txtZona_Proveedor.Visible = false;
            txtNombre_Proveedor.Visible = false;
            txtManaza_proveedor.Visible = false;
            txtCod_Proveedor.Visible = false;
            txtCod_Hierro.Visible = false;
            txtCalle_proveedor.Visible = false;
            txtBarrio_Proveedor.Visible = false;
            
            //PARA CLIENTES


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
                ocultarCampos();
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
                ocultarCampos();
            }


        }

        private void checProveedor_CheckedChanged(object sender, EventArgs e)
        {
            if (checProveedor.Checked)
            {
                checkCliente.Visible = false;
                checEmpleado.Visible = false;
                camposProveedor();
            }
            else
            {
                checkCliente.Visible = true;
                checEmpleado.Visible = true;
                ocultarCampos();
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

       
    }
    }
