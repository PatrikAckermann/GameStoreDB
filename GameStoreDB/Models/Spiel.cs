using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreDB.Models
{
    public class Spiel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int MinSpieler { get; set; }
        public int MaxSpieler { get; set; }

        public List<Lagerbestand> Lagerbestand { get; set; }
        public List<Spieltyp> Typ { get; set; } = null!;
        public List<Hersteller> Hersteller { get; set; } = null!;

    }
}
