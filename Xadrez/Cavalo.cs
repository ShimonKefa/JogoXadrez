using jogoXadrez.Tabuleiro;

namespace jogoXadrez.Xadrez
{
    public class Cavalo : Peca
    {
        public Cavalo(Cor cor, tabuleiro tab) : base(cor, tab)
        {
            
        }

        public override string ToString()
        {
            return "C";
        }
    }
}