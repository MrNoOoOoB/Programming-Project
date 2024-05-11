using BoardLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGUI
{
    public partial class oneVone : Form
    {
        int currentTurn = 0;
        String[] gameBoard = new String[9];
        public string returnSympol(int turn)
        {
            if (turn % 2 == 0)
            {
                return "X";
            }
            else
            {
                return "O";
            }
        }
        public void CheckForWinner()
        {
            for (int i = 0; i < gameBoard.Length; i++)
            {
                String combination = "";
                switch (i)
                {
                    case 0:
                        combination = gameBoard[0] + gameBoard[4] + gameBoard[8];
                        break;
                    case 1:
                        combination = gameBoard[2] + gameBoard[4] + gameBoard[6];
                        break;
                    case 2:
                        combination = gameBoard[0] + gameBoard[1] + gameBoard[2];
                        break;
                    case 3:
                        combination = gameBoard[3] + gameBoard[4] + gameBoard[5];
                        break;
                    case 4:
                        combination = gameBoard[6] + gameBoard[7] + gameBoard[8];
                        break;
                    case 5:
                        combination = gameBoard[0] + gameBoard[3] + gameBoard[6];
                        break;
                    case 6:
                        combination = gameBoard[1] + gameBoard[4] + gameBoard[7];
                        break;
                    case 7:
                        combination = gameBoard[2] + gameBoard[5] + gameBoard[8];
                        break;
                }
                if (combination.Equals("OOO"))
                {
                    MessageBox.Show("Player O Won The Game :)", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                else if (combination.Equals("XXX"))
                {
                    MessageBox.Show("Player X Won The Game :)", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                CheckForDraw();

            }
        }
        public void CheckForDraw()
        {
            int counter = 0;
            for (int i = 0; i < gameBoard.Length; i++)
            {
                if (gameBoard[i] is not null)
                {
                    counter++;
                }
                if (counter == 9)
                {
                    MessageBox.Show("Draw!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
            }
        }
        public void Reset()
        {
            button1.Enabled = true;
            button1.Text = "";
            button2.Enabled = true;
            button2.Text = "";
            button3.Enabled = true;
            button3.Text = "";
            button4.Enabled = true;
            button4.Text = "";
            button5.Enabled = true;
            button5.Text = "";
            button6.Enabled = true;
            button6.Text = "";
            button7.Enabled = true;
            button7.Text = "";
            button8.Enabled = true;
            button8.Text = "";
            button9.Enabled = true;
            button9.Text = "";
            gameBoard = new String[9];
            currentTurn = 0;
        }
        public oneVone()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[0] = returnSympol(currentTurn);
            button1.Text = gameBoard[0];
            button1.Enabled = false;
            CheckForWinner();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[1] = returnSympol(currentTurn);
            button2.Text = gameBoard[1];
            button2.Enabled = false;
            CheckForWinner();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[2] = returnSympol(currentTurn);
            button3.Text = gameBoard[2];
            button3.Enabled = false;
            CheckForWinner();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[3] = returnSympol(currentTurn);
            button4.Text = gameBoard[3];
            button4.Enabled = false;
            CheckForWinner();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[4] = returnSympol(currentTurn);
            button5.Text = gameBoard[4];
            button5.Enabled = false;
            CheckForWinner();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[5] = returnSympol(currentTurn);
            button6.Text = gameBoard[5];
            button6.Enabled = false;
            CheckForWinner();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[6] = returnSympol(currentTurn);
            button7.Text = gameBoard[6];
            button7.Enabled = false;
            CheckForWinner();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[7] = returnSympol(currentTurn);
            button8.Text = gameBoard[7];
            button8.Enabled = false;
            CheckForWinner();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[8] = returnSympol(currentTurn);
            button9.Text = gameBoard[8];
            button9.Enabled = false;
            CheckForWinner();
        }
        private void newGamebtn_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
