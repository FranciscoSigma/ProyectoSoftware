using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Cliente
    {


        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        private string _strApellidoPaterno;

        public string ApellidoPaterno
        {
            get { return _strApellidoPaterno; }
            set { _strApellidoPaterno = value; }
        }

        private string _strApellidoMaterno;

        public string ApellidoMaterno
        {
            get { return _strApellidoMaterno; }
            set { _strApellidoMaterno = value; }
        }
        private decimal _lngTelefono;

        public Cliente(string nombre, string apellidoPaterno, string apellidoMaterno, decimal telefono)
        {
            Nombre = nombre;
            ApellidoPaterno = apellidoPaterno;
            ApellidoMaterno = apellidoMaterno;
            Telefono = telefono;
        }

        public decimal Telefono
        {
            get { return _lngTelefono; }
            set { _lngTelefono = value; }
        }
    }
}
