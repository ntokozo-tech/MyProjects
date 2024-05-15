<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Project.Applications" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Bootsrap/bootstrap.min.css" rel="stylesheet" />
    <script src="Bootsrap/bootstrap.bundle.min.js"></script>
    <title>Register</title>
    <style>
        .h1 {
            color: cornflowerblue;
            background-color: grey;
            width: 100%;
        }
        .my-5
        {
            max-width:600px;
            padding-top:0px;
            
        }
        body {
            background: url(https://www.planetware.com/wpimages/2020/02/france-in-pictures-beautiful-places-to-photograph-eiffel-tower.jpg);
            color: #00cec9;
            background-repeat: no-repeat;
            background-size: cover;
         }
      
    </style>
</head>
<body>
    <form runat="server">

        <nav aria-label="breadcrumb">
          <ol class="breadcrumb">
            <li class="breadcrumb-item"><a href="#">Profile</a></li>
            <li class="breadcrumb-item active">Registration</></li>
          </ol>
        </nav>
        <div class="container-fluid my-5" <%--style="margin-left:500px;margin-right:300px;" --%>>
            <div class="card mx-auto">
                <div class="form-heading text-center" >
                    <h1 class="p-3">Registration Form</h1>

                </div>
                <form class="form">
                    <div class="card-body px-5 mt-4">
                        <div class="col-md-8">
                            <div class="mb-3">
                                <asp:Label ID="lblName" runat="server" Text="First Name"></asp:Label>
                               <input id="name" placeholder="Enter Your name" type="name" class="form-control" runat="server" />
                                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter Name" Display="Dynamic" ControlToValidate="txtName" SetFocusOnError="True" ForeColor="Red"></asp:RequiredFieldValidator>--%>
                                </div>
                                <div class="mb-3">
                                    <asp:Label ID="lblSur" runat="server" Text="Surname"></asp:Label>
                                   <input id="surname" placeholder="Enter Your surname" type="name" class="form-control" runat="server" />
                                  <%--  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ForeColor="#FF3300" runat="server" ErrorMessage="Enter Surname" Display="Dynamic" SetFocusOnError="True" ControlToValidate="txtSurname"></asp:RequiredFieldValidator>--%>

                                </div>
                                <div class="mb-3">
                                    <asp:Label ID="lblID" runat="server" Text="ID/Passport number"></asp:Label>
                                    <input id="IDnumber" placeholder="Enter Your Id number" type="IDnumber" class="form-control" runat="server" />
                                    <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator3" ForeColor="#FF3300" runat="server" ErrorMessage="Enter A valid ID/Passport number" ControlToValidate="txtID"></asp:RequiredFieldValidator>--%>
                                </div>
                            
                                <div class="mb-3">
                                    <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
                                    <input id="Email" placeholder="Enter Your Email" type="email" class="form-control" runat="server" />
                                    <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator4" ForeColor="#FF3300" type="email" runat="server" ErrorMessage="Enter A Valid Email" SetFocusOnError="True" Display="Dynamic" ControlToValidate="txtEmail"></asp:RequiredFieldValidator>--%>

                                </div>
                                <div class="mb-3">
                                    <asp:Label ID="lblNumber" runat="server" Text="Phone Number"></asp:Label>
                                     <input id="phone" placeholder="Enter Your Email" type="phone" class="form-control" runat="server" />
                                    <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator5"  ForeColor="#FF3300" runat="server" ErrorMessage="Select Gender" Display="Dynamic" ControlToValidate="txtNumber" SetFocusOnError="True"></asp:RequiredFieldValidator>--%>

                                </div>

                                <div class="mb-3">

                                    <asp:Label ID="lblSelect" runat="server" Text="Gender"></asp:Label>
                                    <select id="gender" name="gender" class="form-select mb-3" style="max-width: 300px" runat="server">
                                        <option value="Choose">--Select--
                                        </option>
                                        <option value="Male">Male
                                        </option>
                                        <option value="Female">Female
                                        </option>
                                    </select>
                                    <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ForeColor="#FF3300" ErrorMessage="Select Gender" Display="Dynamic" ControlToValidate="gender" SetFocusOnError="True"></asp:RequiredFieldValidator>--%>

                                </div>

                                

                                <div class="mb-3">
                                    <asp:Label ID="lblInstitution" runat="server" Text="Institution"></asp:Label>

                                    <select id="institution" name="institution" class="form-select mb-3" style="max-width: 300px" runat="server">
                                        <option value="Select">--Select--
                                        </option>
                                        <option value="University of Johannesburg">University of Johannesburg
                                        </option>
                                        <option value="University of Witwatersrand">University of Witwatersrand
                                        </option>
                                    </select>
                                    <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator8" ForeColor="#FF3300" runat="server" ErrorMessage="Select Institution" ControlToValidate="institution" SetFocusOnError="True"></asp:RequiredFieldValidator>--%>
                                </div>
                                <div class="mb-3">
                                    <label for="course_name" class="form-label">Course</label>
                                    <input id="course" placeholder="Enter Your Course of study" type="course" class="form-control" runat="server" />
                                </div>

                                <div class="mb-3">
                                    <asp:Label ID="Label2" runat="server" Text="Level Of Study"></asp:Label>

                                    <select id="Level" name="yearstudy" class="form-select mb-3" style="max-width: 300px" runat="server">
                                        <option selected="" value="First Year">First Year</option>
                                        <option value="Second Year">Second Year</option>
                                        <option value="Third Year">Third Year</option>
                                        <option value="Fourth Year">Fourth Year</option>
                                        <option value="Honors">Honors</option>
                                        <option value="Masters">Masters</option>
                                        <option value="PhD">PhD</option>
                                    </select>
                                    <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator11" ForeColor="#FF3300" runat="server" ErrorMessage="Select level of study" Display="Dynamic" SetFocusOnError="True" ControlToValidate="Level"></asp:RequiredFieldValidator>--%>
                                </div>

                                <div class="mb-3">
                                    <asp:Label ID="lblFunding" runat="server" Text="Funding"></asp:Label>
                                    <label for="funding" class="form-label">Funding</label>
                                    <select id="funding" name="funding" class="form-select mb-3" style="max-width: 300px" runat="server">
                                        <option selected="">--Select--
                                        </option>
                                        <option value="NSFAS">NSFAS</option>
                                        <option value="Bursary">Bursary</option>
                                        <option value="Cash">Cash</option>
                                    </select>

                                </div>
                                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator9" ForeColor="#FF3300" runat="server" ErrorMessage="Select Funding" Display="Dynamic" ControlToValidate="funding" SetFocusOnError="True"></asp:RequiredFieldValidator>--%>
                                <div class="mb-3">

                                    <asp:Label ID="lblStuNumber" runat="server" Text="Student Number"></asp:Label>
                                    <input id="StudentNumber" placeholder="Enter Your student number" type="phone" class="form-control" runat="server" />
                                    <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator10" ForeColor="#FF3300" runat="server" ErrorMessage="Enter Student Number" Display="Dynamic" ControlToValidate="txtStuNumber" SetFocusOnError="True"></asp:RequiredFieldValidator>--%>
                                </div>

                                <div class="mb-3">

                                    <asp:Label ID="Label1" runat="server" Text="Password"></asp:Label>
                                    <input id="password" placeholder="Create a password" type="password" class="form-control" runat="server" />
                                    <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator10" ForeColor="#FF3300" runat="server" ErrorMessage="Enter Student Number" Display="Dynamic" ControlToValidate="txtStuNumber" SetFocusOnError="True"></asp:RequiredFieldValidator>--%>
                                </div>
                                <div class="mb-3">

                                    <asp:Label ID="Label3" runat="server" Text="Confirm"></asp:Label>
                                    <input id="confirm" placeholder="confirm password" type="password" class="form-control" runat="server" />
                                    <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator10" ForeColor="#FF3300" runat="server" ErrorMessage="Enter Student Number" Display="Dynamic" ControlToValidate="txtStuNumber" SetFocusOnError="True"></asp:RequiredFieldValidator>--%>
                                </div>


                            </div>
                           
                </form>
             
               <%-- <form id="btnButton">
                    
                        <%--<asp:Button ID="Login" runat="server" Text="Cancel" onClick ="btnCancel"/>--%>
                        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="btnSubmit"/>
              
                   
                <%--</form>--%>

                

                </div>
            </div>
    </form>

</body>
</html>
