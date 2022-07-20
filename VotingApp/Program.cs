using VotingApp.Context;
using VotingApp.Controllers;
using VotingApp.Controllers.Interfaces;

namespace VotingApp
{
    internal class Program
    {
        private static void Main()
        {
            var context = new VotingAppContext();
            IController controller = new MainMenuController(context);

            while (controller != null)
            {
                controller.Render();
                controller = controller.Action();
            }
        }
    }
}