
namespace CalculatorGUI
{
    partial class RemoveWhitespace
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
            this.remove = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.yourTextBox = new System.Windows.Forms.TextBox();
            this.yourString = new System.Windows.Forms.Label();
            this.yourText = new System.Windows.Forms.Label();
            this.modifiedString = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(269, 13);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(75, 23);
            this.remove.TabIndex = 0;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.button1_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(269, 51);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 1;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.button2_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(269, 80);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 2;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.button3_Click);
            // 
            // yourTextBox
            // 
            this.yourTextBox.Location = new System.Drawing.Point(101, 15);
            this.yourTextBox.Name = "yourTextBox";
            this.yourTextBox.Size = new System.Drawing.Size(141, 20);
            this.yourTextBox.TabIndex = 3;
            // 
            // yourString
            // 
            this.yourString.AutoSize = true;
            this.yourString.Location = new System.Drawing.Point(12, 18);
            this.yourString.Name = "yourString";
            this.yourString.Size = new System.Drawing.Size(83, 13);
            this.yourString.TabIndex = 4;
            this.yourString.Text = "Enter your string";
            // 
            // yourText
            // 
            this.yourText.AutoSize = true;
            this.yourText.Location = new System.Drawing.Point(12, 51);
            this.yourText.Name = "yourText";
            this.yourText.Size = new System.Drawing.Size(56, 13);
            this.yourText.TabIndex = 5;
            this.yourText.Text = "Your Text:";
            // 
            // modifiedString
            // 
            this.modifiedString.AutoSize = true;
            this.modifiedString.Location = new System.Drawing.Point(74, 51);
            this.modifiedString.Name = "modifiedString";
            this.modifiedString.Size = new System.Drawing.Size(0, 13);
            this.modifiedString.TabIndex = 6;
            // 
            // RemoveWhitespace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 120);
            this.Controls.Add(this.modifiedString);
            this.Controls.Add(this.yourText);
            this.Controls.Add(this.yourString);
            this.Controls.Add(this.yourTextBox);
            this.Controls.Add(this.back);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.remove);
            this.Name = "RemoveWhitespace";
            this.Text = "Remove Whitespace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox yourTextBox;
        private System.Windows.Forms.Label yourString;
        private System.Windows.Forms.Label yourText;
        private System.Windows.Forms.Label modifiedString;
    }
}