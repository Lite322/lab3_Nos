using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_Nos.Model
{
    public class Guitar
    {
        public int GuitarId { get; set; }
        public int Neck { get; set; } // Гриф
        public int Pegs { get; set; } // Колки
        public int Strings { get; set; } // Струны
        public int Vocalist { get; set; } // Голосник
        public int Body { get; set; } // Корпус
        public int Frets { get; set; } // Лады
        public int Bridge { get; set; } // Бридж
        public int Selector { get; set; } // Селектор
    }
}
// Neck, Pegs, Strings, Vocalist, Body, Frets, Bridge, Selector