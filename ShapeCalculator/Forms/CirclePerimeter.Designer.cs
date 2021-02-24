
namespace ShapeCalculator
{
    partial class CirclePerimeter
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
            this.tbCircum = new System.Windows.Forms.TextBox();
            this.lbCircum = new System.Windows.Forms.Label();
            this.tbRadius = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lbRadius = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(305, 87);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(115, 29);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tbCircum
            // 
            this.tbCircum.Location = new System.Drawing.Point(74, 90);
            this.tbCircum.Name = "tbCircum";
            this.tbCircum.ReadOnly = true;
            this.tbCircum.Size = new System.Drawing.Size(216, 22);
            this.tbCircum.TabIndex = 17;
            // 
            // lbCircum
            // 
            this.lbCircum.AutoSize = true;
            this.lbCircum.Location = new System.Drawing.Point(12, 93);
            this.lbCircum.Name = "lbCircum";
            this.lbCircum.Size = new System.Drawing.Size(55, 17);
            this.lbCircum.TabIndex = 16;
            this.lbCircum.Text = "Circum:";
            // 
            // tbRadius
            // 
            this.tbRadius.Location = new System.Drawing.Point(74, 57);
            this.tbRadius.Name = "tbRadius";
            this.tbRadius.Size = new System.Drawing.Size(216, 22);
            this.tbRadius.TabIndex = 15;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(305, 54);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(115, 29);
            this.btnCalculate.TabIndex = 14;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lbRadius
            // 
            this.lbRadius.AutoSize = true;
            this.lbRadius.Location = new System.Drawing.Point(12, 60);
            this.lbRadius.Name = "lbRadius";
            this.lbRadius.Size = new System.Drawing.Size(56, 17);
            this.lbRadius.TabIndex = 13;
            this.lbRadius.Text = "Radius:";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(312, 17);
            this.lbTitle.TabIndex = 12;
            this.lbTitle.Text = "Please enter the radius of the circle to calculate:";
            // 
            // CirclePerimeter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 178);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbCircum);
            this.Controls.Add(this.lbCircum);
            this.Controls.Add(this.tbRadius);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lbRadius);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CirclePerimeter";
            this.Text = "Circle Circumference | Shape Calculator";
            this.Load += new System.EventHandler(this.CirclePerimeter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox tbCircum;
        private System.Windows.Forms.Label lbCircum;
        private System.Windows.Forms.TextBox tbRadius;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lbRadius;
        private System.Windows.Forms.Label lbTitle;
    }
}