using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class venta
    {



        private int asd;

        public int id_cliente
        {
            get { return asd; }
            set { asd = value; }
        }

        private DateTime myVar;

        public venta(int id_cliente, DateTime fecha_orden)
        {
            this.id_cliente = id_cliente;
            this.fecha_orden = fecha_orden;
        }

        public DateTime fecha_orden
        {
            get { return myVar; }
            set { myVar = value; }
        }


    }
}
