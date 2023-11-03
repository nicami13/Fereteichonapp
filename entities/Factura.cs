using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ferreteaichonapp
{
    public class Factura
    {
        //  NRO FACT,FECHA,IDCLIENTE,    TOTAL FACTURA

        public string ? NR_Facture {get; set;} 
        public DateOnly Fecha {get; set;}
        public int IDCliente { get; set; }
        public int Total { get; set; }
    }
}