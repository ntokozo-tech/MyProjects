using Project.ServiceReference2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class Login : System.Web.UI.Page
    {
        Service1Client sr = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["LoggedInUser"] = null;
        }
        protected void btnLogin(object sender, EventArgs e)
        {
            
            int login = sr.Login(Email.Value, Pass.Value);

            if (login != 0)
            {
                Session["LoggedInUser"] = login;
                Response.Redirect("Home.aspx");
            }
        }
    }
}