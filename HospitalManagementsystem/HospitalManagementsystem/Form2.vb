Imports System.Diagnostics.Metrics
Imports System.Net
Imports System.Net.Mail
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.Devices
Imports MySql.Data.MySqlClient

Public Class fdoctorsform
    Function IsValidEmail(email As String) As Boolean
        Dim pattern As String = "^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"
        Dim regex As New Regex(pattern)
        Return regex.IsMatch(email)
    End Function
    Function frefresh()
        tname.Text = ""
        tno.Text = ""
        tmail.Text = ""
        trole.Text = ""
        tdoctorsnhsno.Text = ""

        If male.Checked Then
            male.Checked = False
        ElseIf female.Checked Then
            female.Checked = False
        End If
    End Function
    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles lgender.Click

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles female.CheckedChanged

    End Sub

    Private Sub ldocname_Click(sender As Object, e As EventArgs) Handles ldocname.Click

    End Sub

    Private Sub fdoctorsform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles tname.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim email As String = tmail.Text
        Dim gender As String

        If Not IsValidEmail(email) Then
            MessageBox.Show("Invalid email")
            tmail.Focus()
            Return
        End If
        If male.Checked Then
            gender = male.Text
        ElseIf female.Checked Then
            gender = female.Text
        Else
            MessageBox.Show("Please select gender")
            Return
        End If
        Dim row As New ListViewItem(tname.Text)
        row.SubItems.Add(tno.Text)
        row.SubItems.Add(tmail.Text)
        row.SubItems.Add(trole.Text)
        row.SubItems.Add(gender)
        row.SubItems.Add(tdoctorsnhsno.Text)
        doctorslist.Items.Add(row)
        frefresh()
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        doctorslist.Items.Clear()
    End Sub

    Private Sub doctorslist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles doctorslist.SelectedIndexChanged

    End Sub

    Private Sub btnenter_Click(sender As Object, e As EventArgs) Handles btnenter.Click
        Dim connectionString As String = "Server=localhost;Port=3306;Database=hospitalmanagementsystem;Uid=root;Pwd='';"

        ' Loop through each row in the ListView
        For Each item As ListViewItem In doctorslist.Items

            ' SQL query to insert data into the database
            Dim query As String = "INSERT INTO `doctors`(`name`, `mobileNo`, `emailAddress`,`role`,`gender`,`doctorNHSno`) VALUES (@val1,@val2,@val3,@val4,@val5,@val6)"

            ' Open a connection to the database
            Using connection As New MySqlConnection(connectionString)
                ' Open the connection
                connection.Open()
                ' Create a command with parameters
                Using command As New MySqlCommand(query, connection)
                    ' Add parameters to the command

                    command.Parameters.AddWithValue("@val1", item.SubItems(0).Text)
                    command.Parameters.AddWithValue("@val2", item.SubItems(1).Text)
                    command.Parameters.AddWithValue("@val3", item.SubItems(2).Text)
                    command.Parameters.AddWithValue("@val4", item.SubItems(3).Text)
                    command.Parameters.AddWithValue("@val5", item.SubItems(4).Text)
                    command.Parameters.AddWithValue("@val6", item.SubItems(5).Text)

                    ' Execute the command
                    command.ExecuteNonQuery()
                End Using
                connection.Close()
            End Using
        Next

        MessageBox.Show("Data inserted successfully.")
    End Sub

    Private Sub lemail_Click(sender As Object, e As EventArgs) Handles lemail.Click

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub lphoneno_Click(sender As Object, e As EventArgs) Handles lphoneno.Click

    End Sub

    Private Sub trole_TextChanged(sender As Object, e As EventArgs) Handles trole.TextChanged

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim connectionString As String = "Server=localhost;Port=3306;Database=hospitalmanagementsystem;Uid=root;Pwd='';"
        If doctorslist.SelectedItems.Count > 0 Then
            Dim itemId As String = doctorslist.SelectedItems(0).SubItems(0).Text

            Dim query As String = "DELETE FROM doctors WHERE idNo = @itemId"

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
            doctorslist.Items.Remove(doctorslist.SelectedItems(0))
        Else
            MessageBox.Show("Please select row")
        End If
    End Sub

    Private Sub btnview_Click(sender As Object, e As EventArgs) Handles btnview.Click
        Dim connectionString As String = "Server=localhost;Port=3306;Database=hospitalmanagementsystem;Uid=root;Pwd='';"


        ' Clear the listview before populating it with new data
        doctorslist.Items.Clear()

        ' Retrieve data from the database
        Dim query As String = "SELECT * FROM doctors"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()

                ' Loop through the data and add it to the listview
                While reader.Read()

                    Dim item As New ListViewItem(reader("Name").ToString())
                    item.SubItems.Add(reader("mobileNo").ToString())
                    item.SubItems.Add(reader("emailAddress").ToString())
                    item.SubItems.Add(reader("role").ToString())
                    item.SubItems.Add(reader("gender").ToString())
                    item.SubItems.Add(reader("doctorNHSno").ToString())
                    ' Add more subitems as needed for additional columns

                    doctorslist.Items.Add(item)
                End While

                reader.Close()
            End Using
        End Using
    End Sub
    Function fClear()
        tsearch.Text = ""

    End Function
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnsearch.Click
        Dim connectionString As String = "Server=localhost;Port=3306;Database=hospitalmanagementsystem;Uid=root;Pwd='';"
        ' Get the search keyword from the textbox
        Dim keyword As String = tsearch.Text.Trim()

        ' Clear the listview before populating it with new search results
        doctorslist.Items.Clear()

        ' Construct the SQL query with a WHERE clause to filter based on the search keyword
        Dim query As String = "SELECT * FROM doctors WHERE Name LIKE @keyword OR mobileNo LIKE @keyword OR emailAddress LIKE @keyword OR idNo LIKE @keyword OR role LIKE @keyword OR gender LIKE @keyword OR doctorNHSno LIKE @keyword"

        ' Execute the SQL query with the search keyword
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()

                ' Add the parameter for the search keyword
                command.Parameters.AddWithValue("@keyword", "%" & keyword & "%")

                Dim reader As MySqlDataReader = command.ExecuteReader()

                ' Loop through the data and add it to the listview
                While reader.Read()
                    Dim item As New ListViewItem(reader("Name").ToString())
                    item.SubItems.Add(reader("mobileNo").ToString())
                    item.SubItems.Add(reader("emailAddress").ToString())
                    item.SubItems.Add(reader("role").ToString())
                    item.SubItems.Add(reader("gender").ToString())
                    item.SubItems.Add(reader("doctorNHSno").ToString())
                    ' Add more subitems as needed for additional columns

                    doctorslist.Items.Add(item)
                End While

                reader.Close()
            End Using
        End Using
        fClear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Check if any item is selected in the ListView
        If doctorslist.SelectedItems.Count > 0 Then
            ' Get the selected item
            Dim selectedItem As ListViewItem = doctorslist.SelectedItems(0)

            ' Open the edit form and pass the selected item's details
            Dim editForm As New fdoctorsform()
            editForm.tname.Text = selectedItem.SubItems(0).Text ' Assuming TextBox1 is for the first column
            editForm.tno.Text = selectedItem.SubItems(1).Text ' Assuming TextBox2 is for the second column
            editForm.tmail.Text = selectedItem.SubItems(2).Text
            editForm.trole.Text = selectedItem.SubItems(3).Text
            editForm.tdoctorsnhsno.Text = selectedItem.SubItems(5).Text
            ' Pass other details similarly as needed

            ' Show the edit form
            If editForm.ShowDialog() = DialogResult.OK Then
                ' Update the ListView with the edited details
                selectedItem.SubItems(0).Text = editForm.tname.Text ' Update first column
                selectedItem.SubItems(1).Text = editForm.tno.Text
                selectedItem.SubItems(2).Text = editForm.tmail.Text
                selectedItem.SubItems(3).Text = editForm.trole.Text
                selectedItem.SubItems(5).Text = editForm.tdoctorsnhsno.Text

                ' Update second column
                ' Update other columns similarly as needed
            End If
        Else
            MessageBox.Show("Please select an item to edit.")
        End If
    End Sub

    Private Sub tno_TextChanged(sender As Object, e As EventArgs) Handles tno.TextChanged

    End Sub

    Private Sub tsearch_TextChanged(sender As Object, e As EventArgs) Handles tsearch.TextChanged
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connectionString As String = "Server=localhost;Port=3306;Database=hospitalmanagementsystem;Uid=root;Pwd='';"

        ' Loop through each row in the ListView
        For Each item As ListViewItem In doctorslist.Items

            ' SQL query to update data in the database based on email address
            Dim query As String = "UPDATE `doctors` SET `name` = @val1, `mobileNo` = @val2, `role` = @val4, `gender` = @val5, `doctorNHSno` = @val6 WHERE `emailAddress` = @val3"

            ' Open a connection to the database
            Using connection As New MySqlConnection(connectionString)
                ' Open the connection
                connection.Open()
                ' Create a command with parameters
                Using command As New MySqlCommand(query, connection)
                    ' Add parameters to the command
                    command.Parameters.AddWithValue("@val1", item.SubItems(0).Text)
                    command.Parameters.AddWithValue("@val2", item.SubItems(1).Text)
                    command.Parameters.AddWithValue("@val3", item.SubItems(2).Text) ' Assuming email address is at index 2
                    command.Parameters.AddWithValue("@val4", item.SubItems(3).Text)
                    command.Parameters.AddWithValue("@val5", item.SubItems(4).Text)
                    command.Parameters.AddWithValue("@val6", item.SubItems(5).Text)

                    ' Execute the command
                    command.ExecuteNonQuery()
                End Using
                connection.Close()
            End Using
        Next

        MessageBox.Show("Data updated successfully based on email address.")
    End Sub
End Class