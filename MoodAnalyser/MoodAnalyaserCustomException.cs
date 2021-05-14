using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
 public class MoodAnalyaserCustomException : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE,
                NO_SUCH_FIELD
        }
        private readonly ExceptionType type;
        public MoodAnalyaserCustomException(ExceptionType Type, string message) : base(message)
        {
            this.type = Type;
        }
    }
}
