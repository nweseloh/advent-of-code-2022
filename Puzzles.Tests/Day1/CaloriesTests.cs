using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using Puzzles.Day1;

namespace Puzzles.Tests.Day1;

[TestFixture]
public class CaloriesTests
{
    private Calories _calories;

    [SetUp]
    public void SetUp()
    {
        _calories = new Calories();
    }

    [TestCase(1, "1")]
    [TestCase(2, "2")]
    [TestCase(2, "1", "1")]
    public void GetHighest_ReturnsSum_ForSingleElf(int expected, params string[] input)
    {
        var calories = _calories.GetHighestCalories(input);

        calories.Should().Be(expected);
    }

    [TestCase(1, "1", "")]
    [TestCase(2, "1", "1", "")]
    [TestCase(2, "1", "1", "", "1")]
    public void GetHighest_ReturnsSum_FromFirstElf(int expected, params string[] input)
    {
        var calories = _calories.GetHighestCalories(input);

        calories.Should().Be(expected);
    }


    [TestCase(2, "1", "", "2")]
    public void GetHighest_ReturnsSum_FromHighestCarryingElf(int expected, params string[] input)
    {
        var calories = _calories.GetHighestCalories(input);

        calories.Should().Be(expected);
    }

    [Test, Explicit]
    public async Task Solve_Part1()
    {
        var input = await new InputReader().GetPuzzleInput(1);

        var calories = _calories.GetHighestCalories(input);

        calories.Should().Be(0);
    }

    [TestCase(2, "1", "", "1")]
    public void GetHighest_ReturnsSum_OfTwoElves(int expected, params string[] input)
    {
        var calories = _calories.GetHighestCalories(input, 2);

        calories.Should().Be(expected);
    }

    [Test, Explicit]
    public async Task Solve_Part2()
    {
        var input = await new InputReader().GetPuzzleInput(1);

        var calories = _calories.GetHighestCalories(input, 3);

        calories.Should().Be(0);
    }
}

    