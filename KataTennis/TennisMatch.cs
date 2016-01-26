namespace KataTennis
{
	public class TennisMatch
	{
		private readonly ScoreReporter _scoreReporter;
		private readonly Player _playerOne;
		private readonly Player _playerTwo;

		public TennisMatch(ScoreReporter scoreReporter)
		{
			_scoreReporter = scoreReporter;
			_playerOne = new Player();
			_playerTwo = new Player();
		}

		public void ReportScore()
		{
			_scoreReporter.Report(_playerOne, _playerTwo);
		}

		public void PlayerOneWinsBall()
		{
			_playerOne.WinsBall();
		}

		public void PlayerTwoWinsBall()
		{
			if (_playerOne.HasAdvantage())
			{
				_playerOne.RemoveAdvantage();
				return;
			}
			_playerTwo.WinsBall();
		}
	}
}