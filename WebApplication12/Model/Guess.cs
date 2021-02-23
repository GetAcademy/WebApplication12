using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication12.Model
{
    class Guess
    {
        public int Number { get; }
        private bool _isTooHigh;
        public bool IsCorrect { get; }
        public string Description => $"{Number} er {DescriptionWord}";

        private string DescriptionWord =>
            IsCorrect ? "riktig!" :
            _isTooHigh ? "for høyt" :
            "for lavt";

        public Guess(int number, bool isTooHigh, bool isCorrect)
        {
            Number = number;
            _isTooHigh = isTooHigh;
            IsCorrect = isCorrect;
        }
    }
}
