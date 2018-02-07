using System;
using System.Collections.Generic;

namespace WebKPIR.Model.Ksiega
{
    public partial class Srodki
    {
        public string NumerDok { get; set; }
        public DateTime? DataDok { get; set; }
        public string NumerZak { get; set; }
        public DateTime? DataZak { get; set; }
        public DateTime? DataPrz { get; set; }
        public string NrInwen { get; set; }
        public string GrRodz { get; set; }
        public string Nazwa { get; set; }
        public double? WartInwen { get; set; }
        public double? WartPocz { get; set; }
        public double? Umorzenie { get; set; }
        public double? Amortyz { get; set; }
        public double? StAmort { get; set; }
        public double? Wskaznik { get; set; }
        public double? WartZakt { get; set; }
        public double? MiesOa { get; set; }
        public string MiesNamor { get; set; }
        public DateTime? DataLik { get; set; }
        public string Podstawa { get; set; }
        public DateTime? DataOam { get; set; }
        public string Opis { get; set; }
        public string Dostawca { get; set; }
        public string Miejsce { get; set; }
        public string Typ { get; set; }
        public string NrFabr { get; set; }
        public bool Trzy { get; set; }
        public bool Proporcja { get; set; }
        public bool BrakAmo { get; set; }
        public string Uwagi { get; set; }
        public bool Piecdzies { get; set; }
        public double? Wart50 { get; set; }
        public bool Samochod { get; set; }
        public double? Kurs { get; set; }
        public double? Wartosc { get; set; }
        public double? MiesOas { get; set; }
    }
}
