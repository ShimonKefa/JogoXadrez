using System.IO.Pipelines;

namespace jogoXadrez.Tabuleiro
{
    public class tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] pecas;

        public tabuleiro() { }

        public tabuleiro(int Linhas, int Colunas)
        {
            this.Linhas = Linhas;
            this.Colunas = Colunas;
            pecas = new Peca[Linhas, Colunas];
        }

        public Peca p(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        public void ColocarPeca(Peca p, Posicao Pos)
        {
            pecas[Pos.Linha, Pos.Coluna] = p;
            p.posicao = Pos;
        }
    }
}
