using System.Collections.Generic;
using Snake.Contracts;
using Snake.DataAccess.Repositories.Interfaces;
using Snake.Domain.Services.Interfaces;

namespace Snake.Domain.Services;

internal class HighscoresService : IHighscoresService
{
	private readonly IHighscoresRepository _repository;

	public HighscoresService(IHighscoresRepository repository)
	{
		_repository = repository;
	}

	public void AddHighscore(Highscore highscore)
	{
		_repository.AddHighscore(highscore);
	}

	public IEnumerable<Highscore> GetAllHighscores()
	{
		return _repository.GetAllHighscores();
	}
}