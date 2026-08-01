namespace jogoXadrez.Tabuleiro
{
    public class Peca
    {
        public Posicao posicao { get; set;}
        public Cor cor {get; protected set;}

        public int QtdeMov {get; protected set;}
        public tabuleiro tab {get; set;}

        public Peca()
        {
            
        }

        public Peca(Posicao posicao, Cor cor, tabuleiro tab)
        {
            this.posicao = posicao;
            this.cor = cor;
            this.tab = tab;
        }
    }
}