using BoardLogic;
using System;

namespace TicTacToeGUI
{
    public partial class Form1 : Form
    {
        Board game = new Board();
        Button[] buttons = new Button[9];
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            game = new Board();

            buttons[0] = button1;
            buttons[1] = button2;
            buttons[2] = button3;
            buttons[3] = button4;
            buttons[4] = button5;
            buttons[5] = button6;
            buttons[6] = button7;
            buttons[7] = button8;
            buttons[8] = button9;

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Click += handleButtonClick;
                buttons[i].Tag = i;
            }

        }

        private void handleButtonClick(object? sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int gameSquarNumber = (int)clickedButton.Tag;
            game.Grid[gameSquarNumber] = 1;
            updateBoard();
            if (game.isBoardFull() == true)
            {
                MessageBox.Show("The Board is Full!!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                disableAllButtons();
            }
            else if (game.checkForWinner() == 1)
            {
                MessageBox.Show("Player Human Won !", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                disableAllButtons();
            }
            else
            {
                computerChoose();
            }
        }

        private void computerChoose()
        {
            int computerTurn = rand.Next(9);
            while (computerTurn == -1 || game.Grid[computerTurn] != 0)
            {
                computerTurn = rand.Next(9);
            }
            game.Grid[computerTurn] = 2;
            updateBoard();
            if (game.isBoardFull() == true)
            {
                MessageBox.Show("The Board is Full!!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                disableAllButtons();
            }
            if (game.checkForWinner() == 2)
            {
                MessageBox.Show("Computer Won !", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                disableAllButtons();
            }
        }

        private void disableAllButtons()
        {
            foreach (var item in buttons)
            {
                item.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateBoard();
        }

        private void updateBoard()
        {
            for (int i = 0; i < game.Grid.Length; i++)
            {
                if (game.Grid[i] == 0)
                {
                    buttons[i].Text = "";
                    buttons[i].Enabled = true;
                }
                else if (game.Grid[i] == 1)
                {
                    buttons[i].Text = "X";
                    buttons[i].Enabled = false;
                    buttons[i].ForeColor = Color.Green;

                }
                else if (game.Grid[i] == 2)
                {
                    buttons[i].Text = "O";
                    buttons[i].Enabled = false;
                    buttons[i].ForeColor = Color.Red;


                }
            }
        }

        private void newGamebtn_Click(object sender, EventArgs e)
        {
            game = new Board();
            enableAllButtons();
        }

        private void enableAllButtons()
        {
            foreach (var item in buttons)
            {
                item.Enabled = true;
            }
            updateBoard();
        }

        private void oneVone_Click(object sender, EventArgs e)
        {
            oneVone p = new oneVone();
            p.ShowDialog();
        }
    }
}
