using System;
using System.Collections.Generic;
using System.Text;

namespace KamersModel
{
    public class Speler
    {
        public Speler()
        {
            Rugzak = new List<Voorwerp>();
        }

        public int Score { get; set; }

        public string Naam { get; set; }

        /// <summary>
        /// De plaats waar de speler zich nu bevindt.
        /// </summary>
        public Plaats HuidigePlaats { get; set; }

        /// <summary>
        /// Bevat de voorwerpen die een speler bij zich heeft.
        /// Alleen verplaatsbare voorwerpen kunnen in de rugzak
        /// zitten.
        /// </summary>
        public List<Voorwerp> Rugzak { get; set; }

        /// <summary>
        /// Neem een voorwerp uit de rugzak en plaats het in 
        /// de huidige ruimte
        /// </summary>
        /// <param name="voorwerp">Het voorwerp om in de ruimte te leggen.</param>
        /// <returns>Of het gelukt is om het voorwerp in de ruimte te leggen.</returns>
        public bool PlaatsVoorwerpInRuimte(Voorwerp voorwerp)
        {
            // haal het voorwerp uit de rugzak
            // plaats het in de ruimte
            if (Rugzak.Contains(voorwerp))
            {
                Rugzak.Remove(voorwerp);
                HuidigePlaats.Voorwerpen.Add(voorwerp);
                return true;
            }
            return false;
        }

        public bool NeemVoorwerpUitRuimte(Voorwerp voorwerp)
        {
            // haal het voorwerp uit de huidige ruimte, als
            // het verplaatsbaar is.
            // stop het in de rugzak.
            int index = HuidigePlaats.Voorwerpen.IndexOf(voorwerp);
            if(index != -1)
            {
                Rugzak.Add(HuidigePlaats.Voorwerpen[index]);
                HuidigePlaats.Voorwerpen.RemoveAt(index);
            }
            return false;
        }

        public override string ToString()
        {
            return $"Naam speler: {Naam}; score: {Score}; {Rugzak.Count} voorwerpen in rugzak";
        }
    }
}
