using MeuDinheiroUCS.EF.Context;
using MeuDinheiroUCS.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuDinheiroUCS.Banco.BancoConta.BancoExtrato
{
    internal class Deposito
    {
        public static void Run()
        {
            try
            {
                var ctx = new BancoContext();
                Console.Clear();
                Console.WriteLine("Deposito:");
                Console.Write("Qual o codigo da conta: ");
                string codigo = Console.ReadLine();
                int codi = int.Parse(codigo);
                var contas = ctx.Conta;
                if (contas.Where(x => x.Codigo == codi).FirstOrDefault() != null)
                {
                    Console.Write("Qual o valor do deposito: R$ ");
                    string valor = Console.ReadLine();
                    Extrato NewExtrato = new Extrato();
                    NewExtrato.ContaID = codi;
                    NewExtrato.Valor = float.Parse(valor);
                    NewExtrato.Descricao = "Deposito efetuado no dia/hora " + DateTime.Now;
                    var conta = contas.Where(x => x.Codigo == codi).FirstOrDefault();
                    conta.Saldo += float.Parse(valor);
                    ctx.Extrato.Add(NewExtrato);
                    try
                    {
                        ctx.SaveChanges();
                        Console.WriteLine("Deposito feito com sucesso...");
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
                    Console.WriteLine("Conta não existe...");
                    Console.ReadLine();
                }
            }catch (Exception ex) {
                Console.WriteLine(ex);
                Console.ReadLine();
            }
            

        }
    }
}
