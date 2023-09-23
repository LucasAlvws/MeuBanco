using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuDinheiroUCS.Banco.BancoCliente
{
    internal class MenuCliente
    {
        private static void comando()
        {
            string scomando = Console.ReadLine();
            if (scomando == "1")
            {
                AdionarCliente.Run();
            }
            else if (scomando == "2")
            {
                ListarCliente.Run();
            }
            else if(scomando == "3")
            {
                DeletarCliente.Run();
            }
            else if (scomando == "4")
            {
                AtualizarCliente.Run();
            }
            else if (scomando== "5")
            {
                
            }
        }
        public static void show()
        {
            Console.WriteLine("1. Adicionar Cliente");
            Console.WriteLine("2. Listar Cliente");
            Console.WriteLine("3. Deletar Cliente");
            Console.WriteLine("4. Atualizar Cliente");
            Console.WriteLine("5. Voltar ao menu");
            Console.WriteLine("Comando:");
            comando();
        }
    }
}
