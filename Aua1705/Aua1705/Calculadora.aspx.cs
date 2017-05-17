using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aua1705
{
    
    public partial class Calculadora : System.Web.UI.Page
    {
        // get set
        double n1 { get; set; }
        double n2 { get; set; }
        double soma { get; set; }
    
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                n1 = 0;
                n2 = 0;
               
            }
        }

        protected void btnSomar_Click(object sender, EventArgs e)
        {
             n1 = float.Parse(txtCampo1.Text);
             n2 = float.Parse(txtCampo2.Text);
        
            soma = n1 + n2;
            txtResultadoSoma.Text = soma.ToString();
        }

        protected void btnIgual_Click(object sender, EventArgs e)
        {
            Session.Add("Num1", n1 );
            Session.Add("Num2", n2);
            Response.Redirect("~/Calculadora2.aspx");
        }
    }
}