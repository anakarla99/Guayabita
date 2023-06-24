using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SnakeProject;
using System.IO;

namespace SnakeProject
{
    public partial class Game : Form
    { 
        public Game()
        {
            InitializeComponent();
        }
        bool IsStarted;
        public bool GameOver;
        Board board;
        Eggs egg;
        Snake snake = new Snake();
        Directions direction;
        int eggAmount;
        int score;
        
        private void btGB_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 window1 = new Form1();
            window1.Show();
        }

        private void pbxWorld_Paint(object sender, PaintEventArgs e)
        {
            if (!IsStarted) return;
            Graphics g = e.Graphics;
            float CelWidth = (pbxWorld.Width - 1f) / board.WorldWidth;
            float CelHeight = (pbxWorld.Height - 1f) / board.WorldHeigth;

            float obstSizeX = CelWidth * 0.9f;
            float obstSizeY = CelHeight * 0.9f;

            float focusObstX = (CelWidth - obstSizeX) / 2f;
            float focusObstY = (CelHeight - obstSizeY) / 2f;

            float eggSizeX = Math.Min(CelHeight, CelWidth) * 0.6f;
            float eggSizeY = CelHeight * 0.9f;

            float focuseggX = (CelWidth - eggSizeX) / 2f;
            float focuseggY = (CelHeight - eggSizeY) / 2f;

            if (egg.NoEgg(board.floor))
            {
                if (!WinGame())
                {
                    egg = new Eggs(board, eggAmount);
                    board.floor = egg.PutEggs();
                }
                else
                {
                    Form win = new Win();
                    win.Show();
                }
            }
            board.floor = snake.CreateSnake(board.floor);

            float snakeSizeX = CelWidth * 0.9f;
            float snakeSizeY = CelHeight * 0.9f;
            float focusSnakeX = (CelWidth - snakeSizeX) / 2f;
            float focusSnakeY = (CelHeight - snakeSizeY) / 2f;
            for (int i = 0; i < board.floor.GetLength(0); i++)
            {
                for (int j = 0; j < board.floor.GetLength(1); j++)
                {
                    if (board.floor[i, j] == Board.WorldStuff.obstacle)
                        g.FillRectangle(Brushes.Gray, CelWidth * j + focusObstX, CelHeight * i + focusObstY, obstSizeX, obstSizeY);
                    if (board.floor[i, j] == Board.WorldStuff.egg)
                    {
                        g.FillEllipse(Brushes.Orange, CelWidth * j + focuseggX, CelHeight * i + focuseggY, eggSizeX, eggSizeY);
                        int s = egg.EggNumber(i, j);
                        g.DrawString(s.ToString(), DefaultFont, Brushes.Black, CelWidth * j + (CelWidth - DefaultFont.Height)/2f , CelHeight * i + (CelHeight - DefaultFont.Height ) / 2f);
                    }
                    if (board.floor[i, j] == Board.WorldStuff.SnakeHead || board.floor[i, j] == Board.WorldStuff.SnakeBody || board.floor[i, j] == Board.WorldStuff.SnakeTail)
                     g.FillRectangle(Brushes.Green, CelWidth * j + focusSnakeX, CelHeight * i + focusSnakeY, snakeSizeX, snakeSizeY);
                    
                }
            }
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btStartGame_Click(object sender, EventArgs e)
        {
            IsStarted = true;
            GameOver = false;
            board = new Board(15, 15);
            board.floor = Board.PutRandomObstacles(board.WorldHeigth, board.WorldWidth);
            eggAmount = 3;
            egg = new Eggs(board, eggAmount);
            snake = new Snake();
            timer1.Stop();
            direction = Directions.Nothing;
            ActiveControl = null;
            score = 0;
            lblscore.Text = score.ToString();
            pbxWorld.Invalidate();
        }

        private void Game_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            e.IsInputKey = true;
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Down:;
                    if(direction != Directions.Up)
                        direction = Directions.Down;
                    break;
                case Keys.Right:
                    if (direction != Directions.Left)
                        direction = Directions.Right;
                    break;
                case Keys.Up:
                    if (direction != Directions.Down)
                        direction = Directions.Up;
                    break;
                case Keys.Left:
                    if (direction != Directions.Right)
                        direction = Directions.Left;
                    break;
            }
            timer1.Start();
            pbxWorld.Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //En cada movimiento lo que se hace es borrar las posiciones de la cabeza y la cola, comprobar la siguiente casilla y moverse si se puede
            int x = snake.Headx;
            int y = snake.Heady;
            switch (direction)
            {
                case Directions.Down:
                        board.floor[x, y] = Board.WorldStuff.empty;
                        board.floor[snake.Tailx, snake.Taily] = Board.WorldStuff.empty;
                        x = (x + 1) % board.WorldWidth;
                        CheckNext(x, y);
                    if (!GameOver)
                    {
                        score += egg.Score(x, y, board.floor) * 100;
                        snake.Movement(x, y);
                        board.floor[x, y] = Board.WorldStuff.SnakeHead;
                        for (int i = 1; i < snake.SnakeBody.GetLength(1) - 1; i++)
                        {
                            int tempx = snake.SnakeBody[0, i];
                            int tempy = snake.SnakeBody[1, i];
                            board.floor[tempx, tempy] = Board.WorldStuff.SnakeBody;
                        }
                        board.floor[snake.Tailx, snake.Taily] = Board.WorldStuff.SnakeTail;
                    }
                    break;
                case Directions.Right:
                        board.floor[x, y] = Board.WorldStuff.empty;
                        board.floor[snake.Tailx, snake.Taily] = Board.WorldStuff.empty;
                        y = (y + 1) % board.WorldHeigth;
                        CheckNext(x, y);
                    if (!GameOver)
                    {
                        score += egg.Score(x, y, board.floor) * 100;
                        snake.Movement(x, y);
                        board.floor[x, y] = Board.WorldStuff.SnakeHead;
                        for (int i = 1; i < snake.SnakeBody.GetLength(1) - 1; i++)
                        {
                            int tempx = snake.SnakeBody[0, i];
                            int tempy = snake.SnakeBody[1, i];
                            board.floor[tempx, tempy] = Board.WorldStuff.SnakeBody;
                        }
                        board.floor[snake.Tailx, snake.Taily] = Board.WorldStuff.SnakeTail;
                    }
                    break;
                case Directions.Up:
                        board.floor[x, y] = Board.WorldStuff.empty;
                        board.floor[snake.Tailx, snake.Taily] = Board.WorldStuff.empty;
                        x = (x - 1 + board.WorldWidth) % board.WorldWidth;
                        CheckNext(x, y);
                    if (!GameOver)
                    {
                        score += egg.Score(x, y, board.floor) * 100;
                        snake.Movement(x, y);
                        board.floor[x, y] = Board.WorldStuff.SnakeHead;
                        for (int i = 1; i < snake.SnakeBody.GetLength(1) - 1; i++)
                        {
                            int tempx = snake.SnakeBody[0, i];
                            int tempy = snake.SnakeBody[1, i];
                            board.floor[tempx, tempy] = Board.WorldStuff.SnakeBody;
                        }
                        board.floor[snake.Tailx, snake.Taily] = Board.WorldStuff.SnakeTail;
                    }
                    break;
                case Directions.Left:
                        board.floor[x, y] = Board.WorldStuff.empty;
                        board.floor[snake.Tailx, snake.Taily] = Board.WorldStuff.empty;
                        y = (y - 1 + board.WorldHeigth) % board.WorldHeigth;
                        CheckNext(x, y);
                    if (!GameOver)
                    {
                        score += egg.Score(x, y, board.floor) * 100;
                        snake.Movement(x, y);
                        board.floor[x, y] = Board.WorldStuff.SnakeHead;
                        for (int i = 1; i < snake.SnakeBody.GetLength(1) - 1; i++)
                        {
                            int tempx = snake.SnakeBody[0, i];
                            int tempy = snake.SnakeBody[1, i];
                            board.floor[tempx, tempy] = Board.WorldStuff.SnakeBody;
                        }
                        board.floor[snake.Tailx, snake.Taily] = Board.WorldStuff.SnakeTail;
                    }
                    break;
            }
            lblscore.Text = score.ToString();
            pbxWorld.Invalidate();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btOpenWorld_Click(object sender, EventArgs e)
        {
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                string[] read = File.ReadAllLines(OpenFile.FileName);
                board = new Board(int.Parse(read[0]), int.Parse(read[1]));
                eggAmount = int.Parse(read[2]);
                egg = new Eggs(board, eggAmount);
                timer1.Interval = int.Parse(read[3]);
                for (int i = 4; i < read.Length; i++)
                {
                    char[] asd = { ' ' };
                    string[] temp = read[i].Split(asd,StringSplitOptions.RemoveEmptyEntries);
                    board.floor[int.Parse(temp[0]), int.Parse(temp[1])] = Board.WorldStuff.obstacle;
                }
                IsStarted = true;
                GameOver = false;
                snake = new Snake();
                timer1.Stop();
                direction = Directions.Nothing;
                ActiveControl = null;
                score = 0;
                lblscore.Text = score.ToString();
                pbxWorld.Invalidate();
            }
        }

        /// <summary>
        /// Este metodo es para comprobar que es la siguiente casilla en la que se va a mover la serpiente
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="a"></param>
        /// <param name="e"></param>
        public void CheckNext(int x, int y)
        {
            if (board.floor[x, y] == Board.WorldStuff.obstacle || board.floor[x, y] == Board.WorldStuff.SnakeBody)
            {
                GameOver = true;
                board.floor[snake.Headx, snake.Heady] = Board.WorldStuff.SnakeHead;
                board.floor[snake.Tailx, snake.Taily] = Board.WorldStuff.SnakeTail;
                timer1.Stop();
                Form gameOver = new GameOver();
                gameOver.Show();
                pbxWorld.Invalidate();
            }

            if (board.floor[x, y] == Board.WorldStuff.egg)
                snake.Growth(x, y, board.floor, egg);
        }

        public bool WinGame()
        {
            int count = 0;
            for (int i = 0; i < board.floor.GetLength(0); i++)
            {
                for (int j = 0; j < board.floor.GetLength(1); j++)
                {
                    if (board.floor[i, j] == Board.WorldStuff.empty)
                        count++;
                }
            }
            if (count < eggAmount)
                return true;
            return false;
        }
    }
}
