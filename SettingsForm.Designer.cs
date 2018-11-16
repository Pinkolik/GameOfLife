namespace GameOfLife
{
    partial class SettingsForm
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
            this.birthCountTextBox = new System.Windows.Forms.TextBox();
            this.survivalTextBox = new System.Windows.Forms.TextBox();
            this.speedTrackBar = new System.Windows.Forms.TrackBar();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.infiniteCheckBox = new System.Windows.Forms.CheckBox();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.speedTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // birthCountTextBox
            // 
            this.birthCountTextBox.Location = new System.Drawing.Point(147, 12);
            this.birthCountTextBox.Name = "birthCountTextBox";
            this.birthCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.birthCountTextBox.TabIndex = 0;
            // 
            // survivalTextBox
            // 
            this.survivalTextBox.Location = new System.Drawing.Point(147, 38);
            this.survivalTextBox.Name = "survivalTextBox";
            this.survivalTextBox.Size = new System.Drawing.Size(100, 20);
            this.survivalTextBox.TabIndex = 1;
            // 
            // speedTrackBar
            // 
            this.speedTrackBar.Location = new System.Drawing.Point(147, 116);
            this.speedTrackBar.Maximum = 1000;
            this.speedTrackBar.Minimum = 10;
            this.speedTrackBar.Name = "speedTrackBar";
            this.speedTrackBar.Size = new System.Drawing.Size(104, 45);
            this.speedTrackBar.TabIndex = 2;
            this.speedTrackBar.Value = 100;
            this.speedTrackBar.ValueChanged += new System.EventHandler(this.speedTrackBar_ValueChanged);
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(147, 64);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(100, 20);
            this.widthTextBox.TabIndex = 3;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(147, 90);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 20);
            this.heightTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Survival";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Height";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Refresh(ms)";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(15, 184);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // infiniteCheckBox
            // 
            this.infiniteCheckBox.AutoSize = true;
            this.infiniteCheckBox.Location = new System.Drawing.Point(15, 144);
            this.infiniteCheckBox.Name = "infiniteCheckBox";
            this.infiniteCheckBox.Size = new System.Drawing.Size(57, 17);
            this.infiniteCheckBox.TabIndex = 12;
            this.infiniteCheckBox.Text = "Infinite";
            this.infiniteCheckBox.UseVisualStyleBackColor = true;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(172, 184);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 13;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 219);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.infiniteCheckBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.speedTrackBar);
            this.Controls.Add(this.survivalTextBox);
            this.Controls.Add(this.birthCountTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.speedTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox birthCountTextBox;
        private System.Windows.Forms.TextBox survivalTextBox;
        private System.Windows.Forms.TrackBar speedTrackBar;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.CheckBox infiniteCheckBox;
        private System.Windows.Forms.Button resetButton;
    }
}