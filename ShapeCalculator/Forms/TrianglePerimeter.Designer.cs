
namespace ShapeCalculator.Forms
{
    partial class TrianglePerimeter
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.tbLenC = new System.Windows.Forms.TextBox();
            this.lbLenC = new System.Windows.Forms.Label();
            this.tbLenB = new System.Windows.Forms.TextBox();
            this.lbLenB = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tbPerim = new System.Windows.Forms.TextBox();
            this.lbPerim = new System.Windows.Forms.Label();
            this.tbLenA = new System.Windows.Forms.TextBox();
            this.lbLenA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(305, 137);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(115, 29);
            this.btnBack.TabIndex = 45;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(305, 104);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(115, 29);
            this.btnCalculate.TabIndex = 44;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // tbLenC
            // 
            this.tbLenC.Location = new System.Drawing.Point(87, 113);
            this.tbLenC.Name = "tbLenC";
            this.tbLenC.Size = new System.Drawing.Size(203, 22);
            this.tbLenC.TabIndex = 43;
            // 
            // lbLenC
            // 
            this.lbLenC.AutoSize = true;
            this.lbLenC.Location = new System.Drawing.Point(12, 116);
            this.lbLenC.Name = "lbLenC";
            this.lbLenC.Size = new System.Drawing.Size(69, 17);
            this.lbLenC.TabIndex = 42;
            this.lbLenC.Text = "Length C:";
            // 
            // tbLenB
            // 
            this.tbLenB.Location = new System.Drawing.Point(87, 85);
            this.tbLenB.Name = "tbLenB";
            this.tbLenB.Size = new System.Drawing.Size(203, 22);
            this.tbLenB.TabIndex = 41;
            // 
            // lbLenB
            // 
            this.lbLenB.AutoSize = true;
            this.lbLenB.Location = new System.Drawing.Point(12, 88);
            this.lbLenB.Name = "lbLenB";
            this.lbLenB.Size = new System.Drawing.Size(69, 17);
            this.lbLenB.TabIndex = 40;
            this.lbLenB.Text = "Length B:";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(400, 17);
            this.lbTitle.TabIndex = 39;
            this.lbTitle.Text = "Please enter the three side lengths of the triangle to calculate:";
            // 
            // tbPerim
            // 
            this.tbPerim.Location = new System.Drawing.Point(87, 141);
            this.tbPerim.Name = "tbPerim";
            this.tbPerim.ReadOnly = true;
            this.tbPerim.Size = new System.Drawing.Size(203, 22);
            this.tbPerim.TabIndex = 38;
            // 
            // lbPerim
            // 
            this.lbPerim.AutoSize = true;
            this.lbPerim.Location = new System.Drawing.Point(12, 144);
            this.lbPerim.Name = "lbPerim";
            this.lbPerim.Size = new System.Drawing.Size(48, 17);
            this.lbPerim.TabIndex = 37;
            this.lbPerim.Text = "Perim:";
            // 
            // tbLenA
            // 
            this.tbLenA.Location = new System.Drawing.Point(87, 57);
            this.tbLenA.Name = "tbLenA";
            this.tbLenA.Size = new System.Drawing.Size(203, 22);
            this.tbLenA.TabIndex = 36;
            // 
            // lbLenA
            // 
            this.lbLenA.AutoSize = true;
            this.lbLenA.Location = new System.Drawing.Point(12, 60);
            this.lbLenA.Name = "lbLenA";
            this.lbLenA.Size = new System.Drawing.Size(69, 17);
            this.lbLenA.TabIndex = 35;
            this.lbLenA.Text = "Length A:";
            // 
            // TrianglePerimeter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 203);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.tbLenC);
            this.Controls.Add(this.lbLenC);
            this.Controls.Add(this.tbLenB);
            this.Controls.Add(this.lbLenB);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.tbPerim);
            this.Controls.Add(this.lbPerim);
            this.Controls.Add(this.tbLenA);
            this.Controls.Add(this.lbLenA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TrianglePerimeter";
            this.Text = "Triangle Perimeter | Shape Calculator";
            this.Load += new System.EventHandler(this.TrianglePerimeter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox tbLenC;
        private System.Windows.Forms.Label lbLenC;
        private System.Windows.Forms.TextBox tbLenB;
        private System.Windows.Forms.Label lbLenB;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox tbPerim;
        private System.Windows.Forms.Label lbPerim;
        private System.Windows.Forms.TextBox tbLenA;
        private System.Windows.Forms.Label lbLenA;
    }
}