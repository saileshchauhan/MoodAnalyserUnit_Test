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
            try
            {
                if (message.Equals(string.Empty))
                {
                    throw new MoodAnalyaserCustomException(MoodAnalyaserCustomException.ExceptionType.EMPTY_MESSAGE,"Mood Should not be empty");
                }
                if (this.message.Contains("sad"))
                    return "SAD";
                else
                {
                    return "HAPPY";
                }
            }
            catch(NullReferenceException)
            {
                throw new MoodAnalyaserCustomException(MoodAnalyaserCustomException.ExceptionType.NULL_MESSAGE, "Mood Should not be empty");
            }
        }
    }
}
