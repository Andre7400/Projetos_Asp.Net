﻿using Aula2205_EF_DF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula2205_EF_DF.Views.Categoria
{
    public partial class ListaCategorias : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Contesto (referencia para o banco)
            strConnLojaEntities contexto = new strConnLojaEntities();

            grwCategorias.DataSource = contexto.Categorias.ToList();
            grwCategorias.DataBind();
        }
    }
}