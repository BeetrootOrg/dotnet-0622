using System.Collections.Generic;

namespace VotingApp.Models
{
    internal record Poll(Question Question, Option[] Options, IList<Answer> Answers)
    {
        public string Name => Question.Text;
    }
}
