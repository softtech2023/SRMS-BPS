<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGrades))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtStudentNumber = New System.Windows.Forms.TextBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.txtSubjectCode = New System.Windows.Forms.TextBox
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.txtLecUnit = New System.Windows.Forms.TextBox
        Me.txtInstructor = New System.Windows.Forms.TextBox
        Me.txt3Grading = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.lblID = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblGradeLevel = New System.Windows.Forms.Label
        Me.lblCourse = New System.Windows.Forms.Label
        Me.btnReset = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtSection = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.txt4Grading = New System.Windows.Forms.TextBox
        Me.btnCompute = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtRemarks = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtAverage = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txt2Grading = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txt1Grading = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tsSave = New System.Windows.Forms.ToolStripButton
        Me.tsUpdate = New System.Windows.Forms.ToolStripButton
        Me.tsDelete = New System.Windows.Forms.ToolStripButton
        Me.tsSearch = New System.Windows.Forms.ToolStripButton
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Student No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 77)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 46)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Subject Code"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 78)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Description"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(312, 78)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 19)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Units"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 110)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 19)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Teacher"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 160)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 19)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "3rd Grading"
        '
        'txtStudentNumber
        '
        Me.txtStudentNumber.Location = New System.Drawing.Point(91, 42)
        Me.txtStudentNumber.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtStudentNumber.Name = "txtStudentNumber"
        Me.txtStudentNumber.ReadOnly = True
        Me.txtStudentNumber.Size = New System.Drawing.Size(97, 26)
        Me.txtStudentNumber.TabIndex = 0
        Me.txtStudentNumber.TabStop = False
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(91, 74)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(305, 26)
        Me.txtName.TabIndex = 1
        Me.txtName.TabStop = False
        '
        'txtSubjectCode
        '
        Me.txtSubjectCode.Location = New System.Drawing.Point(115, 43)
        Me.txtSubjectCode.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtSubjectCode.Name = "txtSubjectCode"
        Me.txtSubjectCode.ReadOnly = True
        Me.txtSubjectCode.Size = New System.Drawing.Size(193, 26)
        Me.txtSubjectCode.TabIndex = 2
        Me.txtSubjectCode.TabStop = False
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(115, 75)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(193, 26)
        Me.txtDescription.TabIndex = 3
        Me.txtDescription.TabStop = False
        '
        'txtLecUnit
        '
        Me.txtLecUnit.Location = New System.Drawing.Point(354, 75)
        Me.txtLecUnit.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtLecUnit.Name = "txtLecUnit"
        Me.txtLecUnit.ReadOnly = True
        Me.txtLecUnit.Size = New System.Drawing.Size(46, 26)
        Me.txtLecUnit.TabIndex = 4
        Me.txtLecUnit.TabStop = False
        '
        'txtInstructor
        '
        Me.txtInstructor.Location = New System.Drawing.Point(115, 107)
        Me.txtInstructor.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtInstructor.Name = "txtInstructor"
        Me.txtInstructor.ReadOnly = True
        Me.txtInstructor.Size = New System.Drawing.Size(285, 26)
        Me.txtInstructor.TabIndex = 6
        Me.txtInstructor.TabStop = False
        '
        'txt3Grading
        '
        Me.txt3Grading.Location = New System.Drawing.Point(106, 157)
        Me.txt3Grading.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt3Grading.Name = "txt3Grading"
        Me.txt3Grading.Size = New System.Drawing.Size(82, 26)
        Me.txt3Grading.TabIndex = 2
        Me.txt3Grading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(192, 40)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 32)
        Me.Button1.TabIndex = 13
        Me.Button1.TabStop = False
        Me.Button1.Text = "Select"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(312, 40)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 32)
        Me.Button2.TabIndex = 14
        Me.Button2.TabStop = False
        Me.Button2.Text = "Select"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(292, 33)
        Me.lblID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(22, 19)
        Me.lblID.TabIndex = 16
        Me.lblID.Text = "ID"
        Me.lblID.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.lblGradeLevel)
        Me.GroupBox1.Controls.Add(Me.lblCourse)
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtSection)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtInstructor)
        Me.GroupBox1.Controls.Add(Me.txtLecUnit)
        Me.GroupBox1.Controls.Add(Me.txtSubjectCode)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 85)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(413, 319)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Subject Details"
        '
        'lblGradeLevel
        '
        Me.lblGradeLevel.AutoSize = True
        Me.lblGradeLevel.Location = New System.Drawing.Point(29, 245)
        Me.lblGradeLevel.Name = "lblGradeLevel"
        Me.lblGradeLevel.Size = New System.Drawing.Size(77, 19)
        Me.lblGradeLevel.TabIndex = 32
        Me.lblGradeLevel.Text = "Grade Level"
        Me.lblGradeLevel.Visible = False
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Location = New System.Drawing.Point(29, 203)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(49, 19)
        Me.lblCourse.TabIndex = 31
        Me.lblCourse.Text = "Course"
        Me.lblCourse.Visible = False
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(304, 168)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(96, 37)
        Me.btnReset.TabIndex = 17
        Me.btnReset.TabStop = False
        Me.btnReset.Text = "Reset Subject"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 142)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 19)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Section"
        '
        'txtSection
        '
        Me.txtSection.Location = New System.Drawing.Point(115, 139)
        Me.txtSection.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.ReadOnly = True
        Me.txtSection.Size = New System.Drawing.Size(285, 26)
        Me.txtSection.TabIndex = 15
        Me.txtSection.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.txt4Grading)
        Me.GroupBox2.Controls.Add(Me.btnCompute)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtRemarks)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtAverage)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txt2Grading)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txt1Grading)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtStudentNumber)
        Me.GroupBox2.Controls.Add(Me.txt3Grading)
        Me.GroupBox2.Controls.Add(Me.txtName)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.lblID)
        Me.GroupBox2.Location = New System.Drawing.Point(431, 85)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(412, 319)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Grades Details"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(11, 189)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(384, 19)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "---------------------------------------------------------------------------"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(281, 255)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(97, 37)
        Me.Button3.TabIndex = 20
        Me.Button3.TabStop = False
        Me.Button3.Text = "Reset Grades"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txt4Grading
        '
        Me.txt4Grading.Location = New System.Drawing.Point(296, 157)
        Me.txt4Grading.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt4Grading.Name = "txt4Grading"
        Me.txt4Grading.Size = New System.Drawing.Size(82, 26)
        Me.txt4Grading.TabIndex = 3
        Me.txt4Grading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(178, 254)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(97, 38)
        Me.btnCompute.TabIndex = 30
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(202, 160)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 19)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "4th Grading"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(265, 210)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.ReadOnly = True
        Me.txtRemarks.Size = New System.Drawing.Size(113, 26)
        Me.txtRemarks.TabIndex = 5
        Me.txtRemarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(201, 213)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 19)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Remarks"
        '
        'txtAverage
        '
        Me.txtAverage.Location = New System.Drawing.Point(106, 210)
        Me.txtAverage.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtAverage.Name = "txtAverage"
        Me.txtAverage.ReadOnly = True
        Me.txtAverage.Size = New System.Drawing.Size(82, 26)
        Me.txtAverage.TabIndex = 3
        Me.txtAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 213)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 19)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Average"
        '
        'txt2Grading
        '
        Me.txt2Grading.Location = New System.Drawing.Point(296, 125)
        Me.txt2Grading.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt2Grading.Name = "txt2Grading"
        Me.txt2Grading.Size = New System.Drawing.Size(82, 26)
        Me.txt2Grading.TabIndex = 1
        Me.txt2Grading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(201, 131)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 19)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "2nd Grading"
        '
        'txt1Grading
        '
        Me.txt1Grading.Location = New System.Drawing.Point(106, 125)
        Me.txt1Grading.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt1Grading.Name = "txt1Grading"
        Me.txt1Grading.Size = New System.Drawing.Size(82, 26)
        Me.txt1Grading.TabIndex = 0
        Me.txt1Grading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 128)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 19)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "1st Grading"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 103)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(384, 19)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "---------------------------------------------------------------------------"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsSave, Me.tsUpdate, Me.tsDelete, Me.tsSearch})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(855, 55)
        Me.ToolStrip1.TabIndex = 19
        Me.ToolStrip1.Text = "Grades Toolbox"
        '
        'tsSave
        '
        Me.tsSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsSave.Image = CType(resources.GetObject("tsSave.Image"), System.Drawing.Image)
        Me.tsSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSave.Name = "tsSave"
        Me.tsSave.Size = New System.Drawing.Size(52, 52)
        Me.tsSave.Text = "Save"
        '
        'tsUpdate
        '
        Me.tsUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsUpdate.Image = CType(resources.GetObject("tsUpdate.Image"), System.Drawing.Image)
        Me.tsUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsUpdate.Name = "tsUpdate"
        Me.tsUpdate.Size = New System.Drawing.Size(52, 52)
        Me.tsUpdate.Text = "Update"
        '
        'tsDelete
        '
        Me.tsDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsDelete.Image = CType(resources.GetObject("tsDelete.Image"), System.Drawing.Image)
        Me.tsDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDelete.Name = "tsDelete"
        Me.tsDelete.Size = New System.Drawing.Size(52, 52)
        Me.tsDelete.Text = "Delete"
        '
        'tsSearch
        '
        Me.tsSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsSearch.Image = CType(resources.GetObject("tsSearch.Image"), System.Drawing.Image)
        Me.tsSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSearch.Name = "tsSearch"
        Me.tsSearch.Size = New System.Drawing.Size(52, 52)
        Me.tsSearch.Text = "Search"
        '
        'frmGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(855, 406)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGrades"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grades Entry"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtStudentNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtSubjectCode As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtLecUnit As System.Windows.Forms.TextBox
    Friend WithEvents txtInstructor As System.Windows.Forms.TextBox
    Friend WithEvents txt3Grading As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtSection As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt2Grading As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt1Grading As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtAverage As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsUpdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents lblCourse As System.Windows.Forms.Label
    Friend WithEvents lblGradeLevel As System.Windows.Forms.Label
    Friend WithEvents txt4Grading As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label

End Class
