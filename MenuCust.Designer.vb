<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuCust
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuCust))
        Me.btnMyProfile = New System.Windows.Forms.Button()
        Me.btnMybooking = New System.Windows.Forms.Button()
        Me.btnViewreceipt = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMyProfile
        '
        Me.btnMyProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnMyProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMyProfile.Font = New System.Drawing.Font("Impact", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMyProfile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnMyProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMyProfile.Location = New System.Drawing.Point(58, 128)
        Me.btnMyProfile.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMyProfile.Name = "btnMyProfile"
        Me.btnMyProfile.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnMyProfile.Size = New System.Drawing.Size(309, 77)
        Me.btnMyProfile.TabIndex = 0
        Me.btnMyProfile.Text = "My profile"
        Me.btnMyProfile.UseVisualStyleBackColor = False
        '
        'btnMybooking
        '
        Me.btnMybooking.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnMybooking.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMybooking.Font = New System.Drawing.Font("Impact", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMybooking.Location = New System.Drawing.Point(58, 242)
        Me.btnMybooking.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMybooking.Name = "btnMybooking"
        Me.btnMybooking.Size = New System.Drawing.Size(309, 87)
        Me.btnMybooking.TabIndex = 1
        Me.btnMybooking.Text = "My booking"
        Me.btnMybooking.UseVisualStyleBackColor = False
        '
        'btnViewreceipt
        '
        Me.btnViewreceipt.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnViewreceipt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnViewreceipt.Font = New System.Drawing.Font("Impact", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewreceipt.Location = New System.Drawing.Point(58, 359)
        Me.btnViewreceipt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnViewreceipt.Name = "btnViewreceipt"
        Me.btnViewreceipt.Size = New System.Drawing.Size(309, 87)
        Me.btnViewreceipt.TabIndex = 2
        Me.btnViewreceipt.Text = "View Receipt"
        Me.btnViewreceipt.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogout.Font = New System.Drawing.Font("Impact", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.Firebrick
        Me.btnLogout.Location = New System.Drawing.Point(58, 704)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(309, 30)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.Text = "Log out"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.Transparent
        Me.btnMenu.BackgroundImage = Global.OMC_1_12__.NET_.My.Resources.Resources.icons8_left_arrow_30
        Me.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMenu.Location = New System.Drawing.Point(-4, -1)
        Me.btnMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(63, 56)
        Me.btnMenu.TabIndex = 9
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'MenuCust
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.OMC_1_12__.NET_.My.Resources.Resources.DefaultBG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(426, 840)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnMyProfile)
        Me.Controls.Add(Me.btnMybooking)
        Me.Controls.Add(Me.btnViewreceipt)
        Me.Controls.Add(Me.btnLogout)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "MenuCust"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barberlon"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnMyProfile As Button
    Friend WithEvents btnMybooking As Button
    Friend WithEvents btnViewreceipt As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnMenu As Button
End Class
