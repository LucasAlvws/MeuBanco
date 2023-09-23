using MeuDinheiroUCS.EF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeuDinheiroUCS.EF.Models;
using Microsoft.EntityFrameworkCore;

namespace MeuDinheiroUCS.EF.Context
{
    internal class BancoContext : DbContext
    {

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Conta> Conta { get; set; }
        public DbSet<Extrato> Extrato { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=localhost;User Id=sa;Password=blog_6109;Database=UCSBANCO;TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");
            base.OnModelCreating(modelBuilder);
        }


        public static void CriarContaCliente(string nomecli, string sobrenomecli, string telefonecli)
        {
            
            BancoContext ctx = new();
            Random random = new Random();
            int numeroConta = random.Next(1000, 100000);
            int idContas = random.Next(1, 100000);
            var clientes = ctx.Cliente;
            var contas = ctx.Conta;
            Cliente NewCliente = new Cliente();
            Conta NewConta = new Conta();
            NewCliente.id = 1;
            NewCliente.Nome = nomecli;
            NewCliente.Sobrenome = sobrenomecli;
            NewCliente.Telefone = telefonecli;
            NewCliente.CodigoConta = numeroConta;
            NewConta.id = 1;
            NewConta.Codigo = numeroConta;
            NewConta.ClienteID = 1;
            ctx.Cliente.Add(NewCliente);
            ctx.Conta.Add(NewConta);
            ctx.SaveChanges();
        }
        public static void Teste1()
        {
            BancoContext ctx = new();

            var clientes = ctx.Cliente;

            foreach (var item in clientes)
            {
                Console.WriteLine($"Codigo: {item.id}");
                item.Nome = "Nicoly";
                
            }
            Cliente lucas = new Cliente();
            lucas.Nome = "Lucas";
            lucas.Sobrenome = "Alves";
            lucas.Telefone = "32126238";
            lucas.CodigoConta = 5254;
            ctx.Cliente.Add(lucas);
            ctx.SaveChanges();

        }
    }
}
