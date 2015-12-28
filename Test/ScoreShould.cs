using System.Collections.Generic;
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

	public class Score
	{
		public int Points { get; private set; }
		public bool Advantage { get; private set; }

		private readonly Dictionary<int, int> _pointAdditions;

		public Score()
		{
			Points = 0;
			Advantage = false;

			_pointAdditions = new Dictionary<int, int>
			{
				{ 0, 15 },
				{ 15, 30 },
				{ 30, 40 }
			};
		}

		public void AddPoint()
		{
			if (Points == 40)
			{
				SetAdvantage(true);
				return;
			}
			Points = _pointAdditions[Points];
		}

		private void SetAdvantage(bool value)
		{
			Advantage = value;
		}
	}
}