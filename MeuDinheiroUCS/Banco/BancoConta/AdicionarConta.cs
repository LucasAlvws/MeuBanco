using MeuDinheiroUCS.EF.Context;
using MeuDinheiroUCS.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuDinheiroUCS.Banco.BancoConta
{
    internal class AdicionarConta
    {
        public static void Run()
        {
            
            var ctx = new BancoContext();
            Console.Clear();
            Console.WriteLine("Adicionar Conta:");
            Console.Write("Qual o codigo do cliente: ");
            string codigo_cli = Console.ReadLine();
            var clientes = ctx.Cliente;
            if (clientes.Where(x => x.id == int.Parse(codigo_cli)).FirstOrDefault() != null) 
            {
                Console.Write("Qual o codigo da conta: ");
                string codigo_cont = Console.ReadLine();
                Conta NewConta = new Conta();
                NewConta.Codigo = int.Parse(codigo_cont);
                NewConta.ClienteID = int.Parse(codigo_cli);
                ctx.Conta.Add(NewConta);
                try
                {
                    ctx.SaveChanges();
                    Console.WriteLine("Conta adicionada...");
                    Console.ReadLine();
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Erro - Conta já existe...");
                    Console.ReadLine();
                }
                
                
            }
            else {
                Console.WriteLine("Cliente não existe...");
                Console.ReadLine();
            }
            
        }
    }
}
