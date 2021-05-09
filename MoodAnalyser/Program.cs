using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
 public class Program
    {
        static void Main(string[] args)
        {
        }
        public int addNumber(int numOne,int numTwo)
        {
            return numOne + numTwo;

        }
        public string Analyse_Mood(string message)
        {
            if (message.ToLower().Contains("sad"))
                 return "SAD";
            else
            {
                 return "HAPPY";
            }
        }
    }
}
