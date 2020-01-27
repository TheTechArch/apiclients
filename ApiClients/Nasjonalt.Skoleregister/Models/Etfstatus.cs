using System;
using System.Collections.Generic;
using System.Text;

namespace Nasjonalt.Skoleregister.Models
{
    public class Etfstatus
    {
        public string Godkjenningslov { get; set; }
        public string GodkjentStatus { get; set; }
        public string GodkjentStatusTekst { get; set; }
        public int Aktiv { get; set; }
    }
}
