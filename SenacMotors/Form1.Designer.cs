namespace SenacMotors
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
            btnCriarCarro = new Button();
            btnAcelerar = new Button();
            btnFreiar = new Button();
            lblVelocimetro = new Label();
            lblAviso = new Label();
            lblMarcha = new Label();
            btnDesceMarcha = new Button();
            btnSobeMarcha = new Button();
            btnDireita = new Button();
            btnEsquerda = new Button();
            btnCriarMoto = new Button();
            SuspendLayout();
            // 
            // btnCriarCarro
            // 
            btnCriarCarro.BackColor = Color.Green;
            btnCriarCarro.BackgroundImageLayout = ImageLayout.None;
            btnCriarCarro.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCriarCarro.ForeColor = Color.LawnGreen;
            btnCriarCarro.Location = new Point(12, 15);
            btnCriarCarro.Name = "btnCriarCarro";
            btnCriarCarro.Size = new Size(133, 38);
            btnCriarCarro.TabIndex = 0;
            btnCriarCarro.Text = "Criar Carro";
            btnCriarCarro.UseVisualStyleBackColor = false;
            btnCriarCarro.Click += btnCriarCarro_Click;
            // 
            // btnAcelerar
            // 
            btnAcelerar.BackColor = Color.DarkGreen;
            btnAcelerar.Font = new Font("Arial", 14.25F);
            btnAcelerar.ForeColor = Color.Lime;
            btnAcelerar.Location = new Point(151, 27);
            btnAcelerar.Name = "btnAcelerar";
            btnAcelerar.Size = new Size(133, 41);
            btnAcelerar.TabIndex = 1;
            btnAcelerar.Text = "Acelerar";
            btnAcelerar.UseVisualStyleBackColor = false;
            btnAcelerar.Click += btnAcelerar_Click;
            // 
            // btnFreiar
            // 
            btnFreiar.BackColor = Color.DarkGreen;
            btnFreiar.Font = new Font("Arial", 14.25F);
            btnFreiar.ForeColor = Color.Lime;
            btnFreiar.Location = new Point(299, 27);
            btnFreiar.Name = "btnFreiar";
            btnFreiar.Size = new Size(133, 41);
            btnFreiar.TabIndex = 2;
            btnFreiar.Text = "Freiar";
            btnFreiar.UseVisualStyleBackColor = false;
            btnFreiar.Click += btnFreiar_Click;
            // 
            // lblVelocimetro
            // 
            lblVelocimetro.AutoSize = true;
            lblVelocimetro.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            lblVelocimetro.Location = new Point(151, 108);
            lblVelocimetro.Name = "lblVelocimetro";
            lblVelocimetro.Size = new Size(65, 22);
            lblVelocimetro.TabIndex = 3;
            lblVelocimetro.Text = "label1";
            // 
            // lblAviso
            // 
            lblAviso.AutoSize = true;
            lblAviso.Font = new Font("Arial", 14.25F);
            lblAviso.ForeColor = Color.DodgerBlue;
            lblAviso.Location = new Point(180, 150);
            lblAviso.Name = "lblAviso";
            lblAviso.Size = new Size(61, 22);
            lblAviso.TabIndex = 4;
            lblAviso.Text = "label2";
            // 
            // lblMarcha
            // 
            lblMarcha.AutoSize = true;
            lblMarcha.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            lblMarcha.Location = new Point(226, 108);
            lblMarcha.Name = "lblMarcha";
            lblMarcha.Size = new Size(65, 22);
            lblMarcha.TabIndex = 5;
            lblMarcha.Text = "label2";
            // 
            // btnDesceMarcha
            // 
            btnDesceMarcha.BackColor = Color.DarkGreen;
            btnDesceMarcha.Font = new Font("Arial", 14.25F);
            btnDesceMarcha.ForeColor = Color.Lime;
            btnDesceMarcha.Location = new Point(448, 96);
            btnDesceMarcha.Name = "btnDesceMarcha";
            btnDesceMarcha.Size = new Size(155, 46);
            btnDesceMarcha.TabIndex = 7;
            btnDesceMarcha.Text = "Desce Marcha";
            btnDesceMarcha.UseVisualStyleBackColor = false;
            btnDesceMarcha.Click += btnDesceMarcha_Click;
            // 
            // btnSobeMarcha
            // 
            btnSobeMarcha.BackColor = Color.DarkGreen;
            btnSobeMarcha.Font = new Font("Arial", 14.25F);
            btnSobeMarcha.ForeColor = Color.Lime;
            btnSobeMarcha.Location = new Point(448, 27);
            btnSobeMarcha.Name = "btnSobeMarcha";
            btnSobeMarcha.Size = new Size(155, 41);
            btnSobeMarcha.TabIndex = 6;
            btnSobeMarcha.Text = "Sobe Marcha";
            btnSobeMarcha.UseVisualStyleBackColor = false;
            btnSobeMarcha.Click += btnSobeMarcha_Click;
            // 
            // btnDireita
            // 
            btnDireita.BackColor = Color.ForestGreen;
            btnDireita.BackgroundImageLayout = ImageLayout.None;
            btnDireita.Font = new Font("Arial", 14.25F);
            btnDireita.ForeColor = Color.Lime;
            btnDireita.Location = new Point(448, 337);
            btnDireita.Name = "btnDireita";
            btnDireita.Size = new Size(155, 46);
            btnDireita.TabIndex = 9;
            btnDireita.Text = "Virar Direita";
            btnDireita.UseVisualStyleBackColor = false;
            btnDireita.Click += btnDireita_Click;
            // 
            // btnEsquerda
            // 
            btnEsquerda.BackColor = Color.ForestGreen;
            btnEsquerda.BackgroundImageLayout = ImageLayout.None;
            btnEsquerda.Font = new Font("Arial", 14.25F);
            btnEsquerda.ForeColor = Color.Lime;
            btnEsquerda.Location = new Point(12, 337);
            btnEsquerda.Name = "btnEsquerda";
            btnEsquerda.Size = new Size(155, 41);
            btnEsquerda.TabIndex = 8;
            btnEsquerda.Text = "Virar Esquerda";
            btnEsquerda.UseVisualStyleBackColor = false;
            btnEsquerda.Click += btnEsquerda_Click;
            // 
            // btnCriarMoto
            // 
            btnCriarMoto.BackColor = Color.Green;
            btnCriarMoto.BackgroundImageLayout = ImageLayout.None;
            btnCriarMoto.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCriarMoto.ForeColor = Color.LawnGreen;
            btnCriarMoto.Location = new Point(12, 59);
            btnCriarMoto.Name = "btnCriarMoto";
            btnCriarMoto.Size = new Size(133, 38);
            btnCriarMoto.TabIndex = 10;
            btnCriarMoto.Text = "Criar Moto";
            btnCriarMoto.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 450);
            Controls.Add(btnCriarMoto);
            Controls.Add(btnDireita);
            Controls.Add(btnEsquerda);
            Controls.Add(btnDesceMarcha);
            Controls.Add(btnSobeMarcha);
            Controls.Add(lblMarcha);
            Controls.Add(lblAviso);
            Controls.Add(lblVelocimetro);
            Controls.Add(btnFreiar);
            Controls.Add(btnAcelerar);
            Controls.Add(btnCriarCarro);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCriarCarro;
        private Button btnAcelerar;
        private Button btnFreiar;
        private Label lblVelocimetro;
        private Label lblAviso;
        private Label lblMarcha;
        private Button btnDesceMarcha;
        private Button btnSobeMarcha;
        private Button btnDireita;
        private Button btnEsquerda;
        private Button btnCriarMoto;
    }
}
