using jogoXadrez.Tabuleiro;

namespace jogoXadrez.Xadrez
{
    public class Rei : Peca
    {
        public Rei(Cor cor, tabuleiro tab) : base(cor, tab)
        {
            
        }

        public override string ToString()
        {
            return "R";
        }
    }
}