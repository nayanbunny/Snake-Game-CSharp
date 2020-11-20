
namespace Snake
{
    partial class SnakeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SnakeForm));
            this.pnlShade = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPauseResume = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSnakeColor = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScoreText = new System.Windows.Forms.Label();
            this.lblFood = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnlShade.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlShade
            // 
            this.pnlShade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.pnlShade.Controls.Add(this.label2);
            this.pnlShade.Controls.Add(this.lblPauseResume);
            this.pnlShade.Controls.Add(this.lblStart);
            this.pnlShade.Controls.Add(this.label1);
            this.pnlShade.Controls.Add(this.lblSnakeColor);
            this.pnlShade.Controls.Add(this.lblScore);
            this.pnlShade.Controls.Add(this.lblScoreText);
            this.pnlShade.Location = new System.Drawing.Point(0, 0);
            this.pnlShade.Name = "pnlShade";
            this.pnlShade.Size = new System.Drawing.Size(800, 60);
            this.pnlShade.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(63, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.MinimumSize = new System.Drawing.Size(191, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Press Arrow Keys - To Navigate";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPauseResume
            // 
            this.lblPauseResume.AutoSize = true;
            this.lblPauseResume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.lblPauseResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPauseResume.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPauseResume.Location = new System.Drawing.Point(66, 21);
            this.lblPauseResume.Margin = new System.Windows.Forms.Padding(0);
            this.lblPauseResume.MinimumSize = new System.Drawing.Size(191, 16);
            this.lblPauseResume.Name = "lblPauseResume";
            this.lblPauseResume.Size = new System.Drawing.Size(197, 16);
            this.lblPauseResume.TabIndex = 5;
            this.lblPauseResume.Text = "Prese Space - Pause/Resume Game";
            this.lblPauseResume.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.lblStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStart.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStart.Location = new System.Drawing.Point(66, 3);
            this.lblStart.Margin = new System.Windows.Forms.Padding(0);
            this.lblStart.MinimumSize = new System.Drawing.Size(191, 16);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(191, 16);
            this.lblStart.TabIndex = 4;
            this.lblStart.Text = "Prese Enter - New Game";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.ForestGreen;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(673, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.MinimumSize = new System.Drawing.Size(65, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Food";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSnakeColor
            // 
            this.lblSnakeColor.AutoSize = true;
            this.lblSnakeColor.BackColor = System.Drawing.Color.DarkOrange;
            this.lblSnakeColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSnakeColor.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSnakeColor.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblSnakeColor.Location = new System.Drawing.Point(594, 18);
            this.lblSnakeColor.Margin = new System.Windows.Forms.Padding(0);
            this.lblSnakeColor.MinimumSize = new System.Drawing.Size(65, 22);
            this.lblSnakeColor.Name = "lblSnakeColor";
            this.lblSnakeColor.Size = new System.Drawing.Size(65, 22);
            this.lblSnakeColor.TabIndex = 1;
            this.lblSnakeColor.Text = "Snake";
            this.lblSnakeColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblScore.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScore.Location = new System.Drawing.Point(417, 17);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(25, 25);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "0";
            // 
            // lblScoreText
            // 
            this.lblScoreText.AutoSize = true;
            this.lblScoreText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblScoreText.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScoreText.Location = new System.Drawing.Point(337, 16);
            this.lblScoreText.Name = "lblScoreText";
            this.lblScoreText.Size = new System.Drawing.Size(87, 25);
            this.lblScoreText.TabIndex = 1;
            this.lblScoreText.Text = "Score : ";
            // 
            // lblFood
            // 
            this.lblFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFood.AutoSize = true;
            this.lblFood.BackColor = System.Drawing.Color.Green;
            this.lblFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFood.Location = new System.Drawing.Point(329, 265);
            this.lblFood.MinimumSize = new System.Drawing.Size(22, 22);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(22, 22);
            this.lblFood.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // SnakeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lblFood);
            this.Controls.Add(this.pnlShade);
            this.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.GhostWhite;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SnakeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SnakeForm_KeyDown);
            this.pnlShade.ResumeLayout(false);
            this.pnlShade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlShade;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.Label lblScoreText;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSnakeColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPauseResume;
    }
}

