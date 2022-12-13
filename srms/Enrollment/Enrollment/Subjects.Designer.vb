<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubjects
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSubjects))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtSubjectCode = New System.Windows.Forms.TextBox
        Me.txtdescription = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtLecUnits = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnViewSubjects = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.cboCourse = New System.Windows.Forms.ComboBox
        Me.CoursesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New SIMS.DataSet
        Me.Label8 = New System.Windows.Forms.Label
        Me.cboYearLevel = New System.Windows.Forms.ComboBox
        Me.btnOK = New System.Windows.Forms.Button
        Me.lblID = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtsearch = New System.Windows.Forms.TextBox
        Me.txtCurriculum = New System.Windows.Forms.TextBox
        Me.txtEffective = New System.Windows.Forms.TextBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgsubjects = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cboSemEffective = New System.Windows.Forms.ComboBox
        Me.txtSYEffective = New System.Windows.Forms.TextBox
        Me.cboSemester = New System.Windows.Forms.ComboBox
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtPreq = New System.Windows.Forms.TextBox
        Me.txtLabUnits = New System.Windows.Forms.TextBox
        Me.mainProfTS = New System.Windows.Forms.ToolStrip
        Me.tsSave = New System.Windows.Forms.ToolStripButton
        Me.tsUpdate = New System.Windows.Forms.ToolStripButton
        Me.tsDelete = New System.Windows.Forms.ToolStripButton
        Me.CoursesTableAdapter = New SIMS.DataSetTableAdapters.coursesTableAdapter
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboCategory = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.CoursesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgsubjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.mainProfTS.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel6)
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.dgsubjects)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(619, 392)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.txtSubjectCode)
        Me.Panel3.Controls.Add(Me.txtdescription)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.txtLecUnits)
        Me.Panel3.Location = New System.Drawing.Point(0, 53)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(615, 28)
        Me.Panel3.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(11, 4)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 19)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Subject Code"
        '
        'txtSubjectCode
        '
        Me.txtSubjectCode.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubjectCode.ForeColor = System.Drawing.Color.Black
        Me.txtSubjectCode.Location = New System.Drawing.Point(102, 1)
        Me.txtSubjectCode.Name = "txtSubjectCode"
        Me.txtSubjectCode.Size = New System.Drawing.Size(88, 26)
        Me.txtSubjectCode.TabIndex = 4
        '
        'txtdescription
        '
        Me.txtdescription.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescription.ForeColor = System.Drawing.Color.Black
        Me.txtdescription.Location = New System.Drawing.Point(275, 1)
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(243, 26)
        Me.txtdescription.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(196, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Description"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(524, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Units"
        '
        'txtLecUnits
        '
        Me.txtLecUnits.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLecUnits.ForeColor = System.Drawing.Color.Black
        Me.txtLecUnits.Location = New System.Drawing.Point(568, 1)
        Me.txtLecUnits.Name = "txtLecUnits"
        Me.txtLecUnits.Size = New System.Drawing.Size(47, 26)
        Me.txtLecUnits.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.btnViewSubjects)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.cboCourse)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.cboYearLevel)
        Me.Panel2.Controls.Add(Me.btnOK)
        Me.Panel2.Controls.Add(Me.lblID)
        Me.Panel2.Location = New System.Drawing.Point(0, 20)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(615, 28)
        Me.Panel2.TabIndex = 0
        '
        'btnViewSubjects
        '
        Me.btnViewSubjects.Location = New System.Drawing.Point(511, -1)
        Me.btnViewSubjects.Name = "btnViewSubjects"
        Me.btnViewSubjects.Size = New System.Drawing.Size(99, 30)
        Me.btnViewSubjects.TabIndex = 20
        Me.btnViewSubjects.Text = "View Subjects"
        Me.btnViewSubjects.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(11, 4)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 19)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Department"
        '
        'cboCourse
        '
        Me.cboCourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboCourse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCourse.DataSource = Me.CoursesBindingSource
        Me.cboCourse.DisplayMember = "CourseDescription"
        Me.cboCourse.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCourse.FormattingEnabled = True
        Me.cboCourse.Location = New System.Drawing.Point(102, 0)
        Me.cboCourse.Name = "cboCourse"
        Me.cboCourse.Size = New System.Drawing.Size(167, 27)
        Me.cboCourse.TabIndex = 1
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
        Me.Label8.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(285, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 19)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Grade Level"
        '
        'cboYearLevel
        '
        Me.cboYearLevel.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYearLevel.FormattingEnabled = True
        Me.cboYearLevel.Location = New System.Drawing.Point(371, 0)
        Me.cboYearLevel.Name = "cboYearLevel"
        Me.cboYearLevel.Size = New System.Drawing.Size(120, 27)
        Me.cboYearLevel.TabIndex = 2
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(446, 2)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(44, 23)
        Me.btnOK.TabIndex = 18
        Me.btnOK.Text = "Ok"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.Color.Black
        Me.lblID.Location = New System.Drawing.Point(70, 8)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(22, 19)
        Me.lblID.TabIndex = 17
        Me.lblID.Text = "ID"
        Me.lblID.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtsearch)
        Me.Panel1.Controls.Add(Me.txtCurriculum)
        Me.Panel1.Controls.Add(Me.txtEffective)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 116)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(615, 30)
        Me.Panel1.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(11, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 19)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Search"
        '
        'txtsearch
        '
        Me.txtsearch.BackColor = System.Drawing.Color.White
        Me.txtsearch.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.ForeColor = System.Drawing.Color.Black
        Me.txtsearch.Location = New System.Drawing.Point(65, 2)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(183, 26)
        Me.txtsearch.TabIndex = 12
        Me.txtsearch.TabStop = False
        '
        'txtCurriculum
        '
        Me.txtCurriculum.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurriculum.ForeColor = System.Drawing.Color.Black
        Me.txtCurriculum.Location = New System.Drawing.Point(484, 3)
        Me.txtCurriculum.Name = "txtCurriculum"
        Me.txtCurriculum.Size = New System.Drawing.Size(128, 26)
        Me.txtCurriculum.TabIndex = 6
        Me.txtCurriculum.Visible = False
        '
        'txtEffective
        '
        Me.txtEffective.Location = New System.Drawing.Point(254, 2)
        Me.txtEffective.Name = "txtEffective"
        Me.txtEffective.Size = New System.Drawing.Size(140, 26)
        Me.txtEffective.TabIndex = 28
        Me.txtEffective.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(136, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(54, 21)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(402, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Curriculum"
        Me.Label1.Visible = False
        '
        'dgsubjects
        '
        Me.dgsubjects.AllowUserToAddRows = False
        Me.dgsubjects.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgsubjects.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgsubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgsubjects.Location = New System.Drawing.Point(0, 151)
        Me.dgsubjects.Name = "dgsubjects"
        Me.dgsubjects.ReadOnly = True
        Me.dgsubjects.Size = New System.Drawing.Size(615, 235)
        Me.dgsubjects.TabIndex = 0
        Me.dgsubjects.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Panel5)
        Me.GroupBox2.Controls.Add(Me.cboSemester)
        Me.GroupBox2.Controls.Add(Me.Panel4)
        Me.GroupBox2.Controls.Add(Me.txtLabUnits)
        Me.GroupBox2.Location = New System.Drawing.Point(411, 70)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(118, 26)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Hidden"
        Me.GroupBox2.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(43, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 19)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Sem."
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Silver
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.cboSemEffective)
        Me.Panel5.Controls.Add(Me.txtSYEffective)
        Me.Panel5.Location = New System.Drawing.Point(5, 66)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(518, 28)
        Me.Panel5.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(196, 4)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 19)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "SY"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(11, 4)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Effectivity"
        '
        'cboSemEffective
        '
        Me.cboSemEffective.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSemEffective.FormattingEnabled = True
        Me.cboSemEffective.Items.AddRange(New Object() {"1st Sem.", "2nd Sem.", "Summer"})
        Me.cboSemEffective.Location = New System.Drawing.Point(102, 0)
        Me.cboSemEffective.Name = "cboSemEffective"
        Me.cboSemEffective.Size = New System.Drawing.Size(88, 27)
        Me.cboSemEffective.TabIndex = 9
        '
        'txtSYEffective
        '
        Me.txtSYEffective.Location = New System.Drawing.Point(275, 1)
        Me.txtSYEffective.Name = "txtSYEffective"
        Me.txtSYEffective.Size = New System.Drawing.Size(243, 20)
        Me.txtSYEffective.TabIndex = 10
        '
        'cboSemester
        '
        Me.cboSemester.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSemester.FormattingEnabled = True
        Me.cboSemester.Items.AddRange(New Object() {"1st Sem.", "2nd Sem.", "Summer"})
        Me.cboSemester.Location = New System.Drawing.Point(86, 12)
        Me.cboSemester.Name = "cboSemester"
        Me.cboSemester.Size = New System.Drawing.Size(108, 27)
        Me.cboSemester.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.txtPreq)
        Me.Panel4.Location = New System.Drawing.Point(5, 33)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(518, 28)
        Me.Panel4.TabIndex = 31
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(11, 4)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 19)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Prerequisite"
        '
        'txtPreq
        '
        Me.txtPreq.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPreq.ForeColor = System.Drawing.Color.Black
        Me.txtPreq.Location = New System.Drawing.Point(102, 1)
        Me.txtPreq.Name = "txtPreq"
        Me.txtPreq.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtPreq.Size = New System.Drawing.Size(416, 26)
        Me.txtPreq.TabIndex = 8
        '
        'txtLabUnits
        '
        Me.txtLabUnits.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLabUnits.ForeColor = System.Drawing.Color.Black
        Me.txtLabUnits.Location = New System.Drawing.Point(147, 45)
        Me.txtLabUnits.Name = "txtLabUnits"
        Me.txtLabUnits.Size = New System.Drawing.Size(47, 26)
        Me.txtLabUnits.TabIndex = 7
        '
        'mainProfTS
        '
        Me.mainProfTS.BackColor = System.Drawing.Color.Transparent
        Me.mainProfTS.Font = New System.Drawing.Font("Segoe Condensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainProfTS.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.mainProfTS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsSave, Me.tsUpdate, Me.tsDelete})
        Me.mainProfTS.Location = New System.Drawing.Point(0, 0)
        Me.mainProfTS.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.mainProfTS.Name = "mainProfTS"
        Me.mainProfTS.Padding = New System.Windows.Forms.Padding(10)
        Me.mainProfTS.Size = New System.Drawing.Size(619, 69)
        Me.mainProfTS.TabIndex = 16
        Me.mainProfTS.Text = "ts"
        '
        'tsSave
        '
        Me.tsSave.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsSave.Image = CType(resources.GetObject("tsSave.Image"), System.Drawing.Image)
        Me.tsSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSave.Name = "tsSave"
        Me.tsSave.Size = New System.Drawing.Size(36, 46)
        Me.tsSave.Text = "&Save"
        Me.tsSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsSave.ToolTipText = "Ctrl + S"
        '
        'tsUpdate
        '
        Me.tsUpdate.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsUpdate.Image = CType(resources.GetObject("tsUpdate.Image"), System.Drawing.Image)
        Me.tsUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsUpdate.Name = "tsUpdate"
        Me.tsUpdate.Size = New System.Drawing.Size(50, 46)
        Me.tsUpdate.Text = "&Update"
        Me.tsUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsUpdate.ToolTipText = "Ctrl + U"
        '
        'tsDelete
        '
        Me.tsDelete.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsDelete.Image = CType(resources.GetObject("tsDelete.Image"), System.Drawing.Image)
        Me.tsDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDelete.Name = "tsDelete"
        Me.tsDelete.Size = New System.Drawing.Size(46, 46)
        Me.tsDelete.Text = "&Delete"
        Me.tsDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsDelete.ToolTipText = "Del"
        '
        'CoursesTableAdapter
        '
        Me.CoursesTableAdapter.ClearBeforeFill = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Silver
        Me.Panel6.Controls.Add(Me.cboCategory)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Location = New System.Drawing.Point(0, 84)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(615, 28)
        Me.Panel6.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(11, 4)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Subject Category"
        '
        'cboCategory
        '
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Items.AddRange(New Object() {"Core", "Applied", "Specialized", "Other Subjects"})
        Me.cboCategory.Location = New System.Drawing.Point(121, 1)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(397, 27)
        Me.cboCategory.TabIndex = 7
        '
        'frmSubjects
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(619, 467)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.mainProfTS)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSubjects"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "[  Subjects Entry Form  ]"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.CoursesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgsubjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.mainProfTS.ResumeLayout(False)
        Me.mainProfTS.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPreq As System.Windows.Forms.TextBox
    Friend WithEvents txtLabUnits As System.Windows.Forms.TextBox
    Friend WithEvents txtLecUnits As System.Windows.Forms.TextBox
    Friend WithEvents txtdescription As System.Windows.Forms.TextBox
    Friend WithEvents txtSubjectCode As System.Windows.Forms.TextBox
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents dgsubjects As System.Windows.Forms.DataGridView
    Friend WithEvents mainProfTS As System.Windows.Forms.ToolStrip
    Friend WithEvents tsSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsUpdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents cboYearLevel As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboSemester As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboCourse As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents txtCurriculum As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboSemEffective As System.Windows.Forms.ComboBox
    Friend WithEvents txtSYEffective As System.Windows.Forms.TextBox
    Friend WithEvents txtEffective As System.Windows.Forms.TextBox
    Friend WithEvents DataSet As SIMS.DataSet
    Friend WithEvents CoursesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CoursesTableAdapter As SIMS.DataSetTableAdapters.coursesTableAdapter
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnViewSubjects As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboCategory As System.Windows.Forms.ComboBox
End Class
