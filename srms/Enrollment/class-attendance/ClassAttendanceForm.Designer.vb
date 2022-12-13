<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClassAttendanceForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClassAttendanceForm))
        Me.lblTeacher = New System.Windows.Forms.TextBox
        Me.lblSection = New System.Windows.Forms.TextBox
        Me.lblDescription = New System.Windows.Forms.TextBox
        Me.lblSubjectCode = New System.Windows.Forms.TextBox
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.txtMiddleName = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtStudentNumber = New System.Windows.Forms.TextBox
        Me.btnLogin = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClassAttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ByDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ByOptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintAttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DailyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.lblTerminalNo = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.btnSelect = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTeacher
        '
        Me.lblTeacher.Location = New System.Drawing.Point(98, 223)
        Me.lblTeacher.Name = "lblTeacher"
        Me.lblTeacher.Size = New System.Drawing.Size(272, 26)
        Me.lblTeacher.TabIndex = 34
        Me.lblTeacher.TabStop = False
        '
        'lblSection
        '
        Me.lblSection.Location = New System.Drawing.Point(98, 191)
        Me.lblSection.Name = "lblSection"
        Me.lblSection.Size = New System.Drawing.Size(272, 26)
        Me.lblSection.TabIndex = 33
        Me.lblSection.TabStop = False
        '
        'lblDescription
        '
        Me.lblDescription.Location = New System.Drawing.Point(98, 159)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(272, 26)
        Me.lblDescription.TabIndex = 32
        Me.lblDescription.TabStop = False
        '
        'lblSubjectCode
        '
        Me.lblSubjectCode.Location = New System.Drawing.Point(98, 127)
        Me.lblSubjectCode.Name = "lblSubjectCode"
        Me.lblSubjectCode.Size = New System.Drawing.Size(100, 26)
        Me.lblSubjectCode.TabIndex = 31
        Me.lblSubjectCode.TabStop = False
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(660, 433)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.ReadOnly = True
        Me.txtLastName.Size = New System.Drawing.Size(147, 30)
        Me.txtLastName.TabIndex = 29
        Me.txtLastName.TabStop = False
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(660, 366)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.ReadOnly = True
        Me.txtFirstName.Size = New System.Drawing.Size(147, 30)
        Me.txtFirstName.TabIndex = 28
        Me.txtFirstName.TabStop = False
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddleName.Location = New System.Drawing.Point(660, 400)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.ReadOnly = True
        Me.txtMiddleName.Size = New System.Drawing.Size(147, 30)
        Me.txtMiddleName.TabIndex = 27
        Me.txtMiddleName.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtStudentNumber)
        Me.Panel1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(-7, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(856, 37)
        Me.Panel1.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe Condensed", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(15, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(318, 28)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "CLASS ATTENDANCE MONITORING"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(420, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "STUDENT NUMBER"
        '
        'txtStudentNumber
        '
        Me.txtStudentNumber.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentNumber.Location = New System.Drawing.Point(605, 0)
        Me.txtStudentNumber.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtStudentNumber.Name = "txtStudentNumber"
        Me.txtStudentNumber.Size = New System.Drawing.Size(209, 37)
        Me.txtStudentNumber.TabIndex = 0
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(571, 289)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(119, 40)
        Me.btnLogin.TabIndex = 30
        Me.btnLogin.TabStop = False
        Me.btnLogin.Text = "F4 - Log In"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(571, 103)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(236, 257)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.PrintAttendanceToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(842, 56)
        Me.MenuStrip1.TabIndex = 35
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClassAttendanceToolStripMenuItem, Me.ResetToolStripMenuItem, Me.LoginToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 52)
        Me.MenuToolStripMenuItem.Text = "Menu"
        Me.MenuToolStripMenuItem.Visible = False
        '
        'ClassAttendanceToolStripMenuItem
        '
        Me.ClassAttendanceToolStripMenuItem.Name = "ClassAttendanceToolStripMenuItem"
        Me.ClassAttendanceToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.ClassAttendanceToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.ClassAttendanceToolStripMenuItem.Text = "Class Attendance"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ByDateToolStripMenuItem, Me.ByOptionToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'ByDateToolStripMenuItem
        '
        Me.ByDateToolStripMenuItem.Name = "ByDateToolStripMenuItem"
        Me.ByDateToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.ByDateToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.ByDateToolStripMenuItem.Text = "By Date"
        '
        'ByOptionToolStripMenuItem
        '
        Me.ByOptionToolStripMenuItem.Name = "ByOptionToolStripMenuItem"
        Me.ByOptionToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.ByOptionToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.ByOptionToolStripMenuItem.Text = "By Option"
        '
        'PrintAttendanceToolStripMenuItem
        '
        Me.PrintAttendanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DailyToolStripMenuItem})
        Me.PrintAttendanceToolStripMenuItem.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintAttendanceToolStripMenuItem.Image = CType(resources.GetObject("PrintAttendanceToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintAttendanceToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PrintAttendanceToolStripMenuItem.Name = "PrintAttendanceToolStripMenuItem"
        Me.PrintAttendanceToolStripMenuItem.Size = New System.Drawing.Size(163, 52)
        Me.PrintAttendanceToolStripMenuItem.Text = "Print Attendance"
        '
        'DailyToolStripMenuItem
        '
        Me.DailyToolStripMenuItem.Name = "DailyToolStripMenuItem"
        Me.DailyToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.DailyToolStripMenuItem.Text = "Daily"
        '
        'lblTerminalNo
        '
        Me.lblTerminalNo.AutoSize = True
        Me.lblTerminalNo.Location = New System.Drawing.Point(468, 310)
        Me.lblTerminalNo.Name = "lblTerminalNo"
        Me.lblTerminalNo.Size = New System.Drawing.Size(80, 19)
        Me.lblTerminalNo.TabIndex = 36
        Me.lblTerminalNo.Text = "Terminal No"
        Me.lblTerminalNo.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(582, 372)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 19)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(568, 406)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 19)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Middle Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(583, 439)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 19)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Last Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 19)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Subject Code"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 19)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Description"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(42, 194)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 19)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Section"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(37, 226)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 19)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Teacher"
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(204, 127)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(75, 27)
        Me.btnSelect.TabIndex = 44
        Me.btnSelect.TabStop = False
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'frmClassAttendanceForm
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 474)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTerminalNo)
        Me.Controls.Add(Me.lblTeacher)
        Me.Controls.Add(Me.lblSection)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblSubjectCode)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtMiddleName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmClassAttendanceForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "::"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTeacher As System.Windows.Forms.TextBox
    Friend WithEvents lblSection As System.Windows.Forms.TextBox
    Friend WithEvents lblDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblSubjectCode As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtMiddleName As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtStudentNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClassAttendanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ByDateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ByOptionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblTerminalNo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PrintAttendanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DailyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
