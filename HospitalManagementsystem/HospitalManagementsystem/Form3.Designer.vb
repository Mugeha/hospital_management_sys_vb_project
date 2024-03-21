<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fAppointmentsform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fAppointmentsform))
        lappointmentsref = New Label()
        lpatientsnumber = New Label()
        ldoctorsname = New Label()
        btnbook = New Button()
        lexit = New Button()
        tappointmentsref = New TextBox()
        tno = New TextBox()
        tdoctorsname = New TextBox()
        listviewforappointments = New ListView()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader7 = New ColumnHeader()
        ColumnHeader8 = New ColumnHeader()
        lheading = New Label()
        lpatientsname = New Label()
        lpatientsNo = New Label()
        ldoctorsNhsno = New Label()
        tpatientsname = New TextBox()
        tpatientsId = New TextBox()
        tdoctorsNhsno = New TextBox()
        ldate = New Label()
        tdate = New DateTimePicker()
        btnclear = New Button()
        btnsave = New Button()
        btndelete = New Button()
        btnview = New Button()
        btnedit = New Button()
        updatebtn = New Button()
        SuspendLayout()
        ' 
        ' lappointmentsref
        ' 
        lappointmentsref.AutoSize = True
        lappointmentsref.BackColor = Color.Transparent
        lappointmentsref.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lappointmentsref.ForeColor = Color.Black
        lappointmentsref.Location = New Point(61, 76)
        lappointmentsref.Name = "lappointmentsref"
        lappointmentsref.Size = New Size(129, 20)
        lappointmentsref.TabIndex = 0
        lappointmentsref.Text = "Appointments Ref"
        ' 
        ' lpatientsnumber
        ' 
        lpatientsnumber.AutoSize = True
        lpatientsnumber.BackColor = Color.Transparent
        lpatientsnumber.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lpatientsnumber.ForeColor = Color.Black
        lpatientsnumber.Location = New Point(58, 167)
        lpatientsnumber.Name = "lpatientsnumber"
        lpatientsnumber.Size = New Size(121, 20)
        lpatientsnumber.TabIndex = 1
        lpatientsnumber.Text = "Patient's Number"
        ' 
        ' ldoctorsname
        ' 
        ldoctorsname.AutoSize = True
        ldoctorsname.BackColor = Color.Transparent
        ldoctorsname.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ldoctorsname.ForeColor = Color.Black
        ldoctorsname.Location = New Point(61, 322)
        ldoctorsname.Name = "ldoctorsname"
        ldoctorsname.Size = New Size(108, 20)
        ldoctorsname.TabIndex = 3
        ldoctorsname.Text = "Doctor's Name"
        ' 
        ' btnbook
        ' 
        btnbook.BackColor = SystemColors.AppWorkspace
        btnbook.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnbook.Location = New Point(61, 397)
        btnbook.Name = "btnbook"
        btnbook.Size = New Size(89, 41)
        btnbook.TabIndex = 4
        btnbook.Text = "BOOK"
        btnbook.UseVisualStyleBackColor = False
        ' 
        ' lexit
        ' 
        lexit.BackColor = SystemColors.AppWorkspace
        lexit.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lexit.Location = New Point(175, 397)
        lexit.Name = "lexit"
        lexit.Size = New Size(87, 41)
        lexit.TabIndex = 5
        lexit.Text = "EXIT"
        lexit.UseVisualStyleBackColor = False
        ' 
        ' tappointmentsref
        ' 
        tappointmentsref.Location = New Point(228, 76)
        tappointmentsref.Name = "tappointmentsref"
        tappointmentsref.Size = New Size(159, 23)
        tappointmentsref.TabIndex = 6
        ' 
        ' tno
        ' 
        tno.Location = New Point(228, 168)
        tno.Name = "tno"
        tno.Size = New Size(159, 23)
        tno.TabIndex = 7
        ' 
        ' tdoctorsname
        ' 
        tdoctorsname.Location = New Point(228, 323)
        tdoctorsname.Name = "tdoctorsname"
        tdoctorsname.Size = New Size(159, 23)
        tdoctorsname.TabIndex = 9
        ' 
        ' listviewforappointments
        ' 
        listviewforappointments.BackColor = SystemColors.ScrollBar
        listviewforappointments.Columns.AddRange(New ColumnHeader() {ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader6, ColumnHeader7, ColumnHeader8})
        listviewforappointments.GridLines = True
        listviewforappointments.Location = New Point(434, 61)
        listviewforappointments.Name = "listviewforappointments"
        listviewforappointments.Size = New Size(703, 334)
        listviewforappointments.TabIndex = 10
        listviewforappointments.UseCompatibleStateImageBehavior = False
        listviewforappointments.View = View.Details
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Patient's Number"
        ColumnHeader2.Width = 100
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Patients Name"
        ColumnHeader3.Width = 100
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "patients Id"
        ColumnHeader4.Width = 100
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Doctor's NHS no"
        ColumnHeader5.Width = 100
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Doctor's Name"
        ColumnHeader6.Width = 100
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.Text = "Date Of appointment"
        ColumnHeader7.Width = 100
        ' 
        ' ColumnHeader8
        ' 
        ColumnHeader8.Text = "Appointments Ref"
        ColumnHeader8.Width = 100
        ' 
        ' lheading
        ' 
        lheading.AutoSize = True
        lheading.BackColor = Color.Transparent
        lheading.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lheading.Location = New Point(253, 21)
        lheading.Name = "lheading"
        lheading.Size = New Size(283, 37)
        lheading.TabIndex = 11
        lheading.Text = "Appointments' Form"
        ' 
        ' lpatientsname
        ' 
        lpatientsname.AutoSize = True
        lpatientsname.BackColor = Color.Transparent
        lpatientsname.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lpatientsname.ForeColor = Color.Black
        lpatientsname.Location = New Point(61, 120)
        lpatientsname.Name = "lpatientsname"
        lpatientsname.Size = New Size(107, 20)
        lpatientsname.TabIndex = 12
        lpatientsname.Text = "Patient's Name"
        ' 
        ' lpatientsNo
        ' 
        lpatientsNo.AutoSize = True
        lpatientsNo.BackColor = Color.Transparent
        lpatientsNo.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lpatientsNo.ForeColor = Color.Black
        lpatientsNo.Location = New Point(61, 277)
        lpatientsNo.Name = "lpatientsNo"
        lpatientsNo.Size = New Size(80, 20)
        lpatientsNo.TabIndex = 13
        lpatientsNo.Text = "Patient's Id"
        ' 
        ' ldoctorsNhsno
        ' 
        ldoctorsNhsno.AutoSize = True
        ldoctorsNhsno.BackColor = Color.Transparent
        ldoctorsNhsno.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ldoctorsNhsno.ForeColor = Color.Black
        ldoctorsNhsno.Location = New Point(61, 362)
        ldoctorsNhsno.Name = "ldoctorsNhsno"
        ldoctorsNhsno.Size = New Size(122, 20)
        ldoctorsNhsno.TabIndex = 14
        ldoctorsNhsno.Text = "Doctor's NHS No"
        ' 
        ' tpatientsname
        ' 
        tpatientsname.Location = New Point(228, 117)
        tpatientsname.Name = "tpatientsname"
        tpatientsname.Size = New Size(159, 23)
        tpatientsname.TabIndex = 15
        ' 
        ' tpatientsId
        ' 
        tpatientsId.Location = New Point(228, 274)
        tpatientsId.Name = "tpatientsId"
        tpatientsId.Size = New Size(159, 23)
        tpatientsId.TabIndex = 16
        ' 
        ' tdoctorsNhsno
        ' 
        tdoctorsNhsno.Location = New Point(228, 368)
        tdoctorsNhsno.Name = "tdoctorsNhsno"
        tdoctorsNhsno.Size = New Size(159, 23)
        tdoctorsNhsno.TabIndex = 17
        ' 
        ' ldate
        ' 
        ldate.AutoSize = True
        ldate.BackColor = Color.Transparent
        ldate.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ldate.ForeColor = Color.Black
        ldate.Location = New Point(58, 222)
        ldate.Name = "ldate"
        ldate.Size = New Size(153, 20)
        ldate.TabIndex = 18
        ldate.Text = "Date Of Appointment"
        ' 
        ' tdate
        ' 
        tdate.CustomFormat = "dd/mm/yyyy hh:mm:ss"
        tdate.Format = DateTimePickerFormat.Custom
        tdate.Location = New Point(228, 220)
        tdate.Name = "tdate"
        tdate.Size = New Size(200, 23)
        tdate.TabIndex = 19
        ' 
        ' btnclear
        ' 
        btnclear.BackColor = SystemColors.AppWorkspace
        btnclear.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnclear.Location = New Point(286, 397)
        btnclear.Name = "btnclear"
        btnclear.Size = New Size(89, 41)
        btnclear.TabIndex = 20
        btnclear.Text = "CLEAR"
        btnclear.UseVisualStyleBackColor = False
        ' 
        ' btnsave
        ' 
        btnsave.BackColor = SystemColors.AppWorkspace
        btnsave.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnsave.Location = New Point(391, 397)
        btnsave.Name = "btnsave"
        btnsave.Size = New Size(89, 41)
        btnsave.TabIndex = 21
        btnsave.Text = "SAVE"
        btnsave.UseVisualStyleBackColor = False
        ' 
        ' btndelete
        ' 
        btndelete.BackColor = SystemColors.AppWorkspace
        btndelete.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btndelete.Location = New Point(495, 397)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(89, 41)
        btndelete.TabIndex = 22
        btndelete.Text = "DELETE"
        btndelete.UseVisualStyleBackColor = False
        ' 
        ' btnview
        ' 
        btnview.BackColor = SystemColors.AppWorkspace
        btnview.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnview.Location = New Point(590, 401)
        btnview.Name = "btnview"
        btnview.Size = New Size(89, 41)
        btnview.TabIndex = 23
        btnview.Text = "VIEW"
        btnview.UseVisualStyleBackColor = False
        ' 
        ' btnedit
        ' 
        btnedit.BackColor = SystemColors.AppWorkspace
        btnedit.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnedit.Location = New Point(700, 401)
        btnedit.Name = "btnedit"
        btnedit.Size = New Size(89, 41)
        btnedit.TabIndex = 24
        btnedit.Text = "EDIT"
        btnedit.UseVisualStyleBackColor = False
        ' 
        ' updatebtn
        ' 
        updatebtn.BackColor = SystemColors.AppWorkspace
        updatebtn.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        updatebtn.Location = New Point(795, 397)
        updatebtn.Name = "updatebtn"
        updatebtn.Size = New Size(89, 41)
        updatebtn.TabIndex = 25
        updatebtn.Text = "UPDATE"
        updatebtn.UseVisualStyleBackColor = False
        ' 
        ' fAppointmentsform
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1179, 450)
        Controls.Add(updatebtn)
        Controls.Add(btnedit)
        Controls.Add(btnview)
        Controls.Add(btndelete)
        Controls.Add(btnsave)
        Controls.Add(btnclear)
        Controls.Add(tdate)
        Controls.Add(ldate)
        Controls.Add(tdoctorsNhsno)
        Controls.Add(tpatientsId)
        Controls.Add(tpatientsname)
        Controls.Add(ldoctorsNhsno)
        Controls.Add(lpatientsNo)
        Controls.Add(lpatientsname)
        Controls.Add(lheading)
        Controls.Add(listviewforappointments)
        Controls.Add(tdoctorsname)
        Controls.Add(tno)
        Controls.Add(tappointmentsref)
        Controls.Add(lexit)
        Controls.Add(btnbook)
        Controls.Add(ldoctorsname)
        Controls.Add(lpatientsnumber)
        Controls.Add(lappointmentsref)
        Name = "fAppointmentsform"
        Text = "fappointments"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lappointmentsref As Label
    Friend WithEvents lpatientsnumber As Label
    Friend WithEvents ldoctorsname As Label
    Friend WithEvents btnbook As Button
    Friend WithEvents lexit As Button
    Friend WithEvents tappointmentsref As TextBox
    Friend WithEvents tno As TextBox
    Friend WithEvents tdoctorsname As TextBox
    Friend WithEvents listviewforappointments As ListView
    Friend WithEvents lheading As Label
    Friend WithEvents lpatientsname As Label
    Friend WithEvents lpatientsNo As Label
    Friend WithEvents ldoctorsNhsno As Label
    Friend WithEvents tpatientsname As TextBox
    Friend WithEvents tpatientsId As TextBox
    Friend WithEvents tdoctorsNhsno As TextBox
    Friend WithEvents ldate As Label
    Friend WithEvents tdate As DateTimePicker
    Friend WithEvents btnclear As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents btnview As Button
    Friend WithEvents updatebtn As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents Button2 As Button
    Friend WithEvents btnupdate As Button
End Class
