using System;
using System.Collections.Generic;
using System.Text;

namespace Nasjonalt.Skoleregister.Models
{
    public class Koordinater
    {
        public int Zoom { get; set; }
        public int Lengdegrad { get; set; }
        public int Breddegrad { get; set; }
        public string GeoKvalitet { get; set; }
    }
}
