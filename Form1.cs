using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace GameOfLife
{
    public partial class Form1 : Form
    {
        private Game game;
        private GameSettings settings;
        private string settingsFile = "settings.bin";
        private Point previousPosition = new Point(0, 0);
        private MouseEventArgs mouseEvent;
        private Bitmap grid;
        public Form1()
        {
            InitializeComponent();
            StartNewGame();
        }
        private void DrawField(Game game)
        {
            int rows = game.Rows;
            int columns = game.Columns;
            int width = (int)Math.Round((double)pictureBox1.Width / columns);
            int height = (int)Math.Round((double)pictureBox1.Height / rows);
            var aliveBrush = new SolidBrush(Color.Green);
            var deadBrush = new SolidBrush(Color.Black);
            var bitmap = new Bitmap(pictureBox1.Image);
            var bitmapGraphics = Graphics.FromImage(bitmap);
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                {
                    if (game.HasCellChangedState(i, j))
                        bitmapGraphics.FillRectangle(
                        game.GetCellState(i, j) == CellState.Alive ? aliveBrush : deadBrush,
                        j * width,
                        i * height,
                        width,
                        height);
                }
            pictureBox1.Image = bitmap;
            aliveBrush.Dispose();
            deadBrush.Dispose();
            bitmapGraphics.Dispose();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            NextStep();
        }

        private void NextStep()
        {
            Stopwatch nextStepWatch = new Stopwatch();
            Stopwatch drawWatch = new Stopwatch();
            nextStepWatch.Start();
            game.NextTick();
            nextStepWatch.Stop();
            drawWatch.Start();
            DrawField(this.game);
            drawWatch.Stop();
            this.Text = string.Format("Game of life {0:000} NextGen, {1:000} Draw, {2:000} Total",
               nextStepWatch.ElapsedMilliseconds,
               drawWatch.ElapsedMilliseconds,
               nextStepWatch.ElapsedMilliseconds + drawWatch.ElapsedMilliseconds);
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        private Bitmap DrawGrid()
        {
            int width = (int)Math.Round((double)pictureBox1.Width / game.Columns);
            int height = (int)Math.Round((double)pictureBox1.Height / game.Rows);
            var bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            var pen = new Pen(Color.Red);
            var bitmapGraphics = Graphics.FromImage(bitmap);
            for (int i = 0; i < game.Rows; i++)
                for (int j = 0; j < game.Columns; j++)
                {
                    bitmapGraphics.DrawLine(pen, 0, i * height, pictureBox1.Width, i * height);
                    bitmapGraphics.DrawLine(pen, j * width, 0, j * width, pictureBox1.Height);
                }
            pen.Dispose();
            bitmapGraphics.Dispose();
            return bitmap;
        }

        private void StartNewGame()
        {
            settings = (GameSettings)Serializer.Deserialize(settingsFile) ?? new GameSettings();
            game = new Game(settings);
            timer1.Interval = settings.Timer;
            //grid = DrawGrid();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            DrawField(this.game);
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void clearFieldToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            game.Reset(CellState.Dead);
            DrawField(this.game);
        }

        private void fillFieldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game.Reset(CellState.Alive);
            DrawField(this.game);
        }

        private void randomlyFillFieldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game.FillRandomly();
            DrawField(this.game);
        }

        private void drawingTimer_Tick(object sender, EventArgs e)
        {
            var position = pictureBox1.PointToClient(MousePosition);
            if ((position.X >= 0 && position.Y >= 0 && position.X < pictureBox1.Width && position.Y < pictureBox1.Height)
                && (position.X != previousPosition.X || position.Y != previousPosition.Y))
            {
                int row = (int)Math.Round((double)game.Rows / pictureBox1.Height * position.Y);
                int column = (int)Math.Round((double)game.Columns / pictureBox1.Width * position.X);
                game.SetCellState(row, column,
                    mouseEvent.Button == MouseButtons.Left ? CellState.Alive : CellState.Dead);
                DrawField(game);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            drawingTimer.Enabled = true;
            mouseEvent = e;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            drawingTimer.Enabled = false;
        }

        private void nextStepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NextStep();
        }
    }
}
