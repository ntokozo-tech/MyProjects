using Project.ServiceReference2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class Main : System.Web.UI.Page
    {
        Service1Client sr = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["LoggedInUser"] = null;
        }
        //btnLogin
        protected void btnLogin(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
        protected void btnRegisterUser(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}