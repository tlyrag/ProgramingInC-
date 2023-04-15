namespace TestScores
{
    partial class Form2
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
            this.ApprovedListBox = new System.Windows.Forms.ListBox();
            this.ApprovedLabel = new System.Windows.Forms.Label();
            this.SaveApprovedBtn = new System.Windows.Forms.Button();
            this.FailedLabel = new System.Windows.Forms.Label();
            this.FailedListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveFailedBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ApprovedListBox
            // 
            this.ApprovedListBox.FormattingEnabled = true;
            this.ApprovedListBox.Location = new System.Drawing.Point(112, 82);
            this.ApprovedListBox.Name = "ApprovedListBox";
            this.ApprovedListBox.Size = new System.Drawing.Size(236, 212);
            this.ApprovedListBox.TabIndex = 0;
            // 
            // ApprovedLabel
            // 
            this.ApprovedLabel.Location = new System.Drawing.Point(180, 44);
            this.ApprovedLabel.Name = "ApprovedLabel";
            this.ApprovedLabel.Size = new System.Drawing.Size(100, 23);
            this.ApprovedLabel.TabIndex = 1;
            this.ApprovedLabel.Text = "Approved";
            // 
            // SaveApprovedBtn
            // 
            this.SaveApprovedBtn.Location = new System.Drawing.Point(12, 44);
            this.SaveApprovedBtn.Name = "SaveApprovedBtn";
            this.SaveApprovedBtn.Size = new System.Drawing.Size(94, 62);
            this.SaveApprovedBtn.TabIndex = 2;
            this.SaveApprovedBtn.Text = "Save Approved List";
            this.SaveApprovedBtn.UseVisualStyleBackColor = true;
            this.SaveApprovedBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // FailedLabel
            // 
            this.FailedLabel.Location = new System.Drawing.Point(490, 44);
            this.FailedLabel.Name = "FailedLabel";
            this.FailedLabel.Size = new System.Drawing.Size(100, 23);
            this.FailedLabel.TabIndex = 1;
            this.FailedLabel.Text = "Failed";
            // 
            // FailedListBox
            // 
            this.FailedListBox.FormattingEnabled = true;
            this.FailedListBox.Location = new System.Drawing.Point(439, 82);
            this.FailedListBox.Name = "FailedListBox";
            this.FailedListBox.Size = new System.Drawing.Size(236, 212);
            this.FailedListBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(817, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "label1";
            // 
            // SaveFailedBtn
            // 
            this.SaveFailedBtn.Location = new System.Drawing.Point(12, 121);
            this.SaveFailedBtn.Name = "SaveFailedBtn";
            this.SaveFailedBtn.Size = new System.Drawing.Size(94, 67);
            this.SaveFailedBtn.TabIndex = 3;
            this.SaveFailedBtn.Text = "Save Failed List";
            this.SaveFailedBtn.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveFailedBtn);
            this.Controls.Add(this.SaveApprovedBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FailedLabel);
            this.Controls.Add(this.FailedListBox);
            this.Controls.Add(this.ApprovedLabel);
            this.Controls.Add(this.ApprovedListBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ApprovedListBox;
        private System.Windows.Forms.Label ApprovedLabel;
        private System.Windows.Forms.Button SaveApprovedBtn;
        private System.Windows.Forms.Label FailedLabel;
        private System.Windows.Forms.ListBox FailedListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveFailedBtn;
    }
}