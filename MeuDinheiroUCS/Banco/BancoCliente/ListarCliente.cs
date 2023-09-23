using MeuDinheiroUCS.EF.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuDinheiroUCS.Banco.BancoCliente
{
    internal class ListarCliente
    {
        public static void Run()
        {
            var ctx = new BancoContext();
            Console.Clear();
            Console.WriteLine("Lista de Cliente:");
            var clientes = ctx.Cliente;
            foreach (var item in clientes)
            {
                Console.WriteLine($"ID: {item.id}");
                Console.WriteLine($"Nome: {item.Nome} {item.Sobrenome}");
                Console.WriteLine($"Telefone: {item.Telefone}");
                Console.WriteLine("===============================");
            }
            Console.WriteLine("Precione qualquer botão para voltar...");
            Console.ReadLine();

        }
    }
}
