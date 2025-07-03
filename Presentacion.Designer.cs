namespace My_Menu
{
    partial class Presentacion
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
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            progressBar1 = new ProgressBar();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(360, 101);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(431, 28);
            label1.TabIndex = 0;
            label1.Text = "ZURIEL SAID RODRIGUEZ GUERRERO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(333, 172);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(493, 28);
            label2.TabIndex = 1;
            label2.Text = "UNIVERSIDAD TECNOLOGICA DE NOGALES";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(484, 238);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(104, 28);
            label3.TabIndex = 2;
            label3.Text = "TIDS 2-2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(347, 334);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(474, 28);
            label4.TabIndex = 3;
            label4.Text = "PROGRAMACION ORIENTADA A OBJETOS";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 649);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1233, 29);
            progressBar1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.TI_UTN2;
            pictureBox1.Location = new Point(292, 371);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(559, 247);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Presentacion
            // 
            AutoScaleDimensions = new SizeF(14F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1257, 690);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(progressBar1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(5);
            Name = "Presentacion";
            ShowInTaskbar = false;
            Load += Presentacion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ProgressBar progressBar1;
        private PictureBox pictureBox1;
    }
}