using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceProject
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public bool RegisterStudent(string fname, string sname, string idNo, string email, string phone, string gender, string institution, string course, string level, string fund, string sNumber, string password)
        {
            var newStudent = new StudentUser
            {
                Name = fname,
                Surname = sname,
                IDnumber = idNo,
                Email = email,
                Phone = phone,
                Gender = gender,
                Institution = institution,
                Course = course,
                Level = level,
                funding = fund,
                StudentNumber = sNumber,
                Password = password

            };
            db.StudentUsers.InsertOnSubmit(newStudent);
            try
            {
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                return false;
            }
        }
        public int Login(string email, string password)
        {
            var sysUser = (from u in db.StudentUsers where u.Email.Equals(email) && u.Password.Equals(password) select u).FirstOrDefault();
            if(sysUser != null)
            {
                return sysUser.Id;
            }
            else
            {
                return 0;
            }
        }
       
        public string RetrieveFunding(int id)
        {
            string funding = "";
            var sysUser = (from s in db.StudentUsers where s.Id == id select s).FirstOrDefault();
            funding = sysUser.funding;
            return funding;
        }

        public double SingleRoomPrice(int id)
        {
            /// discounts : cash = 10%, Nsfas = free
            /// 
            double priceAfterDiscount = 0;

            int price = 150;
            string funding = RetrieveFunding(id);
            switch (funding)
            {
                case "NSFAS":
                    priceAfterDiscount = 0;
                    break;
                case "Cash":
                    priceAfterDiscount = (price - (price * 0.1));
                    break;
                default:
                    priceAfterDiscount = price;
                    break;
            }
            return priceAfterDiscount;
        }

       
        public double TwosRoomPrice(int id)
        {
            double priceAfterDiscount = 0;

            int price = 100;
            string funding = RetrieveFunding(id);
            switch (funding)
            {
                case "NSFAS":
                    priceAfterDiscount = 0;
                    break;
                case "Cash":
                    priceAfterDiscount = (price - (price * 0.1));
                    break;
                default:
                    priceAfterDiscount = price;
                    break;
            }
            return priceAfterDiscount;
        }

        public double ThreeRoomPrice(int id)
        {

            double priceAfterDiscount = 0;

            int price = 90;
            string funding = RetrieveFunding(id);
            switch (funding)
            {
                case "NSFAS":
                    priceAfterDiscount = 0;
                    break;
                case "Cash":
                    priceAfterDiscount = (price - (price * 0.1));
                    break;
                default:
                    priceAfterDiscount = price;
                    break;
            }
            return priceAfterDiscount;
        }
        public double FourRoomPrice(int id)
        {
            double priceAfterDiscount = 0;

            int price = 80;
            string funding = RetrieveFunding(id);
            switch (funding)
            {
                case "NSFAS":
                    priceAfterDiscount = 0;
                    break;
                case "Cash":
                    priceAfterDiscount = (price - (price * 0.1));
                    break;
                default:
                    priceAfterDiscount = price;
                    break;
            }
            return priceAfterDiscount;
        }

        public double FiveRoomPrice(int id)
        {
            double priceAfterDiscount = 0;

            int price = 50;
            string funding = RetrieveFunding(id);
            switch (funding)
            {
                case "NSFAS":
                    priceAfterDiscount = 0;
                    break;
                case "Cash":
                    priceAfterDiscount = (price - (price * 0.1));
                    break;
                default:
                    priceAfterDiscount = price;
                    break;
            }
            return priceAfterDiscount;
        }

        public string retriveUserName(int id)
        {
            var sysUser = (from u in db.StudentUsers where u.Id == id select u).FirstOrDefault();
            string name = "";
            if(sysUser != null)
            {
                name = sysUser.Name;
            }

            return name;
        }

        public int paymentStatus(int id, double amount, double owing)
        {
            var sysUser = (from s in db.StudentUsers where s.Id == id select s).FirstOrDefault();
            
            if (sysUser != null)
            {
                if (amount <= owing)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }   
            }
            else
            {
                return 0;
            }   
        }

        public void updatePayment(int id, double amount, double owing)
        {
            var sysUser = (from s in db.Applications where s.Id == id select s).FirstOrDefault();
            if(sysUser != null)
            {
                if(amount <= owing)
                {
                    sysUser.PaymentStatus = "Paid";
                    try
                    {
                        db.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                        ex.GetBaseException();
                    }
                }
            }
        }

        public bool sendApplication(int id, string name, string roomtype, string discount, string fee, string paymentStatus)
        {
            var applicant = new Applicant
            {
                Id = id,
                Name = name,
                Type =roomtype,
                Discount=discount,
                Fee= fee,
                Status = paymentStatus
            };
            db.Applicants.InsertOnSubmit(applicant);
            try
            {
                db.SubmitChanges();
                return true;
            }
            catch(Exception ex)
            {
                ex.GetBaseException();
                return false;
            }
        }

        public bool checkId(int id)
        {
            var d = (from s in db.Applicants where s.Id.Equals(id) select s).FirstOrDefault();
            if(d != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RecordInvoice(int id, string name, string discount, string roomtype, string amount)
        {
            var newInvoice = new InvoicePaid
            {
                Id=id,
                Name= name,
                Disount=discount,
                RoomType=roomtype,
                AmountDue=amount
            };
            db.InvoicePaids.InsertOnSubmit(newInvoice);
            try
            {
                db.SubmitChanges();
                return true;
            }
            catch(Exception ex)
            {
                ex.GetBaseException();
                return false;
            }
        }
    }
}
