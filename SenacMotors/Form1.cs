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
            novoCarro.Automatico = false;
        }

        private void btnAcelerar_Click(object sender, EventArgs e)
        {
            novoCarro.Acelerar();
            lblVelocimetro.Text =novoCarro.Velocidade.ToString();
        }
    }
}
