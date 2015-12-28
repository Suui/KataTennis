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
	}

	public class Score
	{
		public int Points { get; private set; }
		private readonly Dictionary<int, int> _pointAdditions;

		public Score()
		{
			_pointAdditions = new Dictionary<int, int>
			{
				{ 0, 15 },
				{ 15, 30 },
				{ 30, 40 }
			};
			Points = 0;
		}

		public void AddPoint()
		{
			Points = _pointAdditions[Points];
		}
	}
}