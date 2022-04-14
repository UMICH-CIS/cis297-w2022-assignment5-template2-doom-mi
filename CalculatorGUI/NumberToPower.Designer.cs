
namespace CalculatorGUI
{
    partial class NumberToPower
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
            this.resultDisplay = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.specPower = new System.Windows.Forms.Label();
            this.specNumber = new System.Windows.Forms.Label();
            this.powerTextBox = new System.Windows.Forms.TextBox();
            this.specNumberTextBox = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.solve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultDisplay
            // 
            this.resultDisplay.AutoSize = true;
            this.resultDisplay.Location = new System.Drawing.Point(80, 98);
            this.resultDisplay.Name = "resultDisplay";
            this.resultDisplay.Size = new System.Drawing.Size(0, 13);
            this.resultDisplay.TabIndex = 36;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(25, 98);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(40, 13);
            this.result.TabIndex = 35;
            this.result.Text = "Result:";
            // 
            // specPower
            // 
            this.specPower.AutoSize = true;
            this.specPower.Location = new System.Drawing.Point(25, 64);
            this.specPower.Name = "specPower";
            this.specPower.Size = new System.Drawing.Size(37, 13);
            this.specPower.TabIndex = 34;
            this.specPower.Text = "Power";
            // 
            // specNumber
            // 
            this.specNumber.AutoSize = true;
            this.specNumber.Location = new System.Drawing.Point(25, 27);
            this.specNumber.Name = "specNumber";
            this.specNumber.Size = new System.Drawing.Size(44, 13);
            this.specNumber.TabIndex = 33;
            this.specNumber.Text = "Number";
            // 
            // powerTextBox
            // 
            this.powerTextBox.Location = new System.Drawing.Point(80, 59);
            this.powerTextBox.Name = "powerTextBox";
            this.powerTextBox.Size = new System.Drawing.Size(100, 20);
            this.powerTextBox.TabIndex = 32;
            // 
            // specNumberTextBox
            // 
            this.specNumberTextBox.Location = new System.Drawing.Point(80, 24);
            this.specNumberTextBox.Name = "specNumberTextBox";
            this.specNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.specNumberTextBox.TabIndex = 31;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(358, 88);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 30;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(358, 57);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 29;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // solve
            // 
            this.solve.Location = new System.Drawing.Point(358, 22);
            this.solve.Name = "solve";
            this.solve.Size = new System.Drawing.Size(75, 23);
            this.solve.TabIndex = 28;
            this.solve.Text = "Solve";
            this.solve.UseVisualStyleBackColor = true;
            this.solve.Click += new System.EventHandler(this.solve_Click);
            // 
            // NumberToPower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 144);
            this.Controls.Add(this.resultDisplay);
            this.Controls.Add(this.result);
            this.Controls.Add(this.specPower);
            this.Controls.Add(this.specNumber);
            this.Controls.Add(this.powerTextBox);
            this.Controls.Add(this.specNumberTextBox);
            this.Controls.Add(this.back);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.solve);
            this.Name = "NumberToPower";
            this.Text = "Number to Power";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultDisplay;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label specPower;
        private System.Windows.Forms.Label specNumber;
        private System.Windows.Forms.TextBox powerTextBox;
        private System.Windows.Forms.TextBox specNumberTextBox;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button solve;
    }
}