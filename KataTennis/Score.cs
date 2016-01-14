using System.Collections.Generic;


namespace KataTennis
{
	public class Score
	{
		public int Points { get; private set; }
		public bool Advantage { get; private set; }

		private readonly Dictionary<int, int> _pointAdditions;
		private readonly Dictionary<int, string> _stringifiedScores;

		public Score()
		{
			Points = 0;
			Advantage = false;

			_pointAdditions = new Dictionary<int, int>
			{
				{ 0, 15 },
				{ 15, 30 },
				{ 30, 40 }
			};

			_stringifiedScores = new Dictionary<int, string>
			{
				{ 0, "love" },
				{ 15, "fifty" },
				{ 30, "thirty" },
				{ 40, "forty" }
			};
		}

		public void AddAdvantage() { Advantage = true; }

		public void RemoveAdvantage() { Advantage = false; }

		public void AddPoint()
		{
			if (Points == 40)
			{
				AddAdvantage();
				return;
			}
			Points = _pointAdditions[Points];
		}

		public override string ToString()
		{
			return _stringifiedScores[Points];
		}
	}
}