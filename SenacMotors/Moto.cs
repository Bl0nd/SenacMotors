using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacMotors
{
    public class Moto : Veiculo
    {
        public string Ligar()
        {
            Ligado = true;

            return "Liguei a Moto ! ";
        }
        public string Empinar()
        {
            return "Empinei a Moto !";
        }
        public string Direcionar(string direcao)
        {
            string guidao = $"Virando o guidão para {direcao}";

            return guidao;
        }
    }
}
