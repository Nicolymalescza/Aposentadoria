using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaRecuperacao
{
    internal class Contribuinte
    {
        public string nome;
        public string cpf;      
        public string sexo;
        public string profissao;
        public int DataNascimento;
        public int InicioProfissao;
        //public DateTime DataNascimento;
        //public DateTime InicioProfissao;


        //public double Calculo()
        //{
        /*/ DateTime nascimento = DataNascimento;
         DateTime date = DateTime.Now;
         DateTime*/ //TENTAVIVA DE USAR DateTime pra calculo da idade. 
                    //Não consegui e usei a idade e os anos de contribuição direto 
                    // }

        public /*double*/ void Calcular()
        {
            double conta;
            double result;

            if (profissao == "Professor")
            {
                if (sexo == "Masculino")
                {
                    conta = DataNascimento + InicioProfissao;
                    if (conta <= 95)
                    {
                        result = 95 - conta;
                        //return result;
                        MessageBox.Show($"Faltam {result} pontos para você poder se aposentar");
                    }
                    else if (conta >= 95)
                    {
                        result = conta - 95;
                        //return result;
                        MessageBox.Show($"Faltam {result} pontos para você poder se aposentar");
                    }
                }
                else if (profissao == "Feminino")
                {
                    conta = DataNascimento + InicioProfissao;
                    if (conta <= 85)
                    {
                        result = 85 - conta;
                        //return result;
                        MessageBox.Show($"Faltam {result} pontos para você poder se aposentar");
                    }
                    else if (conta >= 85)
                    {
                        result = conta - 85;
                        //return result;
                        MessageBox.Show($"Faltam {result} pontos para você poder se aposentar");
                    }
                }
            }
            else if (profissao == "Agentes de Segurança")
            {
                if (sexo == "Masculino")
                {
                    conta = DataNascimento + InicioProfissao;
                    if (conta <= 95)
                    {
                        result = 95 - conta;
                        //return result;
                        MessageBox.Show($"Faltam {result} pontos para você poder se aposentar");
                    }
                    else if (conta >= 95)
                    {
                        result = conta - 95;
                        //return result;
                        MessageBox.Show($"Faltam {result} pontos para você poder se aposentar");
                    }
                }
                else if (sexo == "Feminino")
                {
                    conta = DataNascimento + InicioProfissao;
                    if (conta <= 85)
                    {
                        result = 85 - conta;
                        //return result;
                        MessageBox.Show($"Faltam {result} pontos para você poder se aposentar");
                    }
                    else if (conta >= 85)
                    {
                        result = conta - 85;
                       // return result;
                        MessageBox.Show($"Faltam {result} pontos para você poder se aposentar");
                    }
                }
            }
            else if (profissao == "Saúde")
            {
                if (sexo == "Masculino")
                {
                    conta = DataNascimento + InicioProfissao;
                    if (conta <= 105)
                    {
                        result = 105 - conta;
                       // return result;
                        MessageBox.Show($"Faltam {result} pontos para você poder se aposentar");
                    }
                    else if (conta >= 105)
                    {
                        result = conta - 105;
                        //return result;
                        MessageBox.Show($"Faltam {result} pontos para você poder se aposentar");
                    }
                }
                else if (sexo == "Feminino")
                {
                    conta = DataNascimento + InicioProfissao;
                    if (conta <= 95)
                    {
                        result = 95 - conta;
                        //return result;
                        MessageBox.Show($"Faltam {result} pontos para você poder se aposentar");
                    }
                    else if (conta >= 95)
                    {
                        result = conta - 95;
                        //return result;
                        MessageBox.Show($"Faltam {result} pontos para você poder se aposentar");
                    }
                }
            }
            else if (profissao == "Demais serviços")
            {
                if (sexo == "Masculino")
                {
                    conta = DataNascimento + InicioProfissao;
                    if (conta <= 105)
                    {
                        result = 105 - conta;
                       // return result;
                        MessageBox.Show($"Faltam {result} pontos para você poder se aposentar");
                    }
                    else if (conta >= 105)
                    {
                        result = conta - 105;
                       // return result;
                        MessageBox.Show($"Faltam {result} pontos para você poder se aposentar");
                    }
                }
                else if (sexo == "Feminino")
                {
                    conta = DataNascimento + InicioProfissao;
                    if (conta <= 95)
                    {
                        result = 95 - conta;
                        //return result;
                        MessageBox.Show($"Faltam {result} pontos para você poder se aposentar");
                    }
                    else if (conta >= 95)
                    {
                        result = conta - 95;
                        //return result;
                        MessageBox.Show($"Faltam {result} pontos para você poder se aposentar");
                    }
                }
                //return result;
            }
           
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

        private int GetDataNascimento()
        {
            return DataNascimento;
        }
        public void SetDataNascimento(int DataNascimento)
        {
            this.DataNascimento = DataNascimento;
        }

        private int GetInicioProfissao()
        {
            return DataNascimento;
        }
        public void SetInicioProfissao(int InicioProfissao)
        {
            this.InicioProfissao = InicioProfissao;
        }



        /* private DateTime GetInicioProfissao()
         {
             return InicioProfissao;
         }
         public void SetInicioProfissao(DateTime InicioProfissao)
         {
             this.InicioProfissao = InicioProfissao;
         }*/
        /* private DateTime GetDtNAscimento()
         {
             return DataNascimento;
         }
         public void SetDtNascimento(DateTime DataNascimento)
         {
             this.DataNascimento = DataNascimento;
         }*/
    }
}