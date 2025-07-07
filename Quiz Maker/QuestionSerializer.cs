using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Quiz_Maker
{
    public class QuestionSerializer
    {

        public static void Save(List<QuizCard> questions, string path)
        {
            var serializer = new XmlSerializer(typeof(List<QuizCard>));
            using (var file = File.Create(path))
            {
                serializer.Serialize(file, questions);
            }
        }
        public static List<QuizCard> Load(string path)
        {
            if (!File.Exists(path))
            {
                return new List<QuizCard> { new QuizCard() };
            }
            var serializer = new XmlSerializer(typeof(List<QuizCard>));
            using (var file = File.OpenRead(path))
            {
                return serializer.Deserialize(file) as List<QuizCard>;
            }
        }
    }
}
