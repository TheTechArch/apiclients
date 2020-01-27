using System;
using System.Collections.Generic;
using System.Text;

namespace Nasjonalt.Skoleregister.Models
{

    public class Enhet
    {
        public int NSRId { get; set; }
        public string OrgNr { get; set; }
        public string Navn { get; set; }
        public string Karakteristikk { get; set; }
        public string FulltNavn { get; set; }
        public string Kallenavn { get; set; }
        public string KommuneNavn { get; set; }
        public string Epost { get; set; }
        public string Url { get; set; }
        public string Maalform { get; set; }
        public string Leder { get; set; }
        public string LederFornavn { get; set; }
        public string LederEtternavn { get; set; }
        public string GsiId { get; set; }
        public string Telefon { get; set; }
        public string Mobil { get; set; }
        public string Fax { get; set; }
        public string PersonEpost { get; set; }
        public string PersonTelefon { get; set; }
        public bool ErSkole { get; set; }
        public bool ErSkoleEier { get; set; }
        public bool ErGrunnSkole { get; set; }
        public bool ErPrivatSkole { get; set; }
        public bool ErOffentligSkole { get; set; }
        public bool ErVideregaaendeSkole { get; set; }
        public bool VisesPaaWeb { get; set; }
        public bool ErAktiv { get; set; }
        public int Elevtall { get; set; }
        public int AnsatteFra { get; set; }
        public int AnsatteTil { get; set; }
        public int SkoleTrinnFra { get; set; }
        public int SkoleTrinnTil { get; set; }
        public Etfstatus EtfStatus { get; set; }
        public DateTime SistEndretDato { get; set; }
        public DateTime OpprettetDato { get; set; }
        public Adresse Besoksadresse { get; set; }
        public Nacekoder[] Nacekoder { get; set; }
        public Adresse Postadresse { get; set; }
        public Fylke Fylke { get; set; }
        public Enhetstype EnhetsType { get; set; }
        public Sektortype SektorType { get; set; }
        public Skoletyper[] SkoleTyper { get; set; }
        public Kommune Kommune { get; set; }
        public Koordinater Koordinater { get; set; }
        public Utgaattype Utgaattype { get; set; }
        public Relasjoner[] ParentRelasjoner { get; set; }
        public Relasjoner[] ChildRelasjoner { get; set; }
    }

}