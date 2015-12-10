<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Resultat.aspx.cs" Inherits="OnlineQuiz.Resultat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Resultat</title>
        <script type="text/javascript" src="Scripts/JavaScript.js"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
        <style>
        .jumbotron {
        /*font-family:'Century Gothic';*/
        padding:0px 10px 10px 10px;
        background-color:#a38e8e;
        border-radius: 3px;
        display: inline-block;
        }

        .body {
            background-color: #000;
        }

        .results {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="container">
            <div class="jumbotron"><h2>Resultat</h2></div>

        </div>
        <div class="results">
        <p><asp:Label ID="lblScore" runat="server" Text="" ForeColor="White" OnLoad="lblScore_Load"></asp:Label></p>
        <p><asp:Label ID="lblYourAverage" runat="server" Text="" ForeColor="White" OnLoad="lblYourAverage_Load"></asp:Label></p>
        <p><asp:Label ID="lblTotalAverage" runat="server" Text="" ForeColor="White" OnLoad="lblTotalAverage_Load"></asp:Label></p>
            </div>
    </div>
    </form>
    <script src="Scripts/jquery-2.1.1.min.js"></script>
        <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
