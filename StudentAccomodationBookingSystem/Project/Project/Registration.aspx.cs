//using Project.ServiceReference2;
using Project.ServiceReference2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Project

{
    public partial class Registration : System.Web.UI.Page
    {
        Service1Client sr = new Service1Client();
        //Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReg_Click(object sender, EventArgs e)
        {
            //if(Pass.Value == ConfPassword.Value)
            //{
            //    bool register = sr.RegisterStudent(name.Value, email.Value, Pass.Value);

            //    if(register == true)
            //    {
            //        Response.Redirect("Login.aspx");
            //    }

            //}
        }
    }
}
