using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;


namespace KataTennis
{
	public class Scores
	{
		public static Scores Zero = new Scores(0, Fifty, "Zero");
		public static Scores Fifty = new Scores(15, Thirty, "Fifty");
		public static Scores Thirty = new Scores(30, Fourty, "Thirty");
		public static Scores Fourty = new Scores(40, Fourty, "Fourty");

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
			if (Points == Scores.Fifty)
			{
				AddAdvantage();
				return;
			}
			Points = Points.NextValue;
		}
	}
}