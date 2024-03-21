<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fpatientsform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fpatientsform))
        fpatients = New Label()
        lname = New Label()
        lid = New Label()
        ldob = New Label()
        Label4 = New Label()
        Label5 = New Label()
        tname = New TextBox()
        tid = New TextBox()
        taddress = New TextBox()
        tphoneno = New TextBox()
        btnenter = New Button()
        btnexit = New Button()
        patientslist = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader7 = New ColumnHeader()
        ColumnHeader8 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        Label1 = New Label()
        Label2 = New Label()
        twardno = New TextBox()
        tappointmentsno = New TextBox()
        btndelete = New Button()
        tdate = New DateTimePicker()
        lgender = New Label()
        male = New RadioButton()
        female = New RadioButton()
        btnclear = New Button()
        btnentertodb = New Button()
        Button3 = New Button()
        btnview = New Button()
        btnupdate = New Button()
        SuspendLayout()
        ' 
        ' fpatients
        ' 
        fpatients.AutoSize = True
        fpatients.BackColor = Color.Transparent
        fpatients.Font = New Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        fpatients.Location = New Point(251, 9)
        fpatients.Name = "fpatients"
        fpatients.Size = New Size(205, 33)
        fpatients.TabIndex = 0
        fpatients.Text = "Patients Form"
        ' 
        ' lname
        ' 
        lname.AutoSize = True
        lname.BackColor = Color.Transparent
        lname.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lname.ForeColor = Color.Black
        lname.Location = New Point(30, 50)
        lname.Name = "lname"
        lname.Size = New Size(56, 21)
        lname.TabIndex = 1
        lname.Text = "Name"
        ' 
        ' lid
        ' 
        lid.AutoSize = True
        lid.BackColor = Color.Transparent
        lid.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lid.ForeColor = Color.Black
        lid.Location = New Point(28, 98)
        lid.Name = "lid"
        lid.Size = New Size(95, 21)
        lid.TabIndex = 2
        lid.Text = "Patient's Id"
        ' 
        ' ldob
        ' 
        ldob.AutoSize = True
        ldob.BackColor = Color.Transparent
        ldob.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        ldob.ForeColor = Color.Black
        ldob.Location = New Point(30, 147)
        ldob.Name = "ldob"
        ldob.Size = New Size(42, 21)
        ldob.TabIndex = 3
        ldob.Text = "DoB"
        ' 
        ' Label4
        ' 
        Label4.AccessibleName = "laddress"
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(30, 191)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 21)
        Label4.TabIndex = 4
        Label4.Text = "Address"
        ' 
        ' Label5
        ' 
        Label5.AccessibleName = "lphoneno"
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(28, 231)
        Label5.Name = "Label5"
        Label5.Size = New Size(86, 21)
        Label5.TabIndex = 5
        Label5.Text = "Phone No"
        ' 
        ' tname
        ' 
        tname.Location = New Point(150, 52)
        tname.Name = "tname"
        tname.Size = New Size(188, 23)
        tname.TabIndex = 6
        ' 
        ' tid
        ' 
        tid.Location = New Point(150, 96)
        tid.Name = "tid"
        tid.Size = New Size(188, 23)
        tid.TabIndex = 7
        ' 
        ' taddress
        ' 
        taddress.Location = New Point(144, 189)
        taddress.Name = "taddress"
        taddress.Size = New Size(179, 23)
        taddress.TabIndex = 9
        ' 
        ' tphoneno
        ' 
        tphoneno.Location = New Point(144, 231)
        tphoneno.Name = "tphoneno"
        tphoneno.Size = New Size(186, 23)
        tphoneno.TabIndex = 10
        ' 
        ' btnenter
        ' 
        btnenter.BackColor = SystemColors.GradientActiveCaption
        btnenter.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnenter.Location = New Point(39, 406)
        btnenter.Name = "btnenter"
        btnenter.Size = New Size(75, 32)
        btnenter.TabIndex = 11
        btnenter.Text = "ADD"
        btnenter.UseVisualStyleBackColor = False
        ' 
        ' btnexit
        ' 
        btnexit.BackColor = SystemColors.GradientActiveCaption
        btnexit.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnexit.Location = New Point(138, 406)
        btnexit.Name = "btnexit"
        btnexit.Size = New Size(75, 32)
        btnexit.TabIndex = 12
        btnexit.Text = "EXIT"
        btnexit.UseVisualStyleBackColor = False
        ' 
        ' patientslist
        ' 
        patientslist.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader6, ColumnHeader7, ColumnHeader8, ColumnHeader2})
        patientslist.GridLines = True
        patientslist.Location = New Point(369, 45)
        patientslist.Name = "patientslist"
        patientslist.Size = New Size(553, 367)
        patientslist.TabIndex = 13
        patientslist.UseCompatibleStateImageBehavior = False
        patientslist.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Name"
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "DoB"
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Address"
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Phone No"
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Gender"
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.Text = "Ward No"
        ' 
        ' ColumnHeader8
        ' 
        ColumnHeader8.Text = "Appointments No"
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Patient's Id"
        ' 
        ' Label1
        ' 
        Label1.AccessibleName = "lphoneno"
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(30, 321)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 21)
        Label1.TabIndex = 14
        Label1.Text = "Ward No"
        ' 
        ' Label2
        ' 
        Label2.AccessibleName = "lappointments"
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(28, 371)
        Label2.Name = "Label2"
        Label2.Size = New Size(146, 21)
        Label2.TabIndex = 15
        Label2.Text = "Appointments No"
        ' 
        ' twardno
        ' 
        twardno.Location = New Point(138, 319)
        twardno.Name = "twardno"
        twardno.Size = New Size(186, 23)
        twardno.TabIndex = 16
        ' 
        ' tappointmentsno
        ' 
        tappointmentsno.Location = New Point(180, 369)
        tappointmentsno.Name = "tappointmentsno"
        tappointmentsno.Size = New Size(144, 23)
        tappointmentsno.TabIndex = 17
        ' 
        ' btndelete
        ' 
        btndelete.BackColor = SystemColors.GradientActiveCaption
        btndelete.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btndelete.Location = New Point(242, 406)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(75, 32)
        btndelete.TabIndex = 18
        btndelete.Text = "DELETE"
        btndelete.UseVisualStyleBackColor = False
        ' 
        ' tdate
        ' 
        tdate.CustomFormat = "dd/mm/yyyy "
        tdate.Format = DateTimePickerFormat.Custom
        tdate.Location = New Point(138, 147)
        tdate.Name = "tdate"
        tdate.Size = New Size(200, 23)
        tdate.TabIndex = 19
        ' 
        ' lgender
        ' 
        lgender.AccessibleName = "lgender"
        lgender.AutoSize = True
        lgender.BackColor = Color.Transparent
        lgender.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lgender.ForeColor = Color.Black
        lgender.Location = New Point(30, 269)
        lgender.Name = "lgender"
        lgender.Size = New Size(65, 21)
        lgender.TabIndex = 20
        lgender.Text = "Gender"
        ' 
        ' male
        ' 
        male.AutoSize = True
        male.BackColor = Color.Transparent
        male.Location = New Point(144, 272)
        male.Name = "male"
        male.Size = New Size(51, 19)
        male.TabIndex = 21
        male.TabStop = True
        male.Text = "Male"
        male.UseVisualStyleBackColor = False
        ' 
        ' female
        ' 
        female.AutoSize = True
        female.Location = New Point(242, 272)
        female.Name = "female"
        female.Size = New Size(63, 19)
        female.TabIndex = 22
        female.TabStop = True
        female.Text = "Female"
        female.UseVisualStyleBackColor = True
        ' 
        ' btnclear
        ' 
        btnclear.BackColor = SystemColors.GradientActiveCaption
        btnclear.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnclear.Location = New Point(332, 406)
        btnclear.Name = "btnclear"
        btnclear.Size = New Size(75, 32)
        btnclear.TabIndex = 23
        btnclear.Text = "CLEAR"
        btnclear.UseVisualStyleBackColor = False
        ' 
        ' btnentertodb
        ' 
        btnentertodb.BackColor = SystemColors.GradientActiveCaption
        btnentertodb.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnentertodb.Location = New Point(424, 406)
        btnentertodb.Name = "btnentertodb"
        btnentertodb.Size = New Size(75, 32)
        btnentertodb.TabIndex = 24
        btnentertodb.Text = "ENTER"
        btnentertodb.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.GradientActiveCaption
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(519, 406)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 32)
        Button3.TabIndex = 25
        Button3.Text = "EDIT"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' btnview
        ' 
        btnview.BackColor = SystemColors.GradientActiveCaption
        btnview.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnview.Location = New Point(626, 418)
        btnview.Name = "btnview"
        btnview.Size = New Size(75, 32)
        btnview.TabIndex = 26
        btnview.Text = "VIEW"
        btnview.UseVisualStyleBackColor = False
        ' 
        ' btnupdate
        ' 
        btnupdate.BackColor = SystemColors.GradientActiveCaption
        btnupdate.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnupdate.Location = New Point(727, 406)
        btnupdate.Name = "btnupdate"
        btnupdate.Size = New Size(75, 32)
        btnupdate.TabIndex = 27
        btnupdate.Text = "UPDATE"
        btnupdate.UseVisualStyleBackColor = False
        ' 
        ' fpatientsform
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(934, 450)
        Controls.Add(btnupdate)
        Controls.Add(btnview)
        Controls.Add(Button3)
        Controls.Add(btnentertodb)
        Controls.Add(btnclear)
        Controls.Add(female)
        Controls.Add(male)
        Controls.Add(lgender)
        Controls.Add(tdate)
        Controls.Add(btndelete)
        Controls.Add(tappointmentsno)
        Controls.Add(twardno)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(patientslist)
        Controls.Add(btnexit)
        Controls.Add(btnenter)
        Controls.Add(tphoneno)
        Controls.Add(taddress)
        Controls.Add(tid)
        Controls.Add(tname)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(ldob)
        Controls.Add(lid)
        Controls.Add(lname)
        Controls.Add(fpatients)
        Name = "fpatientsform"
        Text = "fpatients"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents fpatients As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tname As TextBox
    Friend WithEvents tid As TextBox
    Friend WithEvents taddress As TextBox
    Friend WithEvents tphoneno As TextBox
    Friend WithEvents btnenter As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents patientslist As ListView
    Friend WithEvents lname As Label
    Friend WithEvents lid As Label
    Friend WithEvents l As Label
    Friend WithEvents ldob As Label
    Friend WithEvents twardno As TextBox
    Friend WithEvents tappointmentsno As TextBox
    Friend WithEvents btndelete As Button
    Friend WithEvents tdate As DateTimePicker
    Friend WithEvents lgender As Label
    Friend WithEvents male As RadioButton
    Friend WithEvents female As RadioButton
    Friend WithEvents btnclear As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents btnentertodb As Button
    Friend WithEvents btnview As Button
    Friend WithEvents btnupdate As Button
End Class
