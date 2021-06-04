using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatos
{
    public class Persona_x_Factura
    {
        public string nombreCliente;
        public int codigoFactura;
        public string fechaFactura;
        public int idProducto;
        public int codigoProducto;
        public string nombreProducto;
        public double precioProducto;
        public int cantidadProducto;

        public Persona_x_Factura(string nc, int cf, string ff, int idp, int cp, string np, double pp, int canp)
        {
            nombreCliente = nc;
            codigoFactura = cf;
            fechaFactura = ff;
            idProducto = idp;
            codigoProducto = cp;
            nombreProducto = np;
            precioProducto = pp;
            cantidadProducto = canp;
        }


    }
}
