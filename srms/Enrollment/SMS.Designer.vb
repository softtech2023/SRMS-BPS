<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSMS
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.dg1 = New System.Windows.Forms.DataGridView
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboPort = New System.Windows.Forms.ComboBox
        Me.txtMessage = New System.Windows.Forms.TextBox
        Me.btnSend = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtSubject = New System.Windows.Forms.TextBox
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.txttimeout = New System.Windows.Forms.TextBox
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Recepients"
        '
        'dg1
        '
        Me.dg1.AllowUserToAddRows = False
        Me.dg1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dg1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg1.Location = New System.Drawing.Point(2, 47)
        Me.dg1.Name = "dg1"
        Me.dg1.Size = New System.Drawing.Size(465, 325)
        Me.dg1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(476, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Message"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(284, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Port No."
        '
        'cboPort
        '
        Me.cboPort.FormattingEnabled = True
        Me.cboPort.Location = New System.Drawing.Point(346, 17)
        Me.cboPort.Name = "cboPort"
        Me.cboPort.Size = New System.Drawing.Size(121, 27)
        Me.cboPort.TabIndex = 4
        '
        'txtMessage
        '
        Me.txtMessage.AcceptsReturn = True
        Me.txtMessage.Location = New System.Drawing.Point(480, 85)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(320, 251)
        Me.txtMessage.TabIndex = 5
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(656, 342)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(144, 30)
        Me.btnSend.TabIndex = 6
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(476, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Subject"
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(542, 18)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(211, 26)
        Me.txtSubject.TabIndex = 8
        '
        'txttimeout
        '
        Me.txttimeout.Location = New System.Drawing.Point(480, 345)
        Me.txttimeout.Name = "txttimeout"
        Me.txttimeout.Size = New System.Drawing.Size(100, 26)
        Me.txttimeout.TabIndex = 9
        '
        'frmSMS
        '
        Me.AcceptButton = Me.btnSend
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 377)
        Me.Controls.Add(Me.txttimeout)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.cboPort)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dg1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmSMS"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Short Service Message (SMS)"
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dg1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboPort As System.Windows.Forms.ComboBox
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSubject As System.Windows.Forms.TextBox
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents txttimeout As System.Windows.Forms.TextBox
End Class
