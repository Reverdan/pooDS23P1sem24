namespace Polimorfismo
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
            txbValor = new TextBox();
            btnCalcular = new Button();
            lblResposta = new Label();
            SuspendLayout();
            // 
            // txbValor
            // 
            txbValor.Location = new Point(66, 43);
            txbValor.Name = "txbValor";
            txbValor.Size = new Size(163, 23);
            txbValor.TabIndex = 0;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(108, 86);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "button1";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResposta
            // 
            lblResposta.AutoSize = true;
            lblResposta.Location = new Point(66, 135);
            lblResposta.Name = "lblResposta";
            lblResposta.Size = new Size(38, 15);
            lblResposta.TabIndex = 2;
            lblResposta.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 208);
            Controls.Add(lblResposta);
            Controls.Add(btnCalcular);
            Controls.Add(txbValor);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbValor;
        private Button btnCalcular;
        private Label lblResposta;
    }
}
