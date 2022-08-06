using Snake.Domain.Services;
using Snake.Domain.Services.Interfaces;

using DataAccessFactory = Snake.DataAccess.Factory;

namespace Snake.Domain;

public static class Factory
{
	public static readonly IHighscoresService HighscoresService = new HighscoresService(DataAccessFactory.HighscoresRepository);
}