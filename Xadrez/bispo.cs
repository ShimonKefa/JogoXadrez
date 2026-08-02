using jogoXadrez.Tabuleiro;

namespace jogoXadrez.Xadrez
{
    public class Bispo : Peca
    {
        public Bispo(Cor cor, tabuleiro tab) : base(cor, tab)
        {
            
        }

        public override string ToString()
        {
            return "B";
        }
    }
}