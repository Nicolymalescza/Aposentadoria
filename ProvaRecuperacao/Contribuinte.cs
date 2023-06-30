using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaRecuperacao
{
    internal class Contribuinte
    {

        public string nome;
        public string cpf;
        public DateTime DataNascimento;
        public string sexo;
        public string profissao;
        public DateTime InicioProfissao;



        public double Calculo()
        {
            DateTime nascimento = DataNascimento;
            DateTime date = DateTime.Now;
            DateTime
           
           
        }





        private string GetNome()
        {
            return nome;
        }
        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        private string GetCpf()
        {
            return cpf;
        }
        public void SetCpf(string cpf)
        {
            this.cpf = cpf;
        }

        private DateTime GetDtNAscimento()
        {
            return DataNascimento;
        }
        public void SetDtNascimento(DateTime DataNascimento)
        {
            this.DataNascimento = DataNascimento;
        }

        private string GetSexo()
        {
            return sexo;
        }
        public void SetSexo(string sexo)
        {
            this.sexo = sexo;
        }

        private string GetProfissao()
        {
            return profissao;
        }
        public void SetProfissao(string profissao)
        {
            this.profissao = profissao;
        }

        private DateTime GetInicioProfissao()
        {
            return InicioProfissao;
        }
        public void SetInicioProfissao(DateTime InicioProfissao)
        {
            this.InicioProfissao = InicioProfissao;
        }





    }
}
