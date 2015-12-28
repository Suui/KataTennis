using System.Collections.Generic;


namespace KataTennis
{
	public class Player
	{
		private readonly Dictionary<int, string> _strigifiedScores;
		private int _internalScore;

		public string Score => _strigifiedScores[_internalScore];

		public Player()
		{
			_strigifiedScores = new Dictionary<int, string>
			{
				{ 0, "love" },
				{ 15, "fifty" },
				{ 30, "thirty" },
				{ 40, "forty" }
			};

			_internalScore = 0;
		}
	}
}