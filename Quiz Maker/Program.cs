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
            const string PLAYGAME = "G";
            const string ADDQUESTIONS = "Q";
            const string EXIT = "S";
            Random rndQiuz = new Random();

            List<Question> quizQuestions = new List<Question>();
            quizQuestions.AddRange(Logic.GetDefaultQuestions());
            Ui.UserGretings("Welcome to Capital Qiuz Game!! ");
            string userChoice = Ui.UserGameChoice();
            if (userChoice == PLAYGAME)
            {


                int indexQuestion = rndQiuz.Next(quizQuestions.Count);
                Question question = quizQuestions[indexQuestion];
                Ui.MessageToUser($"frage { + 1}: {question.Text}");
                for (int i = 0; i < question.Answers.Count; i++)
                {
                    Console.WriteLine($"{i}: {question.Answers[i]}");
                }

            }
            if (userChoice == ADDQUESTIONS)
            {

            }
            if (userChoice == EXIT)
            {

            }











        }
    }
}
