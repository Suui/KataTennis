using KataTennis;
using NSubstitute;
using NUnit.Framework;


namespace Test
{
	[TestFixture]
	public class ScoreReporterShould
	{
		[Test]
		public void report_score_for_the_two_players()
		{
			var console = Substitute.For<Console>();
			var scoreReporter = new ScoreReporter(console);

			scoreReporter.Report(new Player(), new Player());

			console.Received().PrintLine(Arg.Is("love - love"));
		}

	}
}