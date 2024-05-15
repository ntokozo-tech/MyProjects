<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="invoice.aspx.cs" Inherits="Project.invoice" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>invoice</title>
    <link rel="stylesheet" href="nicepage.css" media="screen"/>
    <link rel="stylesheet" href="Home.css" media="screen"/>
    <script class="u-script" type="text/javascript" src="jquery.js" defer=""></script>
    <script class="u-script" type="text/javascript" src="nicepage.js" defer=""></script>
    <meta name="generator" content="Nicepage 4.19.3, nicepage.com"/>
    <link id="u_theme_google_font" rel="stylesheet" href="https://fonts.googleapis.com/css?family=Roboto:100,100i,300,300i,400,400i,500,500i,700,700i,900,900i|Open+Sans:300,300i,400,400i,500,500i,600,600i,700,700i,800,800i"/>
    <link id="u_page_google_font" rel="stylesheet" href="https://fonts.googleapis.com/css?family=Oswald:200,300,400,500,600,700"/>
    
    <meta name="theme-color" content="#478ac9"/>
    <meta property="og:title" content="Application"/>
    <meta property="og:type" content="website"/>
</head>
<body>
    <form id="form1" runat="server">
       <h1>Application invoice</h1>
        <div class="tab-content text-left">
            <h3>Application infomartion</h3>
            <div class="tab-pane fade show active" id="report" runat="server" role="tabpanel" aria-labelledby="pills-breakfast-tab">
                <div class="row">
                    <div class="col-md-6 site-animate">
                        <div class="media menu-item">
                            <div class="media-body">
                                <p>Single room : R 150</p>
                                <p>Funding     : Cash 10%</p>
                                <p>Amount due  : R 140 </p>
                                
                            </div>
                        </div>
                    </div>
                </div>
            </div>
         </div>

        <div>
            <h3>Bank details</h3>
            <p>Account holder : Nestpik Accomodations</p>
            <p>Bank Name      : Capitec Bank</p>
            <p>Account Number : 1234567890231</p>
            <p>Brach code     : 47000</p>
        </div>
        
        <p style="color:red;">Make a payment to the above account details within 30 days </p>
        <p style="color:red;">Make make your student number a reference when making the payment </p>

        <asp:Button ID="log" runat="server" Text="confirm and Submit" onClick="btnSubmit"/>
        <asp:Button ID="Button1" runat="server" Text="Cancel Application" onClick="btnCancel"/>
        <form id ="status">
            <asp:TextBox ID="TextBox1" runat="server" placeholder =""></asp:TextBox>
        </form> 
        
    </form>
</body>
</html>
