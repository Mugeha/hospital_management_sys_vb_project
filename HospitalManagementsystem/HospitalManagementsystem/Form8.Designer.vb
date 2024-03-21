<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        Panel1 = New Panel()
        btnpatients = New Button()
        btnappointments = New Button()
        btndoctor = New Button()
        Panel3 = New Panel()
        btnlabels = New Button()
        btnpharmacy = New Button()
        btnpayments = New Button()
        Button1 = New Button()
        btnexit = New Button()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(btnpatients)
        Panel1.Controls.Add(btnappointments)
        Panel1.Controls.Add(btndoctor)
        Panel1.Location = New Point(82, 85)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(227, 254)
        Panel1.TabIndex = 1
        ' 
        ' btnpatients
        ' 
        btnpatients.Font = New Font("Tahoma", 9F, FontStyle.Bold)
        btnpatients.Location = New Point(49, 167)
        btnpatients.Name = "btnpatients"
        btnpatients.Size = New Size(124, 42)
        btnpatients.TabIndex = 5
        btnpatients.Text = "Patients Details"
        btnpatients.UseVisualStyleBackColor = True
        ' 
        ' btnappointments
        ' 
        btnappointments.Font = New Font("Tahoma", 9F, FontStyle.Bold)
        btnappointments.Location = New Point(49, 107)
        btnappointments.Name = "btnappointments"
        btnappointments.Size = New Size(124, 42)
        btnappointments.TabIndex = 4
        btnappointments.Text = "Appointments"
        btnappointments.UseVisualStyleBackColor = True
        ' 
        ' btndoctor
        ' 
        btndoctor.Font = New Font("Tahoma", 9F, FontStyle.Bold)
        btndoctor.Location = New Point(49, 42)
        btndoctor.Name = "btndoctor"
        btndoctor.Size = New Size(124, 42)
        btndoctor.TabIndex = 3
        btndoctor.Text = "Doctors' Form"
        btndoctor.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ActiveCaption
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(btnlabels)
        Panel3.Controls.Add(btnpharmacy)
        Panel3.Controls.Add(btnpayments)
        Panel3.Location = New Point(433, 85)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(227, 254)
        Panel3.TabIndex = 3
        ' 
        ' btnlabels
        ' 
        btnlabels.Font = New Font("Tahoma", 9F, FontStyle.Bold)
        btnlabels.Location = New Point(60, 169)
        btnlabels.Name = "btnlabels"
        btnlabels.Size = New Size(102, 40)
        btnlabels.TabIndex = 11
        btnlabels.Text = "Wards"
        btnlabels.UseVisualStyleBackColor = True
        ' 
        ' btnpharmacy
        ' 
        btnpharmacy.Font = New Font("Tahoma", 9F, FontStyle.Bold)
        btnpharmacy.Location = New Point(60, 104)
        btnpharmacy.Name = "btnpharmacy"
        btnpharmacy.Size = New Size(102, 40)
        btnpharmacy.TabIndex = 10
        btnpharmacy.Text = "Pharmacy"
        btnpharmacy.UseVisualStyleBackColor = True
        ' 
        ' btnpayments
        ' 
        btnpayments.Font = New Font("Tahoma", 9F, FontStyle.Bold)
        btnpayments.Location = New Point(60, 41)
        btnpayments.Name = "btnpayments"
        btnpayments.Size = New Size(102, 40)
        btnpayments.TabIndex = 9
        btnpayments.Text = "Payments"
        btnpayments.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.Font = New Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(257, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(290, 42)
        Button1.TabIndex = 4
        Button1.Text = "Hospital Information"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnexit
        ' 
        btnexit.Font = New Font("Tahoma", 9F, FontStyle.Bold)
        btnexit.Location = New Point(320, 371)
        btnexit.Name = "btnexit"
        btnexit.Size = New Size(102, 40)
        btnexit.TabIndex = 12
        btnexit.Text = "EXIT"
        btnexit.UseVisualStyleBackColor = True
        ' 
        ' Form8
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(btnexit)
        Controls.Add(Button1)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Name = "Form8"
        Text = "Form8"
        Panel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnpatients As Button
    Friend WithEvents btnappointments As Button
    Friend WithEvents btndoctor As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnlabels As Button
    Friend WithEvents btnpharmacy As Button
    Friend WithEvents btnpayments As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnexit As Button
End Class
