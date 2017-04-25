﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mahinda.aspx.cs" Inherits="lankapolitalks.mahinda" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="">
    <meta name="author" content="">


    <title>All Template Needs</title>

    <!-- Bootstrap core CSS -->
    <link href="css/bootstrap.css" rel="stylesheet">
    <link rel="stylesheet" href="css/normalize.css">
    <link rel="stylesheet" href="css/component.css">
    <link rel="stylesheet" href="css/custom-styles.css">
    <link rel="stylesheet" href="css/font-awesome.css">
    <link rel="stylesheet" href="loginbtn.css">

    <!--  <a href="index.html">index.html</a>-->

    <link rel="stylesheet" href="css/demo.css">
    <link rel="stylesheet" href="css/font-awesome-ie7.css">

    <script src="js/jquery.mobilemenu.js"></script>
    <script src="js/html5shiv.js"></script>
    <script src="js/respond.min.js"></script>
    <script>
    $(document).ready(function(){
        $('.menu').mobileMenu();
    });
    </script>

</head>

<body>
    <div class="header-wrapper">
        <div class="site-name">
            <h1>LankanPoliTalks!</h1>
            <h2>Sri Lankan Future</h2>
        </div>
    </div>
    <div class="menu">
        <div class="navbar">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <i class="fw-icon-th-list"></i>
                    </button>
                </div>
                <div class="navbar-collapse collapse">
                    <ul class="nav navbar-nav">
                        <li><a href="index.html">Home</a></li>
                        <li><a href="#">About</a></li>
                        <li><a href="Politicians.html">Sri Lankan politician</a></li>
                        <li><a href="Contact.html">Contact</a></li>
                    </ul>
                </div><!--/.navbar-collapse -->
            </div>
        </div>
        <div class="mini-menu">
            <label>
                <select class="selectnav">
                    <option value="#" selected="">Home</option>
                    <option value="#">About</option>.
                    <option value="#">Sri Lankan Politician</option>
                    <option value="#">Contact</option>

                </select>
            </label>
        </div>
    </div>

    <!-- Main jumbotron for a primary marketing message or call to action -->
    <div class="banner">
        <div id="carousel-example-generic" class="carousel slide">

            <!-- Wrapper for slides -->
            <div class="carousel-inner">
                <div class="item active">
                    <img src="img/banner-image.jpg" alt="">
                    <div class="carousel-caption">
                        <h1>Sri Lankan Politics</h1>
                        <h2>Vote for your Politician</h2>
                        <a href="#" class="btn">VOTE</a>
                    </div>
                </div>
                <div class="item">
                    <img src="img/banner-image.jpg" alt="">
                    <div class="carousel-caption">
                        <h1>Sri Lankan Politics</h1>
                        <h2>Vote for your Politician</h2>
                        <a href="#" class="btn">VOTE</a>
                    </div>
                </div>
                <div class="item">
                    <img src="img/banner-image.jpg" alt="">
                    <div class="carousel-caption">
                        <h1>Sri Lankan Politics</h1>
                        <h2>Vote for your Politician</h2>
                        <a href="#" class="btn">VOTE</a>
                    </div>
                </div>
            </div>

            <!-- Controls -->
            <a class="left carousel-control" href="#carousel-example-generic" data-slide="prev">
                <i class="fw-icon-chevron-left"></i>
            </a>
            <a class="right carousel-control" href="#carousel-example-generic" data-slide="next">
                <i class="fw-icon-chevron-right"></i>
            </a>
        </div>
    </div>















































    <div class="footer-wrapper">
        <div class="site-content">
            <div class="container">
                <div class="row">

                    <div class="block col-md-2 col-sm-6">
                        <h1>Home</h1>
                        <ul>
                            <li><a href="#">News</a></li>
                            <li><a href="#">famous politicians</a></li>

                        </ul>
                    </div>
                    <div class="block col-md-2 col-sm-6">
                        <h1>About Us</h1>
                        <ul>
                            <li><a href="#">Who are we?</a></li>
                            <li><a href="#">Purpose</a></li>
                            <li><a href="#">Solutions</a></li>
                        </ul>
                    </div>
                    <div class="block col-md-2 col-sm-6">
                        <h1>Politicians</h1>
                        <ul>
                            <li><a href="#">President</a></li>
                            <li><a href="#">Prime Minister</a></li>
                            <li><a href="#">Ministers</a></li>
                        </ul>
                    </div>
                    <!--
                                        <div class="block col-md-3">
                               <h1>Praesent dapibus, neque id cursus faucibus</h1>
                               <div class="input-group">
                                   <input type="email" value="" name="EMAIL" class="required email form-control" id="mce-EMAIL">
                                   <span class="input-group-btn">
                                 <input type="submit" class="button btn btn-default" value="Subscribe" name="subscribe" id="mc-embedded-subscribe">
                                   </span>
                               </div>
                             </div>
                        -->
                    <div class="block col-md-3">
                        <h1> Go and like Us</h1>
                        <ul class="social">
                            <li><a href="#"><i class="fw-icon-twitter"></i></a></li>
                            <li><a href="#"><i class="fw-icon-facebook"></i></a></li>
                            <li><a href="#"><i class="fw-icon-linkedin"></i></a></li>
                        </ul>
                    </div>
                </div>
            </div>

        </div>
        <div class="copy-rights">
            <div class="container">
                <div class="row">
                    <!--
                      <div class="col-md-6">
                        Copyright(c) website name. Designed by: <a href="http://www.alltemplateneeds.com"> www.alltemplateneeds.com</a>
                      </div>
                      <div class="col-md-6">
                        Images from: <a href="http://www.wallpaperswide.com">http://wallpaperswide.com</a> / <a href="http://www.wallcoo.net"> www.wallcoo.net</a>
                      </div>
                      -->
                </div>
            </div>
        </div>
    </div>




    <!-- Bootstrap core JavaScript
    ================================================== -->
    <!-- Placed at the end of the document so the pages load faster -->
    <script src="js/jquery-1.9.1.js"></script>
    <script src="js/bootstrap.js"></script>
    <script src="js/modernizr-2.6.2-respond-1.1.0.min.js"></script>


</body>
</html>

