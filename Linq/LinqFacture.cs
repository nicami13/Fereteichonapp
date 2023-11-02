using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ferreteaichonapp;

namespace Fereteichonapp.Linq
{
    public class LinqFacture
    {
        public static void ProduceFacture(List<Factura>facturas){
            Program program= new Program();
            Factura factura = new Factura();
            factura.NR_Facture=program.GenFacture();
            facturas.Add(factura);
        }
        public void RelashionCliente(List<Factura>facturas,List<Cliente>clientes){
            var innerjoin = facturas.Join(
                clientes,
                factura=> factura.IDCliente,
                cliente=> cliente.Id,
                (factura,cliente)=>new {
                    NroFact=factura.NR_Facture,
                    cliente=cliente.Name
                }
            ).ToList();
        }
    }
}