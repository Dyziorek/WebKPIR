using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebKPIR.Model.Ksiega
{
    public partial class Dziennik
    {
        public int Konto { get; set; }
        public int Ksiega { get; set; }
        public bool Struktura { get; set; }
        [Column ("Nazwa_Skr")]
        public string NazwaSkr { get; set; }
        [Column ("Numer_Dok")]
        public string NumerDok { get; set; }
        public DateTime? Data { get; set; }
        public int? Dzien { get; set; }
        public string Opis { get; set; }
        public short? Rejestr { get; set; }
        public double? Netto22 { get; set; }
        public double? Vat22 { get; set; }
        public double? Netto12 { get; set; }
        public double? Vat12 { get; set; }
        public double? Netto07 { get; set; }
        public double? Vat07 { get; set; }
        public double? Netto03 { get; set; }
        public double? Vat03 { get; set; }
        public double? Netto0 { get; set; }
        public double? Nettozwol { get; set; }
        public double? Bezodl { get; set; }
        [Column("Vat_Bezodl")]
        public double? VatBezodl { get; set; }
        [Column("Typ_Bezodl")]
        public double? TypBezodl { get; set; }
        [Column("Netto_Np")]
        public double? NettoNp { get; set; }
        public double? Brutto { get; set; }
        [Column("Data_Otrz")]
        public DateTime? DataOtrz { get; set; }
        [Column("Mies_Vat")]
        public int? MiesVat { get; set; }
        [Column("Mies_Ks")]
        public int? MiesKs { get; set; }
        public bool Korekta { get; set; }
        public string Uwagi { get; set; }
        public bool Samochod { get; set; }
        [Column("Numer_Rej")]
        public string NumerRej { get; set; }
        public bool Eksport { get; set; }
        public string Notatki { get; set; }
        [Column("Najem_Typ")]
        public int? NajemTyp { get; set; }
        [Column("Rozl_Typ")]
        public int? RozlTyp { get; set; }
        [Column("Forma_P")]
        public string FormaP { get; set; }
        [Column("Termin_P")]
        public DateTime? TerminP { get; set; }
        [Column("Wartosc_Z")]
        public double? WartoscZ { get; set; }
        [Key]
        public int Numer { get; set; }
        public string Kasa { get; set; }
        [Column("Typ_Fakt")]
        public int? TypFakt { get; set; }
        public string Nip { get; set; }
        [Column("Nip_Kod")]
        public string NipKod { get; set; }
        [Column("Opd_Kod")]
        public string OpdKod { get; set; }
        [Column("Nr_Ewid")]
        public int? NrEwid { get; set; }
        [Column("Nazwa_Usl")]
        public string NazwaUsl { get; set; }
        public short? Rok { get; set; }

        public Platnosc FormaPNavigation { get; set; }
        public Konta KontoNavigation { get; set; }
        public TypKonta KsiegaNavigation { get; set; }
        public Klient NazwaSkrNavigation { get; set; }
        public RejestrVat RejestrNavigation { get; set; }
    }
}
