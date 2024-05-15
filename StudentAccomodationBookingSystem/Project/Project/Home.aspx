<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Project.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="description" content="OneTech shop project">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" type="text/css" href="styles/bootstrap4/bootstrap.min.css">
    <link href="plugins/fontawesome-free-5.0.1/css/fontawesome-all.css" rel="stylesheet" type="text/css">
    <link rel="stylesheet" type="text/css" href="plugins/OwlCarousel2-2.2.1/owl.carousel.css">
    <link rel="stylesheet" type="text/css" href="plugins/OwlCarousel2-2.2.1/owl.theme.default.css">
    <link rel="stylesheet" type="text/css" href="plugins/OwlCarousel2-2.2.1/animate.css">
    <link rel="stylesheet" type="text/css" href="plugins/slick-1.8.0/slick.css">
    <link rel="stylesheet" type="text/css" href="styles/main_styles.css">
    <link rel="stylesheet" type="text/css" href="styles/responsive.css">

    <link rel="icon" href="images/fevicon.png" type="image/gif" />
    <!-- Scrollbar Custom CSS -->
    <link rel="stylesheet" href="css/jquery.mCustomScrollbar.min.css">
    <!-- Tweaks for older IEs-->
    <link rel="stylesheet" href="https://netdna.bootstrapcdn.com/font-awesome/4.0.3/css/font-awesome.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/fancybox/2.1.5/jquery.fancybox.min.css" media="screen">

