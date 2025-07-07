using System;
using System.Collections.Generic;

namespace Quiz_Maker
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<QuizCard> existingUserQuestions = Logic.LoadUserQuestions();
            Random rndQiuz = new Random();
            List<QuizCard> newQuestions = new List<QuizCard>();
            List<QuizCard> quizQuestions = new List<QuizCard>();
            quizQuestions.AddRange(Logic.GetDefaultQuestions());
            quizQuestions.AddRange(newQuestions);
            Ui.DisplayUserGretings("Welcome to Capital Qiuz Game!! ");
            bool gameRunning = true;
            while (gameRunning)
            {
                string userChoice = Ui.GetUserGameChoice();
                if (userChoice == Constants.PLAY_GAME)
                {
                    int points = 0;
                    int score = 0;
                    List<QuizCard> questionsForGame = new List<QuizCard>(quizQuestions);
                    while (questionsForGame.Count > 0)
                    {
                        int indexQuestion = rndQiuz.Next(questionsForGame.Count);
                        QuizCard question = questionsForGame[indexQuestion];
                        Ui.ClearDisplay();
                        Ui.MessageToUser($"Question {+1}: {question.Text}");
                        Ui.DisplayGameAnswers(question);
                        Ui.MessageToUser("your Answer below (in numbers):");
                        int inputAnswer = Ui.GetUserInGameCorrectAnswer();
                        points = Logic.GetAnswerValidation(question, inputAnswer, points,Constants.REWARD_POINTS);
                        Ui.DisplayCorrectAnswerValidation(question, inputAnswer);
                        questionsForGame.RemoveAt(indexQuestion);
                        score = Constants.MAX_POINTS - points;
                        Console.WriteLine(points);
                        Ui.MessageToUser("For next Question just tap one key on keyboard");
                        Ui.GetUserPressedKey();
                        continue;
                    }
                    Ui.MessageToUser($"Game Over! Your Score {score}  from {quizQuestions.Count} Total earned points!");

                }
                if (userChoice == Constants.ADD_QUESTIONS)
                {
                    Ui.MessageToUser("input below how many questions you want to add for Game(Max 6 Questions");
                    int userTotalChoiceInputs = Ui.GetUserTotalInputQuestions();
                    int inputs = userTotalChoiceInputs;

                    while (inputs >= 1)
                    {
                        if (inputs == Constants.MAX_QUESTIONS)
                        {
                            break;
                        }
                        string questionsText = Ui.GetUserQuestions();
                        List<string> answers = Ui.GetUserAnswers();
                        List<int> correctAnswer = Ui.GetUserCorrectAnswer();
                        inputs -= 1;
                        newQuestions.AddRange(Logic.GetUserQuestions(questionsText, answers, correctAnswer));
                    }

                    existingUserQuestions.AddRange(newQuestions);
                    Logic.SaveUserInputQuestions(existingUserQuestions);
                    Ui.MessageToUser("Your Questions are succesfuly implemented!");
                    continue;

                }
                if (userChoice == Constants.EXIT)
                {
                    Ui.MessageToUser("Bye see ya next time!");
                    gameRunning = false;

                }

            }

        }
    }
}
