namespace My_Menu
{
    partial class Do_While
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
            lbDatos = new ListBox();
            btmWhile = new Button();
            btmDoWhile = new Button();
            btmSalir = new Button();
            SuspendLayout();
            // 
            // lbDatos
            // 
            lbDatos.FormattingEnabled = true;
            lbDatos.ItemHeight = 20;
            lbDatos.Location = new Point(12, 12);
            lbDatos.Name = "lbDatos";
            lbDatos.Size = new Size(225, 424);
            lbDatos.TabIndex = 0;
            // 
            // btmWhile
            // 
            btmWhile.Location = new Point(452, 108);
            btmWhile.Name = "btmWhile";
            btmWhile.Size = new Size(94, 29);
            btmWhile.TabIndex = 1;
            btmWhile.Text = "While";
            btmWhile.UseVisualStyleBackColor = true;
            btmWhile.Click += btmWhile_Click;
            // 
            // btmDoWhile
            // 
            btmDoWhile.Location = new Point(452, 188);
            btmDoWhile.Name = "btmDoWhile";
            btmDoWhile.Size = new Size(94, 29);
            btmDoWhile.TabIndex = 2;
            btmDoWhile.Text = "Do While";
            btmDoWhile.UseVisualStyleBackColor = true;
            btmDoWhile.Click += btmDoWhile_Click;
            // 
            // btmSalir
            // 
            btmSalir.Location = new Point(300, 409);
            btmSalir.Name = "btmSalir";
            btmSalir.Size = new Size(94, 29);
            btmSalir.TabIndex = 3;
            btmSalir.Text = "Salir";
            btmSalir.UseVisualStyleBackColor = true;
            // 
            // Do_While
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btmSalir);
            Controls.Add(btmDoWhile);
            Controls.Add(btmWhile);
            Controls.Add(lbDatos);
            Name = "Do_While";
            Text = "Do_While";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbDatos;
        private Button btmWhile;
        private Button btmDoWhile;
        private Button btmSalir;
    }
}