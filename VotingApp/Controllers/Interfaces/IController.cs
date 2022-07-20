namespace VotingApp.Controllers.Interfaces
{
    internal interface IController
    {
        /// <summary>
        /// Method used to view data
        /// </summary>
        void Render();

        /// <summary>
        /// Method used to execute action
        /// </summary>
        /// <returns>Next controller</returns>
        IController Action();
    }
}
