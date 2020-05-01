using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Precio { get; set; }
        public int Stock { get; set; }

        public Producto(int id, string nom, string desc, int pre, int st)
        {
            IdProducto = id;
            Nombre = nom;
            Descripcion = desc;
            Precio = pre;
            Stock = st;
        }
        public Producto() { }
    }
}