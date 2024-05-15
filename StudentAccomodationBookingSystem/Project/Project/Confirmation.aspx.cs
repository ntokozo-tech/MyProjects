using Project.ServiceReference2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class Confirmation : System.Web.UI.Page
    {
        Service1Client sr = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnPayment(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["LoggedInUser"]);
            string funding = sr.RetrieveFunding(id);
            if(funding.Equals("Nsfas") || funding.Equals("Bursary"))
            {
                Response.Redirect("Payment.aspx");
            }
            else
            {
                Response.Write("<script LANGUAGE='JavaScript' >alert('Application Successfully sent......You do not owe us anything since you are an Nsfas student')</script>");
            }
            

        }
        protected void btnDone(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}