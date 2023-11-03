using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fereteichonapp.entities;
using Ferreteaichonapp;

namespace Fereteichonapp.Linq
{
    public class LinqProduct
    {
        public void ProduceProduct(List<Producto> productos, int id)
        {
            Producto producto = new Producto();
            Console.WriteLine("Ingresar Nombre del Producto");
            Console.Write(":");
            producto.ID = id;
            producto.Name = Console.ReadLine();
            Console.WriteLine("Ingresar Cantidad del Producto");
            Console.Write(":");
            producto.Amount = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingresar Precio del Producto");
            Console.Write(":");
            producto.PriceUnit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresar StockMinimo Del Producto");
            Console.Write(":");
            producto.StockMin = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingresar StockMaximo Del Producto");
            Console.Write(":");
            producto.StockMax = Convert.ToInt16(Console.ReadLine());
            productos.Add(producto);
        }
        public void ListerProduct(List<Producto> productos)
        {
            foreach (var producto in productos)
            {
                Console.WriteLine($"ID: {producto.ID}");
                Console.WriteLine($"Name: {producto.Name}");
                Console.WriteLine($"Amount: {producto.Amount}");
                Console.WriteLine($"PriceUnit: {producto.PriceUnit}");
                Console.WriteLine($"StockMin: {producto.StockMin}");
                Console.WriteLine($"StockMax: {producto.StockMax}");
                Console.WriteLine("-------------------------------");
            }
        }
        public void ListerSpentProducts(List<Producto> productos)
        {
            Console.WriteLine("Productos Agotados");
            Console.WriteLine(" ");
            var result = (from s in productos where s.Amount < s.StockMin select s).ToList<Producto>();
            foreach (var producto in productos)
            {
                Console.WriteLine($"ID: {producto.ID}");
                Console.WriteLine($"Name: {producto.Name}");
                Console.WriteLine($"Amount: {producto.Amount}");
                Console.WriteLine($"PriceUnit: {producto.PriceUnit}");
                Console.WriteLine($"StockMin: {producto.StockMin}");
                Console.WriteLine($"StockMax: {producto.StockMax}");
                Console.WriteLine("-------------------------------");
            }
        }
        public void ListerBuyProducts(List<Producto> productos)
        {
            Console.WriteLine("Productos A Comprar");
            Console.WriteLine(" ");
            var result = (from s in productos
                          where s.Amount < s.StockMin
                          select new ProductoAComprar()
                          {
                              Producto = s,
                              Total = s.Amount

                          }).ToList<ProductoAComprar>();
            foreach (var producto in result)
            {
                System.Console.WriteLine($"Name:{producto.Producto.Name}");
                System.Console.WriteLine($"ID:{producto.Producto.ID}");
                System.Console.WriteLine($"Amount:{producto.Producto.Amount}");
                System.Console.WriteLine($"PriceUnit:{producto.Producto.PriceUnit}");
                System.Console.WriteLine($"StockMin:{producto.Producto.StockMin}");
                System.Console.WriteLine($"StockMax:{producto.Producto.StockMax}");
                System.Console.WriteLine($"Cantidad A Comprar:{producto.Total}");




            }
        }
        public void InventoryPriceTotal(List<Producto> productos)
        {

            double restTOrest=0;
            foreach (var producto in productos)
            {
                double result = producto.Amount * producto.PriceUnit;
                 restTOrest+=result;
            }
            Console.WriteLine($"EL VALOR TOTAL DE INVENTARIO ES:{restTOrest}");

        }




    }
}