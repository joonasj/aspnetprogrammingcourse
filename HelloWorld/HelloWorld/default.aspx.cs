﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorld
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Label1.Text = "Lollero!";
            var time = DateTime.Now.AddDays(7);
            Label1.Text = time.ToLongDateString() + " "+time.ToLongTimeString();
        }
    }
}