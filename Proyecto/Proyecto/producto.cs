using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class producto
    {

        private int intid_categoria;

        public int id_categoria
        {
            get { return intid_categoria; }
            set { intid_categoria = value; }
        }

        private string _strCodigo;

        public string codigo
        {
            get { return _strCodigo; }
            set { _strCodigo = value; }
        }

        private string strNombre;

        public string Nombre
        {
            get { return strNombre; }
            set { strNombre = value; }
        }

        private decimal decprecio;

        public decimal Precio
        {
            get { return decprecio; }
            set { decprecio = value; }
        }

        private int intinventario;

        public producto(int id_categoria, string codigo, string nombre, decimal precio, int inventario)
        {
            this.id_categoria = id_categoria;
            this.codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Inventario = inventario;
        }

        public int Inventario
        {
            get { return intinventario; }
            set { intinventario = value; }
        }


    }
}
