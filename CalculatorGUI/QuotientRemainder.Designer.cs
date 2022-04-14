
namespace CalculatorGUI
{
    partial class QuotientRemainder
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
            this.back = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.solve = new System.Windows.Forms.Button();
            this.dividendTextBox = new System.Windows.Forms.TextBox();
            this.divisorTextBox = new System.Windows.Forms.TextBox();
            this.dividend = new System.Windows.Forms.Label();
            this.divisor = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.resultDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(381, 95);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 12;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(381, 64);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 11;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // solve
            // 
            this.solve.Location = new System.Drawing.Point(381, 29);
            this.solve.Name = "solve";
            this.solve.Size = new System.Drawing.Size(75, 23);
            this.solve.TabIndex = 10;
            this.solve.Text = "Solve";
            this.solve.UseVisualStyleBackColor = true;
            this.solve.Click += new System.EventHandler(this.solve_Click);
            // 
            // dividendTextBox
            // 
            this.dividendTextBox.Location = new System.Drawing.Point(103, 31);
            this.dividendTextBox.Name = "dividendTextBox";
            this.dividendTextBox.Size = new System.Drawing.Size(100, 20);
            this.dividendTextBox.TabIndex = 13;
            // 
            // divisorTextBox
            // 
            this.divisorTextBox.Location = new System.Drawing.Point(103, 66);
            this.divisorTextBox.Name = "divisorTextBox";
            this.divisorTextBox.Size = new System.Drawing.Size(100, 20);
            this.divisorTextBox.TabIndex = 14;
            // 
            // dividend
            // 
            this.dividend.AutoSize = true;
            this.dividend.Location = new System.Drawing.Point(48, 34);
            this.dividend.Name = "dividend";
            this.dividend.Size = new System.Drawing.Size(49, 13);
            this.dividend.TabIndex = 15;
            this.dividend.Text = "Dividend";
            // 
            // divisor
            // 
            this.divisor.AutoSize = true;
            this.divisor.Location = new System.Drawing.Point(48, 71);
            this.divisor.Name = "divisor";
            this.divisor.Size = new System.Drawing.Size(39, 13);
            this.divisor.TabIndex = 16;
            this.divisor.Text = "Divisor";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(48, 105);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(40, 13);
            this.result.TabIndex = 17;
            this.result.Text = "Result:";
            // 
            // resultDisplay
            // 
            this.resultDisplay.AutoSize = true;
            this.resultDisplay.Location = new System.Drawing.Point(103, 105);
            this.resultDisplay.Name = "resultDisplay";
            this.resultDisplay.Size = new System.Drawing.Size(0, 13);
            this.resultDisplay.TabIndex = 18;
            // 
            // QuotientRemainder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 142);
            this.Controls.Add(this.resultDisplay);
            this.Controls.Add(this.result);
            this.Controls.Add(this.divisor);
            this.Controls.Add(this.dividend);
            this.Controls.Add(this.divisorTextBox);
            this.Controls.Add(this.dividendTextBox);
            this.Controls.Add(this.back);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.solve);
            this.Name = "QuotientRemainder";
            this.Text = "Quotient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button solve;
        private System.Windows.Forms.TextBox dividendTextBox;
        private System.Windows.Forms.TextBox divisorTextBox;
        private System.Windows.Forms.Label dividend;
        private System.Windows.Forms.Label divisor;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label resultDisplay;
    }
}