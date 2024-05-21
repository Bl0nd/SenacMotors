namespace SenacMotors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Carro novoCarro;
        private void btnCriarCarro_Click(object sender, EventArgs e)
        {
            //instanciar o carro
            novoCarro = new Carro();
            novoCarro.Marca = "Fiat";
            novoCarro.Modelo = "Toro";
            novoCarro.Cor = "Roxo";
            novoCarro.Ano = 2022;
            novoCarro.NumeroPortas = 4;
            novoCarro.Automatico = true;
        }

        private void btnAcelerar_Click(object sender, EventArgs e)
        {
            novoCarro.Acelerar();
            lblVelocimetro.Text = novoCarro.GetVelocidade().ToString();

            if (novoCarro.Automatico)
            {
                novoCarro.TrocarMarcha(true);
                lblMarcha.Text = novoCarro.GetMarcha().ToString();
            }
        }

        private void btnFreiar_Click(object sender, EventArgs e)
        {
            novoCarro.Freiar();
            lblVelocimetro.Text = novoCarro.GetVelocidade().ToString();

            if (novoCarro.Automatico)
            {
                novoCarro.TrocarMarcha(true);
                lblMarcha.Text = novoCarro.GetMarcha().ToString();
            }
        }

        private void btnSobeMarcha_Click(object sender, EventArgs e)
        {
            novoCarro.TrocarMarcha("+");
            lblMarcha.Text = novoCarro.GetMarcha().ToString();
        }

        private void btnDesceMarcha_Click(object sender, EventArgs e)
        {
            novoCarro.TrocarMarcha("-");
            lblMarcha.Text = novoCarro.GetMarcha().ToString();
        }

        private void btnEsquerda_Click(object sender, EventArgs e)
        {
            lblAviso.Text = novoCarro.Direcionar("Esquerda");
        }

        private void btnDireita_Click(object sender, EventArgs e)
        {
            lblAviso.Text = novoCarro.Direcionar("Direita");
        }
    }
}
