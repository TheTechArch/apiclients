using System;
using System.Collections.Generic;
using System.Text;

namespace Nasjonalt.Skoleregister.Models
{
    public class Kommune
    {
        public bool ErNedlagt { get; set; }
        public Kommunegruppe KommuneGruppe { get; set; }
        public string Kommunenr { get; set; }
        public string Navn { get; set; }
        public string OrgNr { get; set; }
        public string Fylkesnr { get; set; }
    }
}
