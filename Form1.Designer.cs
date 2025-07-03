namespace My_Menu
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
            txtNumEmpleado = new TextBox();
            txtNombreEmpleado = new TextBox();
            txtFolio = new TextBox();
            numericUpDown1 = new NumericUpDown();
            txtArtNom = new TextBox();
            txtArtDescrp = new TextBox();
            txtCantList = new TextBox();
            txtArtNomList = new TextBox();
            txtDescpList = new TextBox();
            txtPrecio = new TextBox();
            txtPrecioList = new TextBox();
            txtSubtotal = new TextBox();
            txtIVA = new TextBox();
            txtTotal = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btmmPagar = new Button();
            lblDescuento = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // txtNumEmpleado
            // 
            txtNumEmpleado.Location = new Point(34, 50);
            txtNumEmpleado.Name = "txtNumEmpleado";
            txtNumEmpleado.Size = new Size(125, 27);
            txtNumEmpleado.TabIndex = 0;
            txtNumEmpleado.KeyPress += txtNumEmpleado_KeyPress;
            // 
            // txtNombreEmpleado
            // 
            txtNombreEmpleado.Enabled = false;
            txtNombreEmpleado.Location = new Point(199, 50);
            txtNombreEmpleado.Name = "txtNombreEmpleado";
            txtNombreEmpleado.Size = new Size(125, 27);
            txtNombreEmpleado.TabIndex = 1;
            // 
            // txtFolio
            // 
            txtFolio.Location = new Point(464, 50);
            txtFolio.Name = "txtFolio";
            txtFolio.Size = new Size(125, 27);
            txtFolio.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(34, 131);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(89, 27);
            numericUpDown1.TabIndex = 3;
            // 
            // txtArtNom
            // 
            txtArtNom.Location = new Point(149, 131);
            txtArtNom.Name = "txtArtNom";
            txtArtNom.Size = new Size(175, 27);
            txtArtNom.TabIndex = 4;
            txtArtNom.KeyPress += txtArtNom_KeyPress;
            // 
            // txtArtDescrp
            // 
            txtArtDescrp.Location = new Point(333, 130);
            txtArtDescrp.Name = "txtArtDescrp";
            txtArtDescrp.Size = new Size(205, 27);
            txtArtDescrp.TabIndex = 5;
            txtArtDescrp.KeyPress += txtArtDescrp_KeyPress;
            // 
            // txtCantList
            // 
            txtCantList.Enabled = false;
            txtCantList.Location = new Point(34, 179);
            txtCantList.Multiline = true;
            txtCantList.Name = "txtCantList";
            txtCantList.Size = new Size(89, 131);
            txtCantList.TabIndex = 6;
            // 
            // txtArtNomList
            // 
            txtArtNomList.Enabled = false;
            txtArtNomList.Location = new Point(149, 179);
            txtArtNomList.Multiline = true;
            txtArtNomList.Name = "txtArtNomList";
            txtArtNomList.Size = new Size(175, 131);
            txtArtNomList.TabIndex = 7;
            // 
            // txtDescpList
            // 
            txtDescpList.Enabled = false;
            txtDescpList.Location = new Point(333, 179);
            txtDescpList.Multiline = true;
            txtDescpList.Name = "txtDescpList";
            txtDescpList.Size = new Size(214, 131);
            txtDescpList.TabIndex = 8;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(608, 130);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 9;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // txtPrecioList
            // 
            txtPrecioList.Enabled = false;
            txtPrecioList.Location = new Point(608, 179);
            txtPrecioList.Multiline = true;
            txtPrecioList.Name = "txtPrecioList";
            txtPrecioList.Size = new Size(134, 131);
            txtPrecioList.TabIndex = 10;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Enabled = false;
            txtSubtotal.Location = new Point(608, 337);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(125, 27);
            txtSubtotal.TabIndex = 11;
            // 
            // txtIVA
            // 
            txtIVA.Enabled = false;
            txtIVA.Location = new Point(608, 370);
            txtIVA.Name = "txtIVA";
            txtIVA.Size = new Size(125, 27);
            txtIVA.TabIndex = 12;
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(608, 403);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(515, 9);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 14;
            label1.Text = "Folio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 9);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 15;
            label2.Text = "No. Empleado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(449, 337);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 16;
            label3.Text = "Subtotal";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(449, 370);
            label4.Name = "label4";
            label4.Size = new Size(31, 20);
            label4.TabIndex = 17;
            label4.Text = "IVA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(449, 403);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 18;
            label5.Text = "Total";
            // 
            // btmmPagar
            // 
            btmmPagar.Location = new Point(189, 351);
            btmmPagar.Name = "btmmPagar";
            btmmPagar.Size = new Size(94, 29);
            btmmPagar.TabIndex = 19;
            btmmPagar.Text = "Pagar";
            btmmPagar.UseVisualStyleBackColor = true;
            btmmPagar.Click += btmmPagar_Click;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(233, 405);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(0, 20);
            lblDescuento.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(58, 99);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 21;
            label6.Text = "Cantidad";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(222, 91);
            label7.Name = "label7";
            label7.Size = new Size(64, 20);
            label7.TabIndex = 22;
            label7.Text = "Nombre";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(362, 91);
            label8.Name = "label8";
            label8.Size = new Size(87, 20);
            label8.TabIndex = 23;
            label8.Text = "Descripcion";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(629, 91);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 24;
            label9.Text = "Precio";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(lblDescuento);
            Controls.Add(btmmPagar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTotal);
            Controls.Add(txtIVA);
            Controls.Add(txtSubtotal);
            Controls.Add(txtPrecioList);
            Controls.Add(txtPrecio);
            Controls.Add(txtDescpList);
            Controls.Add(txtArtNomList);
            Controls.Add(txtCantList);
            Controls.Add(txtArtDescrp);
            Controls.Add(txtArtNom);
            Controls.Add(numericUpDown1);
            Controls.Add(txtFolio);
            Controls.Add(txtNombreEmpleado);
            Controls.Add(txtNumEmpleado);
            Name = "Form1";
            Text = "VENTA";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumEmpleado;
        private TextBox txtNombreEmpleado;
        private TextBox txtFolio;
        private NumericUpDown numericUpDown1;
        private TextBox txtArtNom;
        private TextBox txtArtDescrp;
        private TextBox txtCantList;
        private TextBox txtArtNomList;
        private TextBox txtDescpList;
        private TextBox txtPrecio;
        private TextBox txtPrecioList;
        private TextBox txtSubtotal;
        private TextBox txtIVA;
        private TextBox txtTotal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btmmPagar;
        private Label lblDescuento;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}