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
            Panel_Cliente.Visible = false;
            llenarCombos();
        }

        private void llenarCombos()
        {
            for (int i = 1; i <= 31; i++)
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCliente.Checked)
            {
                
                checProveedor.Visible = false;
                Panel_Cliente.Visible = true;
            }
            else
            {
                
                checProveedor.Visible = true;
                panel_Provvrerdo.Visible = false;
                Panel_Cliente.Visible = false;
                
            }

        }

       

        private void checProveedor_CheckedChanged(object sender, EventArgs e)
        {
            if (checProveedor.Checked)
            {
                checkCliente.Visible = false;
               
                panel_Provvrerdo.Visible = true;
                
            }
            else
            {
                checkCliente.Visible = true;
             
                panel_Provvrerdo.Visible = false;
                Panel_Cliente.Visible = false;
                
            }
        }


        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btRegistro_Click(object sender, EventArgs e)
        {

        }



    }
    }
