using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnaalyzerProblem
{
     public class MoodAnalyzer
    {
        string message;
        public MoodAnalyzer()
    }
    {

public MoodAnalyzer(string message)
    {
        this.message = message;
    }
  //Analyser method to find mood
  public string Analyzer(string message)
    {
        try
        {
            if (message.Equals(string.Empty))
            {
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.EMPTY_EXCEPTION, "Mood should not be EMPTY");)
            }
            if (this.message.Contains("sad"))
            {
                return "SAD";
            }
            else
            {
                return "Happy";
            }
             catch (NullReferenceException)
        {
            throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NULL_EXCEPTION, "Mood should not be NULL");
        }
    }
    }
}
}
