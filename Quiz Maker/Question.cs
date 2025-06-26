using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Quiz_Maker
{
    public class Question
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
    public static class QuestionSerializer
    {
        public static void Save(List<Question> questions, string path)
        {
            var serializer = new XmlSerializer(typeof(List<Question>));
            var file = File.Create(path);
            serializer.Serialize(file, questions);
        }
        public static List<Question> Load(string path)
        {
            if (!File.Exists(path))
            {
                return new List<Question> { new Question() };
            }
            var serializer = new XmlSerializer(typeof(List<Question>));
            var file = File.OpenRead(path);
            return serializer.Deserialize(file) as List<Question>;
        }
    }
}
