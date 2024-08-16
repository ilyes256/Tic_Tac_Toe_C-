using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_C_.Properties;

namespace Tic_Tac_Toe_C_
{
    public partial class Form1 : Form
    {
        enum PLAYER { PLAYER1, PLAYER2 };
        enum GAME_STATE { WIN, LOSE, DRAW };

        enum GAME_PROGRESS { IN_PROGRESS, GAME_OVER };

        PLAYER winner;

        int turn = 1;
        int win_row = -1, win_col = -1, win_diagonal = -1;



        static char[,] grid = new char[3, 3]
        {
            { '.', '.', '.' },
            { '.', '.', '.' },
            { '.', '.', '.' }
        };

        char check_row(int row)
        {
            char ch = grid[row, 0];
            if (ch == '.')
            {
                return ch;
            }
            for (int c = 1; c < 3; c++)
            {
                if (grid[row, c] != ch)
                {
                    return '.';
                }
            }
            win_row = row;
            return ch;
        }

        char check_column(int column)
        {
            char ch = grid[0, column];
            if (ch == '.')
            {
                return ch;
            }

            for (int r = 1; r < 3; r++)
            {
                if (ch != grid[r, column])
                {
                    return '.';
                }
            }
            win_col = column;
            return ch;
        }

        char check_first_diagonal()
        {
            char ch = grid[0, 0];
            if (ch == '.')
            {
                return ch;
            }
            for (int i = 1; i < 3; i++)
            {
                if (grid[i, i] != ch)
                {
                    return '.';
                }
            }
            win_diagonal = 1;
            return ch;
        }

        char check_second_diagonal()
        {
            char ch = grid[0, 2];
            if (ch == '.')
            {
                return ch;
            }

            for (int r = 1, c = 1; r < 3; r++, c--)
            {
                if (grid[r, c] != ch)
                {
                    return '.';
                }
            }
            win_diagonal = 2;
            return ch;
        }

        char check_winner()
        {
            char winner;
            //check rows
            for (int r = 0; r < 3; r++)
            {
                winner = check_row(r);
                if (winner != '.')
                {
                    return winner;
                }
            }
            //check columns
            for (int c = 0; c < 3; c++)
            {
                winner = check_column(c);
                if (winner != '.')
                {
                    return winner;
                }
            }
            //check first diagonal
            winner = check_first_diagonal();
            if (winner != '.')
            {
                return winner;
            }
            //check second diagonal
            winner = check_second_diagonal();
            if (winner != '.')
            {
                return winner;
            }
            return '.';
        }

        private bool check_draw()
        {
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (grid[r, c] == '.')
                    {
                        return false;
                    }
                }
            }
            return (check_winner() == '.');

        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Color White = Color.FromArgb(255, 255, 255, 255);

            Pen Pen = new Pen(White);
            Pen.Width = 5;

            // Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            //draw vertical line

            e.Graphics.DrawLine(Pen, 538, 100, 538, 403);
            e.Graphics.DrawLine(Pen, 556 + 100 + 18, 100, 556 + 100 + 18, 403);


