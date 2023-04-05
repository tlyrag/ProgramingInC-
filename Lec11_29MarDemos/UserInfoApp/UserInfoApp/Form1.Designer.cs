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
            this.UserNameLabel.Location = new System.Drawing.Point(42, 43);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(79, 16);
            this.UserNameLabel.TabIndex = 0;
            this.UserNameLabel.Text = "User Name:";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(128, 43);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.UserNameTextBox.TabIndex = 1;
            this.UserNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // UserIdLabel
            // 
            this.UserIdLabel.AutoSize = true;
            this.UserIdLabel.Location = new System.Drawing.Point(68, 71);
            this.UserIdLabel.Name = "UserIdLabel";
            this.UserIdLabel.Size = new System.Drawing.Size(53, 16);
            this.UserIdLabel.TabIndex = 2;
            this.UserIdLabel.Text = "User Id:";
            // 
            // UserIdTextBox
            // 
            this.UserIdTextBox.Location = new System.Drawing.Point(128, 72);
            this.UserIdTextBox.Name = "UserIdTextBox";
            this.UserIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.UserIdTextBox.TabIndex = 3;
            // 
            // UserAgeLabel
            // 
            this.UserAgeLabel.AutoSize = true;
            this.UserAgeLabel.Location = new System.Drawing.Point(54, 105);
            this.UserAgeLabel.Name = "UserAgeLabel";
            this.UserAgeLabel.Size = new System.Drawing.Size(67, 16);
            this.UserAgeLabel.TabIndex = 4;
            this.UserAgeLabel.Text = "User Age:";
            // 
            // UserAgeTextBox
            // 
            this.UserAgeTextBox.Location = new System.Drawing.Point(128, 98);
            this.UserAgeTextBox.Name = "UserAgeTextBox";
            this.UserAgeTextBox.Size = new System.Drawing.Size(100, 22);
            this.UserAgeTextBox.TabIndex = 5;
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.Location = new System.Drawing.Point(128, 301);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Size = new System.Drawing.Size(87, 48);
            this.AddUserBtn.TabIndex = 6;
            this.AddUserBtn.Text = "Add User";
            this.AddUserBtn.UseVisualStyleBackColor = true;
            this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            // 
            // SortUsersByAgeBtn
            // 
            this.SortUsersByAgeBtn.Location = new System.Drawing.Point(914, 225);
            this.SortUsersByAgeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SortUsersByAgeBtn.Name = "SortUsersByAgeBtn";
            this.SortUsersByAgeBtn.Size = new System.Drawing.Size(160, 42);
            this.SortUsersByAgeBtn.TabIndex = 30;
            this.SortUsersByAgeBtn.Text = "Sort Users By Age";
            this.SortUsersByAgeBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteSelUserBtn
            // 
            this.DeleteSelUserBtn.Location = new System.Drawing.Point(842, 314);
            this.DeleteSelUserBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteSelUserBtn.Name = "DeleteSelUserBtn";
            this.DeleteSelUserBtn.Size = new System.Drawing.Size(164, 48);
            this.DeleteSelUserBtn.TabIndex = 29;
            this.DeleteSelUserBtn.Text = "Delete Selected User";
            this.DeleteSelUserBtn.UseVisualStyleBackColor = true;
            // 
            // ReadFromFileBtn
            // 
            this.ReadFromFileBtn.Location = new System.Drawing.Point(914, 77);
            this.ReadFromFileBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReadFromFileBtn.Name = "ReadFromFileBtn";
            this.ReadFromFileBtn.Size = new System.Drawing.Size(160, 52);
            this.ReadFromFileBtn.TabIndex = 28;
            this.ReadFromFileBtn.Text = "Read Users From File";
            this.ReadFromFileBtn.UseVisualStyleBackColor = true;
            // 
            // WriteToFileBtn
            // 
            this.WriteToFileBtn.Location = new System.Drawing.Point(885, 155);
            this.WriteToFileBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WriteToFileBtn.Name = "WriteToFileBtn";
            this.WriteToFileBtn.Size = new System.Drawing.Size(226, 48);
            this.WriteToFileBtn.TabIndex = 27;
            this.WriteToFileBtn.Text = "Write Users To File";
            this.WriteToFileBtn.UseVisualStyleBackColor = true;
            // 
            // Add10ToEachUserBtn
            // 
            this.Add10ToEachUserBtn.Location = new System.Drawing.Point(612, 301);
            this.Add10ToEachUserBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add10ToEachUserBtn.Name = "Add10ToEachUserBtn";
            this.Add10ToEachUserBtn.Size = new System.Drawing.Size(190, 66);
            this.Add10ToEachUserBtn.TabIndex = 26;
            this.Add10ToEachUserBtn.Text = "Add 10 Years to Every User";
            this.Add10ToEachUserBtn.UseVisualStyleBackColor = true;
            // 
            // Sub10FromSelUserBtn
            // 
            this.Sub10FromSelUserBtn.Location = new System.Drawing.Point(386, 297);
            this.Sub10FromSelUserBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sub10FromSelUserBtn.Name = "Sub10FromSelUserBtn";
            this.Sub10FromSelUserBtn.Size = new System.Drawing.Size(204, 70);
            this.Sub10FromSelUserBtn.TabIndex = 25;
            this.Sub10FromSelUserBtn.Text = "Subtract 10 Years From Selected User";
            this.Sub10FromSelUserBtn.UseVisualStyleBackColor = true;
            // 
            // UpdateSelectedUserBtn
            // 
            this.UpdateSelectedUserBtn.Location = new System.Drawing.Point(265, 292);
            this.UpdateSelectedUserBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateSelectedUserBtn.Name = "UpdateSelectedUserBtn";
            this.UpdateSelectedUserBtn.Size = new System.Drawing.Size(97, 75);
            this.UpdateSelectedUserBtn.TabIndex = 24;
            this.UpdateSelectedUserBtn.Text = "Update Selected User";
            this.UpdateSelectedUserBtn.UseVisualStyleBackColor = true;
            this.UpdateSelectedUserBtn.Click += new System.EventHandler(this.UpdateSelectedUserBtn_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.Color.PeachPuff;
            this.StatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(323, 402);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(573, 76);
            this.StatusLabel.TabIndex = 31;
            this.StatusLabel.Text = "Status will be displayed here";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OutputListBox
            // 
            this.OutputListBox.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputListBox.FormattingEnabled = true;
            this.OutputListBox.ItemHeight = 15;
            this.OutputListBox.Items.AddRange(new object[] {
            "line 1",
            "line 2",
            "line 3"});
            this.OutputListBox.Location = new System.Drawing.Point(278, 36);
            this.OutputListBox.Name = "OutputListBox";
            this.OutputListBox.Size = new System.Drawing.Size(578, 169);
            this.OutputListBox.TabIndex = 32;
            this.OutputListBox.SelectedIndexChanged += new System.EventHandler(this.OutputListBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 487);
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

