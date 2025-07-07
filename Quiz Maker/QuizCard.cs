using System.Collections.Generic;
namespace Quiz_Maker
{
    public class QuizCard
    {
        public string Text { get; set; }
        public List<string> Answers { get; set; }
        public List<int> CorrectAnswersIndizes { get; set; }
        public override string ToString()
        {
            string answersJoined = string.Join(" ", Answers);
            string correctIndicesJoined = string.Join(" ", CorrectAnswersIndizes);
            return $"Questions:{Text}\n,Answers:{answersJoined}\n,Correct indices:{correctIndicesJoined}";

        }
    }
            
}
