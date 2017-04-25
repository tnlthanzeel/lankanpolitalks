<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="WebApplication5.registration" %>

<!DOCTYPE html >

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <meta charset="UTF-8"/>
    <title>Sign-Up/Login Form</title>
    <link href='http://fonts.googleapis.com/css?family=Titillium+Web:400,300,600' rel='stylesheet' type='text/css'/>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/normalize/5.0.0/normalize.min.css"/>

    <link rel="stylesheet" href="css2/style.css"/>




</head>
    <body>
 <div class="form">

        <ul class="tab-group">
            <li class="tab active"><a href="#signup">Sign Up</a></li>
            <li class="tab"><a href="#login">Log In</a></li>
        </ul>

        <div class="tab-content">
            <div id="signup">
                <h1>Sign Up for Free</h1>

              <form id="form1" action="registration.aspx" method="post" runat="server">

                    <div class="top-row">
                        <div class="field-wrap">
                            <label>
                                First Name<span class="req">*</span>
                            </label>
                            <input type="text" id="txtFname" requiredautocomplete="off"  runat="server"/>
                        </div>

                        <div class="field-wrap">
                            <label>
                                Last Name<span class="req">*</span>
                            </label>
                            <input type="text" id="txtLname" requiredautocomplete="off"  runat="server"/>
                        </div>
                    </div>
                    <div class="field-wrap">
                        <label>
                            Email Address<span class="req">*</span>
                        </label>
                        <input type="email" id="txtEmail" requiredautocomplete="off"  runat="server"/>
                    </div>

                    <div class="field-wrap">
                        <label>
                            Set A Password<span class="req">*</span>
                        </label>
                        <input type="password" id="txtPassword" requiredautocomplete="off"  runat="server" />
                    </div>

                   <asp:Button ID="Button1" runat="server" Text="Get Started" BackColor="#00CC00" ForeColor="White" OnClick="Button1_Click" />
                </form>
            </div>

            <div id="login">
                <h1>Welcome Back!</h1>

                <form id="frmlogin" action="registration.aspx" method="post" >
                    <div class="field-wrap">
                        <label>
                            Email Address<span class="req">*</span>
                        </label>
                        <input type="email" id="txtEmail1" requiredautocomplete="off"/>
                    </div>

                    <div class="field-wrap">
                        <label>
                            Password<span class="req">*</span>
                        </label>
                        <input type="password" id="txtPassword1" requiredautocomplete="off"/>
                    </div>

                    <p class="forgot"><a href="#">Forgot Password?</a></p>
                    <input type="button" value="Login" name="btn_login"/>
                <%--<asp:Button ID="Button2"  Text="Log In" BackColor="#00CC00" ForeColor="White" />--%>

                   </form>
            </div>

        </div><!-- tab-content -->

    </div> <!-- /form -->
    <script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>
    <script src="js2/index.js"></script>
    </body>
</html>
