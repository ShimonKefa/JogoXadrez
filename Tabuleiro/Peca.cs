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

        public Peca(Cor cor, tabuleiro tab)
        {
            this.posicao = null;
            this.cor = cor;
            this.tab = tab;
            this.QtdeMov = 0;
        }

        public void IncrementaQTDEMov()
        {
            QtdeMov++;
        }
    }
}