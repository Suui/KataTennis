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
			if (playerOne.Score.Points == 40 && playerTwo.Score.Points == 40)
				_console.PrintLine("deuce");
			else
				_console.PrintLine(playerOne.Score + " - " + playerTwo.Score);
		}
	}
}