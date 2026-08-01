namespace jogoXadrez.Tabuleiro
{
    public class tabuleiro
    {
        public int Linhas {get; set;}
        public int Colunas{get; set;}
        public Peca[,] pecas;

        public tabuleiro()
        {
            
        }
        public tabuleiro(int Linhas, int Colunas )
        {
            this.Linhas = Linhas;
            this.Colunas = Colunas;
            pecas = new Peca[Linhas, Colunas];
        }

    }
}

