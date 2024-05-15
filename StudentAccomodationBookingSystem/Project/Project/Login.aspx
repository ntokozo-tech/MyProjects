<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Project.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link href="Bootsrap/bootstrap.min.css" rel="stylesheet" />
    <link href="fontawesome-free-6.2.0-web/css/all.css" rel="stylesheet" />
 
</head>
<body>

    <section class="vh-100" style="background-color: #eee;">
        <div class="container h-100">
            <div class="row d-flex justify-content-center align-items-center h-100">
                <div class="col-lg-12 col-xl-11">
                    <div class="card text-black" style="border-radius: 25px;">
                        <div class="card-body p-md-5">
                            <div class="row justify-content-center">
                                <div class="col-md-10 col-lg-6 col-xl-5 order-2 order-lg-1">

                                    <form id="form1" runat="server">

                                        <p class="text-center h1 fw-bold mb-5 mx-1 mx-md-4 mt-4">
                                            Log In
                                        </p>


                                        <div class="d-flex flex-row align-items-center mb-4">
                                            <i class="fas fa-envelope fa-lg me-3 fa-fw"></i>
                                            <div class="form-outline flex-fill mb-0">
                                                <input id="Email" placeholder="Enter Your Email" type="name" class="form-control" runat="server" />

                                                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="Email" ErrorMessage="Enter Your Email" ForeColor="Red" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>--%>

                                            </div>
                                        </div>

                                        <div class="d-flex flex-row align-items-center mb-4">
                                            <i class="fas fa-lock fa-lg me-3 fa-fw"></i>
                                            <div class="form-outline flex-fill mb-0">

                                                <input id="Pass" placeholder="Enter Your Password" type="password" class="form-control" runat="server" />

                                                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtPass" ErrorMessage="Create Password" ForeColor="Red" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>--%>

                                            </div>
                                        </div>
                                        <span>I am signing in as a:</span>
                                        <div class="btn-group">
                                            <input type="radio" class="btn-check" name="options" id="option1" autocomplete="off" checked />
                                            <label class="btn btn-primary" for="option1">Admin</label>

                                            <input type="radio" class="btn-check" name="options" id="option2" autocomplete="off" />
                                            <label class="btn btn-primary" for="option2">Applicant</label>

                                           
                                        </div>


                                        <br />
                                        <br />

                                        <asp:Button ID="log" runat="server" Text="Login" onClick="btnLogin"/>
                                        
                                        <div class="d-flex justify-content-center mx-4 mb-3 mb-lg-4">
                                        </div>

                                    </form>

                                </div>
                                <div class="col-md-10 col-lg-6 col-xl-7 d-flex align-items-center order-1 order-lg-2">

                                    <img src="https://mdbcdn.b-cdn.net/img/Photos/new-templates/bootstrap-registration/draw1.webp"
                                        class="img-fluid" alt="Sample image">
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</body>
<script src="Bootsrap/bootstrap.bundle.min.js"></script>
</html>
