<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signIn.aspx.cs" Inherits="politalks.signIn" %>

<!DOCTYPE html>

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

     
                <h1>Welcome</h1>

                 <form id="form1" action="signIn.aspx" method="post" runat="server">
                     <div class="field-wrap">
                        <label>
                            Email Address<span class="req">*</span>
                        </label>
                        <input id="txtEmail" type="email" required autocomplete="off" runat="server" />
                    </div>

                    <div class="field-wrap">
                        <label>
                            Password<span class="req">*</span>
                        </label>
                        <input id="txtPassword" type="password" required autocomplete="off" runat="server" />
                    </div>

                    <p class="forgot"><a href="#">Forgot Password?</a></p>

                    <asp:Button ID="Button1" runat="server" Text="Sign in" BackColor="#00CC00" BorderColor="#00CC00" OnClick="Button1_Click" />
                    </form>
            </div>

           

    <script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>
    <script src="js2/index.js"></script>
</body>
</html>
