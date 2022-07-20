using System.Collections.Generic;
using System.Linq;
using VotingApp.Models;

namespace VotingApp.Context
{
    internal class VotingAppContext
    {
        private readonly IList<Poll> _polls = new List<Poll>();
        public Poll[] Polls => _polls.ToArray();
        public void AddPoll(Poll poll) => _polls.Add(poll);
    }
}
