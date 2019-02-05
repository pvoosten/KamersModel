using System;
using System.Collections.Generic;
using System.Text;

namespace KamersModel
{
    public class Plaats
    {
        public Plaats(string plaatsnaam)
        {
            Plaatsnaam = plaatsnaam;
        }

        /// <summary>
        /// De voorwerpen die zich op deze plaats bevinden
        /// </summary>
        public List<Voorwerp> Voorwerpen { get; set; }

        /// <summary>
        /// De speler die zich op deze plaats bevindt.
        /// </summary>
        public Speler Speler { get; set; }

        /// <summary>
        /// De naam van deze plaats.
        /// </summary>
        public string Plaatsnaam { get; }

        internal void VoegSpelerToe(Speler speler)
        {
            Speler = speler;
        }

        public override string ToString()
        {
            return $"Plaats {Plaatsnaam}";
        }
    }
}
