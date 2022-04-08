<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmService.aspx.cs" Inherits="foadcours.Inscription.frmService" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-horizontal">
        <h4>Service</h4>
        <hr/>
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtLibelle" CssClass="col-md-4 control-label">Libelle</asp:Label>
            <div class="col-md-8">
                <asp:TextBox runat="server" ID="txtLibelle" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtLibelle"
                    CssClass="text-danger" ErrorMessage="*" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtMontant" CssClass="col-md-4 control-label">Montant</asp:Label>
            <div class="col-md-8">
                <asp:TextBox runat="server" ID="txtMontant" TextMode="Number" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtMontant"
                    CssClass="text-danger" ErrorMessage="*" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="txtType" CssClass="col-md-4 control-label">Type</asp:Label>
            <div class="col-md-8">
                <asp:TextBox runat="server" ID="txtType" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtType"
                    CssClass="text-danger" ErrorMessage="*" />
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" Text="Enregistrer" CssClass="btn btn-success" ID="btnEnregistrer" OnClick="btnEnregistrer_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button runat="server" Text="Modifier" CssClass="btn btn-danger" ID="btnModifier" OnClick="btnModifier_Click" />
            </div>
        </div>
    </div>

    <table style="width: 100%; height: 77px;">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:GridView ID="dgService" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" Width="100%">
                    <AlternatingRowStyle BackColor="#CCCCCC" />
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
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
    </table>
</asp:Content>
