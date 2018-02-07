using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebKPIR.Model.Ksiega
{
    public partial class Klient
    {
        public Klient()
        {
            Dziennik = new HashSet<Dziennik>();
            Wpisy = new HashSet<Wpisy>();
        }

        public bool Zaznaczony { get; set; }
        public bool Blokada { get; set; }
        [Column("Nazwa_Skr")]
        public string NazwaSkr { get; set; }
        [Column("Nazwa_Pel")]
        public string NazwaPel { get; set; }
        [Column("Grupa_K")]
        public string GrupaK { get; set; }
        public string Adres { get; set; }
        public string Kraj { get; set; }
        public string Kod { get; set; }
        public string Miasto { get; set; }
        [Column("Nip_Kod")]
        public string NipKod { get; set; }
        [Key]
        public string Nip { get; set; }
        public string Regon { get; set; }
        public string Pesel { get; set; }
        public string Zezwolenie { get; set; }
        public string Zdarzenie { get; set; }
        public string Dowod { get; set; }
        [Column("Dowod_Data")]
        public DateTime? DowodData { get; set; }
        [Column("Dowod_Org")]
        public string DowodOrg { get; set; }
        public string Bank { get; set; }
        public string Konto { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        [Column("Osoba_Fakt")]
        public string OsobaFakt { get; set; }
        public double? Rabat { get; set; }
        [Column("Pref_Cena")]
        public double? PrefCena { get; set; }
        public string Transport { get; set; }
        public string Zaplata { get; set; }
        [Column("K_Adres")]
        public string KAdres { get; set; }
        [Column("K_Kod")]
        public string KKod { get; set; }
        [Column("K_Miasto")]
        public string KMiasto { get; set; }
        [Column("K_Nazwa")]
        public string KNazwa { get; set; }
        [Column("K_Kraj")]
        public string KKraj { get; set; }
        public bool Korespond { get; set; }
        public string Opis { get; set; }
        [Column("Przed_Hand")]
        public string PrzedHand { get; set; }
        [Column("O_Nazwa")]
        public string ONazwa { get; set; }
        [Column("O_Adres")]
        public string OAdres { get; set; }
        [Column("O_Kod")]
        public string OKod { get; set; }
        [Column("O_Miasto")]
        public string OMiasto { get; set; }
        public double? Km { get; set; }
        [Column("Dane_Adr")]
        public string DaneAdr { get; set; }
        public string Waluta { get; set; }

        public ICollection<Dziennik> Dziennik { get; set; }
        public ICollection<Wpisy> Wpisy { get; set; }
    }
}
