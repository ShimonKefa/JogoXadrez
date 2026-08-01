namespace jogoXadrez.Tabuleiro{
    public class Posicao{

        public int Linha { get; set; }
        public int Coluna { get; set; }

        public Posicao(){

        }
        public Posicao(int linha, int coluna) : this(){
            Linha = linha;
            Coluna = coluna;
        }

        public override string ToString(){
            return $"{Linha},{Coluna}";
        }    
    }
}