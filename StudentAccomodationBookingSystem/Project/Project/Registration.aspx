<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Project.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
    <link href="Bootsrap/bootstrap.min.css" rel="stylesheet" />
    <link href="fontawesome-free-6.2.0-web/css/all.css" rel="stylesheet" />
    <link href="Styles/login.css" rel="stylesheet" />
    <script src="SweetAlert/sweetalert2.all.min.js"></script>
</head>
<body>
    <form id="Outerform" runat="server">
        <header class="navigation fixed-top">

            <nav class="navbar navbar-expand-lg navbar-light bg-white shadow-sm">
                <div class="container mh-50 overflow-auto">
                    <a class="navbar-brand" href="index">
                        <img src="img/Studentinn.png" alt="logo" width="60px" height="60px">
                    </a>
                    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                        <span class="navbar-toggler-icon"></span>
                    </button>
                    <div class="collapse navbar-collapse" id="navbarNav">
                        <ul class="navbar-nav ms-auto">

                            <li class="nav-item">
                                <a class="nav-link" href="index">Home</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="about">About</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="recruiter">Vacancies</a>
                            </li>

                            <li class="nav-item">
                                <a class="nav-link" href="./contact-us/contact-us">Contact Us</a>
                            </li>

                        
                                <asp:Button ID="Button1" runat="server" Text="Register" class="btn btn-primary btn-lg" OnClick="btnReg_Click" />

                      
                        </ul>
                    </div>
                </div>
            </nav>
        </header>

        <section class="vh-100" style="background-color: #eee;">
            <div class="container h-100">
                <div class="row d-flex justify-content-center align-items-center h-100">
                    <div class="col-lg-12 col-xl-11">
                        <div class="card text-black" style="border-radius: 25px;">
                            <div class="card-body p-md-5">
                                <div class="row justify-content-center">
                                    <div class="col-md-10 col-lg-6 col-xl-5 order-2 order-lg-1">

                                        <form id="form1>
                                            <div class="MyForm">

                                                <p class="text-center h1 fw-bold mb-5 mx-1 mx-md-4 mt-4">
                                                    Sign up
                                                </p>

                                                <div class="d-flex flex-row align-items-center mb-4">
                                                    <i class="fas fa-user fa-lg me-3 fa-fw"></i>
                                                    <div class="form-outline flex-fill mb-0">
                                                        <input id="name" placeholder="Enter your name" type="name" class="form-control" runat="server" />

                                                        <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"  ErrorMessage="Enter Your Name" ForeColor="Red" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>--%>

                                                    </div>
                                                </div>

                                                <div class="d-flex flex-row align-items-center mb-4">
                                                    <i class="fas fa-envelope fa-lg me-3 fa-fw"></i>
                                                    <div class="form-outline flex-fill mb-0">
                                                        <input id="email" placeholder="Enter email" type="email" class="form-control" runat="server" />

                                                        <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter Your Email" ForeColor="Red" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>--%>

                                                    </div>
                                                </div>
                                                <%--<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="Pass" ControlToValidate="Confirm" ErrorMessage="Password must match" ForeColor="Red" Display="Dynamic" SetFocusOnError="True"></asp:CompareValidator>--%>
                                                <div class="d-flex flex-row align-items-center mb-4">
                                                    <i class="fas fa-lock fa-lg me-3 fa-fw"></i>
                                                    <div class="form-outline flex-fill mb-0">

                                                        <input id="Pass" placeholder="Create A Password" type="password" class="form-control" runat="server" />

                                                        <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"  ErrorMessage="Create Password" ForeColor="Red" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>--%>

                                                    </div>
                                                </div>

                                                <div class="d-flex flex-row align-items-center mb-4">
                                                    <i class="fas fa-key fa-lg me-3 fa-fw"></i>
                                                    <div class="form-outline flex-fill mb-0">

                                                        <input id="ConfPassword" placeholder="Create A Password" type="password" class="form-control" runat="server" />
                                                        <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Confirm Password" ForeColor="#FF3300" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>--%>

                                                    </div>
                                                </div>

                                                <div class="form-check d-flex justify-content-center mb-5">
                                                    <input class="form-check-input me-2" type="checkbox" value="" id="form2Example3c" />
                                                    <label class="form-check-label" for="form2Example3">
                                                        I agree all statements in <a href="#!">Terms of service</a>
                                                    </label>
                                                </div>
                                                <span>I am Registering as a:</span>
                                                <div class="btn-group" runat="server" id="Selector">
                                                    <input type="radio" class="btn-check" value="1" autocomplete="off" checked />
                                                    <label class="btn btn-primary" for="1">Employee</label>

                                                    <input type="radio" class="btn-check" name="options" value="2" autocomplete="off" />
                                                    <label class="btn btn-primary" for="2">Customer</label>
                                                </div>

                                                <br />
                                                <br />
                                                <div class="btn-container">
                                                    <asp:Button ID="btnReg" runat="server" Text="Register" class="btn btn-primary btn-lg" OnClick="btnReg_Click" />

                                                </div>

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
    </form>
</body>
<script src="Bootsrap/bootstrap.bundle.min.js"></script>

<script src="SweetAlert/sweetalert2.all.min.js"></script>
</html>
