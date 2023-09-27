using MeuDinheiroUCS.EF.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuDinheiroUCS.Banco.BancoConta
{
    internal class ListarContasCli
    {
        public static void Run()
        {
            try { 
            var ctx = new BancoContext();
            Console.Clear();
            Console.Write("Qual o codigo do cliente: ");
            string codigo_cli = Console.ReadLine();
            Console.WriteLine($"Lista de Contas do cliente: {ctx.Cliente.Where(x => x.id == int.Parse(codigo_cli)).FirstOrDefault().Nome} {ctx.Cliente.Where(x => x.id == int.Parse(codigo_cli)).FirstOrDefault().Sobrenome}");
            Console.WriteLine("\n\n===============================");
            var contas = ctx.Conta.Where(x => x.ClienteID == int.Parse(codigo_cli));
            foreach (var item in contas)
            {
                
                Console.WriteLine($"ID: {item.id}");
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Saldo: R$ {item.Saldo.ToString("F2")}");
                Console.WriteLine("===============================");
            }
            Console.WriteLine("Precione qualquer botão para voltar...");
            Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
            }
        }
    }
}
