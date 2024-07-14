<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BarberProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BarberProfile))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblIC = New System.Windows.Forms.Label()
        Me.lblExpBarber = New System.Windows.Forms.Label()
        Me.lblGenderBarb = New System.Windows.Forms.Label()
        Me.lblEmailBarb = New System.Windows.Forms.Label()
        Me.lblNumberBarb = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNameBarber = New System.Windows.Forms.Label()
        Me.txtGend = New System.Windows.Forms.TextBox()
        Me.txtStudentsID = New System.Windows.Forms.TextBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.txtMyAcc = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BackgroundImage = Global.OMC_1_12__.NET_.My.Resources.Resources.icons8_left_arrow_30
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBack.Location = New System.Drawing.Point(0, 0)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(81, 68)
        Me.btnBack.TabIndex = 24
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogout.Font = New System.Drawing.Font("Impact", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.Firebrick
        Me.btnLogout.Location = New System.Drawing.Point(46, 786)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(335, 30)
        Me.btnLogout.TabIndex = 25
        Me.btnLogout.Text = "Log out"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.lblIC)
        Me.GroupBox1.Controls.Add(Me.lblExpBarber)
        Me.GroupBox1.Controls.Add(Me.lblGenderBarb)
        Me.GroupBox1.Controls.Add(Me.lblEmailBarb)
        Me.GroupBox1.Controls.Add(Me.lblNumberBarb)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(58, 207)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(323, 507)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        '
        'lblIC
        '
        Me.lblIC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIC.Font = New System.Drawing.Font("Impact", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIC.Location = New System.Drawing.Point(23, 203)
        Me.lblIC.Name = "lblIC"
        Me.lblIC.Size = New System.Drawing.Size(275, 43)
        Me.lblIC.TabIndex = 2
        Me.lblIC.Text = "lblIC"
        '
        'lblExpBarber
        '
        Me.lblExpBarber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblExpBarber.Font = New System.Drawing.Font("Impact", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpBarber.Location = New System.Drawing.Point(23, 390)
        Me.lblExpBarber.Name = "lblExpBarber"
        Me.lblExpBarber.Size = New System.Drawing.Size(275, 43)
        Me.lblExpBarber.TabIndex = 2
        Me.lblExpBarber.Text = "Experience"
        '
        'lblGenderBarb
        '
        Me.lblGenderBarb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGenderBarb.Font = New System.Drawing.Font("Impact", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenderBarb.Location = New System.Drawing.Point(23, 295)
        Me.lblGenderBarb.Name = "lblGenderBarb"
        Me.lblGenderBarb.Size = New System.Drawing.Size(275, 43)
        Me.lblGenderBarb.TabIndex = 2
        Me.lblGenderBarb.Text = "gender"
        '
        'lblEmailBarb
        '
        Me.lblEmailBarb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmailBarb.Font = New System.Drawing.Font("Impact", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailBarb.Location = New System.Drawing.Point(23, 39)
        Me.lblEmailBarb.Name = "lblEmailBarb"
        Me.lblEmailBarb.Size = New System.Drawing.Size(275, 43)
        Me.lblEmailBarb.TabIndex = 2
        Me.lblEmailBarb.Text = "email"
        '
        'lblNumberBarb
        '
        Me.lblNumberBarb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNumberBarb.Font = New System.Drawing.Font("Impact", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberBarb.Location = New System.Drawing.Point(23, 116)
        Me.lblNumberBarb.Name = "lblNumberBarb"
        Me.lblNumberBarb.Size = New System.Drawing.Size(275, 43)
        Me.lblNumberBarb.TabIndex = 2
        Me.lblNumberBarb.Text = "number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Impact", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "IC Number:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Impact", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 371)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Experience:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Impact", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Email:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Impact", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 276)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Gender:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Impact", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Phone Number:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(170, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 15)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "MY PROFILE"
        '
        'lblNameBarber
        '
        Me.lblNameBarber.AutoSize = True
        Me.lblNameBarber.BackColor = System.Drawing.Color.Transparent
        Me.lblNameBarber.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameBarber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNameBarber.Location = New System.Drawing.Point(158, 144)
        Me.lblNameBarber.Name = "lblNameBarber"
        Me.lblNameBarber.Size = New System.Drawing.Size(133, 25)
        Me.lblNameBarber.TabIndex = 31
        Me.lblNameBarber.Text = "lblNameBarber"
        '
        'txtGend
        '
        Me.txtGend.Location = New System.Drawing.Point(82, 485)
        Me.txtGend.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtGend.Name = "txtGend"
        Me.txtGend.Size = New System.Drawing.Size(262, 22)
        Me.txtGend.TabIndex = 30
        '
        'txtStudentsID
        '
        Me.txtStudentsID.Location = New System.Drawing.Point(82, 411)
        Me.txtStudentsID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStudentsID.Name = "txtStudentsID"
        Me.txtStudentsID.Size = New System.Drawing.Size(262, 22)
        Me.txtStudentsID.TabIndex = 29
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(82, 344)
        Me.txtStatus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(262, 22)
        Me.txtStatus.TabIndex = 28
        '
        'txtMyAcc
        '
        Me.txtMyAcc.Location = New System.Drawing.Point(82, 278)
        Me.txtMyAcc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMyAcc.Name = "txtMyAcc"
        Me.txtMyAcc.Size = New System.Drawing.Size(262, 22)
        Me.txtMyAcc.TabIndex = 27
        '
        'BarberProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OMC_1_12__.NET_.My.Resources.Resources.barberProfile
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(426, 840)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNameBarber)
        Me.Controls.Add(Me.txtGend)
        Me.Controls.Add(Me.txtStudentsID)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.txtMyAcc)
        Me.Controls.Add(Me.btnBack)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "BarberProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barberlon"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblIC As Label
    Friend WithEvents lblGenderBarb As Label
    Friend WithEvents lblEmailBarb As Label
    Friend WithEvents lblNumberBarb As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNameBarber As Label
    Friend WithEvents txtGend As TextBox
    Friend WithEvents txtStudentsID As TextBox
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents txtMyAcc As TextBox
    Friend WithEvents lblExpBarber As Label
    Friend WithEvents Label5 As Label
End Class
