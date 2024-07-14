<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyProfCust
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MyProfCust))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtMyAcc = New System.Windows.Forms.TextBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.txtStudentsID = New System.Windows.Forms.TextBox()
        Me.txtGend = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblCustName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblStuID = New System.Windows.Forms.Label()
        Me.lblGenderCust = New System.Windows.Forms.Label()
        Me.lblEmailCust = New System.Windows.Forms.Label()
        Me.lblNumberCust = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button2.Location = New System.Drawing.Point(46, 648)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(155, 27)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "View Booking History"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txtMyAcc
        '
        Me.txtMyAcc.Location = New System.Drawing.Point(82, 271)
        Me.txtMyAcc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMyAcc.Name = "txtMyAcc"
        Me.txtMyAcc.Size = New System.Drawing.Size(262, 22)
        Me.txtMyAcc.TabIndex = 12
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(82, 337)
        Me.txtStatus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(262, 22)
        Me.txtStatus.TabIndex = 13
        '
        'txtStudentsID
        '
        Me.txtStudentsID.Location = New System.Drawing.Point(82, 404)
        Me.txtStudentsID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStudentsID.Name = "txtStudentsID"
        Me.txtStudentsID.Size = New System.Drawing.Size(262, 22)
        Me.txtStudentsID.TabIndex = 14
        '
        'txtGend
        '
        Me.txtGend.Location = New System.Drawing.Point(82, 478)
        Me.txtGend.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtGend.Name = "txtGend"
        Me.txtGend.Size = New System.Drawing.Size(262, 22)
        Me.txtGend.TabIndex = 15
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BackgroundImage = Global.OMC_1_12__.NET_.My.Resources.Resources.icons8_left_arrow_30
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBack.Location = New System.Drawing.Point(0, -2)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(56, 52)
        Me.btnBack.TabIndex = 16
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblCustName
        '
        Me.lblCustName.AutoSize = True
        Me.lblCustName.BackColor = System.Drawing.Color.Transparent
        Me.lblCustName.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCustName.Location = New System.Drawing.Point(156, 58)
        Me.lblCustName.Name = "lblCustName"
        Me.lblCustName.Size = New System.Drawing.Size(114, 25)
        Me.lblCustName.TabIndex = 17
        Me.lblCustName.Text = "lblCustName"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(170, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 15)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "MY PROFILE"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.lblStuID)
        Me.GroupBox1.Controls.Add(Me.lblGenderCust)
        Me.GroupBox1.Controls.Add(Me.lblEmailCust)
        Me.GroupBox1.Controls.Add(Me.lblNumberCust)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(46, 134)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(335, 480)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'lblStuID
        '
        Me.lblStuID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStuID.Font = New System.Drawing.Font("Impact", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStuID.Location = New System.Drawing.Point(23, 203)
        Me.lblStuID.Name = "lblStuID"
        Me.lblStuID.Size = New System.Drawing.Size(275, 43)
        Me.lblStuID.TabIndex = 2
        Me.lblStuID.Text = "studentid"
        '
        'lblGenderCust
        '
        Me.lblGenderCust.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGenderCust.Font = New System.Drawing.Font("Impact", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenderCust.Location = New System.Drawing.Point(23, 295)
        Me.lblGenderCust.Name = "lblGenderCust"
        Me.lblGenderCust.Size = New System.Drawing.Size(275, 43)
        Me.lblGenderCust.TabIndex = 2
        Me.lblGenderCust.Text = "gender"
        '
        'lblEmailCust
        '
        Me.lblEmailCust.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmailCust.Font = New System.Drawing.Font("Impact", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailCust.Location = New System.Drawing.Point(23, 39)
        Me.lblEmailCust.Name = "lblEmailCust"
        Me.lblEmailCust.Size = New System.Drawing.Size(275, 43)
        Me.lblEmailCust.TabIndex = 2
        Me.lblEmailCust.Text = "email"
        '
        'lblNumberCust
        '
        Me.lblNumberCust.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNumberCust.Font = New System.Drawing.Font("Impact", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberCust.Location = New System.Drawing.Point(23, 116)
        Me.lblNumberCust.Name = "lblNumberCust"
        Me.lblNumberCust.Size = New System.Drawing.Size(275, 43)
        Me.lblNumberCust.TabIndex = 2
        Me.lblNumberCust.Text = "number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Impact", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Student ID:"
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
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogout.Font = New System.Drawing.Font("Impact", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.Firebrick
        Me.btnLogout.Location = New System.Drawing.Point(46, 779)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(335, 30)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.Text = "Log out"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'MyProfCust
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OMC_1_12__.NET_.My.Resources.Resources.MYpROFbg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(426, 840)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCustName)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtGend)
        Me.Controls.Add(Me.txtStudentsID)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.txtMyAcc)
        Me.Controls.Add(Me.Button2)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MyProfCust"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barberlon"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents txtMyAcc As TextBox
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents txtStudentsID As TextBox
    Friend WithEvents txtGend As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents lblCustName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblStuID As Label
    Friend WithEvents lblGenderCust As Label
    Friend WithEvents lblNumberCust As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblEmailCust As Label
    Friend WithEvents Label4 As Label
End Class
