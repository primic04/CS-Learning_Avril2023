using System;
using System.Collections.Generic;

namespace All_I_Know_Now
{
    class Program
    {

        enum month
        {
            janvier,
            fevrier,
            mars,
            avril,
            juin,
            juillet,
            août,
            septembre,
            octobre,
            novembre,
            decembre
        }


        static void Main(string[] args)

        {

            Console.WriteLine("PROGRAM ALL I KNOW");
            Console.WriteLine();
            Console.WriteLine(month.janvier);
            Console.WriteLine("");


            Console.WriteLine("Bonjour, Comment t'appelles-tu?");
            string UserAnswer = Console.ReadLine();
            Console.WriteLine("Bonjour et bienvenue " + UserAnswer);

            List<string> urtask = new List<string>();

            urtask.Add("presentation");//done
            urtask.Add("1 liste de personne");//DONE
            urtask.Add("boucle while");//done
            urtask.Add("boucle do, while");//done
            urtask.Add("boucle for");//done
            urtask.Add("ajout d'un dictionnaire");//done
            urtask.Add("boucle foreach");//done
            urtask.Add("ajout enumération");//in progress
            urtask.Add("cond. if,else if, else");
            urtask.Add("switch,case,default");
            urtask.Add("faire un cast");
            urtask.Add("faire un tableau de couleur, sentiment, animaux");
            urtask.Add("mini conversation avec l'utilisateur");


            List<string> fratrie = new List<string>();

            fratrie.Add("Danny");
            fratrie.Add("Michael");
            fratrie.Add("Meleena");
            fratrie.Add("Samuel");
            fratrie.Add("Danna");
            Console.WriteLine("FRATRIE LIST COMPLETE");

            int decompteSTART = 10;

            while (decompteSTART > -1)
            {
                Console.WriteLine(decompteSTART);
                decompteSTART--;
            }
            decompteSTART = 0;

            do
            {
                Console.WriteLine(decompteSTART);
                decompteSTART++;

            } while (decompteSTART < 10);

            Console.WriteLine("ajout de la boucle for le 7 avril 2023 13h38");

            for (int ma_var = 4; ma_var > 0; ma_var--)
            {
                Console.WriteLine(ma_var);
            }

            Console.WriteLine("maintenant ajoutons une boucle foreach");

            Dictionary<string, string> dicoanimal = new Dictionary<string, string>
            {
                {"ours", "quadripède"},
                {"chat", "quadripède"},
                {"oiseau", "bipède"},
                {"chien", "quadripède"},
                {"singe", "bipède" }

            };

            // Console.WriteLine(dicoanimal["ours"]);

            foreach (KeyValuePair<string, string> kvp in dicoanimal)
            {
                //Console.WriteLine(kvp);

                Console.WriteLine("key: " + kvp.Key);
                Console.WriteLine("value: " + kvp.Value);
            }

            Dictionary<string, int> dicoName = new Dictionary<string, int>
            {
                {"danny", 28 },
                {"michael", 27 },
                {"meleena", 26},
                {"samuel", 24 },
                {"danna", 19}
            };

            Console.WriteLine("");

            foreach (KeyValuePair<string, int> familyname in dicoName)
            {
                //Console.WriteLine(familyname);
                Console.WriteLine("nom: " + familyname.Key + "  age: " + familyname.Value);
                //Console.WriteLine("age: " + familyname.Value);
                //Console.WriteLine(familyname);

            }





            Console.Read();


        }
    }
}


