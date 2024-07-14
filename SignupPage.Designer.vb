<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignupPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignupPage))
        Me.btnToSignupBarber = New System.Windows.Forms.Button()
        Me.btnToSignupCust = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBackSignupPage = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnToSignupBarber
        '
        Me.btnToSignupBarber.BackgroundImage = Global.OMC_1_12__.NET_.My.Resources.Resources.icons8_man_combing_hair_100
        Me.btnToSignupBarber.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToSignupBarber.ForeColor = System.Drawing.Color.Orange
        Me.btnToSignupBarber.Location = New System.Drawing.Point(12, 303)
        Me.btnToSignupBarber.Name = "btnToSignupBarber"
        Me.btnToSignupBarber.Size = New System.Drawing.Size(402, 206)
        Me.btnToSignupBarber.TabIndex = 0
        Me.btnToSignupBarber.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnToSignupBarber.UseVisualStyleBackColor = True
        '
        'btnToSignupCust
        '
        Me.btnToSignupCust.BackgroundImage = Global.OMC_1_12__.NET_.My.Resources.Resources.icons8_man_100
        Me.btnToSignupCust.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToSignupCust.Location = New System.Drawing.Point(12, 568)
        Me.btnToSignupCust.Name = "btnToSignupCust"
        Me.btnToSignupCust.Size = New System.Drawing.Size(402, 191)
        Me.btnToSignupCust.TabIndex = 0
        Me.btnToSignupCust.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Eras Demi ITC", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(80, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(290, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Let's get you started!"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Eras Demi ITC", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(143, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 37)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "I'm a ...?"
        '
        'btnBackSignupPage
        '
        Me.btnBackSignupPage.Image = Global.OMC_1_12__.NET_.My.Resources.Resources.icons8_left_arrow_30
        Me.btnBackSignupPage.Location = New System.Drawing.Point(-7, -7)
        Me.btnBackSignupPage.Name = "btnBackSignupPage"
        Me.btnBackSignupPage.Size = New System.Drawing.Size(74, 54)
        Me.btnBackSignupPage.TabIndex = 4
        Me.btnBackSignupPage.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Eras Demi ITC", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(181, 486)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "BARBER"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Eras Demi ITC", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gold
        Me.Label4.Location = New System.Drawing.Point(171, 732)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "CUSTOMER"
        '
        'SignupPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OMC_1_12__.NET_.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(426, 840)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBackSignupPage)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnToSignupCust)
        Me.Controls.Add(Me.btnToSignupBarber)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "SignupPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barberlon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnToSignupBarber As Button
    Friend WithEvents btnToSignupCust As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnBackSignupPage As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
End Class
