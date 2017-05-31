using ProjetoProva.Controller;
using ProjetoProva.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoProva.Views.Consultas
{
    public partial class Lista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ConsultaController ctrl = new ConsultaController();
            List<Consulta> lista = ctrl.Listar();

            gv_Consultas.DataSource = lista.OrderBy(c => c.Nome);
            gv_Consultas.DataBind();

            gv_ConsultasInativas.DataSource = ctrl.ListarInativos();
            gv_ConsultasInativas.DataBind();
        }

        protected void btn_salvar_Click(object sender, EventArgs e)
        {
            Consulta con = new Consulta();
            con.Nome = txt_nome.Text;
            con.Preco = decimal.Parse(txt_preco.Text);
            
        }
    }
}