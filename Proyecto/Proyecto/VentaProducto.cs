using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class VentaProducto
    {
        private int myVar;

        public int id_Venta
        {
            get { return myVar; }
            set { myVar = value; }
        }

        private int asd;

        public int id_Articulo
        {
            get { return asd; }
            set { asd = value; }
        }

        private int can;

        public int cantidad
        {
            get { return can; }
            set { can = value; }
        }
        private decimal asdasd;

        public decimal dinero
        {
            get { return asdasd; }
            set { asdasd = value; }
        }


        public VentaProducto(int id_Venta, int id_Articulo, int cantidad, decimal dinero)
        {
            this.id_Venta = id_Venta;
            this.id_Articulo = id_Articulo;
            this.cantidad = cantidad;
            this.dinero = dinero;
        }
    }
}
