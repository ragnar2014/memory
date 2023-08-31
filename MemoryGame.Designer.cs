namespace Memory
{
    partial class MemoryGame
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
            this.GamePlan = new System.Windows.Forms.TableLayoutPanel();
            this.PointsText = new System.Windows.Forms.Label();
            this.PointLabel = new System.Windows.Forms.Label();
            this.GameOver = new System.Windows.Forms.Label();
            this.RestartBtn = new System.Windows.Forms.Button();
            this.QuitBtn = new System.Windows.Forms.Button();
            this.GuessText = new System.Windows.Forms.Label();
            this.GuessLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GamePlan
            // 
            this.GamePlan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GamePlan.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.GamePlan.ColumnCount = 4;
            this.GamePlan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.GamePlan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.GamePlan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.GamePlan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.GamePlan.Dock = System.Windows.Forms.DockStyle.Left;
            this.GamePlan.Location = new System.Drawing.Point(0, 0);
            this.GamePlan.Name = "GamePlan";
            this.GamePlan.RowCount = 4;
            this.GamePlan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.GamePlan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.GamePlan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.GamePlan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.GamePlan.Size = new System.Drawing.Size(534, 511);
            this.GamePlan.TabIndex = 0;
            // 
            // PointsText
            // 
            this.PointsText.AutoSize = true;
            this.PointsText.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PointsText.Location = new System.Drawing.Point(555, 26);
            this.PointsText.Name = "PointsText";
            this.PointsText.Size = new System.Drawing.Size(107, 45);
            this.PointsText.TabIndex = 1;
            this.PointsText.Text = "Points";
            // 
            // PointLabel
            // 
            this.PointLabel.AutoSize = true;
            this.PointLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PointLabel.Location = new System.Drawing.Point(594, 96);
            this.PointLabel.Name = "PointLabel";
            this.PointLabel.Size = new System.Drawing.Size(27, 32);
            this.PointLabel.TabIndex = 2;
            this.PointLabel.Text = "0";
            // 
            // GameOver
            // 
            this.GameOver.AutoSize = true;
            this.GameOver.BackColor = System.Drawing.Color.LawnGreen;
            this.GameOver.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GameOver.Location = new System.Drawing.Point(536, 403);
            this.GameOver.Name = "GameOver";
            this.GameOver.Size = new System.Drawing.Size(126, 30);
            this.GameOver.TabIndex = 3;
            this.GameOver.Text = "Game over!";
            this.GameOver.Visible = false;
            // 
            // RestartBtn
            // 
            this.RestartBtn.Location = new System.Drawing.Point(546, 445);
            this.RestartBtn.Name = "RestartBtn";
            this.RestartBtn.Size = new System.Drawing.Size(54, 23);
            this.RestartBtn.TabIndex = 4;
            this.RestartBtn.Text = "Restart";
            this.RestartBtn.UseVisualStyleBackColor = true;
            this.RestartBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StartGame);
            // 
            // QuitBtn
            // 
            this.QuitBtn.Location = new System.Drawing.Point(600, 445);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(54, 23);
            this.QuitBtn.TabIndex = 5;
            this.QuitBtn.Text = "Quit";
            this.QuitBtn.UseVisualStyleBackColor = true;
            this.QuitBtn.Click += new System.EventHandler(this.CloseApp);
            // 
            // GuessText
            // 
            this.GuessText.AutoSize = true;
            this.GuessText.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GuessText.Location = new System.Drawing.Point(545, 149);
            this.GuessText.Name = "GuessText";
            this.GuessText.Size = new System.Drawing.Size(136, 45);
            this.GuessText.TabIndex = 6;
            this.GuessText.Text = "Guesses";
            // 
            // GuessLabel
            // 
            this.GuessLabel.AutoSize = true;
            this.GuessLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GuessLabel.Location = new System.Drawing.Point(594, 210);
            this.GuessLabel.Name = "GuessLabel";
            this.GuessLabel.Size = new System.Drawing.Size(27, 32);
            this.GuessLabel.TabIndex = 8;
            this.GuessLabel.Text = "0";
            // 
            // MemoryGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.GuessLabel);
            this.Controls.Add(this.GuessText);
            this.Controls.Add(this.QuitBtn);
            this.Controls.Add(this.RestartBtn);
            this.Controls.Add(this.GameOver);
            this.Controls.Add(this.PointLabel);
            this.Controls.Add(this.PointsText);
            this.Controls.Add(this.GamePlan);
            this.Name = "MemoryGame";
            this.Text = "MemoryGame";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #endregion
        private Label Sqr = new Label();
        private TableLayoutPanel GamePlan;
        private Label PointsText;
        private Label PointLabel = new Label();
        private Label GameOver;
        private Button RestartBtn;
        private Button QuitBtn;
        private Label GuessText;
        private Label GuessLabel;
    }
}