<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel2 = New Panel()
        btncancel = New Button()
        PictureBox1 = New PictureBox()
        CheckBox1 = New CheckBox()
        btnlogin = New Button()
        btnpassword = New Label()
        btnusername = New Label()
        tpassword = New TextBox()
        tusername = New TextBox()
        Label9 = New Label()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.InactiveCaption
        Panel2.BackgroundImageLayout = ImageLayout.Center
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(btncancel)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(CheckBox1)
        Panel2.Controls.Add(btnlogin)
        Panel2.Controls.Add(btnpassword)
        Panel2.Controls.Add(btnusername)
        Panel2.Controls.Add(tpassword)
        Panel2.Controls.Add(tusername)
        Panel2.Location = New Point(188, 167)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(535, 277)
        Panel2.TabIndex = 1
        ' 
        ' btncancel
        ' 
        btncancel.BackgroundImage = CType(resources.GetObject("btncancel.BackgroundImage"), Image)
        btncancel.BackgroundImageLayout = ImageLayout.Center
        btncancel.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btncancel.Location = New Point(380, 202)
        btncancel.Name = "btncancel"
        btncancel.Size = New Size(102, 37)
        btncancel.TabIndex = 19
        btncancel.Text = "CANCEL"
        btncancel.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.GradientActiveCaption
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Location = New Point(28, 40)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(169, 199)
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(331, 165)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(108, 19)
        CheckBox1.TabIndex = 17
        CheckBox1.Text = "Show password"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' btnlogin
        ' 
        btnlogin.BackgroundImage = CType(resources.GetObject("btnlogin.BackgroundImage"), Image)
        btnlogin.BackgroundImageLayout = ImageLayout.Center
        btnlogin.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnlogin.Location = New Point(254, 202)
        btnlogin.Name = "btnlogin"
        btnlogin.Size = New Size(102, 37)
        btnlogin.TabIndex = 16
        btnlogin.Text = "LOG IN"
        btnlogin.UseVisualStyleBackColor = True
        ' 
        ' btnpassword
        ' 
        btnpassword.AutoSize = True
        btnpassword.Font = New Font("Tahoma", 9F, FontStyle.Bold)
        btnpassword.Location = New Point(221, 117)
        btnpassword.Name = "btnpassword"
        btnpassword.Size = New Size(66, 14)
        btnpassword.TabIndex = 15
        btnpassword.Text = "Password"
        ' 
        ' btnusername
        ' 
        btnusername.AutoSize = True
        btnusername.Font = New Font("Tahoma", 9F, FontStyle.Bold)
        btnusername.Location = New Point(221, 55)
        btnusername.Name = "btnusername"
        btnusername.Size = New Size(66, 14)
        btnusername.TabIndex = 14
        btnusername.Text = "Username"
        ' 
        ' tpassword
        ' 
        tpassword.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tpassword.Location = New Point(331, 117)
        tpassword.Name = "tpassword"
        tpassword.Size = New Size(171, 22)
        tpassword.TabIndex = 13
        tpassword.UseSystemPasswordChar = True
        ' 
        ' tusername
        ' 
        tusername.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tusername.Location = New Point(331, 52)
        tusername.Name = "tusername"
        tusername.Size = New Size(171, 22)
        tusername.TabIndex = 12
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Tahoma", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(100, 43)
        Label9.Name = "Label9"
        Label9.Size = New Size(747, 58)
        Label9.TabIndex = 16
        Label9.Text = "Hospital Management System"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkGray
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(907, 534)
        Controls.Add(Label9)
        Controls.Add(Panel2)
        Name = "Form1"
        Text = "Form1"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents btnpassword As Label
    Friend WithEvents btnusername As Label
    Friend WithEvents tpassword As TextBox
    Friend WithEvents tusername As TextBox
    Friend WithEvents btnlogin As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btncancel As Button

End Class
