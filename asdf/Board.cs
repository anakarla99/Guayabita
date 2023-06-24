using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeProject
{
    class Board
    {
        /// <summary>
        /// Este enum contiene a todas las cosas que pudieran estar en el tablero
        /// </summary>
        public enum WorldStuff
        {
            obstacle = -1,
            empty,
            egg ,
            SnakeHead,
            SnakeBody,
            SnakeTail,
        }
        private int worldWidth;
        public int WorldWidth { get { return worldWidth; } private set { } }
        int worldHeight;
        public int WorldHeigth { get { return worldHeight; } private set { } }
        public WorldStuff[,] floor { get; set; }

        /// <summary>
        /// Esta clase me crea un tablero bidimensional de las cosas del mundo de las dimensiones que el usuario quiera y las de por defecto
        /// </summary>
        /// <param name="worldWidth"></param>
        /// <param name="worldHeight"></param>
        public Board(int worldWidth, int worldHeight)
        {
            this.worldWidth = worldWidth;
            this.worldHeight = worldHeight;
            floor = new WorldStuff[worldWidth, worldHeight];
        }

        /// <summary>
        /// Este método pone los obstáculos en una posición aleatoria en el mundo por defecto
        /// </summary>
        /// <param name="c"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public static WorldStuff[,] PutRandomObstacles(int c, int r)
        {
            WorldStuff[,] a = new WorldStuff[c, r];
            int obstaclesAmount = 30;
            do
            {
                while (obstaclesAmount != 0)
                {
                    Random rand = new Random();
                    int x = rand.Next(c);
                    int y = rand.Next(r);
                    if (a[x, y] == WorldStuff.empty)
                    {
                        a[x, y] = WorldStuff.obstacle;
                        obstaclesAmount--;
                    }
                }
                break;
            }
            while (!Lee(ConvertToInt(a)));
            return a;
        }

        /// <summary>
        /// Este método convierte el array bidimensional de las cosas del mundo aleatorio en un array de enteros
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int[,] ConvertToInt(WorldStuff[,] a)
        {
            int[,] inta = new int[a.GetLength(0), a.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] == WorldStuff.obstacle)
                        inta[i, j] = -1;
                    if (a[i, j] == WorldStuff.empty)
                        inta[i, j] = 0;
                }
            }
            return inta;
        }

        /// <summary>
        /// Este método verifica si el tablero al ponerle obstáculos, es válido
        /// </summary>
        /// <param name="tablero"></param>
        /// <returns></returns>
        public static bool Lee(int[,] tablero)
        {
            int[,] Lee = tablero;
            int[] despx = { -1, 1, 0, 0 };
            int[] despy = { 0, 0, 1, -1 };
            int x = 0;
            int y = 0;
            do
            {
                Random pos = new Random();
                x = pos.Next(tablero.GetLength(0));
                y = pos.Next(tablero.GetLength(1));
            }
            while (tablero[x, y] == -1);
            Lee[x, y] = 1;
            int incr = 1;
            bool hadChange = true;
            while (hadChange)
            {
                hadChange = false;
                for (int i = 0; i < Lee.GetLength(0); i++)
                {
                    for (int j = 0; j < Lee.GetLength(1); j++)
                    {
                        if (Lee[i, j] == 0) continue;
                        if (Lee[i, j] == -1) continue;
                        if (Lee[i, j] == incr)
                        {
                            for (int k = 0; k < 4; k++)
                            {
                                int dirx = (despx[k] + i) % tablero.GetLength(0);
                                int diry = (despy[k] + j) % tablero.GetLength(1);
                                if (dirx < 0)
                                    dirx = tablero.GetLength(0) - 1;
                                if (diry < 0)
                                    diry = tablero.GetLength(1) - 1;
                                if (tablero[dirx, diry] == 0)
                                {
                                    tablero[dirx, diry] = incr + 1;
                                    hadChange = true;
                                }
                            }
                        }
                    }
                }
                incr++;
            }
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    if (tablero[i, j] == 0)
                        return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Este método pone y quita los obstáculos en una posición x,y que el usuario quiera
        /// </summary>
        /// <param name="a"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int[,] PutObstacles(int[,] a, int x, int y)
        {
            bool noerror = true; //Se creó este variable para controlar de que el usuario haya quitado o no el obstaculo que invalida el mundo
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] == -2)
                    {
                        noerror = false;
                    }
                }
            }
            if (a[x, y] == -2)
            {
                a[x, y] = 0;
                return a;
            }
            if (noerror)
            {
                if (a[x, y] == -1)
                {
                    a[x, y] = 0;
                    return a;
                }
                if (a[x, y] == 0)
                {
                    a[x, y] = -1;
                    return a;
                }
            }
            return a;
        }
        
            
    }
}
