<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustPayMethod
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustPayMethod))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblBarberName = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.btnToQR = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblService = New System.Windows.Forms.Label()
        Me.lblCustName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(120, 233)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Barber Name:"
        '
        'lblBarberName
        '
        Me.lblBarberName.BackColor = System.Drawing.SystemColors.Info
        Me.lblBarberName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.lblBarberName.Location = New System.Drawing.Point(120, 249)
        Me.lblBarberName.Name = "lblBarberName"
        Me.lblBarberName.Size = New System.Drawing.Size(221, 36)
        Me.lblBarberName.TabIndex = 7
        Me.lblBarberName.Text = "                       "
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.SystemColors.Info
        Me.lblDate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.lblDate.Location = New System.Drawing.Point(69, 333)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(221, 36)
        Me.lblDate.TabIndex = 8
        Me.lblDate.Text = "                                  "
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.SystemColors.Info
        Me.lblTime.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.lblTime.Location = New System.Drawing.Point(69, 401)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(221, 38)
        Me.lblTime.TabIndex = 9
        Me.lblTime.Text = "                                  "
        '
        'btnToQR
        '
        Me.btnToQR.BackColor = System.Drawing.SystemColors.Info
        Me.btnToQR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnToQR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnToQR.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToQR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnToQR.Location = New System.Drawing.Point(58, 713)
        Me.btnToQR.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnToQR.Name = "btnToQR"
        Me.btnToQR.Size = New System.Drawing.Size(311, 63)
        Me.btnToQR.TabIndex = 10
        Me.btnToQR.Text = "Proceed to QR Payment"
        Me.btnToQR.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BackgroundImage = Global.OMC_1_12__.NET_.My.Resources.Resources.icons8_left_arrow_30
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBack.Location = New System.Drawing.Point(-1, -5)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(46, 46)
        Me.btnBack.TabIndex = 12
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(69, 525)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Service:"
        '
        'lblService
        '
        Me.lblService.BackColor = System.Drawing.SystemColors.Info
        Me.lblService.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.lblService.Location = New System.Drawing.Point(69, 541)
        Me.lblService.Name = "lblService"
        Me.lblService.Size = New System.Drawing.Size(221, 36)
        Me.lblService.TabIndex = 7
        Me.lblService.Text = "                       "
        '
        'lblCustName
        '
        Me.lblCustName.AutoSize = True
        Me.lblCustName.BackColor = System.Drawing.Color.Transparent
        Me.lblCustName.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustName.Location = New System.Drawing.Point(118, 81)
        Me.lblCustName.Name = "lblCustName"
        Me.lblCustName.Size = New System.Drawing.Size(114, 25)
        Me.lblCustName.TabIndex = 13
        Me.lblCustName.Text = "lblCustName"
        '
        'CustPayMethod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OMC_1_12__.NET_.My.Resources.Resources.BookPayment
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(426, 840)
        Me.Controls.Add(Me.lblCustName)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnToQR)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblService)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblBarberName)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CustPayMethod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barberlon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents lblBarberName As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents btnToQR As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblService As Label
    Friend WithEvents lblCustName As Label
End Class
