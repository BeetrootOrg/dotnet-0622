using Snake.DataAccess.Repositories.Interfaces;

using Repository = Snake.DataAccess.Repositories.HighscoresRepository;

namespace Snake.DataAccess;

public static class Factory
{
	public static readonly IHighscoresRepository HighscoresRepository = Repository.Create();
}