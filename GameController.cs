using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class GameController
    {
        public enum CurrentPlayer
        {
            PlayerOne,
            PlayerTwo
        }

        public CurrentPlayer Player { get; set; }
        public bool Click { get; set; } = true;
    }
}
