<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signUp.aspx.cs" Inherits="politalks.signUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta charset="UTF-8">
    <title>Sign-Up/Login Form</title>
    <link href='http://fonts.googleapis.com/css?family=Titillium+Web:400,300,600' rel='stylesheet' type='text/css'>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/normalize/5.0.0/normalize.min.css">

    <link rel="stylesheet" href="css2/style.css">
</head>
<body>
    <div class="form">

     
                <h1>Sign Up for Free</h1>

                <form id="form1" action="signUp.aspx" method="post" runat="server">
                    <div class="top-row">
                        <div class="field-wrap">
                            <label>
                                First Name<span class="req">*</span>
                            </label>
                            <input id="txtFname" type="text" required autocomplete="off" runat="server" />
                        </div>

                        <div class="field-wrap">
                            <label>
                                Last Name<span class="req">*</span>
                            </label>
                            <input id="txtLname" name="txtLname" type="text" required autocomplete="off" runat="server" />
                        </div>
                    </div>
                    <div class="field-wrap">
                        <label>
                            Email Address<span class="req">*</span>
                        </label>
                        <input id="txtEmail" type="email" required autocomplete="off" runat="server" />
                    </div>

                    <div class="field-wrap">
                        <label>
                            Set A Password<span class="req">*</span>
                        </label>
                        <input id="txtPassword" type="password" required autocomplete="off" runat="server" />
                    </div>

                    <asp:Button ID="Button1" Text="Sign up"runat="server" Text="Submit" BackColor="#00CC00" BorderColor="#00CC00" OnClick="Button1_Click" />
                    
                </form>
            </div>

           

    <script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>
    <script src="js2/index.js"></script>
</body>
</html>
