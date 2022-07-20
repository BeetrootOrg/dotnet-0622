using System;
using VotingApp.Builder;
using VotingApp.Context;
using VotingApp.Controllers.Interfaces;

namespace VotingApp.Controllers
{
    internal class AskPollQuestionController : IController
    {
        private readonly VotingAppContext _context;
        private readonly PollBuilder _pollBuilder;

        public AskPollQuestionController(VotingAppContext context, PollBuilder pollBuilder)
        {
            _context = context;
            _pollBuilder = pollBuilder;
        }

        public IController Action()
        {
            _pollBuilder.SetQuestion(Console.ReadLine());
            return new AskPollAnswersController(_context, _pollBuilder);
        }

        public void Render()
        {
            Console.WriteLine("Enter the question:");
        }
    }
}
