namespace Aula23Listas
{
    public class Cartao
    {
        public int Codigo { get; set; }
        public string Titular { get; set; }

        public string Numero { get; set; } 

        public string Bandeira { get; set; }

        public string Vencimento { get; set; }

        public string Cvv { get; set; }
        
        public Cartao(){

        }

        public Cartao(int _Codigo, string _Titular, string _Numero, string _Bandeira, string _Vencimento, string _Cvv){
           this.Codigo = _Codigo;
           this.Titular = _Titular;
           this.Numero = _Numero;
           this.Bandeira = _Bandeira;
           this.Vencimento = _Vencimento;
           this.Cvv = _Cvv;
        }
    }
}