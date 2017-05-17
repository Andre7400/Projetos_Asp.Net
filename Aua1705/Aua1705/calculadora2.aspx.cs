using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aua1705
{
    public partial class calculadora2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            double n1Session = Convert.ToDouble(Session["n1"]);
            double n2Session = Convert.ToDouble(Session["n2"]);
            txtn1.Text = n1Session.ToString();
            txtn2.Text = n2Session.ToString();
        }
        
    }
}