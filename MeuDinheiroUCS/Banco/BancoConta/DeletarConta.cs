using MeuDinheiroUCS.EF.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuDinheiroUCS.Banco.BancoConta
{
    internal class DeletarConta
    {
        public static void Run()
        {
            var ctx = new BancoContext();
            Console.WriteLine("Deletar Conta:");
            Console.Write("Qual o codigo da conta a ser deletado: ");
            string codigo = Console.ReadLine();
            int codi = int.Parse(codigo);
            var conta = ctx.Conta.Where(x => x.Codigo == codi).FirstOrDefault();
            if (conta == null)
            {
                Console.WriteLine("Erro. Conta não existe...");
                Console.ReadLine();
            }
            else
            {
                ctx.Conta.Remove(conta);
                ctx.SaveChanges();
                Console.WriteLine("Conta deletada...");
                Console.ReadLine();
            }
        }
    }
}
