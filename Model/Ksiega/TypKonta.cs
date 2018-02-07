using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebKPIR.Model.Ksiega
{
    public partial class TypKonta
    {
        public TypKonta()
        {
            Dziennik = new HashSet<Dziennik>();
            Wpisy = new HashSet<Wpisy>();
        }
        
        [Key]
        public int Kolumna { get; set; }
        public string Typ { get; set; }
        public int? RejestrVat { get; set; }
        public string Vat { get; set; }

        [ForeignKey("Ksiega")]
        public ICollection<Dziennik> Dziennik { get; set; }
        [ForeignKey("Ksiega")]
        public ICollection<Wpisy> Wpisy { get; set; }
    }
}
