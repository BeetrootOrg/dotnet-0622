using System.Collections.Generic;
using Snake.Contracts;

namespace Snake.Domain.Services.Interfaces;

public interface IHighscoresService
{
	IEnumerable<Highscore> GetAllHighscores();
	void AddHighscore(Highscore highscore);
}