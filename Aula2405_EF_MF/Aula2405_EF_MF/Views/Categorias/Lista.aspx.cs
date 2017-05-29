using Aula2405_EF_MF.Controllers;
using Aula2405_EF_MF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Aula2405_EF_MF.Views.Categorias
{
    public partial class Lista : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //  List<Categoria> categorias = contexto.Categorias.ToList();
            CategoriaController ctrl = new CategoriaController();
            List<Categoria> lista = ctrl.Listar();

            gvCategorias.DataSource = lista.OrderBy(c => c.Nome);
            gvCategorias.DataBind();

            gvCategoriasExcluidas.DataSource = ctrl.ListarInativos();
            gvCategoriasExcluidas.DataBind();

        }

       

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Categoria cat = new Categoria();
            cat.Nome = txtNome.Text;
            cat.Descricao = txtDescricao.Text;
            cat.ativo = true;

            CategoriaController ctrl = new CategoriaController();

            ctrl.Adicionar(cat);
            
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            txtDescricao.Text = string.Empty;
        }

    }
}