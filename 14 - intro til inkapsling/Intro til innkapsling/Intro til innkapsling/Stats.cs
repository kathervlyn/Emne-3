using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_til_innkapsling
{
    internal class Stats
    {
        public int[] Numbers;
        public int NumberCount;


        public Stats()
        {
            Numbers = new int[100];
        }

        public void AddNumber(int number)
        {
            Numbers[NumberCount] = number;
            NumberCount++;
        }

        public void ShowResult()
        {
            var sum = Numbers.Sum();
            Console.WriteLine(
                $"antall tall: {NumberCount} " +
                $"Sum : {sum} " +
                $"Snitt: {(float)sum / NumberCount}");
        }
    }
}