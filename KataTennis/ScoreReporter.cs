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
			_console.PrintLine(playerOne.Score + " - " + playerTwo.Score);
		}
	}
}