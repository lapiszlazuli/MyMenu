namespace My_Menu
{
    partial class Par_Impar
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNumero = new TextBox();
            txtNumeros = new TextBox();
            comboBox1 = new ComboBox();
            btmHacer = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 31);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Numero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 104);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 1;
            label2.Text = "Numeros";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(495, 45);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "Seleccion";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(96, 53);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(125, 27);
            txtNumero.TabIndex = 3;
            txtNumero.KeyPress += txtNumero_KeyPress;
            // 
            // txtNumeros
            // 
            txtNumeros.Enabled = false;
            txtNumeros.Location = new Point(96, 149);
            txtNumeros.Multiline = true;
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(213, 276);
            txtNumeros.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Par", "Impar" });
            comboBox1.Location = new Point(495, 101);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 5;
            comboBox1.Text = "Par";
            // 
            // btmHacer
            // 
            btmHacer.Location = new Point(390, 325);
            btmHacer.Name = "btmHacer";
            btmHacer.Size = new Size(94, 29);
            btmHacer.TabIndex = 6;
            btmHacer.Text = "Hacer";
            btmHacer.UseVisualStyleBackColor = true;
            btmHacer.Click += btmHacer_Click;
            // 
            // Par_Impar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(btmHacer);
            Controls.Add(comboBox1);
            Controls.Add(txtNumeros);
            Controls.Add(txtNumero);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Par_Impar";
            Text = "Par_Impar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNumero;
        private TextBox txtNumeros;
        private ComboBox comboBox1;
        private Button btmHacer;
    }
}