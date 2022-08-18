using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Win : Form
    {
        public TicTacToeGame TicTacToeGame { get; set; }
        public GameController GameController { get; set; }
        public Win()
        {
            InitializeComponent();
        }
        public Win(string message, TicTacToeGame ticTacToeGame, GameController gameController)
        {
            InitializeComponent();
            this.TicTacToeGame = ticTacToeGame;
            this.SuccessLabel.Text = message;
            this.GameController = gameController;
            GameController.Click = false;
        }

        private void Win_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void SuccessLabel_Click(object sender, EventArgs e)
        {

        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            TicTacToeGame.RestartGame();
            GameController.Click = true;
            this.Close();
        }
    }
}
