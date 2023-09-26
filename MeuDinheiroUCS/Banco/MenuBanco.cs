using MeuDinheiroUCS.Banco.BancoCliente;
using MeuDinheiroUCS.Banco.BancoConta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuDinheiroUCS.Banco
{
    internal class MenuBanco
    {
        public void comando()
        {
            string scomando = Console.ReadLine();
            if (scomando == "1")
            {
                Console.Clear();
                MenuCliente.show();
            }
            else if (scomando == "2")
            {
                Console.Clear();
                MenuConta.show();
            }
           
        }

        public void banco()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("+++MeuDinUCS+++");
                Console.WriteLine("1. Clientes");
                Console.WriteLine("2. Contas");
                Console.WriteLine("Comando:");
                comando();
            }
        }
    }
}
