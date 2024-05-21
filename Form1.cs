using System.Diagnostics.Eventing.Reader;
using System.Numerics;
using System.Runtime.CompilerServices;


namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private enum State
        {
            Xwin,
            Owin,
            draw,
            playing
        }

        private int count = 0;
        private string[,] matrix = new string[3, 3];
        private string turn = "O";
        

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            update();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void update()
        {
            DialogResult result;
            c11.Text = matrix[0, 0];
            c12.Text = matrix[0, 1];
            c13.Text = matrix[0, 2];
            c21.Text = matrix[1, 0];
            c22.Text = matrix[1, 1];
            c23.Text = matrix[1, 2];
            c31.Text = matrix[2, 0];
            c32.Text = matrix[2, 1];
            c33.Text = matrix[2, 2];

            // Update `turn`
            if (turn == "O")
            {
                turn = "X";
            }
            else
            {
                turn = "O";
            }
            turnLabel.Text = $"Turn: {turn}";
            State state = checkGameState();
            if (state == State.Owin || state == State.Xwin)
            {
                result = MessageBox.Show(
                    $"{(state == State.Owin ? 'O' : 'X')} won! Do you want to play again?",
                    "", 
                    MessageBoxButtons.YesNo
                );
                if (result == DialogResult.Yes)
                {
                    reset();
                }
                else
                {
                    this.Close();
                }

            }
            if (state == State.draw)
            {
                result = MessageBox.Show(
                    "It was a draw! Do you want to play again?",
                    "",
                    MessageBoxButtons.YesNo
                );
                if (result == DialogResult.Yes)
                {
                    reset();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void reset()
        {
            matrix = new string[3, 3];
            turn = "X";
            update();
        }

        private State checkGameState()
        {
            // Column Check
            for (int col = 0; col <= 2; col++)
            {
                if (matrix[col, 0] == matrix[col, 1] && matrix[col, 1] == matrix[col, 2])
                {
                    if (matrix[col, 0] == "O")
                    {
                        return State.Owin;
                    }
                    else if (matrix[col, 0] == "X")
                    {
                        return State.Xwin;
                    }
                }
            }

            // Row Check
            for (int row = 0; row <= 2; row++)
            {
                if (matrix[0, row] == matrix[1, row] && matrix[1, row] == matrix[2, row])
                {
                    if (matrix[0, row] == "O")
                    {
                        return State.Owin;
                    }
                    else if (matrix[0, row] == "X")
                    {
                        return State.Xwin;
                    }
                }
            }

            // Left Diagonal Check
            if (matrix[0, 0] == matrix[1, 1] && matrix[1, 1] == matrix[2, 2])
            {
                if (matrix[0, 0] == "O")
                {
                    return State.Owin;
                }
                else if (matrix[0, 0] == "X")
                {
                    return State.Xwin;
                }
            }

            // Right Diagonal Check
            if (matrix[2, 0] == matrix[1, 1] && matrix[1, 1] == matrix[0, 2])
            {
                if (matrix[2, 0] == "O")
                {
                    return State.Owin;
                }
                else if (matrix[2, 0] == "X")
                {
                    return State.Xwin;
                }
            }

            // Draw Check

            // Let's assume that there are no more moves left
            bool movesLeft = false;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] != "X" && matrix[row, col] != "O")
                    {
                        // We found an empty cell and now there are moves left
                        movesLeft = true;
                        break;
                    }
                }               

            }


            if (!movesLeft)
            {
                return State.draw;
            }
            return State.playing;
        }
            // Buttons in matrix
            void c11_Click(object sender, EventArgs e)
        {
            matrix[0, 0] = turn;
            update();
        }


        void c12_Click(object sender, EventArgs e)
        {
            matrix[0, 1] = turn;
            update();
        }

        void c13_Click(object sender, EventArgs e)
        {
            matrix[0, 2] = turn;
            update();
        }

        void c21_Click(object sender, EventArgs e)
        {
            matrix[1, 0] = turn;
            update();
        }

        void c22_Click(object sender, EventArgs e)
        {
            matrix[1, 1] = turn;
            update();
        }

        void c23_Click(object sender, EventArgs e)
        {
            matrix[1, 2] = turn;
            update();
        }

        void c31_Click(object sender, EventArgs e)
        {
            matrix[2, 0] = turn;
            update();
        }

        void c32_Click(object sender, EventArgs e)
        {
            matrix[2, 1] = turn;
            update();
        }

        void c33_Click(object sender, EventArgs e)
        {
            matrix[2, 2] = turn;
            update();
        }

        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string message =
                "Are you sure that you would like to close the form?";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.No)
            {
                // cancel the closure of the form.
                e.Cancel = true;
            }
        }
    }
}
