using System.Collections.Generic;
namespace Quiz_Maker
{
    internal class Logic
    {
        public static List<QuizCard> GetDefaultQuestions()
        {
            List<QuizCard> defaultQuestions = new List<QuizCard>();
            QuizCard question1 = new QuizCard();
            question1.Text = "What is the Capital of Austria?";
            question1.Answers = new List<string> { "Wiena", "berlin", "Paris", "Madrid" };
            question1.CorrectAnswersIndizes = new List<int> { 0 };
            defaultQuestions.Add(question1);
            // second object
            QuizCard question2 = new QuizCard();
            question2.Text = "What is the Capital of Germany?";
            question2.Answers = new List<string> { "Wiena", "berlin", "Paris", "Madrid" };
            question2.CorrectAnswersIndizes = new List<int> { 1 };
            defaultQuestions.Add(question2);
            // third object
            QuizCard question3 = new QuizCard();
            question3.Text = "What is the Capital of France?";
            question3.Answers = new List<string> { "Wiena", "berlin", "Paris", "Madrid" };
            question3.CorrectAnswersIndizes = new List<int> { 2 };
            defaultQuestions.Add(question3);
            // fourth object
            QuizCard question4 = new QuizCard();
            question4.Text = "What is the Capital of Spain?";
            question4.Answers = new List<string> { "Wiena", "berlin", "Paris", "Madrid" };
            question4.CorrectAnswersIndizes = new List<int> { 3 };
            defaultQuestions.Add(question4);

            return defaultQuestions;
        }
        public static List<QuizCard> GetUserQuestions(string questions, List<string> answers, List<int> correctAnswerIndizes)
        {
            List<QuizCard> userQuestion = new List<QuizCard>();
            QuizCard userQuestion1 = new QuizCard
            {
                Text = questions,
                Answers = answers,
                CorrectAnswersIndizes = correctAnswerIndizes
            };
            userQuestion.Add(userQuestion1);
            return userQuestion;
        }
        public static int GetAnswerValidation(QuizCard question, int answer, int points, int rewardPoints)
        {

            if (question.CorrectAnswersIndizes.Contains(answer))
            {

            }
            else
            {
                points += rewardPoints;
            }

            return points;
        }
        public static List<QuizCard> LoadUserQuestions()
        {
            return QuestionSerializer.Load(Constants.PATH) ?? new List<QuizCard>();
        }
        public static void SaveUserInputQuestions(List<QuizCard> questions)
        {
            QuestionSerializer.Save(questions, Constants.PATH);
        }
    }

}
