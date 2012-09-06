using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspnetweek36
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {

        }

        protected void Page_Init(object sender, EventArgs e)
        {
            Label lbl = new Label();
            lbl.Text = "hello there.";
            pmContainer.Controls.Add(lbl);

            ListItem li = new ListItem();
            li.Text = "hello";
            DropDownList1.Items.Add(li);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Label1.Text = "Postpack";
            }
        }

        
    }
}