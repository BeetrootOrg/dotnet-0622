using System.Collections.Generic;
using Snake.Contracts;

namespace Snake.DataAccess.Repositories.Interfaces;

public interface IHighscoresRepository
{
	IEnumerable<Highscore> GetAllHighscores();
	void AddHighscore(Highscore highscore);
}