using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication12.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication12.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuessTheNumberController : ControllerBase
    {
        private List<Game> _games;

        public GuessTheNumberController(List<Game> games)
        {
            _games = games;
        }

        // POST api/<GuessTheNumberController>
        [HttpPost]
        public int NewGame()
        {
            var game = new Game();
            _games.Add(game);
            return _games.Count - 1;
        }

        // PUT api/<GuessTheNumberController>/5
        [HttpPut("{id}")]
        public int Put(int id, [FromBody] SimpleGuess guess)
        {
            _games[id].Guess(guess.Number);
            return _games[id].IsSolved ? 0 : _games[id].IsTooHigh ? 1 : -1;
        }
    }
}
