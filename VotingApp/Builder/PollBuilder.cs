using System.Collections.Generic;
using System.Linq;
using VotingApp.Models;

namespace VotingApp.Builder
{
    internal class PollBuilder
    {
        private string _question;
        private string _options;

        public PollBuilder SetQuestion(string question)
        {
            _question = question;
            return this;
        }

        public PollBuilder SetOptions(string options)
        {
            _options = options;
            return this;
        }

        public Poll CreatePoll() => new(new Question(_question), 
            new HashSet<Option>(CreateOptions()).ToArray(), // only unique items
            new List<Answer>());

        private IEnumerable<Option> CreateOptions()
        {
            foreach (var item in _options.Split(','))
            {
                yield return new Option(item);
            }
        }
    }
}
