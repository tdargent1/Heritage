using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heritage
{
    class Lion:Felin
    {

        public Lion(string nom, string lieuHabitation, string nomCrie, bool jeSuisDomestique, int nombrePattes)
            : base(nom, lieuHabitation, nomCrie, jeSuisDomestique, nombrePattes)
        {
        }

        public void Afficher()
        {
            Console.WriteLine("Nom: {0}. LIEU HABITATION: {1}. NOM CRIE: {2}. JE SUIS DOMESTIQUE: {3}. NOMBRE PATTE: {4}.",
                this.Nom, this.LieuHabitation, this.NomCrie, this.JeSuisDangereux, this.NombrePatte);
        }
    }
}
