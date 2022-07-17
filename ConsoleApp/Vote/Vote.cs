using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Vote
{
    internal class Vote
    {
        public string VoteTopic { get; set; }
        public VoteList VoteList { get; set; }

        int _yesCounts;
        int _noCounts;
        public Vote()
        {
            VoteList = new VoteList();
        }

        public Vote(string voteTopic) : this()
        {
            VoteTopic = voteTopic;
        }
        public Vote(Vote v) : this()
        {
            VoteTopic = v.VoteTopic;
            VoteList = v.VoteList;
        }

        public bool WriteAnswer(string answer)
        {
            bool check = answer.ToBoolCheck();

            if (check)
            {
                if (answer.ToBool())
                {
                    _yesCounts++;
                    return true;
                }
                _noCounts++;
                return true;
            }
            return false;
        }

        public int GetYesVotes
        {
            get
            {
                return _yesCounts;
            }
        }
        public int GetNoVotes
        {
            get
            {
                return _noCounts;
            }
        }

        public int GetAllVotes
        {
            get
            {
                return GetYesVotes + GetNoVotes;
            }
        }
    }
}
