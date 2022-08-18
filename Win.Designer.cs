namespace TicTacToe
{
    partial class Win
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
            this.SuccessLabel = new System.Windows.Forms.Label();
            this.RestartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SuccessLabel
            // 
            this.SuccessLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SuccessLabel.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SuccessLabel.ForeColor = System.Drawing.Color.White;
            this.SuccessLabel.Location = new System.Drawing.Point(12, 71);
            this.SuccessLabel.Name = "SuccessLabel";
            this.SuccessLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SuccessLabel.Size = new System.Drawing.Size(360, 54);
            this.SuccessLabel.TabIndex = 0;
            this.SuccessLabel.Text = "label1";
            this.SuccessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SuccessLabel.Click += new System.EventHandler(this.SuccessLabel_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.AccessibleName = "box3";
            this.RestartButton.BackColor = System.Drawing.Color.Black;
            this.RestartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RestartButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.RestartButton.FlatAppearance.BorderSize = 3;
            this.RestartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestartButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RestartButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RestartButton.Location = new System.Drawing.Point(108, 152);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RestartButton.Size = new System.Drawing.Size(157, 55);
            this.RestartButton.TabIndex = 3;
            this.RestartButton.Text = "RESTART";
            this.RestartButton.UseVisualStyleBackColor = false;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // Win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.SuccessLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 300);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Win";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Win_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label SuccessLabel;
        private Button RestartButton;
    }
}