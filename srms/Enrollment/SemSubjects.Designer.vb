<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSemSubjects
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSemSubjects))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cboClass = New System.Windows.Forms.ComboBox
        Me.Button6 = New System.Windows.Forms.Button
        Me.txtInstructor = New System.Windows.Forms.TextBox
        Me.txtSlot = New System.Windows.Forms.TextBox
        Me.txtRoom = New System.Windows.Forms.TextBox
        Me.txtDay = New System.Windows.Forms.TextBox
        Me.txtTime = New System.Windows.Forms.TextBox
        Me.txtLabUnits = New System.Windows.Forms.TextBox
        Me.txtSection = New System.Windows.Forms.TextBox
        Me.txtLecUnits = New System.Windows.Forms.TextBox
        Me.txtSubjectDescription = New System.Windows.Forms.TextBox
        Me.txtSubjectCode = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblID = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.cboClass)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.txtInstructor)
        Me.GroupBox1.Controls.Add(Me.txtSlot)
        Me.GroupBox1.Controls.Add(Me.txtRoom)
        Me.GroupBox1.Controls.Add(Me.txtDay)
        Me.GroupBox1.Controls.Add(Me.txtTime)
        Me.GroupBox1.Controls.Add(Me.txtLabUnits)
        Me.GroupBox1.Controls.Add(Me.txtSection)
        Me.GroupBox1.Controls.Add(Me.txtLecUnits)
        Me.GroupBox1.Controls.Add(Me.txtSubjectDescription)
        Me.GroupBox1.Controls.Add(Me.txtSubjectCode)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(12, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(515, 267)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cboClass
        '
        Me.cboClass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cboClass.FormattingEnabled = True
        Me.cboClass.Items.AddRange(New Object() {"Lec", "Lab"})
        Me.cboClass.Location = New System.Drawing.Point(271, 170)
        Me.cboClass.Name = "cboClass"
        Me.cboClass.Size = New System.Drawing.Size(76, 26)
        Me.cboClass.TabIndex = 14
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(365, 219)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(30, 23)
        Me.Button6.TabIndex = 12
        Me.Button6.UseVisualStyleBackColor = True
        '
        'txtInstructor
        '
        Me.txtInstructor.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtInstructor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtInstructor.Location = New System.Drawing.Point(111, 219)
        Me.txtInstructor.Name = "txtInstructor"
        Me.txtInstructor.Size = New System.Drawing.Size(236, 24)
        Me.txtInstructor.TabIndex = 11
        '
        'txtSlot
        '
        Me.txtSlot.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtSlot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtSlot.Location = New System.Drawing.Point(111, 170)
        Me.txtSlot.Name = "txtSlot"
        Me.txtSlot.Size = New System.Drawing.Size(76, 24)
        Me.txtSlot.TabIndex = 9
        '
        'txtRoom
        '
        Me.txtRoom.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtRoom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtRoom.Location = New System.Drawing.Point(433, 130)
        Me.txtRoom.Name = "txtRoom"
        Me.txtRoom.Size = New System.Drawing.Size(76, 24)
        Me.txtRoom.TabIndex = 8
        '
        'txtDay
        '
        Me.txtDay.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtDay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtDay.Location = New System.Drawing.Point(271, 130)
        Me.txtDay.Name = "txtDay"
        Me.txtDay.Size = New System.Drawing.Size(76, 24)
        Me.txtDay.TabIndex = 7
        '
        'txtTime
        '
        Me.txtTime.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtTime.Location = New System.Drawing.Point(111, 130)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(76, 24)
        Me.txtTime.TabIndex = 6
        '
        'txtLabUnits
        '
        Me.txtLabUnits.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtLabUnits.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtLabUnits.Location = New System.Drawing.Point(271, 84)
        Me.txtLabUnits.Name = "txtLabUnits"
        Me.txtLabUnits.Size = New System.Drawing.Size(76, 24)
        Me.txtLabUnits.TabIndex = 4
        '
        'txtSection
        '
        Me.txtSection.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtSection.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtSection.Location = New System.Drawing.Point(433, 81)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.Size = New System.Drawing.Size(76, 24)
        Me.txtSection.TabIndex = 5
        '
        'txtLecUnits
        '
        Me.txtLecUnits.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtLecUnits.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtLecUnits.Location = New System.Drawing.Point(111, 84)
        Me.txtLecUnits.Name = "txtLecUnits"
        Me.txtLecUnits.Size = New System.Drawing.Size(76, 24)
        Me.txtLecUnits.TabIndex = 3
        '
        'txtSubjectDescription
        '
        Me.txtSubjectDescription.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtSubjectDescription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtSubjectDescription.Location = New System.Drawing.Point(271, 33)
        Me.txtSubjectDescription.Name = "txtSubjectDescription"
        Me.txtSubjectDescription.Size = New System.Drawing.Size(238, 24)
        Me.txtSubjectDescription.TabIndex = 2
        '
        'txtSubjectCode
        '
        Me.txtSubjectCode.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtSubjectCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtSubjectCode.Location = New System.Drawing.Point(111, 36)
        Me.txtSubjectCode.Name = "txtSubjectCode"
        Me.txtSubjectCode.Size = New System.Drawing.Size(76, 24)
        Me.txtSubjectCode.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 219)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 18)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Instructor"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(195, 176)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 18)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Class"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 176)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 18)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Slot"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(362, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 18)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Room"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Time"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(195, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Day"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(362, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Section"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(195, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Lab Units"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Lecture Units"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(195, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Subject"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Subject Code"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(301, 16)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(18, 13)
        Me.lblID.TabIndex = 15
        Me.lblID.Text = "ID"
        Me.lblID.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblID)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 1)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(515, 53)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(429, 18)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(80, 25)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Class List"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(348, 19)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(6, 18)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Select Subject"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(102, 18)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(89, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Add Subject"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'frmSemSubjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 338)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSemSubjects"
        Me.Text = "Semester Subjects"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtInstructor As System.Windows.Forms.TextBox
    Friend WithEvents txtSlot As System.Windows.Forms.TextBox
    Friend WithEvents txtRoom As System.Windows.Forms.TextBox
    Friend WithEvents txtDay As System.Windows.Forms.TextBox
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents txtLabUnits As System.Windows.Forms.TextBox
    Friend WithEvents txtSection As System.Windows.Forms.TextBox
    Friend WithEvents txtLecUnits As System.Windows.Forms.TextBox
    Friend WithEvents txtSubjectDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtSubjectCode As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents cboClass As System.Windows.Forms.ComboBox
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
