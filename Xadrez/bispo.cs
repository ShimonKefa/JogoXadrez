using jogoXadrez.Tabuleiro;

namespace jogoXadrez.Xadrez
{
    public class Bispo : Peca
    {
        public Bispo(Cor cor, tabuleiro tab) : base(cor, tab)
        {
            
        }
                private bool PodeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != this.cor;
        }
        public override bool[,] MovimentosPossiveis()
        {
           bool[,] mat = new bool[tab.Linhas, tab.Colunas];
            Posicao pos = new Posicao(0,0); 

            //nordeste
            pos.DefinirValores(posicao.Linha - 1, posicao.Coluna + 1);
            if (tab.PosicaoValidada(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //Sudeste
            pos.DefinirValores(posicao.Linha +1, posicao.Coluna + 1);
            if (tab.PosicaoValidada(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //sudoeste
            pos.DefinirValores(posicao.Linha + 1, posicao.Coluna - 1);
            if (tab.PosicaoValidada(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //noroeste
            pos.DefinirValores(posicao.Linha - 1, posicao.Coluna - 1);
            if (tab.PosicaoValidada(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            return mat;
           
        }
        

        public override string ToString()
        {
            return "B";
        }
    }
}