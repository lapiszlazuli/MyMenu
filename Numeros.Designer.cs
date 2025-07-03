namespace My_Menu
{
    partial class Numeros
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
            btmHacer = new Button();
            label1 = new Label();
            label2 = new Label();
            txtNumero = new TextBox();
            txtNumeros = new TextBox();
            lblNum = new Label();
            SuspendLayout();
            // 
            // btmHacer
            // 
            btmHacer.Location = new Point(270, 298);
            btmHacer.Margin = new Padding(3, 2, 3, 2);
            btmHacer.Name = "btmHacer";
            btmHacer.Size = new Size(82, 22);
            btmHacer.TabIndex = 0;
            btmHacer.Text = "Hacer";
            btmHacer.UseVisualStyleBackColor = true;
            btmHacer.Click += btmHacer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(284, 7);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Numero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(284, 77);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Numeros";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(243, 37);
            txtNumero.Margin = new Padding(3, 2, 3, 2);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(110, 23);
            txtNumero.TabIndex = 3;
            txtNumero.KeyPress += txtNumero_KeyPress;
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(243, 118);
            txtNumeros.Margin = new Padding(3, 2, 3, 2);
            txtNumeros.Multiline = true;
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(148, 158);
            txtNumeros.TabIndex = 4;
            // 
            // lblNum
            // 
            lblNum.AutoSize = true;
            lblNum.Location = new Point(437, 44);
            lblNum.Name = "lblNum";
            lblNum.Size = new Size(0, 15);
            lblNum.TabIndex = 5;
            // 
            // Numeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(lblNum);
            Controls.Add(txtNumeros);
            Controls.Add(txtNumero);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btmHacer);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Numeros";
            Text = "Numeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btmHacer;
        private Label label1;
        private Label label2;
        private TextBox txtNumero;
        private TextBox txtNumeros;
        private Label lblNum;
    }
}