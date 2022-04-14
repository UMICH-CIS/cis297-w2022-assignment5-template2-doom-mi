
namespace CalculatorGUI
{
    partial class MinMax
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
            this.maximum = new System.Windows.Forms.Label();
            this.minimum = new System.Windows.Forms.Label();
            this.maximumTextBox = new System.Windows.Forms.TextBox();
            this.minimumTextBox = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.solve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultDisplay
            // 
            this.resultDisplay.AutoSize = true;
            this.resultDisplay.Location = new System.Drawing.Point(100, 106);
            this.resultDisplay.Name = "resultDisplay";
            this.resultDisplay.Size = new System.Drawing.Size(0, 13);
            this.resultDisplay.TabIndex = 27;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(45, 106);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(40, 13);
            this.result.TabIndex = 26;
            this.result.Text = "Result:";
            // 
            // maximum
            // 
            this.maximum.AutoSize = true;
            this.maximum.Location = new System.Drawing.Point(45, 72);
            this.maximum.Name = "maximum";
            this.maximum.Size = new System.Drawing.Size(51, 13);
            this.maximum.TabIndex = 25;
            this.maximum.Text = "Maximum";
            // 
            // minimum
            // 
            this.minimum.AutoSize = true;
            this.minimum.Location = new System.Drawing.Point(45, 35);
            this.minimum.Name = "minimum";
            this.minimum.Size = new System.Drawing.Size(48, 13);
            this.minimum.TabIndex = 24;
            this.minimum.Text = "Minimum";
            // 
            // maximumTextBox
            // 
            this.maximumTextBox.Location = new System.Drawing.Point(100, 67);
            this.maximumTextBox.Name = "maximumTextBox";
            this.maximumTextBox.Size = new System.Drawing.Size(100, 20);
            this.maximumTextBox.TabIndex = 23;
            // 
            // minimumTextBox
            // 
            this.minimumTextBox.Location = new System.Drawing.Point(100, 32);
            this.minimumTextBox.Name = "minimumTextBox";
            this.minimumTextBox.Size = new System.Drawing.Size(100, 20);
            this.minimumTextBox.TabIndex = 22;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(378, 96);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 21;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(378, 65);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 20;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // solve
            // 
            this.solve.Location = new System.Drawing.Point(378, 30);
            this.solve.Name = "solve";
            this.solve.Size = new System.Drawing.Size(75, 23);
            this.solve.TabIndex = 19;
            this.solve.Text = "Solve";
            this.solve.UseVisualStyleBackColor = true;
            this.solve.Click += new System.EventHandler(this.solve_Click);
            // 
            // MinMax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 186);
            this.Controls.Add(this.resultDisplay);
            this.Controls.Add(this.result);
            this.Controls.Add(this.maximum);
            this.Controls.Add(this.minimum);
            this.Controls.Add(this.maximumTextBox);
            this.Controls.Add(this.minimumTextBox);
            this.Controls.Add(this.back);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.solve);
            this.Name = "MinMax";
            this.Text = "Min/Max";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultDisplay;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label maximum;
        private System.Windows.Forms.Label minimum;
        private System.Windows.Forms.TextBox maximumTextBox;
        private System.Windows.Forms.TextBox minimumTextBox;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button solve;
    }
}