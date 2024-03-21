Imports Microsoft.VisualBasic.Devices
Imports MySql.Data.MySqlClient
Imports System.Diagnostics.Metrics
Imports System.Net
Imports System.Text.RegularExpressions

Public Class fpatientsform

    Function frefresh()
        tname.Text = ""
        tid.Text = ""
        taddress.Text = ""
        tphoneno.Text = ""
        twardno.Text = ""
        tdate.ResetText()
        tappointmentsno.Text = ""
        If male.Checked Then
            male.Checked = False
        ElseIf female.Checked Then
            female.Checked = False
        End If
    End Function

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim connectionString As String = "Server=localhost;Port=3306;Database=hospitalmanagementsystem;Uid=root;Pwd='';"
        If patientslist.SelectedItems.Count > 0 Then
            Dim itemId As String = patientslist.SelectedItems(0).SubItems(0).Text

            Dim query As String = "DELETE FROM patients WHERE patientsId = @itemId"

            ' Open a connection to the database
            Using connection As New MySqlConnection(connectionString)
                ' Open the connection
                connection.Open()
                ' Create a command with parameters
                Using command As New MySqlCommand(query, connection)
                    ' Add parameters to the command

                    command.Parameters.AddWithValue("@itemId", itemId)
                    ' Execute the command
                    command.ExecuteNonQuery()
                End Using
                connection.Close()
            End Using

            ' Remove the selected row from the listview
            patientslist.Items.Remove(patientslist.SelectedItems(0))
        Else
            MessageBox.Show("Please select row")
        End If
    End Sub

    Private Sub btnenter_Click(sender As Object, e As EventArgs) Handles btnenter.Click
        Dim gender As String

        If male.Checked Then
            gender = male.Text
        ElseIf female.Checked Then
            gender = female.Text
        Else
            MessageBox.Show("Please select gender")
            Return
        End If
        Dim row As New ListViewItem(tname.Text)
        row.SubItems.Add(tdate.Value)
        row.SubItems.Add(taddress.Text)
        row.SubItems.Add(tphoneno.Text)
        row.SubItems.Add(gender)
        row.SubItems.Add(twardno.Text)
        row.SubItems.Add(tappointmentsno.Text)
        row.SubItems.Add(tid.Text)
        patientslist.Items.Add(row)
        frefresh()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        patientslist.Items.Clear()
    End Sub

    Function ConvertVdTextToMySqlDatetime(vdText As String) As DateTime
        ' Splits the string into date and time components
        Dim dateParts() As String = vdText.Split(" ")

        ' Validate the input format
        If dateParts.Length <> 2 Then
            Throw New ArgumentException("Input string is not in the correct format (dd/mm/yyyy hh:mm:ss)")
        End If

        ' Convert date components to integers
        Dim dateComponents() As Integer = Array.ConvertAll(dateParts(0).Split("/"), Function(s) Integer.Parse(s))

        ' Convert time components to integers
        Dim timeComponents() As Integer = Array.ConvertAll(dateParts(1).Split(":"), Function(s) Integer.Parse(s))

        Try
            ' Create a datetime object
            Dim result As New DateTime(dateComponents(2), dateComponents(1), dateComponents(0),
                                   timeComponents(0), timeComponents(1), timeComponents(2))
            Return result
        Catch ex As Exception
            Throw New ArgumentException("Invalid date or time components")
        End Try
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click, btnentertodb.Click
        Dim connectionString = "Server=localhost;Port=3306;Database=hospitalmanagementsystem;Uid=root;Pwd='';"

        ' Loop through each row in the ListView
        For Each item As ListViewItem In patientslist.Items

            ' SQL query to insert data into the database
            Dim query = "INSERT INTO `patients`(`patientsId`, `name`, `dateOfBirth`, `address`, `mobileNo`, `wardNo`, `appointmentsNo`, `gender`) VALUES (@val1,@val2,@val3,@val4,@val5,@val6,@val7,@val8)"

            ' Open a connection to the database
            Using connection As New MySqlConnection(connectionString)
                ' Open the connection
                connection.Open()

                ' Create a command with parameters
                Using command As New MySqlCommand(query, connection)
                    ' Add parameters to the command
                    Dim selectedDate = ConvertVdTextToMySqlDatetime(item.SubItems(1).Text)
                    Dim finaldate = selectedDate.Year & "-" & selectedDate.Month & "-" & selectedDate.Day & " " & selectedDate.Hour & ":" & selectedDate.Minute & ":" & selectedDate.Second



                    command.Parameters.AddWithValue("@val8", item.SubItems(4).Text)
                    command.Parameters.AddWithValue("@val1", item.SubItems(7).Text)
                    command.Parameters.AddWithValue("@val2", item.SubItems(0).Text)
                    command.Parameters.AddWithValue("@val3", finaldate)
                    command.Parameters.AddWithValue("@val4", item.SubItems(2).Text)
                    command.Parameters.AddWithValue("@val5", item.SubItems(3).Text)
                    command.Parameters.AddWithValue("@val6", item.SubItems(5).Text)
                    command.Parameters.AddWithValue("@val7", item.SubItems(6).Text)
                    ' Execute the command
                    command.ExecuteNonQuery()
                End Using
                connection.Close()
            End Using
        Next

        MessageBox.Show("Data inserted successfully.")

    End Sub

    Private Sub tdate_ValueChanged(sender As Object, e As EventArgs) Handles tdate.ValueChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click, btnview.Click
        Dim connectionString = "Server=localhost;Port=3306;Database=hospitalmanagementsystem;Uid=root;Pwd='';"


        ' Clear the listview before populating it with new data
        patientslist.Items.Clear()

        ' Retrieve data from the database
        Dim query = "SELECT * FROM patients"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()

                ' Loop through the data and add it to the listview
                While reader.Read

                    Dim item As New ListViewItem(reader("name").ToString)
                    item.SubItems.Add(reader("dateOfBirth").ToString)
                    item.SubItems.Add(reader("address").ToString)
                    item.SubItems.Add(reader("mobileNo").ToString)
                    item.SubItems.Add(reader("gender").ToString)
                    item.SubItems.Add(reader("wardNo").ToString)
                    item.SubItems.Add(reader("appointmentsNo").ToString)
                    item.SubItems.Add(reader("patientsId").ToString)
                    ' Add more subitems as needed for additional columns

                    patientslist.Items.Add(item)
                End While

                reader.Close()
            End Using
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Check if any item is selected in the ListView
        If patientslist.SelectedItems.Count > 0 Then
            ' Get the selected item
            Dim selectedItem As ListViewItem = patientslist.SelectedItems(0)

            ' Open the edit form and pass the selected item's details
            Dim editForm As New fpatientsform()
            editForm.taddress.Text = selectedItem.SubItems(2).Text
            editForm.twardno.Text = selectedItem.SubItems(5).Text
            editForm.tappointmentsno.Text = selectedItem.SubItems(6).Text
            editForm.tname.Text = selectedItem.SubItems(0).Text
            editForm.tid.Text = selectedItem.SubItems(7).Text
            editForm.tphoneno.Text = selectedItem.SubItems(3).Text
            editForm.tdate.Text = selectedItem.SubItems(1).Text ' Assuming TextBox1 is for the first column
            ' Assuming TextBox2 is for the second column




            ' Pass other details similarly as needed

            ' Show the edit form
            If editForm.ShowDialog() = DialogResult.OK Then
                ' Update the ListView with the edited details
                selectedItem.SubItems(6).Text = editForm.tappointmentsno.Text
                selectedItem.SubItems(0).Text = editForm.tname.Text
                ' Update first column
                selectedItem.SubItems(1).Text = editForm.tdate.Value
                selectedItem.SubItems(2).Text = editForm.taddress.Text
                selectedItem.SubItems(3).Text = editForm.tphoneno.Text
                selectedItem.SubItems(7).Text = editForm.tid.Text
                selectedItem.SubItems(5).Text = editForm.twardno.Text


                ' Update second column
                ' Update other columns similarly as needed
            End If
        Else
            MessageBox.Show("Please select an item to edit.")
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnupdate.Click
        Dim connectionString As String = "Server=localhost;Port=3306;Database=hospitalmanagementsystem;Uid=root;Pwd='';"

        ' Loop through each row in the ListView
        For Each item As ListViewItem In patientslist.Items

            ' SQL query to update data in the database based on email address
            Dim query As String = "UPDATE `patients` SET `name` = @val2, `dateOfBirth` = @val3, `address` = @val4, `mobileNo` = @val5, `wardNo` = @val6, `appointmentsNo` = @val7 WHERE `patientsId` = @val1"

            ' Open a connection to the database
            Using connection As New MySqlConnection(connectionString)
                ' Open the connection
                connection.Open()
                ' Create a command with parameters
                Using command As New MySqlCommand(query, connection)
                    ' Add parameters to the command
                    command.Parameters.AddWithValue("@val1", item.SubItems(7).Text)
                    command.Parameters.AddWithValue("@val2", item.SubItems(0).Text)
                    command.Parameters.AddWithValue("@val3", item.SubItems(1).Text) ' Assuming email address is at index 2
                    command.Parameters.AddWithValue("@val4", item.SubItems(2).Text)
                    command.Parameters.AddWithValue("@val5", item.SubItems(3).Text)
                    command.Parameters.AddWithValue("@val6", item.SubItems(5).Text)
                    command.Parameters.AddWithValue("@val7", item.SubItems(6).Text)

                    ' Execute the command
                    command.ExecuteNonQuery()
                End Using
                connection.Close()
            End Using
        Next

        MessageBox.Show("Data updated successfully based on patients Id.")
    End Sub

End Class