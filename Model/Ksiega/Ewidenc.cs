using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebKPIR.Model.Ksiega
{
    public partial class Ewidenc
    {
         [Column("Nazwa_Skr")]
        public string NazwaSkr { get; set; }
         [Column("Numer_Dok")]
        public string NumerDok { get; set; }
        public DateTime? Data { get; set; }
        public double? Dzien { get; set; }
        public double? Brutto { get; set; }
        public double? Narast { get; set; }
         [Column("Mies_Ks")]
        public double? MiesKs { get; set; }
    }
}
