Imports MySql.Data.MySqlClient

Public Class fpaymentsform

    Function frefresh()
        tname.Text = ""
        tid.Text = ""
        ttotalamount.Text = ""
        tphoneno.Text = ""
        combo.Text = ""
        tamountpaid.Text = ""
        tbalance.Text = ""
    End Function
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tid.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles tamountpaid.TextChanged

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles paymentslist.SelectedIndexChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles tphoneno.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles tname.TextChanged

    End Sub

    Private Sub fpaymentsform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles ttotalamount.TextChanged

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        paymentslist.Items.Clear()
    End Sub

    Private Sub btnview_Click(sender As Object, e As EventArgs) Handles btnview.Click
        Dim connectionString As String = "Server=localhost;Port=3306;Database=hospitalmanagementsystem;Uid=root;Pwd='';"


        ' Clear the listview before populating it with new data
        paymentslist.Items.Clear()

        ' Retrieve data from the database
        Dim query As String = "SELECT * FROM payments"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()

                ' Loop through the data and add it to the listview
                While reader.Read()

                    Dim item As New ListViewItem(reader("patientsName").ToString())
                    item.SubItems.Add(reader("phoneNo").ToString())
                    item.SubItems.Add(reader("methodOfPayment").ToString())
                    item.SubItems.Add(reader("totalamount").ToString())
                    item.SubItems.Add(reader("amountPaid").ToString())
                    item.SubItems.Add(reader("balance").ToString())
                    item.SubItems.Add(reader("patientId").ToString())
                    ' Add more subitems as needed for additional columns

                    paymentslist.Items.Add(item)
                End While

                reader.Close()
            End Using
        End Using
    End Sub

    Private Sub btnenter_Click(sender As Object, e As EventArgs) Handles btnenter.Click
        Dim connectionString As String = "Server=localhost;Port=3306;Database=hospitalmanagementsystem;Uid=root;Pwd='';"


        ' Loop through each row in the ListView
        For Each item As ListViewItem In paymentslist.Items

            ' SQL query to insert data into the database
            Dim query As String = "INSERT INTO `payments`(`patientsName`, `phoneNo`, `methodOfPayment`, `totalamount`, `amountPaid`, `balance`, `patientId`) VALUES (@val1,@val2,@val3,@val4,@val5,@val6,@val7)"


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
                    command.Parameters.AddWithValue("@val7", item.SubItems(6).Text)
                    ' Execute the command
                    command.ExecuteNonQuery()
                End Using
                connection.Close()
            End Using
        Next

        MessageBox.Show("Data inserted successfully.")

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim row As New ListViewItem(tname.Text)
        row.SubItems.Add(tphoneno.Text)
        row.SubItems.Add(combo.Text)
        row.SubItems.Add(ttotalamount.Text)
        row.SubItems.Add(tamountpaid.Text)


        row.SubItems.Add(tbalance.Text)
        row.SubItems.Add(tid.Text)
        paymentslist.Items.Add(row)
        frefresh()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub
End Class