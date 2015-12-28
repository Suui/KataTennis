using System.Collections.Generic;


namespace KataTennis
{
	public class Score
	{
		public int Points { get; private set; }
		public bool Advantage { get; private set; }

		private readonly Dictionary<int, int> _pointAdditions;

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
		}

		public void AddPoint()
		{
			if (Points == 40)
			{
				AddAdvantage();
				return;
			}
			Points = _pointAdditions[Points];
		}

		private void AddAdvantage()
		{
			Advantage = true;
		}

		private void RemoveAdvantage()
		{
			Advantage = false;
		}
	}
}