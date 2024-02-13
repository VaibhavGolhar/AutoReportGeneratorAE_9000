Imports MySql.Data.MySqlClient
Imports System.Data

Public Class DataGridViewForm
    Private mySqlConnection As MySqlConnection
    Private mySqlDataAdapter As MySqlDataAdapter
    Private mySqlCommandBuilder As MySqlCommandBuilder
    Private dataTable As DataTable
    Private bindingSource As BindingSource

    Private Sub DataGridViewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load data into the DataGridView when the form loads
        Bind()
    End Sub

    Public Sub Bind()
        mySqlConnection = New MySqlConnection("server=localhost;user id=root;password=vaibhav@2210;database=ae_9000;")
        mySqlConnection.Open()

        Dim query As String = "SELECT * FROM testing"

        mySqlDataAdapter = New MySqlDataAdapter(query, mySqlConnection)
        mySqlCommandBuilder = New MySqlCommandBuilder(mySqlDataAdapter)

        mySqlDataAdapter.UpdateCommand = mySqlCommandBuilder.GetUpdateCommand()
        mySqlDataAdapter.DeleteCommand = mySqlCommandBuilder.GetDeleteCommand()
        mySqlDataAdapter.InsertCommand = mySqlCommandBuilder.GetInsertCommand()

        dataTable = New DataTable()
        mySqlDataAdapter.Fill(dataTable)

        bindingSource = New BindingSource()
        bindingSource.DataSource = dataTable

        DataGridView1.DataSource = bindingSource
    End Sub

    Public ReadOnly Property Rows As DataRowCollection
        Get
            Return dataTable.Rows
        End Get
    End Property

    Public Sub Save()
        mySqlDataAdapter.Update(dataTable)
    End Sub
End Class
