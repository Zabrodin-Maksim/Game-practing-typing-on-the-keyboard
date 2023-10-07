namespace Game
{
    partial class GaneForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            gameListBox = new ListBox();
            statusStrip1 = new StatusStrip();
            correctLabel = new ToolStripStatusLabel();
            missedLabel = new ToolStripStatusLabel();
            accuracyLabel = new ToolStripStatusLabel();
            Difficult = new ToolStripStatusLabel();
            difficultyProgressBar = new ToolStripProgressBar();
            gameTimer = new System.Windows.Forms.Timer(components);
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // gameListBox
            // 
            gameListBox.BackColor = SystemColors.ControlLightLight;
            gameListBox.Dock = DockStyle.Fill;
            gameListBox.Font = new Font("Segoe UI Black", 125F, FontStyle.Regular, GraphicsUnit.Point);
            gameListBox.FormattingEnabled = true;
            gameListBox.ItemHeight = 221;
            gameListBox.Location = new Point(0, 0);
            gameListBox.Margin = new Padding(50, 56, 50, 56);
            gameListBox.MultiColumn = true;
            gameListBox.Name = "gameListBox";
            gameListBox.RightToLeft = RightToLeft.No;
            gameListBox.Size = new Size(1302, 253);
            gameListBox.TabIndex = 0;
            gameListBox.KeyDown += gameListBox_KeyDown;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { correctLabel, missedLabel, accuracyLabel, Difficult, difficultyProgressBar });
            statusStrip1.Location = new Point(0, 231);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1302, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // correctLabel
            // 
            correctLabel.Name = "correctLabel";
            correctLabel.Size = new Size(72, 17);
            correctLabel.Text = "correctLabel";
            // 
            // missedLabel
            // 
            missedLabel.Name = "missedLabel";
            missedLabel.Size = new Size(72, 17);
            missedLabel.Text = "missedLabel";
            // 
            // accuracyLabel
            // 
            accuracyLabel.Name = "accuracyLabel";
            accuracyLabel.Size = new Size(82, 17);
            accuracyLabel.Text = "accuracyLabel";
            // 
            // Difficult
            // 
            Difficult.Name = "Difficult";
            Difficult.Size = new Size(959, 17);
            Difficult.Spring = true;
            Difficult.Text = "Difficulty";
            Difficult.TextAlign = ContentAlignment.MiddleRight;
            // 
            // difficultyProgressBar
            // 
            difficultyProgressBar.Maximum = 800;
            difficultyProgressBar.Name = "difficultyProgressBar";
            difficultyProgressBar.Size = new Size(100, 16);
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 1000;
            gameTimer.Tick += gameTimer_Tick;
            // 
            // GaneForm
            // 
            AutoScaleDimensions = new SizeF(118F, 283F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1302, 253);
            Controls.Add(statusStrip1);
            Controls.Add(gameListBox);
            Font = new Font("Segoe UI Variable Display", 160F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(50, 56, 50, 56);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "GaneForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Game";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox gameListBox;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel correctLabel;
        private ToolStripStatusLabel missedLabel;
        private ToolStripStatusLabel accuracyLabel;
        private ToolStripStatusLabel Difficult;
        private ToolStripProgressBar difficultyProgressBar;
        private System.Windows.Forms.Timer gameTimer;
    }
}
