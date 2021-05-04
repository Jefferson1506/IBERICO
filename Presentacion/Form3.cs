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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datos.Acciones acciones = new Datos.Acciones();
            int a = (int)Int64.Parse(txt1.Text);
            int b = (int)Int64.Parse(txt2.Text);
            switch (comboBox1.SelectedItem)
            {
                case "-":
                    acciones.resta(a, b);
                    break;

                case "+":
                    txt3.Text=""+acciones.sumar(a, b);
                    break;

                case "*":
                    txt3.Text = "" + acciones.multiplicar(a, b);
                    break;

                case "/":
                    txt3.Text = "" + acciones.dividir(a, b);
                    break;

            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
