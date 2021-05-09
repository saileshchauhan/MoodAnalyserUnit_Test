using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
 public class Program
    {
        private string message;
        public Program(string message)
        {
            this.message = message;
        }
        static void Main(string[] args)
        {
        }
        public string Analyse_Mood()
        {
            if (this.message.ToLower().Contains("sad"))
                return "SAD";
            else
            {
                return "HAPPY";
            }
        }
    }
}
