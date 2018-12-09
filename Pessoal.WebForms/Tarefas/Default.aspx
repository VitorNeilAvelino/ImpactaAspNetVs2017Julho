<%@ Page Title="Tarefas" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Pessoal.WebForms.Tarefas.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Tarefas</h1>
    <asp:LinkButton Text="Nova" PostBackUrl="Create" runat="server" />
    <br />    
    <asp:GridView DataSourceID="gridTarefasObjectDataSource" runat="server" AutoGenerateColumns="False" Width="100%">
        <Columns>
            <asp:BoundField DataField="Nome" HeaderText="Nome" />
            <asp:BoundField DataField="Prioridade" HeaderText="Prioridade" />
            <asp:CheckBoxField DataField="Concluida" HeaderText="Concluída" >
            <ItemStyle HorizontalAlign="Center" />
            </asp:CheckBoxField>
            <asp:BoundField DataField="Observacoes" HeaderText="Observações" />
        </Columns>    
    </asp:GridView>
    <asp:ObjectDataSource ID="gridTarefasObjectDataSource" runat="server" SelectMethod="Selecionar" TypeName="Pessoal.Repositorios.SqlServer.TarefaRepositorio"></asp:ObjectDataSource>
</asp:Content>
