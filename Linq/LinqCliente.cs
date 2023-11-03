using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ferreteaichonapp;

namespace Fereteichonapp.Linq
{
    public class LinqCliente
    {
        public void ProduceCliente(List<Cliente>clientes,int id){
            Cliente cliente=new Cliente();
            System.Console.WriteLine("Ingresar nombre del Cliente");
            System.Console.Write(":");
            cliente.Name=Console.ReadLine();
            cliente.Id=id;
            System.Console.WriteLine("Ingresar Email Del Cliente");
            System.Console.Write(":");
            cliente.Email=Console.ReadLine();
            clientes.Add(cliente);
            

        }

    }
}