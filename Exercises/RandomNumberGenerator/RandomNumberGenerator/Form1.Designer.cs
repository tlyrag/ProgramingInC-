namespace RandomNumberGenerator
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
            this.MinNumberTextBox = new System.Windows.Forms.TextBox();
            this.MaxNumberTextBox = new System.Windows.Forms.TextBox();
            this.ResultListBox = new System.Windows.Forms.ListBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.MinNumberLabel = new System.Windows.Forms.Label();
            this.MaxNumberLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MinNumberTextBox
            // 
            this.MinNumberTextBox.Location = new System.Drawing.Point(117, 57);
            this.MinNumberTextBox.Name = "MinNumberTextBox";
            this.MinNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.MinNumberTextBox.TabIndex = 0;
            // 
            // MaxNumberTextBox
            // 
            this.MaxNumberTextBox.Location = new System.Drawing.Point(117, 99);
            this.MaxNumberTextBox.Name = "MaxNumberTextBox";
            this.MaxNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.MaxNumberTextBox.TabIndex = 0;
            // 
            // ResultListBox
            // 
            this.ResultListBox.FormattingEnabled = true;
            this.ResultListBox.Location = new System.Drawing.Point(323, 39);
            this.ResultListBox.Name = "ResultListBox";
            this.ResultListBox.Size = new System.Drawing.Size(237, 160);
            this.ResultListBox.TabIndex = 1;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(16, 134);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(75, 23);
            this.GenerateButton.TabIndex = 2;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // MinNumberLabel
            // 
            this.MinNumberLabel.AutoSize = true;
            this.MinNumberLabel.Location = new System.Drawing.Point(13, 60);
            this.MinNumberLabel.Name = "MinNumberLabel";
            this.MinNumberLabel.Size = new System.Drawing.Size(92, 13);
            this.MinNumberLabel.TabIndex = 3;
            this.MinNumberLabel.Text = "Enter Min Number";
            // 
            // MaxNumberLabel
            // 
            this.MaxNumberLabel.AutoSize = true;
            this.MaxNumberLabel.Location = new System.Drawing.Point(13, 102);
            this.MaxNumberLabel.Name = "MaxNumberLabel";
            this.MaxNumberLabel.Size = new System.Drawing.Size(95, 13);
            this.MaxNumberLabel.TabIndex = 3;
            this.MaxNumberLabel.Text = "Enter Max Number";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(396, 205);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 592);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.MaxNumberLabel);
            this.Controls.Add(this.MinNumberLabel);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.ResultListBox);
            this.Controls.Add(this.MaxNumberTextBox);
            this.Controls.Add(this.MinNumberTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MinNumberTextBox;
        private System.Windows.Forms.TextBox MaxNumberTextBox;
        private System.Windows.Forms.ListBox ResultListBox;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Label MinNumberLabel;
        private System.Windows.Forms.Label MaxNumberLabel;
        private System.Windows.Forms.Button ClearButton;
    }
}

