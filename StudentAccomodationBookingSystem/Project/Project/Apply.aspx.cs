using Project.ServiceReference2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class Apply : System.Web.UI.Page
    {
        Service1Client sr = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
          
            Session["track"] = null;

            Session["Discount"] = null;
            
            Session["Price"] = null;

            Session["PriceAfterDiscount"] = null;

        }
        protected void btnApplySingle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["LoggedInUser"]);
            double price = sr.SingleRoomPrice(id);

            Session["Price"] = price;

           
            string funding = sr.RetrieveFunding(id).Trim();
            if(funding.Equals("NSFAS"))
            {
                Session["Discount"] = "100% Discount";
             
            }
            else if(funding.Equals("Bursary"))
            {
                Session["Discount"] = "0% Discount";
               
            }
            else if(funding.Equals("Cash"))
            {
                Session["Discount"] = "10% Discount";
                
            }
            Session["track"] = "Single Room";


            Response.Redirect("invoice.aspx");

        }

        protected void btnApplyTwo_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["LoggedInUser"]);
            double price = sr.TwosRoomPrice(id);

            Session["Price"] = price;
            
            string funding = sr.RetrieveFunding(id).Trim();
            if (funding.Equals("NSFAS"))
            {
                Session["Discount"] = "100% Discount";
                

            }
            else if (funding.Equals("Bursary"))
            {
                Session["Discount"] = "0% Discount";
              
            }
            else if (funding.Equals("Cash"))
            {
                Session["Discount"] = "10% Discount";
              
            }

            Session["track"] = "Two Sharing";
            Response.Redirect("invoice.aspx");
        }

        protected void btnApplyThree_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["LoggedInUser"]);
            double price = sr.ThreeRoomPrice(id);

            Session["Price"] = price;
            string funding = sr.RetrieveFunding(id).Trim();

           
            if (funding.Equals("NSFAS"))
            {
                Session["Discount"] = "100% Discount";
               
            }
            else if (funding.Equals("Bursary"))
            {
                Session["Discount"] = "0% Discount";
               
            }
            else if (funding.Equals("Cash"))
            {
                Session["Discount"] = "10% Discount";
               
            }
            Session["track"] = "Three Sharing";
            Response.Redirect("invoice.aspx");
        }
        protected void btnApplyFour_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["LoggedInUser"]);
            double price = sr.FourRoomPrice(id);

            Session["Price"] = price;
            string funding = sr.RetrieveFunding(id).Trim();
           
            if (funding.Equals("NSFAS"))
            {
                Session["Discount"] = "100% Discount";
                
            }
            else if (funding.Equals("Bursary"))
            {
                Session["Discount"] = "0% Discount";
               
            }
            else if (funding.Equals("Cash"))
            {
                Session["Discount"] = "10% Discount";
               
            }
            Session["track"] = "Four Sharing";

            Response.Redirect("invoice.aspx");
        }
        protected void btnApplyFive_Click(object sender, EventArgs e)
        {
           
            int id = Convert.ToInt32(Session["LoggedInUser"]);
            double price = sr.FiveRoomPrice(id);
            Session["Price"] = price;
            string funding = sr.RetrieveFunding(id).Trim();
            
            if (funding.Equals("NSFAS"))
            {
                Session["Discount"] = "100% Discount";
                
            }
            else if (funding.Equals("Bursary"))
            {
                Session["Discount"] = "0% Discount";
               
            }
            else if (funding.Equals("Cash"))
            {
                Session["Discount"] = "10% Discount";
                
            }
            Session["track"] = "Five Sharing";

            Response.Redirect("invoice.aspx");
        }

        //protected void dfghjkl(object sender, EventArgs e)
        //{
        //    Response.Redirect("Login.aspx");
        //}

    }
}