namespace Exercício_16
{
    public class Produto
    {
        public string Nome { get; set; }
        public int Tamanho { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Qestoque { get; set; }

        //0
        public Produto (){

        }

        //1
        public Produto(string _nome){
            this.Nome = _nome;
        }

        //3
        public Produto(string _nome, string _marca, string _modelo){
            this.Nome = _nome;
            this.Marca = _marca;
            this.Modelo = _modelo;
        }

        //3
        public Produto(string _nome, string _marca, string _modelo, int _tamanho, int _qestoque){
            this.Nome = _nome;
            this.Marca = _marca;
            this.Modelo = _modelo;
            this.Tamanho = _tamanho;
            this.Qestoque = _qestoque;
        }


    }
}