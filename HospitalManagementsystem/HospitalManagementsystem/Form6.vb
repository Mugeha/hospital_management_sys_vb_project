Imports Microsoft.VisualBasic.Devices
Imports MySql.Data.MySqlClient
Imports System.Diagnostics.Metrics
Imports System.Globalization
Imports System.Net
Imports System.Text.RegularExpressions

Public Class fpharmacyform

    Function frefresh()
        tname.Text = ""
        tpatientsid.Text = ""
        tdosage.Text = ""
        tmedicine.Text = ""
        'tdate.ResetText()
        tadministration.Text = ""
    End Function
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lpatientsname.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles ldosage.Click

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        pharmacylist.Items.Clear()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim row As New ListViewItem(tname.Text)
        row.SubItems.Add(tmedicine.Text)
        row.SubItems.Add(tdateissued.Value)
        row.SubItems.Add(tdosage.Text)
        row.SubItems.Add(tadministration.Text)
        row.SubItems.Add(tpatientsid.Text)
        pharmacylist.Items.Add(row)
        frefresh()
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
            MessageBox.Show("Invalid date or time components")
        End Try
    End Function




    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim connectionString As String = "Server=localhost;Port=3306;Database=hospitalmanagementsystem;Uid=root;Pwd='';"

        ' Loop through each row in the ListView
        For Each item As ListViewItem In pharmacylist.Items

            ' SQL query to insert data into the database
            Dim query As String = "INSERT INTO `pharmacy`(`patientId`,  `administration`,  `nameOfTablets`, `dosageMg`, `dateIssued`, `patientsName`) VALUES (@val1,@val2,@val3,@val4,@val5,@val6)"

            ' Open a connection to the database
            Using connection As New MySqlConnection(connectionString)
                ' Open the connection
                connection.Open()
                Dim selectedDate As DateTime = ConvertVdTextToMySqlDatetime(item.SubItems(2).Text)
                Dim finaldate = selectedDate.Year & "-" & selectedDate.Month & "-" & selectedDate.Day & " " & selectedDate.Hour & ":" & selectedDate.Minute & ":" & selectedDate.Second



                ' Create a command with parameters
                Using command As New MySqlCommand(query, connection)
                    ' Add parameters to the command
                    command.Parameters.AddWithValue("@val1", item.SubItems(5).Text)
                    command.Parameters.AddWithValue("@val2", item.SubItems(4).Text)
                    command.Parameters.AddWithValue("@val4", item.SubItems(3).Text)
                    command.Parameters.AddWithValue("@val3", item.SubItems(1).Text)

                    ' Convert the date string to MySQL datetime format "yyyy-MM-dd"

                    command.Parameters.AddWithValue("@val5", finaldate)

                    command.Parameters.AddWithValue("@val6", item.SubItems(0).Text)

                    ' Execute the command
                    command.ExecuteNonQuery()
                End Using
                connection.Close()
            End Using
        Next

        MessageBox.Show("Data inserted successfully.")
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub pharmacylist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pharmacylist.SelectedIndexChanged

    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click, btnview.Click
        Dim connectionString = "Server=localhost;Port=3306;Database=hospitalmanagementsystem;Uid=root;Pwd='';"


        ' Clear the listview before populating it with new data
        pharmacylist.Items.Clear()

        ' Retrieve data from the database
        Dim query = "SELECT * FROM pharmacy"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Dim reader = command.ExecuteReader

                ' Loop through the data and add it to the listview
                While reader.Read

                    Dim item As New ListViewItem(reader("patientsName").ToString)
                    item.SubItems.Add(reader("nameOfTablets").ToString)
                    item.SubItems.Add(reader("dateIssued").ToString)
                    item.SubItems.Add(reader("dosageMg").ToString)
                    item.SubItems.Add(reader("administration").ToString)
                    item.SubItems.Add(reader("patientId").ToString)
                    ' Add more subitems as needed for additional columns

                    pharmacylist.Items.Add(item)
                End While

                reader.Close()
            End Using
        End Using
    End Sub
End Class