using System;
using System.Collections.Generic;
using System.Text;

namespace KamersModel
{
    /// <summary>
    /// Een spelomgeving of een level
    /// </summary>
    public class Level
    {
        public Plaats Startplaats { get; }
        public IEnumerable<Plaats> Plaatsen { get; }

        public Level(Plaats startplaats)
        {
            Startplaats = startplaats;
            Plaatsen = new List<Plaats> { Startplaats };
        }

        public void VoegSpelerToe(Speler speler)
        {
            Startplaats.VoegSpelerToe(speler);
        }
    }
}
