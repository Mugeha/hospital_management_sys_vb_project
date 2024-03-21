Imports System.Diagnostics.Metrics
Imports System.Net
Imports System.Security.Cryptography
Imports Microsoft.VisualBasic.Devices
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class fwardsform
    Function frefresh()
        twardid.Text = ""
        tpatientid.Text = ""
        tpatientsname.Text = ""
        male.Text = ""
        female.Text = ""
        If male.Checked Then
            male.Checked = False
        ElseIf female.Checked Then
            female.Checked = False
        End If
    End Function

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim gender As String

        If male.Checked Then
            gender = male.Text
        ElseIf female.Checked Then
            gender = female.Text
        Else
            MessageBox.Show("Please select gender")
            Return
        End If


        Dim row As New ListViewItem(tpatientid.Text)
        row.SubItems.Add(tpatientsname.Text)
        row.SubItems.Add(gender)
        wardslist.Items.Add(row)
        frefresh()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub btnenter_Click(sender As Object, e As EventArgs) Handles btnenter.Click
        Dim connectionString As String = "Server=localhost;Port=3306;Database=hospitalmanagementsystem;Uid=root;Pwd='';"

        ' Loop through each row in the ListView
        For Each item As ListViewItem In wardslist.Items

            ' SQL query to insert data into the database
            Dim query As String = "INSERT INTO `wards`(`patientsName`, `patientsId`, `gender`, `wardId`) VALUES (@val1,@val2,@val3,@val4)"

            ' Open a connection to the database
            Using connection As New MySqlConnection(connectionString)
                ' Open the connection
                connection.Open()

                ' Create a command with parameters
                Using command As New MySqlCommand(query, connection)
                    ' Add parameters to the command


                    command.Parameters.AddWithValue("@val1", item.SubItems(1).Text)
                    command.Parameters.AddWithValue("@val2", item.SubItems(0).Text)
                    command.Parameters.AddWithValue("@val3", item.SubItems(2).Text)
                    command.Parameters.AddWithValue("@val4", item.SubItems(3).Text)
                    ' Execute the command
                    command.ExecuteNonQuery()
                End Using
                connection.Close()
            End Using
        Next

        MessageBox.Show("Data inserted successfully.")

    End Sub

    Private Sub wardslist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles wardslist.SelectedIndexChanged

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        wardslist.Items.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnview.Click
        Dim connectionString As String = "Server=localhost;Port=3306;Database=hospitalmanagementsystem;Uid=root;Pwd='';"


        ' Clear the listview before populating it with new data
        wardslist.Items.Clear()

        ' Retrieve data from the database
        Dim query As String = "SELECT * FROM wards"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()

                ' Loop through the data and add it to the listview
                While reader.Read()

                    Dim item As New ListViewItem(reader("patientsId").ToString())
                    item.SubItems.Add(reader("patientsName").ToString())
                    item.SubItems.Add(reader("gender").ToString())
                    item.SubItems.Add(reader("wardId").ToString())
                    ' Add more subitems as needed for additional columns

                    wardslist.Items.Add(item)
                End While

                reader.Close()
            End Using
        End Using
    End Sub

End Class