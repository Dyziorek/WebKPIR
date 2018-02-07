using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebKPIR.Model.Ksiega
{
    public partial class Firma
    {
         [Column("Nazwaskr")]
        public string Nazwaskr { get; set; }
         [Column("Nazwapelna")]
        public string Nazwapelna { get; set; }
         [Column("Nip_Kod")]
        public string NipKod { get; set; }
        public string Nip { get; set; }
        public string Regon { get; set; }
        public string Zezwolenie { get; set; }
        public string Urzadskarb { get; set; }
        public string Kraj { get; set; }
        public string Wojewodztw { get; set; }
        public string Powiat { get; set; }
        public string Gmina { get; set; }
        public string Ulica { get; set; }
        public string Nrdomu { get; set; }
        public string Nrlokalu { get; set; }
        public string Miejscowos { get; set; }
        public string Kod { get; set; }
        public string Poczta { get; set; }
        public string Email { get; set; }
        public bool Wvat { get; set; }
         [Column("Vat_Kw1")]
        public bool VatKw1 { get; set; }
         [Column("Vat_Kw2")]
        public bool VatKw2 { get; set; }
         [Column("Vat_Kw3")]
        public bool VatKw3 { get; set; }
         [Column("Vat_Kw4")]
        public bool VatKw4 { get; set; }
        public bool Ryczalt { get; set; }
         [Column("Rycz_Kw1")]
        public bool RyczKw1 { get; set; }
         [Column("Rycz_Kw2")]
        public bool RyczKw2 { get; set; }
         [Column("Rycz_Kw3")]
        public bool RyczKw3 { get; set; }
         [Column("Rycz_Kw4")]
        public bool RyczKw4 { get; set; }
        public string Bank { get; set; }
        public string Konto { get; set; }
         [Column("Sp_Brutto")]
        public bool SpBrutto { get; set; }
         [Column("Wsp_Wz")]
        public bool WspWz { get; set; }
         [Column("Druk_Wz")]
        public bool DrukWz { get; set; }
         [Column("Osoba_Fakt")]
        public string OsobaFakt { get; set; }
         [Column("Fakt_Roz")]
        public string FaktRoz { get; set; }
         [Column("Faktura_Mp")]
        public bool FakturaMp { get; set; }
         [Column("Rodzaj_Dz")]
        public string RodzajDz { get; set; }
        public bool Marza { get; set; }
        public string Telefon { get; set; }
         [Column("Cena_Impp")]
        public double? CenaImpp { get; set; }
         [Column("Ilosc_Impp")]
        public double? IloscImpp { get; set; }
         [Column("Prod_Impp")]
        public double? ProdImpp { get; set; }
         [Column("Epp_Impp")]
        public double? EppImpp { get; set; }
        public bool Index { get; set; }
         [Column("Typ_Numer")]
        public double? TypNumer { get; set; }
         [Column("D_Wzcena")]
        public bool DWzcena { get; set; }
         [Column("D_Facena")]
         public bool DFacena { get; set; }
          [Column("Cena_Sp1")]
        public string CenaSp1 { get; set; }
         [Column("Cena_Sp2")]
        public string CenaSp2 { get; set; }
         [Column("Cena_Sp3")]
        public string CenaSp3 { get; set; }
         [Column("Cena_Sp4")]
        public string CenaSp4 { get; set; }
         [Column("Wielkosc_C")]
        public double? WielkoscC { get; set; }
         [Column("Format_F")]
        public double? FormatF { get; set; }
         [Column("Drukarka_F")]
        public bool DrukarkaF { get; set; }
         [Column("Drukuj_R")]
        public bool DrukujR { get; set; }
         [Column("Auto_Index")]
        public bool AutoIndex { get; set; }
        
        public bool Inny3c { get; set; }
         [Column("Brak_Zaplt")]
        public bool BrakZaplt { get; set; }
         [Column("Miejsce_Dz")]
        public string MiejsceDz { get; set; }
         [Column("Dr_Poczta")]
        public bool DrPoczta { get; set; }
         [Column("Rozl_Numer")]
        public double? RozlNumer { get; set; }
         [Column("Kpir_Mem")]
        public bool KpirMem { get; set; }
         [Column("Kwvat0404")]
        public bool Kwvat0404 { get; set; }
         [Column("Pod_Unii")]
        public bool PodUnii { get; set; }
         [Column("Wsp_Spvat")]
        public double? WspSpvat { get; set; }
         [Column("Ildrukfakt")]
        public double? Ildrukfakt { get; set; }
         [Column("Mag_Ks")]
        public double? MagKs { get; set; }
         [Column("Mag_Ksa")]
        public bool MagKsa { get; set; }
         [Column("Mag_Ksdf")]
        public bool MagKsdf { get; set; }
         [Column("Mag_Roz")]
        public double? MagRoz { get; set; }
         [Column("Mag_Roza")]
        public bool MagRoza { get; set; }
        public bool Bezpodpisu { get; set; }
        public double? Ildrukwz { get; set; }
         [Column("Format_Fx")]
        public double? FormatFx { get; set; }
         [Column("Format_Fy")]
        public double? FormatFy { get; set; }
         [Column("Format_Fsz")]
        public double? FormatFsz { get; set; }
         [Column("Numer_Nist")]
        public bool NumerNist { get; set; }
         [Column("Format_Fwy")]
        public double? FormatFwy { get; set; }
        public string Swift { get; set; }
        public bool Walbezpln { get; set; }
        public bool RyczSumnz { get; set; }
        public bool Ewidencje { get; set; }
         [Column("Drukuj_Rn0")]
        public bool DrukujRn0 { get; set; }
         [Column("Z_Nip")]
        public string ZNip { get; set; }
         [Column("Z_Regon")]
        public string ZRegon { get; set; }
         [Column("Z_Pesel")]
        public double? ZPesel { get; set; }
         [Column("Z_RDOK")]
        public double? ZRdok { get; set; }
         [Column("Z_Dokument")]
        public string ZDokument { get; set; }
         [Column("Z_Nazwaskr")]
        public string ZNazwaskr { get; set; }
         [Column("Z_Nazwisko")]
        public string ZNazwisko { get; set; }
         [Column("Z_Imie")]
        public string ZImie { get; set; }
         [Column("Z_Dataur")]
        public DateTime? ZDataur { get; set; }
        [Column("R_Pkpir")]
        public double? RPkpir { get; set; }
        public bool Czyzezwol { get; set; }
        public bool Czyregon { get; set; }
        public bool Czymiejsce { get; set; }
        public double? Moiukup { get; set; }
        public bool Swock { get; set; }
         [Column("Vat_Ue_Kw1")]
        public bool VatUeKw1 { get; set; }
         [Column("Vat_Ue_Kw2")]
        public bool VatUeKw2 { get; set; }
         [Column("Vat_Ue_Kw3")]
        public bool VatUeKw3 { get; set; }
         [Column("Vat_Ue_Kw4")]
        public bool VatUeKw4 { get; set; }
         [Column("Podpis_F")]
        public double? PodpisF { get; set; }
         [Column("Redodst_F")]
        public double? RedodstF { get; set; }
    }
}
