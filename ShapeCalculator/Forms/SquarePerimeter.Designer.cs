
namespace ShapeCalculator
{
    partial class SquarePerimeter
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.tbPerim = new System.Windows.Forms.TextBox();
            this.lbPerim = new System.Windows.Forms.Label();
            this.tbLength = new System.Windows.Forms.TextBox();
            this.lbLength = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(305, 87);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(115, 29);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(305, 54);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(115, 29);
            this.btnCalculate.TabIndex = 27;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(353, 17);
            this.lbTitle.TabIndex = 26;
            this.lbTitle.Text = "Please enter the side length of the square to calculate:";
            // 
            // tbPerim
            // 
            this.tbPerim.Location = new System.Drawing.Point(74, 90);
            this.tbPerim.Name = "tbPerim";
            this.tbPerim.ReadOnly = true;
            this.tbPerim.Size = new System.Drawing.Size(216, 22);
            this.tbPerim.TabIndex = 25;
            // 
            // lbPerim
            // 
            this.lbPerim.AutoSize = true;
            this.lbPerim.Location = new System.Drawing.Point(12, 93);
            this.lbPerim.Name = "lbPerim";
            this.lbPerim.Size = new System.Drawing.Size(48, 17);
            this.lbPerim.TabIndex = 24;
            this.lbPerim.Text = "Perim:";
            // 
            // tbLength
            // 
            this.tbLength.Location = new System.Drawing.Point(74, 57);
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(216, 22);
            this.tbLength.TabIndex = 23;
            // 
            // lbLength
            // 
            this.lbLength.AutoSize = true;
            this.lbLength.Location = new System.Drawing.Point(12, 60);
            this.lbLength.Name = "lbLength";
            this.lbLength.Size = new System.Drawing.Size(56, 17);
            this.lbLength.TabIndex = 22;
            this.lbLength.Text = "Length:";
            // 
            // SquarePerimeter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 178);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.tbPerim);
            this.Controls.Add(this.lbPerim);
            this.Controls.Add(this.tbLength);
            this.Controls.Add(this.lbLength);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SquarePerimeter";
            this.Text = "Square Perimeter | Shape Calculator";
            this.Load += new System.EventHandler(this.SquarePerimeter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox tbPerim;
        private System.Windows.Forms.Label lbPerim;
        private System.Windows.Forms.TextBox tbLength;
        private System.Windows.Forms.Label lbLength;
    }
}