namespace VerificarPrimo
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
            txbNumero = new TextBox();
            btnVerificar = new Button();
            lblResposta = new Label();
            SuspendLayout();
            // 
            // txbNumero
            // 
            txbNumero.Location = new Point(35, 21);
            txbNumero.Name = "txbNumero";
            txbNumero.Size = new Size(157, 23);
            txbNumero.TabIndex = 0;
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(35, 61);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(157, 23);
            btnVerificar.TabIndex = 1;
            btnVerificar.Text = "Verificar Primo";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // lblResposta
            // 
            lblResposta.AutoSize = true;
            lblResposta.Location = new Point(35, 105);
            lblResposta.Name = "lblResposta";
            lblResposta.Size = new Size(54, 15);
            lblResposta.TabIndex = 2;
            lblResposta.Text = "Resposta";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(237, 161);
            Controls.Add(lblResposta);
            Controls.Add(btnVerificar);
            Controls.Add(txbNumero);
            Name = "Form1";
            Text = "Primo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbNumero;
        private Button btnVerificar;
        private Label lblResposta;
    }
}
