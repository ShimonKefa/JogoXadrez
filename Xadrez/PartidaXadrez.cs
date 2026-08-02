using jogoXadrez.Tabuleiro;
using jogoXadrez.Tela;
namespace jogoXadrez.Xadrez
{
    public class PartidaXadrez
    {
        public tabuleiro tab {get; private set;}
        private int Turno;
        private Cor JogadorAtual;
        public PartidaXadrez()
        {
            tab = new  tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branco;
            ColocarPecas();
        }

        public void execMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.RetirarPeca(origem);
            tab.RetirarPeca(destino);
            tab.ColocarPeca(p, destino);
        }

        private void ColocarPecas()
        {
            //peoes pretos
            tab.ColocarPeca(new Peao(Cor.Preto, tab) , new posicaoXadrez('a', 7).ToPosicao());
            tab.ColocarPeca(new Peao(Cor.Preto, tab) , new posicaoXadrez('b', 7).ToPosicao());
            tab.ColocarPeca(new Peao(Cor.Preto, tab) , new posicaoXadrez('c', 7).ToPosicao());
            tab.ColocarPeca(new Peao(Cor.Preto, tab) , new posicaoXadrez('d', 7).ToPosicao());
            tab.ColocarPeca(new Peao(Cor.Preto, tab) , new posicaoXadrez('e', 7).ToPosicao());
            tab.ColocarPeca(new Peao(Cor.Preto, tab) , new posicaoXadrez('f', 7).ToPosicao());
            tab.ColocarPeca(new Peao(Cor.Preto, tab) , new posicaoXadrez('g', 7).ToPosicao());
            tab.ColocarPeca(new Peao(Cor.Preto, tab) , new posicaoXadrez('h', 7).ToPosicao());

            //torres Pretas
            tab.ColocarPeca(new Torre(Cor.Preto, tab) , new posicaoXadrez('a', 8).ToPosicao());
            tab.ColocarPeca(new Torre(Cor.Preto, tab) , new posicaoXadrez('h', 8).ToPosicao());

            //Cavalos Pretos
            tab.ColocarPeca(new Cavalo(Cor.Preto, tab) , new posicaoXadrez('b', 8).ToPosicao());
            tab.ColocarPeca(new Cavalo(Cor.Preto, tab) , new posicaoXadrez('g', 8).ToPosicao());

            //Bispos Pretos
            tab.ColocarPeca(new Bispo(Cor.Preto, tab) , new posicaoXadrez('c', 8).ToPosicao());
            tab.ColocarPeca(new Bispo(Cor.Preto, tab) , new posicaoXadrez('f', 8).ToPosicao());

            //rainha
            tab.ColocarPeca(new Rainha(Cor.Branco, tab), new posicaoXadrez('d', 1).ToPosicao());
            tab.ColocarPeca(new Rainha(Cor.Preto, tab), new posicaoXadrez('d', 8).ToPosicao());
            
            //rei 
            tab.ColocarPeca(new Rei(Cor.Branco, tab), new posicaoXadrez('e', 1).ToPosicao());
            tab.ColocarPeca(new Rei(Cor.Preto, tab), new posicaoXadrez('e', 8).ToPosicao());

            //Bispos Brancos
            tab.ColocarPeca(new Bispo(Cor.Branco, tab) , new posicaoXadrez('c', 1).ToPosicao());
            tab.ColocarPeca(new Bispo(Cor.Branco, tab) , new posicaoXadrez('f', 1).ToPosicao());

            //Cavalos Brancos
            tab.ColocarPeca(new Cavalo(Cor.Branco, tab) , new posicaoXadrez('b', 1).ToPosicao());
            tab.ColocarPeca(new Cavalo(Cor.Branco, tab) , new posicaoXadrez('g', 1).ToPosicao());

            //peoes Brancos
            tab.ColocarPeca(new Peao(Cor.Branco, tab) , new posicaoXadrez('a', 2).ToPosicao());
            tab.ColocarPeca(new Peao(Cor.Branco, tab) , new posicaoXadrez('b', 2).ToPosicao());
            tab.ColocarPeca(new Peao(Cor.Branco, tab) , new posicaoXadrez('c', 2).ToPosicao());
            tab.ColocarPeca(new Peao(Cor.Branco, tab) , new posicaoXadrez('d', 2).ToPosicao());
            tab.ColocarPeca(new Peao(Cor.Branco, tab) , new posicaoXadrez('e', 2).ToPosicao());
            tab.ColocarPeca(new Peao(Cor.Branco, tab) , new posicaoXadrez('f', 2).ToPosicao());
            tab.ColocarPeca(new Peao(Cor.Branco, tab) , new posicaoXadrez('g', 2).ToPosicao());
            tab.ColocarPeca(new Peao(Cor.Branco, tab) , new posicaoXadrez('h', 2).ToPosicao());

            //torres brancas
            tab.ColocarPeca(new Torre(Cor.Branco, tab) , new posicaoXadrez('a', 1).ToPosicao());
            tab.ColocarPeca(new Torre(Cor.Branco, tab) , new posicaoXadrez('h', 1).ToPosicao());
        }

    }
}