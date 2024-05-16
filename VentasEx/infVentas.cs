using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasEx
{
    public class infVentas
    {

        public string prdName { get; set; }
        public double Precio { get; set; }
        public int cntd { get; set; }
        public double ventas { get; set; }

        public infVentas(string prdName, double Precio, int cntd, double ventast)
        {
            this.prdName = prdName;
            this.cntd = cntd;
            this.Precio = Precio;
            this.ventas = Precio*cntd;


   
        }


    }
}
