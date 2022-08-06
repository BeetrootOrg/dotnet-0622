using System.Collections.Generic;
using Snake.Contracts;
using Snake.DataAccess.Repositories.Interfaces;
using Newtonsoft.Json;

namespace Snake.DataAccess.Repositories;

internal class HighscoresRepository : IHighscoresRepository
{
	private const string Filename = "highscores.json";
	private readonly IList<Highscore> _highscores = new List<Highscore>();

	private HighscoresRepository(IList<Highscore> highscores)
	{
		_highscores = highscores;
	} 

	public void AddHighscore(Highscore highscore)
	{
		_highscores.Add(highscore);
		var orderedHighscores = _highscores.OrderByDescending(f => f.Score).ToList();
		var serialized = JsonConvert.SerializeObject(orderedHighscores);
		File.WriteAllText(Filename, serialized);
	}

	public IEnumerable<Highscore> GetAllHighscores()
	{
		return _highscores.OrderByDescending(f => f.Score).ToList();
	}

	public static HighscoresRepository Create()
	{
		IList<Highscore> hightscores;
		if (!File.Exists(Filename))
		{
			hightscores = new List<Highscore>();
		}
		else
		{
			var serialized = File.ReadAllText(Filename);
			hightscores = JsonConvert.DeserializeObject<IList<Highscore>>(serialized);
		}

		return new HighscoresRepository(hightscores);
	}
}