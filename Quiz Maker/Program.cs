using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Quiz_Maker
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const string PLAYGAME = "G";
            const string ADDQUESTIONS = "Q";
            const string EXIT = "S";
            const int MAXPOINTS = 100;
            const int MAXQUESTIONS = 6;
            Random rndQiuz = new Random();
            var path = @"C:\Users\blakk\Desktop\Try\QuestionList.txt";
           
            List<Question> quizQuestions = new List<Question>();
            quizQuestions.AddRange(Logic.GetDefaultQuestions());
           


            Ui.UserGretings("Welcome to Capital Qiuz Game!! ");
            
            bool gameRunning = true;
            while (gameRunning)
            {
                string userChoice = Ui.UserGameChoice();
                if (userChoice == PLAYGAME)
                {
                    int points = 0;
                    int score = 0;
                    List<Question> questionsForGame = new List<Question>(quizQuestions);
                    while (questionsForGame.Count >0)
                    {
                        
                        int indexQuestion = rndQiuz.Next(questionsForGame.Count);
                        Question question = questionsForGame[indexQuestion];
                        Console.Clear();
                        Ui.MessageToUser($"Question {+1}: {question.Text}");
                        for (int i = 0; i < question.Answers.Count; i++)
                        {
                            Console.WriteLine($"{i}: {question.Answers[i]}");
                        }
                        Ui.MessageToUser("your Answer below (in numbers):");
                        int inputAnswer = Ui.UserInGameCorrectAnswer();
                        if (question.CorrectAnswersIndizes.Contains(inputAnswer))
                        {
                            Ui.MessageToUser("Right Answer ");
                        }
                        else
                        {
                            Ui.MessageToUser("Wrong Answer");
                            points += 10;
                        }
                        score = MAXPOINTS - points;
                        questionsForGame.RemoveAt(indexQuestion);
                        Ui.MessageToUser("For next Question just tap one key on keyboard");
                        Console.WriteLine($"remeining questions {questionsForGame.Count}");
                        Console.ReadKey();
                    }
                    Ui.MessageToUser($"Game Over! Your Score {score}  from {quizQuestions.Count} Total earned points!");
                   


                }
                if (userChoice == ADDQUESTIONS)
                {
                    Ui.MessageToUser("input below how many questions you want to add for Game(Max 6 Questions");
                    int userTotalChoiceInputs = Ui.UserTotalInputQuestions();
                    int inputs = userTotalChoiceInputs;
                    List<Question> newQuestions = new List<Question>();

                    while (inputs >= 1)
                    {
                        
                        if (inputs == MAXQUESTIONS)
                        {
                            break;
                        }
                        string questionsText = Ui.UserQuestions();
                        List<string> answers = Ui.UserAnswers();
                        List<int> correctAnswer = Ui.UserCorrectAnswer();
                        inputs -= 1;
                       
                        newQuestions.AddRange(Logic.GetUserQuestions(questionsText, answers, correctAnswer));
                       

                    }
                    List<Question> existingUserQuestions = QuestionSerializer.Load(path);
                    existingUserQuestions.AddRange(newQuestions);
                    QuestionSerializer.Save(existingUserQuestions,path);
                    Ui.MessageToUser("Your Questions are succesfuly implemented!");
                    Ui.UserGameChoice();

                }
                if (userChoice == EXIT)
                {
                    Ui.MessageToUser("Bye see ya next time!");
                    gameRunning = false;
                   
                }


            }












        }
    }
}
