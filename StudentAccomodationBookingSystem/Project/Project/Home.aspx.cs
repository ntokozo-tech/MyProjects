﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int trigger = Convert.ToInt32(Request.QueryString["out"]);

            if(trigger == -1)
            {
                Session["LoggedInUser"] = null;
            }
            
        }
    }
}