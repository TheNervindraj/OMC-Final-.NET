<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuBarber
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
        Me.btnMyProfile = New System.Windows.Forms.Button()
        Me.btnMybooking = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMyProfile
        '
        Me.btnMyProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnMyProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMyProfile.Font = New System.Drawing.Font("Impact", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMyProfile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnMyProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMyProfile.Location = New System.Drawing.Point(59, 117)
        Me.btnMyProfile.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMyProfile.Name = "btnMyProfile"
        Me.btnMyProfile.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnMyProfile.Size = New System.Drawing.Size(309, 144)
        Me.btnMyProfile.TabIndex = 4
        Me.btnMyProfile.Text = "My profile"
        Me.btnMyProfile.UseVisualStyleBackColor = False
        '
        'btnMybooking
        '
        Me.btnMybooking.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnMybooking.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMybooking.Font = New System.Drawing.Font("Impact", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMybooking.Location = New System.Drawing.Point(59, 305)
        Me.btnMybooking.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMybooking.Name = "btnMybooking"
        Me.btnMybooking.Size = New System.Drawing.Size(309, 139)
        Me.btnMybooking.TabIndex = 5
        Me.btnMybooking.Text = "View Customer Receipts"
        Me.btnMybooking.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogout.Font = New System.Drawing.Font("Impact", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.Firebrick
        Me.btnLogout.Location = New System.Drawing.Point(59, 693)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(309, 30)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.Text = "Log out"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BackgroundImage = Global.OMC_1_12__.NET_.My.Resources.Resources.icons8_left_arrow_30
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBack.Location = New System.Drawing.Point(-4, -2)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(62, 57)
        Me.btnBack.TabIndex = 25
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'MenuBarber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OMC_1_12__.NET_.My.Resources.Resources.DefaultBG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(426, 840)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnMyProfile)
        Me.Controls.Add(Me.btnMybooking)
        Me.Controls.Add(Me.btnLogout)
        Me.DoubleBuffered = True
        Me.Name = "MenuBarber"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuBarber"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMyProfile As Button
    Friend WithEvents btnMybooking As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnBack As Button
End Class
