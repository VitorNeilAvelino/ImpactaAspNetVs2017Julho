<%@ Page Title="Nova Tarefa" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="Pessoal.WebForms.Tarefas.Create" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Nova Tarefa</h1>
    <hr />
    <asp:ValidationSummary ID="tarefasValidationSummary" runat="server" />
    <table>
        <tr>
            <td style="width: 115px">Nome</td>
            <td>
                <asp:TextBox ID="nomeTextBox" runat="server" Width="250px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Nome é obrigatório." ControlToValidate="nomeTextBox" CssClass="text-danger">(!)</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 115px">Prioridade</td>
            <td>
                <asp:DropDownList ID="prioridadeDropDownList" runat="server" 
                    DataSourceID="prioridadeObjectDataSource" AppendDataBoundItems="true">
                    <asp:ListItem Text="Selecione" Value="0" />
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Selecione uma prioridade." ControlToValidate="prioridadeDropDownList" CssClass="text-danger" Text="(!)" InitialValue="0">(!)</asp:RequiredFieldValidator>
                <asp:ObjectDataSource ID="prioridadeObjectDataSource" runat="server" SelectMethod="ObterPrioridades" TypeName="Pessoal.WebForms.Tarefas.Create"></asp:ObjectDataSource>
            </td>
        </tr>
        <tr>
            <td style="width: 115px">Concluída</td>
            <td>
                <asp:CheckBox ID="concluidaCheckBox" runat="server" />
            </td>
        </tr>
        <tr>
            <td style="width: 115px">Observações</td>
            <td>
                <asp:TextBox ID="observacoesTextBox" runat="server" Rows="5" TextMode="MultiLine" Width="250px"></asp:TextBox>
            </td>
        </tr>
    </table>
    <asp:Button ID="gravarButton" runat="server" Text="Gravar" OnClick="gravarButton_Click" />
</asp:Content>
