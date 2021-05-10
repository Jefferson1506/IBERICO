using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_IBERICO.Logica
{
    class Validacion
    {

        public string controlEspaciosProveedor(string nombre1, string nombre2, string apellido, string apellido2,
          string cedula, string telefono,string barrio, string zona, string calle, string manzana,
           string dia, string mes, string año)
        {


            if (string.IsNullOrEmpty(nombre1.Trim()) || contegaNumero(nombre1).Equals("true"))
            {
                return "PRIMER NOMBRE INVALIDO ";
            }

            if (contegaNumero(nombre2).Equals("true"))
            {
                return "SEGUNDO NOMBRE INVALIDO ";
            }

            if (string.IsNullOrEmpty(apellido.Trim()) || contegaNumero(apellido).Equals("true"))
            {
                return "PRIMER APELLIDO INVALIDO ";
            }

            if (string.IsNullOrEmpty(apellido2.Trim()) || contegaNumero(apellido2).Equals("true"))
            {
                return "SEGUNDO APELLIDO INVALIDO ";
            }

            try
            {
                long auxCedula = long.Parse(cedula);
            }
            catch (Exception e)
            {
                return "ERROR.CEDULA CONTIENE UN CARACTER ";
            }

            try
            {
                long auxTelefon = long.Parse(telefono);
            }
            catch (Exception e)
            {
                return "ERROR.TELEFONO CONTIENE UN CARACTER ";
            }

         
            if (dia.Equals("0"))
            {
                return "NO SE HA SELECIONADO EL DIA";
            }


            if (mes.Equals("0"))
            {
                return "NO SE HA SELECIONADO EL MES";
            }

            if (año.Equals("0"))
            {
                return "NO SE HA SELECIONADO EL AÑO";
            }

            if (string.IsNullOrEmpty(barrio.Trim()) ||
                barrio.Length < 4)
            {
                return "BARRIO INVALIDO";
            }
            if (string.IsNullOrEmpty(calle.Trim()) ||
                calle.Length < 4)
            {
                return "CALLE INVALIDA";
            }




            return "REGISTRO EXITOSO";
        }
        public string controlEspaciosCliente()
        {

            return "";
        }

        public string controlEspaciosEmpleado( string nombre1, string nombre2, string apellido, string apellido2,
            string cedula, string telefono, string contraseña, string barrio, string zona, string calle, string manzana,
             string dia, string mes, string año)
        {
            

            if (string.IsNullOrEmpty(nombre1.Trim()) || contegaNumero(nombre1).Equals("true"))
            {
                return "PRIMER NOMBRE INVALIDO ";
            }

            if ( contegaNumero(nombre2).Equals("true"))
            {
                return "SEGUNDO NOMBRE INVALIDO ";
            }

            if (string.IsNullOrEmpty(apellido.Trim()) || contegaNumero(apellido).Equals("true"))
            {
                return "PRIMER APELLIDO INVALIDO ";
            }

            if (string.IsNullOrEmpty(apellido2.Trim()) || contegaNumero(apellido2).Equals("true"))
            {
                return "SEGUNDO APELLIDO INVALIDO ";
            }

            try
            {
                long auxCedula = long.Parse(cedula);
            }catch(Exception e)
            {
                return "ERROR.CEDULA CONTIENE UN CARACTER ";
            }

            try
            {
                long auxTelefon = long.Parse(telefono);
            }
            catch (Exception e)
            {
                return "ERROR.TELEFONO CONTIENE UN CARACTER ";
            }

            if (string.IsNullOrEmpty(contraseña.Trim()) || contraseña.Length< 4)
            {
                return "CONTRASEÑA INVALIDA , MINIMO 4 CARACTERES ";
            }


            if (dia.Equals("0"))
            {
                return "NO SE HA SELECIONADO EL DIA";
            }


            if (mes.Equals("0"))
            {
                return "NO SE HA SELECIONADO EL MES";
            }

            if (año.Equals("0"))
            {
                return "NO SE HA SELECIONADO EL AÑO";
            }

            if (string.IsNullOrEmpty(barrio.Trim()) || 
                barrio.Length < 4)
            {
                return "BARRIO INVALIDO";
            }
            if (string.IsNullOrEmpty(calle.Trim()) ||
                calle.Length < 4)
            {
                return "CALLE INVALIDA";
            }

          


            return "REGISTRO EXITOSO";
        }

        private string contegaNumero(string a)
        {
            string accion = "";
            if(a.Contains("1") || a.Contains("2") || a.Contains("3")
               || a.Contains("4") || a.Contains("5") || a.Contains("6")
               || a.Contains("7") || a.Contains("8") || a.Contains("9")
               || a.Contains("0"))
            {
                accion = "true";
            }
            else
            {
                accion = "false";
            }

            return accion;
        }
    }
}
