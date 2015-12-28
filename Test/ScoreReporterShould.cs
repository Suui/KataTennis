using NUnit.Framework;

/**
	Implementing a tennis Score.

	Rules:
	Player1 always starts
	Players can score points and the score will adjust
	There will be no points or sets, if you have 40 and you win the ball you win the game

	Domain concepts:
	Win Ball, Win Game
	The scores are described in a manner peculiar to tennis:
		0: love, 15: fifteen, 30: thirty, 40: forty
		when deuced (40-40): deuce
		when advantage: advantage for the player

	Score reports follow this format:
	"love - fifteen"
	
	In case of deuce:
	"deuce"

	In case of advantage:
	"advantage - forty"


	POSSIBLE TESTS
	0 - 0			=> "love - love"
	15 - 0			=> "fifteen - love"	&& generalize for all cases
	40 - 0 & wins	=> "Player1 wins the game"
	40 - 40			=> "deuce"
	adv - 40		=> "advantage - forty"
	40 - adv & wins	=> "Player2 wins the game"

*/


namespace Test
{
	[TestFixture]
	public class ScoreReporterShould
	{

	}
}
