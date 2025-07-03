namespace My_Menu
{
    partial class Formula_General
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
            components = new System.ComponentModel.Container();
            txtA = new TextBox();
            txtB = new TextBox();
            txtC = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtResultado1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtResultado2 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            errorProvider1 = new ErrorProvider(components);
            lblx1 = new Label();
            lblx2 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtA
            // 
            txtA.Location = new Point(99, 29);
            txtA.Name = "txtA";
            txtA.Size = new Size(53, 23);
            txtA.TabIndex = 0;
            txtA.KeyPress += txtA_KeyPress;
            // 
            // txtB
            // 
            txtB.Location = new Point(99, 81);
            txtB.Name = "txtB";
            txtB.Size = new Size(53, 23);
            txtB.TabIndex = 1;
            txtB.KeyPress += txtB_KeyPress;
            // 
            // txtC
            // 
            txtC.Location = new Point(99, 132);
            txtC.Name = "txtC";
            txtC.Size = new Size(53, 23);
            txtC.TabIndex = 2;
            txtC.KeyPress += txtC_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 29);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 3;
            label1.Text = "A :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 84);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 4;
            label2.Text = "B :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 135);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 5;
            label3.Text = "C :";
            // 
            // txtResultado1
            // 
            txtResultado1.Location = new Point(57, 221);
            txtResultado1.Name = "txtResultado1";
            txtResultado1.Size = new Size(181, 23);
            txtResultado1.TabIndex = 6;
            txtResultado1.KeyPress += textBox4_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 190);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 7;
            label4.Text = "Resultado :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 303);
            label5.Name = "label5";
            label5.Size = new Size(136, 15);
            label5.TabIndex = 8;
            label5.Text = "x1 = -b- \\/ b^2 -4ac / 2a";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 338);
            label6.Name = "label6";
            label6.Size = new Size(139, 15);
            label6.TabIndex = 9;
            label6.Text = "x2 = -b+ \\/ b^2 -4ac / 2a";
            // 
            // txtResultado2
            // 
            txtResultado2.Location = new Point(57, 261);
            txtResultado2.Name = "txtResultado2";
            txtResultado2.Size = new Size(181, 23);
            txtResultado2.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 224);
            label7.Name = "label7";
            label7.Size = new Size(19, 15);
            label7.TabIndex = 11;
            label7.Text = "x1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 261);
            label8.Name = "label8";
            label8.Size = new Size(19, 15);
            label8.TabIndex = 12;
            label8.Text = "x2";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lblx1
            // 
            lblx1.AutoSize = true;
            lblx1.Location = new Point(297, 223);
            lblx1.Name = "lblx1";
            lblx1.Size = new Size(0, 15);
            lblx1.TabIndex = 13;
            // 
            // lblx2
            // 
            lblx2.AutoSize = true;
            lblx2.Location = new Point(297, 261);
            lblx2.Name = "lblx2";
            lblx2.Size = new Size(0, 15);
            lblx2.TabIndex = 14;
            // 
            // Formula_General
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 365);
            Controls.Add(lblx2);
            Controls.Add(lblx1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtResultado2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtResultado1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtC);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Name = "Formula_General";
            Text = "Formula_General";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtC;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtResultado1;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtResultado2;
        private Label label7;
        private Label label8;
        private ErrorProvider errorProvider1;
        private Label lblx2;
        private Label lblx1;
    }
}