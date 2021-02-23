using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication12.Model
{
    public class Game
    {
        private static readonly Random Random = new Random();
        private readonly int _correctNumber;
        private readonly List<Guess> _guesses;
        public bool IsSolved => _guesses.Count > 0 && _guesses.Last().IsCorrect;
        public bool IsTooHigh => _guesses.Count > 0 && _guesses.Last().Number > _correctNumber;

        public Game()
        {
            _correctNumber = Random.Next(1, 100);
            _guesses = new List<Guess>();
        }

        public void GiveUp()
        {
            Console.WriteLine($"Jeg tenkte på tallet {_correctNumber}.");
        }

        public void Guess(int number)
        {
            if (IsSolved) return;
            var guess = new Guess(number, number > _correctNumber, number == _correctNumber);
            _guesses.Add(guess);
        }
    }
}
