using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Vote
{
    internal class VoteList
    {
        List<Vote> votes { get; set; }
        public VoteList()
        {
            votes = new List<Vote>();
        }

        public VoteList(Vote vote) : this()
        {
            votes.Add(vote);
        }

        public bool ToVote(string voteTopic, string answer)
        {
            Vote vote = FindVote(voteTopic);
            if (vote == null)
            {
                string message = "Didn`t find such vote topic";
                message.PressAnyKeyToProcced();
                return false;
            }


            if (!vote.WriteAnswer(answer)) 
            {
                return false;
            }
            return true;
        }
        public Vote FindVote(Vote vote)
        {
            Vote findedVote;

            foreach (Vote v in votes)
            {
                if (vote.VoteTopic == v.VoteTopic)
                {
                    findedVote = v;
                    return findedVote;
                }
            }
            return null;
        }

        public Vote FindVote(string voteName)
        {
            Vote toFind = new Vote(voteName);
            Vote findedVote = FindVote(toFind);

            return findedVote == null ? null : findedVote;
        }

        public bool CreateVoteTopic(string voteTopic)
        {
            if(FindVote(voteTopic) != null)
            {
                string message = "The topic is already exist";
                message.PressAnyKeyToProcced();
                return false;
            }
            Vote topic = new Vote(voteTopic);
            votes.Add(topic);
            return true;
        }

        public void Show(string voteTopic)
        {
           Vote show =  FindVote(voteTopic);
            Console.WriteLine($"YES Votes: {show.GetYesVotes}");
            Console.WriteLine($"NO Votes: {show.GetNoVotes}");
        }

    }
}
