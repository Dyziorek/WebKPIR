using System;
using System.Collections.Generic;

namespace WebKPIR.Model.Ksiega
{
    public partial class Kompens
    {
        public double Numer { get; set; }
        public string NazwaSkr { get; set; }
        public DateTime? DataDok { get; set; }
        public double? Wartosc { get; set; }
    }
}
