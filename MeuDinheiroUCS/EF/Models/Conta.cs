using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuDinheiroUCS.EF.Models
{
    internal class Conta
    {
        [Key]
        public int id { get; set; }
        public int Codigo { get; set; }
        public float Saldo { get; set; }
        public int ClienteID { get; set; }

    }
}
