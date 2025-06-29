using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Maker
{
    internal class Logic
    {
        public static List<Question> GetDefaultQuestions()
        {
            List<Question> defaultQuestions = new List<Question>();
            Question question1 = new Question();
            question1.Text = "What is the Capital of Austria?";
            question1.Answers = new List<string> { "Wiena", "berlin", "Paris", "Madrid" };
            question1.CorrectAnswersIndizes = new List<int> { 0 };
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
            
            return defaultQuestions;
        }
        public static List<Question> GetUserQuestions(string questions, List<string> answers, List<int> correctAnswerIndizes)
        {
            List<Question> userQuestion = new List<Question>();
            Question userQuestion1 = new Question
            {
                Text = questions,
                Answers = answers,
                CorrectAnswersIndizes = correctAnswerIndizes
            };
            userQuestion.Add(userQuestion1);
            return userQuestion;
        }
        public static int AnswerValidation(Question question,int answer,int points)
        {
            
            if (question.CorrectAnswersIndizes.Contains(answer))
            {
                Ui.MessageToUser("Right Answer ");
            }
            else
            {
                Ui.MessageToUser("Wrong Answer");
                points += 10;
            }
            return points;
        }
    }

}
