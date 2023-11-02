using Fereteichonapp.Linq;
using Ferreteaichonapp;

internal class Program
{
    public string GenFacture(){
        Random random = new Random();
        int CodigoFactura=random.Next(1000,1000);
        string facture= "FACT-"+CodigoFactura.ToString();
        return facture;
        }
    private static void Main(string[] args)
    {
        int ConProducto=0;
        List<Factura> facturas = new List<Factura>();
        List<Producto> Productos = new List<Producto>();
        LinqProduct linqProduct=new LinqProduct();
        linqProduct.ProduceProduct(Productos,ConProducto);
        linqProduct.ListerBuyProducts(Productos);

    }
}