using System;
using System.Collections.Generic;

namespace QuizMaker.Models
{
    [Serializable]
    public class Quiz
    {
        public string Title { get; }
        public List<Question> Questions { get; }
        public int RightQuestion { get; }

        public Quiz(string title, List<Question> questions, int rightQuestion)
        {
            Title = title;
            Questions = questions;
            RightQuestion = rightQuestion;
        }
    }
}
