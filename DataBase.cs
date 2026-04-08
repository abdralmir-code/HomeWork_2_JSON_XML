using Symphony_Orchestra.Instrument;
using Symphony_Orchestra.Musician;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Symphony_Orchestra
{
    public class DataBase
    {
        public List<Conductor> conductors { get; set; } = new List<Conductor>();
        public List<Musicians> musicians { get; set; } = new List<Musicians>();
        public List<Instruments> instruments { get; set; } = new List<Instruments>();
    }
}
