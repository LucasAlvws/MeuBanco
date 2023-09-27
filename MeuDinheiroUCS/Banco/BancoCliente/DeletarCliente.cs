using MeuDinheiroUCS.EF.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuDinheiroUCS.Banco.BancoCliente
{
    internal class DeletarCliente
    {
        public static void Run()
        {
            try { 
            var ctx = new BancoContext();
            Console.WriteLine("Deletar Cliente:");
            Console.Write("Qual o codigo do cliente a ser deletado: ");
            string codigo = Console.ReadLine();
            int id = int.Parse(codigo);
            var cli = ctx.Cliente.Where(x => x.id == id).FirstOrDefault();
            if( cli == null)
            {
                Console.WriteLine("Erro. Cliente não existe...");
                Console.ReadLine();
            }
            else
            {
                ctx.Cliente.Remove(cli);
                ctx.SaveChanges();
                Console.WriteLine("Cliente deletado...");
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
