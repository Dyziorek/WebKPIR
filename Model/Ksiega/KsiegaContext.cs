using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebKPIR.Model.Ksiega
{
    public partial class KsiegaContext : DbContext
    {
        public virtual DbSet<Amortyz> Amortyz { get; set; }
        public virtual DbSet<Dokument> Dokument { get; set; }
        public virtual DbSet<Dziennik> Dziennik { get; set; }
        public virtual DbSet<Ewid> Ewid { get; set; }
        public virtual DbSet<Ewidenc> Ewidenc { get; set; }
        public virtual DbSet<Firma> Firma { get; set; }
        public virtual DbSet<Klient> Klient { get; set; }
        public virtual DbSet<Kompens> Kompens { get; set; }
        public virtual DbSet<Kompensp> Kompensp { get; set; }
        public virtual DbSet<Konta> Konta { get; set; }
        public virtual DbSet<KontaB> KontaB { get; set; }
        public virtual DbSet<Pit5> Pit5 { get; set; }
        public virtual DbSet<Pit5sum> Pit5sum { get; set; }
        public virtual DbSet<Platnosc> Platnosc { get; set; }
        public virtual DbSet<RejestrVat> RejestrVat { get; set; }
        public virtual DbSet<Rok> Rok { get; set; }
        public virtual DbSet<Srodki> Srodki { get; set; }
        public virtual DbSet<TypKonta> TypKonta { get; set; }
        public virtual DbSet<Vat7> Vat7 { get; set; }
        public virtual DbSet<Wpisy> Wpisy { get; set; }
        public virtual DbSet<Wspolnik> Wspolnik { get; set; }
        public virtual DbSet<Zdarzen> Zdarzen { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\LocalRepos\WebKPIR\Data\KsiegaKP.mdf;Integrated Security=True;Connect Timeout=30");
            }

            
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Amortyz>(entity =>
            {
                entity.HasKey(e => e.NrInwen);

                entity.Property(e => e.NrInwen)
                    .HasColumnName("NR_INWEN")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Amortyz1).HasColumnName("AMORTYZ");

                entity.Property(e => e.GrRodz)
                    .HasColumnName("GR_RODZ")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MscAmo).HasColumnName("MSC_AMO");

                entity.Property(e => e.Nazwa)
                    .HasColumnName("NAZWA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Umorzenie).HasColumnName("UMORZENIE");

                entity.Property(e => e.WartInwen).HasColumnName("WART_INWEN");

                entity.Property(e => e.Wartosc).HasColumnName("WARTOSC");
            });

            modelBuilder.Entity<Dokument>(entity =>
            {
                entity.HasKey(e => e.NrInwen);

                entity.Property(e => e.NrInwen)
                    .HasColumnName("NR_INWEN")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DataDok)
                    .HasColumnName("DATA_DOK")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DataLik)
                    .HasColumnName("DATA_LIK")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DataPrz)
                    .HasColumnName("DATA_PRZ")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DataZak)
                    .HasColumnName("DATA_ZAK")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DataZmian)
                    .HasColumnName("DATA_ZMIAN")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Dokument1)
                    .HasColumnName("DOKUMENT")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.GrRodz)
                    .HasColumnName("GR_RODZ")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MiejsceNw)
                    .HasColumnName("MIEJSCE_NW")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MiejsceSt)
                    .HasColumnName("MIEJSCE_ST")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Nazwa)
                    .HasColumnName("NAZWA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumerDok)
                    .HasColumnName("NUMER_DOK")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumerZak)
                    .HasColumnName("NUMER_ZAK")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Podstawa)
                    .HasColumnName("PODSTAWA")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Rozlicz).HasColumnName("ROZLICZ");

                entity.Property(e => e.Umorzenie).HasColumnName("UMORZENIE");

                entity.Property(e => e.WartInwen).HasColumnName("WART_INWEN");

                entity.Property(e => e.WartPocz).HasColumnName("WART_POCZ");

                entity.Property(e => e.Wartosc).HasColumnName("WARTOSC");

                entity.Property(e => e.ZmWamort).HasColumnName("ZM_WAMORT");

                entity.Property(e => e.ZmWinwen).HasColumnName("ZM_WINWEN");

                entity.Property(e => e.ZmWumorz).HasColumnName("ZM_WUMORZ");
            });

            modelBuilder.Entity<Dziennik>(entity =>
            {
                entity.HasKey(e => e.Numer);

                entity.ToTable("DZIENNIK");

                entity.Property(e => e.Numer)
                    .HasColumnName("NUMER")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bezodl).HasColumnName("BEZODL");

                entity.Property(e => e.Brutto).HasColumnName("BRUTTO");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DataOtrz)
                    .HasColumnName("DATA_OTRZ")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Dzien).HasColumnName("DZIEN");

                entity.Property(e => e.Eksport).HasColumnName("EKSPORT");

                entity.Property(e => e.FormaP)
                    .HasColumnName("FORMA_P")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Kasa)
                    .HasColumnName("KASA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Konto).HasColumnName("KONTO");

                entity.Property(e => e.Korekta).HasColumnName("KOREKTA");

                entity.Property(e => e.Ksiega).HasColumnName("KSIEGA");

                entity.Property(e => e.MiesKs).HasColumnName("MIES_KS");

                entity.Property(e => e.MiesVat).HasColumnName("MIES_VAT");

                entity.Property(e => e.NajemTyp).HasColumnName("NAJEM_TYP");

                entity.Property(e => e.NazwaSkr)
                    .HasColumnName("NAZWA_SKR")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NazwaUsl)
                    .HasColumnName("NAZWA_USL")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Netto0).HasColumnName("NETTO0");

                entity.Property(e => e.Netto03).HasColumnName("NETTO03");

                entity.Property(e => e.Netto07).HasColumnName("NETTO07");

                entity.Property(e => e.Netto12).HasColumnName("NETTO12");

                entity.Property(e => e.Netto22).HasColumnName("NETTO22");

                entity.Property(e => e.NettoNp).HasColumnName("NETTO_NP");

                entity.Property(e => e.Nettozwol).HasColumnName("NETTOZWOL");

                entity.Property(e => e.Nip)
                    .HasColumnName("NIP")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.NipKod)
                    .HasColumnName("NIP_KOD")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Notatki)
                    .HasColumnName("NOTATKI")
                    .HasColumnType("text");

                entity.Property(e => e.NrEwid).HasColumnName("NR_EWID");

                entity.Property(e => e.NumerDok)
                    .HasColumnName("NUMER_DOK")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumerRej)
                    .HasColumnName("NUMER_REJ")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OpdKod)
                    .HasColumnName("OPD_KOD")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Opis)
                    .HasColumnName("OPIS")
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Rejestr).HasColumnName("REJESTR");

                entity.Property(e => e.Rok).HasColumnName("ROK");

                entity.Property(e => e.RozlTyp).HasColumnName("ROZL_TYP");

                entity.Property(e => e.Samochod).HasColumnName("SAMOCHOD");

                entity.Property(e => e.Struktura).HasColumnName("STRUKTURA");

                entity.Property(e => e.TerminP)
                    .HasColumnName("TERMIN_P")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.TypBezodl).HasColumnName("TYP_BEZODL");

                entity.Property(e => e.TypFakt).HasColumnName("TYP_FAKT");

                entity.Property(e => e.Uwagi)
                    .HasColumnName("UWAGI")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vat03).HasColumnName("VAT03");

                entity.Property(e => e.Vat07).HasColumnName("VAT07");

                entity.Property(e => e.Vat12).HasColumnName("VAT12");

                entity.Property(e => e.Vat22).HasColumnName("VAT22");

                entity.Property(e => e.VatBezodl).HasColumnName("VAT_BEZODL");

                entity.Property(e => e.WartoscZ).HasColumnName("WARTOSC_Z");

                entity.HasOne(d => d.FormaPNavigation)
                    .WithMany(p => p.Dziennik)
                    .HasForeignKey(d => d.FormaP)
                    .HasConstraintName("FK_DZIENNIK_PLATNOSC");

                entity.HasOne(d => d.KontoNavigation)
                    .WithMany(p => p.Dziennik)
                    .HasForeignKey(d => d.Konto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DZIENNIK_Konta");

                entity.HasOne(d => d.KsiegaNavigation)
                    .WithMany(p => p.Dziennik)
                    .HasForeignKey(d => d.Ksiega)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DZIENNIK_TypKonta");

                entity.HasOne(d => d.NazwaSkrNavigation)
                    .WithMany(p => p.Dziennik)
                    .HasForeignKey(d => d.NazwaSkr)
                    .HasConstraintName("FK_DZIENNIK_KLIENT");

                entity.HasOne(d => d.RejestrNavigation)
                    .WithMany(p => p.Dziennik)
                    .HasForeignKey(d => d.Rejestr)
                    .HasConstraintName("FK_DZIENNIK_RejestrVAT");
            });

            modelBuilder.Entity<Ewid>(entity =>
            {
                entity.HasKey(e => e.NrEwid);

                entity.Property(e => e.NrEwid).HasColumnName("NR_EWID");

                entity.Property(e => e.Opis)
                    .HasColumnName("OPIS")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ewidenc>(entity =>
            {
                entity.HasKey(e => e.NazwaSkr);

                entity.Property(e => e.NazwaSkr)
                    .HasColumnName("NAZWA_SKR")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Brutto).HasColumnName("BRUTTO");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Dzien).HasColumnName("DZIEN");

                entity.Property(e => e.MiesKs).HasColumnName("MIES_KS");

                entity.Property(e => e.Narast).HasColumnName("NARAST");

                entity.Property(e => e.NumerDok)
                    .HasColumnName("NUMER_DOK")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Firma>(entity =>
            {
                entity.HasKey(e => e.Nip);

                entity.ToTable("FIRMA");

                entity.Property(e => e.Nip)
                    .HasColumnName("NIP")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AutoIndex).HasColumnName("AUTO_INDEX");

                entity.Property(e => e.Bank)
                    .HasColumnName("BANK")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Bezpodpisu).HasColumnName("BEZPODPISU");

                entity.Property(e => e.BrakZaplt).HasColumnName("BRAK_ZAPLT");

                entity.Property(e => e.CenaImpp).HasColumnName("CENA_IMPP");

                entity.Property(e => e.CenaSp1)
                    .HasColumnName("CENA_SP1")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CenaSp2)
                    .HasColumnName("CENA_SP2")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CenaSp3)
                    .HasColumnName("CENA_SP3")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CenaSp4)
                    .HasColumnName("CENA_SP4")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Czymiejsce).HasColumnName("CZYMIEJSCE");

                entity.Property(e => e.Czyregon).HasColumnName("CZYREGON");

                entity.Property(e => e.Czyzezwol).HasColumnName("CZYZEZWOL");

                entity.Property(e => e.DFacena).HasColumnName("D_FACENA");

                entity.Property(e => e.DWzcena).HasColumnName("D_WZCENA");

                entity.Property(e => e.DrPoczta).HasColumnName("DR_POCZTA");

                entity.Property(e => e.DrukWz).HasColumnName("DRUK_WZ");

                entity.Property(e => e.DrukarkaF).HasColumnName("DRUKARKA_F");

                entity.Property(e => e.DrukujR).HasColumnName("DRUKUJ_R");

                entity.Property(e => e.DrukujRn0).HasColumnName("DRUKUJ_RN0");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EppImpp).HasColumnName("EPP_IMPP");

                entity.Property(e => e.Ewidencje).HasColumnName("EWIDENCJE");

                entity.Property(e => e.FaktRoz)
                    .HasColumnName("FAKT_ROZ")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.FakturaMp).HasColumnName("FAKTURA_MP");

                entity.Property(e => e.FormatF).HasColumnName("FORMAT_F");

                entity.Property(e => e.FormatFsz).HasColumnName("FORMAT_FSZ");

                entity.Property(e => e.FormatFwy).HasColumnName("FORMAT_FWY");

                entity.Property(e => e.FormatFx).HasColumnName("FORMAT_FX");

                entity.Property(e => e.FormatFy).HasColumnName("FORMAT_FY");

                entity.Property(e => e.Gmina)
                    .HasColumnName("GMINA")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ildrukfakt).HasColumnName("ILDRUKFAKT");

                entity.Property(e => e.Ildrukwz).HasColumnName("ILDRUKWZ");

                entity.Property(e => e.IloscImpp).HasColumnName("ILOSC_IMPP");

                entity.Property(e => e.Index).HasColumnName("INDEX");

                entity.Property(e => e.Inny3c).HasColumnName("INNY_3C");

                entity.Property(e => e.Kod)
                    .HasColumnName("KOD")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Konto)
                    .HasColumnName("KONTO")
                    .HasMaxLength(52)
                    .IsUnicode(false);

                entity.Property(e => e.KpirMem).HasColumnName("KPIR_MEM");

                entity.Property(e => e.Kraj)
                    .HasColumnName("KRAJ")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Kwvat0404).HasColumnName("KWVAT0404");

                entity.Property(e => e.MagKs).HasColumnName("MAG_KS");

                entity.Property(e => e.MagKsa).HasColumnName("MAG_KSA");

                entity.Property(e => e.MagKsdf).HasColumnName("MAG_KSDF");

                entity.Property(e => e.MagRoz).HasColumnName("MAG_ROZ");

                entity.Property(e => e.MagRoza).HasColumnName("MAG_ROZA");

                entity.Property(e => e.Marza).HasColumnName("MARZA");

                entity.Property(e => e.MiejsceDz)
                    .HasColumnName("MIEJSCE_DZ")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Miejscowos)
                    .HasColumnName("MIEJSCOWOS")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Moiukup).HasColumnName("MOIUKUP");

                entity.Property(e => e.Nazwapelna)
                    .HasColumnName("NAZWAPELNA")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Nazwaskr)
                    .HasColumnName("NAZWASKR")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NipKod)
                    .HasColumnName("NIP_KOD")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Nrdomu)
                    .HasColumnName("NRDOMU")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Nrlokalu)
                    .HasColumnName("NRLOKALU")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.NumerNist).HasColumnName("NUMER_NIST");

                entity.Property(e => e.OsobaFakt)
                    .HasColumnName("OSOBA_FAKT")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Poczta)
                    .HasColumnName("POCZTA")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PodUnii).HasColumnName("POD_UNII");

                entity.Property(e => e.PodpisF).HasColumnName("PODPIS_F");

                entity.Property(e => e.Powiat)
                    .HasColumnName("POWIAT")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ProdImpp).HasColumnName("PROD_IMPP");

                entity.Property(e => e.RPkpir).HasColumnName("R_PKPIR");

                entity.Property(e => e.RedodstF).HasColumnName("REDODST_F");

                entity.Property(e => e.Regon)
                    .HasColumnName("REGON")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.RodzajDz)
                    .HasColumnName("RODZAJ_DZ")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RozlNumer).HasColumnName("ROZL_NUMER");

                entity.Property(e => e.RyczKw1).HasColumnName("RYCZ_KW1");

                entity.Property(e => e.RyczKw2).HasColumnName("RYCZ_KW2");

                entity.Property(e => e.RyczKw3).HasColumnName("RYCZ_KW3");

                entity.Property(e => e.RyczKw4).HasColumnName("RYCZ_KW4");

                entity.Property(e => e.RyczSumnz).HasColumnName("RYCZ_SUMNZ");

                entity.Property(e => e.Ryczalt).HasColumnName("RYCZALT");

                entity.Property(e => e.SpBrutto).HasColumnName("SP_BRUTTO");

                entity.Property(e => e.Swift)
                    .HasColumnName("SWIFT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Swock).HasColumnName("SWOCK");

                entity.Property(e => e.Telefon)
                    .HasColumnName("TELEFON")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.TypNumer).HasColumnName("TYP_NUMER");

                entity.Property(e => e.Ulica)
                    .HasColumnName("ULICA")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Urzadskarb)
                    .HasColumnName("URZADSKARB")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.VatKw1).HasColumnName("VAT_KW1");

                entity.Property(e => e.VatKw2).HasColumnName("VAT_KW2");

                entity.Property(e => e.VatKw3).HasColumnName("VAT_KW3");

                entity.Property(e => e.VatKw4).HasColumnName("VAT_KW4");

                entity.Property(e => e.VatUeKw1).HasColumnName("VAT_UE_KW1");

                entity.Property(e => e.VatUeKw2).HasColumnName("VAT_UE_KW2");

                entity.Property(e => e.VatUeKw3).HasColumnName("VAT_UE_KW3");

                entity.Property(e => e.VatUeKw4).HasColumnName("VAT_UE_KW4");

                entity.Property(e => e.Walbezpln).HasColumnName("WALBEZPLN");

                entity.Property(e => e.WielkoscC).HasColumnName("WIELKOSC_C");

                entity.Property(e => e.Wojewodztw)
                    .HasColumnName("WOJEWODZTW")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.WspSpvat).HasColumnName("WSP_SPVAT");

                entity.Property(e => e.WspWz).HasColumnName("WSP_WZ");

                entity.Property(e => e.Wvat).HasColumnName("WVAT");

                entity.Property(e => e.ZDataur)
                    .HasColumnName("Z_DATAUR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ZDokument)
                    .HasColumnName("Z_DOKUMENT")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.ZImie)
                    .HasColumnName("Z_IMIE")
                    .HasMaxLength(22)
                    .IsUnicode(false);

                entity.Property(e => e.ZNazwaskr)
                    .HasColumnName("Z_NAZWASKR")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.ZNazwisko)
                    .HasColumnName("Z_NAZWISKO")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.ZNip)
                    .HasColumnName("Z_NIP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ZPesel)
                    .HasColumnName("Z_PESEL")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.ZRdok).HasColumnName("Z_RDOK");

                entity.Property(e => e.ZRegon)
                    .HasColumnName("Z_REGON")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Zezwolenie)
                    .HasColumnName("ZEZWOLENIE")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Klient>(entity =>
            {
                entity.HasKey(e => e.NazwaSkr);

                entity.ToTable("KLIENT");

                entity.Property(e => e.NazwaSkr)
                    .HasColumnName("NAZWA_SKR")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Adres)
                    .HasColumnName("ADRES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bank)
                    .HasColumnName("BANK")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Blokada).HasColumnName("BLOKADA");

                entity.Property(e => e.DaneAdr)
                    .HasColumnName("DANE_ADR")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Dowod)
                    .HasColumnName("DOWOD")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DowodData)
                    .HasColumnName("DOWOD_DATA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DowodOrg)
                    .HasColumnName("DOWOD_ORG")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.GrupaK)
                    .HasColumnName("GRUPA_K")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.KAdres)
                    .HasColumnName("K_ADRES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KKod)
                    .HasColumnName("K_KOD")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.KKraj)
                    .HasColumnName("K_KRAJ")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.KMiasto)
                    .HasColumnName("K_MIASTO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.KNazwa)
                    .HasColumnName("K_NAZWA")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Km).HasColumnName("KM");

                entity.Property(e => e.Kod)
                    .HasColumnName("KOD")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Konto)
                    .HasColumnName("KONTO")
                    .HasMaxLength(52)
                    .IsUnicode(false);

                entity.Property(e => e.Korespond).HasColumnName("KORESPOND");

                entity.Property(e => e.Kraj)
                    .HasColumnName("KRAJ")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Miasto)
                    .HasColumnName("MIASTO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NazwaPel)
                    .HasColumnName("NAZWA_PEL")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Nip)
                    .HasColumnName("NIP")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.NipKod)
                    .HasColumnName("NIP_KOD")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.OAdres)
                    .HasColumnName("O_ADRES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OKod)
                    .HasColumnName("O_KOD")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.OMiasto)
                    .HasColumnName("O_MIASTO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ONazwa)
                    .HasColumnName("O_NAZWA")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Opis)
                    .HasColumnName("OPIS")
                    .HasColumnType("text");

                entity.Property(e => e.OsobaFakt)
                    .HasColumnName("OSOBA_FAKT")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Pesel)
                    .HasColumnName("PESEL")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.PrefCena).HasColumnName("PREF_CENA");

                entity.Property(e => e.PrzedHand)
                    .HasColumnName("PRZED_HAND")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Rabat).HasColumnName("RABAT");

                entity.Property(e => e.Regon)
                    .HasColumnName("REGON")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Telefon)
                    .HasColumnName("TELEFON")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Transport)
                    .HasColumnName("TRANSPORT")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Waluta)
                    .HasColumnName("WALUTA")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Zaplata)
                    .HasColumnName("ZAPLATA")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Zaznaczony).HasColumnName("ZAZNACZONY");

                entity.Property(e => e.Zdarzenie)
                    .HasColumnName("ZDARZENIE")
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Zezwolenie)
                    .HasColumnName("ZEZWOLENIE")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Kompens>(entity =>
            {
                entity.HasKey(e => e.Numer);

                entity.ToTable("KOMPENS");

                entity.Property(e => e.Numer).HasColumnName("NUMER");

                entity.Property(e => e.DataDok)
                    .HasColumnName("DATA_DOK")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NazwaSkr)
                    .HasColumnName("NAZWA_SKR")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Wartosc).HasColumnName("WARTOSC");
            });

            modelBuilder.Entity<Kompensp>(entity =>
            {
                entity.HasKey(e => e.Numer);

                entity.ToTable("KOMPENSP");

                entity.Property(e => e.Numer).HasColumnName("NUMER");

                entity.Property(e => e.DataDok)
                    .HasColumnName("DATA_DOK")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DoRozl).HasColumnName("DO_ROZL");

                entity.Property(e => e.NumerDok)
                    .HasColumnName("NUMER_DOK")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Rozlicz).HasColumnName("ROZLICZ");

                entity.Property(e => e.TerminP)
                    .HasColumnName("TERMIN_P")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Typ).HasColumnName("TYP");

                entity.Property(e => e.WartoscD).HasColumnName("WARTOSC_D");
            });

            modelBuilder.Entity<Konta>(entity =>
            {
                entity.HasKey(e => e.Konto);

                entity.Property(e => e.Konto).HasColumnName("KONTO");

                entity.Property(e => e.Eksport).HasColumnName("EKSPORT");

                entity.Property(e => e.Ksiega).HasColumnName("KSIEGA");

                entity.Property(e => e.NajemTyp).HasColumnName("NAJEM_TYP");

                entity.Property(e => e.Nazwa)
                    .HasColumnName("NAZWA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumerRej)
                    .HasColumnName("NUMER_REJ")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Opis)
                    .HasColumnName("OPIS")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Rejestr).HasColumnName("REJESTR");

                entity.Property(e => e.Samochod).HasColumnName("SAMOCHOD");

                entity.Property(e => e.Struktura).HasColumnName("STRUKTURA");

                entity.Property(e => e.TypBezodl).HasColumnName("TYP_BEZODL");
            });

            modelBuilder.Entity<KontaB>(entity =>
            {
                entity.HasKey(e => e.Konto);

                entity.Property(e => e.Konto)
                    .HasColumnName("KONTO")
                    .HasMaxLength(52)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Bank)
                    .HasColumnName("BANK")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Swift)
                    .HasColumnName("SWIFT")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pit5>(entity =>
            {
                entity.HasKey(e => e.McRok);

                entity.ToTable("PIT5");

                entity.Property(e => e.McRok)
                    .HasColumnName("MC_ROK")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DataUr)
                    .HasColumnName("DATA_UR")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.E42)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Gmina)
                    .HasColumnName("GMINA")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Imie)
                    .HasColumnName("IMIE")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.J54)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.J56)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.K64)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.K65)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.K66)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.K67)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.K73)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.K74)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.K75)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.K76)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KodP)
                    .HasColumnName("KOD_P")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Kraj)
                    .HasColumnName("KRAJ")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.L100)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.L101)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.L102)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.L103)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.L104)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.L105)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.L106)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.L82)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.L83)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.L84)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.L85)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.L86)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.L87)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.L88)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.L89)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.L90)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.L98)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.L99)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.M114)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.M115)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.M121)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.M122)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Miejsc)
                    .HasColumnName("MIEJSC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mieszk)
                    .HasColumnName("MIESZK")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Nazwisko)
                    .HasColumnName("NAZWISKO")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Nip)
                    .HasColumnName("NIP")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Numer)
                    .HasColumnName("NUMER")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.O131)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Ogran).HasColumnName("OGRAN");

                entity.Property(e => e.Poczta)
                    .HasColumnName("POCZTA")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Powiat)
                    .HasColumnName("POWIAT")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Ulica)
                    .HasColumnName("ULICA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Urzad)
                    .HasColumnName("URZAD")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Wojew)
                    .HasColumnName("WOJEW")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Zanie).HasColumnName("ZANIE");
            });

            modelBuilder.Entity<Pit5sum>(entity =>
            {
                entity.HasKey(e => e.McRok);

                entity.ToTable("PIT5SUM");

                entity.Property(e => e.McRok)
                    .HasColumnName("MC_ROK")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.E35k).HasColumnName("E35K");

                entity.Property(e => e.E35n)
                    .HasColumnName("E35N")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.E36k).HasColumnName("E36K");

                entity.Property(e => e.E36n)
                    .HasColumnName("E36N")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.E37k).HasColumnName("E37K");

                entity.Property(e => e.E37n)
                    .HasColumnName("E37N")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.E38k).HasColumnName("E38K");

                entity.Property(e => e.E38n)
                    .HasColumnName("E38N")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.E39k).HasColumnName("E39K");

                entity.Property(e => e.E39n)
                    .HasColumnName("E39N")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.E40k).HasColumnName("E40K");

                entity.Property(e => e.E40n)
                    .HasColumnName("E40N")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.E41k).HasColumnName("E41K");

                entity.Property(e => e.E41n)
                    .HasColumnName("E41N")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.E42k).HasColumnName("E42K");

                entity.Property(e => e.E42n)
                    .HasColumnName("E42N")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.E43k).HasColumnName("E43K");

                entity.Property(e => e.E43n)
                    .HasColumnName("E43N")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.E44k).HasColumnName("E44K");

                entity.Property(e => e.E44n)
                    .HasColumnName("E44N")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F45k).HasColumnName("F45K");

                entity.Property(e => e.F45n)
                    .HasColumnName("F45N")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.F46k).HasColumnName("F46K");

                entity.Property(e => e.F46n)
                    .HasColumnName("F46N")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.J52k).HasColumnName("J52K");

                entity.Property(e => e.J52n)
                    .HasColumnName("J52N")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.J53k).HasColumnName("J53K");

                entity.Property(e => e.J53n)
                    .HasColumnName("J53N")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.J54k).HasColumnName("J54K");

                entity.Property(e => e.J54n)
                    .HasColumnName("J54N")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.J55num)
                    .HasColumnName("J55NUM")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.J56k).HasColumnName("J56K");

                entity.Property(e => e.J57d)
                    .HasColumnName("J57D")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.J62k).HasColumnName("J62K");

                entity.Property(e => e.J64k).HasColumnName("J64K");

                entity.Property(e => e.K69udz).HasColumnName("K69UDZ");

                entity.Property(e => e.K70prz).HasColumnName("K70PRZ");

                entity.Property(e => e.K71kosz).HasColumnName("K71KOSZ");

                entity.Property(e => e.K71roz).HasColumnName("K71ROZ");

                entity.Property(e => e.K78udz).HasColumnName("K78UDZ");

                entity.Property(e => e.K79prz).HasColumnName("K79PRZ");

                entity.Property(e => e.K80kosz).HasColumnName("K80KOSZ");

                entity.Property(e => e.K80roz).HasColumnName("K80ROZ");

                entity.Property(e => e.L106udz).HasColumnName("L106UDZ");

                entity.Property(e => e.L107prz).HasColumnName("L107PRZ");

                entity.Property(e => e.L108kosz).HasColumnName("L108KOSZ");

                entity.Property(e => e.L111dzwol).HasColumnName("L111DZWOL");

                entity.Property(e => e.L112zwi).HasColumnName("L112ZWI");

                entity.Property(e => e.L91udz).HasColumnName("L91UDZ");

                entity.Property(e => e.L92prz).HasColumnName("L92PRZ");

                entity.Property(e => e.L93kosz).HasColumnName("L93KOSZ");

                entity.Property(e => e.L96dzwol).HasColumnName("L96DZWOL");

                entity.Property(e => e.L97zwi).HasColumnName("L97ZWI");

                entity.Property(e => e.M115udz).HasColumnName("M115UDZ");

                entity.Property(e => e.M116prz).HasColumnName("M116PRZ");

                entity.Property(e => e.M117kosz).HasColumnName("M117KOSZ");

                entity.Property(e => e.M122udz).HasColumnName("M122UDZ");

                entity.Property(e => e.M123prz).HasColumnName("M123PRZ");

                entity.Property(e => e.M124kosz).HasColumnName("M124KOSZ");
            });

            modelBuilder.Entity<Platnosc>(entity =>
            {
                entity.HasKey(e => e.TypPlatn);

                entity.ToTable("PLATNOSC");

                entity.Property(e => e.TypPlatn)
                    .HasColumnName("TYP_PLATN")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CzasPlatn)
                    .HasColumnName("CZAS_PLATN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NazwaPlatn)
                    .HasColumnName("NAZWA_PLATN")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RejestrVat>(entity =>
            {
                entity.ToTable("RejestrVAT");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.RejestrNazwa)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Rok>(entity =>
            {
                entity.HasKey(e => e.RokKs);

                entity.Property(e => e.RokKs).HasColumnName("ROK_KS");

                entity.Property(e => e.IloscPr).HasColumnName("ILOSC_PR");

                entity.Property(e => e.ProgPod1).HasColumnName("PROG_POD1");

                entity.Property(e => e.ProgPod2).HasColumnName("PROG_POD2");

                entity.Property(e => e.ProgPod3).HasColumnName("PROG_POD3");

                entity.Property(e => e.Stawka1).HasColumnName("STAWKA1");

                entity.Property(e => e.Stawka2).HasColumnName("STAWKA2");

                entity.Property(e => e.Stawka3).HasColumnName("STAWKA3");

                entity.Property(e => e.Stawka4).HasColumnName("STAWKA4");

                entity.Property(e => e.Stawkar1).HasColumnName("STAWKAR1");

                entity.Property(e => e.Stawkar2).HasColumnName("STAWKAR2");

                entity.Property(e => e.Stawkar3).HasColumnName("STAWKAR3");

                entity.Property(e => e.Stawkar4).HasColumnName("STAWKAR4");

                entity.Property(e => e.Stawkar5).HasColumnName("STAWKAR5");

                entity.Property(e => e.Stawkar6).HasColumnName("STAWKAR6");

                entity.Property(e => e.Stawkar7).HasColumnName("STAWKAR7");

                entity.Property(e => e.Stawkar8).HasColumnName("STAWKAR8");

                entity.Property(e => e.Sumar1).HasColumnName("SUMAR1");

                entity.Property(e => e.Sumar2).HasColumnName("SUMAR2");

                entity.Property(e => e.Sumar3).HasColumnName("SUMAR3");

                entity.Property(e => e.Sumar4).HasColumnName("SUMAR4");

                entity.Property(e => e.Sumar5).HasColumnName("SUMAR5");

                entity.Property(e => e.Sumar6).HasColumnName("SUMAR6");

                entity.Property(e => e.Sumar7).HasColumnName("SUMAR7");

                entity.Property(e => e.Sumar8).HasColumnName("SUMAR8");

                entity.Property(e => e.UlgaPod).HasColumnName("ULGA_POD");
            });

            modelBuilder.Entity<Srodki>(entity =>
            {
                entity.HasKey(e => e.NumerDok);

                entity.Property(e => e.NumerDok)
                    .HasColumnName("NUMER_DOK")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Amortyz).HasColumnName("AMORTYZ");

                entity.Property(e => e.BrakAmo).HasColumnName("BRAK_AMO");

                entity.Property(e => e.DataDok)
                    .HasColumnName("DATA_DOK")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DataLik)
                    .HasColumnName("DATA_LIK")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DataOam)
                    .HasColumnName("DATA_OAM")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DataPrz)
                    .HasColumnName("DATA_PRZ")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DataZak)
                    .HasColumnName("DATA_ZAK")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Dostawca)
                    .HasColumnName("DOSTAWCA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GrRodz)
                    .HasColumnName("GR_RODZ")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Kurs).HasColumnName("KURS");

                entity.Property(e => e.Miejsce)
                    .HasColumnName("MIEJSCE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MiesNamor)
                    .HasColumnName("MIES_NAMOR")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MiesOa).HasColumnName("MIES_OA");

                entity.Property(e => e.MiesOas).HasColumnName("MIES_OAS");

                entity.Property(e => e.Nazwa)
                    .HasColumnName("NAZWA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NrFabr)
                    .HasColumnName("NR_FABR")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NrInwen)
                    .HasColumnName("NR_INWEN")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumerZak)
                    .HasColumnName("NUMER_ZAK")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Opis)
                    .HasColumnName("OPIS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Piecdzies).HasColumnName("PIECDZIES");

                entity.Property(e => e.Podstawa)
                    .HasColumnName("PODSTAWA")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Proporcja).HasColumnName("PROPORCJA");

                entity.Property(e => e.Samochod).HasColumnName("SAMOCHOD");

                entity.Property(e => e.StAmort).HasColumnName("ST_AMORT");

                entity.Property(e => e.Trzy).HasColumnName("TRZY");

                entity.Property(e => e.Typ)
                    .HasColumnName("TYP")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Umorzenie).HasColumnName("UMORZENIE");

                entity.Property(e => e.Uwagi)
                    .HasColumnName("UWAGI")
                    .HasColumnType("text");

                entity.Property(e => e.Wart50).HasColumnName("WART_50");

                entity.Property(e => e.WartInwen).HasColumnName("WART_INWEN");

                entity.Property(e => e.WartPocz).HasColumnName("WART_POCZ");

                entity.Property(e => e.WartZakt).HasColumnName("WART_ZAKT");

                entity.Property(e => e.Wartosc).HasColumnName("WARTOSC");

                entity.Property(e => e.Wskaznik).HasColumnName("WSKAZNIK");
            });

            modelBuilder.Entity<TypKonta>(entity =>
            {
                entity.HasKey(e => e.Kolumna);

                entity.HasIndex(e => e.Kolumna)
                    .HasName("IX_TypKonta")
                    .IsUnique();

                entity.Property(e => e.Kolumna)
                    .HasColumnName("KOLUMNA")
                    .ValueGeneratedNever();

                entity.Property(e => e.RejestrVat).HasColumnName("REJESTR_VAT");

                entity.Property(e => e.Typ)
                    .HasColumnName("TYP")
                    .HasMaxLength(50);

                entity.Property(e => e.Vat)
                    .HasColumnName("VAT")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Vat7>(entity =>
            {
                entity.HasKey(e => new { e.Mc4, e.Rok5 });

                entity.ToTable("VAT7");

                entity.Property(e => e.Mc4)
                    .HasColumnName("MC4")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Rok5)
                    .HasColumnName("ROK5")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.A6)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.B10)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.B11)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.B12)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.B13)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.B14)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.B15)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.B16)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.B17)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.B18)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.B7)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.B8)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.B81)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.B82)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.B9)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.C20a).HasColumnName("C20A");

                entity.Property(e => e.F69)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.G70)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.G71)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.G72)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Nip1)
                    .HasColumnName("NIP1")
                    .HasMaxLength(13)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Wpisy>(entity =>
            {
                entity.ToTable("WPISY");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Bezodl).HasColumnName("BEZODL");

                entity.Property(e => e.Brutto).HasColumnName("BRUTTO");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DataOtrz)
                    .HasColumnName("DATA_OTRZ")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Dzien).HasColumnName("DZIEN");

                entity.Property(e => e.Eksport).HasColumnName("EKSPORT");

                entity.Property(e => e.FormaP)
                    .HasColumnName("FORMA_P")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Kasa)
                    .HasColumnName("KASA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Konto).HasColumnName("KONTO");

                entity.Property(e => e.Korekta).HasColumnName("KOREKTA");

                entity.Property(e => e.Ksiega).HasColumnName("KSIEGA");

                entity.Property(e => e.MiesKs).HasColumnName("MIES_KS");

                entity.Property(e => e.MiesVat).HasColumnName("MIES_VAT");

                entity.Property(e => e.NajemTyp).HasColumnName("NAJEM_TYP");

                entity.Property(e => e.NazwaSkr)
                    .HasColumnName("NAZWA_SKR")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NazwaUsl)
                    .HasColumnName("NAZWA_USL")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Netto0).HasColumnName("NETTO0");

                entity.Property(e => e.Netto03).HasColumnName("NETTO03");

                entity.Property(e => e.Netto07).HasColumnName("NETTO07");

                entity.Property(e => e.Netto12).HasColumnName("NETTO12");

                entity.Property(e => e.Netto22).HasColumnName("NETTO22");

                entity.Property(e => e.NettoNp).HasColumnName("NETTO_NP");

                entity.Property(e => e.Nettozwol).HasColumnName("NETTOZWOL");

                entity.Property(e => e.Nip)
                    .HasColumnName("NIP")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.NipKod)
                    .HasColumnName("NIP_KOD")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Notatki)
                    .HasColumnName("NOTATKI")
                    .HasColumnType("text");

                entity.Property(e => e.NrEwid).HasColumnName("NR_EWID");

                entity.Property(e => e.Numer).HasColumnName("NUMER");

                entity.Property(e => e.NumerDok)
                    .HasColumnName("NUMER_DOK")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumerRej)
                    .HasColumnName("NUMER_REJ")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OpdKod)
                    .HasColumnName("OPD_KOD")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Opis)
                    .HasColumnName("OPIS")
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Rejestr).HasColumnName("REJESTR");

                entity.Property(e => e.RozlTyp).HasColumnName("ROZL_TYP");

                entity.Property(e => e.Samochod).HasColumnName("SAMOCHOD");

                entity.Property(e => e.Struktura).HasColumnName("STRUKTURA");

                entity.Property(e => e.TerminP)
                    .HasColumnName("TERMIN_P")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.TypBezodl).HasColumnName("TYP_BEZODL");

                entity.Property(e => e.TypFakt).HasColumnName("TYP_FAKT");

                entity.Property(e => e.Uwagi)
                    .HasColumnName("UWAGI")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vat03).HasColumnName("VAT03");

                entity.Property(e => e.Vat07).HasColumnName("VAT07");

                entity.Property(e => e.Vat12).HasColumnName("VAT12");

                entity.Property(e => e.Vat22).HasColumnName("VAT22");

                entity.Property(e => e.VatBezodl).HasColumnName("VAT_BEZODL");

                entity.Property(e => e.WartoscZ).HasColumnName("WARTOSC_Z");

                entity.HasOne(d => d.FormaPNavigation)
                    .WithMany(p => p.Wpisy)
                    .HasForeignKey(d => d.FormaP)
                    .HasConstraintName("FK_WPISY_PLATNOSC");

                entity.HasOne(d => d.KontoNavigation)
                    .WithMany(p => p.Wpisy)
                    .HasForeignKey(d => d.Konto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WPISY_KONTO");

                entity.HasOne(d => d.KsiegaNavigation)
                    .WithMany(p => p.Wpisy)
                    .HasForeignKey(d => d.Ksiega)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WPISY_TypKonta");

                entity.HasOne(d => d.NazwaSkrNavigation)
                    .WithMany(p => p.Wpisy)
                    .HasForeignKey(d => d.NazwaSkr)
                    .HasConstraintName("FK_WPISY_KLIENT");

                entity.HasOne(d => d.RejestrNavigation)
                    .WithMany(p => p.Wpisy)
                    .HasForeignKey(d => d.Rejestr)
                    .HasConstraintName("FK_WPISY_RejestrVAT");
            });

            modelBuilder.Entity<Wspolnik>(entity =>
            {
                entity.HasKey(e => e.Nip);

                entity.Property(e => e.Nip)
                    .HasColumnName("NIP")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Bank)
                    .HasColumnName("BANK")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dataurodze)
                    .HasColumnName("DATAURODZE")
                    .HasColumnType("date");

                entity.Property(e => e.Dowod)
                    .HasColumnName("DOWOD")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Gmina)
                    .HasColumnName("GMINA")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Imie)
                    .HasColumnName("IMIE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Kod)
                    .HasColumnName("KOD")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.KodTUb)
                    .HasColumnName("KOD_T_UB")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Konto)
                    .HasColumnName("KONTO")
                    .HasMaxLength(52)
                    .IsUnicode(false);

                entity.Property(e => e.Kraj)
                    .HasColumnName("KRAJ")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Miejscowos)
                    .HasColumnName("MIEJSCOWOS")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Nakos01).HasColumnName("NAKOS01");

                entity.Property(e => e.Nakos02).HasColumnName("NAKOS02");

                entity.Property(e => e.Nakos03).HasColumnName("NAKOS03");

                entity.Property(e => e.Nakos04).HasColumnName("NAKOS04");

                entity.Property(e => e.Nakos05).HasColumnName("NAKOS05");

                entity.Property(e => e.Nakos06).HasColumnName("NAKOS06");

                entity.Property(e => e.Nakos07).HasColumnName("NAKOS07");

                entity.Property(e => e.Nakos08).HasColumnName("NAKOS08");

                entity.Property(e => e.Nakos09).HasColumnName("NAKOS09");

                entity.Property(e => e.Nakos10).HasColumnName("NAKOS10");

                entity.Property(e => e.Nakos11).HasColumnName("NAKOS11");

                entity.Property(e => e.Nakos12).HasColumnName("NAKOS12");

                entity.Property(e => e.Namiejsce)
                    .HasColumnName("NAMIEJSCE")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Namiejscee)
                    .HasColumnName("NAMIEJSCEE")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Nanip)
                    .HasColumnName("NANIP")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Nanipe)
                    .HasColumnName("NANIPE")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Naprz01).HasColumnName("NAPRZ01");

                entity.Property(e => e.Naprz02).HasColumnName("NAPRZ02");

                entity.Property(e => e.Naprz03).HasColumnName("NAPRZ03");

                entity.Property(e => e.Naprz04).HasColumnName("NAPRZ04");

                entity.Property(e => e.Naprz05).HasColumnName("NAPRZ05");

                entity.Property(e => e.Naprz06).HasColumnName("NAPRZ06");

                entity.Property(e => e.Naprz07).HasColumnName("NAPRZ07");

                entity.Property(e => e.Naprz08).HasColumnName("NAPRZ08");

                entity.Property(e => e.Naprz09).HasColumnName("NAPRZ09");

                entity.Property(e => e.Naprz10).HasColumnName("NAPRZ10");

                entity.Property(e => e.Naprz11).HasColumnName("NAPRZ11");

                entity.Property(e => e.Naprz12).HasColumnName("NAPRZ12");

                entity.Property(e => e.Naudz01).HasColumnName("NAUDZ01");

                entity.Property(e => e.Naudz01e).HasColumnName("NAUDZ01E");

                entity.Property(e => e.Naudz02).HasColumnName("NAUDZ02");

                entity.Property(e => e.Naudz02e).HasColumnName("NAUDZ02E");

                entity.Property(e => e.Naudz03).HasColumnName("NAUDZ03");

                entity.Property(e => e.Naudz03e).HasColumnName("NAUDZ03E");

                entity.Property(e => e.Naudz04).HasColumnName("NAUDZ04");

                entity.Property(e => e.Naudz04e).HasColumnName("NAUDZ04E");

                entity.Property(e => e.Naudz05).HasColumnName("NAUDZ05");

                entity.Property(e => e.Naudz05e).HasColumnName("NAUDZ05E");

                entity.Property(e => e.Naudz06).HasColumnName("NAUDZ06");

                entity.Property(e => e.Naudz06e).HasColumnName("NAUDZ06E");

                entity.Property(e => e.Naudz07).HasColumnName("NAUDZ07");

                entity.Property(e => e.Naudz07e).HasColumnName("NAUDZ07E");

                entity.Property(e => e.Naudz08).HasColumnName("NAUDZ08");

                entity.Property(e => e.Naudz08e).HasColumnName("NAUDZ08E");

                entity.Property(e => e.Naudz09).HasColumnName("NAUDZ09");

                entity.Property(e => e.Naudz09e).HasColumnName("NAUDZ09E");

                entity.Property(e => e.Naudz10).HasColumnName("NAUDZ10");

                entity.Property(e => e.Naudz10e).HasColumnName("NAUDZ10E");

                entity.Property(e => e.Naudz11).HasColumnName("NAUDZ11");

                entity.Property(e => e.Naudz11e).HasColumnName("NAUDZ11E");

                entity.Property(e => e.Naudz12).HasColumnName("NAUDZ12");

                entity.Property(e => e.Naudz12e).HasColumnName("NAUDZ12E");

                entity.Property(e => e.Nazwisko)
                    .HasColumnName("NAZWISKO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NipKod)
                    .HasColumnName("NIP_KOD")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Nrdomu)
                    .HasColumnName("NRDOMU")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Nrlokalu)
                    .HasColumnName("NRLOKALU")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Pesel)
                    .HasColumnName("PESEL")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Poczta)
                    .HasColumnName("POCZTA")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PodLin).HasColumnName("POD_LIN");

                entity.Property(e => e.PodOkres).HasColumnName("POD_OKRES");

                entity.Property(e => e.Powiat)
                    .HasColumnName("POWIAT")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Procent).HasColumnName("PROCENT");

                entity.Property(e => e.Ub01).HasColumnName("UB01");

                entity.Property(e => e.Ub02).HasColumnName("UB02");

                entity.Property(e => e.Ub03).HasColumnName("UB03");

                entity.Property(e => e.Ub04).HasColumnName("UB04");

                entity.Property(e => e.Ub05).HasColumnName("UB05");

                entity.Property(e => e.Ub06).HasColumnName("UB06");

                entity.Property(e => e.Ub07).HasColumnName("UB07");

                entity.Property(e => e.Ub08).HasColumnName("UB08");

                entity.Property(e => e.Ub09).HasColumnName("UB09");

                entity.Property(e => e.Ub10).HasColumnName("UB10");

                entity.Property(e => e.Ub11).HasColumnName("UB11");

                entity.Property(e => e.Ub12).HasColumnName("UB12");

                entity.Property(e => e.Udzial01).HasColumnName("UDZIAL01");

                entity.Property(e => e.Udzial02).HasColumnName("UDZIAL02");

                entity.Property(e => e.Udzial03).HasColumnName("UDZIAL03");

                entity.Property(e => e.Udzial04).HasColumnName("UDZIAL04");

                entity.Property(e => e.Udzial05).HasColumnName("UDZIAL05");

                entity.Property(e => e.Udzial06).HasColumnName("UDZIAL06");

                entity.Property(e => e.Udzial07).HasColumnName("UDZIAL07");

                entity.Property(e => e.Udzial08).HasColumnName("UDZIAL08");

                entity.Property(e => e.Udzial09).HasColumnName("UDZIAL09");

                entity.Property(e => e.Udzial10).HasColumnName("UDZIAL10");

                entity.Property(e => e.Udzial11).HasColumnName("UDZIAL11");

                entity.Property(e => e.Udzial12).HasColumnName("UDZIAL12");

                entity.Property(e => e.Ulica)
                    .HasColumnName("ULICA")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Urzadskarb)
                    .HasColumnName("URZADSKARB")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Wojewodztw)
                    .HasColumnName("WOJEWODZTW")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Zus01).HasColumnName("ZUS01");

                entity.Property(e => e.Zus02).HasColumnName("ZUS02");

                entity.Property(e => e.Zus03).HasColumnName("ZUS03");

                entity.Property(e => e.Zus04).HasColumnName("ZUS04");

                entity.Property(e => e.Zus05).HasColumnName("ZUS05");

                entity.Property(e => e.Zus06).HasColumnName("ZUS06");

                entity.Property(e => e.Zus07).HasColumnName("ZUS07");

                entity.Property(e => e.Zus08).HasColumnName("ZUS08");

                entity.Property(e => e.Zus09).HasColumnName("ZUS09");

                entity.Property(e => e.Zus10).HasColumnName("ZUS10");

                entity.Property(e => e.Zus11).HasColumnName("ZUS11");

                entity.Property(e => e.Zus12).HasColumnName("ZUS12");

                entity.Property(e => e.ZusWsp)
                    .HasColumnName("ZUS_WSP")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<Zdarzen>(entity =>
            {
                entity.HasKey(e => e.IdZdarzenia);

                entity.Property(e => e.IdZdarzenia)
                    .HasColumnName("ID_ZDARZENIA")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Zdarzenie)
                    .HasColumnName("ZDARZENIE")
                    .HasMaxLength(75)
                    .IsUnicode(false);
            });
        }
    }
}
