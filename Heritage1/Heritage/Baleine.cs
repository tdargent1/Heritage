using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heritage
{
    class Baleine:Cetace
    {

        public Baleine(string nom, string lieuHabitation, string nomCrie, bool jeSuisDomestique, int dureeApnee, int profondeurPlonge)
            : base(nom, lieuHabitation, nomCrie, jeSuisDomestique, dureeApnee, profondeurPlonge)
        {
        }

        public void Afficher()
        {
            Console.WriteLine("Nom: {0}. LIEU HABITATION: {1}. NOM CRIE: {2}. JE SUIS DOMESTIQUE: {3}. DUREE APNEE: {4}h. PROFONDEUR PLONGEE: {5}.",
                this.Nom, this.LieuHabitation, this.NomCrie, this.JeSuisDangereux, this.DureeApnee, this.ProfondeurPlonge);
        }
    }
}
