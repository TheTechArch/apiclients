using System;
using System.Collections.Generic;
using System.Text;

namespace Nasjonalt.Skoleregister.Models
{
    public class Fylke
    {
        public string Fylkesnr { get; set; }
        public string Navn { get; set; }
        public string OrgNr { get; set; }
        public string OrgNrFylkesmann { get; set; }
    }
}
