using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ferreteaichonapp;

namespace Fereteichonapp.Linq
{
    public class LinqDetailFacture
    {
        public void RelashionFacture(List<Factura>facturas,List<DetalleFactura>detalleFacturas){
            var innerjoin = detalleFacturas.Join(
                detalleFacturas,
                detallefactura=> detallefactura.NR_Facture,
                factura=>factura.NR_Facture,
                (factura,detalleFactura)=>new{
                    Nro_fac=factura.NR_Facture,
                    detalleFactura=detalleFactura.Id
                }
            ).ToList();
     }   
     public void RelashionProducto(List<Producto>productos,List<DetalleFactura>detalleFacturas){
            var innerjoin = detalleFacturas.Join(
                detalleFacturas,
                detallefactura=> detallefactura.IdProduct,
                producto=> producto.Id,
                (Producto,detalleFactura)=>new{
                    Nro_fac=detalleFactura.NR_Facture,
                    detalleFactura=Producto.Id
                }
            ).ToList();
     }   
    }
}