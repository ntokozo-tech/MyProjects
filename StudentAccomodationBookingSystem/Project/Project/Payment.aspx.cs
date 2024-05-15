using Project.ServiceReference2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class Payment : System.Web.UI.Page
    {
        Service1Client sr = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnConfirm(object sender, EventArgs e)
        {
            //sr.u
            int id = Convert.ToInt32(Session["LoggedInUser"]);
            double owing = Convert.ToDouble(Session["Price"]);
            double amount = Convert.ToDouble(Amount.Value);
            sr.updatePayment(id, amount, owing);

            string name = sr.retriveUserName(id);
            string discount = Session["Discount"].ToString();
            string roomtype = Session["track"].ToString();
            bool RecordInvoice = sr.RecordInvoice(id, name, discount,roomtype,amount.ToString());
        }
        
    }
}