using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab1.Models
{
    public class QuizModel
    {
        public int answer { get; set; } = -1;
        public int rightAnswersCount { get; set; } = 0;
        public int answersCount { get; set; } = 0;
        public List<string> listResult { get; set; } = new List<string>();

        public QuizModel(string result, int rightAnsw, int countAnsw)
        {

        }

        public QuizModel()
        {

        }
    }
}
