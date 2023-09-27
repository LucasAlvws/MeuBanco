using MeuDinheiroUCS.EF.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuDinheiroUCS.Banco.BancoCliente
{
    internal class AtualizarCliente
    {
        public static void Run()
        {
            try { 
            var ctx = new BancoContext();
            Console.Clear();
            Console.WriteLine("Atualizr Cliente:");
            Console.Write("Qual o codigo do cliente a ser atualizado: ");
            string codigo = Console.ReadLine();
            int id = int.Parse(codigo);
            var cli = ctx.Cliente.Where(x => x.id == id).FirstOrDefault();
            Console.WriteLine("O que você quer atualizar: ");
            Console.WriteLine("1. Nome");
            Console.WriteLine("2. Sobrenome");
            Console.WriteLine("3. Telefone");
            Console.WriteLine("Comando:");
            string cmd = Console.ReadLine();

            if (cmd == "1") 
            {
                Console.WriteLine("Digite o nome:");
                string nome = Console.ReadLine();
                cli.Nome = nome;
            }
            else if(cmd == "2")
            {
                Console.WriteLine("Digite o sobrenome:");
                string sobrenome = Console.ReadLine();
                cli.Sobrenome = sobrenome;
            }
            else if (cmd == "3")
            {
                Console.WriteLine("Digite o telefone:");
                string telefone = Console.ReadLine();
                cli.Telefone = telefone;
            }
            ctx.SaveChanges();
            Console.WriteLine("Cliente atualizado...");
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
