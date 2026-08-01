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
                for (int j = 0; j < tab.Colunas; j++)
                {
                    //imprime a peça na linha i e coluna j
                    if (tab.p(i, j) == null)
                    {
                        System.Console.Write(" ");
                    }
                    else
                    {
                        System.Console.Write(tab.p(i, j) + "-");    
                    }
                    
                }
                System.Console.WriteLine();
            }
        }
    }
}
