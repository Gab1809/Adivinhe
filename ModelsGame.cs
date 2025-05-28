namespace JogoAdivinhacao.Models
{
    public class Game
    {
        private int numeroSecreto;
        private Random random;

        public Game()
        {
            random = new Random();
            GerarNovoNumero();
        }

        public void GerarNovoNumero()
        {
            numeroSecreto = random.Next(1, 101); // de 1 a 100
        }

        public string VerificarPalpite(int palpite)
        {
            if (palpite < numeroSecreto)
                return "Muito baixo!";
            else if (palpite > numeroSecreto)
                return "Muito alto!";
            else
            {
                GerarNovoNumero(); // reinicia o jogo
                return "Acertou!";
            }
        }
    }
}
