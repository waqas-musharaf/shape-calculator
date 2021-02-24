
namespace ShapeCalculator
{
    partial class Menu
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbShape = new System.Windows.Forms.Label();
            this.lbOperation = new System.Windows.Forms.Label();
            this.cbShape = new System.Windows.Forms.ComboBox();
            this.cbOperation = new System.Windows.Forms.ComboBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(263, 17);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Please select a shape and an operation:";
            // 
            // lbShape
            // 
            this.lbShape.AutoSize = true;
            this.lbShape.Location = new System.Drawing.Point(12, 60);
            this.lbShape.Name = "lbShape";
            this.lbShape.Size = new System.Drawing.Size(53, 17);
            this.lbShape.TabIndex = 1;
            this.lbShape.Text = "Shape:";
            // 
            // lbOperation
            // 
            this.lbOperation.AutoSize = true;
            this.lbOperation.Location = new System.Drawing.Point(12, 92);
            this.lbOperation.Name = "lbOperation";
            this.lbOperation.Size = new System.Drawing.Size(75, 17);
            this.lbOperation.TabIndex = 2;
            this.lbOperation.Text = "Operation:";
            // 
            // cbShape
            // 
            this.cbShape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShape.FormattingEnabled = true;
            this.cbShape.Items.AddRange(new object[] {
            "",
            "Circle",
            "Square",
            "Triangle"});
            this.cbShape.Location = new System.Drawing.Point(93, 56);
            this.cbShape.Name = "cbShape";
            this.cbShape.Size = new System.Drawing.Size(327, 24);
            this.cbShape.TabIndex = 3;
            // 
            // cbOperation
            // 
            this.cbOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperation.FormattingEnabled = true;
            this.cbOperation.Items.AddRange(new object[] {
            "",
            "Calculate Area",
            "Calculate Perimeter",
            "Quadratic Solver"});
            this.cbOperation.Location = new System.Drawing.Point(93, 89);
            this.cbOperation.Name = "cbOperation";
            this.cbOperation.Size = new System.Drawing.Size(327, 24);
            this.cbOperation.TabIndex = 4;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(305, 137);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(115, 29);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 178);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.cbOperation);
            this.Controls.Add(this.cbShape);
            this.Controls.Add(this.lbOperation);
            this.Controls.Add(this.lbShape);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Menu";
            this.Text = "Menu | Shape Calculator";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbShape;
        private System.Windows.Forms.Label lbOperation;
        private System.Windows.Forms.ComboBox cbShape;
        private System.Windows.Forms.ComboBox cbOperation;
        private System.Windows.Forms.Button btnGo;
    }
}

