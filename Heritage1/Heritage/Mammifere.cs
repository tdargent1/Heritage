using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heritage
{
    class Mammifere
    {
        protected string nom;
        protected string lieuHabitation;
        protected string nomCrie;
        protected bool jeSuisDomestique;

        public Mammifere(string nom, string lieuHabitation, string nomCrie, bool jeSuisDomestique)
        {
            this.nom = nom;
            this.lieuHabitation = lieuHabitation;
            this.nomCrie = nomCrie;
            this.jeSuisDomestique = jeSuisDomestique;
        }

        public string Nom
        {
            get
            {
                return this.nom;
            }
        }

        public string LieuHabitation
        {
            get
            {
                return this.lieuHabitation;
            }
        }

        public string NomCrie
        {
            get
            {
                return this.nomCrie;
            }
        }

        public bool JeSuisDangereux
        {
            get
            {
                return this.jeSuisDomestique;
            }
        }
    }
}
