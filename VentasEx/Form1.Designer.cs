namespace VentasEx
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
            btnAgregar = new Button();
            dgvVentas = new DataGridView();
            label1 = new Label();
            btnVentas = new Button();
            txtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtCntd = new TextBox();
            txtPrice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(330, 130);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(84, 32);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += button1_Click;
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(105, 199);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.Size = new Size(485, 228);
            dgvVentas.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 32);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // btnVentas
            // 
            btnVentas.Location = new Point(438, 115);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(151, 63);
            btnVentas.TabIndex = 4;
            btnVentas.Text = "Calcular Ventas Totales";
            btnVentas.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            txtName.Location = new Point(167, 28);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(313, 31);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 6;
            label2.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(515, 32);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 7;
            label3.Text = "Cantidad";
            // 
            // txtCntd
            // 
            txtCntd.Location = new Point(580, 28);
            txtCntd.Name = "txtCntd";
            txtCntd.Size = new Size(100, 23);
            txtCntd.TabIndex = 8;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(370, 28);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPrice);
            Controls.Add(txtCntd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(btnVentas);
            Controls.Add(label1);
            Controls.Add(dgvVentas);
            Controls.Add(btnAgregar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private DataGridView dgvVentas;
        private Label label1;
        private Button btnVentas;
        private TextBox txtName;
        private Label label2;
        private Label label3;
        private TextBox txtCntd;
        private TextBox txtPrice;
    }
}
