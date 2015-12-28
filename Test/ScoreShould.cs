using FluentAssertions;
using KataTennis;
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

		[Test]
		public void set_advantage_true_when_adding_a_fourth_point()
		{
			var score = new Score();

			score.AddPoint();
			score.AddPoint();
			score.AddPoint();
			score.AddPoint();

			score.Points.Should().Be(40);
			score.Advantage.Should().BeTrue();
		}
	}
}