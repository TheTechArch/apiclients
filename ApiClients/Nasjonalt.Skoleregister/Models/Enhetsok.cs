using System;
using System.Collections.Generic;
using System.Text;

namespace Nasjonalt.Skoleregister.Models
{
    public class Enhetsok
    {
        public string SokeString { get; set; }
        public string NaceKode { get; set; }
        public string SkoleType { get; set; }
        public string Fylke { get; set; }
        public string Kommune { get; set; }
        public bool Nedlagte { get; set; }
        public bool Aktive { get; set; }
        public bool Skoler { get; set; }
        public bool Eiere { get; set; }
        public bool AndreEnheter { get; set; }
    }

}


