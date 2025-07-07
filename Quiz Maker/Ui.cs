using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace Quiz_Maker
{
    internal class Ui
    {
        public static void DisplayUserGretings(string message)
        {
            Console.WriteLine($"{message}");
        }
        public static void MessageToUser(string messageToUser)
        {
            Console.WriteLine(messageToUser);
        }
        public static string GetUserGameChoice()
        {
            MessageToUser($"please take your choice betwen play Game({Constants.PLAY_GAME}) or Add Question({Constants.ADD_QUESTIONS})and for Quit({Constants.EXIT})");

            while (true)
            {
                string userGameChoice = Console.ReadLine().ToUpper();
                bool containsNumber = userGameChoice.Any(char.IsDigit);
                if (string.IsNullOrWhiteSpace(userGameChoice))
                {

                    MessageToUser("Please enter an valid Letter as mentioned above!!");
                    continue;
                }
                else if (containsNumber)
                {

                    MessageToUser("Please enter an valid Letter as mentioned above not numbers!!");
                    continue;
                }
                else
                {
                    return userGameChoice;
                }
            }

        }

        public static string GetUserQuestions()
        {
            MessageToUser("please enter below your Question!");
            string userInputQuestions = Console.ReadLine();
            return userInputQuestions;
        }
        public static List<string> GetUserAnswers()
        {
            List<string> userInputAnswers = new List<string>();
            MessageToUser("Please enter below your Answers!");
            string userInput = Console.ReadLine();
            string userInputJoined = string.Join(",", userInput);
            TextInfo answers = CultureInfo.CurrentCulture.TextInfo;
            userInputAnswers.Add(answers.ToTitleCase(userInputJoined));
            return userInputAnswers;
        }
        public static List<int> GetUserCorrectAnswer()
        {
            List<int> userCorrectAnswer = new List<int>();
            bool userAnswer = false;
            int userIndexNumber = 0;
            while (!userAnswer)
            {
                MessageToUser("please enter below the correct Answers but as number starting counting from (Zero = 0,1,2,3,4)!!");
                string userInputIndexAnswer = Console.ReadLine();
                if (int.TryParse(userInputIndexAnswer, out userIndexNumber))
                {
                    userAnswer = true;
                }
                else
                {
                    MessageToUser(" Invalid Input!, Please try to input an Number!");
                    continue;
                }
            }
            userCorrectAnswer.Add(userIndexNumber);
            return userCorrectAnswer;
        }
        public static int GetUserTotalInputQuestions()
        {
            bool userRightInput = false;
            int userInputNumber = 0;
            while (!userRightInput)
            {
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out userInputNumber))
                {
                    userRightInput = true;
                }
                else
                {
                    MessageToUser("Invalid input!! put one number inside!");
                }
            }
            return userInputNumber;

        }
        public static int GetUserInGameCorrectAnswer()
        {
            bool userRightInput = false;
            int userInputNumber = 0;
            while (!userRightInput)
            {
                MessageToUser("please enter below the correct Answers but as number starting counting from (Zero = 0,1,2,3)!!");
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out userInputNumber))
                {
                    userRightInput = true;
                }
                else
                {
                    MessageToUser("Invalid input!! put one number inside!");
                }
            }
            return userInputNumber;
        }
        public static void DisplayGameAnswers(QuizCard question)
        {
            for (int i = 0; i < question.Answers.Count; i++)
            {
                Console.WriteLine($"{i}: {question.Answers[i]}");
            }

        }
        public static void ClearDisplay()
        {
            Console.Clear();
        }
        public static void GetUserPressedKey()
        {
            Console.ReadKey();
        }
        public static void DisplayCorrectAnswerValidation(QuizCard question, int answer)
        {
            if (question.CorrectAnswersIndizes.Contains(answer))
            {
                MessageToUser("Right Answer Gratulation!!");
            }
            else
            {
                MessageToUser("Wrong Answer!take your time!");
            }
        }
    }
}
