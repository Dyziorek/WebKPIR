using System;
using System.Collections.Generic;

namespace WebKPIR.Model.Ksiega
{
    public partial class Kompensp
    {
        public double Numer { get; set; }
        public double? Typ { get; set; }
        public string NumerDok { get; set; }
        public double? Rozlicz { get; set; }
        public double? DoRozl { get; set; }
        public double? WartoscD { get; set; }
        public DateTime? DataDok { get; set; }
        public DateTime? TerminP { get; set; }
    }
}
