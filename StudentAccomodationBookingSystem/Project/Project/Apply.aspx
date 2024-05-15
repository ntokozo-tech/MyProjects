<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Apply.aspx.cs" Inherits="Project.Apply" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <title>Home</title>
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
        <div>
             <a href="https://nicepage.com" class="u-image u-logo u-image-1">
          <img src="images/log.jpg" class="u-logo-image u-logo-image-1">
        </a>
        <nav class="u-menu u-menu-dropdown u-offcanvas u-menu-1">
          <div class="menu-collapse" style="font-size: 1rem; letter-spacing: 0px;">
            <a class="u-button-style u-custom-left-right-menu-spacing u-custom-padding-bottom u-custom-top-bottom-menu-spacing u-nav-link u-text-active-palette-1-base u-text-hover-palette-2-base" href="#">
              <svg class="u-svg-link" viewBox="0 0 24 24"><use xmlns:xlink="http://www.w3.org/1999/xlink" xlink:href="#menu-hamburger"></use></svg>
              <svg class="u-svg-content" version="1.1" id="menu-hamburger" viewBox="0 0 16 16" x="0px" y="0px" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns="http://www.w3.org/2000/svg"><g><rect y="1" width="16" height="2"></rect><rect y="7" width="16" height="2"></rect><rect y="13" width="16" height="2"></rect>
</g></svg>
            </a>
          </div>
          <div class="u-nav-container">
            <ul class="u-nav u-unstyled u-nav-1"><li class="u-nav-item"><a class="u-button-style u-nav-link u-text-active-palette-1-base u-text-hover-palette-2-base" href="Home.aspx" style="padding: 10px 20px;">Home</a>
<%--</li><li class="u-nav-item"><a class="u-button-style u-nav-link u-text-active-palette-1-base u-text-hover-palette-2-base" href="About.html" style="padding: 10px 20px;">About</a>
</li><li class="u-nav-item"><a class="u-button-style u-nav-link u-text-active-palette-1-base u-text-hover-palette-2-base" href="Contact.html" style="padding: 10px 20px;">Contact</a>--%>
</li></ul>
          </div>
          <div class="u-nav-container-collapse">
            <div class="u-black u-container-style u-inner-container-layout u-opacity u-opacity-95 u-sidenav">
              <div class="u-inner-container-layout u-sidenav-overflow">
                <div class="u-menu-close"></div>
                <ul class="u-align-center u-nav u-popupmenu-items u-unstyled u-nav-2"><li class="u-nav-item"><a class="u-button-style u-nav-link" href="Home.aspx">Home</a>
