<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BarberHomepage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BarberHomepage))
        Me.btnAppointmentBarber = New System.Windows.Forms.Button()
        Me.btnShopReminder = New System.Windows.Forms.Button()
        Me.btnLogOutBarberHomepage = New System.Windows.Forms.Button()
        Me.lblNameBarber = New System.Windows.Forms.Label()
        Me.btnMenuBarbHome = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAppointmentBarber
        '
        Me.btnAppointmentBarber.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnAppointmentBarber.Location = New System.Drawing.Point(115, 259)
        Me.btnAppointmentBarber.Name = "btnAppointmentBarber"
        Me.btnAppointmentBarber.Size = New System.Drawing.Size(261, 123)
        Me.btnAppointmentBarber.TabIndex = 0
        Me.btnAppointmentBarber.Text = "Appointment"
        Me.btnAppointmentBarber.UseVisualStyleBackColor = False
        '
        'btnShopReminder
        '
        Me.btnShopReminder.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnShopReminder.Location = New System.Drawing.Point(115, 423)
        Me.btnShopReminder.Name = "btnShopReminder"
        Me.btnShopReminder.Size = New System.Drawing.Size(261, 141)
        Me.btnShopReminder.TabIndex = 0
        Me.btnShopReminder.Text = "Shop Open Reminder"
        Me.btnShopReminder.UseVisualStyleBackColor = False
        '
        'btnLogOutBarberHomepage
        '
        Me.btnLogOutBarberHomepage.Font = New System.Drawing.Font("Impact", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOutBarberHomepage.ForeColor = System.Drawing.Color.Red
        Me.btnLogOutBarberHomepage.Image = Global.OMC_1_12__.NET_.My.Resources.Resources.icons8_left_arrow_30
        Me.btnLogOutBarberHomepage.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLogOutBarberHomepage.Location = New System.Drawing.Point(-5, -4)
        Me.btnLogOutBarberHomepage.Name = "btnLogOutBarberHomepage"
        Me.btnLogOutBarberHomepage.Size = New System.Drawing.Size(67, 54)
        Me.btnLogOutBarberHomepage.TabIndex = 2
        Me.btnLogOutBarberHomepage.Text = "Log Out"
        Me.btnLogOutBarberHomepage.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLogOutBarberHomepage.UseVisualStyleBackColor = True
        '
        'lblNameBarber
        '
        Me.lblNameBarber.AutoSize = True
        Me.lblNameBarber.BackColor = System.Drawing.Color.Transparent
        Me.lblNameBarber.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameBarber.Location = New System.Drawing.Point(139, 89)
        Me.lblNameBarber.Name = "lblNameBarber"
        Me.lblNameBarber.Size = New System.Drawing.Size(133, 25)
        Me.lblNameBarber.TabIndex = 3
        Me.lblNameBarber.Text = "lblNameBarber"
        '
        'btnMenuBarbHome
        '
        Me.btnMenuBarbHome.BackColor = System.Drawing.Color.Transparent
        Me.btnMenuBarbHome.BackgroundImage = Global.OMC_1_12__.NET_.My.Resources.Resources.Hamburger_icon_svg
        Me.btnMenuBarbHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMenuBarbHome.Location = New System.Drawing.Point(359, 11)
        Me.btnMenuBarbHome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMenuBarbHome.Name = "btnMenuBarbHome"
        Me.btnMenuBarbHome.Size = New System.Drawing.Size(55, 39)
        Me.btnMenuBarbHome.TabIndex = 11
        Me.btnMenuBarbHome.UseVisualStyleBackColor = False
        '
        'BarberHomepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OMC_1_12__.NET_.My.Resources.Resources.barberhome
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(426, 840)
        Me.Controls.Add(Me.btnMenuBarbHome)
        Me.Controls.Add(Me.lblNameBarber)
        Me.Controls.Add(Me.btnLogOutBarberHomepage)
        Me.Controls.Add(Me.btnShopReminder)
        Me.Controls.Add(Me.btnAppointmentBarber)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "BarberHomepage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barberlon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAppointmentBarber As Button
    Friend WithEvents btnShopReminder As Button
    Friend WithEvents btnLogOutBarberHomepage As Button
    Friend WithEvents lblNameBarber As Label
    Friend WithEvents btnMenuBarbHome As Button
End Class
