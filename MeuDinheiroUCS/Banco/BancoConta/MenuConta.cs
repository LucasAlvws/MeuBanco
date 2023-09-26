using MeuDinheiroUCS.Banco.BancoCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuDinheiroUCS.Banco.BancoConta
{
    internal class MenuConta
    {
        private static void comando()
        {
            string scomando = Console.ReadLine();
            if (scomando == "1")
            {
                ListarContas.Run();
            }
            else if (scomando == "2")
            {
                ListarContasCli.Run();
            }
            else if (scomando == "3")
            {
                AdicionarConta.Run();
            }
            else if (scomando == "4")
            {
                DeletarConta.Run();
            }
            else if (scomando == "5")
            {
                BancoExtrato.ExtratoConta.Run();
            }
            else if (scomando == "6")
            {
                BancoExtrato.Deposito.Run();
            }
            else if (scomando == "7")
            {
                BancoExtrato.Saque.Run();
            }
            else if (scomando == "8")
            {

            }
        }
        public static void show()
        {
            Console.WriteLine("1. Listar todas as contas");
            Console.WriteLine("2. Listar contas de um cliente");
            Console.WriteLine("3. Adicionar Conta");
            Console.WriteLine("4. Deletar Conta");
            Console.WriteLine("5. Ver extrato de uma Conta");
            Console.WriteLine("6. Depositar");
            Console.WriteLine("7. Sacar");
            Console.WriteLine("8. Voltar ao menu");
            Console.WriteLine("Comando:");
            comando();
        }
    }
}
