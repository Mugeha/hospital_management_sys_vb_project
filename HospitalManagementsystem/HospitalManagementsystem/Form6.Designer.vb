<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fpharmacyform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fpharmacyform))
        Label1 = New Label()
        lpatientsid = New Label()
        lpatientsname = New Label()
        lmedicine = New Label()
        ldate = New Label()
        ldosage = New Label()
        tpatientsid = New TextBox()
        tname = New TextBox()
        tmedicine = New TextBox()
        tdosage = New TextBox()
        btnadd = New Button()
        btnview = New Button()
        pharmacylist = New ListView()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader8 = New ColumnHeader()
        ladministration = New Label()
        tadministration = New TextBox()
        btnsave = New Button()
        btnclear = New Button()
        btnexit = New Button()
        tdateissued = New DateTimePicker()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(353, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(153, 40)
        Label1.TabIndex = 0
        Label1.Text = "Pharmacy"
        ' 
        ' lpatientsid
        ' 
        lpatientsid.AutoSize = True
        lpatientsid.Font = New Font("Segoe UI", 11.25F)
        lpatientsid.Location = New Point(45, 53)
        lpatientsid.Name = "lpatientsid"
        lpatientsid.Size = New Size(77, 20)
        lpatientsid.TabIndex = 1
        lpatientsid.Text = "Patients Id"
        ' 
        ' lpatientsname
        ' 
        lpatientsname.AutoSize = True
        lpatientsname.Font = New Font("Segoe UI", 11.25F)
        lpatientsname.Location = New Point(45, 107)
        lpatientsname.Name = "lpatientsname"
        lpatientsname.Size = New Size(104, 20)
        lpatientsname.TabIndex = 2
        lpatientsname.Text = "Patient's name"
        ' 
        ' lmedicine
        ' 
        lmedicine.AutoSize = True
        lmedicine.Font = New Font("Segoe UI", 11.25F)
        lmedicine.Location = New Point(45, 156)
        lmedicine.Name = "lmedicine"
        lmedicine.Size = New Size(70, 20)
        lmedicine.TabIndex = 3
        lmedicine.Text = "Medicine"
        ' 
        ' ldate
        ' 
        ldate.AutoSize = True
        ldate.Font = New Font("Segoe UI", 11.25F)
        ldate.Location = New Point(45, 212)
        ldate.Name = "ldate"
        ldate.Size = New Size(86, 20)
        ldate.TabIndex = 4
        ldate.Text = "Date Issued"
        ' 
        ' ldosage
        ' 
        ldosage.AutoSize = True
        ldosage.Font = New Font("Segoe UI", 11.25F)
        ldosage.Location = New Point(45, 273)
        ldosage.Name = "ldosage"
        ldosage.Size = New Size(80, 20)
        ldosage.TabIndex = 5
        ldosage.Text = "dosageMg"
        ' 
        ' tpatientsid
        ' 
        tpatientsid.Location = New Point(185, 54)
        tpatientsid.Name = "tpatientsid"
        tpatientsid.Size = New Size(177, 23)
        tpatientsid.TabIndex = 6
        ' 
        ' tname
        ' 
        tname.Location = New Point(185, 105)
        tname.Name = "tname"
        tname.Size = New Size(177, 23)
        tname.TabIndex = 7
        ' 
        ' tmedicine
        ' 
        tmedicine.Location = New Point(185, 157)
        tmedicine.Name = "tmedicine"
        tmedicine.Size = New Size(177, 23)
        tmedicine.TabIndex = 8
        ' 
        ' tdosage
        ' 
        tdosage.Location = New Point(185, 274)
        tdosage.Name = "tdosage"
        tdosage.Size = New Size(177, 23)
        tdosage.TabIndex = 10
        ' 
        ' btnadd
        ' 
        btnadd.BackColor = Color.RosyBrown
        btnadd.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnadd.Location = New Point(24, 396)
        btnadd.Name = "btnadd"
        btnadd.Size = New Size(75, 42)
        btnadd.TabIndex = 11
        btnadd.Text = "ADD"
        btnadd.UseVisualStyleBackColor = False
        ' 
        ' btnview
        ' 
        btnview.BackColor = Color.RosyBrown
        btnview.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnview.Location = New Point(124, 396)
        btnview.Name = "btnview"
        btnview.Size = New Size(75, 42)
        btnview.TabIndex = 12
        btnview.Text = "VIEW"
        btnview.UseVisualStyleBackColor = False
        ' 
        ' pharmacylist
        ' 
        pharmacylist.BackColor = SystemColors.ScrollBar
        pharmacylist.Columns.AddRange(New ColumnHeader() {ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader6, ColumnHeader8})
        pharmacylist.GridLines = True
        pharmacylist.Location = New Point(425, 53)
        pharmacylist.Name = "pharmacylist"
        pharmacylist.Size = New Size(678, 337)
        pharmacylist.TabIndex = 13
        pharmacylist.UseCompatibleStateImageBehavior = False
        pharmacylist.View = View.Details
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Patients's name"
        ColumnHeader2.Width = 100
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Medicine"
        ColumnHeader3.Width = 100
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Date Issued"
        ColumnHeader4.Width = 100
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "dosageMg"
        ColumnHeader5.Width = 100
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Administration"
        ColumnHeader6.Width = 100
        ' 
        ' ColumnHeader8
        ' 
        ColumnHeader8.Text = "Patient's Id"
        ColumnHeader8.Width = 100
        ' 
        ' ladministration
        ' 
        ladministration.AutoSize = True
        ladministration.Font = New Font("Segoe UI", 11.25F)
        ladministration.Location = New Point(44, 324)
        ladministration.Name = "ladministration"
        ladministration.Size = New Size(107, 20)
        ladministration.TabIndex = 14
        ladministration.Text = "Administration"
        ' 
        ' tadministration
        ' 
        tadministration.Location = New Point(185, 322)
        tadministration.Name = "tadministration"
        tadministration.Size = New Size(177, 23)
        tadministration.TabIndex = 15
        ' 
        ' btnsave
        ' 
        btnsave.BackColor = Color.RosyBrown
        btnsave.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnsave.Location = New Point(222, 396)
        btnsave.Name = "btnsave"
        btnsave.Size = New Size(75, 42)
        btnsave.TabIndex = 16
        btnsave.Text = "SAVE"
        btnsave.UseVisualStyleBackColor = False
        ' 
        ' btnclear
        ' 
        btnclear.BackColor = Color.RosyBrown
        btnclear.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnclear.Location = New Point(322, 396)
        btnclear.Name = "btnclear"
        btnclear.Size = New Size(75, 42)
        btnclear.TabIndex = 17
        btnclear.Text = "CLEAR"
        btnclear.UseVisualStyleBackColor = False
        ' 
        ' btnexit
        ' 
        btnexit.BackColor = Color.RosyBrown
        btnexit.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnexit.Location = New Point(425, 396)
        btnexit.Name = "btnexit"
        btnexit.Size = New Size(75, 42)
        btnexit.TabIndex = 18
        btnexit.Text = "EXIT"
        btnexit.UseVisualStyleBackColor = False
        ' 
        ' tdateissued
        ' 
        tdateissued.CustomFormat = "dd/mm/yyyy"
        tdateissued.Format = DateTimePickerFormat.Custom
        tdateissued.Location = New Point(185, 210)
        tdateissued.Name = "tdateissued"
        tdateissued.Size = New Size(200, 23)
        tdateissued.TabIndex = 19
        ' 
        ' fpharmacyform
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1160, 450)
        Controls.Add(tdateissued)
        Controls.Add(btnexit)
        Controls.Add(btnclear)
        Controls.Add(btnsave)
        Controls.Add(tadministration)
        Controls.Add(ladministration)
        Controls.Add(pharmacylist)
        Controls.Add(btnview)
        Controls.Add(btnadd)
        Controls.Add(tdosage)
        Controls.Add(tmedicine)
        Controls.Add(tname)
        Controls.Add(tpatientsid)
        Controls.Add(ldosage)
        Controls.Add(ldate)
        Controls.Add(lmedicine)
        Controls.Add(lpatientsname)
        Controls.Add(lpatientsid)
        Controls.Add(Label1)
        Name = "fpharmacyform"
        Text = "fpharmacy"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lpatientsid As Label
    Friend WithEvents lpatientsname As Label
    Friend WithEvents lmedicine As Label
    Friend WithEvents ldate As Label
    Friend WithEvents ldosage As Label
    Friend WithEvents tpatientsid As TextBox
    Friend WithEvents tname As TextBox
    Friend WithEvents tmedicine As TextBox
    Friend WithEvents tdate As TextBox
    Friend WithEvents tdosage As TextBox
    Friend WithEvents btnadd As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ladministration As Label
    Friend WithEvents tadministration As TextBox
    Friend WithEvents btnsave As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents pharmacylist As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents btnexit As Button
    Friend WithEvents tdateissued As DateTimePicker
    Friend WithEvents btnview As Button
    Friend WithEvents ColumnHeader8 As ColumnHeader
End Class
