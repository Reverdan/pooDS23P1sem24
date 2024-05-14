namespace CalculoFatorial
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
            btnCalcular = new Button();
            lblResposta = new Label();
            SuspendLayout();
            // 
            // txbNumero
            // 
            txbNumero.Location = new Point(31, 31);
            txbNumero.Name = "txbNumero";
            txbNumero.Size = new Size(147, 23);
            txbNumero.TabIndex = 0;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(31, 71);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(147, 23);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular Fatorial";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResposta
            // 
            lblResposta.AutoSize = true;
            lblResposta.Location = new Point(31, 107);
            lblResposta.Name = "lblResposta";
            lblResposta.Size = new Size(54, 15);
            lblResposta.TabIndex = 2;
            lblResposta.Text = "Resposta";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(209, 165);
            Controls.Add(lblResposta);
            Controls.Add(btnCalcular);
            Controls.Add(txbNumero);
            Name = "Form1";
            Text = "Fatorial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbNumero;
        private Button btnCalcular;
        private Label lblResposta;
    }
}
