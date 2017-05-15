using Aula1505.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula1505
{
    public partial class CadastraProjeto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();

        }

        private void LimparCampos()
        {
            TxtNome.Text = String.Empty;
            ChkAtivo.Checked = false;
            txtDescricao.Text = String.Empty;
        }

        protected void BtnSalvar_Click(object sender, EventArgs e)
        {
            Projeto prj = new Projeto();
                prj.Nome = TxtNome.Text;
            prj.Descricao = txtDescricao.Text;
            prj.Ativo = ChkAtivo.Checked;
        }
    }
}