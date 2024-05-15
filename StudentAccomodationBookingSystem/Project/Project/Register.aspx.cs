using Project.ServiceReference2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class Applications : System.Web.UI.Page
    {
        Service1Client sr = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session[]
        }
    
        protected void btnCancel(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
        protected void btnSubmit(object sender, EventArgs e)
        {
            if(password.Value != null)
            {
                if (password.Value == confirm.Value)
                {
                    bool register = sr.RegisterStudent(name.Value, surname.Value, IDnumber.Value, Email.Value, phone.Value,
                        gender.Value, institution.Value, course.Value, Level.Value, funding.Value, StudentNumber.Value, password.Value);
                    Console.WriteLine(register);
                    Response.Write(register);
                    if (register == true)
                    {
                        //Response.Write("<script LANGUAGE='JavaScript' >alert('Registration Succesful....')</script>");
                        Response.Redirect("Login.aspx");
                    }
                    else
                    {
                        Response.Write("<script LANGUAGE='JavaScript' >alert('Registration Failed, check your inputs....')</script>");
                    }
                }
            }
            
            
        }
    }
}