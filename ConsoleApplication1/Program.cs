using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            /////////Première soluce//////////////

            //int[] MesNombres = new int[4];

            //MesNombres[0] = 5;
            //MesNombres[1] = 9;
            //MesNombres[2] = 4;
            //MesNombres[3] = 3;

            ////////Deuxième soluce/////////////

            int[] MesNombres = {5,9,4,3};

            /////////////////////////////////

            for (int i = 0; i < MesNombres.Length; i++)
            {
                Console.WriteLine(i + " - " + MesNombres[i]);

            }

           

            string[] MesMots = { "Mon Cul", "Ma Bite" };



            for (int j = 0; j < MesMots.Length; j++)
            {
                Console.WriteLine(j + " - " + MesMots[j]);

            }

            string[] MesBurnes = new string[4];

            MesBurnes[0] = "poils";
            MesBurnes[1] = "peau";
            MesBurnes[2] = "couleur";
            MesBurnes[3] = "morpions";

            for (int k = 0; k < MesBurnes.Length; k++)
            {
                Console.WriteLine(k + " - " + MesBurnes[k]);

            }


            ////////////foreach///////////

            foreach (string Burnes in MesBurnes)
            {
                Console.WriteLine("Voilà : {0}", Burnes);
            }

            foreach (int Nombre in MesNombres)
            {
                Console.WriteLine("Et les nombres : " + Nombre);
                Console.WriteLine("Et encore : {0}", Nombre);
            }

            ////////////////inversion tableau//////////////

            string Phrase = "Ma bite est un volcan";
            Console.WriteLine(Phrase);

            char[] TableauDeChar = Phrase.ToCharArray();//copie les char dans un tableau

            /////////

            foreach (char Tab in TableauDeChar)
            {
                Console.WriteLine(Tab);
            }

            /////////

            Array.Reverse(TableauDeChar);



            Console.WriteLine(TableauDeChar);

            foreach (char Tak in TableauDeChar)
            {
                Console.WriteLine(Tak);

               

            }


            //////////////////////////////

            Console.ReadLine();//blocage de l'affichage


          



    }
    }
}
