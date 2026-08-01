using jogoXadrez.Tabuleiro;
using jogoXadrez.Tela;

namespace jogoXadrez{
    class Program{
        static void Main(){
            //Posicao p = new Posicao(3, 4); 
            tabuleiro tab = new tabuleiro(8, 8);
            //System.Console.WriteLine(p);
            tela.PrintTab(tab);
            Console.ReadLine();
        }
    }
}