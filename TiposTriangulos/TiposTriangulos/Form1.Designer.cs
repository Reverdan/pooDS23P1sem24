namespace TiposTriangulos
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
            lblLado1 = new Label();
            txbLado1 = new TextBox();
            txbLado2 = new TextBox();
            lblLado2 = new Label();
            txbLado3 = new TextBox();
            lblLado3 = new Label();
            btnVerificar = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblLado1
            // 
            lblLado1.AutoSize = true;
            lblLado1.Location = new Point(35, 9);
            lblLado1.Name = "lblLado1";
            lblLado1.Size = new Size(42, 15);
            lblLado1.TabIndex = 0;
            lblLado1.Text = "Lado 1";
            // 
            // txbLado1
            // 
            txbLado1.Location = new Point(35, 27);
            txbLado1.Name = "txbLado1";
            txbLado1.Size = new Size(167, 23);
            txbLado1.TabIndex = 1;
            // 
            // txbLado2
            // 
            txbLado2.Location = new Point(35, 90);
            txbLado2.Name = "txbLado2";
            txbLado2.Size = new Size(167, 23);
            txbLado2.TabIndex = 3;
            // 
            // lblLado2
            // 
            lblLado2.AutoSize = true;
            lblLado2.Location = new Point(35, 72);
            lblLado2.Name = "lblLado2";
            lblLado2.Size = new Size(42, 15);
            lblLado2.TabIndex = 2;
            lblLado2.Text = "Lado 2";
            // 
            // txbLado3
            // 
            txbLado3.Location = new Point(35, 153);
            txbLado3.Name = "txbLado3";
            txbLado3.Size = new Size(167, 23);
            txbLado3.TabIndex = 5;
            // 
            // lblLado3
            // 
            lblLado3.AutoSize = true;
            lblLado3.Location = new Point(35, 135);
            lblLado3.Name = "lblLado3";
            lblLado3.Size = new Size(42, 15);
            lblLado3.TabIndex = 4;
            lblLado3.Text = "Lado 3";
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(35, 207);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(167, 25);
            btnVerificar.TabIndex = 6;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(35, 259);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 7;
            lblResultado.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 301);
            Controls.Add(lblResultado);
            Controls.Add(btnVerificar);
            Controls.Add(txbLado3);
            Controls.Add(lblLado3);
            Controls.Add(txbLado2);
            Controls.Add(lblLado2);
            Controls.Add(txbLado1);
            Controls.Add(lblLado1);
            Name = "Form1";
            Text = "Triangulos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLado1;
        private TextBox txbLado1;
        private TextBox txbLado2;
        private Label lblLado2;
        private TextBox txbLado3;
        private Label lblLado3;
        private Button btnVerificar;
        private Label lblResultado;
    }
}
