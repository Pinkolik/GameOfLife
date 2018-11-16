namespace GameOfLife
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fieldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearFieldToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fillFieldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomlyFillFieldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.drawingTimer = new System.Windows.Forms.Timer(this.components);
            this.nextStepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.fieldToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(500, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.startToolStripMenuItem,
            this.nextStepToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // fieldToolStripMenuItem
            // 
            this.fieldToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearFieldToolStripMenuItem1,
            this.fillFieldToolStripMenuItem,
            this.randomlyFillFieldToolStripMenuItem});
            this.fieldToolStripMenuItem.Name = "fieldToolStripMenuItem";
            this.fieldToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.fieldToolStripMenuItem.Text = "Field";
            // 
            // clearFieldToolStripMenuItem1
            // 
            this.clearFieldToolStripMenuItem1.Name = "clearFieldToolStripMenuItem1";
            this.clearFieldToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.clearFieldToolStripMenuItem1.Text = "Clear Field";
            this.clearFieldToolStripMenuItem1.Click += new System.EventHandler(this.clearFieldToolStripMenuItem1_Click);
            // 
            // fillFieldToolStripMenuItem
            // 
            this.fillFieldToolStripMenuItem.Name = "fillFieldToolStripMenuItem";
            this.fillFieldToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.fillFieldToolStripMenuItem.Text = "Fill Field";
            this.fillFieldToolStripMenuItem.Click += new System.EventHandler(this.fillFieldToolStripMenuItem_Click);
            // 
            // randomlyFillFieldToolStripMenuItem
            // 
            this.randomlyFillFieldToolStripMenuItem.Name = "randomlyFillFieldToolStripMenuItem";
            this.randomlyFillFieldToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.randomlyFillFieldToolStripMenuItem.Text = "Randomly Fill Field";
            this.randomlyFillFieldToolStripMenuItem.Click += new System.EventHandler(this.randomlyFillFieldToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // drawingTimer
            // 
            this.drawingTimer.Interval = 1;
            this.drawingTimer.Tick += new System.EventHandler(this.drawingTimer_Tick);
            // 
            // nextStepToolStripMenuItem
            // 
            this.nextStepToolStripMenuItem.Name = "nextStepToolStripMenuItem";
            this.nextStepToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nextStepToolStripMenuItem.Text = "Next Step";
            this.nextStepToolStripMenuItem.Click += new System.EventHandler(this.nextStepToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 527);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Game of life";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fieldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearFieldToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fillFieldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomlyFillFieldToolStripMenuItem;
        private System.Windows.Forms.Timer drawingTimer;
        private System.Windows.Forms.ToolStripMenuItem nextStepToolStripMenuItem;
    }
}

