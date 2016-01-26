namespace KataTennis
{
	public class TennisMatch
	{
		private readonly ScoreReporter _scoreReporter;
		private readonly Player PlayerOne;
		private readonly Player PlayerTwo;

		public TennisMatch(ScoreReporter scoreReporter)
		{
			_scoreReporter = scoreReporter;
			PlayerOne = new Player();
			PlayerTwo = new Player();
		}

		public void ReportScore()
		{
			_scoreReporter.Report(PlayerOne, PlayerTwo);
		}

		public void PlayerOneWinsBall()
		{
			PlayerOne.WinsBall();
		}

		public void PlayerTwoWinsBall()
		{
			PlayerTwo.WinsBall();
		}
	}
}