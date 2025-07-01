using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Quiz_Maker
{
    internal class Ui
    {
        public static void UserGretings(string message)
        {
            Console.WriteLine($"{message}");
        }
        public static void MessageToUser(string messageToUser)
        {
            Console.WriteLine(messageToUser);
        }
        public static string UserGameChoice()
        {
            MessageToUser($"please take your choice betwen play Game({Constants.PLAY_GAME}) or Add Question({Constants.ADD_QUESTIONS})and for Quit({Constants.EXIT})");
            string userGameChoice = Console.ReadLine().ToUpper();
            bool containsNumber = userGameChoice.Any(char.IsDigit);
            bool userInput = false;
            while (!userInput)
            {
                if (string.IsNullOrWhiteSpace(userGameChoice))
                {
                    userInput = false;
                    MessageToUser("Please enter an valid Letter as mentioned above!!");
                    continue;
                }
                else if (containsNumber)
                {
                    userInput = false;
                    MessageToUser("Please enter an valid Letter as mentioned above not numbers!!");
                    continue;
                }
                else
                {
                    userInput = true;   
                }
            }


            return userGameChoice;
        }

        public static string UserQuestions()
        {
            MessageToUser("please enter below your Question!");
            string userInputQuestions = Console.ReadLine();
            return userInputQuestions;
        }
        public static List<string> UserAnswers()
        {
            List<string> userInputAnswers = new List<string>();
            MessageToUser("Please enter below your Answers!");
            string userInput = Console.ReadLine();
            string userInputJoined = string.Join(",", userInput);
            TextInfo answers = CultureInfo.CurrentCulture.TextInfo;
            userInputAnswers.Add ( answers.ToTitleCase(userInputJoined));
            return userInputAnswers;
        }
        public static List<int> UserCorrectAnswer()
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
        public static int UserTotalInputQuestions()
        {
            bool userRightInput = false;
            int userInputNumber = 0;
            while (!userRightInput)
            {
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput,out userInputNumber))
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
        public static int UserInGameCorrectAnswer()
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
        public static void GameAnswers(Question question)
        {
            for (int i = 0; i < question.Answers.Count; i++)
            {
                Console.WriteLine($"{i}: {question.Answers[i]}");
            }
            
        }
    }
}
