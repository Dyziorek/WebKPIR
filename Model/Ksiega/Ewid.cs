using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebKPIR.Model.Ksiega
{
    public partial class Ewid
    {
         [Column("Nr_Ewid")]
        public double NrEwid { get; set; }
        public string Opis { get; set; }
    }
}
