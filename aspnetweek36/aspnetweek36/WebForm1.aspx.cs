using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspnetweek36
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtSubmitText.Text != string.Empty)
            {
                Session["userName"] = txtSubmitText.Text;
                Label hello = (Label) Master.FindControl("Label1");
                hello.Text = string.Format("hello {0}", Session["userName"]);
            }
        }
    }
}