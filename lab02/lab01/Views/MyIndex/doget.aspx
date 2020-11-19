<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    doget
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        doget</h2>
    @VieData["outputdata"].toString()
    <%Label1.Text = Request["name"]; %>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</asp:Content>
