<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmEleve.aspx.cs" Inherits="foadcours.frmEleve" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <div class="form-horizontal">
        <h4>Elève</h4>
        <hr/>
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtNomPrenom" CssClass="col-md-4 control-label">Nom Prénom</asp:Label>
            <div class="col-md-8">
                <asp:TextBox runat="server" ID="txtNomPrenom" CssClass="form-control" />
                <%--<asp:RequiredFieldValidator runat="server" ControlToValidate="txtNomPrenom"
                    CssClass="text-danger" ErrorMessage="*" />--%>
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtEmail" CssClass="col-md-4 control-label">Email</asp:Label>
            <div class="col-md-8">
                <asp:TextBox runat="server" ID="txtEmail" TextMode="Email" CssClass="form-control" />
                <%--<asp:RequiredFieldValidator runat="server" ControlToValidate="txtEmail"
                    CssClass="text-danger" ErrorMessage="*" />--%>
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtAdresse" CssClass="col-md-4 control-label">Adresse</asp:Label>
            <div class="col-md-8">
                <asp:TextBox runat="server" ID="txtAdresse" CssClass="form-control" />
                <%--<asp:RequiredFieldValidator runat="server" ControlToValidate="txtAdresse"
                    CssClass="text-danger" ErrorMessage="*" />--%>
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="ddlService" CssClass="col-md-4 control-label">Service</asp:Label>
            <div class="col-md-8">
                <asp:DropDownList runat="server" ID="ddlService" CssClass="form-control"></asp:DropDownList>
                <%-- <asp:RequiredFieldValidator runat="server" ControlToValidate="ddlService"
                    CssClass="text-danger" ErrorMessage="*" />--%>
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" Text="Enregistrer" CssClass="btn btn-success" ID="btnEnregistrer" OnClick="btnEnregistrer_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button runat="server" Text="Rechercher" CssClass="btn btn-primary" ID="btnRechercher" OnClick="btnRechercher_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button runat="server" Text="Suprimer" CssClass="btn btn-danger" ID="btnSupprimer" OnClick="btnSupprimer_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button runat="server" Text="Modifier" CssClass="btn btn-warning" ID="btnModifier" OnClick="btnModifier_Click" />
            </div>
        </div>
    </div>
    <table style="width: 100%;">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3"><asp:GridView ID="dgEleve" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" Width="100%" OnSelectedIndexChanged="dgEleve_SelectedIndexChanged">
                <AlternatingRowStyle BackColor="#CCCCCC" />
                <Columns>
                    <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
                </Columns>
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
                </asp:GridView>

            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
