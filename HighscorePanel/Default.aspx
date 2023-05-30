<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Highscore Table</title>
    <style>
        #gridViewHighscores {
            font-family: Arial, sans-serif;
            border-collapse: collapse;
            width: 100%;
        }

        #gridViewHighscores th {
            background-color: #4CAF50;
            color: white;
            font-weight: bold;
            padding: 10px;
            text-align: left;
        }

        #gridViewHighscores td {
            border: 1px solid #ddd;
            padding: 8px;
        }

        #gridViewHighscores tr:nth-child(even) {
            background-color: #f2f2f2;
        }

        #gridViewHighscores tr:hover {
            background-color: #ddd;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="gridViewHighscores" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="username" HeaderText="Username" />
                <asp:BoundField DataField="highscore" HeaderText="Highscore" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>