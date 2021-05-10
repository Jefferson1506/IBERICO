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
    public partial class Facturacion : Form
    {
        public Facturacion()
        {
            InitializeComponent();
            llenarCombos();
            ocultarCampor();
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
        
        private void ocultarCampor()
        {
            lbVaca.Visible = false;
            lbPrecioVaca.Visible = false;
            lbTotalVaca.Visible = false;
            lbCerdo.Visible = false;
            lbPrecioCerdo.Visible = false;
            lbTotalCerdo.Visible = false;
            

            txtVacaCan.Visible = false;
            txtValorVaca.Visible = false;
            txtCantidadCerdo.Visible = false;
            txtValorCerdo.Visible = false;
            txtTotalCerdo.Visible = false;
            txtTotalVaca.Visible = false;
           


        }

        private void calcularMontoLiquidar()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void boxVaca_CheckedChanged(object sender, EventArgs e)
        {
            if (boxVaca.Checked)
            {
                lbVaca.Visible = true;
                lbPrecioVaca.Visible = true;
                lbTotalVaca.Visible = true;
                

                txtVacaCan.Visible = true;
                txtValorVaca.Visible = true;
                txtTotalVaca.Visible = true;
               

            }
            else
            {

                lbVaca.Visible = false;
                lbPrecioVaca.Visible = false;
                lbTotalVaca.Visible = false;
               

                txtVacaCan.Visible = false;
                txtValorVaca.Visible = false;
                txtTotalVaca.Visible = false;
               
            }
        }

        private void boxCerdo_CheckedChanged(object sender, EventArgs e)
        {
            if (boxCerdo.Checked)
            {
                lbCerdo.Visible = true;
                lbPrecioCerdo.Visible = true;
                lbTotalCerdo.Visible = true;
              

                txtCantidadCerdo.Visible = true;
                txtValorCerdo.Visible = true;
                txtTotalCerdo.Visible = true;
                
            }
            else
            {
                lbCerdo.Visible = false;
                lbPrecioCerdo.Visible = false;
                lbTotalCerdo.Visible = false;
              

                txtCantidadCerdo.Visible = false;
                txtValorCerdo.Visible = false;
                txtTotalCerdo.Visible = false;
                
            }
        }
    }
}
