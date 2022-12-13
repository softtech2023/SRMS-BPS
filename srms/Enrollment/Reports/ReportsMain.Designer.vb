<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportsMain
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cboClass = New System.Windows.Forms.ComboBox
        Me.cboInstructorMasterlist = New System.Windows.Forms.ComboBox
        Me.StaffBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Enrollment.DataSet
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtSection = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtsubjectcode = New System.Windows.Forms.TextBox
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnMasterlist = New System.Windows.Forms.Button
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnFacultyLoading = New System.Windows.Forms.Button
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnStudeAccount = New System.Windows.Forms.Button
        Me.cboInstructor = New System.Windows.Forms.ComboBox
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboYearLevelAccount = New System.Windows.Forms.ComboBox
        Me.cboCourseAccount = New System.Windows.Forms.ComboBox
        Me.CoursesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboStatus = New System.Windows.Forms.ComboBox
        Me.cboYearLevel = New System.Windows.Forms.ComboBox
        Me.btnStudentList = New System.Windows.Forms.Button
        Me.cboCourse = New System.Windows.Forms.ComboBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnCompleteList = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnPreviewFinancial = New System.Windows.Forms.Button
        Me.cboFinancialReport = New System.Windows.Forms.ComboBox
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnStudeReport = New System.Windows.Forms.Button
        Me.cboStudeReport = New System.Windows.Forms.ComboBox
        Me.mskStudentNumber = New System.Windows.Forms.MaskedTextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CoursesTableAdapter = New Enrollment.DataSetTableAdapters.coursesTableAdapter
        Me.StaffTableAdapter = New Enrollment.DataSetTableAdapters.staffTableAdapter
        Me.GroupBox1.SuspendLayout()
        CType(Me.StaffBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CoursesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cboClass)
        Me.GroupBox1.Controls.Add(Me.cboInstructorMasterlist)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtSection)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtsubjectcode)
        Me.GroupBox1.Controls.Add(Me.Panel6)
        Me.GroupBox1.Controls.Add(Me.btnMasterlist)
        Me.GroupBox1.Controls.Add(Me.Panel5)
        Me.GroupBox1.Controls.Add(Me.btnFacultyLoading)
        Me.GroupBox1.Controls.Add(Me.Panel4)
        Me.GroupBox1.Controls.Add(Me.btnStudeAccount)
        Me.GroupBox1.Controls.Add(Me.cboInstructor)
        Me.GroupBox1.Controls.Add(Me.cboYearLevelAccount)
        Me.GroupBox1.Controls.Add(Me.cboCourseAccount)
        Me.GroupBox1.Controls.Add(Me.cboStatus)
        Me.GroupBox1.Controls.Add(Me.cboYearLevel)
        Me.GroupBox1.Controls.Add(Me.btnStudentList)
        Me.GroupBox1.Controls.Add(Me.cboCourse)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.btnPreviewFinancial)
        Me.GroupBox1.Controls.Add(Me.cboFinancialReport)
        Me.GroupBox1.Controls.Add(Me.dtpDate)
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.btnStudeReport)
        Me.GroupBox1.Controls.Add(Me.cboStudeReport)
        Me.GroupBox1.Controls.Add(Me.mskStudentNumber)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(576, 519)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(421, 458)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 17)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Type"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(250, 458)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 17)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Instructor"
        '
        'cboClass
        '
        Me.cboClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboClass.FormattingEnabled = True
        Me.cboClass.Items.AddRange(New Object() {"Lab", "Lec"})
        Me.cboClass.Location = New System.Drawing.Point(405, 478)
        Me.cboClass.Name = "cboClass"
        Me.cboClass.Size = New System.Drawing.Size(71, 25)
        Me.cboClass.TabIndex = 31
        '
        'cboInstructorMasterlist
        '
        Me.cboInstructorMasterlist.DataSource = Me.StaffBindingSource1
        Me.cboInstructorMasterlist.DisplayMember = "Name"
        Me.cboInstructorMasterlist.FormattingEnabled = True
        Me.cboInstructorMasterlist.Location = New System.Drawing.Point(184, 478)
        Me.cboInstructorMasterlist.Name = "cboInstructorMasterlist"
        Me.cboInstructorMasterlist.Size = New System.Drawing.Size(215, 25)
        Me.cboInstructorMasterlist.TabIndex = 29
        '
        'StaffBindingSource1
        '
        Me.StaffBindingSource1.DataMember = "staff"
        Me.StaffBindingSource1.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(123, 458)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 17)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Section"
        '
        'txtSection
        '
        Me.txtSection.Location = New System.Drawing.Point(120, 478)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.Size = New System.Drawing.Size(58, 23)
        Me.txtSection.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 458)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 17)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Subject Code"
        '
        'txtsubjectcode
        '
        Me.txtsubjectcode.Location = New System.Drawing.Point(21, 478)
        Me.txtsubjectcode.Name = "txtsubjectcode"
        Me.txtsubjectcode.Size = New System.Drawing.Size(93, 23)
        Me.txtsubjectcode.TabIndex = 26
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Location = New System.Drawing.Point(6, 420)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(469, 29)
        Me.Panel6.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(12, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Masterlist"
        '
        'btnMasterlist
        '
        Me.btnMasterlist.BackColor = System.Drawing.Color.Transparent
        Me.btnMasterlist.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnMasterlist.Location = New System.Drawing.Point(481, 474)
        Me.btnMasterlist.Name = "btnMasterlist"
        Me.btnMasterlist.Size = New System.Drawing.Size(88, 31)
        Me.btnMasterlist.TabIndex = 24
        Me.btnMasterlist.Text = "Preview"
        Me.btnMasterlist.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Location = New System.Drawing.Point(6, 343)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(469, 29)
        Me.Panel5.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(12, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Faculty Loading"
        '
        'btnFacultyLoading
        '
        Me.btnFacultyLoading.BackColor = System.Drawing.Color.Transparent
        Me.btnFacultyLoading.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnFacultyLoading.Location = New System.Drawing.Point(482, 374)
        Me.btnFacultyLoading.Name = "btnFacultyLoading"
        Me.btnFacultyLoading.Size = New System.Drawing.Size(88, 31)
        Me.btnFacultyLoading.TabIndex = 21
        Me.btnFacultyLoading.Text = "Preview"
        Me.btnFacultyLoading.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(6, 264)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(469, 29)
        Me.Panel4.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(12, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Student's Account"
        '
        'btnStudeAccount
        '
        Me.btnStudeAccount.BackColor = System.Drawing.Color.Transparent
        Me.btnStudeAccount.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnStudeAccount.Location = New System.Drawing.Point(481, 295)
        Me.btnStudeAccount.Name = "btnStudeAccount"
        Me.btnStudeAccount.Size = New System.Drawing.Size(88, 31)
        Me.btnStudeAccount.TabIndex = 17
        Me.btnStudeAccount.Text = "Preview"
        Me.btnStudeAccount.UseVisualStyleBackColor = False
        '
        'cboInstructor
        '
        Me.cboInstructor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboInstructor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboInstructor.DataSource = Me.StaffBindingSource
        Me.cboInstructor.DisplayMember = "Name"
        Me.cboInstructor.FormattingEnabled = True
        Me.cboInstructor.Location = New System.Drawing.Point(6, 378)
        Me.cboInstructor.Name = "cboInstructor"
        Me.cboInstructor.Size = New System.Drawing.Size(469, 25)
        Me.cboInstructor.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.cboInstructor, "Select Report")
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "staff"
        Me.StaffBindingSource.DataSource = Me.DataSet
        '
        'cboYearLevelAccount
        '
        Me.cboYearLevelAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboYearLevelAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboYearLevelAccount.FormattingEnabled = True
        Me.cboYearLevelAccount.Items.AddRange(New Object() {"1st", "2nd", "3rd", "4th"})
        Me.cboYearLevelAccount.Location = New System.Drawing.Point(387, 299)
        Me.cboYearLevelAccount.Name = "cboYearLevelAccount"
        Me.cboYearLevelAccount.Size = New System.Drawing.Size(88, 25)
        Me.cboYearLevelAccount.Sorted = True
        Me.cboYearLevelAccount.TabIndex = 16
        Me.cboYearLevelAccount.Text = "Year Level"
        Me.ToolTip1.SetToolTip(Me.cboYearLevelAccount, "Select Report")
        '
        'cboCourseAccount
        '
        Me.cboCourseAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboCourseAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCourseAccount.DataSource = Me.CoursesBindingSource
        Me.cboCourseAccount.DisplayMember = "Course"
        Me.cboCourseAccount.FormattingEnabled = True
        Me.cboCourseAccount.Location = New System.Drawing.Point(6, 299)
        Me.cboCourseAccount.Name = "cboCourseAccount"
        Me.cboCourseAccount.Size = New System.Drawing.Size(375, 25)
        Me.cboCourseAccount.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.cboCourseAccount, "Select Report")
        '
        'CoursesBindingSource
        '
        Me.CoursesBindingSource.DataMember = "courses"
        Me.CoursesBindingSource.DataSource = Me.DataSet
        '
        'cboStatus
        '
        Me.cboStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Assessed", "Enrolled"})
        Me.cboStatus.Location = New System.Drawing.Point(387, 57)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(88, 25)
        Me.cboStatus.Sorted = True
        Me.cboStatus.TabIndex = 14
        Me.cboStatus.Text = "Status"
        Me.ToolTip1.SetToolTip(Me.cboStatus, "Select Report")
        '
        'cboYearLevel
        '
        Me.cboYearLevel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboYearLevel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboYearLevel.FormattingEnabled = True
        Me.cboYearLevel.Items.AddRange(New Object() {"1st", "2nd", "3rd", "4th"})
        Me.cboYearLevel.Location = New System.Drawing.Point(293, 57)
        Me.cboYearLevel.Name = "cboYearLevel"
        Me.cboYearLevel.Size = New System.Drawing.Size(88, 25)
        Me.cboYearLevel.Sorted = True
        Me.cboYearLevel.TabIndex = 13
        Me.cboYearLevel.Text = "Year Level"
        Me.ToolTip1.SetToolTip(Me.cboYearLevel, "Select Report")
        '
        'btnStudentList
        '
        Me.btnStudentList.BackColor = System.Drawing.Color.Transparent
        Me.btnStudentList.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnStudentList.Location = New System.Drawing.Point(481, 53)
        Me.btnStudentList.Name = "btnStudentList"
        Me.btnStudentList.Size = New System.Drawing.Size(88, 31)
        Me.btnStudentList.TabIndex = 12
        Me.btnStudentList.Text = "Preview"
        Me.btnStudentList.UseVisualStyleBackColor = False
        '
        'cboCourse
        '
        Me.cboCourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboCourse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCourse.DataSource = Me.CoursesBindingSource
        Me.cboCourse.DisplayMember = "Course"
        Me.cboCourse.FormattingEnabled = True
        Me.cboCourse.Location = New System.Drawing.Point(6, 57)
        Me.cboCourse.Name = "cboCourse"
        Me.cboCourse.Size = New System.Drawing.Size(281, 25)
        Me.cboCourse.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.cboCourse, "Select Report")
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.Controls.Add(Me.btnCompleteList)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(6, 22)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(469, 29)
        Me.Panel2.TabIndex = 10
        '
        'btnCompleteList
        '
        Me.btnCompleteList.BackColor = System.Drawing.Color.Transparent
        Me.btnCompleteList.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCompleteList.Location = New System.Drawing.Point(350, 3)
        Me.btnCompleteList.Name = "btnCompleteList"
        Me.btnCompleteList.Size = New System.Drawing.Size(114, 24)
        Me.btnCompleteList.TabIndex = 34
        Me.btnCompleteList.Text = "Complete List"
        Me.btnCompleteList.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(12, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Student's List"
        '
        'btnPreviewFinancial
        '
        Me.btnPreviewFinancial.BackColor = System.Drawing.Color.Transparent
        Me.btnPreviewFinancial.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPreviewFinancial.Location = New System.Drawing.Point(481, 213)
        Me.btnPreviewFinancial.Name = "btnPreviewFinancial"
        Me.btnPreviewFinancial.Size = New System.Drawing.Size(88, 31)
        Me.btnPreviewFinancial.TabIndex = 7
        Me.btnPreviewFinancial.Text = "Preview"
        Me.btnPreviewFinancial.UseVisualStyleBackColor = False
        '
        'cboFinancialReport
        '
        Me.cboFinancialReport.FormattingEnabled = True
        Me.cboFinancialReport.Items.AddRange(New Object() {"Daily Collection (Student's Account)", "Daily Collection (Other Services)", "Daily Expenses Report", "Promissory Note (complied)", "Promissory Note (for compliance)", "Student's Current Balance"})
        Me.cboFinancialReport.Location = New System.Drawing.Point(112, 217)
        Me.cboFinancialReport.Name = "cboFinancialReport"
        Me.cboFinancialReport.Size = New System.Drawing.Size(363, 25)
        Me.cboFinancialReport.TabIndex = 6
        '
        'dtpDate
        '
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(6, 215)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(100, 23)
        Me.dtpDate.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(6, 180)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(469, 29)
        Me.Panel3.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(12, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(219, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Collections and Expenses Report"
        '
        'btnStudeReport
        '
        Me.btnStudeReport.BackColor = System.Drawing.Color.Transparent
        Me.btnStudeReport.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnStudeReport.Location = New System.Drawing.Point(481, 131)
        Me.btnStudeReport.Name = "btnStudeReport"
        Me.btnStudeReport.Size = New System.Drawing.Size(88, 31)
        Me.btnStudeReport.TabIndex = 3
        Me.btnStudeReport.Text = "Preview"
        Me.btnStudeReport.UseVisualStyleBackColor = False
        '
        'cboStudeReport
        '
        Me.cboStudeReport.FormattingEnabled = True
        Me.cboStudeReport.Items.AddRange(New Object() {"Certificate of Registration (CoR)", "Student's Account", "Report of Grades", "Clearance (by Semester)"})
        Me.cboStudeReport.Location = New System.Drawing.Point(131, 135)
        Me.cboStudeReport.Name = "cboStudeReport"
        Me.cboStudeReport.Size = New System.Drawing.Size(344, 25)
        Me.cboStudeReport.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.cboStudeReport, "Select Report")
        '
        'mskStudentNumber
        '
        Me.mskStudentNumber.Location = New System.Drawing.Point(6, 135)
        Me.mskStudentNumber.Name = "mskStudentNumber"
        Me.mskStudentNumber.Size = New System.Drawing.Size(119, 23)
        Me.mskStudentNumber.TabIndex = 1
        Me.mskStudentNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.mskStudentNumber, "Student Number")
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(6, 102)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(469, 29)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student's  Report (Individual)"
        '
        'CoursesTableAdapter
        '
        Me.CoursesTableAdapter.ClearBeforeFill = True
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'frmReportsMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(603, 546)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmReportsMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reports Dashboard"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.StaffBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CoursesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnPreviewFinancial As System.Windows.Forms.Button
    Friend WithEvents cboFinancialReport As System.Windows.Forms.ComboBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cboYearLevel As System.Windows.Forms.ComboBox
    Friend WithEvents btnStudentList As System.Windows.Forms.Button
    Friend WithEvents cboCourse As System.Windows.Forms.ComboBox
    Friend WithEvents DataSet As Enrollment.DataSet
    Friend WithEvents CoursesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CoursesTableAdapter As Enrollment.DataSetTableAdapters.coursesTableAdapter
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnStudeAccount As System.Windows.Forms.Button
    Friend WithEvents cboYearLevelAccount As System.Windows.Forms.ComboBox
    Friend WithEvents cboCourseAccount As System.Windows.Forms.ComboBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnFacultyLoading As System.Windows.Forms.Button
    Friend WithEvents cboInstructor As System.Windows.Forms.ComboBox
    Friend WithEvents StaffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StaffTableAdapter As Enrollment.DataSetTableAdapters.staffTableAdapter
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnMasterlist As System.Windows.Forms.Button
    Friend WithEvents cboClass As System.Windows.Forms.ComboBox
    Friend WithEvents cboInstructorMasterlist As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSection As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtsubjectcode As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents StaffBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents btnCompleteList As System.Windows.Forms.Button
    Friend WithEvents btnStudeReport As System.Windows.Forms.Button
    Friend WithEvents cboStudeReport As System.Windows.Forms.ComboBox
    Friend WithEvents mskStudentNumber As System.Windows.Forms.MaskedTextBox
End Class
