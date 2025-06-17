using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Maker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ui.UserGretings("Welcome to Capital Qiuz Game!! ");
            Ui.UserGameChoice();
            string userQuestionsInput = Ui.UserQuestions();
            List<string> userAnswersInput = new List<string> { (Ui.UserAnswers()) };
            List<int> userCorrectAnswerInput = new List<int> { (Ui.UserCorrectAnswer()) };
            List<Question> qiuzQuestions = Logic.GetDefaultQuestions(userQuestionsInput, userAnswersInput, userCorrectAnswerInput);
            Console.Clear();
            Console.WriteLine(qiuzQuestions[4].Text);
            for (int i = 0; i < qiuzQuestions[4].Answers.Count; i++)
            {
                Console.WriteLine(qiuzQuestions[4].Answers[i]);
            }

        }
    }
}
