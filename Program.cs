using jogoXadrez.Tabuleiro;
using jogoXadrez.Tela;
using jogoXadrez.Xadrez;

namespace jogoXadrez{
    class Program{
        static void Main(){
            //Posicao p = new Posicao(3, 4); 
            tabuleiro tab = new tabuleiro(8, 8);
            tab.ColocarPeca(new Torre(Cor.Preto, tab) , new Posicao(0, 0));
            tab.ColocarPeca(new Torre(Cor.Preto, tab) , new Posicao(0, 1));
            tab.ColocarPeca(new Rei(Cor.Preto, tab) , new Posicao(1, 2));
            tab.ColocarPeca(new Torre(Cor.Preto, tab) , new Posicao(3, 2));
            tab.ColocarPeca(new Rei(Cor.Preto, tab) , new Posicao(5, 3));
            tab.ColocarPeca(new Torre(Cor.Preto, tab) , new Posicao(2, 3));
            //System.Console.WriteLine(p);
            tela.PrintTab(tab);
            Console.ReadLine();
        }
    }
}