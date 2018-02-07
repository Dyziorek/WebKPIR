using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebKPIR.Model.Ksiega
{
    public partial class Dokument
    {
         [Column("Nr_Inwen")]
        public string NrInwen { get; set; }
         [Column("Gr_Rodz")]
        public string GrRodz { get; set; }
        
        public string Nazwa { get; set; }
         [Column("Wart_Inwen")]
        public double? WartInwen { get; set; }
         [Column("Dokument1")]
        public string Dokument1 { get; set; }
         [Column("Numer_Dok")]
        public string NumerDok { get; set; }
         [Column("Data_Dok")]
        public DateTime? DataDok { get; set; }
        public double? Wartosc { get; set; }
         [Column("Data_Lik")]
        public DateTime? DataLik { get; set; }
        public string Podstawa { get; set; }
         [Column("Data_Prz")]
        public DateTime? DataPrz { get; set; }
         [Column("Numer_Zak")]
        public string NumerZak { get; set; }
         [Column("Data_Zak")]
        public DateTime? DataZak { get; set; }
         [Column("Wart_Pocz")]
        public double? WartPocz { get; set; }
        public bool Rozlicz { get; set; }
         [Column("Zm_Winwen")]
        public double? ZmWinwen { get; set; }
         [Column("Zm_Wumorz")]
        public double? ZmWumorz { get; set; }
         [Column("Zm_Wamort")]
        public double? ZmWamort { get; set; }
        public double? Umorzenie { get; set; }
         [Column("Data_Zmian")]
        public DateTime? DataZmian { get; set; }
         [Column("Miejsce_St")]
        public string MiejsceSt { get; set; }
         [Column("Miejsce_Nw")]
        public string MiejsceNw { get; set; }
    }
}
