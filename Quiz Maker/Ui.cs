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
            MessageToUser("please take your choice betwen play Game(G) or Add Question(Q)and for Quit(S)");
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
        public static string UserAnswers()
        {
            MessageToUser("Please enter below your Answers!");
            string userInput = Console.ReadLine();
            string userInputJoined = string.Join(",", userInput);
            TextInfo answers = CultureInfo.CurrentCulture.TextInfo;
            string userInputAnswers = answers.ToTitleCase(userInputJoined);
            return userInputAnswers;
        }
        public static int UserCorrectAnswer()
        {
            
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
            return userIndexNumber;
        }
    }
}
