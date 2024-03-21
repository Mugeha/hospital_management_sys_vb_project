<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fdoctorsform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fdoctorsform))
        ldocname = New Label()
        lphoneno = New Label()
        lemail = New Label()
        lrole = New Label()
        tmail = New TextBox()
        trole = New TextBox()
        tname = New TextBox()
        tno = New TextBox()
        lgender = New Label()
        male = New RadioButton()
        female = New RadioButton()
        btnenter = New Button()
        btnexit = New Button()
        doctorslist = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader7 = New ColumnHeader()
        Label1 = New Label()
        btnadd = New Button()
        btnclear = New Button()
        btndelete = New Button()
        btnsearch = New Button()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Label2 = New Label()
        tdoctorsnhsno = New TextBox()
        btnview = New Button()
        Button2 = New Button()
        tsearch = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' ldocname
        ' 
        ldocname.AutoSize = True
        ldocname.BackColor = Color.Transparent
        ldocname.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ldocname.ForeColor = SystemColors.Window
        ldocname.Location = New Point(41, 74)
        ldocname.Name = "ldocname"
        ldocname.Size = New Size(49, 20)
        ldocname.TabIndex = 0
        ldocname.Text = "Name"
        ' 
        ' lphoneno
        ' 
        lphoneno.AutoSize = True
        lphoneno.BackColor = Color.Transparent
        lphoneno.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lphoneno.ForeColor = SystemColors.Window
        lphoneno.Location = New Point(41, 126)
        lphoneno.Name = "lphoneno"
        lphoneno.Size = New Size(71, 20)
        lphoneno.TabIndex = 1
        lphoneno.Text = "Phone no"
        ' 
        ' lemail
        ' 
        lemail.AutoSize = True
        lemail.BackColor = Color.Transparent
        lemail.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lemail.ForeColor = SystemColors.Window
        lemail.Location = New Point(41, 182)
        lemail.Name = "lemail"
        lemail.Size = New Size(52, 20)
        lemail.TabIndex = 2
        lemail.Text = "E-mail"
        ' 
        ' lrole
        ' 
        lrole.AutoSize = True
        lrole.BackColor = Color.Transparent
        lrole.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lrole.ForeColor = SystemColors.Window
        lrole.Location = New Point(41, 300)
        lrole.Name = "lrole"
        lrole.Size = New Size(39, 20)
        lrole.TabIndex = 4
        lrole.Text = "Role"
        ' 
        ' tmail
        ' 
        tmail.Location = New Point(130, 179)
        tmail.Name = "tmail"
        tmail.Size = New Size(120, 23)
        tmail.TabIndex = 5
        ' 
        ' trole
        ' 
        trole.Location = New Point(130, 301)
        trole.Name = "trole"
        trole.Size = New Size(120, 23)
        trole.TabIndex = 6
        ' 
        ' tname
        ' 
        tname.Location = New Point(140, 74)
        tname.Name = "tname"
        tname.Size = New Size(120, 23)
        tname.TabIndex = 7
        ' 
        ' tno
        ' 
        tno.Location = New Point(147, 126)
        tno.Name = "tno"
        tno.Size = New Size(113, 23)
        tno.TabIndex = 8
        ' 
        ' lgender
        ' 
        lgender.AutoSize = True
        lgender.BackColor = Color.Transparent
        lgender.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lgender.ForeColor = SystemColors.Window
        lgender.Location = New Point(55, 376)
        lgender.Name = "lgender"
        lgender.Size = New Size(57, 20)
        lgender.TabIndex = 10
        lgender.Text = "Gender"
        ' 
        ' male
        ' 
        male.AutoSize = True
        male.BackColor = Color.Transparent
        male.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        male.ForeColor = SystemColors.Window
        male.Location = New Point(140, 376)
        male.Name = "male"
        male.Size = New Size(60, 24)
        male.TabIndex = 11
        male.TabStop = True
        male.Text = "Male"
        male.UseVisualStyleBackColor = False
        ' 
        ' female
        ' 
        female.AutoSize = True
        female.BackColor = Color.Transparent
        female.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        female.ForeColor = SystemColors.Window
        female.Location = New Point(238, 376)
        female.Name = "female"
        female.Size = New Size(75, 24)
        female.TabIndex = 12
        female.TabStop = True
        female.Text = "Female"
        female.UseVisualStyleBackColor = False
        ' 
        ' btnenter
        ' 
        btnenter.BackColor = SystemColors.ActiveCaption
        btnenter.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnenter.Location = New Point(238, 426)
        btnenter.Name = "btnenter"
        btnenter.Size = New Size(75, 32)
        btnenter.TabIndex = 13
        btnenter.Text = "ENTER"
        btnenter.UseVisualStyleBackColor = False
        ' 
        ' btnexit
        ' 
        btnexit.BackColor = SystemColors.ActiveCaption
        btnexit.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnexit.Location = New Point(326, 426)
        btnexit.Name = "btnexit"
        btnexit.Size = New Size(75, 32)
        btnexit.TabIndex = 14
        btnexit.Text = "EXIT"
        btnexit.UseVisualStyleBackColor = False
        ' 
        ' doctorslist
        ' 
        doctorslist.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader5, ColumnHeader6, ColumnHeader7})
        doctorslist.GridLines = True
        doctorslist.Location = New Point(340, 74)
        doctorslist.Name = "doctorslist"
        doctorslist.Size = New Size(501, 326)
        doctorslist.TabIndex = 15
        doctorslist.UseCompatibleStateImageBehavior = False
        doctorslist.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Name"
        ColumnHeader1.Width = 80
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Phone No"
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "emailAddress"
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Role"
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Gender"
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.Text = "Doctor's NHS No"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Window
        Label1.Location = New Point(349, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(235, 45)
        Label1.TabIndex = 16
        Label1.Text = "Doctors' Form"
        ' 
        ' btnadd
        ' 
        btnadd.BackColor = SystemColors.ActiveCaption
        btnadd.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnadd.Location = New Point(55, 426)
        btnadd.Name = "btnadd"
        btnadd.Size = New Size(75, 32)
        btnadd.TabIndex = 17
        btnadd.Text = "ADD"
        btnadd.UseVisualStyleBackColor = False
        ' 
        ' btnclear
        ' 
        btnclear.BackColor = SystemColors.ActiveCaption
        btnclear.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnclear.Location = New Point(147, 426)
        btnclear.Name = "btnclear"
        btnclear.Size = New Size(75, 32)
        btnclear.TabIndex = 18
        btnclear.Text = "CLEAR"
        btnclear.UseVisualStyleBackColor = False
        ' 
        ' btndelete
        ' 
        btndelete.BackColor = SystemColors.ActiveCaption
        btndelete.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btndelete.Location = New Point(407, 426)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(75, 32)
        btndelete.TabIndex = 19
        btndelete.Text = "DELETE"
        btndelete.UseVisualStyleBackColor = False
        ' 
        ' btnsearch
        ' 
        btnsearch.BackColor = SystemColors.ActiveCaption
        btnsearch.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnsearch.Location = New Point(233, 338)
        btnsearch.Name = "btnsearch"
        btnsearch.Size = New Size(80, 32)
        btnsearch.TabIndex = 20
        btnsearch.Text = "SEARCH"
        btnsearch.UseVisualStyleBackColor = False
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.Window
        Label2.Location = New Point(41, 240)
        Label2.Name = "Label2"
        Label2.Size = New Size(122, 20)
        Label2.TabIndex = 21
        Label2.Text = "Doctor's NHS No"
        ' 
        ' tdoctorsnhsno
        ' 
        tdoctorsnhsno.Location = New Point(192, 237)
        tdoctorsnhsno.Name = "tdoctorsnhsno"
        tdoctorsnhsno.Size = New Size(100, 23)
        tdoctorsnhsno.TabIndex = 22
        ' 
        ' btnview
        ' 
        btnview.BackColor = SystemColors.ActiveCaption
        btnview.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnview.Location = New Point(488, 426)
        btnview.Name = "btnview"
        btnview.Size = New Size(75, 32)
        btnview.TabIndex = 23
        btnview.Text = "VIEW"
        btnview.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ActiveCaption
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(569, 426)
        Button2.Name = "Button2"
        Button2.Size = New Size(65, 32)
        Button2.TabIndex = 24
        Button2.Text = "EDIT"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' tsearch
        ' 
        tsearch.Location = New Point(41, 338)
        tsearch.Name = "tsearch"
        tsearch.Size = New Size(181, 23)
        tsearch.TabIndex = 25
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(640, 426)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 32)
        Button1.TabIndex = 26
        Button1.Text = "UPDATE"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' fdoctorsform
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(886, 537)
        Controls.Add(Button1)
        Controls.Add(tsearch)
        Controls.Add(Button2)
        Controls.Add(btnview)
        Controls.Add(tdoctorsnhsno)
        Controls.Add(Label2)
        Controls.Add(btnsearch)
        Controls.Add(btndelete)
        Controls.Add(btnclear)
        Controls.Add(btnadd)
        Controls.Add(Label1)
        Controls.Add(doctorslist)
        Controls.Add(btnexit)
        Controls.Add(btnenter)
        Controls.Add(female)
        Controls.Add(male)
        Controls.Add(lgender)
        Controls.Add(tno)
        Controls.Add(tname)
        Controls.Add(trole)
        Controls.Add(tmail)
        Controls.Add(lrole)
        Controls.Add(lemail)
        Controls.Add(lphoneno)
        Controls.Add(ldocname)
        Name = "fdoctorsform"
        Text = "fDoc"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ldocname As Label
    Friend WithEvents lphoneno As Label
    Friend WithEvents lemail As Label
    Friend WithEvents lemployeeno As Label
    Friend WithEvents lrole As Label
    Friend WithEvents tmail As TextBox
    Friend WithEvents trole As TextBox
    Friend WithEvents tname As TextBox
    Friend WithEvents tno As TextBox
    Friend WithEvents temployeeno As TextBox
    Friend WithEvents lgender As Label
    Friend WithEvents male As RadioButton
    Friend WithEvents female As RadioButton
    Friend WithEvents btnenter As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents doctorslist As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnadd As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents btndelete As Button
    Friend WithEvents btnsearch As Button
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents Label2 As Label
    Friend WithEvents tsearch As TextBox
    Friend WithEvents btnview As Button
    Friend WithEvents tdoctorsnhsno As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents Button1 As Button
End Class
