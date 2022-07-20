using System;
using VotingApp.Context;
using VotingApp.Controllers.Interfaces;
using VotingApp.Models;

namespace VotingApp.Controllers
{
    internal abstract class BaseShowAllPollsController : IController
    {
        protected readonly VotingAppContext Context;
        private readonly Poll[] _polls;

        public BaseShowAllPollsController(VotingAppContext context)
        {
            Context = context;
            _polls = Context.Polls;
        }

        public IController Action()
        {
            var line = Console.ReadLine();

            if (int.TryParse(line, out var index))
            {
                if (index == 0)
                {
                    return new MainMenuController(Context);
                }

                if (index > 0 && index <= _polls.Length)
                {
                    return CreateController(_polls[index - 1]);
                }
            }

            return this;
        }

        public void Render()
        {
            Console.Clear();

            for (var i = 0; i < _polls.Length; ++i)
            {
                Console.WriteLine($"{i + 1}. {_polls[i].Name}");
            }

            Console.WriteLine("0. Back to menu");
            Console.WriteLine("Choose item and click Enter");
        }

        protected abstract IController CreateController(Poll poll);
    }
}
