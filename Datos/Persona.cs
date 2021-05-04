using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_IBERICO.Datos
{
    class Persona
    {
        private string _nombre1;
        private string _nombre2;
        private string _apellido1;
        private string _apellido2;
        private string _usuario;
        private string _password;
        private string _tipoUsuario;
        
    }

    class Empleado : Persona
    {
        private long salario;
    }

    class Cliente : Persona
    {
        private string codigi;
    }
}
