
namespace ShapeCalculator.Forms
{
    partial class QuadraticSolver
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
            this.btnBack = new System.Windows.Forms.Button();
            this.tbXSquared = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbXSquared = new System.Windows.Forms.Label();
            this.lbX = new System.Windows.Forms.Label();
            this.tbX = new System.Windows.Forms.TextBox();
            this.tbC = new System.Windows.Forms.TextBox();
            this.lb0 = new System.Windows.Forms.Label();
            this.lbSolutions = new System.Windows.Forms.Label();
            this.tbSolutions = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(311, 120);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(109, 29);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tbXSquared
            // 
            this.tbXSquared.Location = new System.Drawing.Point(15, 57);
            this.tbXSquared.Name = "tbXSquared";
            this.tbXSquared.Size = new System.Drawing.Size(55, 22);
            this.tbXSquared.TabIndex = 15;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(311, 54);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(109, 29);
            this.btnCalculate.TabIndex = 14;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(312, 17);
            this.lbTitle.TabIndex = 12;
            this.lbTitle.Text = "Please fill in the blanks of the quadratic to solve:";
            // 
            // lbXSquared
            // 
            this.lbXSquared.AutoSize = true;
            this.lbXSquared.Location = new System.Drawing.Point(76, 60);
            this.lbXSquared.Name = "lbXSquared";
            this.lbXSquared.Size = new System.Drawing.Size(41, 17);
            this.lbXSquared.TabIndex = 19;
            this.lbXSquared.Text = "x^2 +";
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Location = new System.Drawing.Point(184, 60);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(26, 17);
            this.lbX.TabIndex = 21;
            this.lbX.Text = "x +";
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(123, 57);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(55, 22);
            this.tbX.TabIndex = 20;
            // 
            // tbC
            // 
            this.tbC.Location = new System.Drawing.Point(216, 57);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(55, 22);
            this.tbC.TabIndex = 22;
            // 
            // lb0
            // 
            this.lb0.AutoSize = true;
            this.lb0.Location = new System.Drawing.Point(277, 60);
            this.lb0.Name = "lb0";
            this.lb0.Size = new System.Drawing.Size(28, 17);
            this.lb0.TabIndex = 23;
            this.lb0.Text = "= 0";
            // 
            // lbSolutions
            // 
            this.lbSolutions.AutoSize = true;
            this.lbSolutions.Location = new System.Drawing.Point(12, 98);
            this.lbSolutions.Name = "lbSolutions";
            this.lbSolutions.Size = new System.Drawing.Size(70, 17);
            this.lbSolutions.TabIndex = 24;
            this.lbSolutions.Text = "Solutions:";
            // 
            // tbSolutions
            // 
            this.tbSolutions.Location = new System.Drawing.Point(15, 123);
            this.tbSolutions.Name = "tbSolutions";
            this.tbSolutions.ReadOnly = true;
            this.tbSolutions.Size = new System.Drawing.Size(256, 22);
            this.tbSolutions.TabIndex = 26;
            // 
            // Quadratic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 178);
            this.Controls.Add(this.tbSolutions);
            this.Controls.Add(this.lbSolutions);
            this.Controls.Add(this.lb0);
            this.Controls.Add(this.tbC);
            this.Controls.Add(this.lbX);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.lbXSquared);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbXSquared);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Quadratic";
            this.Text = "Quadratic Equation Solver";
            this.Load += new System.EventHandler(this.Quadratic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox tbXSquared;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbXSquared;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.Label lb0;
        private System.Windows.Forms.Label lbSolutions;
        private System.Windows.Forms.TextBox tbSolutions;
    }
}