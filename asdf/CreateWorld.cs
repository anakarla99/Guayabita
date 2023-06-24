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

namespace SnakeProject
{
    public partial class CreateWorld : Form
    {
        public CreateWorld()
        {
            InitializeComponent();
            rows = (int)nudRows.Value;
            columns = (int)nudColumns.Value;
            yourWorld = new int[rows, columns];
        }

        int rows;
        int columns;
        int eggs;
        int speed;
        private int[,] yourWorld;
        

        private void CreateWorld_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btSaveGame_Click(object sender, EventArgs e)
        {
            eggs = (int)nudEggs.Value;
            speed = (int)SpeedBar.Value;
            if (saveWorld.ShowDialog() == DialogResult.OK)
            { //Necesito tener filas, columnas, huevos, velocidad y cant de obst
                string[] saveW = new string[4 + ObstAmount(yourWorld)];
                saveW[0] = columns.ToString();
                saveW[1] = rows.ToString();
                saveW[2] = eggs.ToString();
                saveW[3] = speed.ToString();
                int k = 4;
                for (int i = 0; i < yourWorld.GetLength(0); i++)
                {
                    for (int j = 0; j < yourWorld.GetLength(1); j++)
                    {
                        if (yourWorld[i, j] == -1)
                        {
                            saveW[k] = i.ToString() + " " + j.ToString();
                            k++;
                        }
                    }
                }
                File.WriteAllLines(saveWorld.FileName + ".txt", saveW);
            }
            yourWorld = new int[rows, columns];
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            rows = (int)nudRows.Value;
            columns = (int)nudColumns.Value;

            Graphics g = e.Graphics;

            float cellHeight = (pictureBox1.Height - 1f) / rows;
            float cellWidth = (pictureBox1.Width - 1f) / columns;

            float obstSizeX = cellWidth * 0.9f;
            float obstSizeY = cellHeight * 0.9f;

            float focusObstX = (cellWidth - obstSizeX) / 2f;
            float focusObstY = (cellHeight - obstSizeY) / 2f;
            yourWorld = BiggerWorld();

            for (int i = 0; i <= rows; i++)
            {
                g.DrawLine(Pens.Black, 0, cellHeight * i, pictureBox1.Width, cellHeight * i);

            }
            for (int i = 0; i <= columns; i++)
            {
                g.DrawLine(Pens.Black, cellWidth * i, 0, cellWidth * i, pictureBox1.Height);
            }
            for (int c = 0; c < yourWorld.GetLength(0); c++)
            {
                for (int r = 0; r < yourWorld.GetLength(1); r++)
                {
                    if (yourWorld[c, r] == -1)
                    g.FillRectangle(Brushes.Gray, cellWidth * r + focusObstX, cellHeight * c + focusObstY, obstSizeX, obstSizeY);
                     if(yourWorld[c,r] == -2)
                    {
                        g.FillRectangle(Brushes.Red, cellWidth * r, cellHeight * c, cellWidth, cellHeight);
                        g.FillRectangle(Brushes.Gray, cellWidth * r + focusObstX, cellHeight * c + focusObstY, obstSizeX, obstSizeY);
                    }   
                }
            }
                pictureBox1.Invalidate();
        }

        /// <summary>
        /// Este método agranda(achica) el tablero, si el usuario decide aumentar(disminuir) las columnas
        /// </summary>
        /// <returns></returns>
        public int[,] BiggerWorld()
        {
            int[,] bigger = new int[rows, columns];
            for (int i = 0; i < yourWorld.GetLength(0); i++)
            {
                for (int j = 0; j < yourWorld.GetLength(1); j++)
                {
                    if (yourWorld[i, j] == -1)
                        bigger[i, j] = -1;
                    if (yourWorld[i, j] == -2)
                        bigger[i, j] = -2;
                }
            }
            return bigger;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = columns * e.X / pictureBox1.Width;
            int y = rows * e.Y / pictureBox1.Height;
            bool fix = true;
            yourWorld = Board.PutObstacles(yourWorld, y, x);
            for (int i = 0; i < yourWorld.GetLength(0); i++)
            {
                for (int j = 0; j < yourWorld.GetLength(1); j++)
                {
                    if (yourWorld[i, j] == -2)
                        fix = false;
                }
            }
            if (!Board.Lee(yourWorld) && fix)
            {
                yourWorld[y, x] = -2;
            }
            pictureBox1.Invalidate();
        }

        /// <summary>
        /// Este método se encarga de decir cuantos obstáculos a puesto el usuario en el tablero
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        private int ObstAmount(int[,] a)
        {
            int c = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] == -1)
                        c++;
                }
            }
            return c;
        }

        private void btGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 window1 = new Form1();
            window1.Show();

        }
    }
}
