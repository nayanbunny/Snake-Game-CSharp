using Snake.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Snake
{
    /// <summary>
    /// Snake Form
    /// </summary>
    public partial class SnakeForm : Form
    {
        /// <summary>
        /// Field Columns, Field Rows, Snake Length, Piece Size, Field Top Start Position Constants
        /// </summary>
        private const int columns = 40, rows = 30, snakeLength = rows * columns, pieceSize = 20, fieldTopStart = 60, additionalWidthOnForm = 16;
        /// <summary>
        /// Score, Next Step Distance X, Next Step Distance Y, Head Index, Tail Index Fields
        /// </summary>
        private int score = 0, nextStepDistanceX = 0, nextStepDistanceY = 0, headIndex = 0, tailIndex = 0;
        /// <summary>
        /// Game Pause Status Field
        /// </summary>
        private bool gamePaused = false;
        /// <summary>
        /// Field Cells Visit Status
        /// </summary>
        private bool[,] fieldCellsVisitStatus;
        /// <summary>
        /// Snake Object
        /// </summary>
        Piece[] snake = new Piece[snakeLength];
        /// <summary>
        /// Available Field Cells
        /// </summary>
        private readonly List<int> availableFieldCells = new List<int>();
        /// <summary>
        /// Random Number Generator Object
        /// </summary>
        private readonly Random random = new Random();

        /// <summary>
        /// Snake Form Constructor
        /// </summary>
        public SnakeForm()
        {
            InitializeComponent();
            InitializeSnake();
            timer.Start();
        }

        #region Timer Events

        /// <summary>
        /// Timer Tick Event
        /// </summary>
        /// <param name="sender">The Sender</param>
        /// <param name="e">The Event Args</param>
        private void Timer_Tick(object sender, EventArgs e) => MoveSnake();

        #endregion

        #region Keyboard Events

        /// <summary>
        /// Keyboard Navigation Event
        /// </summary>
        /// <param name="sender">The Sender</param>
        /// <param name="e">The Key Event Args</param>
        private void SnakeForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Checking Space and Enter Key Down
            if (e.KeyCode == Keys.Space)
            {
                gamePaused = !gamePaused;
                if (gamePaused) timer.Stop();
                else timer.Start();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                ResetTheGame();
                InitializeSnake();
                timer.Start();
            }

            // Assigning Next Step Distance based on pressed Arrow Key
            (nextStepDistanceX, nextStepDistanceY) = e.KeyCode switch
            {
                Keys.Right => (pieceSize, 0),
                Keys.Left => (-pieceSize, 0),
                Keys.Up => (0, -pieceSize),
                Keys.Down => (0, pieceSize),
                _ => (0, 0)
            };
        }

        #endregion

        #region Snake Events

        /// <summary>
        /// Initializing Snake Element on UI
        /// </summary>
        private void InitializeSnake()
        {
            fieldCellsVisitStatus = new bool[rows, columns];
            Piece headPiece = new Piece(random.Next() % columns * pieceSize, random.Next() % rows * pieceSize);
            lblFood.Location = new Point(random.Next() % columns * pieceSize, random.Next() % rows * pieceSize);

            headPiece.Top = headPiece.Location.Y < fieldTopStart ? headPiece.Top = fieldTopStart : headPiece.Top;
            lblFood.Top = lblFood.Location.Y < fieldTopStart ? lblFood.Top = fieldTopStart : lblFood.Top;

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                {
                    fieldCellsVisitStatus[i, j] = false;
                    availableFieldCells.Add(i * columns + j);
                }

            fieldCellsVisitStatus[(headPiece.Location.Y) / pieceSize, headPiece.Location.X / pieceSize] = true;
            availableFieldCells.Remove((headPiece.Location.Y) / pieceSize * columns + headPiece.Location.X / pieceSize);
            Controls.Add(headPiece);
            snake[headIndex] = headPiece;
        }

        /// <summary>
        /// Snake Move Action
        /// </summary>
        private void MoveSnake()
        {
            int positionX = snake[headIndex].Location.X, positionY = snake[headIndex].Location.Y;
            int nextPositionX = positionX + nextStepDistanceX, nextPositionY = positionY + nextStepDistanceY;

            // Checking Not Moved
            if (nextStepDistanceX == 0 && nextStepDistanceY == 0) return;

            // Game Over Check
            if (GameOver(nextPositionX, nextPositionY))
            {
                timer.Stop();
                MessageBox.Show("Game Over.");
                return;
            }

            // Self Collision Check
            if (SelfCollision(nextPositionY / pieceSize, nextPositionX / pieceSize))
                return;

            // Food Collision Check
            if (FoodCollision(nextPositionX, nextPositionY))
            {
                // Score Increment
                score++;
                lblScore.Text = (score * 10).ToString();

                // New Body Piece of Snake in Food Position
                Piece headPiece = new Piece(nextPositionX, nextPositionY);
                headIndex = (headIndex - 1 + snakeLength) % snakeLength;
                snake[headIndex] = headPiece;
                fieldCellsVisitStatus[headPiece.Location.Y / pieceSize, headPiece.Location.X / pieceSize] = true;
                Controls.Add(headPiece);
                // Generate new Random Food
                GenerateFood();
                // Speed Increment on Food Consume
                IncreaseSpeed();
            }
            else
            {
                // Maintain Snake Body Locations and Move Forward
                fieldCellsVisitStatus[snake[tailIndex].Location.Y / pieceSize, snake[tailIndex].Location.X / pieceSize] = false;
                headIndex = (headIndex - 1 + snakeLength) % snakeLength;
                snake[headIndex] = snake[tailIndex];
                snake[headIndex].Location = new Point(nextPositionX, nextPositionY);
                tailIndex = (tailIndex - 1 + snakeLength) % snakeLength;
                fieldCellsVisitStatus[nextPositionY / pieceSize, nextPositionX / pieceSize] = true;
            }
        }

        /// <summary>
        /// Self Collision Validation
        /// </summary>
        /// <param name="positionX">The X Position</param>
        /// <param name="positionY">The Y Position</param>
        /// <returns><c>true</c> if the snake collide itself; otherwise, <c>false</c></returns>
        private bool SelfCollision(int positionX, int positionY)
        {
            if (!fieldCellsVisitStatus[positionX, positionY])
                return false;

            timer.Stop();
            MessageBox.Show("Snake hits body. Game Over.");
            return true;
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Generate Random Food
        /// </summary>
        private void GenerateFood()
        {
            availableFieldCells.Clear();

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    if (!fieldCellsVisitStatus[i, j])
                        availableFieldCells.Add(i * columns + j);

            // Generating Food where snake body is not there.
            int index = random.Next(availableFieldCells.Count) % availableFieldCells.Count;
            lblFood.Left = availableFieldCells[index] * pieceSize % (Width - additionalWidthOnForm);
            lblFood.Top = availableFieldCells[index] * pieceSize / (Width - additionalWidthOnForm) * pieceSize;
            lblFood.Top = lblFood.Top < fieldTopStart ? lblFood.Top + fieldTopStart : lblFood.Top;
        }

        /// <summary>
        /// Speed Increment
        /// </summary>
        private void IncreaseSpeed()
        {
            timer.Interval -= timer.Interval * Convert.ToInt32(lblScore.Text) / snakeLength;
            timer.Interval = timer.Interval > 0 ? timer.Interval : 0;
        }

        /// <summary>
        /// Reset the Game
        /// </summary>
        private void ResetTheGame()
        {
            ClearTheField();
            headIndex = 0;
            tailIndex = 0;
            availableFieldCells.Clear();
            snake = new Piece[snakeLength];
            lblScore.Text = 0.ToString();
            timer.Interval = 100;
        }

        /// <summary>
        /// Clear the Game Field
        /// </summary>
        private void ClearTheField()
        {
            for (var i = Controls.Count - 1; i > 1; i--)
                Controls.RemoveAt(i);
        }

        /// <summary>
        /// Collision with Food.
        /// </summary>
        /// <param name="positionX">The X Position</param>
        /// <param name="positionY">The Y Position</param>
        /// <returns><c>true</c> if the snake collide with food; otherwise, <c>false</c></returns>
        private bool FoodCollision(int positionX, int positionY)
            => positionX == lblFood.Location.X && positionY == lblFood.Location.Y;

        /// <summary>
        /// Check Game Over if snake collides with corners.
        /// </summary>
        /// <param name="positionX">The X Position</param>
        /// <param name="positionY">The Y Position</param>
        /// <returns><c>true</c> if the snake hit corners; otherwise, <c>false</c></returns>
        private bool GameOver(int positionX, int positionY)
            => positionX < 0 || positionY < 60 || positionX > 780 || positionY > 580;

        #endregion
    }
}