using System;
using System.Collections.Generic;
using VotingApp.Context;
using VotingApp.Controllers.Interfaces;
using VotingApp.Models;

namespace VotingApp.Controllers
{
    internal class ShowPollController : IController
    {
        private readonly VotingAppContext _context;
        private readonly Poll _poll;

        public ShowPollController(VotingAppContext context, Poll poll)
        {
            _context = context;
            _poll = poll;
        }

        public IController Action()
        {
            Console.ReadLine();
            return new MainMenuController(_context);
        }

        public void Render()
        {
            Console.Clear();

            Console.WriteLine($"Question: {_poll.Question.Text}");
            foreach (var (option, result) in CountResults())
            {
                Console.WriteLine($"{option.Text}: {result}");
            }

            Console.WriteLine("Press press Enter to get back to menu");
        }

        public IDictionary<Option, int> CountResults()
        {
            var dictionary = new Dictionary<Option, int>();

            foreach (var option in _poll.Options)
            {
                dictionary[option] = 0;
            }

            foreach (var answer in _poll.Answers)
            {
                ++dictionary[answer.Option];
            }

            return dictionary;
        }
    }
}
