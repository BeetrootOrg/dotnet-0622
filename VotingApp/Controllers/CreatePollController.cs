using VotingApp.Builder;
using VotingApp.Context;
using VotingApp.Controllers.Interfaces;

namespace VotingApp.Controllers
{
    internal class CreatePollController : IController
    {
        private readonly VotingAppContext _context;
        private readonly PollBuilder _pollBuilder;

        public CreatePollController(VotingAppContext context, PollBuilder pollBuilder)
        {
            _context = context;
            _pollBuilder = pollBuilder;
        }

        public IController Action()
        {
            _context.AddPoll(_pollBuilder.CreatePoll());
            return new MainMenuController(_context);
        }

        public void Render()
        {
        }
    }
}
