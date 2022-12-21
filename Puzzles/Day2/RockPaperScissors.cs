using System;
using System.Collections.Generic;
using System.Linq;

namespace Puzzles.Day2
{
    public class RockPaperScissors
    {
        public int GetScore(IEnumerable<string> games)
        {
            int score = 0; 
            foreach (var game in games)
            {
                string[] shapes = game.Split(' ');

                Shape opponent = ToShape(shapes.First().Single());
                Shape own = ToShape(shapes.Last().Single());

                Outcome outcome = GetOwnOutcome(opponent, own);

                score += (int)outcome + (int)own;
            }

            return score;
        }

        private Shape ToShape(char c)
        {
            switch (c)
            {
                case 'A':
                case 'X':
                    return Shape.Rock;
                case 'B':
                case 'Y':
                    return Shape.Paper;
                case 'C':
                case 'Z':
                    return Shape.Scissors;
            }
            throw new ArgumentOutOfRangeException();
        }


        private Outcome GetOwnOutcome(Shape opponent, Shape own)
        {
            switch (own)
            {
                case Shape.Rock:
                    switch (opponent)
                    {
                        case Shape.Rock:
                            return Outcome.Draw;
                        case Shape.Paper:
                            return Outcome.Loss;
                        case Shape.Scissors:
                            return Outcome.Win;
                    }

                    break;
                case Shape.Paper:
                    switch (opponent)
                    {
                        case Shape.Rock:
                            return Outcome.Win;
                        case Shape.Paper:
                            return Outcome.Draw;
                        case Shape.Scissors:
                            return Outcome.Loss;
                    }

                    break;
                case Shape.Scissors:
                    switch (opponent)
                    {
                        case Shape.Rock:
                            return Outcome.Loss;
                        case Shape.Paper:
                            return Outcome.Win;
                        case Shape.Scissors:
                            return Outcome.Draw;
                    }

                    break;

            }

            throw new ArgumentOutOfRangeException();
        }
    }
}