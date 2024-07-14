<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustLogin))
        Me.btnLoginCust = New System.Windows.Forms.Button()
        Me.btnResetCust = New System.Windows.Forms.Button()
        Me.txtLoginPasswordCust = New System.Windows.Forms.TextBox()
        Me.txtLoginEmailCust = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBackCustLogin = New System.Windows.Forms.Button()
        Me.btnShowPassCust = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLoginCust
        '
        Me.btnLoginCust.Font = New System.Drawing.Font("Impact", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoginCust.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.btnLoginCust.Location = New System.Drawing.Point(226, 557)
        Me.btnLoginCust.Name = "btnLoginCust"
        Me.btnLoginCust.Size = New System.Drawing.Size(163, 98)
        Me.btnLoginCust.TabIndex = 21
        Me.btnLoginCust.Text = "Login"
        Me.btnLoginCust.UseVisualStyleBackColor = True
        '
        'btnResetCust
        '
        Me.btnResetCust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnResetCust.Font = New System.Drawing.Font("Impact", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetCust.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.btnResetCust.Location = New System.Drawing.Point(40, 557)
        Me.btnResetCust.Name = "btnResetCust"
        Me.btnResetCust.Size = New System.Drawing.Size(163, 98)
        Me.btnResetCust.TabIndex = 22
        Me.btnResetCust.Text = "Reset"
        Me.btnResetCust.UseVisualStyleBackColor = True
        '
        'txtLoginPasswordCust
        '
        Me.txtLoginPasswordCust.Location = New System.Drawing.Point(40, 405)
        Me.txtLoginPasswordCust.Multiline = True
        Me.txtLoginPasswordCust.Name = "txtLoginPasswordCust"
        Me.txtLoginPasswordCust.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtLoginPasswordCust.Size = New System.Drawing.Size(349, 43)
        Me.txtLoginPasswordCust.TabIndex = 19
        '
        'txtLoginEmailCust
        '
        Me.txtLoginEmailCust.Location = New System.Drawing.Point(40, 288)
        Me.txtLoginEmailCust.Multiline = True
        Me.txtLoginEmailCust.Name = "txtLoginEmailCust"
        Me.txtLoginEmailCust.Size = New System.Drawing.Size(349, 43)
        Me.txtLoginEmailCust.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Gold
        Me.Label5.Location = New System.Drawing.Point(37, 386)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 16)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Gold
        Me.Label4.Location = New System.Drawing.Point(37, 269)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Email Address"
        '
        'btnBackCustLogin
        '
        Me.btnBackCustLogin.Image = Global.OMC_1_12__.NET_.My.Resources.Resources.icons8_left_arrow_30
        Me.btnBackCustLogin.Location = New System.Drawing.Point(-2, -5)
        Me.btnBackCustLogin.Name = "btnBackCustLogin"
        Me.btnBackCustLogin.Size = New System.Drawing.Size(58, 59)
        Me.btnBackCustLogin.TabIndex = 24
        Me.btnBackCustLogin.UseVisualStyleBackColor = True
        '
        'btnShowPassCust
        '
        Me.btnShowPassCust.BackgroundImage = Global.OMC_1_12__.NET_.My.Resources.Resources.pngwing_com
        Me.btnShowPassCust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnShowPassCust.Location = New System.Drawing.Point(363, 454)
        Me.btnShowPassCust.Name = "btnShowPassCust"
        Me.btnShowPassCust.Size = New System.Drawing.Size(26, 22)
        Me.btnShowPassCust.TabIndex = 27
        Me.btnShowPassCust.UseVisualStyleBackColor = True
        '
        'CustLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.OMC_1_12__.NET_.My.Resources.Resources.loginCustbg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(426, 840)
        Me.Controls.Add(Me.btnShowPassCust)
        Me.Controls.Add(Me.btnBackCustLogin)
        Me.Controls.Add(Me.btnLoginCust)
        Me.Controls.Add(Me.btnResetCust)
        Me.Controls.Add(Me.txtLoginPasswordCust)
        Me.Controls.Add(Me.txtLoginEmailCust)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CustLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barberlon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLoginCust As Button
    Friend WithEvents btnResetCust As Button
    Friend WithEvents txtLoginPasswordCust As TextBox
    Friend WithEvents txtLoginEmailCust As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnBackCustLogin As Button
    Friend WithEvents btnShowPassCust As Button
End Class
