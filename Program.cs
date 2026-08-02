using jogoXadrez.Exceptions;
using jogoXadrez.Tabuleiro;
using jogoXadrez.Tela;
using jogoXadrez.Xadrez;

namespace jogoXadrez{
    class Program{
        static void Main(){
            try
            {
            PartidaXadrez part = new PartidaXadrez();
            tela.PrintTab(part.tab);
            }
            catch (tabsException ex)
            {
                System.Console.WriteLine(ex.Message);
            }            
            Console.ReadLine();
        }
    }
}