Imports System.Diagnostics.Metrics
Imports System.Net
Imports Microsoft.VisualBasic.Devices
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports Google.Protobuf.WellKnownTypes

Public Class fAppointmentsform
    Function frefresh()
        tappointmentsref.Text = ""
        tno.Text = ""
        tpatientsname.Text = ""
        tpatientsId.Text = ""
        tdate.ResetText()
        tdoctorsname.Text = ""
        tdoctorsNhsno.Text = ""
    End Function
    Private Sub lappointmentsref_Click(sender As Object, e As EventArgs) Handles lappointmentsref.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tappointmentsref.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles tno.TextChanged

    End Sub


    Private Sub ldoctorsname_Click(sender As Object, e As EventArgs) Handles ldoctorsname.Click

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles tdoctorsname.TextChanged

    End Sub

    Private Sub lpatientsnumber_Click(sender As Object, e As EventArgs) Handles lpatientsnumber.Click

    End Sub

    Private Sub fAppointmentsform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles tpatientsname.TextChanged

    End Sub

    Private Sub lbook_Click(sender As Object, e As EventArgs) Handles btnbook.Click
        Dim row As New ListViewItem(tno.Text)
        row.SubItems.Add(tpatientsname.Text)
        row.SubItems.Add(tpatientsId.Text)
        row.SubItems.Add(tdoctorsNhsno.Text)
        row.SubItems.Add(tdoctorsname.Text)
        row.SubItems.Add(tdate.Value)
        row.SubItems.Add(tappointmentsref.Text)
        listviewforappointments.Items.Add(row)
        frefresh()
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        listviewforappointments.Items.Clear()
    End Sub

    Private Sub lexit_Click(sender As Object, e As EventArgs) Handles lexit.Click
        Me.Close()
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



    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim connectionString = "Server=localhost;Port=3306;Database=hospitalmanagementsystem;Uid=root;Pwd='';"

        ' Loop through each row in the ListView
        For Each item As ListViewItem In listviewforappointments.Items

            ' SQL query to insert data into the database
            Dim query = "INSERT INTO `appointment`(`appointmentsRef`, `patientsNumber`, `patientsName`, `patientsId`, `doctorNHSno`, `doctorsName`, `DateOfAppointment`) VALUES (@val1,@val2,@val3,@val4,@val5,@val6,@val7)"

            ' Open a connection to the database
            Using connection As New MySqlConnection(connectionString)
                ' Open the connection
                connection.Open()


                ' Create a command with parameters
                Using command As New MySqlCommand(query, connection)
                    ' Add parameters to the command
                    Dim selectedDate As DateTime = ConvertVdTextToMySqlDatetime(item.SubItems(5).Text)
                    Dim finaldate = selectedDate.Year & "-" & selectedDate.Month & "-" & selectedDate.Day & " " & selectedDate.Hour & ":" & selectedDate.Minute & ":" & selectedDate.Second


                    MessageBox.Show(finaldate)

                    command.Parameters.AddWithValue("@val7", finaldate)
                    command.Parameters.AddWithValue("@val1", item.SubItems(6).Text)
                    command.Parameters.AddWithValue("@val2", item.SubItems(0).Text)
                    command.Parameters.AddWithValue("@val3", item.SubItems(1).Text)
                    command.Parameters.AddWithValue("@val4", item.SubItems(2).Text)
                    command.Parameters.AddWithValue("@val5", item.SubItems(3).Text)
                    command.Parameters.AddWithValue("@val6", item.SubItems(4).Text)

                    ' Execute the command
                    command.ExecuteNonQuery()
                End Using
                connection.Close()
            End Using
        Next

        MessageBox.Show("Data inserted successfully.")


    End Sub

    Private Sub listviewforappointments_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listviewforappointments.SelectedIndexChanged

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim connectionString As String = "Server=localhost;Port=3306;Database=hospitalmanagementsystem;Uid=root;Pwd='';"
        If listviewforappointments.SelectedItems.Count > 0 Then
            Dim itemId As String = listviewforappointments.SelectedItems(0).SubItems(0).Text

            Dim query As String = "DELETE FROM appointment WHERE appointmentsRef = @itemId"

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
            listviewforappointments.Items.Remove(listviewforappointments.SelectedItems(0))
        Else
            MessageBox.Show("Please select row")
        End If
    End Sub

    Private Sub btnview_Click(sender As Object, e As EventArgs) Handles btnview.Click
        Dim connectionString As String = "Server=localhost;Port=3306;Database=hospitalmanagementsystem;Uid=root;Pwd='';"


        ' Clear the listview before populating it with new data
        listviewforappointments.Items.Clear()

        ' Retrieve data from the database
        Dim query As String = "SELECT * FROM appointment"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()

                ' Loop through the data and add it to the listview
                While reader.Read()
                    Dim dateStr As String = reader("DateOfAppointment").ToString() ' Assuming DateOfAppointment is the column name
                    Dim appointmentDate As DateTime

                    ' Try parsing the date string using DateTime.TryParse
                    If DateTime.TryParse(dateStr, appointmentDate) Then
                        Dim item As New ListViewItem(reader("patientsNumber").ToString())
                        item.SubItems.Add(reader("patientsName").ToString())
                        item.SubItems.Add(reader("patientsId").ToString())
                        item.SubItems.Add(reader("doctorNHSno").ToString())
                        item.SubItems.Add(reader("doctorsName").ToString())
                        item.SubItems.Add(appointmentDate.ToString())
                        item.SubItems.Add(reader("appointmentsRef").ToString())
                        ' Add more subitems as needed for additional columns

                        listviewforappointments.Items.Add(item)
                    Else
                        ' Handle case where date parsing fails
                        MessageBox.Show("Unable to parse date string: " & dateStr)
                        ' You may want to log this error or handle it in another appropriate way
                    End If
                End While




                reader.Close()
            End Using
        End Using
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        ' Check if any item is selected in the ListView
        If listviewforappointments.SelectedItems.Count > 0 Then
            ' Get the selected item
            Dim selectedItem As ListViewItem = listviewforappointments.SelectedItems(0)

            ' Open the edit form and pass the selected item's details
            Dim editForm As New fAppointmentsform()
            editForm.tappointmentsref.Text = selectedItem.SubItems(6).Text
            editForm.tno.Text = selectedItem.SubItems(0).Text

            editForm.tpatientsname.Text = selectedItem.SubItems(1).Text
            editForm.tpatientsId.Text = selectedItem.SubItems(2).Text
            editForm.tdoctorsNhsno.Text = selectedItem.SubItems(3).Text
            editForm.tdoctorsname.Text = selectedItem.SubItems(4).Text ' Assuming TextBox1 is for the first column
            ' Assuming TextBox2 is for the second column
            editForm.tdate.Value = selectedItem.SubItems(5).Text



            ' Pass other details similarly as needed

            ' Show the edit form
            If editForm.ShowDialog() = DialogResult.OK Then
                ' Update the ListView with the edited details
                selectedItem.SubItems(6).Text = editForm.tappointmentsref.Text
                selectedItem.SubItems(0).Text = editForm.tno.Text
                ' Update first column
                selectedItem.SubItems(1).Text = editForm.tpatientsname.Text
                selectedItem.SubItems(2).Text = editForm.tpatientsId.Text
                selectedItem.SubItems(3).Text = editForm.tdoctorsNhsno.Text
                selectedItem.SubItems(4).Text = editForm.tdoctorsname.Text
                selectedItem.SubItems(5).Text = editForm.tdate.Value


                ' Update second column
                ' Update other columns similarly as needed
            End If
        Else
            MessageBox.Show("Please select an item to edit.")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles updatebtn.Click
        Dim connectionString As String = "Server=localhost;Port=3306;Database=hospitalmanagementsystem;Uid=root;Pwd='';"

        ' Loop through each row in the ListView
        For Each item As ListViewItem In listviewforappointments.Items

            ' SQL query to update data in the database based on email address
            Dim query As String = "UPDATE `appointment` SET `patientsNumber` = @val2, `patientsName` = @val3, `patientsId` = @val4, `doctorNHSno` = @val5, `doctorsName` = @val6, `DateOfAppointment` = @val7 WHERE `appointmentsRef` = @val1"

            ' Open a connection to the database
            Using connection As New MySqlConnection(connectionString)
                ' Open the connection
                connection.Open()
                ' Create a command with parameters
                Using command As New MySqlCommand(query, connection)
                    ' Add parameters to the command
                    command.Parameters.AddWithValue("@val1", item.SubItems(6).Text)
                    command.Parameters.AddWithValue("@val2", item.SubItems(0).Text)
                    command.Parameters.AddWithValue("@val3", item.SubItems(1).Text) ' Assuming email address is at index 2
                    command.Parameters.AddWithValue("@val4", item.SubItems(2).Text)
                    command.Parameters.AddWithValue("@val5", item.SubItems(3).Text)
                    command.Parameters.AddWithValue("@val6", item.SubItems(4).Text)
                    command.Parameters.AddWithValue("@val7", item.SubItems(5).Text)

                    ' Execute the command
                    command.ExecuteNonQuery()
                End Using
                connection.Close()
            End Using
        Next

        MessageBox.Show("Data updated successfully based on appointments ref.")
    End Sub

End Class