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
            if(!IsPostBack)
            {
                MedicoController mc = new  MedicoController();
                ddlMedico.DataSource = mc.Listar();
                ddlMedico.DataBind();
            }
        }

        protected void btn_salvar_Click(object sender, EventArgs e)
        {
            Consulta con = new Consulta();
            con.Nome = txt_nome.Text;
            con.Preco = decimal.Parse(txt_preco.Text);
            con.DataConsulta = txt_data.Text;
            con.MedicoId = int.Parse(ddlMedico.SelectedValue);
            con.Ativo = true;

           ConsultaController  contexto = new ConsultaController();
            contexto.Adicionar(con);
  
        }

        protected void btn_buscar_Click(object sender, EventArgs e)
        {
            int idConsulta = int.Parse(txt_IdBuscar.Text);
            ConsultaController cc = new ConsultaController();
            Consulta con = cc.BuscarConsultaPorID(idConsulta);
  
            if (con !=null )
            {

                txt_NomeBuscado.Text = con.Nome;
                txt_PrecoBuscado.Text = con.Preco.ToString();
                txt_DataBuscado.Text = con.DataConsulta;
                ddlMedico.SelectedValue = con.Id.ToString();
            }
        }

        protected void btn_excluir_Click(object sender, EventArgs e)
        {
            Consulta con = new Consulta();
            ConsultaController cc = new ConsultaController();
            txt_NomeBuscado.Text = con.Nome;
            txt_PrecoBuscado.Text = con.Preco.ToString();
            txt_DataBuscado.Text = con.DataConsulta;
            cc.Excluir(con);
        }
    }
}