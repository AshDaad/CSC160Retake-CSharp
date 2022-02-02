using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConwaysGameOfLife.Models;


namespace ConwaysGameOfLife.Models
{


	//The universe of the Game of Life is an infinite two-dimensional orthogonal grid of square cells, 
	//each of which is in one of two possible states, alive or dead.Every cell interacts with its eight 
	//neighbours, which are the cells that are horizontally, vertically, or diagonally adjacent.At each step in time, 
	//the following transitions occur:
		
		//  R U L E S
		//Any live cell with fewer than two live neighbours dies, as if caused by under-population.
		//Any live cell with two or three live neighbours lives on to the next generation.
		//Any live cell with more than three live neighbours dies, as if by overcrowding.
		//Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.
	
	//The initial pattern constitutes the seed of the system. The first generation is created by applying the above rules simultaneously to every cell in the seed—births and deaths occur simultaneously, and the discrete moment at which this happens is sometimes called a tick (in other words, each generation is a pure function of the preceding one). The rules continue to be applied repeatedly to create further generations.


	public delegate void CellsUpdate();
	public class Board
	{
		public Cells[,] Cells { get; set; }
		public int Width { get; set; }
		public int Height { get; set; }

		public event CellsUpdate UpdateCellAliveStatus;


		public Board(int Width, int Height)
		{
			this.Width = Width;
			this.Height = Height;

			Cells = new Cells[this.Width, this.Height];
			for (int row = 0; row < Width; row++)
			{
				for (int column = 0; column < Height; column++)
				{
					Cells[row, column] = new Models.Cells(this);
				}
			}
		}

		private void UpdateCellStatus()
		{
			UpdateCellAliveStatus();
		}

		public void Tick()
		{
			UpdateNeighbors();
			UpdateCellStatus();
		}

		private void UpdateNeighbors()
		{
			for (int row = 0; row < Width; row++)
			{
				for (int column = 0; column < Height; column++)
                {
					Cells[row, column].SuroundingAliveCell = GetLivingNeighbors(row, column);
				}

			}
		}

        private int GetLivingNeighbors(int row, int column)
        {
            //this will check if the neighbors are alive or not
            int count = 0;
            for (int x = -1; x < 2; x++)
            {
                for (int y = -1; y < 2; y++)
                {
                    int ROWS = row + x;
                    int COLUMNS = column + y;

                    if (IsValidNeighbot(ROWS, COLUMNS) &&
                          Cells[ROWS, COLUMNS].IsAlive &&
                          !(x == 0 && y == 0))
                    {
                        count++;
                    }

                }

            }
            return count;
        }



        private bool IsValidNeighbot(int row, int column)
		{
			bool ಠ_ಠ = true;
			if (row < 0 || row >= Width || column < 0 || column >= Height)
			{
				ಠ_ಠ = false;
			}

			return ಠ_ಠ;
		}
	}
}
