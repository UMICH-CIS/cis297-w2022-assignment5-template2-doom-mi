
namespace CalculatorGUI
{
    partial class ReverseString
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
            this.modifiedString = new System.Windows.Forms.Label();
            this.yourText = new System.Windows.Forms.Label();
            this.yourString = new System.Windows.Forms.Label();
            this.yourTextBox = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.reverse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // modifiedString
            // 
            this.modifiedString.AutoSize = true;
            this.modifiedString.Location = new System.Drawing.Point(115, 73);
            this.modifiedString.Name = "modifiedString";
            this.modifiedString.Size = new System.Drawing.Size(0, 13);
            this.modifiedString.TabIndex = 13;
            // 
            // yourText
            // 
            this.yourText.AutoSize = true;
            this.yourText.Location = new System.Drawing.Point(53, 73);
            this.yourText.Name = "yourText";
            this.yourText.Size = new System.Drawing.Size(56, 13);
            this.yourText.TabIndex = 12;
            this.yourText.Text = "Your Text:";
            // 
            // yourString
            // 
            this.yourString.AutoSize = true;
            this.yourString.Location = new System.Drawing.Point(53, 40);
            this.yourString.Name = "yourString";
            this.yourString.Size = new System.Drawing.Size(83, 13);
            this.yourString.TabIndex = 11;
            this.yourString.Text = "Enter your string";
            // 
            // yourTextBox
            // 
            this.yourTextBox.Location = new System.Drawing.Point(142, 37);
            this.yourTextBox.Name = "yourTextBox";
            this.yourTextBox.Size = new System.Drawing.Size(141, 20);
            this.yourTextBox.TabIndex = 10;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(310, 102);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 9;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(310, 73);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 8;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // reverse
            // 
            this.reverse.Location = new System.Drawing.Point(310, 35);
            this.reverse.Name = "reverse";
            this.reverse.Size = new System.Drawing.Size(75, 23);
            this.reverse.TabIndex = 7;
            this.reverse.Text = "Reverse";
            this.reverse.UseVisualStyleBackColor = true;
            this.reverse.Click += new System.EventHandler(this.reverse_Click);
            // 
            // ReverseString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 161);
            this.Controls.Add(this.modifiedString);
            this.Controls.Add(this.yourText);
            this.Controls.Add(this.yourString);
            this.Controls.Add(this.yourTextBox);
            this.Controls.Add(this.back);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.reverse);
            this.Name = "ReverseString";
            this.Text = "Reverse String";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label modifiedString;
        private System.Windows.Forms.Label yourText;
        private System.Windows.Forms.Label yourString;
        private System.Windows.Forms.TextBox yourTextBox;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button reverse;
    }
}