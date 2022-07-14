using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerApp
{
    public class MoodAnalyze
    {
        public MoodAnalyze() { }

        private string message;
        /// <summary>
        /// Parameterised Constructor.
        /// </summary>
        /// <param name="message"></param>
        public MoodAnalyze(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.Empty_Message, "Mood should not be Empty");
                }


                if (this.message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }
        }
    }
}
