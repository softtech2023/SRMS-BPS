<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModifyGrades
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.mskStudentNumber = New System.Windows.Forms.MaskedTextBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtStudeName = New System.Windows.Forms.TextBox
        Me.tsNew = New System.Windows.Forms.Button
        Me.dg1 = New System.Windows.Forms.DataGridView
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.txtSection = New System.Windows.Forms.TextBox
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.txtSubjectCode = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtTeacher = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblQualification = New System.Windows.Forms.Label
        Me.lblTrack = New System.Windows.Forms.Label
        Me.lblAdviser = New System.Windows.Forms.Label
        Me.lblYearLevel = New System.Windows.Forms.Label
        Me.txtAverage = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtFourth = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtThird = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtSecond = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtFirst = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblID = New System.Windows.Forms.Label
        Me.btnDeleteAll = New System.Windows.Forms.Button
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(77, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LRN"
        '
        'mskStudentNumber
        '
        Me.mskStudentNumber.BackColor = System.Drawing.Color.White
        Me.mskStudentNumber.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskStudentNumber.ForeColor = System.Drawing.Color.Black
        Me.mskStudentNumber.Location = New System.Drawing.Point(115, 38)
        Me.mskStudentNumber.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mskStudentNumber.Name = "mskStudentNumber"
        Me.mskStudentNumber.ReadOnly = True
        Me.mskStudentNumber.Size = New System.Drawing.Size(127, 26)
        Me.mskStudentNumber.TabIndex = 0
        Me.mskStudentNumber.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(202, 42)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(38, 17)
        Me.btnClose.TabIndex = 22
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(19, 75)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(91, 19)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Student Name"
        '
        'txtStudeName
        '
        Me.txtStudeName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtStudeName.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudeName.ForeColor = System.Drawing.Color.Black
        Me.txtStudeName.Location = New System.Drawing.Point(116, 72)
        Me.txtStudeName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtStudeName.Name = "txtStudeName"
        Me.txtStudeName.ReadOnly = True
        Me.txtStudeName.Size = New System.Drawing.Size(515, 26)
        Me.txtStudeName.TabIndex = 1
        Me.txtStudeName.TabStop = False
        '
        'tsNew
        '
        Me.tsNew.Location = New System.Drawing.Point(249, 38)
        Me.tsNew.Name = "tsNew"
        Me.tsNew.Size = New System.Drawing.Size(109, 28)
        Me.tsNew.TabIndex = 42
        Me.tsNew.TabStop = False
        Me.tsNew.Text = "Select Student"
        Me.tsNew.UseVisualStyleBackColor = True
        '
        'dg1
        '
        Me.dg1.AllowUserToAddRows = False
        Me.dg1.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dg1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg1.Location = New System.Drawing.Point(0, 176)
        Me.dg1.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.dg1.Name = "dg1"
        Me.dg1.ReadOnly = True
        Me.dg1.Size = New System.Drawing.Size(631, 223)
        Me.dg1.TabIndex = 43
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(15, 405)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(139, 40)
        Me.btnAdd.TabIndex = 44
        Me.btnAdd.TabStop = False
        Me.btnAdd.Text = "&Encode New Grades"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(160, 405)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(139, 40)
        Me.btnUpdate.TabIndex = 45
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(305, 405)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(139, 40)
        Me.btnDelete.TabIndex = 46
        Me.btnDelete.TabStop = False
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtSection
        '
        Me.txtSection.Location = New System.Drawing.Point(116, 138)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.ReadOnly = True
        Me.txtSection.Size = New System.Drawing.Size(126, 26)
        Me.txtSection.TabIndex = 60
        Me.txtSection.TabStop = False
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(333, 106)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(298, 26)
        Me.txtDescription.TabIndex = 59
        Me.txtDescription.TabStop = False
        '
        'txtSubjectCode
        '
        Me.txtSubjectCode.Location = New System.Drawing.Point(116, 106)
        Me.txtSubjectCode.Name = "txtSubjectCode"
        Me.txtSubjectCode.ReadOnly = True
        Me.txtSubjectCode.Size = New System.Drawing.Size(126, 26)
        Me.txtSubjectCode.TabIndex = 2
        Me.txtSubjectCode.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(60, 141)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 19)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Section"
        '
        'txtTeacher
        '
        Me.txtTeacher.Location = New System.Drawing.Point(333, 141)
        Me.txtTeacher.Name = "txtTeacher"
        Me.txtTeacher.ReadOnly = True
        Me.txtTeacher.Size = New System.Drawing.Size(298, 26)
        Me.txtTeacher.TabIndex = 56
        Me.txtTeacher.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(272, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 19)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Teacher"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(254, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 19)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Description"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 19)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Subject Code"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblQualification)
        Me.GroupBox1.Controls.Add(Me.lblTrack)
        Me.GroupBox1.Controls.Add(Me.lblAdviser)
        Me.GroupBox1.Controls.Add(Me.lblYearLevel)
        Me.GroupBox1.Controls.Add(Me.txtAverage)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtFourth)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtThird)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtSecond)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtFirst)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(638, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(229, 327)
        Me.GroupBox1.TabIndex = 61
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Grades"
        '
        'lblQualification
        '
        Me.lblQualification.AutoSize = True
        Me.lblQualification.Location = New System.Drawing.Point(18, 296)
        Me.lblQualification.Name = "lblQualification"
        Me.lblQualification.Size = New System.Drawing.Size(85, 19)
        Me.lblQualification.TabIndex = 75
        Me.lblQualification.Text = "Qualifications"
        Me.lblQualification.Visible = False
        '
        'lblTrack
        '
        Me.lblTrack.AutoSize = True
        Me.lblTrack.Location = New System.Drawing.Point(18, 268)
        Me.lblTrack.Name = "lblTrack"
        Me.lblTrack.Size = New System.Drawing.Size(40, 19)
        Me.lblTrack.TabIndex = 74
        Me.lblTrack.Text = "Track"
        Me.lblTrack.Visible = False
        '
        'lblAdviser
        '
        Me.lblAdviser.AutoSize = True
        Me.lblAdviser.Location = New System.Drawing.Point(18, 237)
        Me.lblAdviser.Name = "lblAdviser"
        Me.lblAdviser.Size = New System.Drawing.Size(51, 19)
        Me.lblAdviser.TabIndex = 73
        Me.lblAdviser.Text = "Adviser"
        Me.lblAdviser.Visible = False
        '
        'lblYearLevel
        '
        Me.lblYearLevel.AutoSize = True
        Me.lblYearLevel.Location = New System.Drawing.Point(18, 205)
        Me.lblYearLevel.Name = "lblYearLevel"
        Me.lblYearLevel.Size = New System.Drawing.Size(64, 19)
        Me.lblYearLevel.TabIndex = 72
        Me.lblYearLevel.Text = "YearLevel"
        Me.lblYearLevel.Visible = False
        '
        'txtAverage
        '
        Me.txtAverage.Location = New System.Drawing.Point(100, 162)
        Me.txtAverage.Name = "txtAverage"
        Me.txtAverage.Size = New System.Drawing.Size(113, 26)
        Me.txtAverage.TabIndex = 71
        Me.txtAverage.Text = "0"
        Me.txtAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 165)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 19)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "Average"
        '
        'txtFourth
        '
        Me.txtFourth.Location = New System.Drawing.Point(100, 130)
        Me.txtFourth.Name = "txtFourth"
        Me.txtFourth.Size = New System.Drawing.Size(113, 26)
        Me.txtFourth.TabIndex = 69
        Me.txtFourth.Text = "0"
        Me.txtFourth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 133)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 19)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "4th Grading"
        '
        'txtThird
        '
        Me.txtThird.Location = New System.Drawing.Point(100, 98)
        Me.txtThird.Name = "txtThird"
        Me.txtThird.Size = New System.Drawing.Size(113, 26)
        Me.txtThird.TabIndex = 67
        Me.txtThird.Text = "0"
        Me.txtThird.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 19)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "3rd Grading"
        '
        'txtSecond
        '
        Me.txtSecond.Location = New System.Drawing.Point(100, 66)
        Me.txtSecond.Name = "txtSecond"
        Me.txtSecond.Size = New System.Drawing.Size(113, 26)
        Me.txtSecond.TabIndex = 65
        Me.txtSecond.Text = "0"
        Me.txtSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 19)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "2nd Grading"
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(100, 34)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(113, 26)
        Me.txtFirst.TabIndex = 63
        Me.txtFirst.Text = "0"
        Me.txtFirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 19)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "1st Grading"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(800, 426)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(61, 19)
        Me.lblID.TabIndex = 62
        Me.lblID.Text = "Grade ID"
        Me.lblID.Visible = False
        '
        'btnDeleteAll
        '
        Me.btnDeleteAll.Location = New System.Drawing.Point(450, 405)
        Me.btnDeleteAll.Name = "btnDeleteAll"
        Me.btnDeleteAll.Size = New System.Drawing.Size(139, 40)
        Me.btnDeleteAll.TabIndex = 63
        Me.btnDeleteAll.TabStop = False
        Me.btnDeleteAll.Text = "Delete All"
        Me.btnDeleteAll.UseVisualStyleBackColor = True
        '
        'frmModifyGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(873, 454)
        Me.Controls.Add(Me.btnDeleteAll)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSection)
        Me.Controls.Add(Me.mskStudentNumber)
        Me.Controls.Add(Me.txtStudeName)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtSubjectCode)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTeacher)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dg1)
        Me.Controls.Add(Me.tsNew)
        Me.Controls.Add(Me.btnClose)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmModifyGrades"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modify Grades ::"
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mskStudentNumber As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtStudeName As System.Windows.Forms.TextBox
    Friend WithEvents tsNew As System.Windows.Forms.Button
    Friend WithEvents dg1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents txtSection As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtSubjectCode As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTeacher As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAverage As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtFourth As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtThird As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSecond As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtFirst As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblYearLevel As System.Windows.Forms.Label
    Friend WithEvents lblQualification As System.Windows.Forms.Label
    Friend WithEvents lblTrack As System.Windows.Forms.Label
    Friend WithEvents lblAdviser As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents btnDeleteAll As System.Windows.Forms.Button
End Class
