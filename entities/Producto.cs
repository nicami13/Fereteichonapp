using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ferreteaichonapp
{
    public class Producto
    {
        // ID, NOMBRE, PRECIOUNIT, CANTIDAD,STOCKMIN Y STOCKMAX
        public int ID { get; set; }
        public string ? Name {get; set;} 
        public double PriceUnit { get; set; }
        public int Amount { get; set; }
        public int StockMin { get; set; }
        public int StockMax { get; set; }
        
    }
}