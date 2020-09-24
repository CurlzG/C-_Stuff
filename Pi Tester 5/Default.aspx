<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication6.WebForm1" %>



<head runat="server">
    <link href="PiCss.css" rel="stylesheet" />
  
 


    <title></title>
</head>

<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>
             <div class="jumbotron">
        <div id="Box">
                 <h1> Pi Game</h1>
        <p class="lead">This website will test you on the knowledge of how many places of pi you know. <br />
           When you are ready to start the game click on the button and game will start.</p>
        <p class="lead">You will have 20 Seconds to remember as much as possible. <br />
            <asp:Button ID="Sumbit" runat="server" Text="Start" Height="34px" OnClick="Sumbit_Click" Width="82px" />
                 </p>
            <asp:Timer ID="Timer" runat="server" OnTick="Timer1_Tick" Interval="20000">
            </asp:Timer> 

            </div>
       
       <asp:TextBox ID="PiNum" Columns="100" MaxLength="80" Text="Number" runat="server" Font-Bold="True" Font-Size="30pt" Height="130px" Rows="4" TextMode="MultiLine" Width="1231px" Wrap="False" ReadOnly="True" Visible="False"/> <br />
        
        <asp:TextBox ID="Value1" Columns="118" MaxLength="118" placeHolder="Enter Your Guess" runat="server" Font-Size="30pt" Height="44px" Width="1231px" Visible="False"/>  
        <br /> 
       
        <asp:Button ID="SumBtn" runat="server" Text="Submit" Height="77px" OnClick="SumBtn_Click" Width="1229px" Visible="False" />
       
        <br /> <asp:TextBox ID="Answer" runat="server" Width="1231px" Height="69px" OnTextChanged="Answer_TextChanged" Font-Size="30pt" Visible="False"></asp:TextBox>
       
    </div>
        </div>
    </form>
</body>