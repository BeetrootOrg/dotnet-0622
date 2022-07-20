using VotingApp.Context;
using VotingApp.Controllers.Interfaces;
using VotingApp.Models;

namespace VotingApp.Controllers
{
    internal class VoteMenuController : BaseShowAllPollsController
    {
        public VoteMenuController(VotingAppContext context) : base(context)
        {
        }

        protected override IController CreateController(Poll poll) => new VoteController(Context, poll);
    }
}
