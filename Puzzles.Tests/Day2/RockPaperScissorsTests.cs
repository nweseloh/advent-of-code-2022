using System.Collections.Generic;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using Puzzles.Day2;

namespace Puzzles.Tests.Day2;

[TestFixture]
public class RockPaperScissorsTests
{
    private RockPaperScissors _rockPaperScissors;

    [SetUp]
    public void SetUp()
    {
        _rockPaperScissors = new RockPaperScissors();
    }

    [TestCase(8, "A Y")]
    [TestCase(1, "B X")]
    [TestCase(6, "C Z")]
    public void GetScore_ReturnsScore_ForSingleGame(int expected, params string[] games)
    {
        int result = _rockPaperScissors.GetScore(games);

        result.Should().Be(expected);
    }

    [TestCase(15, "A Y", "B X", "C Z")]
    public void GetScore_ReturnsScore_ForMultipleGames(int expected, params string[] games)
    {
        int result = _rockPaperScissors.GetScore(games);

        result.Should().Be(expected);
    }

    [Test, Explicit]
    public async Task Solve_Part1()
    {
        List<string> input = await new InputReader().GetPuzzleInput(2);

        int result= _rockPaperScissors.GetScore(input);

        result.Should().Be(0);
    }
}