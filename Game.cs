using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Game
    {
        private CellState[,] field;
        private CellState[,] previousField;
        private int[,] aliveNeighbours;
        public int Rows { get; }
        public int Columns { get; }
        private int[] stayAliveCount;
        private int[] birthCount;
        private bool isInfinite;

        public Game(int rows,
            int columns,
            int[] bornCount,
            int[] stayAliveCount,
            bool isInfinite = false)
        {
            field = new CellState[rows, columns];
            previousField = new CellState[rows, columns];
            aliveNeighbours = new int[rows, columns];
            Rows = rows;
            Columns = columns;
            this.Reset(CellState.Dead);
            this.stayAliveCount = stayAliveCount;
            this.birthCount = bornCount;
            this.isInfinite = isInfinite;
        }

        public Game(GameSettings settings)
        {
            field = new CellState[settings.Rows, settings.Columns];
            previousField = new CellState[settings.Rows, settings.Columns];
            aliveNeighbours = new int[settings.Rows, settings.Columns];
            Rows = settings.Rows;
            Columns = settings.Columns;
            this.Reset(CellState.Dead);
            this.stayAliveCount = settings.StayAliveCount;
            this.birthCount = settings.BirthCount;
            this.isInfinite = settings.IsInfinite;
        }

        private void MakeActionWithNeighbours(int row, int column, Action<int, int> action)
        {
            for (int i = row - 1; i <= row + 1; i++)
                for (int j = column - 1; j <= column + 1; j++)
                {
                    int bufRow = i;
                    int bufColumn = j;
                    if (isInfinite == true)
                    {
                        bufRow = (Rows + i) % Rows;
                        bufColumn = (Columns + j) % Columns;
                    }
                    action(bufRow, bufColumn);
                }
        }

        public void Reset(CellState cellState)
        {
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Columns; j++)
                    SetCellState(i, j, cellState);
        }

        public void FillRandomly()
        {
            var random = new Random();
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Columns; j++)
                    SetCellState(i, j, random.Next(2) == 0 ? CellState.Dead : CellState.Alive);
        }

        private bool isInBounds(int row, int column)
        {
            return row >= 0 && column >= 0 && row < Rows && column < Columns;
        }

        public void SetCellState(int row, int column, CellState state)
        {
            if (!isInBounds(row, column)) throw new Exception("Out of bounds!");
            previousField[row, column] = field[row, column];
            field[row, column] = state;
        }

        public CellState GetCellState(int row, int column)
        {
            if (!isInBounds(row, column)) throw new Exception("Out of bounds!");
            return field[row, column];
        }

        private void RefreshAliveNeighbours()
        {
            Array.Clear(aliveNeighbours, 0, aliveNeighbours.Length);
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Columns; j++)
                {
                    if (field[i, j] == CellState.Alive)
                        IncreaseSurroundingNeighbours(i, j);
                }
        }

        private void IncreaseSurroundingNeighbours(int row, int column)
        {
            MakeActionWithNeighbours(row, column, (bufRow, bufColumn) =>
            {
                if (isInBounds(bufRow, bufColumn) &&
                    !(bufRow == row && bufColumn == column))
                    aliveNeighbours[bufRow, bufColumn]++;
            });
        }

        public void NextTick()
        {
            CellState[,] newField = (CellState[,])field.Clone();
            RefreshAliveNeighbours();
            Parallel.For(0, Rows, i =>
            {
                Parallel.For(0, Columns, j =>
                {
                    int aliveNeighbours = this.aliveNeighbours[i, j];
                    if (field[i, j] == CellState.Dead && birthCount.Contains(aliveNeighbours))
                        newField[i, j] = CellState.Alive;
                    if (field[i, j] == CellState.Alive && !stayAliveCount.Contains(aliveNeighbours))
                        newField[i, j] = CellState.Dead;
                });
            });
            previousField = (CellState[,])field.Clone();
            field = newField;
        }

        public bool HasCellChangedState(int row, int column)
        {
            return !(field[row, column] == previousField[row, column]);
        }
    }
}
