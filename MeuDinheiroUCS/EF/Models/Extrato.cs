using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuDinheiroUCS.EF.Models
{
    internal class Extrato
    {
        [Key]
        public int id { get; set; }
        public double Valor { get; set; }
        public string Descricao { get; set; }
        public int ContaID { get; set; }
    }
}


/*public int BusinessEntityID { get; set; }
public string AccountNumber { get; set; }
public string Name { get; set; }
public byte CreditRating { get; set; }
public bool PreferredVendorStatus { get; set; }
public bool ActiveFlag { get; set; }
public string? PurchasingWebServiceURL { get; set; }
public DateTime ModifiedDate { get; set; }*/
