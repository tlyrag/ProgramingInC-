﻿namespace ShaolWFA
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
            this.locationLabel = new System.Windows.Forms.Label();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.mileMarkerTextBox = new System.Windows.Forms.TextBox();
            this.mileMarkerLabel = new System.Windows.Forms.Label();
            this.lowTidesLabel = new System.Windows.Forms.Label();
            this.highTidesLabel = new System.Windows.Forms.Label();
            this.lowTidesTB1 = new System.Windows.Forms.TextBox();
            this.lowTidesTB2 = new System.Windows.Forms.TextBox();
            this.lowTidesTB3 = new System.Windows.Forms.TextBox();
            this.lowTidesTB4 = new System.Windows.Forms.TextBox();
            this.highTidesTB4 = new System.Windows.Forms.TextBox();
            this.highTidesTB3 = new System.Windows.Forms.TextBox();
            this.highTidesTB2 = new System.Windows.Forms.TextBox();
            this.highTidesTB1 = new System.Windows.Forms.TextBox();
            this.addShoalButtonNew = new System.Windows.Forms.Button();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.btnReadFromFile = new System.Windows.Forms.Button();
            this.btnWriteFile = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.outputListBoxTitleLabel = new System.Windows.Forms.Label();
            this.updateSelectedItemButton = new System.Windows.Forms.Button();
            this.shoalTitleLabel = new System.Windows.Forms.Label();
            this.FilterBtn = new System.Windows.Forms.Button();
            this.FilteredListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(50, 75);
            this.locationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(61, 16);
            this.locationLabel.TabIndex = 0;
            this.locationLabel.Text = "Location:";
            this.locationLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(126, 71);
            this.locationTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(104, 22);
            this.locationTextBox.TabIndex = 1;
            // 
            // stateTextBox
            // 
            this.stateTextBox.Location = new System.Drawing.Point(126, 103);
            this.stateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(104, 22);
            this.stateTextBox.TabIndex = 3;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(71, 107);
            this.stateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(41, 16);
            this.stateLabel.TabIndex = 2;
            this.stateLabel.Text = "State:";
            // 
            // mileMarkerTextBox
            // 
            this.mileMarkerTextBox.Location = new System.Drawing.Point(126, 139);
            this.mileMarkerTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.mileMarkerTextBox.Name = "mileMarkerTextBox";
            this.mileMarkerTextBox.Size = new System.Drawing.Size(104, 22);
            this.mileMarkerTextBox.TabIndex = 5;
            // 
            // mileMarkerLabel
            // 
            this.mileMarkerLabel.AutoSize = true;
            this.mileMarkerLabel.Location = new System.Drawing.Point(31, 142);
            this.mileMarkerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mileMarkerLabel.Name = "mileMarkerLabel";
            this.mileMarkerLabel.Size = new System.Drawing.Size(80, 16);
            this.mileMarkerLabel.TabIndex = 4;
            this.mileMarkerLabel.Text = "Mile Marker:";
            // 
            // lowTidesLabel
            // 
            this.lowTidesLabel.AutoSize = true;
            this.lowTidesLabel.Location = new System.Drawing.Point(35, 181);
            this.lowTidesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lowTidesLabel.Name = "lowTidesLabel";
            this.lowTidesLabel.Size = new System.Drawing.Size(69, 16);
            this.lowTidesLabel.TabIndex = 6;
            this.lowTidesLabel.Text = "Low Tides";
            // 
            // highTidesLabel
            // 
            this.highTidesLabel.AutoSize = true;
            this.highTidesLabel.Location = new System.Drawing.Point(154, 181);
            this.highTidesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.highTidesLabel.Name = "highTidesLabel";
            this.highTidesLabel.Size = new System.Drawing.Size(73, 16);
            this.highTidesLabel.TabIndex = 7;
            this.highTidesLabel.Text = "High Tides";
            // 
            // lowTidesTB1
            // 
            this.lowTidesTB1.Location = new System.Drawing.Point(39, 213);
            this.lowTidesTB1.Margin = new System.Windows.Forms.Padding(4);
            this.lowTidesTB1.Name = "lowTidesTB1";
            this.lowTidesTB1.Size = new System.Drawing.Size(70, 22);
            this.lowTidesTB1.TabIndex = 8;
            // 
            // lowTidesTB2
            // 
            this.lowTidesTB2.Location = new System.Drawing.Point(39, 245);
            this.lowTidesTB2.Margin = new System.Windows.Forms.Padding(4);
            this.lowTidesTB2.Name = "lowTidesTB2";
            this.lowTidesTB2.Size = new System.Drawing.Size(70, 22);
            this.lowTidesTB2.TabIndex = 9;
            // 
            // lowTidesTB3
            // 
            this.lowTidesTB3.Location = new System.Drawing.Point(39, 277);
            this.lowTidesTB3.Margin = new System.Windows.Forms.Padding(4);
            this.lowTidesTB3.Name = "lowTidesTB3";
            this.lowTidesTB3.Size = new System.Drawing.Size(70, 22);
            this.lowTidesTB3.TabIndex = 10;
            // 
            // lowTidesTB4
            // 
            this.lowTidesTB4.Location = new System.Drawing.Point(39, 309);
            this.lowTidesTB4.Margin = new System.Windows.Forms.Padding(4);
            this.lowTidesTB4.Name = "lowTidesTB4";
            this.lowTidesTB4.Size = new System.Drawing.Size(70, 22);
            this.lowTidesTB4.TabIndex = 11;
            // 
            // highTidesTB4
            // 
            this.highTidesTB4.Location = new System.Drawing.Point(158, 309);
            this.highTidesTB4.Margin = new System.Windows.Forms.Padding(4);
            this.highTidesTB4.Name = "highTidesTB4";
            this.highTidesTB4.Size = new System.Drawing.Size(70, 22);
            this.highTidesTB4.TabIndex = 15;
            // 
            // highTidesTB3
            // 
            this.highTidesTB3.Location = new System.Drawing.Point(158, 277);
            this.highTidesTB3.Margin = new System.Windows.Forms.Padding(4);
            this.highTidesTB3.Name = "highTidesTB3";
            this.highTidesTB3.Size = new System.Drawing.Size(70, 22);
            this.highTidesTB3.TabIndex = 14;
            // 
            // highTidesTB2
            // 
            this.highTidesTB2.Location = new System.Drawing.Point(158, 245);
            this.highTidesTB2.Margin = new System.Windows.Forms.Padding(4);
            this.highTidesTB2.Name = "highTidesTB2";
            this.highTidesTB2.Size = new System.Drawing.Size(70, 22);
            this.highTidesTB2.TabIndex = 13;
            // 
            // highTidesTB1
            // 
            this.highTidesTB1.Location = new System.Drawing.Point(158, 213);
            this.highTidesTB1.Margin = new System.Windows.Forms.Padding(4);
            this.highTidesTB1.Name = "highTidesTB1";
            this.highTidesTB1.Size = new System.Drawing.Size(70, 22);
            this.highTidesTB1.TabIndex = 12;
            // 
            // addShoalButtonNew
            // 
            this.addShoalButtonNew.Location = new System.Drawing.Point(10, 366);
            this.addShoalButtonNew.Margin = new System.Windows.Forms.Padding(4);
            this.addShoalButtonNew.Name = "addShoalButtonNew";
            this.addShoalButtonNew.Size = new System.Drawing.Size(117, 46);
            this.addShoalButtonNew.TabIndex = 16;
            this.addShoalButtonNew.Text = "Add New Shoal Data";
            this.addShoalButtonNew.UseVisualStyleBackColor = true;
            this.addShoalButtonNew.Click += new System.EventHandler(this.AddShoalButton_Click);
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.ItemHeight = 16;
            this.outputListBox.Location = new System.Drawing.Point(258, 121);
            this.outputListBox.Margin = new System.Windows.Forms.Padding(4);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(744, 276);
            this.outputListBox.TabIndex = 17;
            this.outputListBox.SelectedIndexChanged += new System.EventHandler(this.OutputListBox_SelectedIndexChanged);
            // 
            // btnReadFromFile
            // 
            this.btnReadFromFile.Location = new System.Drawing.Point(558, 58);
            this.btnReadFromFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnReadFromFile.Name = "btnReadFromFile";
            this.btnReadFromFile.Size = new System.Drawing.Size(189, 50);
            this.btnReadFromFile.TabIndex = 19;
            this.btnReadFromFile.Text = "Read All Shoal Records From Input File";
            this.btnReadFromFile.UseVisualStyleBackColor = true;
            this.btnReadFromFile.Click += new System.EventHandler(this.BtnReadFromFile_Click);
            // 
            // btnWriteFile
            // 
            this.btnWriteFile.Location = new System.Drawing.Point(572, 411);
            this.btnWriteFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnWriteFile.Name = "btnWriteFile";
            this.btnWriteFile.Size = new System.Drawing.Size(167, 50);
            this.btnWriteFile.TabIndex = 20;
            this.btnWriteFile.Text = "Write All Shoal Objects To  Output File";
            this.btnWriteFile.UseVisualStyleBackColor = true;
            this.btnWriteFile.Click += new System.EventHandler(this.BtnWriteFile_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.statusLabel.Location = new System.Drawing.Point(283, 482);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(551, 66);
            this.statusLabel.TabIndex = 21;
            this.statusLabel.Text = "Status Label";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputListBoxTitleLabel
            // 
            this.outputListBoxTitleLabel.AutoSize = true;
            this.outputListBoxTitleLabel.Location = new System.Drawing.Point(357, 101);
            this.outputListBoxTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputListBoxTitleLabel.Name = "outputListBoxTitleLabel";
            this.outputListBoxTitleLabel.Size = new System.Drawing.Size(95, 16);
            this.outputListBoxTitleLabel.TabIndex = 24;
            this.outputListBoxTitleLabel.Text = "All Shoal Items";
            // 
            // updateSelectedItemButton
            // 
            this.updateSelectedItemButton.Location = new System.Drawing.Point(135, 363);
            this.updateSelectedItemButton.Margin = new System.Windows.Forms.Padding(4);
            this.updateSelectedItemButton.Name = "updateSelectedItemButton";
            this.updateSelectedItemButton.Size = new System.Drawing.Size(115, 53);
            this.updateSelectedItemButton.TabIndex = 25;
            this.updateSelectedItemButton.Text = "Update Selected Item";
            this.updateSelectedItemButton.UseVisualStyleBackColor = true;
            this.updateSelectedItemButton.Click += new System.EventHandler(this.updateSelectedItemButton_Click);
            // 
            // shoalTitleLabel
            // 
            this.shoalTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoalTitleLabel.Location = new System.Drawing.Point(352, -2);
            this.shoalTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shoalTitleLabel.Name = "shoalTitleLabel";
            this.shoalTitleLabel.Size = new System.Drawing.Size(388, 55);
            this.shoalTitleLabel.TabIndex = 26;
            this.shoalTitleLabel.Text = "Shoal Application";
            // 
            // FilterBtn
            // 
            this.FilterBtn.Location = new System.Drawing.Point(1054, 411);
            this.FilterBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FilterBtn.Name = "FilterBtn";
            this.FilterBtn.Size = new System.Drawing.Size(237, 60);
            this.FilterBtn.TabIndex = 30;
            this.FilterBtn.Text = "Show Shoal Items from California with High Tide Avg > 75";
            this.FilterBtn.UseVisualStyleBackColor = true;
            this.FilterBtn.Click += new System.EventHandler(this.FilterBtn_Click);
            // 
            // FilteredListBox
            // 
            this.FilteredListBox.FormattingEnabled = true;
            this.FilteredListBox.ItemHeight = 16;
            this.FilteredListBox.Location = new System.Drawing.Point(1009, 121);
            this.FilteredListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FilteredListBox.Name = "FilteredListBox";
            this.FilteredListBox.Size = new System.Drawing.Size(648, 276);
            this.FilteredListBox.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1669, 570);
            this.Controls.Add(this.FilterBtn);
            this.Controls.Add(this.FilteredListBox);
            this.Controls.Add(this.shoalTitleLabel);
            this.Controls.Add(this.updateSelectedItemButton);
            this.Controls.Add(this.outputListBoxTitleLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.btnWriteFile);
            this.Controls.Add(this.btnReadFromFile);
            this.Controls.Add(this.outputListBox);
            this.Controls.Add(this.addShoalButtonNew);
            this.Controls.Add(this.highTidesTB4);
            this.Controls.Add(this.highTidesTB3);
            this.Controls.Add(this.highTidesTB2);
            this.Controls.Add(this.highTidesTB1);
            this.Controls.Add(this.lowTidesTB4);
            this.Controls.Add(this.lowTidesTB3);
            this.Controls.Add(this.lowTidesTB2);
            this.Controls.Add(this.lowTidesTB1);
            this.Controls.Add(this.highTidesLabel);
            this.Controls.Add(this.lowTidesLabel);
            this.Controls.Add(this.mileMarkerTextBox);
            this.Controls.Add(this.mileMarkerLabel);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.locationLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.TextBox mileMarkerTextBox;
        private System.Windows.Forms.Label mileMarkerLabel;
        private System.Windows.Forms.Label lowTidesLabel;
        private System.Windows.Forms.Label highTidesLabel;
        private System.Windows.Forms.TextBox lowTidesTB1;
        private System.Windows.Forms.TextBox lowTidesTB2;
        private System.Windows.Forms.TextBox lowTidesTB3;
        private System.Windows.Forms.TextBox lowTidesTB4;
        private System.Windows.Forms.TextBox highTidesTB4;
        private System.Windows.Forms.TextBox highTidesTB3;
        private System.Windows.Forms.TextBox highTidesTB2;
        private System.Windows.Forms.TextBox highTidesTB1;
        private System.Windows.Forms.Button addShoalButtonNew;
        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.Button btnReadFromFile;
        private System.Windows.Forms.Button btnWriteFile;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label outputListBoxTitleLabel;
        private System.Windows.Forms.Button updateSelectedItemButton;
        private System.Windows.Forms.Label shoalTitleLabel;
        private System.Windows.Forms.Button FilterBtn;
        private System.Windows.Forms.ListBox FilteredListBox;
    }
}

