<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustBook
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustBook))
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.cboSelBarber = New System.Windows.Forms.ComboBox()
        Me.txtService = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblCustName = New System.Windows.Forms.Label()
        Me.btnToPayment = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtDate
        '
        Me.txtDate.BackColor = System.Drawing.SystemColors.Info
        Me.txtDate.Font = New System.Drawing.Font("Impact", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Location = New System.Drawing.Point(60, 548)
        Me.txtDate.Multiline = True
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(319, 41)
        Me.txtDate.TabIndex = 17
        '
        'txtTime
        '
        Me.txtTime.BackColor = System.Drawing.SystemColors.Info
        Me.txtTime.Font = New System.Drawing.Font("Impact", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime.Location = New System.Drawing.Point(60, 471)
        Me.txtTime.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTime.Multiline = True
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(319, 38)
        Me.txtTime.TabIndex = 19
        '
        'cboSelBarber
        '
        Me.cboSelBarber.BackColor = System.Drawing.SystemColors.Info
        Me.cboSelBarber.Font = New System.Drawing.Font("Impact", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSelBarber.FormattingEnabled = True
        Me.cboSelBarber.Items.AddRange(New Object() {"HAZIQ", "DANI", "NERVINDRAJ", "WILFRED", "ANIS", "SYAFIQAH"})
        Me.cboSelBarber.Location = New System.Drawing.Point(60, 629)
        Me.cboSelBarber.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboSelBarber.Name = "cboSelBarber"
        Me.cboSelBarber.Size = New System.Drawing.Size(319, 36)
        Me.cboSelBarber.TabIndex = 20
        '
        'txtService
        '
        Me.txtService.BackColor = System.Drawing.SystemColors.Info
        Me.txtService.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtService.Font = New System.Drawing.Font("Impact", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtService.Location = New System.Drawing.Point(60, 389)
        Me.txtService.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtService.Multiline = True
        Me.txtService.Name = "txtService"
        Me.txtService.Size = New System.Drawing.Size(319, 38)
        Me.txtService.TabIndex = 22
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BackgroundImage = Global.OMC_1_12__.NET_.My.Resources.Resources.icons8_left_arrow_30
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBack.Location = New System.Drawing.Point(-2, -1)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(56, 52)
        Me.btnBack.TabIndex = 23
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(56, 366)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 21)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Service:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(56, 448)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 21)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Time:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(60, 524)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 21)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(56, 606)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 21)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Barber:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Silver
        Me.Label5.Location = New System.Drawing.Point(56, 667)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 15)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "*Please select one"
        '
        'lblCustName
        '
        Me.lblCustName.AutoSize = True
        Me.lblCustName.BackColor = System.Drawing.Color.Transparent
        Me.lblCustName.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCustName.Location = New System.Drawing.Point(116, 97)
        Me.lblCustName.Name = "lblCustName"
        Me.lblCustName.Size = New System.Drawing.Size(114, 25)
        Me.lblCustName.TabIndex = 25
        Me.lblCustName.Text = "lblCustName"
        '
        'btnToPayment
        '
        Me.btnToPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnToPayment.Font = New System.Drawing.Font("Impact", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToPayment.Location = New System.Drawing.Point(60, 779)
        Me.btnToPayment.Name = "btnToPayment"
        Me.btnToPayment.Size = New System.Drawing.Size(319, 49)
        Me.btnToPayment.TabIndex = 26
        Me.btnToPayment.Text = "Proceed to Payment"
        Me.btnToPayment.UseVisualStyleBackColor = False
        '
        'CustBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.OMC_1_12__.NET_.My.Resources.Resources.CustBook1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(426, 840)
        Me.Controls.Add(Me.btnToPayment)
        Me.Controls.Add(Me.lblCustName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtService)
        Me.Controls.Add(Me.cboSelBarber)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.txtDate)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CustBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barberlon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtTime As TextBox
    Friend WithEvents cboSelBarber As ComboBox
    Friend WithEvents txtService As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblCustName As Label
    Friend WithEvents btnToPayment As Button
End Class
