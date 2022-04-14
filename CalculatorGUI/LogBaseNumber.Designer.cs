
namespace CalculatorGUI
{
    partial class LogBaseNumber
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
            this.baseNumber = new System.Windows.Forms.Label();
            this.logNumber = new System.Windows.Forms.Label();
            this.baseTextBox = new System.Windows.Forms.TextBox();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.solve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultDisplay
            // 
            this.resultDisplay.AutoSize = true;
            this.resultDisplay.Location = new System.Drawing.Point(74, 89);
            this.resultDisplay.Name = "resultDisplay";
            this.resultDisplay.Size = new System.Drawing.Size(0, 13);
            this.resultDisplay.TabIndex = 27;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(19, 89);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(40, 13);
            this.result.TabIndex = 26;
            this.result.Text = "Result:";
            // 
            // baseNumber
            // 
            this.baseNumber.AutoSize = true;
            this.baseNumber.Location = new System.Drawing.Point(19, 55);
            this.baseNumber.Name = "baseNumber";
            this.baseNumber.Size = new System.Drawing.Size(31, 13);
            this.baseNumber.TabIndex = 25;
            this.baseNumber.Text = "Base";
            // 
            // logNumber
            // 
            this.logNumber.AutoSize = true;
            this.logNumber.Location = new System.Drawing.Point(19, 18);
            this.logNumber.Name = "logNumber";
            this.logNumber.Size = new System.Drawing.Size(44, 13);
            this.logNumber.TabIndex = 24;
            this.logNumber.Text = "Number";
            // 
            // baseTextBox
            // 
            this.baseTextBox.Location = new System.Drawing.Point(74, 50);
            this.baseTextBox.Name = "baseTextBox";
            this.baseTextBox.Size = new System.Drawing.Size(100, 20);
            this.baseTextBox.TabIndex = 23;
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(74, 15);
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.Size = new System.Drawing.Size(100, 20);
            this.logTextBox.TabIndex = 22;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(333, 79);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 21;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(333, 50);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 20;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // solve
            // 
            this.solve.Location = new System.Drawing.Point(333, 13);
            this.solve.Name = "solve";
            this.solve.Size = new System.Drawing.Size(75, 23);
            this.solve.TabIndex = 19;
            this.solve.Text = "Solve";
            this.solve.UseVisualStyleBackColor = true;
            this.solve.Click += new System.EventHandler(this.solve_Click);
            // 
            // LogBaseNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 132);
            this.Controls.Add(this.resultDisplay);
            this.Controls.Add(this.result);
            this.Controls.Add(this.baseNumber);
            this.Controls.Add(this.logNumber);
            this.Controls.Add(this.baseTextBox);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.back);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.solve);
            this.Name = "LogBaseNumber";
            this.Text = "Log Base Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultDisplay;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label baseNumber;
        private System.Windows.Forms.Label logNumber;
        private System.Windows.Forms.TextBox baseTextBox;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button solve;
    }
}