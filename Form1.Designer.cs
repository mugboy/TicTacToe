namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            c11 = new Button();
            c12 = new Button();
            c13 = new Button();
            c23 = new Button();
            c22 = new Button();
            c21 = new Button();
            c33 = new Button();
            c32 = new Button();
            c31 = new Button();
            turnLabel = new Label();
            SuspendLayout();
            // 
            // c11
            // 
            c11.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            c11.Location = new Point(6, 70);
            c11.Name = "c11";
            c11.Size = new Size(74, 68);
            c11.TabIndex = 0;
            c11.UseVisualStyleBackColor = true;
            c11.Click += c11_Click;
            // 
            // c12
            // 
            c12.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            c12.Location = new Point(98, 70);
            c12.Name = "c12";
            c12.Size = new Size(74, 68);
            c12.TabIndex = 1;
            c12.UseVisualStyleBackColor = true;
            c12.Click += c12_Click;
            // 
            // c13
            // 
            c13.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            c13.Location = new Point(189, 70);
            c13.Name = "c13";
            c13.Size = new Size(74, 68);
            c13.TabIndex = 2;
            c13.UseVisualStyleBackColor = true;
            c13.Click += c13_Click;
            // 
            // c23
            // 
            c23.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            c23.Location = new Point(189, 163);
            c23.Name = "c23";
            c23.Size = new Size(74, 68);
            c23.TabIndex = 5;
            c23.UseVisualStyleBackColor = true;
            c23.Click += c23_Click;
            // 
            // c22
            // 
            c22.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            c22.Location = new Point(98, 163);
            c22.Name = "c22";
            c22.Size = new Size(74, 68);
            c22.TabIndex = 4;
            c22.UseVisualStyleBackColor = true;
            c22.Click += c22_Click;
            // 
            // c21
            // 
            c21.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            c21.Location = new Point(6, 163);
            c21.Name = "c21";
            c21.Size = new Size(74, 68);
            c21.TabIndex = 3;
            c21.UseVisualStyleBackColor = true;
            c21.Click += c21_Click;
            // 
            // c33
            // 
            c33.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            c33.Location = new Point(189, 255);
            c33.Name = "c33";
            c33.Size = new Size(74, 68);
            c33.TabIndex = 8;
            c33.UseVisualStyleBackColor = true;
            c33.Click += c33_Click;
            // 
            // c32
            // 
            c32.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            c32.Location = new Point(98, 255);
            c32.Name = "c32";
            c32.Size = new Size(74, 68);
            c32.TabIndex = 7;
            c32.UseVisualStyleBackColor = true;
            c32.Click += c32_Click;
            // 
            // c31
            // 
            c31.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            c31.Location = new Point(6, 255);
            c31.Name = "c31";
            c31.Size = new Size(74, 68);
            c31.TabIndex = 6;
            c31.UseVisualStyleBackColor = true;
            c31.Click += c31_Click;
            // 
            // turnLabel
            // 
            turnLabel.AutoSize = true;
            turnLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            turnLabel.Location = new Point(77, 18);
            turnLabel.Name = "turnLabel";
            turnLabel.Size = new Size(0, 30);
            turnLabel.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 342);
            Controls.Add(turnLabel);
            Controls.Add(c33);
            Controls.Add(c32);
            Controls.Add(c31);
            Controls.Add(c23);
            Controls.Add(c22);
            Controls.Add(c21);
            Controls.Add(c13);
            Controls.Add(c12);
            Controls.Add(c11);
            Name = "Form1";
            Text = "TIc Tac Toe";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button c11;
        private Button c12;
        private Button c13;
        private Button c23;
        private Button c22;
        private Button c21;
        private Button c33;
        private Button c32;
        private Button c31;
        private Label turnLabel;
    }
}
