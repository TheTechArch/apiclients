using System;
using System.Collections.Generic;
using System.Text;

namespace Nasjonalt.Skoleregister.Models
{
    public class Relasjonstype
    {
        public string Beskrivelse { get; set; }
        public string Navn { get; set; }
        public string Id { get; set; }
        public bool ErSystemRelasjon { get; set; }
    }
}
