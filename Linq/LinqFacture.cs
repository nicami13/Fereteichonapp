using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ferreteaichonapp;

namespace Fereteichonapp.Linq
{
    public class LinqFacture
    {
 public void ProduceFacture(List<Factura> facturas, List<Cliente> clientes,int id)
    {
        Factura factura = new Factura();
        Program program = new Program();
        Console.Write("Ingresar Día De La Realización De La Factura: ");
        int dia = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingresar Mes De La Realización De La Factura: ");
        int mes = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingresar Año De La Realización De La Factura: ");
        int año = Convert.ToInt32(Console.ReadLine());
        factura.Fecha = DateOnly.FromDateTime(new DateTime(año, mes, dia));
        factura.NR_Facture = program.GenFacture(id);

        Console.WriteLine("Clientes disponibles:");
        foreach (var cliente in clientes)
        {
            Console.WriteLine($"ID: {cliente.Id} - NOMBRE: {cliente.Name} - EMAIL: {cliente.Email}");
        }

        Console.WriteLine("Marque El Número Del ID Del Cliente De la Factura");
        Console.Write(": ");
        int selection = Convert.ToInt32(Console.ReadLine());

        var selectedClient = clientes.FirstOrDefault(cliente => cliente.Id == selection);

        if (selectedClient == null)
        {
            Console.WriteLine("El cliente con el ID proporcionado no existe.");
        }
        else
        {
            factura.IDCliente = selectedClient.Id;
            facturas.Add(factura);
            Console.WriteLine("Factura creada con éxito.");
        }
    }   
    public  void MostrarFacturas(List<Factura> facturas)
    {
        Console.WriteLine("Lista de Facturas:");
        foreach (var factura in facturas)
        {
            Console.WriteLine($"Número de Factura: {factura.NR_Facture}");
            Console.WriteLine($"Fecha de Realización: {factura.Fecha}");
            Console.WriteLine($"Cliente: ID: {factura.IDCliente}");
        }
    }
    public void SeeOldFacture(List<Factura>facturas){
    DateOnly OldDate = DateOnly.FromDateTime(new DateTime(2023, 01, 01));

    var result = facturas.Where(factura => factura.Fecha.Month == 1 && factura.Fecha.Year == 2023).ToList();

    foreach (var factura in result) {
        Console.WriteLine($"Número de Factura: {factura.NR_Facture}");
        Console.WriteLine($"Fecha de Realización: {factura.Fecha}");
        Console.WriteLine($"Cliente: ID: {factura.IDCliente}");
    }
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