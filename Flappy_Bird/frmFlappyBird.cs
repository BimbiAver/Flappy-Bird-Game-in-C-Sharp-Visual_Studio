using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class frmFlappyBird : Form
    {
        // Variable Declaration
        int pipeSpeed = 8; // Pipe speed
        int gravity = 10; // Gravity speed
        int score = 0; // Score count

        public frmFlappyBird()
        {
            InitializeComponent();
        }

        private void Event01(object sender, EventArgs e)
        {
            imgPipeUp.Left -= pipeSpeed; // The top pipe begins to move to the left side with the pipe speed
            imgPipeDown.Left -= pipeSpeed; // The bottom pipe begins to move to the left side with the pipe speed

            imgBird.Top += gravity;

            // If the bottom pipes location is -50, then it will reset back to 500 and add 1 to the score and display
            if (imgPipeDown.Left < -50)
            {
                imgPipeDown.Left = 500;
                score++;
                lblScore.Text = "Score: " + score.ToString();
            }

            // If the top pipes location is -50, then it will reset back to 450 and add 1 to the score and display
            if (imgPipeUp.Left < -50)
            {
                imgPipeUp.Left = 450;
                score++;
                lblScore.Text = "Score: " + score.ToString();
            }

            // If any of the following conditions are met, then it will run the end game function
            if (imgBird.Bounds.IntersectsWith(imgPipeDown.Bounds) || imgBird.Bounds.IntersectsWith(imgPipeUp.Bounds) || imgBird.Bounds.IntersectsWith(imgGround.Bounds) || imgBird.Top < -5)
            {
                endGame();
            }

            // If score is greater than 10, then the speed will increase to 15
            if (score >= 10)
            {
                pipeSpeed = 15;
            }
        }

        // Key down event
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            // The gravity will be set to -10 if the space is pressed
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }

        // Key up event
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            // The gravity will be set to 10 if the space is pressed
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }

        // The game end function
        private void endGame()
        {
            tmr01.Stop();
            lblGameOver.Visible = true;
            btnRetry.Visible = true;
        }

        // Restarts the application
        private void btnRetry_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }
    }
}