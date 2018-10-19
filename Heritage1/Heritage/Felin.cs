using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heritage
{
    class Felin:Mammifere
    {
        protected int nombrePattes;

        public Felin(string nom, string lieuHabitation, string nomCrie, bool jeSuisDomestique, int nombrePattes)
            : base(nom, lieuHabitation, nomCrie, jeSuisDomestique)
        {
            this.nombrePattes = nombrePattes;
        }

        public int NombrePatte
        {
            get
            {
                return this.nombrePattes;
            }
        }
    }
}
