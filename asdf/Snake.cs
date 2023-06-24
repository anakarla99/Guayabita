using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnakeProject;

namespace SnakeProject
{
    class Snake
    {
        public int Headx;
        public int Heady;
        public int Bodyx;
        public int Bodyy;
        public int Tailx;
        public int Taily;
        public int[,] SnakeBody;
        public  Board.WorldStuff[,] CreateSnake(Board.WorldStuff[,] a)
        {
            bool sePuso = false;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] == Board.WorldStuff.SnakeHead)
                        sePuso = true;
                }
            }
            while (!sePuso)
            {
                Random r = new Random();
                Headx = r.Next(a.GetLength(0));
                Heady = r.Next(a.GetLength(1));
                if (a[Headx, Heady] == Board.WorldStuff.empty)
                {
                    a[Headx, Heady] = Board.WorldStuff.SnakeHead;
                    SnakeBody[0, 0] = Headx;
                    SnakeBody[1, 0] = Heady;
                    Tailx = Headx;
                    Taily = Heady;
                    SnakeBody[0, 1] = Tailx;
                    SnakeBody[1, 1] = Taily;
                    Bodyx = Headx;
                    Bodyy = Heady;
                sePuso = true;
            }
        }
            return a;
        }
        /// <summary>
        /// Este método dado una x y una y hace que la serpiente avance
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void Movement(int x, int y)
        {
            //Primero actualizo desde el final hasta el primer cuerpo que tengo en el array de serpiente
            for (int i = SnakeBody.GetLength(1) - 1; i > 0; i--)
            {
                SnakeBody[0, i] = SnakeBody[0, i - 1];
                SnakeBody[1, i] = SnakeBody[1, i - 1];
            }
            //Luego actualizo la cabeza y con los nuevos valores
            Headx = x;
            Heady = y;
            SnakeBody[0, 0] = x;
            SnakeBody[1, 0] = y;
            Tailx = SnakeBody[0, SnakeBody.GetLength(1) - 1];
            Taily = SnakeBody[1, SnakeBody.GetLength(1) - 1];
        }

        /// <summary>
        /// Este método hace crecer el array bidimensional de la serpiente
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="a"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public int[,] Growth(int x, int y, Board.WorldStuff[,] a, Eggs e)
        {
            int s = e.EggNumber(x, y);
            int[,] snakeBody = new int[2, SnakeBody.GetLength(1) + s];
            //Los cuerpos nuevos que se anaden a la serpiente van a tomar en primera instacia la x y la y de la cabeza
            Bodyx = Headx;
            Bodyy = Heady;
            //Como creo un nuevo array, copio las posiciones de la cabeza, cola y cuerpos que estaban anteriormente
            snakeBody[0, 0] = Headx;
            snakeBody[1, 0] = Heady;
            snakeBody[0, SnakeBody.GetLength(1) - 1] = Tailx;
            snakeBody[1, SnakeBody.GetLength(1) - 1] = Taily;
            for (int i = s; i < snakeBody.GetLength(1); i++)
            {
                snakeBody[0, i] = SnakeBody[0, i - s];
                snakeBody[1, i] = SnakeBody[1, i - s];
            }
            //Los valores nuevos toman los de por defecto
            for (int i = 1; i < s + 1; i++)
            {
                snakeBody[0, i] = Bodyx;
                snakeBody[1, i] = Bodyy;
            }
            
            SnakeBody = snakeBody;
            return SnakeBody;
        }
        public Snake()
        {
            SnakeBody = new int[2, 2];
        }
    }
}
