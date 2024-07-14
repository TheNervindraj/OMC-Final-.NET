<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignupCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignupCustomer))
        Me.cboGenderCust = New System.Windows.Forms.ComboBox()
        Me.txtRegNumCust = New System.Windows.Forms.TextBox()
        Me.txtRegEmailCust = New System.Windows.Forms.TextBox()
        Me.txtRegIDCust = New System.Windows.Forms.TextBox()
        Me.txtRegNameCust = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRegConfPassCust = New System.Windows.Forms.TextBox()
        Me.txtRegPassCust = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnNextSignupCust = New System.Windows.Forms.Button()
        Me.btnBackSignupCust = New System.Windows.Forms.Button()
        Me.btnShowPassRegCust = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboGenderCust
        '
        Me.cboGenderCust.FormattingEnabled = True
        Me.cboGenderCust.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.cboGenderCust.Location = New System.Drawing.Point(42, 379)
        Me.cboGenderCust.Name = "cboGenderCust"
        Me.cboGenderCust.Size = New System.Drawing.Size(349, 24)
        Me.cboGenderCust.TabIndex = 12
        '
        'txtRegNumCust
        '
        Me.txtRegNumCust.Location = New System.Drawing.Point(42, 535)
        Me.txtRegNumCust.Multiline = True
        Me.txtRegNumCust.Name = "txtRegNumCust"
        Me.txtRegNumCust.Size = New System.Drawing.Size(349, 43)
        Me.txtRegNumCust.TabIndex = 8
        '
        'txtRegEmailCust
        '
        Me.txtRegEmailCust.Location = New System.Drawing.Point(42, 450)
        Me.txtRegEmailCust.Multiline = True
        Me.txtRegEmailCust.Name = "txtRegEmailCust"
        Me.txtRegEmailCust.Size = New System.Drawing.Size(349, 43)
        Me.txtRegEmailCust.TabIndex = 9
        '
        'txtRegIDCust
        '
        Me.txtRegIDCust.Location = New System.Drawing.Point(42, 288)
        Me.txtRegIDCust.Multiline = True
        Me.txtRegIDCust.Name = "txtRegIDCust"
        Me.txtRegIDCust.Size = New System.Drawing.Size(349, 43)
        Me.txtRegIDCust.TabIndex = 10
        '
        'txtRegNameCust
        '
        Me.txtRegNameCust.Location = New System.Drawing.Point(42, 206)
        Me.txtRegNameCust.Multiline = True
        Me.txtRegNameCust.Name = "txtRegNameCust"
        Me.txtRegNameCust.Size = New System.Drawing.Size(349, 43)
        Me.txtRegNameCust.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.Gold
        Me.Label8.Location = New System.Drawing.Point(39, 516)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 16)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Phone Number"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Gold
        Me.Label7.Location = New System.Drawing.Point(39, 431)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 16)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Email Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.Gold
        Me.Label6.Location = New System.Drawing.Point(39, 360)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Gender"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Gold
        Me.Label5.Location = New System.Drawing.Point(39, 269)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Student ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Gold
        Me.Label4.Location = New System.Drawing.Point(39, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Full Name"
        '
        'txtRegConfPassCust
        '
        Me.txtRegConfPassCust.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegConfPassCust.Location = New System.Drawing.Point(42, 713)
        Me.txtRegConfPassCust.Multiline = True
        Me.txtRegConfPassCust.Name = "txtRegConfPassCust"
        Me.txtRegConfPassCust.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRegConfPassCust.Size = New System.Drawing.Size(349, 43)
        Me.txtRegConfPassCust.TabIndex = 15
        '
        'txtRegPassCust
        '
        Me.txtRegPassCust.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegPassCust.Location = New System.Drawing.Point(42, 628)
        Me.txtRegPassCust.Multiline = True
        Me.txtRegPassCust.Name = "txtRegPassCust"
        Me.txtRegPassCust.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRegPassCust.Size = New System.Drawing.Size(349, 43)
        Me.txtRegPassCust.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(39, 694)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Confirm Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(39, 609)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Password"
        '
        'btnNextSignupCust
        '
        Me.btnNextSignupCust.Location = New System.Drawing.Point(163, 786)
        Me.btnNextSignupCust.Name = "btnNextSignupCust"
        Me.btnNextSignupCust.Size = New System.Drawing.Size(100, 42)
        Me.btnNextSignupCust.TabIndex = 17
        Me.btnNextSignupCust.Text = "Continue"
        Me.btnNextSignupCust.UseVisualStyleBackColor = True
        '
        'btnBackSignupCust
        '
        Me.btnBackSignupCust.Image = Global.OMC_1_12__.NET_.My.Resources.Resources.icons8_left_arrow_30
        Me.btnBackSignupCust.Location = New System.Drawing.Point(-9, -4)
        Me.btnBackSignupCust.Name = "btnBackSignupCust"
        Me.btnBackSignupCust.Size = New System.Drawing.Size(70, 54)
        Me.btnBackSignupCust.TabIndex = 26
        Me.btnBackSignupCust.UseVisualStyleBackColor = True
        '
        'btnShowPassRegCust
        '
        Me.btnShowPassRegCust.BackgroundImage = Global.OMC_1_12__.NET_.My.Resources.Resources.pngwing_com
        Me.btnShowPassRegCust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnShowPassRegCust.Location = New System.Drawing.Point(365, 685)
        Me.btnShowPassRegCust.Name = "btnShowPassRegCust"
        Me.btnShowPassRegCust.Size = New System.Drawing.Size(26, 22)
        Me.btnShowPassRegCust.TabIndex = 27
        Me.btnShowPassRegCust.UseVisualStyleBackColor = True
        '
        'SignupCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OMC_1_12__.NET_.My.Resources.Resources.cust_signup_backg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(426, 840)
        Me.Controls.Add(Me.btnShowPassRegCust)
        Me.Controls.Add(Me.btnBackSignupCust)
        Me.Controls.Add(Me.btnNextSignupCust)
        Me.Controls.Add(Me.txtRegConfPassCust)
        Me.Controls.Add(Me.txtRegPassCust)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboGenderCust)
        Me.Controls.Add(Me.txtRegNumCust)
        Me.Controls.Add(Me.txtRegEmailCust)
        Me.Controls.Add(Me.txtRegIDCust)
        Me.Controls.Add(Me.txtRegNameCust)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "SignupCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barberlon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboGenderCust As ComboBox
    Friend WithEvents txtRegNumCust As TextBox
    Friend WithEvents txtRegEmailCust As TextBox
    Friend WithEvents txtRegIDCust As TextBox
    Friend WithEvents txtRegNameCust As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRegConfPassCust As TextBox
    Friend WithEvents txtRegPassCust As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnNextSignupCust As Button
    Friend WithEvents btnBackSignupCust As Button
    Friend WithEvents btnShowPassRegCust As Button
End Class
