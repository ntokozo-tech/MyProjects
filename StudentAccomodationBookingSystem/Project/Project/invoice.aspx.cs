using Project.ServiceReference2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class invoice : System.Web.UI.Page
    {
        Service1Client sr = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            string roomType = Session["track"].ToString();
            double priceAfterDiscount = Convert.ToDouble(Session["Price"]);
            string discount = Session["Discount"].ToString();
            string display = "";
            double price = Convert.ToDouble(Session["Price"]);

            switch (roomType)
            {
                case "Single Room":
                    
                    
                    break;
                case "Two Sharing":
                    display = "";
                    display += "<div class='row'>";
                    display += "<div class='col-md-6 site-animate'>";
                    display += "<div class='media menu-item'>";
                    display += "<div class='media-body'>";
                    display += "<p>Two sharing = R 100 </p>";
                    display += "<p>Discount =:" + discount + "</p>";
                    display += "<p>Amount due  =:R " + priceAfterDiscount + "</p>";
                    display += "</div>";
                    display += "</div>";
                    display += "</div>";
                    display += "</div>";
                    break;
                case "Three Sharing":
                    display = "";
                    display += "<div class='row'>";
                    display += "<div class='col-md-6 site-animate'>";
                    display += "<div class='media menu-item'>";
                    display += "<div class='media-body'>";
                    display += "<p>Three sharing = R 90 </p>";
                    display += "<p>Discount =:" + discount + "</p>";
                    display += "<p>Amount due  =:R " + priceAfterDiscount + "</p>";
                    display += "</div>";
                    display += "</div>";
                    display += "</div>";
                    display += "</div>";
                    break;
                case "Four Sharing":
                    display = "";
                    display += "<div class='row'>";
                    display += "<div class='col-md-6 site-animate'>";
                    display += "<div class='media menu-item'>";
                    display += "<div class='media-body'>";
                    display += "<p> Four sharing  = R 80 </p>";
                    display += "<p>Discount =:" + discount + "</p>";
                    display += "<p>Amount due  =:R " + priceAfterDiscount + "</p>";
                    display += "</div>";
                    display += "</div>";
                    display += "</div>";
                    display += "</div>";
                    break;
                case "Five Sharing":
                    display = "";
                    display += "<div class='row'>";
                    display += "<div class='col-md-6 site-animate'>";
                    display += "<div class='media menu-item'>";
                    display += "<div class='media-body'>";
                    display += "<p>Five Sharing = R 50 </p>";
                    display += "<p>Discount =:" + discount + "</p>";
                    display += "<p>Amount due  =:R " + priceAfterDiscount + "</p>";
                    display += "</div>";
                    display += "</div>";
                    display += "</div>";
                    display += "</div>";
                    break;
            }
            report.InnerHtml = display;
        }
        protected void btnSubmit(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["LoggedInUser"]);
            string name = sr.retriveUserName(id);
            string roomType = Session["track"].ToString();
            string discount = Session["Discount"].ToString();
            double fee = Convert.ToDouble(Session["Price"]);
            string status = "Not paid";

            bool existance = sr.checkId(id);
            if(existance != true)
            {
                bool apply = sr.sendApplication(id, name, roomType, discount, fee.ToString(), status);

                if (apply == true)
                {
                    Response.Redirect("Confirmation.aspx");
                }
            }
            else
            {
                Response.Write("<script LANGUAGE='JavaScript' >alert('Application Already exists....')</script>");
            }


           
           

        }
        protected void btnCancel(object sender, EventArgs e)
        {
            Response.Redirect("Apply.aspx");
        }
    }
}