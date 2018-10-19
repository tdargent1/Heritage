using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heritage
{
    class Cetace : Mammifere
    {
        protected int dureeApnee;
        protected int profondeurPlonge;

        public Cetace(string nom, string lieuHabitation, string nomCrie, bool jeSuisDomestique, int dureeApnee, int profondeurPlonge)
            : base(nom, lieuHabitation, nomCrie, jeSuisDomestique)
        {
            this.dureeApnee = dureeApnee;
            this.profondeurPlonge = profondeurPlonge;
        }

        public int DureeApnee
        {
            get
            {
                return this.dureeApnee;
            }
        }

        public int ProfondeurPlonge
        {
            get
            {
                return this.profondeurPlonge;
            }
        }
    }
}
