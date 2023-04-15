namespace TestScores
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
            this.scoreListBox = new System.Windows.Forms.ListBox();
            this.ScoreTitleLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.AverageScoreLB = new System.Windows.Forms.Label();
            this.MaxScoreLabel = new System.Windows.Forms.Label();
            this.MinScoreLabel = new System.Windows.Forms.Label();
            this.AvgScoreValue = new System.Windows.Forms.Label();
            this.MinScoreValue = new System.Windows.Forms.Label();
            this.MaxScoreValue = new System.Windows.Forms.Label();
            this.ReadBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.UpdateTextBox = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.AddTextBox = new System.Windows.Forms.TextBox();
            this.PerformCompBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // scoreListBox
            // 
            this.scoreListBox.FormattingEnabled = true;
            this.scoreListBox.Location = new System.Drawing.Point(179, 57);
            this.scoreListBox.Name = "scoreListBox";
            this.scoreListBox.Size = new System.Drawing.Size(388, 251);
            this.scoreListBox.TabIndex = 0;
            // 
            // ScoreTitleLabel
            // 
            this.ScoreTitleLabel.Location = new System.Drawing.Point(179, 9);
            this.ScoreTitleLabel.Name = "ScoreTitleLabel";
            this.ScoreTitleLabel.Size = new System.Drawing.Size(388, 45);
            this.ScoreTitleLabel.TabIndex = 1;
            this.ScoreTitleLabel.Text = "Score Program";
            this.ScoreTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StatusLabel.Location = new System.Drawing.Point(179, 345);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(388, 72);
            this.StatusLabel.TabIndex = 2;
            this.StatusLabel.Text = "Status Will Show Here";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AverageScoreLB
            // 
            this.AverageScoreLB.AutoSize = true;
            this.AverageScoreLB.Location = new System.Drawing.Point(583, 70);
            this.AverageScoreLB.Name = "AverageScoreLB";
            this.AverageScoreLB.Size = new System.Drawing.Size(78, 13);
            this.AverageScoreLB.TabIndex = 3;
            this.AverageScoreLB.Text = "Average Score";
            // 
            // MaxScoreLabel
            // 
            this.MaxScoreLabel.AutoSize = true;
            this.MaxScoreLabel.Location = new System.Drawing.Point(587, 145);
            this.MaxScoreLabel.Name = "MaxScoreLabel";
            this.MaxScoreLabel.Size = new System.Drawing.Size(74, 13);
            this.MaxScoreLabel.TabIndex = 4;
            this.MaxScoreLabel.Text = "Maxium Score";
            // 
            // MinScoreLabel
            // 
            this.MinScoreLabel.AutoSize = true;
            this.MinScoreLabel.Location = new System.Drawing.Point(583, 107);
            this.MinScoreLabel.Name = "MinScoreLabel";
            this.MinScoreLabel.Size = new System.Drawing.Size(79, 13);
            this.MinScoreLabel.TabIndex = 5;
            this.MinScoreLabel.Text = "Minimum Score";
            // 
            // AvgScoreValue
            // 
            this.AvgScoreValue.AutoSize = true;
            this.AvgScoreValue.Location = new System.Drawing.Point(682, 70);
            this.AvgScoreValue.Name = "AvgScoreValue";
            this.AvgScoreValue.Size = new System.Drawing.Size(35, 13);
            this.AvgScoreValue.TabIndex = 6;
            this.AvgScoreValue.Text = "label6";
            // 
            // MinScoreValue
            // 
            this.MinScoreValue.AutoSize = true;
            this.MinScoreValue.Location = new System.Drawing.Point(682, 107);
            this.MinScoreValue.Name = "MinScoreValue";
            this.MinScoreValue.Size = new System.Drawing.Size(35, 13);
            this.MinScoreValue.TabIndex = 7;
            this.MinScoreValue.Text = "label7";
            // 
            // MaxScoreValue
            // 
            this.MaxScoreValue.AutoSize = true;
            this.MaxScoreValue.Location = new System.Drawing.Point(682, 145);
            this.MaxScoreValue.Name = "MaxScoreValue";
            this.MaxScoreValue.Size = new System.Drawing.Size(35, 13);
            this.MaxScoreValue.TabIndex = 8;
            this.MaxScoreValue.Text = "label8";
            // 
            // ReadBtn
            // 
            this.ReadBtn.Location = new System.Drawing.Point(13, 9);
            this.ReadBtn.Name = "ReadBtn";
            this.ReadBtn.Size = new System.Drawing.Size(75, 23);
            this.ReadBtn.TabIndex = 9;
            this.ReadBtn.Text = "Read File";
            this.ReadBtn.UseVisualStyleBackColor = true;
            this.ReadBtn.Click += new System.EventHandler(this.ReadBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(13, 97);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 9;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(13, 135);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 9;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(13, 205);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 9;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // UpdateTextBox
            // 
            this.UpdateTextBox.Location = new System.Drawing.Point(95, 99);
            this.UpdateTextBox.Name = "UpdateTextBox";
            this.UpdateTextBox.Size = new System.Drawing.Size(78, 20);
            this.UpdateTextBox.TabIndex = 10;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(13, 65);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 11;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // AddTextBox
            // 
            this.AddTextBox.Location = new System.Drawing.Point(95, 67);
            this.AddTextBox.Name = "AddTextBox";
            this.AddTextBox.Size = new System.Drawing.Size(78, 20);
            this.AddTextBox.TabIndex = 12;
            // 
            // PerformCompBtn
            // 
            this.PerformCompBtn.Location = new System.Drawing.Point(13, 36);
            this.PerformCompBtn.Name = "PerformCompBtn";
            this.PerformCompBtn.Size = new System.Drawing.Size(75, 23);
            this.PerformCompBtn.TabIndex = 13;
            this.PerformCompBtn.Text = "Perform Computations";
            this.PerformCompBtn.UseVisualStyleBackColor = true;
            this.PerformCompBtn.Click += new System.EventHandler(this.PerformCompBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PerformCompBtn);
            this.Controls.Add(this.AddTextBox);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.UpdateTextBox);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.ReadBtn);
            this.Controls.Add(this.MaxScoreValue);
            this.Controls.Add(this.MinScoreValue);
            this.Controls.Add(this.AvgScoreValue);
            this.Controls.Add(this.MinScoreLabel);
            this.Controls.Add(this.MaxScoreLabel);
            this.Controls.Add(this.AverageScoreLB);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.ScoreTitleLabel);
            this.Controls.Add(this.scoreListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox scoreListBox;
        private System.Windows.Forms.Label ScoreTitleLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label AverageScoreLB;
        private System.Windows.Forms.Label MaxScoreLabel;
        private System.Windows.Forms.Label MinScoreLabel;
        private System.Windows.Forms.Label AvgScoreValue;
        private System.Windows.Forms.Label MinScoreValue;
        private System.Windows.Forms.Label MaxScoreValue;
        private System.Windows.Forms.Button ReadBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox UpdateTextBox;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox AddTextBox;
        private System.Windows.Forms.Button PerformCompBtn;
    }
}

