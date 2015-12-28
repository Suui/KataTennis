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

		[Test]
		public void get_40_when_adding_the_third_point()
		{
			var score = new Score();

			score.AddPoint();
			score.AddPoint();
			score.AddPoint();

			score.Points.Should().Be(40);
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
			if (Points == 30) Points = 40;
			if (Points == 15) Points = 30;
			if (Points == 0) Points = 15;
		}
	}
}