<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Questions.aspx.cs" Inherits="OnlineQuiz.Questions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Questions</title>
    <script type="text/javascript" src="Scripts/JavaScript.js"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <style>
        .jumbotron {
        margin-top:10px;
        text-align: center;
        /*font-family:'Century Gothic';*/
        padding:0px 10px 10px 10px;
        background-color:#a38e8e;
        border-radius: 3px;
        display: inline-block;
        }

        body {
        background-color:#000;
        }

        .detail {
            text-align:center;
        }

        .btn.btn-primary {
            background-color: red;
            margin-right: 5px;
        }

        .btn.btn-default {
            background-color: green;
            margin-left: 5px;
        }

    </style>

</head>
<body>

    <form id="form1" runat="server">
        <div class="container">
            <div class="jumbotron">
                <h2>Frågor</h2>
            </div>
        </div>
    <div>
        <asp:Repeater ID="Repeater1" runat="server">
            
            <HeaderTemplate>
                <div id="divQuestions">
            </HeaderTemplate>
            <ItemTemplate>
                <div class="detail">
                   <div>Fråga: <strong><%# Eval("Question1") %> </strong></div>

                    <div id="answer1">1. <strong><%# Eval("Multiple1")%>&nbsp</strong><input type="checkbox" id="CheckBox1" runat="server" /><asp:Label id="Label1" ForeColor="White" runat="server" Text=""></asp:Label></div>
                    <div id="answer2">2. <strong><%# Eval("Multiple2")%>&nbsp</strong><input type="checkbox" id="CheckBox2" runat="server" /><asp:Label id="Label2" ForeColor="White" runat="server" Text=""></asp:Label></div>
                    <div id="answer3">3. <strong><%# Eval("Multiple3")%>&nbsp</strong><input type="checkbox" id="CheckBox3" runat="server" /><asp:Label id="Label3" ForeColor="White" runat="server" Text=""></asp:Label></div><br />
                    
                </div>
            </ItemTemplate>
            <AlternatingItemTemplate>
                <div class="detail">
                   <div>Fråga: <strong><%# Eval("Question1") %> </strong></div>

                    <div id="answer1">1. <strong><%# Eval("Multiple1")%>&nbsp</strong><input type="checkbox" id="CheckBox1" runat="server" /><asp:Label id="Label1" ForeColor="White" runat="server" Text=""></asp:Label></div>
                    <div id="answer2">2. <strong><%# Eval("Multiple2")%>&nbsp</strong><input type="checkbox" id="CheckBox2" runat="server" /><asp:Label id="Label2" ForeColor="White" runat="server" Text=""></asp:Label></div>
                    <div id="answer3">3. <strong><%# Eval("Multiple3")%>&nbsp</strong><input type="checkbox" id="CheckBox3" runat="server" /><asp:Label id="Label3" ForeColor="White" runat="server" Text=""></asp:Label></div><br />     
                                  
                </div>
            </AlternatingItemTemplate>
            <FooterTemplate>
                </div>
            </FooterTemplate>

        </asp:Repeater>

    </div>
        <div class="detail">
        <asp:Button ID="btnSubmitAnswer" CssClass="btn btn-primary" runat="server" OnClick="btnSubmitAnswer_Click" Text="Skicka in svar" /><asp:Button ID="showScore" CssClass="btn btn-default" OnClick="showScore_Click" runat="server" Text="Visa resultat" /><br />
        </div>
            </form>
        <script src="Scripts/jquery-2.1.1.min.js"></script>
        <script src="Scripts/bootstrap.min.js"></script>
        

</body>

</html>
