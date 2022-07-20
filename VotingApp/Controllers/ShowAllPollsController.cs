using VotingApp.Context;
using VotingApp.Controllers.Interfaces;
using VotingApp.Models;

namespace VotingApp.Controllers
{
    internal class ShowAllPollsController : BaseShowAllPollsController
    {
        public ShowAllPollsController(VotingAppContext context) : base(context)
        {
        }

        protected override IController CreateController(Poll poll) => new ShowPollController(Context, poll);
    }
}
