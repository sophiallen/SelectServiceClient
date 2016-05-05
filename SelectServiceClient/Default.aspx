<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Show Tracker Service Client</title>
    <link rel="stylesheet" href="StyleSheet.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Search For Shows</h1>
        <h4><em>Search by artist or venue, or display all shows.</em></h4>
    <div>
        <label id="artists">Artists:<br /><asp:DropDownList ID="ArtistDropDown" runat="server"></asp:DropDownList></label>
        <label>Venues:<br /><asp:DropDownList ID="VenueDropDown" runat="server"></asp:DropDownList></label>
        <label>Shows:<br /><asp:DropDownList ID="ShowDropDown" runat="server"></asp:DropDownList></label>
        <asp:Button ID="SelectArtist" runat="server" Text="Search By Artist" OnClick="SelectArtist_Click" />
        <asp:Button ID="SelectVenue" runat="server" Text="Search By Venue" OnClick="SelectVenue_Click" />
        <asp:Button ID="DisplayShows" runat="server" Text="List All Shows" OnClick="DisplayShows_Click"/>
        <asp:GridView ID="ShowGridView" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
