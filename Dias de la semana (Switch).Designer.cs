namespace My_Menu
{
    partial class Dias_de_la_semana__Switch_
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
            btmSalir = new Button();
            btmHacer = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtLeyenda = new TextBox();
            txtNombre = new TextBox();
            txtDia = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            LabelNumero = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btmSalir
            // 
            btmSalir.Location = new Point(304, 278);
            btmSalir.Margin = new Padding(3, 2, 3, 2);
            btmSalir.Name = "btmSalir";
            btmSalir.Size = new Size(82, 22);
            btmSalir.TabIndex = 15;
            btmSalir.Text = "Salir";
            btmSalir.UseVisualStyleBackColor = true;
            // 
            // btmHacer
            // 
            btmHacer.Location = new Point(315, 110);
            btmHacer.Margin = new Padding(3, 2, 3, 2);
            btmHacer.Name = "btmHacer";
            btmHacer.Size = new Size(82, 22);
            btmHacer.TabIndex = 14;
            btmHacer.Text = "Dime";
            btmHacer.UseVisualStyleBackColor = true;
            btmHacer.Click += btmHacer_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(108, 184);
            label3.Name = "label3";
            label3.Size = new Size(132, 15);
            label3.TabIndex = 13;
            label3.Text = "Leyenda referente al dia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 84);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 12;
            label2.Text = "Dia de la semana";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 8);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 11;
            label1.Text = "Dia de la semana";
            // 
            // txtLeyenda
            // 
            txtLeyenda.Enabled = false;
            txtLeyenda.Location = new Point(108, 212);
            txtLeyenda.Margin = new Padding(3, 2, 3, 2);
            txtLeyenda.Name = "txtLeyenda";
            txtLeyenda.Size = new Size(110, 23);
            txtLeyenda.TabIndex = 10;
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(108, 128);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(110, 23);
            txtNombre.TabIndex = 9;
            // 
            // txtDia
            // 
            txtDia.Location = new Point(108, 35);
            txtDia.Margin = new Padding(3, 2, 3, 2);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(110, 23);
            txtDia.TabIndex = 8;
            txtDia.KeyPress += txtDia_KeyPress;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // LabelNumero
            // 
            LabelNumero.AutoSize = true;
            LabelNumero.Location = new Point(280, 37);
            LabelNumero.Name = "LabelNumero";
            LabelNumero.Size = new Size(0, 15);
            LabelNumero.TabIndex = 16;
            // 
            // Dias_de_la_semana__Switch_
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
            Name = "Dias_de_la_semana__Switch_";
            Text = "Dias_de_la_semana__Switch_";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btmSalir;
        private Button btmHacer;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtLeyenda;
        private TextBox txtNombre;
        private TextBox txtDia;
        private ErrorProvider errorProvider1;
        private Label LabelNumero;
    }
}