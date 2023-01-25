using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreDB.Models
{
    public class Lagerbestand
    {
        public int Id { get; set; }
        public bool Zustand { get; set; }
        public int Price { get; set; }

        public Spiel Spiel { get; set; }
    }
}
