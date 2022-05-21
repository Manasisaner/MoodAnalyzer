using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodanalyserDemo
{
    public class MoodAnalyser
    {
        private string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        //Analyser Method to find  mood
        //public string Analyser() //check msg passing into the constructor is contain(sad) then written sad else sad
        //{
        //    if (this.message.Contains("sad"))
        //    {
        //        return "sad";
        //    }
        //    else
        //    {
        //        return "no sad";
        //    }
        //}
        //Analyser method to find mood
        public string Analyser() //check msg passing into the constructor is contain(sad) then written sad else sad
        {
            if (this.message.ToLower().Contains("sad"))
            {
                return "sad";
            }
            else
            {
                return "happy";
            }
        }
    }
}
