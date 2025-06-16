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
            List<Question> qiuzQuestions = Logic.GetDefaultQuestions();

            Console.WriteLine(qiuzQuestions[0].Text);
            for (int i =0; i< qiuzQuestions[0].Answers.Count; i++)
            {
                Console.WriteLine(qiuzQuestions[0].Answers[i]);
            }

        }
    }
}
