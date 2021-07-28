
namespace Flappy_Bird
{
    partial class frmFlappyBird
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFlappyBird));
            this.imgPipeUp = new System.Windows.Forms.PictureBox();
            this.imgPipeDown = new System.Windows.Forms.PictureBox();
            this.imgBird = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.imgGround = new System.Windows.Forms.PictureBox();
            this.tmr01 = new System.Windows.Forms.Timer(this.components);
            this.lblGameOver = new System.Windows.Forms.Label();
            this.btnRetry = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgPipeUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGround)).BeginInit();
            this.SuspendLayout();
            // 
            // imgPipeUp
            // 
            this.imgPipeUp.BackColor = System.Drawing.Color.Transparent;
            this.imgPipeUp.Image = global::Flappy_Bird.Properties.Resources.pipedown;
            this.imgPipeUp.Location = new System.Drawing.Point(291, -39);
            this.imgPipeUp.Name = "imgPipeUp";
            this.imgPipeUp.Size = new System.Drawing.Size(60, 150);
            this.imgPipeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPipeUp.TabIndex = 0;
            this.imgPipeUp.TabStop = false;
            // 
            // imgPipeDown
            // 
            this.imgPipeDown.BackColor = System.Drawing.Color.Transparent;
            this.imgPipeDown.Image = global::Flappy_Bird.Properties.Resources.pipe;
            this.imgPipeDown.Location = new System.Drawing.Point(229, 226);
            this.imgPipeDown.Name = "imgPipeDown";
            this.imgPipeDown.Size = new System.Drawing.Size(60, 196);
            this.imgPipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPipeDown.TabIndex = 0;
            this.imgPipeDown.TabStop = false;
            // 
            // imgBird
            // 
            this.imgBird.BackColor = System.Drawing.Color.Transparent;
            this.imgBird.Image = global::Flappy_Bird.Properties.Resources.bird;
            this.imgBird.Location = new System.Drawing.Point(45, 142);
            this.imgBird.Name = "imgBird";
            this.imgBird.Size = new System.Drawing.Size(45, 45);
            this.imgBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBird.TabIndex = 1;
            this.imgBird.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(216)))), ((int)(((byte)(149)))));
            this.lblScore.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(6, 400);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(86, 29);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score:";
            // 
            // imgGround
            // 
            this.imgGround.Image = global::Flappy_Bird.Properties.Resources.ground;
            this.imgGround.Location = new System.Drawing.Point(-16, 381);
            this.imgGround.Name = "imgGround";
            this.imgGround.Size = new System.Drawing.Size(466, 73);
            this.imgGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgGround.TabIndex = 3;
            this.imgGround.TabStop = false;
            // 
            // tmr01
            // 
            this.tmr01.Enabled = true;
            this.tmr01.Interval = 60;
            this.tmr01.Tick += new System.EventHandler(this.Event01);
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(216)))), ((int)(((byte)(149)))));
            this.lblGameOver.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.Red;
            this.lblGameOver.Location = new System.Drawing.Point(141, 400);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(153, 29);
            this.lblGameOver.TabIndex = 2;
            this.lblGameOver.Text = "Game Over !";
            this.lblGameOver.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblGameOver.Visible = false;
            // 
            // btnRetry
            // 
            this.btnRetry.BackColor = System.Drawing.Color.Navy;
            this.btnRetry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetry.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetry.ForeColor = System.Drawing.Color.White;
            this.btnRetry.Location = new System.Drawing.Point(354, 399);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(72, 31);
            this.btnRetry.TabIndex = 4;
            this.btnRetry.Text = "Retry";
            this.btnRetry.UseVisualStyleBackColor = false;
            this.btnRetry.Visible = false;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // frmFlappyBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Flappy_Bird.Properties.Resources.bg_01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 435);
            this.Controls.Add(this.btnRetry);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.imgPipeUp);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.imgGround);
            this.Controls.Add(this.imgPipeDown);
            this.Controls.Add(this.imgBird);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFlappyBird";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.imgPipeUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGround)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPipeUp;
        private System.Windows.Forms.PictureBox imgPipeDown;
        private System.Windows.Forms.PictureBox imgBird;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox imgGround;
        private System.Windows.Forms.Timer tmr01;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Button btnRetry;
    }
}

