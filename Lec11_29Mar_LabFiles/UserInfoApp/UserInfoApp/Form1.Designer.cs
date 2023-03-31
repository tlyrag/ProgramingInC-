namespace UserInfoApp
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
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.UserIdLabel = new System.Windows.Forms.Label();
            this.UserIdTextBox = new System.Windows.Forms.TextBox();
            this.UserAgeLabel = new System.Windows.Forms.Label();
            this.UserAgeTextBox = new System.Windows.Forms.TextBox();
            this.AddUserBtn = new System.Windows.Forms.Button();
            this.SortUsersByAgeBtn = new System.Windows.Forms.Button();
            this.DeleteSelUserBtn = new System.Windows.Forms.Button();
            this.ReadFromFileBtn = new System.Windows.Forms.Button();
            this.WriteToFileBtn = new System.Windows.Forms.Button();
            this.Add10ToEachUserBtn = new System.Windows.Forms.Button();
            this.Sub10FromSelUserBtn = new System.Windows.Forms.Button();
            this.UpdateSelectedUserBtn = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.OutputListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(32, 35);
            this.UserNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(63, 13);
            this.UserNameLabel.TabIndex = 0;
            this.UserNameLabel.Text = "User Name:";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(96, 35);
            this.UserNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(76, 20);
            this.UserNameTextBox.TabIndex = 1;
            this.UserNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // UserIdLabel
            // 
            this.UserIdLabel.AutoSize = true;
            this.UserIdLabel.Location = new System.Drawing.Point(51, 58);
            this.UserIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserIdLabel.Name = "UserIdLabel";
            this.UserIdLabel.Size = new System.Drawing.Size(44, 13);
            this.UserIdLabel.TabIndex = 2;
            this.UserIdLabel.Text = "User Id:";
            // 
            // UserIdTextBox
            // 
            this.UserIdTextBox.Location = new System.Drawing.Point(96, 58);
            this.UserIdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.UserIdTextBox.Name = "UserIdTextBox";
            this.UserIdTextBox.Size = new System.Drawing.Size(76, 20);
            this.UserIdTextBox.TabIndex = 3;
            // 
            // UserAgeLabel
            // 
            this.UserAgeLabel.AutoSize = true;
            this.UserAgeLabel.Location = new System.Drawing.Point(40, 85);
            this.UserAgeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserAgeLabel.Name = "UserAgeLabel";
            this.UserAgeLabel.Size = new System.Drawing.Size(54, 13);
            this.UserAgeLabel.TabIndex = 4;
            this.UserAgeLabel.Text = "User Age:";
            // 
            // UserAgeTextBox
            // 
            this.UserAgeTextBox.Location = new System.Drawing.Point(96, 80);
            this.UserAgeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.UserAgeTextBox.Name = "UserAgeTextBox";
            this.UserAgeTextBox.Size = new System.Drawing.Size(76, 20);
            this.UserAgeTextBox.TabIndex = 5;
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.Location = new System.Drawing.Point(81, 214);
            this.AddUserBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Size = new System.Drawing.Size(75, 46);
            this.AddUserBtn.TabIndex = 6;
            this.AddUserBtn.Text = "Add User";
            this.AddUserBtn.UseVisualStyleBackColor = true;
            this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            // 
            // SortUsersByAgeBtn
            // 
            this.SortUsersByAgeBtn.Location = new System.Drawing.Point(617, 175);
            this.SortUsersByAgeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SortUsersByAgeBtn.Name = "SortUsersByAgeBtn";
            this.SortUsersByAgeBtn.Size = new System.Drawing.Size(120, 34);
            this.SortUsersByAgeBtn.TabIndex = 30;
            this.SortUsersByAgeBtn.Text = "Sort Users By Age";
            this.SortUsersByAgeBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteSelUserBtn
            // 
            this.DeleteSelUserBtn.Location = new System.Drawing.Point(617, 224);
            this.DeleteSelUserBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteSelUserBtn.Name = "DeleteSelUserBtn";
            this.DeleteSelUserBtn.Size = new System.Drawing.Size(123, 39);
            this.DeleteSelUserBtn.TabIndex = 29;
            this.DeleteSelUserBtn.Text = "Delete Selected User";
            this.DeleteSelUserBtn.UseVisualStyleBackColor = true;
            // 
            // ReadFromFileBtn
            // 
            this.ReadFromFileBtn.Location = new System.Drawing.Point(620, 56);
            this.ReadFromFileBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ReadFromFileBtn.Name = "ReadFromFileBtn";
            this.ReadFromFileBtn.Size = new System.Drawing.Size(120, 42);
            this.ReadFromFileBtn.TabIndex = 28;
            this.ReadFromFileBtn.Text = "Read Users From File";
            this.ReadFromFileBtn.UseVisualStyleBackColor = true;
            // 
            // WriteToFileBtn
            // 
            this.WriteToFileBtn.Location = new System.Drawing.Point(617, 115);
            this.WriteToFileBtn.Margin = new System.Windows.Forms.Padding(2);
            this.WriteToFileBtn.Name = "WriteToFileBtn";
            this.WriteToFileBtn.Size = new System.Drawing.Size(170, 39);
            this.WriteToFileBtn.TabIndex = 27;
            this.WriteToFileBtn.Text = "Write Users To File";
            this.WriteToFileBtn.UseVisualStyleBackColor = true;
            // 
            // Add10ToEachUserBtn
            // 
            this.Add10ToEachUserBtn.Location = new System.Drawing.Point(444, 214);
            this.Add10ToEachUserBtn.Margin = new System.Windows.Forms.Padding(2);
            this.Add10ToEachUserBtn.Name = "Add10ToEachUserBtn";
            this.Add10ToEachUserBtn.Size = new System.Drawing.Size(142, 54);
            this.Add10ToEachUserBtn.TabIndex = 26;
            this.Add10ToEachUserBtn.Text = "Add 10 Years to Every User";
            this.Add10ToEachUserBtn.UseVisualStyleBackColor = true;
            // 
            // Sub10FromSelUserBtn
            // 
            this.Sub10FromSelUserBtn.Location = new System.Drawing.Point(275, 210);
            this.Sub10FromSelUserBtn.Margin = new System.Windows.Forms.Padding(2);
            this.Sub10FromSelUserBtn.Name = "Sub10FromSelUserBtn";
            this.Sub10FromSelUserBtn.Size = new System.Drawing.Size(153, 57);
            this.Sub10FromSelUserBtn.TabIndex = 25;
            this.Sub10FromSelUserBtn.Text = "Subtract 10 Years From Selected User";
            this.Sub10FromSelUserBtn.UseVisualStyleBackColor = true;
            // 
            // UpdateSelectedUserBtn
            // 
            this.UpdateSelectedUserBtn.Location = new System.Drawing.Point(184, 206);
            this.UpdateSelectedUserBtn.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateSelectedUserBtn.Name = "UpdateSelectedUserBtn";
            this.UpdateSelectedUserBtn.Size = new System.Drawing.Size(73, 61);
            this.UpdateSelectedUserBtn.TabIndex = 24;
            this.UpdateSelectedUserBtn.Text = "Update Selected User";
            this.UpdateSelectedUserBtn.UseVisualStyleBackColor = true;
            this.UpdateSelectedUserBtn.Click += new System.EventHandler(this.UpdateSelectedUserBtn_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.StatusLabel.Location = new System.Drawing.Point(180, 291);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(422, 45);
            this.StatusLabel.TabIndex = 31;
            this.StatusLabel.Text = "Status Will be displayed here";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OutputListBox
            // 
            this.OutputListBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputListBox.FormattingEnabled = true;
            this.OutputListBox.ItemHeight = 14;
            this.OutputListBox.Items.AddRange(new object[] {
            "Line 1",
            "Line 2",
            "Line 3"});
            this.OutputListBox.Location = new System.Drawing.Point(219, 35);
            this.OutputListBox.Name = "OutputListBox";
            this.OutputListBox.Size = new System.Drawing.Size(367, 158);
            this.OutputListBox.TabIndex = 32;
            this.OutputListBox.SelectedIndexChanged += new System.EventHandler(this.OutputListBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(963, 396);
            this.Controls.Add(this.OutputListBox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.SortUsersByAgeBtn);
            this.Controls.Add(this.DeleteSelUserBtn);
            this.Controls.Add(this.ReadFromFileBtn);
            this.Controls.Add(this.WriteToFileBtn);
            this.Controls.Add(this.Add10ToEachUserBtn);
            this.Controls.Add(this.Sub10FromSelUserBtn);
            this.Controls.Add(this.UpdateSelectedUserBtn);
            this.Controls.Add(this.AddUserBtn);
            this.Controls.Add(this.UserAgeTextBox);
            this.Controls.Add(this.UserAgeLabel);
            this.Controls.Add(this.UserIdTextBox);
            this.Controls.Add(this.UserIdLabel);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.UserNameLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label UserIdLabel;
        private System.Windows.Forms.TextBox UserIdTextBox;
        private System.Windows.Forms.Label UserAgeLabel;
        private System.Windows.Forms.TextBox UserAgeTextBox;
        private System.Windows.Forms.Button AddUserBtn;
        private System.Windows.Forms.Button SortUsersByAgeBtn;
        private System.Windows.Forms.Button DeleteSelUserBtn;
        private System.Windows.Forms.Button ReadFromFileBtn;
        private System.Windows.Forms.Button WriteToFileBtn;
        private System.Windows.Forms.Button Add10ToEachUserBtn;
        private System.Windows.Forms.Button Sub10FromSelUserBtn;
        private System.Windows.Forms.Button UpdateSelectedUserBtn;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.ListBox OutputListBox;
    }
}

