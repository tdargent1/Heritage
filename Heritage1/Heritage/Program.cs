using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Heritage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Mammifere> listObjet = new List<Mammifere>();
           

            Lion mufasa = new Lion("Mufasa", "Savane", "Rugir", false, 4);
            Chat simba = new Chat("Simba", "Maison", "Miauler", true, 4);
            Baleine grosseBaleine = new Baleine("Grosse Baleine", "Océan", "Chanter", false, 5, 500);
            listObjet.Add(mufasa);
            listObjet.Add(simba);
            listObjet.Add(grosseBaleine);

            Console.WriteLine("Voici les trois animaux:");
            Console.WriteLine("");
            mufasa.Afficher();
            Console.WriteLine("");
            simba.Afficher();
            Console.WriteLine("");
            grosseBaleine.Afficher();
            Console.WriteLine("");
            Console.WriteLine("Le critère permettant de connaitre la dangerosité de l'animal est: JeSuisDomestique (True/False)");
            Console.WriteLine("Souhaitez-vous un animal dangereux ou domestique?");
            bool result = Convert.ToBoolean(Console.ReadLine());
            /*for (int i = 0; i < listObjet.Count; i++)
            {
                listObjet[i]
            }*/
            if (result == true)
            {
                Console.WriteLine("Chat");
            }
            else
            {
                Console.WriteLine("Lion, Baleine");
            }




            Console.ReadLine();
        }
    }
}
