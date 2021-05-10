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
        private string _barrio;
        private string _calle;
        private string _manzana;
        private string _zona;

        public string Nombre1 { get => _nombre1; set => _nombre1 = value; }
        public string Nombre2 { get => _nombre2; set => _nombre2 = value; }
        public string Apellido1 { get => _apellido1; set => _apellido1 = value; }
        public string Apellido2 { get => _apellido2; set => _apellido2 = value; }
        public string Barrio { get => _barrio; set => _barrio = value; }
        public string Calle { get => _calle; set => _calle = value; }
        public string Manzana { get => _manzana; set => _manzana = value; }
        public string Zona { get => _zona; set => _zona = value; }
    }

    class Empleado : Persona
    {
        private long salario;
        private string _password;
        private string _tipoUsuario;

        public long Salario { get => salario; set => salario = value; }
        public string Password { get => _password; set => _password = value; }
        public string TipoUsuario { get => _tipoUsuario; set => _tipoUsuario = value; }
    }

    class Cliente : Persona
    {
        private string codigi;

        public string Codigi { get => codigi; set => codigi = value; }
    }

    class Proveedor 
    {
        private string _codigoProveedor;
        private string _codigOHierro;
        private string _NombreEstablecimiento;
        private string _calle;
        private string _manzana;
        private string _zona;
        private string _barrioP;
        private string _calleP;
        private string _manzanaP;
        private string _zonaP;

        public string CodigoProveedor { get => _codigoProveedor; set => _codigoProveedor = value; }
        public string CodigOHierro { get => _codigOHierro; set => _codigOHierro = value; }
        public string NombreEstablecimiento { get => _NombreEstablecimiento; set => _NombreEstablecimiento = value; }
        public string Calle { get => _calle; set => _calle = value; }
        public string Manzana { get => _manzana; set => _manzana = value; }
        public string Zona { get => _zona; set => _zona = value; }
        public string BarrioP { get => _barrioP; set => _barrioP = value; }
        public string CalleP { get => _calleP; set => _calleP = value; }
        public string ManzanaP { get => _manzanaP; set => _manzanaP = value; }
        public string ZonaP { get => _zonaP; set => _zonaP = value; }
    }
}
