using System.Text.Json;
using jogoXadrez.Tabuleiro;

namespace jogoXadrez.Tela
{
    public class tela
    {
        public static void PrintTab(tabuleiro tab)
        {
            for (int i = 0; i < tab.Linhas; i++)
            {
                System.Console.Write(8 - i + " ");
                for (int j = 0; j < tab.Colunas; j++)
                {
                    //imprime a peça na linha i e coluna j
                    if (tab.p(i, j) == null)
                    {
                        System.Console.Write("- ");
                    }
                    else
                    {
                        tela.ImprimirPeca(tab.p(i,j));
                    System.Console.Write(" ");
                    }
                    
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine("  A B C D E F G H");
        }

        public static void ImprimirPeca(Peca peca)
        {
            if(peca.cor == Cor.Branco)
            {
                System.Console.Write(peca);
            }

            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.Write(peca);
                Console.ForegroundColor = aux;                
            }
        }
    }
}
