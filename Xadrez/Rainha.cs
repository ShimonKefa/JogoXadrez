using jogoXadrez.Tabuleiro;

namespace jogoXadrez.Xadrez
{
    public class Rainha : Peca
    {
        public Rainha(Cor cor, tabuleiro tab) : base(cor, tab)
        {
            
        }

        public override string ToString()
        {
            return "R";
        }
    }
}