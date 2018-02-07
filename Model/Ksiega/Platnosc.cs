using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebKPIR.Model.Ksiega
{
    public partial class Platnosc
    {
        public Platnosc()
        {
            Dziennik = new HashSet<Dziennik>();
            Wpisy = new HashSet<Wpisy>();
        }

        [Key]
         [Column("Typ_Platn")]
        public string TypPlatn { get; set; }
         [Column("Nazwa_Platn")]
        public string NazwaPlatn { get; set; }
         [Column("Czas_Platn")]
        public short CzasPlatn { get; set; }
        [ForeignKey("Forma_P")]
        public ICollection<Dziennik> Dziennik { get; set; }
        [ForeignKey("Forma_P")]
        public ICollection<Wpisy> Wpisy { get; set; }
    }
}
