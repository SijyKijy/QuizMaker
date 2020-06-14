using System;

namespace QuizMaker.Models
{
    [Serializable]
    public class Question
    {
        public string Content { get; }
        public int Index { get; }

        public Question(int index, string content)
        {
            Index = index;
            Content = content;
        }
    }
}
