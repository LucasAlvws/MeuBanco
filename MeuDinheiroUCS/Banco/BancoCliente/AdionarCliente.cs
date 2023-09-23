using MeuDinheiroUCS.EF.Context;
using MeuDinheiroUCS.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuDinheiroUCS.Banco.BancoCliente
{
    internal class AdionarCliente
    {
        public static void Run()
        {
            var ctx = new BancoContext();
            Console.Clear();
            Console.WriteLine("Adicionar Cliente:");
            Console.Write("Qual o codigo do cliente: ");
            string codigo = Console.ReadLine();

            Console.Write("Qual o nome do cliente: ");
            string nome = Console.ReadLine();

            Console.Write("Qual o sobrenome do cliente: ");
            string sobrenome = Console.ReadLine();

            Console.Write("Qual o telefone do cliente: ");
            string telefone = Console.ReadLine();

            Cliente NewCliente = new Cliente();
            NewCliente.id = int.Parse(codigo);
            NewCliente.Nome = nome;
            NewCliente.Sobrenome = sobrenome;
            NewCliente.Telefone = telefone;
            ctx.Cliente.Add(NewCliente);
            ctx.SaveChanges();
            Console.WriteLine("Cliente adicionado...");
            Console.ReadLine();
        }
    }
}
