<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fwardsform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fwardsform))
        Label1 = New Label()
        lwardid = New Label()
        lpatientid = New Label()
        lgender = New Label()
        lpatientname = New Label()
        twardid = New TextBox()
        tpatientid = New TextBox()
        tpatientsname = New TextBox()
        male = New RadioButton()
        female = New RadioButton()
        btnsave = New Button()
        btnenter = New Button()
        wardslist = New ListView()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        btnclear = New Button()
        btnexit = New Button()
        btnview = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Window
        Label1.Location = New Point(333, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(115, 45)
        Label1.TabIndex = 0
        Label1.Text = "Wards"
        ' 
        ' lwardid
        ' 
        lwardid.AutoSize = True
        lwardid.BackColor = Color.Transparent
        lwardid.Font = New Font("Segoe UI", 11.25F)
        lwardid.ForeColor = SystemColors.Window
        lwardid.Location = New Point(38, 116)
        lwardid.Name = "lwardid"
        lwardid.Size = New Size(61, 20)
        lwardid.TabIndex = 1
        lwardid.Text = "Ward Id"
        ' 
        ' lpatientid
        ' 
        lpatientid.AutoSize = True
        lpatientid.BackColor = Color.Transparent
        lpatientid.Font = New Font("Segoe UI", 11.25F)
        lpatientid.ForeColor = SystemColors.Window
        lpatientid.Location = New Point(38, 183)
        lpatientid.Name = "lpatientid"
        lpatientid.Size = New Size(71, 20)
        lpatientid.TabIndex = 2
        lpatientid.Text = "Patient Id"
        ' 
        ' lgender
        ' 
        lgender.AutoSize = True
        lgender.BackColor = Color.Transparent
        lgender.Font = New Font("Segoe UI", 11.25F)
        lgender.ForeColor = SystemColors.Window
        lgender.Location = New Point(38, 326)
        lgender.Name = "lgender"
        lgender.Size = New Size(57, 20)
        lgender.TabIndex = 3
        lgender.Text = "Gender"
        ' 
        ' lpatientname
        ' 
        lpatientname.AutoSize = True
        lpatientname.BackColor = Color.Transparent
        lpatientname.Font = New Font("Segoe UI", 11.25F)
        lpatientname.ForeColor = SystemColors.Window
        lpatientname.Location = New Point(38, 261)
        lpatientname.Name = "lpatientname"
        lpatientname.Size = New Size(104, 20)
        lpatientname.TabIndex = 4
        lpatientname.Text = "Patient's name"
        ' 
        ' twardid
        ' 
        twardid.Location = New Point(155, 108)
        twardid.Name = "twardid"
        twardid.Size = New Size(177, 23)
        twardid.TabIndex = 6
        ' 
        ' tpatientid
        ' 
        tpatientid.Location = New Point(155, 183)
        tpatientid.Name = "tpatientid"
        tpatientid.Size = New Size(177, 23)
        tpatientid.TabIndex = 7
        ' 
        ' tpatientsname
        ' 
        tpatientsname.Location = New Point(155, 262)
        tpatientsname.Name = "tpatientsname"
        tpatientsname.Size = New Size(177, 23)
        tpatientsname.TabIndex = 8
        ' 
        ' male
        ' 
        male.AutoSize = True
        male.BackColor = Color.Transparent
        male.ForeColor = SystemColors.Window
        male.Location = New Point(155, 328)
        male.Name = "male"
        male.Size = New Size(51, 19)
        male.TabIndex = 10
        male.TabStop = True
        male.Text = "Male"
        male.UseVisualStyleBackColor = False
        ' 
        ' female
        ' 
        female.AutoSize = True
        female.BackColor = Color.Transparent
        female.ForeColor = SystemColors.Window
        female.Location = New Point(244, 328)
        female.Name = "female"
        female.Size = New Size(63, 19)
        female.TabIndex = 11
        female.TabStop = True
        female.Text = "Female"
        female.UseVisualStyleBackColor = False
        ' 
        ' btnsave
        ' 
        btnsave.BackColor = Color.Sienna
        btnsave.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        btnsave.Location = New Point(38, 403)
        btnsave.Name = "btnsave"
        btnsave.Size = New Size(75, 35)
        btnsave.TabIndex = 12
        btnsave.Text = "SAVE"
        btnsave.UseVisualStyleBackColor = False
        ' 
        ' btnenter
        ' 
        btnenter.BackColor = Color.Sienna
        btnenter.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        btnenter.Location = New Point(137, 403)
        btnenter.Name = "btnenter"
        btnenter.Size = New Size(75, 35)
        btnenter.TabIndex = 13
        btnenter.Text = "ENTER"
        btnenter.UseVisualStyleBackColor = False
        ' 
        ' wardslist
        ' 
        wardslist.BackColor = SystemColors.ScrollBar
        wardslist.Columns.AddRange(New ColumnHeader() {ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader6})
        wardslist.GridLines = True
        wardslist.Location = New Point(511, 53)
        wardslist.Name = "wardslist"
        wardslist.Size = New Size(489, 367)
        wardslist.TabIndex = 14
        wardslist.UseCompatibleStateImageBehavior = False
        wardslist.View = View.Details
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Patient Id"
        ColumnHeader2.Width = 100
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Patient's Name"
        ColumnHeader3.Width = 100
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Gender"
        ColumnHeader4.Width = 100
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Ward Id"
        ColumnHeader6.Width = 100
        ' 
        ' btnclear
        ' 
        btnclear.BackColor = Color.Sienna
        btnclear.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        btnclear.Location = New Point(232, 403)
        btnclear.Name = "btnclear"
        btnclear.Size = New Size(75, 35)
        btnclear.TabIndex = 15
        btnclear.Text = "CLEAR"
        btnclear.UseVisualStyleBackColor = False
        ' 
        ' btnexit
        ' 
        btnexit.BackColor = Color.Sienna
        btnexit.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        btnexit.Location = New Point(324, 403)
        btnexit.Name = "btnexit"
        btnexit.Size = New Size(75, 35)
        btnexit.TabIndex = 16
        btnexit.Text = "EXIT"
        btnexit.UseVisualStyleBackColor = False
        ' 
        ' btnview
        ' 
        btnview.BackColor = Color.Sienna
        btnview.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        btnview.Location = New Point(417, 403)
        btnview.Name = "btnview"
        btnview.Size = New Size(75, 35)
        btnview.TabIndex = 17
        btnview.Text = "VIEW"
        btnview.UseVisualStyleBackColor = False
        ' 
        ' fwardsform
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1003, 450)
        Controls.Add(btnview)
        Controls.Add(btnexit)
        Controls.Add(btnclear)
        Controls.Add(wardslist)
        Controls.Add(btnenter)
        Controls.Add(btnsave)
        Controls.Add(female)
        Controls.Add(male)
        Controls.Add(tpatientsname)
        Controls.Add(tpatientid)
        Controls.Add(twardid)
        Controls.Add(lpatientname)
        Controls.Add(lgender)
        Controls.Add(lpatientid)
        Controls.Add(lwardid)
        Controls.Add(Label1)
        Name = "fwardsform"
        Text = "fwards"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lwardid As Label
    Friend WithEvents lpatientid As Label
    Friend WithEvents lgender As Label
    Friend WithEvents lpatientname As Label
    Friend WithEvents twardid As TextBox
    Friend WithEvents tpatientid As TextBox
    Friend WithEvents tpatientsname As TextBox
    Friend WithEvents radiomale As RadioButton
    Friend WithEvents radiofemale As RadioButton
    Friend WithEvents btnsave As Button
    Friend WithEvents btnenter As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Button3 As Button
    Friend WithEvents wardslist As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents btnclear As Button
    Friend WithEvents btnview As Button
    Friend WithEvents male As RadioButton
    Friend WithEvents female As RadioButton
    Friend WithEvents btnexit As Button
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents Button2 As Button
End Class
