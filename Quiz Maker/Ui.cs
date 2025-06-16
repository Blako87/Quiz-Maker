using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Maker
{
    internal class Ui
    {
        public void UserGretings(string message)
        {
            Console.WriteLine($"{message}");
        }

        public static string UserQuestions()
        {
            return Console.ReadLine();
        }
        public static string UserAnswers()
        {
            return Console.ReadLine();
        }
        public static int UserCorrectAnswer()
        {
            return Console.Read();
        }
    }
}
