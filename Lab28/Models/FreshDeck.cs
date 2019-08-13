using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab28.Models
{
    public class FreshDeck
    {
        public bool Shuffled { get; set; }
        public bool Success { get; set; }
        public string Deck_Id { get; set; }
        public int Remaining { get; set; }

    }
}