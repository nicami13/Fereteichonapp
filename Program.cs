using Fereteichonapp.Linq;
using Ferreteaichonapp;

internal class Program
{
    public int GenFacture(int id)
    {
        Random random = new Random();
        int CodigoFactura = id;
        int facture = CodigoFactura;
        return facture;
    }
    private static void Main(string[] args)
    {
        int ConProducto = 0;
        int ConCliente = 0;
        int ConDetail = 0;
        int conFacture=0;
        List<Factura> facturas = new List<Factura>();
        List<Producto> Productos = new List<Producto>();
        List<Cliente> clientes = new List<Cliente>();
        List<DetalleFactura> detalleFacturas= new List<DetalleFactura>();
        LinqProduct linqProduct = new LinqProduct();
        LinqFacture linqFacture = new LinqFacture();
        LinqCliente linqCliente = new LinqCliente();
        LinqDetailFacture linqDetailFacture = new LinqDetailFacture();
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Menú:");
            Console.WriteLine("1. Ingresar Producto");
            Console.WriteLine("2. Ingresar Factura");
            System.Console.WriteLine("3. Ver Facturas");
            System.Console.WriteLine("4. Ver Facturas Antiguas");
            Console.WriteLine("5. Ingresar Cliente");
            System.Console.WriteLine("6. Listar Productos");
            System.Console.WriteLine("7. Listar Productos Agotados");
            System.Console.WriteLine("8. Listar Productos A Comprar");
            System.Console.WriteLine("9. Ingresar Detalle De Factura");
            System.Console.WriteLine("t. Total De inventario");
            Console.WriteLine("0. Salir");
            Console.Write("Elija una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Opción 1: Ingresar Producto");
                    linqProduct.ProduceProduct(Productos, ConProducto);
                    ConProducto = +1;
                    break;

                case "2":
                    Console.WriteLine("Opción 2: Ingresar Factura");
                    linqFacture.ProduceFacture(facturas, clientes,conFacture);
                    conFacture+=1;
                    break;
                case "3":
                    Console.WriteLine("Opción 3: Ver Facturas");
                    linqFacture.MostrarFacturas(facturas);
                    break;
                case "4":
                    Console.WriteLine("Opción 4: Ver Facturas De Eneroñ");
                    linqFacture.SeeOldFacture(facturas);
                    break;
                case "5":
                    Console.WriteLine("Opción 5: Ingresar Cliente");
                    linqCliente.ProduceCliente(clientes, ConCliente);
                    ConCliente = +1;
                    break;

                case "6":
                    Console.WriteLine("Opción 6: Lista De Productos");
                    linqProduct.ListerProduct(Productos);
                    break;
                case "7":
                    Console.WriteLine("Opción 7: Lista De Productos Agotados");
                    linqProduct.ListerSpentProducts(Productos);
                    break;
                case "8":
                    Console.WriteLine("Opción 8: Lista De Productos A Comprar");
                    linqProduct.ListerBuyProducts(Productos);
                    break;

                case "9":
                    Console.WriteLine("Opcion 9: Crear Detalle de Factura");
                    linqDetailFacture.ProduceDetailFacture(detalleFacturas,Productos,facturas,ConDetail);
                    linqDetailFacture.factureProducts(ConDetail,facturas,detalleFacturas,Productos);
                    
                    ConDetail+=1;
                    break;
                case"t":
                    linqProduct.InventoryPriceTotal(Productos);
                break;

                case "0":
                    Console.WriteLine("Saliendo del programa.");
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, elija una opción válida.");
                    break;


            }
        }
    }
}

