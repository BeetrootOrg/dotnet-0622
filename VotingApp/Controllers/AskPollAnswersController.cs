using System;
using VotingApp.Builder;
using VotingApp.Context;
using VotingApp.Controllers.Interfaces;

namespace VotingApp.Controllers
{
    internal class AskPollAnswersController : IController
    {
        private readonly VotingAppContext _context;
        private readonly PollBuilder _pollBuilder;

        public AskPollAnswersController(VotingAppContext context, PollBuilder pollBuilder)
        {
            _context = context;
            _pollBuilder = pollBuilder;
        }

        public IController Action()
        {
            _pollBuilder.SetOptions(Console.ReadLine());
            return new CreatePollController(_context, _pollBuilder);
        }

        public void Render()
        {
            Console.WriteLine("Enter the comma-separated answers:");
        }
    }
}
