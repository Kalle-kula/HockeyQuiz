<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="OnlineQuiz.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <style>
        body {
        min-width:250px;
        background-color: #000;
        }
        .footer {
        color:grey;
        }
        .jumbotron {
        margin-top:10px;
        text-align: center;
        /*font-family:'Century Gothic';*/
        padding: 0px 10px 10px 10px;
        background-color:#a38e8e;
        border-radius: 3px;
        display: inline-block
        }
        .header1 {
        background-color:#000;
        border-radius:3px;
        padding:25px 15px 70px 15px;
        
        }
        .header2 {
        background-color:#000;
        border-radius:3px;
        padding:15px;
        }
        .header3 {
        background-color:#000;
        border-radius:3px;
        padding: 15px;
        }

        .btn.btn-danger {
            background-color: green;
        }
        .btn.btn-info {
            background-color: blue;
        }
    </style>
    
    <title>Hockey-Quiz</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="jumbotron alert-success">
                <h2>Hockey-Quiz</h2>
            </div>

            <div class="row">

                <div class="col-lg-6 col-md-6">
                    <div class="header1">
                    <h2>Logga in/registrera:</h2>
                        <p>
                    <asp:TextBox runat="server" Id="userId" TextMode="SingleLine" Text=""/></p>
                    <asp:TextBox runat="server" Id="password" TextMode="SingleLine" Text=""/><br />
                    <p>
                        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Registrera ny användare</asp:LinkButton>
                    </p>
                    <asp:Button Text="Starta" CssClass="btn btn-danger" runat="server" OnClick="Enter_Click" ID="btnLogin" /><br /><br />
            
                </div>
            </div>

            <div class="col-lg-6 col-md-6">
                <div class="header2">
                    <h2>Skriv in fråga:</h2>
                    
                    <asp:TextBox runat="server" ID="Question" TextMode="SingleLine" Text="Fråga"/><br /><br />

                    <asp:TextBox runat="server" ID="Multiple1" TextMode="SingleLine" Text="Svar 1"/>&nbsp
                    <asp:CheckBox ID="CheckBox1" BorderStyle="None" runat="server" BorderWidth="0px"/>&nbsp
                    <asp:Label ID="Label2" runat="server" Text="Rätt svar"/><br /><br />

                    <asp:TextBox runat="server" ID="Multiple2" TextMode="SingleLine" Text="Svar 2"/>&nbsp
                    <asp:CheckBox ID="CheckBox2" BorderStyle="None" runat="server" BorderWidth="0px"/>&nbsp
                    <asp:Label ID="Label3" runat="server" Text="Rätt svar"/><br /><br />

                    <asp:TextBox runat="server" ID="Multiple3" TextMode="SingleLine" Text="Svar 3"/>&nbsp
                    <asp:CheckBox ID="CheckBox3" BorderStyle="None" runat="server" BorderWidth="0px"/>&nbsp
                    <asp:Label ID="Label4" runat="server" Text="Rätt svar"/><br /><br />
                    <asp:Button Text="Lägg till fråga" CssClass="btn btn-info" runat="server" ID="btnSubmitQuestion" OnClick="btnSubmitQuestion_Click" />
                </div>
            </div>
                        
            </div>
            <footer></footer>
        </div>
        
    </form>
    <script src="Scripts/jquery-2.1.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    
    </body>
</html>
