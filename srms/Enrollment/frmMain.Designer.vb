<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ACLCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.FacultyAndStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.CoursesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.CurriculumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.SubjectsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.SemSubjectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.ChangeSemesterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SearcToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StaffToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.SubjectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SemesterSubjectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnInputGrades = New System.Windows.Forms.Button
        Me.btnAddNewStudent = New System.Windows.Forms.Button
        Me.btnManageUsers = New System.Windows.Forms.Button
        Me.btnEnrollStudent = New System.Windows.Forms.Button
        Me.btnAddSemStudent = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblUser = New System.Windows.Forms.Label
        Me.lblSY = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblSem = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ACLCToolStripMenuItem, Me.SearcToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(984, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ACLCToolStripMenuItem
        '
        Me.ACLCToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.ToolStripSeparator2, Me.FacultyAndStaffToolStripMenuItem, Me.ToolStripSeparator3, Me.CoursesToolStripMenuItem, Me.ToolStripSeparator4, Me.CurriculumToolStripMenuItem, Me.ToolStripSeparator5, Me.SubjectsToolStripMenuItem1, Me.ToolStripSeparator1, Me.SemSubjectsToolStripMenuItem, Me.ToolStripSeparator6, Me.ChangeSemesterToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ACLCToolStripMenuItem.Name = "ACLCToolStripMenuItem"
        Me.ACLCToolStripMenuItem.Size = New System.Drawing.Size(118, 20)
        Me.ACLCToolStripMenuItem.Text = "ACLC - Enrollment"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.NewToolStripMenuItem.Text = "New Student"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(163, 6)
        '
        'FacultyAndStaffToolStripMenuItem
        '
        Me.FacultyAndStaffToolStripMenuItem.Name = "FacultyAndStaffToolStripMenuItem"
        Me.FacultyAndStaffToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.FacultyAndStaffToolStripMenuItem.Text = "Faculty and Staff"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(163, 6)
        '
        'CoursesToolStripMenuItem
        '
        Me.CoursesToolStripMenuItem.Name = "CoursesToolStripMenuItem"
        Me.CoursesToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.CoursesToolStripMenuItem.Text = "Courses"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(163, 6)
        '
        'CurriculumToolStripMenuItem
        '
        Me.CurriculumToolStripMenuItem.Name = "CurriculumToolStripMenuItem"
        Me.CurriculumToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.CurriculumToolStripMenuItem.Text = "Curriculum"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(163, 6)
        '
        'SubjectsToolStripMenuItem1
        '
        Me.SubjectsToolStripMenuItem1.Name = "SubjectsToolStripMenuItem1"
        Me.SubjectsToolStripMenuItem1.Size = New System.Drawing.Size(166, 22)
        Me.SubjectsToolStripMenuItem1.Text = "Add Subjects"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(163, 6)
        '
        'SemSubjectsToolStripMenuItem
        '
        Me.SemSubjectsToolStripMenuItem.Name = "SemSubjectsToolStripMenuItem"
        Me.SemSubjectsToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.SemSubjectsToolStripMenuItem.Text = "Sem Subjects"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(163, 6)
        '
        'ChangeSemesterToolStripMenuItem
        '
        Me.ChangeSemesterToolStripMenuItem.Name = "ChangeSemesterToolStripMenuItem"
        Me.ChangeSemesterToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ChangeSemesterToolStripMenuItem.Text = "Change Semester"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'SearcToolStripMenuItem
        '
        Me.SearcToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentsToolStripMenuItem, Me.StaffToolStripMenuItem1, Me.SubjectsToolStripMenuItem, Me.SemesterSubjectsToolStripMenuItem})
        Me.SearcToolStripMenuItem.Name = "SearcToolStripMenuItem"
        Me.SearcToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.SearcToolStripMenuItem.Text = "Search"
        '
        'StudentsToolStripMenuItem
        '
        Me.StudentsToolStripMenuItem.Name = "StudentsToolStripMenuItem"
        Me.StudentsToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.StudentsToolStripMenuItem.Text = "Students"
        '
        'StaffToolStripMenuItem1
        '
        Me.StaffToolStripMenuItem1.Name = "StaffToolStripMenuItem1"
        Me.StaffToolStripMenuItem1.Size = New System.Drawing.Size(169, 22)
        Me.StaffToolStripMenuItem1.Text = "Faculty and Staff"
        '
        'SubjectsToolStripMenuItem
        '
        Me.SubjectsToolStripMenuItem.Name = "SubjectsToolStripMenuItem"
        Me.SubjectsToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.SubjectsToolStripMenuItem.Text = "Subjects"
        '
        'SemesterSubjectsToolStripMenuItem
        '
        Me.SemesterSubjectsToolStripMenuItem.Name = "SemesterSubjectsToolStripMenuItem"
        Me.SemesterSubjectsToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.SemesterSubjectsToolStripMenuItem.Text = "Semester Subjects"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnInputGrades)
        Me.GroupBox1.Controls.Add(Me.btnAddNewStudent)
        Me.GroupBox1.Controls.Add(Me.btnManageUsers)
        Me.GroupBox1.Controls.Add(Me.btnEnrollStudent)
        Me.GroupBox1.Controls.Add(Me.btnAddSemStudent)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(351, 84)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'btnInputGrades
        '
        Me.btnInputGrades.Image = CType(resources.GetObject("btnInputGrades.Image"), System.Drawing.Image)
        Me.btnInputGrades.Location = New System.Drawing.Point(213, 13)
        Me.btnInputGrades.Name = "btnInputGrades"
        Me.btnInputGrades.Size = New System.Drawing.Size(63, 60)
        Me.btnInputGrades.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.btnInputGrades, "Input Student's Grades")
        Me.btnInputGrades.UseVisualStyleBackColor = True
        '
        'btnAddNewStudent
        '
        Me.btnAddNewStudent.Image = CType(resources.GetObject("btnAddNewStudent.Image"), System.Drawing.Image)
        Me.btnAddNewStudent.Location = New System.Drawing.Point(6, 13)
        Me.btnAddNewStudent.Name = "btnAddNewStudent"
        Me.btnAddNewStudent.Size = New System.Drawing.Size(63, 60)
        Me.btnAddNewStudent.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.btnAddNewStudent, "Add New Student")
        Me.btnAddNewStudent.UseVisualStyleBackColor = True
        '
        'btnManageUsers
        '
        Me.btnManageUsers.Image = CType(resources.GetObject("btnManageUsers.Image"), System.Drawing.Image)
        Me.btnManageUsers.Location = New System.Drawing.Point(282, 13)
        Me.btnManageUsers.Name = "btnManageUsers"
        Me.btnManageUsers.Size = New System.Drawing.Size(63, 60)
        Me.btnManageUsers.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.btnManageUsers, "Manage Users")
        Me.btnManageUsers.UseVisualStyleBackColor = True
        '
        'btnEnrollStudent
        '
        Me.btnEnrollStudent.Image = CType(resources.GetObject("btnEnrollStudent.Image"), System.Drawing.Image)
        Me.btnEnrollStudent.Location = New System.Drawing.Point(144, 13)
        Me.btnEnrollStudent.Name = "btnEnrollStudent"
        Me.btnEnrollStudent.Size = New System.Drawing.Size(63, 60)
        Me.btnEnrollStudent.TabIndex = 1
        Me.btnEnrollStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ToolTip1.SetToolTip(Me.btnEnrollStudent, "Enroll Student")
        Me.btnEnrollStudent.UseVisualStyleBackColor = True
        '
        'btnAddSemStudent
        '
        Me.btnAddSemStudent.Image = CType(resources.GetObject("btnAddSemStudent.Image"), System.Drawing.Image)
        Me.btnAddSemStudent.Location = New System.Drawing.Point(75, 13)
        Me.btnAddSemStudent.Name = "btnAddSemStudent"
        Me.btnAddSemStudent.Size = New System.Drawing.Size(63, 60)
        Me.btnAddSemStudent.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.btnAddSemStudent, "Add Student for the Current Semester")
        Me.btnAddSemStudent.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(18, 143)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(345, 26)
        Me.DateTimePicker1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Semester:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(157, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "School Year:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblUser)
        Me.GroupBox2.Controls.Add(Me.lblSY)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lblSem)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(392, 39)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(580, 84)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.Navy
        Me.lblUser.Location = New System.Drawing.Point(466, 37)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(52, 22)
        Me.lblUser.TabIndex = 7
        Me.lblUser.Text = "User"
        '
        'lblSY
        '
        Me.lblSY.AutoSize = True
        Me.lblSY.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSY.ForeColor = System.Drawing.Color.Navy
        Me.lblSY.Location = New System.Drawing.Point(254, 37)
        Me.lblSY.Name = "lblSY"
        Me.lblSY.Size = New System.Drawing.Size(36, 22)
        Me.lblSY.TabIndex = 6
        Me.lblSY.Text = "SY"
        Me.lblSY.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(366, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Current User:"
        '
        'lblSem
        '
        Me.lblSem.AutoSize = True
        Me.lblSem.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSem.ForeColor = System.Drawing.Color.Navy
        Me.lblSem.Location = New System.Drawing.Point(88, 35)
        Me.lblSem.Name = "lblSem"
        Me.lblSem.Size = New System.Drawing.Size(49, 22)
        Me.lblSem.TabIndex = 5
        Me.lblSem.Text = "Sem"
        Me.lblSem.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(984, 712)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.Text = "ACLC College | Tagum City Campus"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ACLCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearcToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StaffToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubjectsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacultyAndStaffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CoursesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CurriculumToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubjectsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SemSubjectsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEnrollStudent As System.Windows.Forms.Button
    Friend WithEvents btnAddSemStudent As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnManageUsers As System.Windows.Forms.Button
    Friend WithEvents btnAddNewStudent As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ChangeSemesterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblSY As System.Windows.Forms.Label
    Friend WithEvents lblSem As System.Windows.Forms.Label
    Friend WithEvents SemesterSubjectsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnInputGrades As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label

End Class
