using System;
using System.Collections.Generic;
using System.Text;

namespace KamersModel
{
    public class Voorwerp
    {
        /// <summary>
        /// Sommige voorwerpen zitten vast op een plaats (bv een standbeeld, een lichtschakelaar, ...) 
        /// en sommige kan je meenemen (bv een afstandsbediening).
        /// </summary>
        public bool VastOpPlaats { get; set; }
    }
}
