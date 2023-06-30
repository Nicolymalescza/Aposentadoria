using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaRecuperacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_verificar_Click(object sender, EventArgs e)
        {
            Contribuinte con = new Contribuinte();
            con.nome = tx_nome.Text;
            con.cpf = mask_cpf.Text;
          //con.DataNascimento = Convert.ToDateTime(mask_dtnascimento.Text);
            con.sexo = cb_sexo.Text;
            con.profissao = cb_profissao.Text;
           //con.InicioProfissao = Convert.ToDateTime(mask_inicioProfissao.Text);
            con.DataNascimento = Convert.ToInt32(tx_idade.Text);
            con.InicioProfissao = Convert.ToInt32(tx_tempoCont.Text);
            //MessageBox.Show(Convert.ToString(con.Calcular()));
           // lb_result.Text = $"{Convert.ToString(con.Calcular())}";
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            tx_nome.Text = string.Empty;
            tx_idade.Text = string.Empty;
            mask_cpf.Text = string.Empty;
            cb_sexo.Text = string.Empty;
            cb_profissao.Text = string.Empty;
            tx_tempoCont.Text = string.Empty;
            lb_result.Text = string.Empty;
        }
    }
}
