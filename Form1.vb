Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataIntoDataGridView()
    End Sub

    Private Sub LoadDataIntoDataGridView()
        ' Establish connection to MySQL database
        Dim connectionString As String = "server=localhost;user=root;database=ae_9000;password=vaibhav@2210"
        Dim connection As New MySqlConnection(connectionString)

        ' Query to retrieve data from MySQL database
        Dim query As String = "SELECT * FROM testing"
        Dim adapter As New MySqlDataAdapter(query, connection)

        ' Create a DataTable to hold the data
        Dim dataTable As New DataTable()

        ' Open connection
        connection.Open()

        ' Fill the DataTable with data from the database
        adapter.Fill(dataTable)

        ' Close connection
        connection.Close()

        ' Bind DataTable to DataGridView
        DataGridView1.DataSource = dataTable
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.SelectedRows.Count = 1 Then
            ' Populate input boxes with data from selected row
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            txtCnfgName.Text = selectedRow.Cells("TName").Value.ToString()
            Ur.Text = selectedRow.Cells("Ur").Value.ToString()
            Uy.Text = selectedRow.Cells("Uy").Value.ToString()
            Ub.Text = selectedRow.Cells("Ub").Value.ToString()
            Ir.Text = selectedRow.Cells("Ir").Value.ToString()
            Iy.Text = selectedRow.Cells("Iy").Value.ToString()
            Ib.Text = selectedRow.Cells("Ib").Value.ToString()
            UI.Text = selectedRow.Cells("UI").Value.ToString()
            F.Text = selectedRow.Cells("F").Value.ToString()

            ' Enable and show the Update button, and disable the Add button
            button_Update.Enabled = True
            button_Update.Visible = True
            button_Update.Cursor = Cursors.Hand
            button_Delete.Enabled = True
            button_Delete.Visible = True
            button_Delete.Cursor = Cursors.Hand
            btnAdd.Enabled = False
            btnAdd.Visible = False
        ElseIf DataGridView1.SelectedRows.Count > 1 Then
            txtCnfgName.Clear()
            Ur.Clear()
            Uy.Clear()
            Ub.Clear()
            Ir.Clear()
            Iy.Clear()
            Ib.Clear()
            UI.Clear()
            F.Clear()
            ' Disable and hide the Update button, and disable the Add button
            button_Update.Enabled = False
            button_Update.Cursor = Cursors.No
            btnAdd.Enabled = False
            btnAdd.Visible = False
        Else
            ' Clear input boxes if no row is selected
            txtCnfgName.Clear()
            Ur.Clear()
            Uy.Clear()
            Ub.Clear()
            Ir.Clear()
            Iy.Clear()
            Ib.Clear()
            UI.Clear()
            F.Clear()

            ' Disable and hide the Update button, and enable the Add button
            button_Update.Enabled = False
            button_Update.Visible = False
            button_Delete.Enabled = False
            button_Delete.Visible = False
            button_Update.Cursor = Cursors.Default
            btnAdd.Enabled = True
            btnAdd.Visible = True
        End If
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Not ValidateInputs() Then
            Return
        End If

        ' Insert data into database
        Dim connectionString As String = "server=localhost;user id=root;password=vaibhav@2210;database=ae_9000;"

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Dim query As String = "INSERT INTO testing(TName, Ur, Uy, Ub, Ir, Iy, Ib, UI, F) VALUES (@Cnfg_Name, @R_Voltage, @Y_Voltage, @B_Voltage, @R_Current, @Y_Current, @B_Current, @Phase_Angle, @Frequency)"

            Using cmd As New MySqlCommand(query, connection)
                Dim configName As String = txtCnfgName.Text.Trim().ToUpper()

                cmd.Parameters.AddWithValue("@Cnfg_Name", configName)
                cmd.Parameters.AddWithValue("@R_Voltage", Ur.Text) ' Access text from RichTextBox
                cmd.Parameters.AddWithValue("@Y_Voltage", Uy.Text) ' Access text from RichTextBox
                cmd.Parameters.AddWithValue("@B_Voltage", Ub.Text) ' Access text from RichTextBox
                cmd.Parameters.AddWithValue("@R_Current", Ir.Text) ' Access text from RichTextBox
                cmd.Parameters.AddWithValue("@Y_Current", Iy.Text) ' Access text from RichTextBox
                cmd.Parameters.AddWithValue("@B_Current", Ib.Text) ' Access text from RichTextBox
                cmd.Parameters.AddWithValue("@Phase_Angle", UI.Text) ' Access text from RichTextBox
                cmd.Parameters.AddWithValue("@Frequency", F.Text) ' Access text from RichTextBox

                cmd.ExecuteNonQuery()

                MsgBox("Values Inserted")
            End Using
        End Using

        ' Refresh DataGridView with updated data
        LoadDataIntoDataGridView()
    End Sub

    Private Sub button_Update_Click(sender As Object, e As EventArgs) Handles button_Update.Click
        If Not ValidateInputs() Then
            Return
        End If

        If DataGridView1.SelectedRows.Count <> 1 Then
            MsgBox("Please select a single row to update.")
            Return
        End If

        ' Get the Sr. No. of the selected row
        Dim selectedSrNo As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("Sr_No").Value)

        ' Update data in the database
        Dim connectionString As String = "server=localhost;user id=root;password=vaibhav@2210;database=ae_9000;"

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Dim query As String = "UPDATE testing SET TName = @Cnfg_Name, Ur = @R_Voltage, Uy = @Y_Voltage, Ub = @B_Voltage, Ir = @R_Current, Iy = @Y_Current, Ib = @B_Current, UI = @Phase_Angle, F = @Frequency WHERE Sr_No = @SrNo"

            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@Cnfg_Name", txtCnfgName.Text.Trim().ToUpper())
                cmd.Parameters.AddWithValue("@R_Voltage", Ur.Text)
                cmd.Parameters.AddWithValue("@Y_Voltage", Uy.Text)
                cmd.Parameters.AddWithValue("@B_Voltage", Ub.Text)
                cmd.Parameters.AddWithValue("@R_Current", Ir.Text)
                cmd.Parameters.AddWithValue("@Y_Current", Iy.Text)
                cmd.Parameters.AddWithValue("@B_Current", Ib.Text)
                cmd.Parameters.AddWithValue("@Phase_Angle", UI.Text)
                cmd.Parameters.AddWithValue("@Frequency", F.Text)
                cmd.Parameters.AddWithValue("@SrNo", selectedSrNo)

                cmd.ExecuteNonQuery()

                MsgBox("Values Updated")
            End Using
        End Using

        ' Refresh DataGridView with updated data
        LoadDataIntoDataGridView()
    End Sub

    Private Sub button_Delete_Click(sender As Object, e As EventArgs) Handles button_Delete.Click
        ' Check if any rows are selected
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Prompt the user to confirm deletion
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected row(s)?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' Delete selected rows
                Dim connectionString As String = "server=localhost;user id=root;password=vaibhav@2210;database=ae_9000;"

                Using connection As New MySqlConnection(connectionString)
                    connection.Open()

                    For Each row As DataGridViewRow In DataGridView1.SelectedRows
                        ' Retrieve the ID of the selected row (assuming it's in the first column)
                        Dim id As Integer = Convert.ToInt32(row.Cells(0).Value)

                        ' Construct the DELETE query
                        Dim query As String = "DELETE FROM testing WHERE Sr_No = @ID"

                        ' Execute the query
                        Using cmd As New MySqlCommand(query, connection)
                            cmd.Parameters.AddWithValue("@ID", id)
                            cmd.ExecuteNonQuery()
                        End Using
                    Next


                    ' Refresh DataGridView with updated data
                    LoadDataIntoDataGridView()

                    MessageBox.Show("Selected row(s) deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End If
        Else
            MessageBox.Show("No rows selected for deletion.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Function ValidateInputs() As Boolean
        Dim configName As String = txtCnfgName.Text.Trim().ToUpper()

        If configName <> "AUTOMATIC" AndAlso configName <> "MANUAL" Then
            MessageBox.Show("Wrong configuration name entered. Please enter 'AUTOMATIC' or 'MANUAL'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCnfgName.Focus()
            txtCnfgName.SelectAll()
            Return False
        End If

        Dim inputRichTextBoxes As Dictionary(Of RichTextBox, String) = New Dictionary(Of RichTextBox, String) From {
        {Ur, "R_Voltage"},
        {Uy, "Y_Voltage"},
        {Ub, "B_Voltage"},
        {Ir, "R_Current"},
        {Iy, "Y_Current"},
        {Ib, "B_Current"},
        {UI, "Phase_Angle"},
        {F, "Frequency"}
        }

        For Each pair As KeyValuePair(Of RichTextBox, String) In inputRichTextBoxes
            Dim inputRichTextBox As RichTextBox = pair.Key
            Dim inputValue As String = inputRichTextBox.Text.Trim()

            ' Skip symbol check for empty input
            If String.IsNullOrWhiteSpace(inputValue) Then
                Continue For
            End If

            ' Define regex pattern to match only decimal numbers
            Dim regexPattern As String = "^[+-]?\d*\.?\d*$"

            If Not Regex.IsMatch(inputValue, regexPattern) Then
                MessageBox.Show($"Please enter a valid number in the {pair.Value} field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                inputRichTextBox.Focus()
                inputRichTextBox.SelectAll()
                Return False
            End If
        Next

        Return True
    End Function
End Class
