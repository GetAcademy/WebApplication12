using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication12.Model
{
    public class SimpleGuess
    {
        public int Number { get; set; }

        public SimpleGuess()
        {
            
        }

        public SimpleGuess(int number)
        {
            Number = number;
        }
    }
}
