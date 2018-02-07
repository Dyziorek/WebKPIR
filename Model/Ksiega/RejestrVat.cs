using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebKPIR.Model.Ksiega
{
    public partial class RejestrVat
    {
        public RejestrVat()
        {
            Dziennik = new HashSet<Dziennik>();
            Wpisy = new HashSet<Wpisy>();
        }

        [Key]
        public short Id { get; set; }
        public string RejestrNazwa { get; set; }
        [ForeignKey("Rejestr")]
        public ICollection<Dziennik> Dziennik { get; set; }
        [ForeignKey("Rejestr")]
        public ICollection<Wpisy> Wpisy { get; set; }
    }
}
