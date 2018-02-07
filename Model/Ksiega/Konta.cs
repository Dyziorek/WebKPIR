using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebKPIR.Model.Ksiega
{
    public partial class Konta
    {
        public Konta()
        {
            Dziennik = new HashSet<Dziennik>();
            Wpisy = new HashSet<Wpisy>();
        }

        [Key]
        public int Konto { get; set; }
        public string Nazwa { get; set; }
        public int? Ksiega { get; set; }
        public string Opis { get; set; }
        public double? Rejestr { get; set; }
        public bool Samochod { get; set; }
        [Column("Numer_Rej")]
        public string NumerRej { get; set; }
        public bool Struktura { get; set; }
        public bool Eksport { get; set; }
        [Column("Najem_Typ")]
        public double? NajemTyp { get; set; }
        [Column("Typ_Bezodl")]
        public double? TypBezodl { get; set; }

        public ICollection<Dziennik> Dziennik { get; set; }
        public ICollection<Wpisy> Wpisy { get; set; }
    }
}
