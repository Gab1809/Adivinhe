using JogoAdivinhacao.Models;

namespace JogoAdivinhacao.Controllers
{
    public class GameController
    {
        private Game game;

        public GameController()
        {
            game = new Game();
        }

        public string Verificar(int palpite)
        {
            return game.VerificarPalpite(palpite);
        }
    }
}