            //draw horizonal
            //e.Graphics.DrawLine(Pen, x, y, x, y);
            e.Graphics.DrawLine(Pen, 420, 176 + 13, 788, 176 + 13);
            e.Graphics.DrawLine(Pen, 420, 176 + 13 + 100 + 13, 788, 176 + 13 + 100 + 13);




        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //pb_00
            char ch = grid[0, 0];
            if (ch == '.')
            {
                if (turn == 1)
                {
                    grid[0, 0] = 'X';
                    pb_00.Image = Resources.X;
                }
                else
                {
                    grid[0, 0] = 'O';
                    pb_00.Image = Resources.O;
                }

                char winner = check_winner();
                if (winner != '.')
                {
                    if (winner == 'X')
                    {
                        lbl_winner.Text = "Player 1 ";
                    }
                    else
                    {
                        lbl_winner.Text = "Player 2 ";
                    }
                    lbl_turn.Text = "Game Over";
                    show_win_spots();
                    lock_board();
                    return;
                }
                if (check_draw())
                {
                    lbl_turn.Text = "Game Over";
                    lbl_winner.Text = "Draw";
                    lock_board();
                    return;
                }

                turn *= -1;
                if (turn == 1)
                {
                    lbl_turn.Text = "Player 1";
                }
                else
                {
                    lbl_turn.Text = "Player 2";
                }
            }
            else
            {
                MessageBox.Show("Cannot choose this", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbl_turn.Text = "Player 1 ";
            turn = 1;
            lbl_winner.Text = "In Progress";

            pb_00.Enabled = true;
            pb_01.Enabled = true;
            pb_02.Enabled = true;

            pb_10.Enabled = true;
            pb_11.Enabled = true;
            pb_12.Enabled = true;

            pb_20.Enabled = true;
            pb_21.Enabled = true;
            pb_22.Enabled = true;

            //Change pb to ?
            pb_00.Image = Resources.question_mark_96;
            pb_01.Image = Resources.question_mark_96;
            pb_02.Image = Resources.question_mark_96;

            pb_10.Image = Resources.question_mark_96;
            pb_11.Image = Resources.question_mark_96;
            pb_12.Image = Resources.question_mark_96;

            pb_20.Image = Resources.question_mark_96;
            pb_21.Image = Resources.question_mark_96;
            pb_22.Image = Resources.question_mark_96;

            //remove green colors

            pb_00.BackColor = Color.Black;
            pb_01.BackColor = Color.Black;
            pb_02.BackColor = Color.Black;

            pb_10.BackColor = Color.Black;
            pb_11.BackColor = Color.Black;
            pb_12.BackColor = Color.Black;

            pb_20.BackColor = Color.Black;
            pb_21.BackColor = Color.Black;
            pb_22.BackColor = Color.Black;

            for (int r = 0; r < 3; r++)
            {
                for(int c= 0; c < 3; c++)
                {
                    grid[r, c] = '.';
                }
            }
        }

        private void pb_01_Click(object sender, EventArgs e)
        {
            //pb_01
            char ch = grid[0, 1];
            if (ch == '.')
            {
                if (turn == 1)
                {
                    grid[0, 1] = 'X';
                    pb_01.Image = Resources.X;
                }
                else
                {
                    grid[0, 1] = 'O';
                    pb_01.Image = Resources.O;
                }
                char winner = check_winner();
                if (winner != '.')
                {
                    if (winner == 'X')
                    {
                        lbl_winner.Text = "Player 1 ";
                    }
                    else
                    {
                        lbl_winner.Text = "Player 2 ";
                    }
                    lbl_turn.Text = "Game Over";
                    show_win_spots();
                    lock_board();
                    return;
                }
                if (check_draw())
                {
                    lbl_turn.Text = "Game Over";
                    lbl_winner.Text = "Draw";
                    lock_board();
                    return;
                }
                turn *= -1;
                if (turn == 1)
                {
                    lbl_turn.Text = "Player 1";
                }
                else
                {
                    lbl_turn.Text = "Player 2";
                }
            }
            else
            {
                MessageBox.Show("Cannot choose this", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pb_02_Click(object sender, EventArgs e)
        {
            //pb_02
            char ch = grid[0, 2];
            if (ch == '.')
            {
                if (turn == 1)
                {
                    grid[0, 2] = 'X';
                    pb_02.Image = Resources.X;
                }
                else
                {
                    grid[0, 2] = 'O';
                    pb_02.Image = Resources.O;
                }
                char winner = check_winner();
                if (winner != '.')
                {
                    if (winner == 'X')
                    {
                        lbl_winner.Text = "Player 1 ";
                    }
                    else
                    {
                        lbl_winner.Text = "Player 2 ";
                    }
                    lbl_turn.Text = "Game Over";
                    show_win_spots();
                    lock_board();
                    return;
                }
                if (check_draw())
                {
                    lbl_turn.Text = "Game Over";
                    lbl_winner.Text = "Draw";
                    lock_board();
                    return;
                }
                turn *= -1;
                if (turn == 1)
                {
                    lbl_turn.Text = "Player 1";
                }
                else
                {
                    lbl_turn.Text = "Player 2";
                }
            }
            else
            {
                MessageBox.Show("Cannot choose this", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pb_10_Click(object sender, EventArgs e)
        {
            //pb_10
            char ch = grid[1, 0];
            if (ch == '.')
            {
                if (turn == 1)
                {
                    grid[1, 0] = 'X';
                    pb_10.Image = Resources.X;
                }
                else
                {
                    grid[1, 0] = 'O';
                    pb_10.Image = Resources.O;
                }
                char winner = check_winner();
                if (winner != '.')
                {
                    if (winner == 'X')
                    {
                        lbl_winner.Text = "Player 1 ";
                    }
                    else
                    {
                        lbl_winner.Text = "Player 2 ";
                    }
                    lbl_turn.Text = "Game Over";
                    show_win_spots();
                    lock_board();
                    return;
                }
                if (check_draw())
                {
                    lbl_turn.Text = "Game Over";
                    lbl_winner.Text = "Draw";
                    lock_board();
                    return;
                }
                turn *= -1;
                if (turn == 1)
                {
                    lbl_turn.Text = "Player 1";
                }
                else
                {
                    lbl_turn.Text = "Player 2";
                }
            }
            else
            {
                MessageBox.Show("Cannot choose this", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pb_11_Click(object sender, EventArgs e)
        {
            //pb_11
            char ch = grid[1, 1];
            if (ch == '.')
            {
                if (turn == 1)
                {
                    grid[1, 1] = 'X';
                    pb_11.Image = Resources.X;
                }
                else
                {
                    grid[1, 1] = 'O';
                    pb_11.Image = Resources.O;
                }
                char winner = check_winner();
                if (winner != '.')
                {
                    if (winner == 'X')
                    {
                        lbl_winner.Text = "Player 1 ";
                    }
                    else
                    {
                        lbl_winner.Text = "Player 2 ";
                    }
                    lbl_turn.Text = "Game Over";
                    show_win_spots();
                    lock_board();
                    return;
                }
                if (check_draw())
                {
                    lbl_turn.Text = "Game Over";
                    lbl_winner.Text = "Draw";
                    lock_board();
                    return;
                }
                turn *= -1;
                if (turn == 1)
                {
                    lbl_turn.Text = "Player 1";
                }
                else
                {
                    lbl_turn.Text = "Player 2";
                }
            }
            else
            {
                MessageBox.Show("Cannot choose this", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pb_12_Click(object sender, EventArgs e)
        {
            //pb_12
            char ch = grid[1, 2];
            if (ch == '.')
            {
                if (turn == 1)
                {
                    grid[1, 2] = 'X';
                    pb_12.Image = Resources.X;
                }
                else
                {
                    grid[1, 2] = 'O';
                    pb_12.Image = Resources.O;
                }
                char winner = check_winner();
                if (winner != '.')
                {
                    if (winner == 'X')
                    {
                        lbl_winner.Text = "Player 1 ";
                    }
                    else
                    {
                        lbl_winner.Text = "Player 2 ";
                    }
                    lbl_turn.Text = "Game Over";
                    show_win_spots();
                    lock_board();
                    return;
                }
                if (check_draw())
                {
                    lbl_turn.Text = "Game Over";
                    lbl_winner.Text = "Draw";
                    lock_board();
                    return;
                }
                turn *= -1;
                if (turn == 1)
                {
                    lbl_turn.Text = "Player 1";
                }
                else
                {
                    lbl_turn.Text = "Player 2";
                }
            }
            else
            {
                MessageBox.Show("Cannot choose this", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pb_20_Click(object sender, EventArgs e)
        {
            //pb_20
            char ch = grid[2, 0];
            if (ch == '.')
            {
                if (turn == 1)
                {
                    grid[2, 0] = 'X';
                    pb_20.Image = Resources.X;
                }
                else
                {
                    grid[2, 0] = 'O';
                    pb_20.Image = Resources.O;
                }
                char winner = check_winner();
                if (winner != '.')
                {
                    if (winner == 'X')
                    {
                        lbl_winner.Text = "Player 1 ";
                    }
                    else
                    {
                        lbl_winner.Text = "Player 2 ";
                    }
                    lbl_turn.Text = "Game Over";
                    show_win_spots();
                    lock_board();
                    return;
                }
                if (check_draw())
                {
                    lbl_turn.Text = "Game Over";
                    lbl_winner.Text = "Draw";
                    lock_board();
                    return;
                }
                turn *= -1;
                if (turn == 1)
                {
                    lbl_turn.Text = "Player 1";
                }
                else
                {
                    lbl_turn.Text = "Player 2";
                }
            }
            else
            {
                MessageBox.Show("Cannot choose this", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pb_21_Click(object sender, EventArgs e)
        {
            //pb_21
            char ch = grid[2, 1];
            if (ch == '.')
            {
                if (turn == 1)
                {
                    grid[2, 1] = 'X';
                    pb_21.Image = Resources.X;
                }
                else
                {
                    grid[2, 1] = 'O';
                    pb_21.Image = Resources.O;
                }
                char winner = check_winner();
                if (winner != '.')
                {
                    if (winner == 'X')
                    {
                        lbl_winner.Text = "Player 1 ";
                    }
                    else
                    {
                        lbl_winner.Text = "Player 2 ";
                    }
                    lbl_turn.Text = "Game Over";
                    show_win_spots();
                    lock_board();
                    return;
                }
                if (check_draw())
                {
                    lbl_turn.Text = "Game Over";
                    lbl_winner.Text = "Draw";
                    lock_board();
                    return;
                }
                turn *= -1;
                if (turn == 1)
                {
                    lbl_turn.Text = "Player 1";
                }
                else
                {
                    lbl_turn.Text = "Player 2";
                }
            }
            else
            {
                MessageBox.Show("Cannot choose this", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void pb_22_Click(object sender, EventArgs e)
        {
            //pb_22
            char ch = grid[2, 2];
            if (ch == '.')
            {
                if (turn == 1)
                {
                    grid[2, 2] = 'X';
                    pb_22.Image = Resources.X;
                }
                else
                {
                    grid[2, 2] = 'O';
                    pb_22.Image = Resources.O;
                }
                char winner = check_winner();
                if (winner != '.')
                {
                    if (winner == 'X')
                    {
                        lbl_winner.Text = "Player 1 ";
                    }
                    else
                    {
                        lbl_winner.Text = "Player 2 ";
                    }
                    lbl_turn.Text = "Game Over";
                    show_win_spots();
                    lock_board();
                    return;
                }
                if (check_draw())
                {
                    lbl_turn.Text = "Game Over";
                    lbl_winner.Text = "Draw";
                    lock_board();
                    return;
                }
                turn *= -1;
                if (turn == 1)
                {
                    lbl_turn.Text = "Player 1";
                }
                else
                {
                    lbl_turn.Text = "Player 2";
                }
            }
            else
            {
                MessageBox.Show("Cannot choose this", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lbl_winner_Click(object sender, EventArgs e)
        {

        }
        private void lock_board()
        {
            pb_00.Enabled = false;
            pb_01.Enabled = false;
            pb_02.Enabled = false;

            pb_10.Enabled = false;
            pb_11.Enabled = false;
            pb_12.Enabled = false;

            pb_20.Enabled = false;
            pb_21.Enabled = false;
            pb_22.Enabled = false;
        }
        private void show_win_spots()
        {
            if (win_row != -1)
            {
                if (win_row == 0)
                {
                    pb_00.BackColor = Color.Green;
                    pb_01.BackColor = Color.Green;
                    pb_02.BackColor = Color.Green;
                }
                else if (win_row == 1)
                {
                    pb_10.BackColor = Color.Green;
                    pb_11.BackColor = Color.Green;
                    pb_12.BackColor = Color.Green;
                }
                else
                {
                    pb_20.BackColor = Color.Green;
                    pb_21.BackColor = Color.Green;
                    pb_22.BackColor = Color.Green;
                }
            }

            if (win_col != -1)
            {
                if (win_col == 0)
                {
                    pb_00.BackColor = Color.Green;
                    pb_10.BackColor = Color.Green;
                    pb_20.BackColor = Color.Green;
                }
                else if(win_col == 1)
                {
                    pb_01.BackColor = Color.Green;
                    pb_11.BackColor = Color.Green;
                    pb_21.BackColor = Color.Green;
                }
                else 
                {
                    pb_02.BackColor = Color.Green;
                    pb_12.BackColor = Color.Green;
                    pb_22.BackColor = Color.Green;
                }

            }
            if (win_diagonal != -1) 
            {
                if (win_diagonal == 1) 
                {
                    pb_00.BackColor= Color.Green;
                    pb_11.BackColor= Color.Green;
                    pb_22.BackColor= Color.Green;
                }
                else
                {
                    pb_02.BackColor = Color.Green;
                    pb_11.BackColor = Color.Green;
                    pb_20.BackColor = Color.Green;
                }
            }
        }

    }
}