<%--</li><li class="u-nav-item"><a class="u-button-style u-nav-link" href="About.html">About</a>
</li><li class="u-nav-item"><a class="u-button-style u-nav-link" href="Contact.html">Contact</a>--%>
</li></ul>
              </div>
            </div>
            <div class="u-black u-menu-overlay u-opacity u-opacity-70"></div>
          </div>
        </nav>
      </div></header>
    <section class="u-align-center u-clearfix u-grey-10 u-section-1" id="priceSingle" runat="server">
      <div class="u-clearfix u-sheet u-sheet-1">
        <h1 class="u-custom-font u-font-oswald u-text u-text-default u-text-palette-3-base u-text-1">Room application</h1>
        <p class="u-text u-text-2">These are the rooms that are available for book at the moment, we recieve a number of applications every and it takes a lot of resources for us to process those applications. To cover those costs we change an application fee.</p>
        <div class="u-expanded-width u-list u-list-1">
          <div class="u-repeater u-repeater-1">
            <div class="u-container-style u-list-item u-repeater-item u-white u-list-item-1">
              <div class="u-container-layout u-similar-container u-valign-bottom u-container-layout-1">
                <img alt="" class="u-expanded-width-xs u-image u-image-default u-image-1" src="images/Singleroom.PNG" data-image-width="303" data-image-height="398">
                <div class="u-container-style u-expanded-width-xs u-group u-video-cover u-group-1">
                  <div class="u-container-layout u-valign-bottom u-container-layout-2">
                    <h3 class="u-custom-font u-font-oswald u-text u-text-3">single room</h3>
                    <p class="u-text u-text-default u-text-4">Has a desk, text book shelf, bathroom shared with 3 people max</p>
                    <h6 class="u-text u-text-palette-3-base u-text-5">R150.00</h6>
                    <%--<a href="https://nicepage.com/k/ranking-website-templates" class="u-btn u-btn-rectangle u-button-style u-grey-10 u-btn-1">Apply</a>--%>
                     
                    <asp:Button ID="Button1" runat="server" Text="Apply" class="btn btn-primary btn-lg" OnClick="btnApplySingle_Click" />
                      
                      
                  </div>
                </div>
              </div>
            </div>
            <div class="u-container-style u-list-item u-repeater-item u-video-cover u-white u-list-item-2">
              <div class="u-container-layout u-similar-container u-valign-bottom u-container-layout-3">
                <img alt="" class="u-expanded-width-xs u-image u-image-default u-image-2" src="images/Twosharing.PNG" data-image-width="571" data-image-height="328">
                <div class="u-container-style u-expanded-width-xs u-group u-video-cover u-group-2">
                  <div class="u-container-layout u-valign-bottom u-container-layout-4">
                    <h3 class="u-custom-font u-font-oswald u-text u-text-default u-text-6">Two sharing</h3>
                    <p class="u-text u-text-default u-text-7">2 beds separeted by a wall,&nbsp;study desk, text book shelf, and other useful furniter</p>
                    <h6 class="u-text u-text-palette-3-base u-text-8">R100.00</h6>
                    <%--<a href="https://nicepage.com/k/interactive-website-templates" class="u-btn u-btn-rectangle u-button-style u-grey-10 u-btn-2">apply</a>--%>
                      <form id="TwosharingRoom">
                          
                          <div class="u-btn-submit">
                              <%--<asp:Button ID="Button2" runat="server" Text="Button" OnClick ="dfghjkl"/>--%>
                              <asp:Button ID="Button6" runat="server" Text="Apply"  OnClick="btnApplyTwo_Click" />
                          </div>
                          
                      </form>
                  </div>
                </div>
              </div>
            </div>
            <div class="u-container-style u-list-item u-repeater-item u-video-cover u-white u-list-item-3">
              <div class="u-container-layout u-similar-container u-valign-bottom u-container-layout-5">
                <img alt="" class="u-expanded-width-xs u-image u-image-default u-image-3" src="images/Threesharing.PNG" data-image-width="451" data-image-height="349" />
                <div class="u-container-style u-expanded-width-xs u-group u-video-cover u-group-3">
                  <div class="u-container-layout u-valign-bottom u-container-layout-6">
                    <h3 class="u-custom-font u-font-oswald u-text u-text-default u-text-9">Three sharing</h3>
                    <p class="u-text u-text-default u-text-10">3 beds separeted by a wall for privacy, study desk for each, sharing a kitchen with roommates&nbsp;</p>
                    <h6 class="u-text u-text-palette-3-base u-text-11">R90.00</h6>
                    <%--<a href="https://nicepage.com/wysiwyg-html-editor" class="u-btn u-btn-rectangle u-button-style u-grey-10 u-btn-3">apply</a>--%>
                      <%--<form id="ThreesharingRoom">--%>
                          <div class="u-btn-submit">
                               <asp:Button ID="Button3" runat="server" Text="Apply" class="btn btn-primary btn-lg" OnClick="btnApplyThree_Click"/>
                          </div>
                         
                      <%--</form>--%>
                  </div>
                </div>
              </div>
            </div>
            <div class="u-container-style u-list-item u-repeater-item u-video-cover u-white u-list-item-4">
              <div class="u-container-layout u-similar-container u-valign-bottom u-container-layout-7">
                <img alt="" class="u-expanded-width-xs u-image u-image-default u-image-4" src="images/Foursharing.PNG" data-image-width="539" data-image-height="255">
                <div class="u-container-style u-expanded-width-xs u-group u-video-cover u-group-4">
                  <div class="u-container-layout u-valign-bottom u-container-layout-8">
                    <h3 class="u-custom-font u-font-oswald u-text u-text-12">Four sharing</h3>
                    <p class="u-text u-text-default u-text-13">4 beds separeted by a wall and a curtin for privacy, 2 fridges, sharing a kitchen and bathroom with roommates</p>
                    <h6 class="u-text u-text-palette-3-base u-text-14">R80.00</h6>
                    <%--<a href="https://nicepage.me" class="u-btn u-btn-rectangle u-button-style u-grey-10 u-btn-4">apply</a>--%>
                      <%--<form id="FoursharingRoom">--%>
                          <asp:Button ID="Button4" runat="server" Text="Apply" class="btn btn-primary btn-lg" OnClick="btnApplyFour_Click" />
                      <%--</form>--%>
                  </div>
                </div>
              </div>
            </div>
            <div class="u-container-style u-list-item u-repeater-item u-video-cover u-white u-list-item-5">
              <div class="u-container-layout u-similar-container u-valign-bottom u-container-layout-9">
                <img alt="" class="u-expanded-width-xs u-image u-image-default u-image-5" src="images/Fivesharing.PNG" data-image-width="399" data-image-height="335">
                <div class="u-container-style u-expanded-width-xs u-group u-video-cover u-group-5">
                  <div class="u-container-layout u-valign-bottom u-container-layout-10">
                    <h3 class="u-custom-font u-font-oswald u-text u-text-default u-text-15">Five sharing</h3>
                    <p class="u-text u-text-default u-text-16">5 beds separeted by a curtain and a wall, 3 fridges, bathroom and kitchen shared with roommates&nbsp;</p>
                    <h6 class="u-text u-text-palette-3-base u-text-17">R50.00</h6>
                    <%--<a href="https://nicepage.com/wysiwyg-html-editor" class="u-btn u-btn-rectangle u-button-style u-grey-10 u-btn-5">Apply</a>--%>
                       <%--<form id="FivesharingRoom">--%>
                          <asp:Button ID="Button5" runat="server" Text="Apply" class="btn btn-primary btn-lg" OnClick="btnApplyFive_Click" />
                      <%--</form>--%>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
        <p class="u-text u-text-default u-text-18">Images from <a href="https://www.freepik.com/free-photos-vectors/background" target="_blank"><b>Freepik</b>
          </a>
        </p>
      </div>
    </section>
    
    
    <footer class="u-align-center u-clearfix u-footer u-grey-80 u-footer" id="sec-6cb5"><div class="u-clearfix u-sheet u-sheet-1">
        <p class="u-small-text u-text u-text-variant u-text-1">Sample text. Click to select the Text Element.</p>
      </div></footer>
    <section class="u-backlink u-clearfix u-grey-80">
      <a class="u-link" href="https://nicepage.com/website-templates" target="_blank">
        <span>Website Templates</span>
      </a>
      <p class="u-text">
        <span>created with</span>
      </p>
      <a class="u-link" href="" target="_blank">
        <span>Website Builder Software</span>
      </a>. 
    </section>
  
        </div>
    </form>
</body>
</html>
