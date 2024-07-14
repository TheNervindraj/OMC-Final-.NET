<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubscriptionPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SubscriptionPage))
        Me.Subscribe = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblContent = New System.Windows.Forms.Label()
        Me.btnSubsHere = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblCustName = New System.Windows.Forms.Label()
        Me.Subscribe.SuspendLayout()
        Me.SuspendLayout()
        '
        'Subscribe
        '
        Me.Subscribe.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.Subscribe.Controls.Add(Me.Label4)
        Me.Subscribe.Controls.Add(Me.lblContent)
        Me.Subscribe.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subscribe.Location = New System.Drawing.Point(50, 243)
        Me.Subscribe.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Subscribe.Name = "Subscribe"
        Me.Subscribe.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Subscribe.Size = New System.Drawing.Size(329, 415)
        Me.Subscribe.TabIndex = 5
        Me.Subscribe.TabStop = False
        Me.Subscribe.Text = "Subscribe Now!"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-5, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 75)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Start with: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "* RM7.50 per month" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblContent
        '
        Me.lblContent.Location = New System.Drawing.Point(-5, 54)
        Me.lblContent.Name = "lblContent"
        Me.lblContent.Size = New System.Drawing.Size(334, 133)
        Me.lblContent.TabIndex = 1
        Me.lblContent.Text = "Barbelon Plus" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "* Free of Booking Fee" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "* Get Discounted Products and Haircuts fr" &
    "om 10%" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnSubsHere
        '
        Me.btnSubsHere.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.btnSubsHere.Location = New System.Drawing.Point(50, 702)
        Me.btnSubsHere.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSubsHere.Name = "btnSubsHere"
        Me.btnSubsHere.Size = New System.Drawing.Size(329, 37)
        Me.btnSubsHere.TabIndex = 7
        Me.btnSubsHere.Text = "SUBSCRIBE HERE"
        Me.btnSubsHere.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Image = Global.OMC_1_12__.NET_.My.Resources.Resources.icons8_left_arrow_30
        Me.btnBack.Location = New System.Drawing.Point(-1, -1)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(60, 46)
        Me.btnBack.TabIndex = 0
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblCustName
        '
        Me.lblCustName.AutoSize = True
        Me.lblCustName.BackColor = System.Drawing.Color.Transparent
        Me.lblCustName.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustName.Location = New System.Drawing.Point(110, 101)
        Me.lblCustName.Name = "lblCustName"
        Me.lblCustName.Size = New System.Drawing.Size(114, 25)
        Me.lblCustName.TabIndex = 8
        Me.lblCustName.Text = "lblCustName"
        '
        'SubscriptionPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OMC_1_12__.NET_.My.Resources.Resources.subscriptionbg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(426, 840)
        Me.Controls.Add(Me.lblCustName)
        Me.Controls.Add(Me.btnSubsHere)
        Me.Controls.Add(Me.Subscribe)
        Me.Controls.Add(Me.btnBack)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "SubscriptionPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barberlon"
        Me.Subscribe.ResumeLayout(False)
        Me.Subscribe.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents Subscribe As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblContent As Label
    Friend WithEvents btnSubsHere As Button
    Friend WithEvents lblCustName As Label
End Class
