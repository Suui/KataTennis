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
	}
}