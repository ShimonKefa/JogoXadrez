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
                while (!part.Terminada)
                {
                    Console.Clear();
                    tela.PrintTab(part.tab);

                    System.Console.WriteLine();
                    System.Console.Write("origem: ");
                    Posicao origem = tela.LerPosicaoXadrez().ToPosicao();

                    System.Console.Write("destino: ");
                    Posicao destino = tela.LerPosicaoXadrez().ToPosicao();    

                    part.execMovimento(origem, destino);
                }
            
            }
            catch (tabsException ex)
            {
                System.Console.WriteLine(ex.Message);
            }            
            Console.ReadLine();
        }
    }
}