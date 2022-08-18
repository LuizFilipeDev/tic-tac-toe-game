namespace TicTacToe
{
    public partial class TicTacToeGame : Form
    {
        public GameController GameController { get; set; }
        public List<Button> Buttons { get; set; }
        public int[,] Combinations { get; set; }

        public TicTacToeGame()
        {
            InitializeComponent();

            this.GameController = new GameController();
            this.Buttons = new List<Button>();

            Combinations = new int[,] { 
                {0, 1, 2}, {3, 4, 5}, {6, 7, 8},
                {0, 3, 6}, {1, 4, 7}, {2, 5, 8},
                {0, 4, 8}, {2, 4, 6}
            };
        }

        private void TicTacToeForm(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (string.IsNullOrEmpty(button.Text) && string.IsNullOrEmpty(this.label1.Text) && GameController.Click)
            {
                if (GameController.Player == GameController.CurrentPlayer.PlayerOne)
                {
                    button.Text = "X";
                    GameController.Player = GameController.CurrentPlayer.PlayerTwo;
                }
                else
                {
                    button.Text = "O";
                    GameController.Player = GameController.CurrentPlayer.PlayerOne;
                }
                VerifyEndGame();
            }
        }

        private void VerifyEndGame()
        {
            int countX = default(int);
            int countO = default(int);

            CaptureButtons();

            for (int i = default(int); i < 8; i++)
            {
                for (int x = default(int); x < 3; x++)
                {
                    if (this.Buttons[this.Combinations[i, x]].Text == "X")
                    {
                        countX++;
                    }
                    else if (this.Buttons[this.Combinations[i, x]].Text == "O")
                    {
                        countO++;
                    }
                    else
                    {
                        continue;
                    }

                    if(countX == 3)
                    {
                        Win winScreen = new Win("Player One Win", this, GameController);
                        winScreen.Show();
                        return;
                    }
                    
                    if(countO == 3)
                    {
                        Win winScreen = new Win("Player Two Win", this, GameController);
                        winScreen.Show();
                        return;
                    }
                }

                countX = default(int);
                countO = default(int);
            }

            if (VerifyTie())
            {
                Win winScreen = new Win("Tie", this, GameController);
                winScreen.Show();
            }
        }

        public void RestartGame()
        {
            foreach (Button button in this.Controls.OfType<Button>().OrderBy(x => x.Name))
            {
                button.Text = string.Empty;
            }

            this.label1.Text = string.Empty;
        }
    
        private void CaptureButtons()
        {
            this.Buttons.Clear();
            foreach (Button button in this.Controls.OfType<Button>().OrderBy(x => x.Name))
            {
                this.Buttons.Add(button);
            }
        }

        private bool VerifyTie()
        {
            int filledFields = default;
            foreach (Button button in this.Buttons)
            {
                if (!string.IsNullOrEmpty(button.Text))
                {
                    filledFields++;
                }
            }

            return filledFields == 9;
        }
    }
}