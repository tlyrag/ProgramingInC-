using System.Drawing;

namespace RestaurantOrder
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
            this.TableLabel = new System.Windows.Forms.Label();
            this.TableTextBox = new System.Windows.Forms.TextBox();
            this.CoffeeBox = new System.Windows.Forms.CheckBox();
            this.JuiceBox = new System.Windows.Forms.CheckBox();
            this.CokeBox = new System.Windows.Forms.CheckBox();
            this.IceTeaBox = new System.Windows.Forms.CheckBox();
            this.SelectDrinkLabel = new System.Windows.Forms.Label();
            this.PartySizeLabel = new System.Windows.Forms.Label();
            this.PartySizeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TableLabel
            // 
            this.TableLabel.AutoSize = true;
            this.TableLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.TableLabel.Location = new System.Drawing.Point(12, 33);
            this.TableLabel.Name = "TableLabel";
            this.TableLabel.Size = new System.Drawing.Size(128, 18);
            this.TableLabel.TabIndex = 1;
            this.TableLabel.Text = "Table Number";
            // 
            // TableTextBox
            // 
            this.TableTextBox.Location = new System.Drawing.Point(158, 33);
            this.TableTextBox.Name = "TableTextBox";
            this.TableTextBox.Size = new System.Drawing.Size(100, 20);
            this.TableTextBox.TabIndex = 2;
            // 
            // CoffeeBox
            // 
            this.CoffeeBox.AutoSize = true;
            this.CoffeeBox.ForeColor = System.Drawing.SystemColors.Control;
            this.CoffeeBox.Location = new System.Drawing.Point(396, 43);
            this.CoffeeBox.Name = "CoffeeBox";
            this.CoffeeBox.Size = new System.Drawing.Size(57, 17);
            this.CoffeeBox.TabIndex = 3;
            this.CoffeeBox.Text = "Coffee";
            this.CoffeeBox.UseVisualStyleBackColor = true;
            // 
            // JuiceBox
            // 
            this.JuiceBox.AutoSize = true;
            this.JuiceBox.ForeColor = System.Drawing.SystemColors.Control;
            this.JuiceBox.Location = new System.Drawing.Point(396, 66);
            this.JuiceBox.Name = "JuiceBox";
            this.JuiceBox.Size = new System.Drawing.Size(51, 17);
            this.JuiceBox.TabIndex = 4;
            this.JuiceBox.Text = "Juice";
            this.JuiceBox.UseVisualStyleBackColor = true;
            // 
            // CokeBox
            // 
            this.CokeBox.AutoSize = true;
            this.CokeBox.ForeColor = System.Drawing.SystemColors.Control;
            this.CokeBox.Location = new System.Drawing.Point(396, 89);
            this.CokeBox.Name = "CokeBox";
            this.CokeBox.Size = new System.Drawing.Size(51, 17);
            this.CokeBox.TabIndex = 5;
            this.CokeBox.Text = "Coke";
            this.CokeBox.UseVisualStyleBackColor = true;
            // 
            // IceTeaBox
            // 
            this.IceTeaBox.AutoSize = true;
            this.IceTeaBox.ForeColor = System.Drawing.SystemColors.Control;
            this.IceTeaBox.Location = new System.Drawing.Point(396, 112);
            this.IceTeaBox.Name = "IceTeaBox";
            this.IceTeaBox.Size = new System.Drawing.Size(60, 17);
            this.IceTeaBox.TabIndex = 6;
            this.IceTeaBox.Text = "IceTea";
            this.IceTeaBox.UseVisualStyleBackColor = true;
            // 
            // SelectDrinkLabel
            // 
            this.SelectDrinkLabel.AutoSize = true;
            this.SelectDrinkLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectDrinkLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.SelectDrinkLabel.Location = new System.Drawing.Point(393, 22);
            this.SelectDrinkLabel.Name = "SelectDrinkLabel";
            this.SelectDrinkLabel.Size = new System.Drawing.Size(118, 18);
            this.SelectDrinkLabel.TabIndex = 7;
            this.SelectDrinkLabel.Text = "SelectDrink";
            // 
            // PartySizeLabel
            // 
            this.PartySizeLabel.AutoSize = true;
            this.PartySizeLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartySizeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.PartySizeLabel.Location = new System.Drawing.Point(12, 87);
            this.PartySizeLabel.Name = "PartySizeLabel";
            this.PartySizeLabel.Size = new System.Drawing.Size(128, 18);
            this.PartySizeLabel.TabIndex = 8;
            this.PartySizeLabel.Text = "Table Number";
            // 
            // PartySizeTextBox
            // 
            this.PartySizeTextBox.Location = new System.Drawing.Point(158, 87);
            this.PartySizeTextBox.Name = "PartySizeTextBox";
            this.PartySizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.PartySizeTextBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PartySizeTextBox);
            this.Controls.Add(this.PartySizeLabel);
            this.Controls.Add(this.SelectDrinkLabel);
            this.Controls.Add(this.IceTeaBox);
            this.Controls.Add(this.CokeBox);
            this.Controls.Add(this.JuiceBox);
            this.Controls.Add(this.CoffeeBox);
            this.Controls.Add(this.TableTextBox);
            this.Controls.Add(this.TableLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TableLabel;
        private System.Windows.Forms.TextBox TableTextBox;
        private System.Windows.Forms.CheckBox CoffeeBox;
        private System.Windows.Forms.CheckBox JuiceBox;
        private System.Windows.Forms.CheckBox CokeBox;
        private System.Windows.Forms.CheckBox IceTeaBox;
        private System.Windows.Forms.Label SelectDrinkLabel;
        private System.Windows.Forms.Label PartySizeLabel;
        private System.Windows.Forms.TextBox PartySizeTextBox;
    }
}

