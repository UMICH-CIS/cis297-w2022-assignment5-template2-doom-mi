
namespace CalculatorGUI
{
    partial class RootsOfQuad
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
            this.coefficient2 = new System.Windows.Forms.Label();
            this.coefficient1 = new System.Windows.Forms.Label();
            this.coefficient2TextBox = new System.Windows.Forms.TextBox();
            this.coefficient1TextBox = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.solve = new System.Windows.Forms.Button();
            this.constant = new System.Windows.Forms.Label();
            this.constantTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // resultDisplay
            // 
            this.resultDisplay.AutoSize = true;
            this.resultDisplay.Location = new System.Drawing.Point(76, 133);
            this.resultDisplay.Name = "resultDisplay";
            this.resultDisplay.Size = new System.Drawing.Size(0, 13);
            this.resultDisplay.TabIndex = 36;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(21, 133);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(40, 13);
            this.result.TabIndex = 35;
            this.result.Text = "Result:";
            // 
            // coefficient2
            // 
            this.coefficient2.AutoSize = true;
            this.coefficient2.Location = new System.Drawing.Point(10, 50);
            this.coefficient2.Name = "coefficient2";
            this.coefficient2.Size = new System.Drawing.Size(97, 13);
            this.coefficient2.TabIndex = 34;
            this.coefficient2.Text = "Second Coefficient";
            // 
            // coefficient1
            // 
            this.coefficient1.AutoSize = true;
            this.coefficient1.Location = new System.Drawing.Point(10, 15);
            this.coefficient1.Name = "coefficient1";
            this.coefficient1.Size = new System.Drawing.Size(79, 13);
            this.coefficient1.TabIndex = 33;
            this.coefficient1.Text = "First Coefficient";
            // 
            // coefficient2TextBox
            // 
            this.coefficient2TextBox.Location = new System.Drawing.Point(152, 43);
            this.coefficient2TextBox.Name = "coefficient2TextBox";
            this.coefficient2TextBox.Size = new System.Drawing.Size(100, 20);
            this.coefficient2TextBox.TabIndex = 32;
            // 
            // coefficient1TextBox
            // 
            this.coefficient1TextBox.Location = new System.Drawing.Point(152, 12);
            this.coefficient1TextBox.Name = "coefficient1TextBox";
            this.coefficient1TextBox.Size = new System.Drawing.Size(100, 20);
            this.coefficient1TextBox.TabIndex = 31;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(351, 76);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 30;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(351, 45);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 29;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // solve
            // 
            this.solve.Location = new System.Drawing.Point(351, 10);
            this.solve.Name = "solve";
            this.solve.Size = new System.Drawing.Size(75, 23);
            this.solve.TabIndex = 28;
            this.solve.Text = "Solve";
            this.solve.UseVisualStyleBackColor = true;
            this.solve.Click += new System.EventHandler(this.solve_Click);
            // 
            // constant
            // 
            this.constant.AutoSize = true;
            this.constant.Location = new System.Drawing.Point(21, 84);
            this.constant.Name = "constant";
            this.constant.Size = new System.Drawing.Size(49, 13);
            this.constant.TabIndex = 37;
            this.constant.Text = "Constant";
            // 
            // constantTextBox
            // 
            this.constantTextBox.Location = new System.Drawing.Point(152, 81);
            this.constantTextBox.Name = "constantTextBox";
            this.constantTextBox.Size = new System.Drawing.Size(100, 20);
            this.constantTextBox.TabIndex = 38;
            // 
            // RootsOfQuad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 167);
            this.Controls.Add(this.constantTextBox);
            this.Controls.Add(this.constant);
            this.Controls.Add(this.resultDisplay);
            this.Controls.Add(this.result);
            this.Controls.Add(this.coefficient2);
            this.Controls.Add(this.coefficient1);
            this.Controls.Add(this.coefficient2TextBox);
            this.Controls.Add(this.coefficient1TextBox);
            this.Controls.Add(this.back);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.solve);
            this.Name = "RootsOfQuad";
            this.Text = "Roots of Quadratic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultDisplay;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label coefficient2;
        private System.Windows.Forms.Label coefficient1;
        private System.Windows.Forms.TextBox coefficient2TextBox;
        private System.Windows.Forms.TextBox coefficient1TextBox;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button solve;
        private System.Windows.Forms.Label constant;
        private System.Windows.Forms.TextBox constantTextBox;
    }
}