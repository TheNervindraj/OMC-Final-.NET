<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BarberLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BarberLogin))
        Me.txtLoginPassBarber = New System.Windows.Forms.TextBox()
        Me.txtLoginEmailBarber = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnResetBarber = New System.Windows.Forms.Button()
        Me.btnLoginBarber = New System.Windows.Forms.Button()
        Me.btnBackBarberLogin = New System.Windows.Forms.Button()
        Me.btnShowPassCust = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtLoginPassBarber
        '
        Me.txtLoginPassBarber.Location = New System.Drawing.Point(35, 403)
        Me.txtLoginPassBarber.Multiline = True
        Me.txtLoginPassBarber.Name = "txtLoginPassBarber"
        Me.txtLoginPassBarber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtLoginPassBarber.Size = New System.Drawing.Size(349, 43)
        Me.txtLoginPassBarber.TabIndex = 14
        '
        'txtLoginEmailBarber
        '
        Me.txtLoginEmailBarber.Location = New System.Drawing.Point(35, 255)
        Me.txtLoginEmailBarber.Multiline = True
        Me.txtLoginEmailBarber.Name = "txtLoginEmailBarber"
        Me.txtLoginEmailBarber.Size = New System.Drawing.Size(349, 43)
        Me.txtLoginEmailBarber.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Gold
        Me.Label5.Location = New System.Drawing.Point(32, 384)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Gold
        Me.Label4.Location = New System.Drawing.Point(32, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Email Address"
        '
        'btnResetBarber
        '
        Me.btnResetBarber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnResetBarber.Font = New System.Drawing.Font("Impact", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetBarber.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.btnResetBarber.Location = New System.Drawing.Point(35, 503)
        Me.btnResetBarber.Name = "btnResetBarber"
        Me.btnResetBarber.Size = New System.Drawing.Size(163, 98)
        Me.btnResetBarber.TabIndex = 16
        Me.btnResetBarber.Text = "Reset"
        Me.btnResetBarber.UseVisualStyleBackColor = True
        '
        'btnLoginBarber
        '
        Me.btnLoginBarber.Font = New System.Drawing.Font("Impact", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoginBarber.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.btnLoginBarber.Location = New System.Drawing.Point(221, 503)
        Me.btnLoginBarber.Name = "btnLoginBarber"
        Me.btnLoginBarber.Size = New System.Drawing.Size(163, 98)
        Me.btnLoginBarber.TabIndex = 16
        Me.btnLoginBarber.Text = "Login"
        Me.btnLoginBarber.UseVisualStyleBackColor = True
        '
        'btnBackBarberLogin
        '
        Me.btnBackBarberLogin.Image = Global.OMC_1_12__.NET_.My.Resources.Resources.icons8_left_arrow_30
        Me.btnBackBarberLogin.Location = New System.Drawing.Point(-4, -4)
        Me.btnBackBarberLogin.Name = "btnBackBarberLogin"
        Me.btnBackBarberLogin.Size = New System.Drawing.Size(60, 58)
        Me.btnBackBarberLogin.TabIndex = 25
        Me.btnBackBarberLogin.UseVisualStyleBackColor = True
        '
        'btnShowPassCust
        '
        Me.btnShowPassCust.BackgroundImage = Global.OMC_1_12__.NET_.My.Resources.Resources.pngwing_com
        Me.btnShowPassCust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnShowPassCust.Location = New System.Drawing.Point(358, 452)
        Me.btnShowPassCust.Name = "btnShowPassCust"
        Me.btnShowPassCust.Size = New System.Drawing.Size(26, 22)
        Me.btnShowPassCust.TabIndex = 28
        Me.btnShowPassCust.UseVisualStyleBackColor = True
        '
        'BarberLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OMC_1_12__.NET_.My.Resources.Resources.LOGINBARBBACKGROUND
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(426, 840)
        Me.Controls.Add(Me.btnShowPassCust)
        Me.Controls.Add(Me.btnBackBarberLogin)
        Me.Controls.Add(Me.btnLoginBarber)
        Me.Controls.Add(Me.btnResetBarber)
        Me.Controls.Add(Me.txtLoginPassBarber)
        Me.Controls.Add(Me.txtLoginEmailBarber)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "BarberLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barberlon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtLoginPassBarber As TextBox
    Friend WithEvents txtLoginEmailBarber As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnResetBarber As Button
    Friend WithEvents btnLoginBarber As Button
    Friend WithEvents btnBackBarberLogin As Button
    Friend WithEvents btnShowPassCust As Button
End Class
