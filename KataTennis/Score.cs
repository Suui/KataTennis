using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;


namespace KataTennis
{
	public class Scores
	{
		public static Scores Zero = new Scores(0, Fifteen, "love");
		public static Scores Fifteen = new Scores(15, Thirty, "fifteen");
		public static Scores Thirty = new Scores(30, Forty, "thirty");
		public static Scores Forty = new Scores(40, Advantage, "forty");
		public static Scores Advantage = new Scores(40, Forty, "advantage");

		public Scores NextValue { get; set; }
		public string Name { get; set; }
		public int CurrrentPoint { get; set; }

		private Scores(int currrentPoint, Scores nextValue, string name)
		{
			NextValue = nextValue;
			Name = name;
			CurrrentPoint = currrentPoint;
		}

		
	}
	public class Score
	{
		public Scores Points { get; private set; }
		public bool Advantage { get; private set; }

		public Score()
		{
			Points = Scores.Zero;
			Advantage = false;

		}

		private void AddAdvantage()
		{
			Advantage = true;
		}

		private void RemoveAdvantage()
		{
			Advantage = false;
		}

		public void AddPoint()
		{
			if (Points == Scores.Fifteen)
			{
				AddAdvantage();
				return;
			}
			Points = Points.NextValue;
		}

		public override string ToString()
		{
			return Points.Name;
		}
	}
}