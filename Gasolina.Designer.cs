namespace My_Menu
{
    partial class Gasolina
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
            txtLitros = new TextBox();
            txtResul = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            btmSalir = new Button();
            label1 = new Label();
            LabelLetras = new Label();
            SuspendLayout();
            // 
            // btmHacer
            // 
            btmHacer.Location = new Point(302, 155);
            btmHacer.Name = "btmHacer";
            btmHacer.Size = new Size(94, 29);
            btmHacer.TabIndex = 0;
            btmHacer.Text = "Hacer";
            btmHacer.UseVisualStyleBackColor = true;
            btmHacer.Click += btmHacer_Click;
            // 
            // txtLitros
            // 
            txtLitros.Location = new Point(286, 92);
            txtLitros.Name = "txtLitros";
            txtLitros.Size = new Size(125, 27);
            txtLitros.TabIndex = 1;
            txtLitros.KeyPress += txtLitros_KeyPress;
            // 
            // txtResul
            // 
            txtResul.Enabled = false;
            txtResul.Location = new Point(246, 203);
            txtResul.Multiline = true;
            txtResul.Name = "txtResul";
            txtResul.Size = new Size(195, 143);
            txtResul.TabIndex = 2;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(91, 80);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(78, 24);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "México";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(91, 121);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(58, 24);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "USA";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // btmSalir
            // 
            btmSalir.Location = new Point(317, 409);
            btmSalir.Name = "btmSalir";
            btmSalir.Size = new Size(94, 29);
            btmSalir.TabIndex = 5;
            btmSalir.Text = "Salir";
            btmSalir.UseVisualStyleBackColor = true;
            btmSalir.Click += btmSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(331, 41);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 6;
            label1.Text = "Litros:";
            // 
            // LabelLetras
            // 
            LabelLetras.AutoSize = true;
            LabelLetras.Location = new Point(557, 159);
            LabelLetras.Name = "LabelLetras";
            LabelLetras.Size = new Size(0, 20);
            LabelLetras.TabIndex = 7;
            // 
            // Gasolina
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(LabelLetras);
            Controls.Add(label1);
            Controls.Add(btmSalir);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(txtResul);
            Controls.Add(txtLitros);
            Controls.Add(btmHacer);
            Name = "Gasolina";
            Text = "Gasolina";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btmHacer;
        private TextBox txtLitros;
        private TextBox txtResul;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button btmSalir;
        private Label label1;
        private Label LabelLetras;
    }
}