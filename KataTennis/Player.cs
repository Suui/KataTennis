namespace KataTennis
{
	public class Player
	{
		public readonly Score Score;

		public Player()
		{
			Score = new Score();
		}

		public void WinsBall()
		{
			Score.AddPoint();
		}

		public bool HasAdvantage()
		{
			return Score.Advantage;
		}

		public void RemoveAdvantage()
		{
			Score.RemoveAdvantage();
		}
	}
}