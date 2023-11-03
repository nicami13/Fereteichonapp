using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ferreteaichonapp
{
    public class DetalleFactura
    {
        // ID, NROFACT,IDPROD, CANTIDAD  Y VALOR
        public int Id { get; set; }
        public int NR_Facture { get; set; }
        public int IdProduct { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        
    }
}