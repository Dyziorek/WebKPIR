using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebKPIR.Model.Ksiega
{
    public partial class Amortyz
    {
         [Column("Nr_Inwen")]
        public string NrInwen { get; set; }
         [Column("Gr_Rodz")]
        public string GrRodz { get; set; }
        public string Nazwa { get; set; }
         [Column("Wart_Inwen")]
        public double? WartInwen { get; set; }
        public double? Umorzenie { get; set; }
         [Column("Msc_Amo")]
        public double? MscAmo { get; set; }
        public double? Wartosc { get; set; }
        public double? Amortyz1 { get; set; }
    }
}
