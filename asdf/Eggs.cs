using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnakeProject;

namespace SnakeProject
{
    class Eggs
    {
        Board Tablero { get; set; }
        int eggsAmount;
        private int[,] eggsPositions;
        public int[,] EggsPositions { get { return eggsPositions; } private set { } }
        
        /// <summary>
        /// Este método es para poner los huevos en el tablero
        /// </summary>
        /// <returns></returns>
        public Board.WorldStuff [,] PutEggs()
        {
            int i = 0;
            int j = 0;
            while (eggsAmount != 0)
            {
                Random a = new Random();
                int x = a.Next(Tablero.floor.GetLength(0));
                int y = a.Next(Tablero.floor.GetLength(1));
                if (Tablero.floor[x, y] == Board.WorldStuff.empty)
                {
                    Tablero.floor[x, y] = Board.WorldStuff.egg;
                    eggsPositions[0, i] = x;
                    eggsPositions[1, j] = y;
                    i++;
                    j++;
                    eggsAmount--;
                }
            }
            return Tablero.floor;
        }

        /// <summary>
        /// Este método me dice el numero del huevo en la posicion dada
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int EggNumber(int x, int y)
        {
            for (int i = 0; i < eggsPositions.GetLength(1); i++)
            {
                if (eggsPositions[0, i] == x && EggsPositions[1, i] == y)
                    return i+1;
            }
            return 0;
        }

        /// <summary>
        /// Este método booleano comprueba si en el tablero todavia existen huevos
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public bool NoEgg(Board.WorldStuff[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] == Board.WorldStuff.egg)
                        return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Este método dice el numero del huevo mas cercano al que se comió la serpiente
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public int Score(int x, int y, Board.WorldStuff[,] a)
        {
            if (EggNumber(x, y) == 0) return 0;
            int s = 0;
            // Creo un array bidimensional del mismo tamano de mi tablero, solamente con obstáculos
            int[,] Lee = new int[a.GetLength(0), a.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] == Board.WorldStuff.obstacle)
                        Lee[i, j] = -1;
                }
            }
            //Luego utilizo el método de Lee para expandir el numero por todo el tablero
            int[] despx = { -1, 1, 0, 0 };
            int[] despy = { 0, 0, 1, -1 };
            Lee[x, y] = 1;
            int e = 1;
            bool Change = true;
            do
            {
                Change = false;
                for (int i = 0; i < Lee.GetLength(0); i++)
                {
                    for (int j = 0; j < Lee.GetLength(1); j++)
                    {
                        if (Lee[i, j] == 0) continue;
                        if (Lee[i, j] == -1) continue;
                        if (Lee[i, j] == e)
                        {
                            for (int k = 0; k < 4; k++)
                            {
                                int dirx = (despx[k] + i) % Lee.GetLength(0);
                                int diry = (despy[k] + j) % Lee.GetLength(1);
                                if (dirx < 0)
                                {
                                    dirx = Lee.GetLength(0) - 1;
                                }
                                if (diry < 0)
                                {
                                    diry = Lee.GetLength(1) - 1;
                                }

                                if (Lee[dirx, diry] == 0)
                                {
                                    Lee[dirx, diry] = e + 1;
                                    Change = true;
                                }
                            }
                        }
                    }
                }
                e++;
            } while (Change);
            // Finalmente busco un huevo, comparando entre los dos tablero(el normal y el de Lee), y si hallo alguno que este mas cercano al que se comio la serpiente, escojo ese
            int tempx = 0;
            int tempy = 0;
            for (int i = 0; i < Lee.GetLength(0); i++)
            {
                for (int j = 0; j < Lee.GetLength(1); j++)
                {
                    if (a[i, j] == Board.WorldStuff.egg && Lee[i,j] != 1)
                    {
                        if (a[tempx, tempy] == Board.WorldStuff.egg)
                        {
                            if (Lee[i, j] < Lee[tempx, tempy])
                            {
                                tempx = i;
                                tempy = j;
                                s = EggNumber(tempx, tempy);
                            }
                            else continue;
                        }
                        else
                        {
                            tempx = i;
                            tempy = j;
                            s = EggNumber(tempx, tempy);
                        }
                        
                    }
                }
            }
                return s;
        }
        public Eggs(Board tablero, int eggsAmount)
        {
            this.eggsAmount = eggsAmount;
            Tablero = tablero;
            eggsPositions = new int[2, eggsAmount];
        }
    }
}
