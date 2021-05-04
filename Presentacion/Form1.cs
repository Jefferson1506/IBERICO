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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            /*
            if (Mn1.Selected)
            {
                Presentacion.Form2 form2 = new Presentacion.Form2();
                form2.Show();
            }
            else
            {
                Presentacion.Form3 form3 = new Presentacion.Form3();
                form3.Show();



            }
            */

          
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MostrarMensaje(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias porfe");
        }
    }
}