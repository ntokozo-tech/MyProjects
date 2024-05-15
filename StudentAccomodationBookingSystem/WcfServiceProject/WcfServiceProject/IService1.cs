using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceProject
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        bool RegisterStudent(string fname, string sname, string idNo, string email, string phone,
            string gender, string institution, string course, string level, string funding, string sNumber, string password);
        [OperationContract]
        int Login(string email, string password);
     
        [OperationContract]
        string RetrieveFunding(int id);

        [OperationContract]
        double SingleRoomPrice(int id);
        [OperationContract]
        double TwosRoomPrice(int id);
        [OperationContract]
        double ThreeRoomPrice(int id);
        [OperationContract]
        double FourRoomPrice(int id);
        [OperationContract]
        double FiveRoomPrice(int id);
        [OperationContract]
        string retriveUserName(int id);

        [OperationContract]
        int paymentStatus(int id, double amount, double owing);
        [OperationContract]
        void updatePayment(int id, double amount, double owing);
        [OperationContract]
        bool sendApplication(int id, string name, string roomtype, string discount, string fee, string paymentStatus);

        [OperationContract]
        bool checkId(int id);
        [OperationContract]
        bool RecordInvoice(int id, string name, string discount, string roomtype, string amount);

    }
}
