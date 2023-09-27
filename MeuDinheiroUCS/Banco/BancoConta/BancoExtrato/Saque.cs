using MeuDinheiroUCS.EF.Context;
using MeuDinheiroUCS.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuDinheiroUCS.Banco.BancoConta.BancoExtrato
{
    internal class Saque
    {
        public static void Run()
        {
            try { 
            var ctx = new BancoContext();
            Console.Clear();
            Console.WriteLine("Saque:");
            Console.Write("Qual o codigo da conta: ");
            string codigo = Console.ReadLine();
            int codi = int.Parse(codigo);
            var contas = ctx.Conta;
            if (contas.Where(x => x.Codigo == codi).FirstOrDefault() != null)
            {
                Console.Write("Qual o valor do saque: R$ ");
                string valor = Console.ReadLine();
                if(contas.Where(x => x.Codigo == codi).FirstOrDefault().Saldo >= float.Parse(valor))
                {
                    Extrato NewExtrato = new Extrato();
                    NewExtrato.ContaID = codi;
                    NewExtrato.Valor = float.Parse(valor) * -1;
                    NewExtrato.Descricao = "Saque efetuado no dia/hora " + DateTime.Now;
                    var conta = contas.Where(x => x.Codigo == codi).FirstOrDefault();
                    conta.Saldo -= float.Parse(valor);
                    ctx.Extrato.Add(NewExtrato);
                    try
                    {
                        ctx.SaveChanges();
                        Console.WriteLine("Saque feito com sucesso...");
                        Console.ReadLine();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Saldo indisponível...");
                    Console.ReadLine();
                }
                


            }
            else
            {
                Console.WriteLine("Conta não existe...");
                Console.ReadLine();
            }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
            }
        }
    }
}
