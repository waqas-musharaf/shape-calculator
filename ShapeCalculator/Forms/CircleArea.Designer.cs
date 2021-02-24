
namespace ShapeCalculator
{
    partial class CircleArea
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
            this.lbRadius = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.tbRadius = new System.Windows.Forms.TextBox();
            this.lbArea = new System.Windows.Forms.Label();
            this.tbArea = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbRadius
            // 
            this.lbRadius.AutoSize = true;
            this.lbRadius.Location = new System.Drawing.Point(12, 60);
            this.lbRadius.Name = "lbRadius";
            this.lbRadius.Size = new System.Drawing.Size(56, 17);
            this.lbRadius.TabIndex = 5;
            this.lbRadius.Text = "Radius:";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(312, 17);
            this.lbTitle.TabIndex = 4;
            this.lbTitle.Text = "Please enter the radius of the circle to calculate:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(305, 54);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(115, 29);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // tbRadius
            // 
            this.tbRadius.Location = new System.Drawing.Point(74, 57);
            this.tbRadius.Name = "tbRadius";
            this.tbRadius.Size = new System.Drawing.Size(216, 22);
            this.tbRadius.TabIndex = 8;
            // 
            // lbArea
            // 
            this.lbArea.AutoSize = true;
            this.lbArea.Location = new System.Drawing.Point(12, 93);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(42, 17);
            this.lbArea.TabIndex = 9;
            this.lbArea.Text = "Area:";
            // 
            // tbArea
            // 
            this.tbArea.Location = new System.Drawing.Point(74, 90);
            this.tbArea.Name = "tbArea";
            this.tbArea.ReadOnly = true;
            this.tbArea.Size = new System.Drawing.Size(216, 22);
            this.tbArea.TabIndex = 10;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(305, 87);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(115, 29);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CircleArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 178);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbArea);
            this.Controls.Add(this.lbArea);
            this.Controls.Add(this.tbRadius);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lbRadius);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CircleArea";
            this.Text = "Circle Area | Shape Calculator";
            this.Load += new System.EventHandler(this.CircleArea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbRadius;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox tbRadius;
        private System.Windows.Forms.Label lbArea;
        private System.Windows.Forms.TextBox tbArea;
        private System.Windows.Forms.Button btnBack;
    }
}