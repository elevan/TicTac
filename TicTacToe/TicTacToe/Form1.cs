using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TicTacToe
{
    public partial class Form1 : Form
    {

        int GameWinner;
        Button[] Buttons = new Button[9];
        int turn = 0;
        bool ComputerFirst = false;

        public Form1()
        {
            InitializeComponent();

            Buttons[0] = button1;
            Buttons[1] = button2;
            Buttons[2] = button3;
            Buttons[3] = button4;
            Buttons[4] = button5;
            Buttons[5] = button6;
            Buttons[6] = button7;
            Buttons[7] = button8;
            Buttons[8] = button9;


            firstMove();
        }

        private void firstMove()
        {

            Random start = new Random();
            int first = start.Next(0,2);


            if(first == 0)
            {
                turn = 0;
                ComputerFirst = true;
                Computerturn();
            }
            else
            {
                MessageBox.Show("Player goes First");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            turn++;
            button1.Text = "X";
            button1.Enabled = false;

            if (CheckWin())
            {
                MessageBox.Show("Player Wins");
                GameWinner = 0;
                LogGame();
                Reset();
                firstMove();
            }
            else if (CheckTie())
            {
                GameWinner = 2;
                MessageBox.Show("Tie Game");
                LogGame();
                Reset();
                firstMove();
            }

            Computerturn();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            turn++;
            button2.Text = "X";
            button2.Enabled = false;

            if (CheckWin())
            {
                MessageBox.Show("Player Wins");
                GameWinner = 0;
                LogGame();
                Reset();
                firstMove();
            }
            else if (CheckTie())
            {
                GameWinner = 2;
                MessageBox.Show("Tie Game");
                LogGame();
                Reset();
                firstMove();
            }

            Computerturn();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            turn++;
            button3.Text = "X";
            button3.Enabled = false;

            if (CheckWin())
            {
                GameWinner = 0;
                MessageBox.Show("Player Wins");
                LogGame();
                Reset();
                firstMove();
            }
            else if (CheckTie())
            {
                GameWinner = 2;
                MessageBox.Show("Tie Game");
                LogGame();
                Reset();
                firstMove();
            }

            Computerturn();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            turn++;
            button4.Text = "X";
            button4.Enabled = false;

            if (CheckWin())
            {
                GameWinner = 0;
                MessageBox.Show("Player Wins");
                LogGame();
                Reset();
                firstMove();
            }
            else if (CheckTie())
            {
                GameWinner = 2;
                MessageBox.Show("Tie Game");
                LogGame();
                Reset();
                firstMove();
            }

            Computerturn();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            turn++;
            button5.Text = "X";
            button5.Enabled = false;

            if (CheckWin())
            {
                GameWinner = 0;
                MessageBox.Show("Player Wins");
                LogGame();
                Reset();
                firstMove();
            }
            else if (CheckTie())
            {
                GameWinner = 2;
                MessageBox.Show("Tie Game");
                LogGame();
                Reset();
                firstMove();
            }

            Computerturn();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            turn++;
            button6.Text = "X";
            button6.Enabled = false;

            if (CheckWin())
            {
                GameWinner = 0;
                MessageBox.Show("Player Wins");
                LogGame();
                Reset();
                firstMove();
            }
            else if (CheckTie())
            {
                GameWinner = 2;
                MessageBox.Show("Tie Game");
                LogGame();
                Reset();
                firstMove();
            }

            Computerturn();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            turn++;
            button7.Text = "X";
            button7.Enabled = false;

            if (CheckWin())
            {
                GameWinner = 0;
                MessageBox.Show("Player Wins");
                LogGame();
                Reset();
                firstMove();
            }
            else if (CheckTie())
            {
                GameWinner = 2;
                MessageBox.Show("Tie Game");
                LogGame();
                Reset();
                firstMove();
            }

            Computerturn();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            turn++;
            button8.Text = "X";
            button8.Enabled = false;

            if (CheckWin())
            {
                GameWinner = 0;
                MessageBox.Show("Player Wins");
                LogGame();
                Reset();
                firstMove();
            }
            else if (CheckTie())
            {
                GameWinner = 2;
                MessageBox.Show("Tie Game");
                LogGame();
                Reset();
                firstMove();
            }

            Computerturn();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            turn++;
            button9.Text = "X";
            button9.Enabled = false;

            if (CheckWin())
            {
                GameWinner = 0;
                MessageBox.Show("Player Wins");
                LogGame();
                Reset();
                firstMove();
            }
            else if (CheckTie())
            {
                GameWinner = 2;
                MessageBox.Show("Tie Game");
                LogGame();
                Reset();
                firstMove();
            }

            Computerturn();
        }

        private Boolean CheckWin()
        {
            for (int i = 0; i < 3; i++)
            {
                if (Buttons[i].Text == Buttons[i + 3].Text && Buttons[i].Text == Buttons[i + 6].Text && Buttons[i].Text != "")
                {
                    return true;
                }
            }

            for (int i = 0; i < 8; i += 3)
            {
                if (Buttons[i].Text == Buttons[i + 1].Text && Buttons[i].Text == Buttons[i + 2].Text && Buttons[i].Text != "")
                    return true;                  
            }

            if (Buttons[0].Text == Buttons[4].Text && Buttons[0].Text == Buttons[8].Text && Buttons[0].Text != "")
                return true;
            else if (Buttons[2].Text == Buttons[4].Text && Buttons[2].Text == Buttons[6].Text && Buttons[2].Text != "")
                return true;

                return false;
        }

        private Boolean CheckTie()
        {
            int panels = 0;

            for (int i = 0; i < 9; i++)
            {
                if (Buttons[i].Enabled == false)
                {
                    panels++;
                }
            }

            if (panels == 9)
                return true;
            else
                return false;
        }

        private void Reset()
        {
            for (int i = 0; i < 9; i++)
            {
                Buttons[i].Text = "";
                Buttons[i].Enabled = true;
            }
            GameWinner = 5;
            turn = 0;
            ComputerFirst = false;
        }

        private void Computerturn()
        {
            turn++;
            if (ComputerFirst && turn ==1)
            {

                Buttons[4].Text = "O";
                Buttons[4].Enabled = false;
                return;
            }
            else if (turn == 2&& ComputerFirst == false)
            {
                if (Buttons[4].Enabled == true)
                {
                    Buttons[4].Text = "O";
                    Buttons[4].Enabled = false;
                    return;
                }
                else
                {
                    Buttons[0].Text = "O";
                    Buttons[0].Enabled = false;
                    return;    
                }
            }


            int temp = DenyWin();

            if (temp == 10)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (Buttons[i].Enabled == true)
                    {
                        Buttons[i].Text = "O";
                        Buttons[i].Enabled = false;
                        CheckCompWin();
                        return;
                    }
                }
            }
                
            else
            {
                Buttons[temp].Text = "O";
                Buttons[temp].Enabled = false;
                CheckCompWin();
                return;
            }



        }

        private void CheckCompWin()
        {
            if (CheckWin())
            {
                GameWinner = 1;
                MessageBox.Show("Computer Wins");
                LogGame();
                Reset();
                firstMove();
            }
            else if (CheckTie())
            {
                GameWinner = 2;
                MessageBox.Show("Tie Game");
                LogGame();
                Reset();
                firstMove();
            }

        }

        private int DenyWin()
        {
            if (Buttons[4].Text == Buttons[8].Text && Buttons[8].Text != "" && Buttons[0].Enabled == true)
                return 0;
            else if (Buttons[0].Text == Buttons[4].Text && Buttons[0].Text != "" && Buttons[8].Enabled == true)
                return 8;
            else if (Buttons[0].Text == Buttons[8].Text && Buttons[0].Text != "" && Buttons[4].Enabled == true)
                return 4;
            else if (Buttons[4].Text == Buttons[6].Text && Buttons[6].Text != "" && Buttons[2].Enabled == true)
                return 2;
            else if (Buttons[2].Text == Buttons[6].Text && Buttons[2].Text != "" && Buttons[4].Enabled == true)
                return 4;
            else if (Buttons[4].Text == Buttons[2].Text && Buttons[2].Text != "" && Buttons[6].Enabled == true)
                return 6;

            for (int i = 0; i < 3; i++ )
            {
                if (Buttons[i + 3].Text == Buttons[i + 6].Text && Buttons[i + 3].Text != "" && Buttons[i].Enabled == true)
                    return i;
            }
            for (int i = 3; i < 6; i++)
            {
                if (Buttons[i + 3].Text == Buttons[i - 3].Text && Buttons[i + 3].Text != "" && Buttons[i].Enabled == true)
                    return i;
            }
            for (int i = 6; i < 9; i++)
            {
                if (Buttons[i - 6].Text == Buttons[i - 3].Text && Buttons[i - 3].Text != "" && Buttons[i].Enabled == true)
                    return i;
            }
            for (int i = 0; i < 8; i += 3)
            {
                if (Buttons[i + 1].Text == Buttons[i + 2].Text && Buttons[i + 1].Text != "" && Buttons[i].Enabled == true)
                    return i;
            }
            for (int i = 1; i < 8; i += 3)
            {
                if (Buttons[i + 1].Text == Buttons[i + -1].Text && Buttons[i + 1].Text != "" && Buttons[i].Enabled == true)
                    return i;
            }
            for (int i = 2; i < 8; i += 3)
            {
                if (Buttons[i - 1].Text == Buttons[i - 2].Text && Buttons[i - 1].Text != "" && Buttons[i].Enabled == true)
                    return i;
            }


                return 10;
        }

        public void LogGame()
        {
            String GameResult = "";

            for (int i = 0; i < 9; i++ )
            {
                if (Buttons[i].Text == "")
                    GameResult = GameResult + "_";
                else
                    GameResult = GameResult + Buttons[i].Text;
            }

            if (GameWinner == 0)
                GameResult = GameResult + "=X";
            else if (GameWinner == 1)
                GameResult = GameResult + "=O";
            else if (GameWinner == 2)
                GameResult = GameResult + "=?";

            

            StreamWriter writer = new StreamWriter("GameLog.txt", true); 
            writer.WriteLine(GameResult); 
            writer.Close(); 
            writer.Dispose();
        }
    }
}
