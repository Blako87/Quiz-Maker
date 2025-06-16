using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Maker
{
    internal class Logic
    {
        public static List<Question> GetDefaultQuestions(string userQuestions,List<string>userAnswers,List<int>userCorrectAnswer)
        {
            List<Question> defaultQuestions = new List<Question>();
            Question question1 = new Question();
            question1.Text = "What is the Capital of Austria?";
            question1.Answers = new List<string> { "Wiena", "berlin", "Paris", "Madrid" };
            question1.CorrectAnswersIndizes = new List<int> {0 };
            defaultQuestions.Add(question1);
            // second object
            Question question2 = new Question();
            question2.Text = "What is the Capital of Germany?";
            question2.Answers = new List<string> { "Wiena", "berlin", "Paris", "Madrid" };
            question2.CorrectAnswersIndizes = new List<int> { 1 };
            defaultQuestions.Add(question2);
            // third object
            Question question3 = new Question();
            question3.Text = "What is the Capital of France?";
            question3.Answers = new List<string> { "Wiena", "berlin", "Paris", "Madrid" };
            question3.CorrectAnswersIndizes = new List<int> { 2 };
            defaultQuestions.Add(question3);
            // fourth object
            Question question4 = new Question();
            question4.Text = "What is the Capital of Spain?";
            question4.Answers = new List<string> { "Wiena", "berlin", "Paris", "Madrid" };
            question4.CorrectAnswersIndizes = new List<int> { 3 };
            defaultQuestions.Add(question4);
            //five-th Object user input
            Question userInputStuff = new Question();
            userInputStuff.Text = userQuestions;
            userInputStuff.Answers = userAnswers;
            userInputStuff.CorrectAnswersIndizes = userCorrectAnswer;
            defaultQuestions.Add(userInputStuff);
            return defaultQuestions;
        }
        public static List<Question> GetUserQuestions(string questions,string answers,int correctAnswerIndizes)
        {
            List<Question> userQuestion = new List<Question>();
            Question userQuestion1 = new Question
            {
                Text = questions,
                Answers = new List<string> {(answers) },
                CorrectAnswersIndizes = new List<int>{(correctAnswerIndizes)}
            };
            userQuestion.Add(userQuestion1);
            return userQuestion;
        }
    }
    public class Question
    {
        public string Text { get; set; }
        public List<string> Answers { get; set; }
        public List<int> CorrectAnswersIndizes { get; set; }
        public override string ToString()
        {
            string answersJoined = string.Join(" ", Answers);
            string correctIndicesJoined = string.Join(" ",CorrectAnswersIndizes);
            return $"Questions:{Text}\n,Answers:{answersJoined}\n,Correct indices:{correctIndicesJoined}";
            
        }
        
    }
}
