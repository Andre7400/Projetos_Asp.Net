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
            CarregarGrids();

            if (!IsPostBack)
            {
                MedicoController mc = new MedicoController();
                ddlMedico.DataSource = mc.Listar();
                ddlMedico.DataBind();
            }
        }

        private void CarregarGrids()
        {
            ConsultaController ctrl = new ConsultaController();
            MedicoController list = new MedicoController();
            List<Consulta> lista = ctrl.Listar();
            List<Medico> ListaMed = list.Listar();

            gv_Consultas.DataSource = lista.OrderBy(c => c.Nome);
            gv_Consultas.DataBind();

            gv_ConsultasInativas.DataSource = ctrl.ListarInativos();
            gv_ConsultasInativas.DataBind();

            gv_Medicos.DataSource = ListaMed.OrderBy(m => m.Nome);
            gv_Medicos.DataBind();

            gv_MedicosInativos.DataSource = list.ListarInativos();
            gv_MedicosInativos.DataBind();
        }

        protected void btn_salvar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_nome.Text))
            {
                Consulta con = new Consulta();
                con.Nome = txt_nome.Text;
                con.Preco = decimal.Parse(txt_preco.Text);
                con.DataConsulta = txt_data.Text;
                con.MedicoId = int.Parse(ddlMedico.SelectedValue);
                con.Ativo = true;
                ConsultaController contexto = new ConsultaController();
                contexto.Adicionar(con);
                CarregarGrids();
            }

        }

        protected void btn_buscar_Click(object sender, EventArgs e)
        {
            int idConsulta = int.Parse(txt_IdBuscar.Text);
            ConsultaController cc = new ConsultaController();
            Consulta con = cc.BuscarConsultaPorID(idConsulta);

            if (con != null)
            {
                try
                {
                    txt_NomeBuscado.Text = con.Nome;
                    txt_PrecoBuscado.Text = con.Preco.ToString();
                    txt_DataBuscado.Text = con.DataConsulta;
                }
                catch
                {
                    ddlMedico.SelectedValue = con.Id.ToString();
                }
            }
        }

        protected void btn_excluir_Click(object sender, EventArgs e)
        {
            int idConsulta = int.Parse(txt_IdBuscar.Text);
            ConsultaController cc = new ConsultaController();
            Consulta con = cc.BuscarConsultaPorID(idConsulta);
            con.Ativo = false;
            cc.Excluir(con);
            CarregarGrids();

        }

        protected void btn_editar_Click(object sender, EventArgs e)
        {
            int idConsulta = int.Parse(txt_IdBuscar.Text);
            ConsultaController cc = new ConsultaController();
            Consulta con = cc.BuscarConsultaPorID(idConsulta);
            con.Nome = txt_NomeBuscado.Text;
            con.Preco = decimal.Parse(txt_PrecoBuscado.Text);
            con.DataConsulta = txt_DataBuscado.Text;
            con.MedicoId = int.Parse(ddlMedico.SelectedValue);
            con.Ativo = true;
            cc.Editar(con);
            CarregarGrids();
        }
    }
}