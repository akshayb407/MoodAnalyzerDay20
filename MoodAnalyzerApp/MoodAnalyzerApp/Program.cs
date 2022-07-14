using System;
using System.IO;

namespace MoodAnalyzerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Mood Analyzer");
            MoodAnalyse moodanalse = new MoodAnalyse("message");
            moodanalse.AnalyseMood();
            Console.WriteLine(moodanalse.AnalyseMood());
             MoodAnalyse.ReferenceEquals(moodanalse, moodanalse);   

        }
    }
}
