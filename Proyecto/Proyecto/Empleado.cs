using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Empleado
    {

        private string _strusuario;

        public string usuario
        {
            get { return _strusuario; }
            set { _strusuario = value; }
        }

        private string _strPassword;

        public string Password
        {
            get { return _strPassword; }
            set { _strPassword = value; }
        }



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

        public decimal Telefono
        {
            get { return _lngTelefono; }
            set { _lngTelefono = value; }
        }
        private string _strPuesto;

        public string Puesto
        {
            get { return _strPuesto; }
            set { _strPuesto = value; }
        }


        private string _strEmail;

        public string Email
        {
            get { return _strEmail; }
            set { _strEmail = value; }
        }


        public Empleado(string usuario, string password, string nombre, string apellidoPaterno, string apellidoMaterno, decimal telefono, string puesto, string email)
        {
            this.usuario = usuario;
            Password = password;
            Nombre = nombre;
            ApellidoPaterno = apellidoPaterno;
            ApellidoMaterno = apellidoMaterno;
            Puesto = puesto;
            Email = email;
            this.Telefono = telefono;
        }


    }
}
