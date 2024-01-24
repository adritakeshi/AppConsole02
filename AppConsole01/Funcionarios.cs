using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsole01
{
    public class Funcionarios: Pessoas, IFuncionario
    {
        public float salario;
        public DateTime dataEntrada;
        public List<string> listaFunc;

        public Funcionarios(long cpf, string nome, DateTime data, string cordocabelo) : base(cpf, nome, data, cordocabelo)
        {
            this.CPF = cpf;
            this.Nome = nome;
            this.dataNasc = data;
            this.corDoCabelo = cordocabelo;
        }

        public void Altera(int Id, Pessoas pe, float salario)
        {
            throw new NotImplementedException();
        }

        public override void atualizaSalario(float salario)
        {
            this.salario = salario;
        }

        public void Cadastra(Pessoas pes, float salario, DateTime dataEnt)
        {
            listaFunc.Add(pes.Nome);
        }

        public void Consulta(int Id)
        {
            throw new NotImplementedException();
        }

        public void Contrata(float salario, DateTime dataent)
        {
            this.salario = salario;
            this.dataEntrada = dataent;
        }

        public void Exclusao(int Id)
        {
            listaFunc.Remove(Id.ToString());
        }
    }
}
