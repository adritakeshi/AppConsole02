using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsole01
{
    public interface IFuncionario
    {
        public void Cadastra(Pessoas pes, float salario, DateTime dataEnt);
        public void Altera(int Id, Pessoas pe, float salario);
        public void Exclusao(int Id);
        public void Consulta(int Id);

    }
}
