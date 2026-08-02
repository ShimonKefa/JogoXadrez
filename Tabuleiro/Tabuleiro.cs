using jogoXadrez.Exceptions;

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

        public Peca peca(Posicao pos)
        {
            return pecas[pos.Linha, pos.Coluna];
        }

        public void ColocarPeca(Peca p, Posicao Pos)
        {
            if (existePeca(Pos))
            {
                System.Console.WriteLine("já existe peça nessa posição");
            }
            pecas[Pos.Linha, Pos.Coluna] = p;
            p.posicao = Pos;
        }

        public Peca RetirarPeca(Posicao pos)
        {
            if(peca(pos) == null)
            {
                return null;
            }
            else
            {
                Peca aux1 = peca(pos);
                aux1.posicao = null;
                pecas[pos.Linha, pos.Coluna] = null;
                return aux1;
            }
        }
        public bool existePeca(Posicao pos)
        {
            ValidatePos(pos);
            return peca(pos) != null;
            
        }

        public bool PosicaoValidada(Posicao pos)
        {
            if(pos.Linha < 0 || pos.Linha >= Linhas || pos.Coluna < 0 || pos.Coluna >= Colunas)
            {
                return false;
            }
            return true;
        }

        public void ValidatePos(Posicao pos)
        {
            if (!PosicaoValidada(pos))
            {
                throw new tabsException("posição invalida");
            }
        }

    }
}
