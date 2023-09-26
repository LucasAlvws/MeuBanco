using MeuDinheiroUCS.EF.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuDinheiroUCS.Banco.BancoConta.BancoExtrato
{
    internal class ExtratoConta
    {
        public static void Run()
        {
            var ctx = new BancoContext();
            Console.Clear();
            Console.Write("Qual o codigo da conta: ");
            string codigo = Console.ReadLine();
            var conta = ctx.Conta.Where(x => x.Codigo == int.Parse(codigo)).FirstOrDefault();
            if (conta == null) 
            {
                Console.WriteLine("Conta não existe...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\n\n===============================");
                Console.WriteLine($"Extrato conta {codigo}: ");
                Console.WriteLine($"Títular da conta: {ctx.Cliente.Where(x => x.id == conta.ClienteID).FirstOrDefault().Nome} {ctx.Cliente.Where(x => x.id == conta.ClienteID).FirstOrDefault().Sobrenome}");
                Console.WriteLine($"Saldo da conta: R$ {conta.Saldo.ToString("F2")}");
                var extrato = ctx.Extrato.Where(x => x.ContaID == conta.Codigo);
                foreach (var item in extrato)
                {
                    Console.WriteLine($"Valor: R$ {item.Valor.ToString("F2")} || Descrição: {item.Descricao}");
                }
                Console.WriteLine("===============================");
                
                Console.WriteLine("Precione qualquer botão para voltar...");
                Console.ReadLine();
            }
            

        }
    }
}
