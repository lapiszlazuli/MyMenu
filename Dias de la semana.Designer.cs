namespace My_Menu
{
    partial class Dias_de_la_semana
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
            txtDia = new TextBox();
            txtNombre = new TextBox();
            txtLeyenda = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btmHacer = new Button();
            btmSalir = new Button();
            LabelNumero = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtDia
            // 
            txtDia.Location = new Point(95, 47);
            txtDia.Margin = new Padding(3, 2, 3, 2);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(110, 23);
            txtDia.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(95, 140);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(110, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtLeyenda
            // 
            txtLeyenda.Enabled = false;
            txtLeyenda.Location = new Point(95, 224);
            txtLeyenda.Margin = new Padding(3, 2, 3, 2);
            txtLeyenda.Name = "txtLeyenda";
            txtLeyenda.Size = new Size(110, 23);
            txtLeyenda.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 20);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 3;
            label1.Text = "Dia de la semana";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 96);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 4;
            label2.Text = "Dia de la semana";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 196);
            label3.Name = "label3";
            label3.Size = new Size(132, 15);
            label3.TabIndex = 5;
            label3.Text = "Leyenda referente al dia";
            // 
            // btmHacer
            // 
            btmHacer.Location = new Point(303, 122);
            btmHacer.Margin = new Padding(3, 2, 3, 2);
            btmHacer.Name = "btmHacer";
            btmHacer.Size = new Size(82, 22);
            btmHacer.TabIndex = 6;
            btmHacer.Text = "Dime";
            btmHacer.UseVisualStyleBackColor = true;
            btmHacer.Click += btmHacer_Click;
            btmHacer.KeyPress += btmHacer_KeyPress;
            // 
            // btmSalir
            // 
            btmSalir.Location = new Point(292, 290);
            btmSalir.Margin = new Padding(3, 2, 3, 2);
            btmSalir.Name = "btmSalir";
            btmSalir.Size = new Size(82, 22);
            btmSalir.TabIndex = 7;
            btmSalir.Text = "Salir";
            btmSalir.UseVisualStyleBackColor = true;
            // 
            // LabelNumero
            // 
            LabelNumero.AutoSize = true;
            LabelNumero.Location = new Point(381, 52);
            LabelNumero.Name = "LabelNumero";
            LabelNumero.Size = new Size(0, 15);
            LabelNumero.TabIndex = 8;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Dias_de_la_semana
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(LabelNumero);
            Controls.Add(btmSalir);
            Controls.Add(btmHacer);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLeyenda);
            Controls.Add(txtNombre);
            Controls.Add(txtDia);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Dias_de_la_semana";
            Text = "Dias_de_la_semana";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDia;
        private TextBox txtNombre;
        private TextBox txtLeyenda;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btmHacer;
        private Button btmSalir;
        private Label LabelNumero;
        private ErrorProvider errorProvider1;
    }
}