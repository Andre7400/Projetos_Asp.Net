using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula_1005
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            txt_data.Text = DateTime.Now.ToString(); 
        }

        protected void btn_salvar_Click(object sender, EventArgs e)
        {
            DateTime dataCalendario = inicialCalendario.SelectedDate;
            txt_data.Text = dataCalendario.ToString();
        }
    }
}