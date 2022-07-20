using System;
using VotingApp.Context;
using VotingApp.Controllers.Interfaces;
using VotingApp.Models;

namespace VotingApp.Controllers
{
    internal class VoteController : IController
    {
        private readonly VotingAppContext _context;
        private readonly Poll _poll;

        public VoteController(VotingAppContext context, Poll poll)
        {
            _context = context;
            _poll = poll;
        }

        public IController Action()
        {
            var line = Console.ReadLine();

            if (int.TryParse(line, out var index) && index > 0 && index <= _poll.Options.Length)
            {
                _poll.Answers.Add(new Answer(_poll.Options[index - 1]));
                return new MainMenuController(_context);
            }

            return this;
        }

        public void Render()
        {
            Console.Clear();
            var options = _poll.Options;

            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {options[i].Text}");
            }

            Console.WriteLine("Choose item and click Enter");
        }
    }
}
