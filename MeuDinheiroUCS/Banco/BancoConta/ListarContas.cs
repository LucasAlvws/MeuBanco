using MeuDinheiroUCS.EF.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuDinheiroUCS.Banco.BancoConta
{
    internal class ListarContas
    {
        public static void Run()
        {
            var ctx = new BancoContext();
            var ctx2 = new BancoContext();
            Console.Clear();
            Console.WriteLine("Lista de Contas:");
            
            var clintes = ctx.Cliente;
            var contas = ctx.Conta;
            foreach (var item in contas)
            {
                Console.WriteLine($"ID: {item.id}");
                Console.WriteLine($"Nome Cliente: {ctx2.Cliente.Where(x => x.id == item.id).FirstOrDefault().Nome} {ctx2.Cliente.Where(x => x.id == item.id).FirstOrDefault().Sobrenome}");
                Console.WriteLine($"Código: {(int)item.Codigo}");
                Console.WriteLine("===============================");
            }
            Console.WriteLine("Precione qualquer botão para voltar...");
            Console.ReadLine();

        }
    }
}
