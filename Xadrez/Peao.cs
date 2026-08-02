using jogoXadrez.Tabuleiro;

namespace jogoXadrez.Xadrez
{
    public class Peao : Peca
    {
        public Peao(Cor cor, tabuleiro tab) : base(cor, tab)
        {
            
        }

        public override string ToString()
        {
            return "P";
        }
    }
}