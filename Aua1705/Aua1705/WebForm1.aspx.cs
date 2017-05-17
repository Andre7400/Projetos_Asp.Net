using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aua1705
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public int QuantidadeCliques
        {
            get
            {
                return QuantidadeCliques = Convert.ToInt32(ViewState["qtdCliques"]);
            }
            set
            {
                ViewState["qtdCliques"] = value;
            }
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                QuantidadeCliques = 0; 
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            
            QuantidadeCliques++;
            lblQuantidadecliques.Text = QuantidadeCliques.ToString();
            
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            Session.Add("QtdCliquesSession", QuantidadeCliques);
            Response.Redirect("~/WebForms2.aspx");
        }
    }
}