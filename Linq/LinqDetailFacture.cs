using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ferreteaichonapp;

namespace Fereteichonapp.Linq
{
    public class LinqDetailFacture
    {
        public void ProduceDetailFacture(List<DetalleFactura> Dfacturas, List<Producto> productos, List<Factura> facturas, int id)
        {
            DetalleFactura detalleFactura = new DetalleFactura();

            foreach (var Factura in facturas)
            {
                Console.WriteLine($"ID:{Factura.NR_Facture} - NOMBRE CLIENTE:{Factura.IDCliente} - FECHA:{Factura.Fecha}");
            }

            Console.WriteLine("Marque El Número De Factura Que desea Detallar (solo el número):");
            Console.Write(": ");
            string facturaInput = Console.ReadLine();
            int selection;

            if (int.TryParse(facturaInput, out selection))
            {
                var selectedFacture = facturas.FirstOrDefault(factura =>
                {
                    int facturaNumber;
                    if (int.TryParse(factura.NR_Facture.Replace("fact-", ""), out facturaNumber))
                    {
                        return facturaNumber == selection;
                    }
                    return false;
                });

                if (selectedFacture == null)
                {
                    Console.WriteLine("La factura con el número proporcionado no existe.");
                }
                else
                {
                    detalleFactura.NR_Facture = selectedFacture.NR_Facture;
                    Console.WriteLine("Factura Vinculada Con Éxito.");

                    foreach (var producto in productos)
                    {
                        Console.WriteLine($"ID:{producto.ID} - NOMBRE:{producto.Name} - VALOR UNITARIO:{producto.PriceUnit}");
                    }

                    Console.WriteLine("Marque El Número De Producto Que desea Añadir (solo el número):");
                    Console.Write(": ");
                    string productoInput = Console.ReadLine();
                    int select;

                    if (int.TryParse(productoInput, out select))
                    {
                        var selectedProduct = productos.FirstOrDefault(producto => producto.ID == select);

                        if (selectedProduct == null)
                        {
                            Console.WriteLine("El producto con el ID proporcionado no existe.");
                        }
                        else
                        {
                            detalleFactura.IdProduct = selectedProduct.ID;
                            Console.WriteLine("Producto Vinculado Con Éxito.");
                            Console.Write("Ingresar Cantidad De Producto De la Compra: ");
                            int cantidad;

                            if (int.TryParse(Console.ReadLine(), out cantidad))
                            {
                                if (selectedProduct.Amount >= cantidad)
                                {
                                    detalleFactura.Amount = cantidad;
                                    selectedProduct.Amount = selectedProduct.Amount - cantidad;
                                    detalleFactura.Price = cantidad * selectedProduct.PriceUnit;
                                    detalleFactura.Id = id;
                                    Dfacturas.Add(detalleFactura);
                                }
                                else
                                {
                                    Console.WriteLine("La cantidad ingresada supera el stock disponible.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Cantidad no válida. Ingrese un número válido.");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada no válida. Ingrese un número de producto válido.");
                    }
                }



            }
        }
    }
}