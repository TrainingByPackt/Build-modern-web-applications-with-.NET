using System.Collections.Generic;

namespace OnlineQuiz.Models
{
    public class Quiz
    {
        public IEnumerable<Player> Players { get; set; }
        public IEnumerable<Question> Questions { get; set; }
    }
}