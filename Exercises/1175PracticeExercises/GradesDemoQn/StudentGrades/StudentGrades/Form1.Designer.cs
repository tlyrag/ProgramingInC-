namespace StudentGrades
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
            this.StudListBox = new System.Windows.Forms.ListBox();
            this.Title = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.ReadFileBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SortBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.AvgLbl = new System.Windows.Forms.Label();
            this.AvgGrade = new System.Windows.Forms.Label();
            this.MaxLbl = new System.Windows.Forms.Label();
            this.MaxGrade = new System.Windows.Forms.Label();
            this.MinLbl = new System.Windows.Forms.Label();
            this.MinGrade = new System.Windows.Forms.Label();
            this.ClassifyBtn = new System.Windows.Forms.Button();
            this.QuizzLbl = new System.Windows.Forms.Label();
            this.MidLbl = new System.Windows.Forms.Label();
            this.Final = new System.Windows.Forms.Label();
            this.QuizTextBox = new System.Windows.Forms.TextBox();
            this.MidTermTextBox = new System.Windows.Forms.TextBox();
            this.FinalsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // StudListBox
            // 
            this.StudListBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudListBox.FormattingEnabled = true;
            this.StudListBox.ItemHeight = 14;
            this.StudListBox.Location = new System.Drawing.Point(162, 57);
            this.StudListBox.Name = "StudListBox";
            this.StudListBox.Size = new System.Drawing.Size(1001, 270);
            this.StudListBox.TabIndex = 0;
            this.StudListBox.SelectedIndexChanged += new System.EventHandler(this.StudListBox_SelectedIndexChanged);
            // 
            // Title
            // 
            this.Title.ForeColor = System.Drawing.Color.IndianRed;
            this.Title.Location = new System.Drawing.Point(350, 20);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(416, 23);
            this.Title.TabIndex = 1;
            this.Title.Text = "Student Grades";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StatusLabel.Location = new System.Drawing.Point(196, 379);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(413, 62);
            this.StatusLabel.TabIndex = 1;
            this.StatusLabel.Text = "Updates Will Show Here";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReadFileBtn
            // 
            this.ReadFileBtn.Location = new System.Drawing.Point(15, 57);
            this.ReadFileBtn.Name = "ReadFileBtn";
            this.ReadFileBtn.Size = new System.Drawing.Size(75, 23);
            this.ReadFileBtn.TabIndex = 2;
            this.ReadFileBtn.Text = "Read File";
            this.ReadFileBtn.UseVisualStyleBackColor = true;
            this.ReadFileBtn.Click += new System.EventHandler(this.ReadFileBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(15, 232);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(105, 23);
            this.UpdateBtn.TabIndex = 2;
            this.UpdateBtn.Text = "Update Student";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(15, 274);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(105, 23);
            this.DeleteBtn.TabIndex = 2;
            this.DeleteBtn.Text = "Delete Student";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // SortBtn
            // 
            this.SortBtn.Location = new System.Drawing.Point(15, 318);
            this.SortBtn.Name = "SortBtn";
            this.SortBtn.Size = new System.Drawing.Size(105, 23);
            this.SortBtn.TabIndex = 2;
            this.SortBtn.Text = "Sort Student";
            this.SortBtn.UseVisualStyleBackColor = true;
            this.SortBtn.Click += new System.EventHandler(this.SortBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(15, 366);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(105, 23);
            this.SaveBtn.TabIndex = 2;
            this.SaveBtn.Text = "Save File";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // AvgLbl
            // 
            this.AvgLbl.AutoSize = true;
            this.AvgLbl.Location = new System.Drawing.Point(728, 352);
            this.AvgLbl.Name = "AvgLbl";
            this.AvgLbl.Size = new System.Drawing.Size(47, 13);
            this.AvgLbl.TabIndex = 3;
            this.AvgLbl.Text = "Average";
            // 
            // AvgGrade
            // 
            this.AvgGrade.AutoSize = true;
            this.AvgGrade.Location = new System.Drawing.Point(790, 352);
            this.AvgGrade.Name = "AvgGrade";
            this.AvgGrade.Size = new System.Drawing.Size(79, 13);
            this.AvgGrade.TabIndex = 3;
            this.AvgGrade.Text = "Average Grade";
            // 
            // MaxLbl
            // 
            this.MaxLbl.AutoSize = true;
            this.MaxLbl.Location = new System.Drawing.Point(728, 388);
            this.MaxLbl.Name = "MaxLbl";
            this.MaxLbl.Size = new System.Drawing.Size(27, 13);
            this.MaxLbl.TabIndex = 3;
            this.MaxLbl.Text = "Max";
            // 
            // MaxGrade
            // 
            this.MaxGrade.AutoSize = true;
            this.MaxGrade.Location = new System.Drawing.Point(790, 388);
            this.MaxGrade.Name = "MaxGrade";
            this.MaxGrade.Size = new System.Drawing.Size(83, 13);
            this.MaxGrade.TabIndex = 3;
            this.MaxGrade.Text = "Maximum Grade";
            // 
            // MinLbl
            // 
            this.MinLbl.AutoSize = true;
            this.MinLbl.Location = new System.Drawing.Point(728, 431);
            this.MinLbl.Name = "MinLbl";
            this.MinLbl.Size = new System.Drawing.Size(48, 13);
            this.MinLbl.TabIndex = 3;
            this.MinLbl.Text = "Minimum";
            // 
            // MinGrade
            // 
            this.MinGrade.AutoSize = true;
            this.MinGrade.Location = new System.Drawing.Point(790, 431);
            this.MinGrade.Name = "MinGrade";
            this.MinGrade.Size = new System.Drawing.Size(80, 13);
            this.MinGrade.TabIndex = 3;
            this.MinGrade.Text = "Minimum Grade";
            // 
            // ClassifyBtn
            // 
            this.ClassifyBtn.Location = new System.Drawing.Point(15, 404);
            this.ClassifyBtn.Name = "ClassifyBtn";
            this.ClassifyBtn.Size = new System.Drawing.Size(105, 23);
            this.ClassifyBtn.TabIndex = 4;
            this.ClassifyBtn.Text = "Classify Students";
            this.ClassifyBtn.UseVisualStyleBackColor = true;
            // 
            // QuizzLbl
            // 
            this.QuizzLbl.AutoSize = true;
            this.QuizzLbl.Location = new System.Drawing.Point(0, 106);
            this.QuizzLbl.Name = "QuizzLbl";
            this.QuizzLbl.Size = new System.Drawing.Size(64, 13);
            this.QuizzLbl.TabIndex = 5;
            this.QuizzLbl.Text = "Quizz Score";
            // 
            // MidLbl
            // 
            this.MidLbl.AutoSize = true;
            this.MidLbl.Location = new System.Drawing.Point(0, 132);
            this.MidLbl.Name = "MidLbl";
            this.MidLbl.Size = new System.Drawing.Size(79, 13);
            this.MidLbl.TabIndex = 5;
            this.MidLbl.Text = "MidTerm Score";
            // 
            // Final
            // 
            this.Final.AutoSize = true;
            this.Final.Location = new System.Drawing.Point(0, 161);
            this.Final.Name = "Final";
            this.Final.Size = new System.Drawing.Size(60, 13);
            this.Final.TabIndex = 5;
            this.Final.Text = "Final Score";
            // 
            // QuizTextBox
            // 
            this.QuizTextBox.Location = new System.Drawing.Point(85, 99);
            this.QuizTextBox.Name = "QuizTextBox";
            this.QuizTextBox.Size = new System.Drawing.Size(71, 20);
            this.QuizTextBox.TabIndex = 6;
            // 
            // MidTermTextBox
            // 
            this.MidTermTextBox.Location = new System.Drawing.Point(85, 125);
            this.MidTermTextBox.Name = "MidTermTextBox";
            this.MidTermTextBox.Size = new System.Drawing.Size(71, 20);
            this.MidTermTextBox.TabIndex = 6;
            // 
            // FinalsTextBox
            // 
            this.FinalsTextBox.Location = new System.Drawing.Point(85, 158);
            this.FinalsTextBox.Name = "FinalsTextBox";
            this.FinalsTextBox.Size = new System.Drawing.Size(71, 20);
            this.FinalsTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 450);
            this.Controls.Add(this.FinalsTextBox);
            this.Controls.Add(this.MidTermTextBox);
            this.Controls.Add(this.QuizTextBox);
            this.Controls.Add(this.Final);
            this.Controls.Add(this.MidLbl);
            this.Controls.Add(this.QuizzLbl);
            this.Controls.Add(this.ClassifyBtn);
            this.Controls.Add(this.MinGrade);
            this.Controls.Add(this.MinLbl);
            this.Controls.Add(this.MaxGrade);
            this.Controls.Add(this.MaxLbl);
            this.Controls.Add(this.AvgGrade);
            this.Controls.Add(this.AvgLbl);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.SortBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.ReadFileBtn);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.StudListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox StudListBox;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button ReadFileBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button SortBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label AvgLbl;
        private System.Windows.Forms.Label AvgGrade;
        private System.Windows.Forms.Label MaxLbl;
        private System.Windows.Forms.Label MaxGrade;
        private System.Windows.Forms.Label MinLbl;
        private System.Windows.Forms.Label MinGrade;
        private System.Windows.Forms.Button ClassifyBtn;
        private System.Windows.Forms.Label QuizzLbl;
        private System.Windows.Forms.Label MidLbl;
        private System.Windows.Forms.Label Final;
        private System.Windows.Forms.TextBox QuizTextBox;
        private System.Windows.Forms.TextBox MidTermTextBox;
        private System.Windows.Forms.TextBox FinalsTextBox;
    }
}

