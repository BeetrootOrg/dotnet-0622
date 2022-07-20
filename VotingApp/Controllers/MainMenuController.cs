using System;
using VotingApp.Builder;
using VotingApp.Context;
using VotingApp.Controllers.Interfaces;

namespace VotingApp.Controllers
{
    internal class MainMenuController : IController
    {
        private readonly VotingAppContext _context;

        public MainMenuController(VotingAppContext context)
        {
            _context = context;
        }

        public IController Action()
        {
            var key = Console.ReadKey();
            Console.Clear();

            return key.Key switch
            {
                ConsoleKey.D1 => new AskPollQuestionController(_context, new PollBuilder()),
                ConsoleKey.D2 => new ShowAllPollsController(_context),
                ConsoleKey.D3 => new VoteMenuController(_context),
                ConsoleKey.D0 => new ExitController(),
                _ => this
            };
        }

        public void Render()
        {
            Console.Clear();
            Console.WriteLine("1. Create poll");
            Console.WriteLine("2. Show poll results");
            Console.WriteLine("3. Vote for something");
            Console.WriteLine("0. Exit");
        }
    }
}
