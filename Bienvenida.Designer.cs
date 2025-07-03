namespace My_Menu
{
    partial class Bienvenida
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
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btmIniciar = new Button();
            pictureBox1 = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(83, 204);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(194, 25);
            txtUsuario.TabIndex = 0;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(83, 307);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(194, 25);
            txtContraseña.TabIndex = 1;
            txtContraseña.UseSystemPasswordChar = true;
            txtContraseña.KeyUp += txtContraseña_KeyUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 173);
            label1.Name = "label1";
            label1.Size = new Size(79, 17);
            label1.TabIndex = 2;
            label1.Text = "USUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 267);
            label2.Name = "label2";
            label2.Size = new Size(115, 17);
            label2.TabIndex = 3;
            label2.Text = "CONTRASEÑA";
            // 
            // btmIniciar
            // 
            btmIniciar.Location = new Point(138, 399);
            btmIniciar.Name = "btmIniciar";
            btmIniciar.Size = new Size(97, 26);
            btmIniciar.TabIndex = 4;
            btmIniciar.Text = "Iniciar";
            btmIniciar.UseVisualStyleBackColor = true;
            btmIniciar.Click += btmIniciar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Inicio_de_sesion;
            pictureBox1.Location = new Point(101, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(167, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Bienvenida
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(199, 225, 221);
            ClientSize = new Size(405, 429);
            Controls.Add(pictureBox1);
            Controls.Add(btmIniciar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Bienvenida";
            ShowIcon = false;
            Text = "Bienvenida";
            Load += Bienvenida_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Label label1;
        private Label label2;
        private Button btmIniciar;
        private PictureBox pictureBox1;
        private ErrorProvider errorProvider1;
    }
}