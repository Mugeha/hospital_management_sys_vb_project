Imports System.Globalization
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports MySql.Data.MySqlClient

Public Class Form1


    Private Sub tusername_TextChanged(sender As Object, e As EventArgs) Handles tusername.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click


        Dim username As String = tusername.Text
        Dim password As String = tpassword.Text

        'Check credentials against the database
        If CheckCredentials(username, password) Then
            'Open the mainform

            Form8.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password. Please Try again.")
        End If
    End Sub

    Function CheckCredentials(username As String, password As String) As Boolean
        Dim connectionString As String = "Server=localhost;Port=3306;Database=hospitalmanagementsystem;Uid=root;Pwd='';"
        Dim query As String = "SELECT COUNT(*) FROM users WHERE userName = @username AND pwd = @password"

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@password", password)

                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                Return count > 0
            End Using
        End Using
    End Function


    Private Sub btnpassword_Click(sender As Object, e As EventArgs) Handles btnpassword.Click

    End Sub

    Private Sub tpassword_TextChanged(sender As Object, e As EventArgs) Handles tpassword.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then

            tpassword.UseSystemPasswordChar = False
        Else
            tpassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
End Class
