using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyt_meg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tall = 1;

            float desimaltall = 1.01F;//Nøyaktig
            double desimaltall2 = 1.01;
            decimal delimalTall = 1.01M;// veldig nøyaktig
            long vetIkkeHvaDetteErForDetBleAldriForklart = 1;

            char boksrav = 'a';         // en bokstav
            string tekst = "hei";     // en Tekst

            bool santUsant = false; //true / false

            int[] tallArray = { 1, 2, 3 };
            string[] tekstAray = { "hei", "på", "Deg" };

            List<int> listeMedTall = new List<int>(); // lager en ny liste med tall

            int NumberFive()
                //kan bytte ut int med string
                //og da bytter man ut 5; med "Tekst her";
                //Private Kan byttes ut med public hvis jeg vil at den skal gå over flere filer.
            {
                return 5;
            }
//-------------------------------------------------------------------- Oppgave ------------------------------------------------------
            SumAvtall(a:5, b:3.0M);
        }
        public static decimal SumAvtall(int a, decimal b)
        {
            decimal sum = a + b;
            return sum;
        }
    }
}
