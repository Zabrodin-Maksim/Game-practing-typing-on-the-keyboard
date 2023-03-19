using GameLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class GaneForm : Form
    {

        private Random random = new Random();
        private Stats stats = new Stats();
        public GaneForm()
        {
            InitializeComponent();
            stats.UpdatedStats += Updated_Stats;
        }


        private void Updated_Stats(object sender, UpdatedStatsEventArgs e)
        {
            correctLabel.Text = "Correct: " + stats.Correct;
            missedLabel.Text = "Missed: " + stats.Missed;
            accuracyLabel.Text = "Accuracy: " + stats.Accuracy + "%";
        }


        private void gameListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (gameListBox.Items.Contains(e.KeyCode))
            {
                gameListBox.Items.Remove(e.KeyCode);
                gameListBox.Refresh();
                stats.Update(true);


                if (gameTimer.Interval > 400)
                {
                    gameTimer.Interval -= 60;
                }
                else if (gameTimer.Interval > 250)
                {
                    gameTimer.Interval -= 15;
                }
                else if (gameTimer.Interval > 150)
                {
                    gameTimer.Interval -= 8;
                }

                int difficulty = 800 - gameTimer.Interval;
                if (difficulty > 800) difficulty = 800;
                if (difficulty < 0) difficulty = 0;
                difficultyProgressBar.Value = difficulty;

            }
            else { stats.Update(false); }

            if (gameListBox.Items.Count == 1 && gameListBox.Items[0].ToString() == "Game over!")
            {
                RestartGame();
            }
        }
        private void RestartGame()
        {
            gameListBox.Items.Clear();
            stats.Reset();
            correctLabel.Text = "Correct: 0";
            missedLabel.Text = "Missed: 0";
            accuracyLabel.Text = "Accuracy: 0%";
            gameTimer.Interval = 800;
            gameTimer.Start();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (gameListBox.Items.Count > 6)
            {
                gameTimer.Stop();
                stats.Reset();
                gameListBox.Items.Clear();
                gameListBox.Items.Add("Game over!");
            }
            else { gameListBox.Items.Add((Keys)random.Next(65, 91)); }


        }
    }
}
