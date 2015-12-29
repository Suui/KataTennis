namespace KataTennis
{
	public class ScoreReporter
	{
		private readonly Console _console;

		public ScoreReporter(Console console)
		{
			_console = console;
		}

		public void Report(Player playerOne, Player playerTwo)
		{
			if (playerOne.Score.Points == Scores.Forty && playerTwo.Score.Points == Scores.Forty)
				_console.PrintLine("deuce");
			else
				_console.PrintLine(playerOne.Score + " - " + playerTwo.Score);
		}
	}
}