<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fpaymentsform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fpaymentsform))
        lphoneno = New Label()
        lmodeofpayment = New Label()
        ltotalamount = New Label()
        lamountpaid = New Label()
        lbalance = New Label()
        lcash = New Label()
        tid = New TextBox()
        ttotalamount = New TextBox()
        tamountpaid = New TextBox()
        btnenter = New Button()
        btnclear = New Button()
        paymentslist = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader7 = New ColumnHeader()
        ColumnHeader8 = New ColumnHeader()
        btnsave = New Button()
        btnview = New Button()
        lpatientsId = New Label()
        lpatientsname = New Label()
        tphoneno = New TextBox()
        tname = New TextBox()
        combo = New ComboBox()
        tbalance = New TextBox()
        btnexit = New Button()
        SuspendLayout()
        ' 
        ' lphoneno
        ' 
        lphoneno.AutoSize = True
        lphoneno.BackColor = Color.Transparent
        lphoneno.Font = New Font("Segoe UI", 11.25F)
        lphoneno.ForeColor = Color.Black
        lphoneno.Location = New Point(18, 157)
        lphoneno.Name = "lphoneno"
        lphoneno.Size = New Size(74, 20)
        lphoneno.TabIndex = 0
        lphoneno.Text = "Phone No"
        ' 
        ' lmodeofpayment
        ' 
        lmodeofpayment.AutoSize = True
        lmodeofpayment.BackColor = Color.Transparent
        lmodeofpayment.Font = New Font("Segoe UI", 11.25F)
        lmodeofpayment.ForeColor = Color.Black
        lmodeofpayment.Location = New Point(18, 199)
        lmodeofpayment.Name = "lmodeofpayment"
        lmodeofpayment.Size = New Size(126, 20)
        lmodeofpayment.TabIndex = 1
        lmodeofpayment.Text = "Mode of Payment"
        ' 
        ' ltotalamount
        ' 
        ltotalamount.AutoSize = True
        ltotalamount.BackColor = Color.Transparent
        ltotalamount.Font = New Font("Segoe UI", 11.25F)
        ltotalamount.ForeColor = Color.Black
        ltotalamount.Location = New Point(18, 248)
        ltotalamount.Name = "ltotalamount"
        ltotalamount.Size = New Size(97, 20)
        ltotalamount.TabIndex = 2
        ltotalamount.Text = "Total amount"
        ' 
        ' lamountpaid
        ' 
        lamountpaid.AutoSize = True
        lamountpaid.BackColor = Color.Transparent
        lamountpaid.Font = New Font("Segoe UI", 11.25F)
        lamountpaid.ForeColor = Color.Black
        lamountpaid.Location = New Point(25, 295)
        lamountpaid.Name = "lamountpaid"
        lamountpaid.Size = New Size(90, 20)
        lamountpaid.TabIndex = 3
        lamountpaid.Text = "AmountPaid"
        ' 
        ' lbalance
        ' 
        lbalance.AutoSize = True
        lbalance.BackColor = Color.Transparent
        lbalance.Font = New Font("Segoe UI", 11.25F)
        lbalance.ForeColor = Color.Black
        lbalance.Location = New Point(25, 345)
        lbalance.Name = "lbalance"
        lbalance.Size = New Size(61, 20)
        lbalance.TabIndex = 4
        lbalance.Text = "Balance"
        ' 
        ' lcash
        ' 
        lcash.AutoSize = True
        lcash.BackColor = Color.Transparent
        lcash.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lcash.ForeColor = Color.Black
        lcash.Location = New Point(231, 9)
        lcash.Name = "lcash"
        lcash.Size = New Size(251, 45)
        lcash.TabIndex = 5
        lcash.Text = "Hospital Billing"
        ' 
        ' tid
        ' 
        tid.Location = New Point(158, 111)
        tid.Name = "tid"
        tid.Size = New Size(170, 23)
        tid.TabIndex = 6
        ' 
        ' ttotalamount
        ' 
        ttotalamount.Location = New Point(158, 245)
        ttotalamount.Name = "ttotalamount"
        ttotalamount.Size = New Size(152, 23)
        ttotalamount.TabIndex = 8
        ' 
        ' tamountpaid
        ' 
        tamountpaid.Location = New Point(158, 295)
        tamountpaid.Name = "tamountpaid"
        tamountpaid.Size = New Size(170, 23)
        tamountpaid.TabIndex = 9
        ' 
        ' btnenter
        ' 
        btnenter.BackColor = SystemColors.MenuHighlight
        btnenter.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnenter.Location = New Point(23, 391)
        btnenter.Name = "btnenter"
        btnenter.Size = New Size(75, 31)
        btnenter.TabIndex = 11
        btnenter.Text = "ENTER"
        btnenter.UseVisualStyleBackColor = False
        ' 
        ' btnclear
        ' 
        btnclear.BackColor = SystemColors.MenuHighlight
        btnclear.Font = New Font("Segoe UI", 12F)
        btnclear.Location = New Point(115, 391)
        btnclear.Name = "btnclear"
        btnclear.Size = New Size(75, 31)
        btnclear.TabIndex = 12
        btnclear.Text = "CLEAR"
        btnclear.UseVisualStyleBackColor = False
        ' 
        ' paymentslist
        ' 
        paymentslist.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader6, ColumnHeader7, ColumnHeader8})
        paymentslist.GridLines = True
        paymentslist.Location = New Point(364, 58)
        paymentslist.Name = "paymentslist"
        paymentslist.Size = New Size(681, 327)
        paymentslist.TabIndex = 13
        paymentslist.UseCompatibleStateImageBehavior = False
        paymentslist.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Patient's name"
        ColumnHeader1.Width = 100
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Phone no"
        ColumnHeader3.Width = 100
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Mode of payment"
        ColumnHeader4.Width = 100
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Total amount"
        ColumnHeader5.Width = 100
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Amount Paid"
        ColumnHeader6.Width = 100
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.Text = "Balance"
        ColumnHeader7.Width = 100
        ' 
        ' ColumnHeader8
        ' 
        ColumnHeader8.Text = "Patient's Id"
        ColumnHeader8.Width = 100
        ' 
        ' btnsave
        ' 
        btnsave.BackColor = SystemColors.MenuHighlight
        btnsave.Font = New Font("Segoe UI", 12F)
        btnsave.Location = New Point(196, 391)
        btnsave.Name = "btnsave"
        btnsave.Size = New Size(75, 31)
        btnsave.TabIndex = 14
        btnsave.Text = "SAVE"
        btnsave.UseVisualStyleBackColor = False
        ' 
        ' btnview
        ' 
        btnview.BackColor = SystemColors.MenuHighlight
        btnview.Font = New Font("Segoe UI", 12F)
        btnview.Location = New Point(296, 391)
        btnview.Name = "btnview"
        btnview.Size = New Size(75, 31)
        btnview.TabIndex = 15
        btnview.Text = "VIEW"
        btnview.UseVisualStyleBackColor = False
        ' 
        ' lpatientsId
        ' 
        lpatientsId.AutoSize = True
        lpatientsId.BackColor = Color.Transparent
        lpatientsId.Font = New Font("Segoe UI", 11.25F)
        lpatientsId.ForeColor = Color.Black
        lpatientsId.Location = New Point(18, 111)
        lpatientsId.Name = "lpatientsId"
        lpatientsId.Size = New Size(80, 20)
        lpatientsId.TabIndex = 16
        lpatientsId.Text = "Patient's Id"
        ' 
        ' lpatientsname
        ' 
        lpatientsname.AutoSize = True
        lpatientsname.BackColor = Color.Transparent
        lpatientsname.Font = New Font("Segoe UI", 11.25F)
        lpatientsname.ForeColor = Color.Black
        lpatientsname.Location = New Point(18, 59)
        lpatientsname.Name = "lpatientsname"
        lpatientsname.Size = New Size(107, 20)
        lpatientsname.TabIndex = 17
        lpatientsname.Text = "Patient's Name"
        ' 
        ' tphoneno
        ' 
        tphoneno.Location = New Point(158, 158)
        tphoneno.Name = "tphoneno"
        tphoneno.Size = New Size(170, 23)
        tphoneno.TabIndex = 18
        ' 
        ' tname
        ' 
        tname.Location = New Point(158, 60)
        tname.Name = "tname"
        tname.Size = New Size(170, 23)
        tname.TabIndex = 19
        ' 
        ' combo
        ' 
        combo.FormattingEnabled = True
        combo.Items.AddRange(New Object() {"credit card", "cash"})
        combo.Location = New Point(158, 200)
        combo.Name = "combo"
        combo.Size = New Size(152, 23)
        combo.TabIndex = 20
        ' 
        ' tbalance
        ' 
        tbalance.Location = New Point(149, 346)
        tbalance.Name = "tbalance"
        tbalance.Size = New Size(152, 23)
        tbalance.TabIndex = 21
        ' 
        ' btnexit
        ' 
        btnexit.BackColor = SystemColors.MenuHighlight
        btnexit.Font = New Font("Segoe UI", 12F)
        btnexit.Location = New Point(377, 391)
        btnexit.Name = "btnexit"
        btnexit.Size = New Size(75, 31)
        btnexit.TabIndex = 22
        btnexit.Text = "EXIT"
        btnexit.UseVisualStyleBackColor = False
        ' 
        ' fpaymentsform
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1122, 450)
        Controls.Add(btnexit)
        Controls.Add(tbalance)
        Controls.Add(combo)
        Controls.Add(tname)
        Controls.Add(tphoneno)
        Controls.Add(lpatientsname)
        Controls.Add(lpatientsId)
        Controls.Add(btnview)
        Controls.Add(btnsave)
        Controls.Add(paymentslist)
        Controls.Add(btnclear)
        Controls.Add(btnenter)
        Controls.Add(tamountpaid)
        Controls.Add(ttotalamount)
        Controls.Add(tid)
        Controls.Add(lcash)
        Controls.Add(lbalance)
        Controls.Add(lamountpaid)
        Controls.Add(ltotalamount)
        Controls.Add(lmodeofpayment)
        Controls.Add(lphoneno)
        Name = "fpaymentsform"
        Text = "fpayments"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lphoneno As Label
    Friend WithEvents lmodeofpayment As Label
    Friend WithEvents ltotalamount As Label
    Friend WithEvents lamountpaid As Label
    Friend WithEvents lbalance As Label
    Friend WithEvents lcash As Label
    Friend WithEvents tid As TextBox
    Friend WithEvents ttotalamount As TextBox
    Friend WithEvents tamountpaid As TextBox
    Friend WithEvents btnenter As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents paymentslist As ListView
    Friend WithEvents btnsave As Button
    Friend WithEvents btnview As Button
    Friend WithEvents lpatientsId As Label
    Friend WithEvents lpatientsname As Label
    Friend WithEvents tphoneno As TextBox
    Friend WithEvents tname As TextBox
    Friend WithEvents combo As ComboBox
    Friend WithEvents tbalance As TextBox
    Friend WithEvents btnexit As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
End Class
