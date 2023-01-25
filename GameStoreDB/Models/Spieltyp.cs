using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreDB.Models
{
    public class Spieltyp
    {
        public int Id { get; set; }
        public int Typ { get; set; }
        public string Name { get; set; } = null!;

        public Spiel Spiel { get; set; } = null!;
    }
}
