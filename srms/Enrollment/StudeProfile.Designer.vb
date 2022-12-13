<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudeProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudeProfile))
        Me.txtBPlace = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.cboCourse = New System.Windows.Forms.ComboBox
        Me.CoursesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Enrollment.DataSet
        Me.Label8 = New System.Windows.Forms.Label
        Me.mskDateofBirth = New System.Windows.Forms.MaskedTextBox
        Me.cboCivilStatus = New System.Windows.Forms.ComboBox
        Me.cboSex = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.txtMName = New System.Windows.Forms.TextBox
        Me.txtFname = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.mskStudentNumber = New System.Windows.Forms.MaskedTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.txtAddress = New System.Windows.Forms.RichTextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtContactNumber = New System.Windows.Forms.TextBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtGuardian = New System.Windows.Forms.TextBox
        Me.txtGuardianContact = New System.Windows.Forms.TextBox
        Me.txtRelationship = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.txtRemarks = New System.Windows.Forms.RichTextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.cboSearch = New System.Windows.Forms.ComboBox
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.dgstudentsearch = New System.Windows.Forms.DataGridView
        Me.StudentNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MiddleNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BPlaceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CivilStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContactNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GuardianDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RelationshipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GuardianContactDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CourseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RemarksDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StudeprofileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudeprofileTableAdapter = New Enrollment.DataSetTableAdapters.studeprofileTableAdapter
        Me.CoursesTableAdapter = New Enrollment.DataSetTableAdapters.coursesTableAdapter
        CType(Me.CoursesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgstudentsearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudeprofileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBPlace
        '
        Me.txtBPlace.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtBPlace.Location = New System.Drawing.Point(320, 107)
        Me.txtBPlace.Name = "txtBPlace"
        Me.txtBPlace.Size = New System.Drawing.Size(146, 23)
        Me.txtBPlace.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(365, 87)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(76, 17)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "Birth Place"
        '
        'cboCourse
        '
        Me.cboCourse.DataSource = Me.CoursesBindingSource
        Me.cboCourse.DisplayMember = "coursedescription"
        Me.cboCourse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cboCourse.FormattingEnabled = True
        Me.cboCourse.Location = New System.Drawing.Point(168, 164)
        Me.cboCourse.Name = "cboCourse"
        Me.cboCourse.Size = New System.Drawing.Size(146, 24)
        Me.cboCourse.TabIndex = 9
        '
        'CoursesBindingSource
        '
        Me.CoursesBindingSource.DataMember = "courses"
        Me.CoursesBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(168, 143)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Course"
        '
        'mskDateofBirth
        '
        Me.mskDateofBirth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.mskDateofBirth.Location = New System.Drawing.Point(168, 107)
        Me.mskDateofBirth.Mask = "00/00/0000"
        Me.mskDateofBirth.Name = "mskDateofBirth"
        Me.mskDateofBirth.Size = New System.Drawing.Size(146, 23)
        Me.mskDateofBirth.TabIndex = 6
        Me.mskDateofBirth.ValidatingType = GetType(Date)
        '
        'cboCivilStatus
        '
        Me.cboCivilStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cboCivilStatus.FormattingEnabled = True
        Me.cboCivilStatus.Items.AddRange(New Object() {"Single", "Married", "Separated"})
        Me.cboCivilStatus.Location = New System.Drawing.Point(14, 164)
        Me.cboCivilStatus.Name = "cboCivilStatus"
        Me.cboCivilStatus.Size = New System.Drawing.Size(148, 24)
        Me.cboCivilStatus.TabIndex = 8
        '
        'cboSex
        '
        Me.cboSex.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cboSex.FormattingEnabled = True
        Me.cboSex.Location = New System.Drawing.Point(14, 106)
        Me.cboSex.Name = "cboSex"
        Me.cboSex.Size = New System.Drawing.Size(148, 24)
        Me.cboSex.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(168, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Date of Birth"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(11, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Civil Status"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(11, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Sex"
        '
        'txtLastName
        '
        Me.txtLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtLastName.Location = New System.Drawing.Point(320, 41)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(146, 26)
        Me.txtLastName.TabIndex = 4
        '
        'txtMName
        '
        Me.txtMName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtMName.Location = New System.Drawing.Point(168, 41)
        Me.txtMName.Name = "txtMName"
        Me.txtMName.Size = New System.Drawing.Size(146, 26)
        Me.txtMName.TabIndex = 3
        '
        'txtFname
        '
        Me.txtFname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtFname.Location = New System.Drawing.Point(14, 41)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(148, 26)
        Me.txtFname.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(320, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Lastname"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(165, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Middle Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(11, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Firstname"
        '
        'mskStudentNumber
        '
        Me.mskStudentNumber.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.mskStudentNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskStudentNumber.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.mskStudentNumber.Location = New System.Drawing.Point(160, 12)
        Me.mskStudentNumber.Name = "mskStudentNumber"
        Me.mskStudentNumber.Size = New System.Drawing.Size(212, 30)
        Me.mskStudentNumber.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Number"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(6, 60)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(487, 343)
        Me.TabControl1.TabIndex = 12
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage4.Controls.Add(Me.txtAddress)
        Me.TabPage4.Controls.Add(Me.txtBPlace)
        Me.TabPage4.Controls.Add(Me.Label4)
        Me.TabPage4.Controls.Add(Me.Label16)
        Me.TabPage4.Controls.Add(Me.Label12)
        Me.TabPage4.Controls.Add(Me.Label11)
        Me.TabPage4.Controls.Add(Me.Label3)
        Me.TabPage4.Controls.Add(Me.Label5)
        Me.TabPage4.Controls.Add(Me.txtLastName)
        Me.TabPage4.Controls.Add(Me.txtContactNumber)
        Me.TabPage4.Controls.Add(Me.Label6)
        Me.TabPage4.Controls.Add(Me.Label7)
        Me.TabPage4.Controls.Add(Me.cboCourse)
        Me.TabPage4.Controls.Add(Me.Label2)
        Me.TabPage4.Controls.Add(Me.cboSex)
        Me.TabPage4.Controls.Add(Me.Label8)
        Me.TabPage4.Controls.Add(Me.cboCivilStatus)
        Me.TabPage4.Controls.Add(Me.txtMName)
        Me.TabPage4.Controls.Add(Me.txtFname)
        Me.TabPage4.Controls.Add(Me.mskDateofBirth)
        Me.TabPage4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(479, 317)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Profile"
        '
        'txtAddress
        '
        Me.txtAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtAddress.Location = New System.Drawing.Point(14, 220)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(452, 79)
        Me.txtAddress.TabIndex = 11
        Me.txtAddress.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(11, 200)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(113, 17)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Present Address"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(366, 143)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 17)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Contact #"
        '
        'txtContactNumber
        '
        Me.txtContactNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtContactNumber.Location = New System.Drawing.Point(320, 165)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(146, 23)
        Me.txtContactNumber.TabIndex = 10
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.txtGuardian)
        Me.TabPage2.Controls.Add(Me.txtGuardianContact)
        Me.TabPage2.Controls.Add(Me.txtRelationship)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(550, 317)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Guardian"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(23, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Complete Name"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label19.Location = New System.Drawing.Point(23, 113)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(86, 17)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "Relationship"
        '
        'txtGuardian
        '
        Me.txtGuardian.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuardian.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtGuardian.Location = New System.Drawing.Point(193, 37)
        Me.txtGuardian.Name = "txtGuardian"
        Me.txtGuardian.Size = New System.Drawing.Size(236, 23)
        Me.txtGuardian.TabIndex = 0
        '
        'txtGuardianContact
        '
        Me.txtGuardianContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuardianContact.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtGuardianContact.Location = New System.Drawing.Point(193, 75)
        Me.txtGuardianContact.Name = "txtGuardianContact"
        Me.txtGuardianContact.Size = New System.Drawing.Size(234, 23)
        Me.txtGuardianContact.TabIndex = 1
        '
        'txtRelationship
        '
        Me.txtRelationship.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRelationship.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtRelationship.Location = New System.Drawing.Point(193, 113)
        Me.txtRelationship.Name = "txtRelationship"
        Me.txtRelationship.Size = New System.Drawing.Size(234, 23)
        Me.txtRelationship.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(23, 77)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 17)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Contact Number"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Controls.Add(Me.txtRemarks)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(550, 317)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Remarks"
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Location = New System.Drawing.Point(14, 23)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(521, 274)
        Me.txtRemarks.TabIndex = 0
        Me.txtRemarks.Text = ""
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TabControl1)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.mskStudentNumber)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 72)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(498, 415)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 72)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(8, 11)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(55, 55)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Tag = "Save"
        Me.btnSave.Text = "Save"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.btnSave, "Save")
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(135, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(55, 55)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Delete"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.Button2, "Delete")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(72, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(55, 55)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Update"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.Button1, "Update")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.dgstudentsearch)
        Me.GroupBox1.Location = New System.Drawing.Point(518, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(451, 415)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cboSearch)
        Me.GroupBox4.Controls.Add(Me.txtSearch)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(435, 60)
        Me.GroupBox4.TabIndex = 24
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Search"
        '
        'cboSearch
        '
        Me.cboSearch.FormattingEnabled = True
        Me.cboSearch.Items.AddRange(New Object() {"by Student Number", "by Lastname", " by Course"})
        Me.cboSearch.Location = New System.Drawing.Point(158, 19)
        Me.cboSearch.Name = "cboSearch"
        Me.cboSearch.Size = New System.Drawing.Size(155, 32)
        Me.cboSearch.TabIndex = 1
        Me.cboSearch.Text = "Search Category"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(6, 22)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(146, 29)
        Me.txtSearch.TabIndex = 0
        '
        'dgstudentsearch
        '
        Me.dgstudentsearch.AllowUserToAddRows = False
        Me.dgstudentsearch.AllowUserToDeleteRows = False
        Me.dgstudentsearch.AutoGenerateColumns = False
        Me.dgstudentsearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgstudentsearch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentNumberDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.MiddleNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.BDateDataGridViewTextBoxColumn, Me.BPlaceDataGridViewTextBoxColumn, Me.SexDataGridViewTextBoxColumn, Me.CivilStatusDataGridViewTextBoxColumn, Me.ContactNumberDataGridViewTextBoxColumn, Me.GuardianDataGridViewTextBoxColumn, Me.RelationshipDataGridViewTextBoxColumn, Me.GuardianContactDataGridViewTextBoxColumn, Me.CourseDataGridViewTextBoxColumn, Me.RemarksDataGridViewTextBoxColumn})
        Me.dgstudentsearch.DataSource = Me.StudeprofileBindingSource
        Me.dgstudentsearch.Location = New System.Drawing.Point(6, 82)
        Me.dgstudentsearch.Name = "dgstudentsearch"
        Me.dgstudentsearch.Size = New System.Drawing.Size(435, 327)
        Me.dgstudentsearch.TabIndex = 0
        '
        'StudentNumberDataGridViewTextBoxColumn
        '
        Me.StudentNumberDataGridViewTextBoxColumn.DataPropertyName = "StudentNumber"
        Me.StudentNumberDataGridViewTextBoxColumn.HeaderText = "StudentNumber"
        Me.StudentNumberDataGridViewTextBoxColumn.Name = "StudentNumberDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'MiddleNameDataGridViewTextBoxColumn
        '
        Me.MiddleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName"
        Me.MiddleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName"
        Me.MiddleNameDataGridViewTextBoxColumn.Name = "MiddleNameDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'BDateDataGridViewTextBoxColumn
        '
        Me.BDateDataGridViewTextBoxColumn.DataPropertyName = "BDate"
        Me.BDateDataGridViewTextBoxColumn.HeaderText = "BDate"
        Me.BDateDataGridViewTextBoxColumn.Name = "BDateDataGridViewTextBoxColumn"
        '
        'BPlaceDataGridViewTextBoxColumn
        '
        Me.BPlaceDataGridViewTextBoxColumn.DataPropertyName = "BPlace"
        Me.BPlaceDataGridViewTextBoxColumn.HeaderText = "BPlace"
        Me.BPlaceDataGridViewTextBoxColumn.Name = "BPlaceDataGridViewTextBoxColumn"
        '
        'SexDataGridViewTextBoxColumn
        '
        Me.SexDataGridViewTextBoxColumn.DataPropertyName = "Sex"
        Me.SexDataGridViewTextBoxColumn.HeaderText = "Sex"
        Me.SexDataGridViewTextBoxColumn.Name = "SexDataGridViewTextBoxColumn"
        '
        'CivilStatusDataGridViewTextBoxColumn
        '
        Me.CivilStatusDataGridViewTextBoxColumn.DataPropertyName = "CivilStatus"
        Me.CivilStatusDataGridViewTextBoxColumn.HeaderText = "CivilStatus"
        Me.CivilStatusDataGridViewTextBoxColumn.Name = "CivilStatusDataGridViewTextBoxColumn"
        '
        'ContactNumberDataGridViewTextBoxColumn
        '
        Me.ContactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber"
        Me.ContactNumberDataGridViewTextBoxColumn.HeaderText = "ContactNumber"
        Me.ContactNumberDataGridViewTextBoxColumn.Name = "ContactNumberDataGridViewTextBoxColumn"
        '
        'GuardianDataGridViewTextBoxColumn
        '
        Me.GuardianDataGridViewTextBoxColumn.DataPropertyName = "Guardian"
        Me.GuardianDataGridViewTextBoxColumn.HeaderText = "Guardian"
        Me.GuardianDataGridViewTextBoxColumn.Name = "GuardianDataGridViewTextBoxColumn"
        '
        'RelationshipDataGridViewTextBoxColumn
        '
        Me.RelationshipDataGridViewTextBoxColumn.DataPropertyName = "Relationship"
        Me.RelationshipDataGridViewTextBoxColumn.HeaderText = "Relationship"
        Me.RelationshipDataGridViewTextBoxColumn.Name = "RelationshipDataGridViewTextBoxColumn"
        '
        'GuardianContactDataGridViewTextBoxColumn
        '
        Me.GuardianContactDataGridViewTextBoxColumn.DataPropertyName = "GuardianContact"
        Me.GuardianContactDataGridViewTextBoxColumn.HeaderText = "GuardianContact"
        Me.GuardianContactDataGridViewTextBoxColumn.Name = "GuardianContactDataGridViewTextBoxColumn"
        '
        'CourseDataGridViewTextBoxColumn
        '
        Me.CourseDataGridViewTextBoxColumn.DataPropertyName = "Course"
        Me.CourseDataGridViewTextBoxColumn.HeaderText = "Course"
        Me.CourseDataGridViewTextBoxColumn.Name = "CourseDataGridViewTextBoxColumn"
        '
        'RemarksDataGridViewTextBoxColumn
        '
        Me.RemarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks"
        Me.RemarksDataGridViewTextBoxColumn.HeaderText = "Remarks"
        Me.RemarksDataGridViewTextBoxColumn.Name = "RemarksDataGridViewTextBoxColumn"
        '
        'StudeprofileBindingSource
        '
        Me.StudeprofileBindingSource.DataMember = "studeprofile"
        Me.StudeprofileBindingSource.DataSource = Me.DataSet
        '
        'StudeprofileTableAdapter
        '
        Me.StudeprofileTableAdapter.ClearBeforeFill = True
        '
        'CoursesTableAdapter
        '
        Me.CoursesTableAdapter.ClearBeforeFill = True
        '
        'frmStudeProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(980, 499)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmStudeProfile"
        Me.Text = "Student's Profile"
        CType(Me.CoursesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgstudentsearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudeprofileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mskStudentNumber As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtMName As System.Windows.Forms.TextBox
    Friend WithEvents txtFname As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mskDateofBirth As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboCivilStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cboSex As System.Windows.Forms.ComboBox
    Friend WithEvents cboCourse As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtBPlace As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtContactNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtGuardian As System.Windows.Forms.TextBox
    Friend WithEvents txtRelationship As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtGuardianContact As System.Windows.Forms.TextBox
    Friend WithEvents txtRemarks As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents txtAddress As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgstudentsearch As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet As Enrollment.DataSet
    Friend WithEvents StudeprofileBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudeprofileTableAdapter As Enrollment.DataSetTableAdapters.studeprofileTableAdapter
    Friend WithEvents StudentNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MiddleNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BPlaceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SexDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CivilStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GuardianDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RelationshipDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GuardianContactDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CourseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RemarksDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cboSearch As System.Windows.Forms.ComboBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents CoursesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CoursesTableAdapter As Enrollment.DataSetTableAdapters.coursesTableAdapter
End Class
