<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimeIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTimeIn))
        Me.txtStudentNo = New System.Windows.Forms.TextBox
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.txtMiddleName = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.txtRFID = New System.Windows.Forms.TextBox
        Me.lblTerminalNo = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnSave = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.txtContactNum = New System.Windows.Forms.TextBox
        Me.txtMessage = New System.Windows.Forms.TextBox
        Me.btnSend = New System.Windows.Forms.Button
        Me.cboPorts = New System.Windows.Forms.ComboBox
        Me.txttimeout = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtStudentNo
        '
        Me.txtStudentNo.Location = New System.Drawing.Point(24, 106)
        Me.txtStudentNo.Name = "txtStudentNo"
        Me.txtStudentNo.Size = New System.Drawing.Size(185, 26)
        Me.txtStudentNo.TabIndex = 30
        Me.txtStudentNo.TabStop = False
        Me.txtStudentNo.Visible = False
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(343, 416)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.ReadOnly = True
        Me.txtLastName.Size = New System.Drawing.Size(147, 30)
        Me.txtLastName.TabIndex = 37
        Me.txtLastName.TabStop = False
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(343, 349)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.ReadOnly = True
        Me.txtFirstName.Size = New System.Drawing.Size(147, 30)
        Me.txtFirstName.TabIndex = 36
        Me.txtFirstName.TabStop = False
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddleName.Location = New System.Drawing.Point(343, 383)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.ReadOnly = True
        Me.txtMiddleName.Size = New System.Drawing.Size(147, 30)
        Me.txtMiddleName.TabIndex = 35
        Me.txtMiddleName.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(256, 419)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 22)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(235, 386)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 22)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Middle Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(253, 352)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 22)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "First Name"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(254, 74)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(236, 255)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'txtRFID
        '
        Me.txtRFID.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRFID.ForeColor = System.Drawing.Color.Black
        Me.txtRFID.Location = New System.Drawing.Point(260, 292)
        Me.txtRFID.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtRFID.Name = "txtRFID"
        Me.txtRFID.Size = New System.Drawing.Size(199, 37)
        Me.txtRFID.TabIndex = 29
        '
        'lblTerminalNo
        '
        Me.lblTerminalNo.AutoSize = True
        Me.lblTerminalNo.Location = New System.Drawing.Point(45, 205)
        Me.lblTerminalNo.Name = "lblTerminalNo"
        Me.lblTerminalNo.Size = New System.Drawing.Size(89, 19)
        Me.lblTerminalNo.TabIndex = 38
        Me.lblTerminalNo.Text = "lblTerminalNo"
        Me.lblTerminalNo.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 2000
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(299, 74)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 28)
        Me.btnSave.TabIndex = 39
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(756, 67)
        Me.PictureBox2.TabIndex = 40
        Me.PictureBox2.TabStop = False
        '
        'txtContactNum
        '
        Me.txtContactNum.Location = New System.Drawing.Point(574, 141)
        Me.txtContactNum.Name = "txtContactNum"
        Me.txtContactNum.Size = New System.Drawing.Size(142, 26)
        Me.txtContactNum.TabIndex = 41
        Me.txtContactNum.Visible = False
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(504, 173)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(212, 156)
        Me.txtMessage.TabIndex = 42
        Me.txtMessage.Visible = False
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(407, 349)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 43
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'cboPorts
        '
        Me.cboPorts.FormattingEnabled = True
        Me.cboPorts.Location = New System.Drawing.Point(595, 105)
        Me.cboPorts.Name = "cboPorts"
        Me.cboPorts.Size = New System.Drawing.Size(121, 27)
        Me.cboPorts.TabIndex = 44
        Me.cboPorts.Visible = False
        '
        'txttimeout
        '
        Me.txttimeout.Location = New System.Drawing.Point(559, 382)
        Me.txttimeout.Name = "txttimeout"
        Me.txttimeout.Size = New System.Drawing.Size(157, 26)
        Me.txttimeout.TabIndex = 45
        Me.txttimeout.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(533, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 19)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Port No."
        Me.Label1.Visible = False
        '
        'frmTimeIn
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(758, 457)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txttimeout)
        Me.Controls.Add(Me.cboPorts)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.txtContactNum)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblTerminalNo)
        Me.Controls.Add(Me.txtStudentNo)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtMiddleName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtRFID)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnSend)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTimeIn"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtStudentNo As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtMiddleName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtRFID As System.Windows.Forms.TextBox
    Friend WithEvents lblTerminalNo As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents txtContactNum As System.Windows.Forms.TextBox
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents cboPorts As System.Windows.Forms.ComboBox
    Friend WithEvents txttimeout As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
