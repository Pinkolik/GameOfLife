using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    [Serializable]
    public class GameSettings
    {
        public int Timer { get; set; }
        public int[] BirthCount { get; set; }
        public int[] StayAliveCount { get; set; }
        public int Rows { get; set; }
        public int Columns { get; set; }
        public bool IsInfinite { get; set; }
        public GameSettings(int timer,
            int[] bornCount,
            int[] stayAliveCount,
            int rows,
            int columns,
            bool isInfinite)
        {
            Timer = timer;
            BirthCount = bornCount;
            StayAliveCount = stayAliveCount;
            Rows = rows;
            Columns = columns;
            IsInfinite = isInfinite;
        }

        public GameSettings()
        {
            Timer = 100;
            BirthCount = new[] { 3 };
            StayAliveCount = new[] { 2, 3 };
            Rows = 500;
            Columns = 500;
            IsInfinite = true;
        }
    }
}
