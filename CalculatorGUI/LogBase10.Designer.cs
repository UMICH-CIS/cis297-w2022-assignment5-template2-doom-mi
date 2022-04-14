
namespace CalculatorGUI
{
    partial class LogBase10
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
            this.logDisplay = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.logLabel = new System.Windows.Forms.Label();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(296, 88);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 15;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(296, 59);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 14;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // solve
            // 
            this.solve.Location = new System.Drawing.Point(296, 20);
            this.solve.Name = "solve";
            this.solve.Size = new System.Drawing.Size(75, 23);
            this.solve.TabIndex = 13;
            this.solve.Text = "Solve";
            this.solve.UseVisualStyleBackColor = true;
            this.solve.Click += new System.EventHandler(this.solve_Click);
            // 
            // logDisplay
            // 
            this.logDisplay.AutoSize = true;
            this.logDisplay.Location = new System.Drawing.Point(98, 64);
            this.logDisplay.Name = "logDisplay";
            this.logDisplay.Size = new System.Drawing.Size(0, 13);
            this.logDisplay.TabIndex = 22;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(37, 64);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(40, 13);
            this.result.TabIndex = 21;
            this.result.Text = "Result:";
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Location = new System.Drawing.Point(23, 26);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(72, 13);
            this.logLabel.TabIndex = 20;
            this.logLabel.Text = "Enter Number";
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(101, 23);
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.Size = new System.Drawing.Size(100, 20);
            this.logTextBox.TabIndex = 19;
            // 
            // LogBase10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 139);
            this.Controls.Add(this.logDisplay);
            this.Controls.Add(this.result);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.back);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.solve);
            this.Name = "LogBase10";
            this.Text = "Log Base 10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button solve;
        private System.Windows.Forms.Label logDisplay;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.TextBox logTextBox;
    }
}