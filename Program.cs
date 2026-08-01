using jogoXadrez.Exceptions;
using jogoXadrez.Tabuleiro;
using jogoXadrez.Tela;
using jogoXadrez.Xadrez;

namespace jogoXadrez{
    class Program{
        static void Main(){
            try
            {
            tabuleiro tab = new tabuleiro(8, 8);
            tab.ColocarPeca(new Torre(Cor.Preto, tab) , new Posicao(0, 0));
            tab.ColocarPeca(new Torre(Cor.Preto, tab) , new Posicao(0, 8));
            //System.Console.WriteLine(p);
            tela.PrintTab(tab);
            }
            catch (tabsException ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            //Posicao p = new Posicao(3, 4); 
            
            Console.ReadLine();
        }
    }
}