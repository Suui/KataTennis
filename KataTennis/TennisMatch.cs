namespace KataTennis
{
	public class TennisMatch
	{
		private readonly ScoreReporter _scoreReporter;
		public readonly Player PlayerOne;
		public readonly Player PlayerTwo;


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
	}
}