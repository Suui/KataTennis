using FluentAssertions;
using NUnit.Framework;


namespace Test
{
	[TestFixture]
	public class ScoreShould
	{
		[Test]
		public void get_15_when_adding_the_first_point()
		{
			var score = new Score();

			score.AddPoint();

			score.Points.Should().Be(15);
		}

		[Test]
		public void get_30_when_adding_the_second_point()
		{
			var score = new Score();

			score.AddPoint();
			score.AddPoint();

			score.Points.Should().Be(30);
		}
	}

	public class Score
	{
		public int Points { get; private set; }

		public Score()
		{
			Points = 0;
		}

		public void AddPoint()
		{
			Points = Points == 15 ? 30 : 15;
		}
	}
}