using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsole01
{
    public class Pessoas
    {
        protected long CPF;
        public string Nome;
        public DateTime dataNasc;
        public string corDoCabelo;
        public string nomefilho1;
        public string nomefilho2;

        public Pessoas(long cpf, string nome, DateTime data, string cordocabelo)
        {
            this.CPF = cpf;
            this.Nome = nome;
            this.dataNasc = data;
            this.corDoCabelo = cordocabelo;
        }

        public int Soma(int n1, int n2)
        {
            return n1 + n2;
        }

        public int Soma(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }

        public void darNomeAoFilho(string NomeFilho)
        {
            this.nomefilho1 = NomeFilho;
        }

        public void darNomeAoFilho(string NomeFilho, string NomeFilho2)
        {
            this.nomefilho1 = NomeFilho;
            this.nomefilho2 = NomeFilho2;
        }

        public virtual void atualizaSalario(float salario)
        {

        }

        public float CalcularIdade()
        {
            float idade = (((DateTime.Today - this.dataNasc).Days) / 365);
            return idade;
        }

        public void MudaACorDoCabelo(string corEmRGB)
        {
            this.corDoCabelo = corEmRGB;
        }

    }
}