</head>
<body>
    <form id="form1" runat="server">
		<div class="top_bar">
			<div class="container">
				<div class="row">
					<div class="col d-flex flex-row">
						<div class="top_bar_contact_item"><div class="top_bar_icon"><img src="images/phone.png" alt=""></div>+27 110 110 1111</div>
						<div class="top_bar_contact_item"><div class="top_bar_icon"><img src="images/mail.png" alt=""></div><a href="mailto:nestpikaccomodations@gmail.com">nestpikaccomodations@gmail.com</a></div>
						<div class="top_bar_content ml-auto">
							<div class="top_bar_menu">
								<%--<ul class="standard_dropdown top_bar_dropdown">
									<li>
										<a href="#">English<i class="fas fa-chevron-down"></i></a>
										<ul>
											<li><a href="#">Italian</a></li>
											<li><a href="#">Spanish</a></li>
											<li><a href="#">Japanese</a></li>
										</ul>
									</li>
									<li>
										<a href="#">$ US dollar<i class="fas fa-chevron-down"></i></a>
										<ul>
											<li><a href="#">EUR Euro</a></li>
											<li><a href="#">GBP British Pound</a></li>
											<li><a href="#">JPY Japanese Yen</a></li>
										</ul>
									</li>
								</ul>--%>
							</div>
							<div class="top_bar_user" id ="logout" runat ="server">
								<div class="user_icon"><img src="images/user.svg" alt=""></div>
								<div><a href="Main.aspx?out=-1">logOut</a></div>
							</div>
						</div>
					</div>
				</div>
			</div>		
		</div>

		<%--NAVIGATION BAR--%>
        <div>
            <div class="main_nav_menu ml-auto">
					<ul class="standard_dropdown main_nav_dropdown">
						<li><a href="#">'    '<i class="fas fa-chevron-down"></i></a></li>
						 
					    <li><a href="Apply.aspx">Apply<i class="fas fa-chevron-down"></i></a></li>
                        
					    <li><a href="#">Application status<i class="fas fa-chevron-down"></i></a></li>
		
                        <li><a href="#">Personal details<i class="fas fa-chevron-down"></i></a></li>

						<li><a href="Contact.aspx">Contact<i class="fas fa-chevron-down"></i></a></li>

                        <li class="hassubs">
                            <a href="#">Price List<i class="fas fa-chevron-down"></i></a>
                            <ul>
								<li>
									<a href="#">Application fee<i class="fas fa-chevron-down"></i></a>
									<ul>
										<li><a href="1">Single Room ---- R150<i class="fas fa-chevron-down"></i></a></li>
										<li><a href="2">Two Sharing -----R100<i class="fas fa-chevron-down"></i></a></li>
										<li><a href="3">Three Sharing ---R90<i class="fas fa-chevron-down"></i></a></li>
                                        <li><a href="4">Four Sharing  ---R80<i class="fas fa-chevron-down"></i></a></li>
                                        <li><a href="5">Five Sharing  ---R50<i class="fas fa-chevron-down"></i></a></li>
									</ul>
                                    
								</li>
                                <li>
                                    <a href="#">Discounts<i class="fas fa-chevron-down"></i></a>
									<ul>
										<li><a href="1">NSFAS------free<i class="fas fa-chevron-down"></i></a></li>
										<li><a href="2">cash-----10%OFF<i class="fas fa-chevron-down"></i></a></li>
									</ul>
                                </li>
							</ul>
                        </li>
						<li><a href="Reviews.aspx">Reviews<i class="fas fa-chevron-down"></i></a></li>
					</ul>
				</div>


			<div class="menu_trigger_container ml-auto">
				<div class="menu_trigger d-flex flex-row align-items-center justify-content-end">
					<div class="menu_burger">
						<div class="menu_trigger_text">menu</div>
						<div class="cat_burger menu_burger_inner"><span></span><span></span><span></span></div>
					</div>
				</div>
			</div>
        </div>
		 <div  class="about">
         <div class="container">
            <div class="row">
            </div>
            <div class="container">
               <div class="row">
                  <div class="col-md-10 offset-md-1">

                  </div>
               </div>
            </div>
         </div>
      </div>
      <!-- end about -->
      <!-- wedo  section -->
      <div class="wedo ">
         <div class="container">
            <div class="row">
               <div class="col-md-12">
                  <div class="titlepage">
                     <h2>What We Offer</h2>
                     <p>Here are the things that our student accommodation offers: </p>
                  </div>
               </div>
            </div>
            <div class="row">
               <div class="col-md-10 offset-md-1">
                  <div class="row">
                     <div class="col-md-6 margin_bottom">
                        <div class="work">
						    <p>Single room</p>
                           <figure><img src="images/Single.jpg" height="450" width="450" alt="#" /></figure>
                        </div>
                        
                     </div>
                      <div></div>
                     <div class="col-md-6 margin_bottom">
                        <div class="work">
						    <p>Sharing</p>
                           <figure><img src="images/Sharing.jpg" height="450" width="450" alt="#" /></figure>
                        </div>
                    
                     </div>
                     <div class="col-md-6 margin_bottom">
                        <div class="work">
						<p>Gym</p>
                           <figure><img src="images/Gym.jpg" height="450" width="450" alt="#" /></figure>
                        </div>
                        
                     </div>
                     <br />
                      <div></div>
                     <%--<div class="col-md-6 margin_bottom">
                        <div class="work">
						<p>Library</p>
                           <figure><img src="images/Library.jpg" alt="#" /></figure>
                        </div>
                     </div>--%>
			  <div class="col-md-6 margin_bottom">
                        <div class="work">
						<p>Free unlimited Wi-Fi</p>
                           <figure><img src="images/wifi.jpg" height="450" width="450" alt="#" /></figure>
                        </div>
                     </div>
					 
					 
					 
					 <div class="col-md-6 margin_bottom">
                        <div class="work">
						<p>Entertainment Area</p>
                           <figure><img src="images/Enter.jpg" alt="#"  height="450" width="450"/></figure>
                        </div>
                     </div>
					 
					 
					 
                  </div>
               </div>
            </div>
         </div>
      </div>
      <!-- end wedo  section -->
      <!-- testimonial -->
      <div class="testimonial">
         <div class="container">
            <div class="row">
               
            </div>
            <div class="row">
               <div class="col-md-12">
                  <div id="myCarousel" class="carousel slide testimonial_Carousel " data-ride="carousel">
                     <ol class="carousel-indicators">
                        <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                        <li data-target="#myCarousel" data-slide-to="1"></li>
                        <li data-target="#myCarousel" data-slide-to="2"></li>
                     </ol>
                     <div class="carousel-inner">
                        <div class="carousel-item active">
                           <div class="container">
                              <div class="carousel-caption ">
                                 <div class="row">
                                    
                                   
                                 </div>
                              </div>
                           </div>
                        </div>
                        <div class="carousel-item">
                           <div class="container">
                              <div class="carousel-caption">
                                 <div class="row">
                                    
                                    
                                 </div>
                              </div>
                           </div>
                        </div>
                        <div class="carousel-item">
                           <div class="container">
                              <div class="carousel-caption">
                                 <div class="row">
                                    
                                    
                                 </div>
                              </div>
                           </div>
                        </div>
                     </div>
                     <a class="carousel-control-prev" href="#myCarousel" role="button" data-slide="prev">
                     <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                     <span class="sr-only">Previous</span>
                     </a>
                     <a class="carousel-control-next" href="#myCarousel" role="button" data-slide="next">
                     <span class="carousel-control-next-icon" aria-hidden="true"></span>
                     <span class="sr-only">Next</span>
                     </a>
                  </div>
               </div>
            </div>
         </div>
      </div>
      <!-- end testimonial -->
      </div>
      <!--  footer -->
      <footer id="contact">
         <div class="footer">
            <div class="container">
               <div class="row">
                  <div class="col-md-4">
                     <div class="titlepage">
                        <h2>Contact Us</h2>
                     </div>
                  </div>
                  <div class="col-md-8">
                     <ul class="location_icon">
                        <li><a href="#"><i class="fa fa-map-marker" aria-hidden="true"></i></a> Location
						</li>
                        <li><a href="#"><i class="fa fa-volume-control-phone" aria-hidden="true"></i></a> +27 724927223</li>
                        <li><a href="#"><i class="fa fa-envelope" aria-hidden="true"></i></a>Nest@gmail.com</li>
                     </ul>
                  </div>
                  <div class="col-md-6">
                     <form id="request" class="main_form">
                        <div class="row">
                           <div class="col-md-12 ">
                              <input class="contactus" placeholder="Full Name" type="type" name="Full Name"> 
                           </div>
                           <div class="col-md-12">
                              <input class="contactus" placeholder="Email" type="type" name="Email"> 
                           </div>
                           <div class="col-md-12">
                              <input class="contactus" placeholder="Phone Number" type="type" name="Phone Number">                          
                           </div>
                           <div class="col-md-12">
                              <textarea class="textarea" placeholder="Message" type="type" Message="Name">Message </textarea>
                           </div>
                           <div class="col-sm-col-xl-6 col-lg-6 col-md-6 col-sm-12">
                              <button class="send_btn">Send</button>
                           </div>
                           <div class="col-sm-col-xl-6 col-lg-6 col-md-6 col-sm-12">
                              <ul class="social_icon">
                                 <li><a href="#"><i class="fa fa-facebook" aria-hidden="true"></i></a></li>
                                 <li><a href="#"><i class="fa fa-twitter" aria-hidden="true"></i></a></li>
                                 <li><a href="#"><i class="fa fa-linkedin-square" aria-hidden="true"></i></a></li>
                                 <li><a href="#"><i class="fa fa-instagram" aria-hidden="true"></i></a></li>
                              </ul>
                           </div>
                        </div>
                     </form>
                  </div>
                  <div class="col-md-6">
                     <div class="map">
                        <figure><img src="images/map.jpg" alt="#"/></figure>
                     </div>
                     <form class="bottom_form">
                        <h3>Newsletter</h3>
                        <input class="enter" placeholder="Enter your email" type="text" name="Enter your email">
                        <button class="sub_btn">subscribe</button>
                     </form>
                  </div>
               </div>
            </div>
            <div class="copyright">
               <div class="container">
                  <div class="row">
                     <div class="col-md-12">
                        <p>Copyright 2019 All Right Reserved By <a href="https://html.design/"> Free  html Templates</a></p>
                     </div>
                  </div>
               </div>
            </div>
         </div>
      </footer>
      <!-- end footer -->
      <!-- Javascript files-->
      <script src="js/jquery.min.js"></script>
      <script src="js/popper.min.js"></script>
      <script src="js/bootstrap.bundle.min.js"></script>
      <script src="js/jquery-3.0.0.min.js"></script>
      <!-- sidebar -->
      <script src="js/jquery.mCustomScrollbar.concat.min.js"></script>
      <script src="js/custom.js"></script>
      
    </form>


	
	<script src="js/jquery-3.3.1.min.js"></script>
	<script src="styles/bootstrap4/popper.js"></script>
	<script src="styles/bootstrap4/bootstrap.min.js"></script>
	<script src="plugins/greensock/TweenMax.min.js"></script>
	<script src="plugins/greensock/TimelineMax.min.js"></script>
	<script src="plugins/scrollmagic/ScrollMagic.min.js"></script>
	<script src="plugins/greensock/animation.gsap.min.js"></script>
	<script src="plugins/greensock/ScrollToPlugin.min.js"></script>
	<script src="plugins/OwlCarousel2-2.2.1/owl.carousel.js"></script>
	<script src="plugins/slick-1.8.0/slick.js"></script>
	<script src="plugins/easing/easing.js"></script>
	<script src="js/custom.js"></script>


    <script src="js/jquery.min.js"></script>
    <script src="js/popper.min.js"></script>
    <script src="js/bootstrap.bundle.min.js"></script>
    <script src="js/jquery-3.0.0.min.js"></script>
    <!-- sidebar -->
    <script src="js/jquery.mCustomScrollbar.concat.min.js"></script>
</body>
</html>
