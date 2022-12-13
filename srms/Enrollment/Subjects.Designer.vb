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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtPreq = New System.Windows.Forms.TextBox
        Me.txtLabUnits = New System.Windows.Forms.TextBox
        Me.txtLecUnits = New System.Windows.Forms.TextBox
        Me.txtdescription = New System.Windows.Forms.TextBox
        Me.txtSubjectCode = New System.Windows.Forms.TextBox
        Me.cboCurriculum = New System.Windows.Forms.ComboBox
        Me.CurriculumBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Enrollment.DataSet
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.CurriculumTableAdapter = New Enrollment.DataSetTableAdapters.curriculumTableAdapter
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dgsubjects = New System.Windows.Forms.DataGridView
        Me.SubjectidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SubjectcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LecunitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LabunitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrereqDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CurriculumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SubjectsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Enrollment.DataSet
        Me.txtsearch = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.SubjectsTableAdapter = New Enrollment.DataSetTableAdapters.subjectsTableAdapter
        Me.lblID = New System.Windows.Forms.Label
        Me.cbosearch = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.CurriculumBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgsubjects, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPreq)
        Me.GroupBox1.Controls.Add(Me.txtLabUnits)
        Me.GroupBox1.Controls.Add(Me.txtLecUnits)
        Me.GroupBox1.Controls.Add(Me.txtdescription)
        Me.GroupBox1.Controls.Add(Me.txtSubjectCode)
        Me.GroupBox1.Controls.Add(Me.cboCurriculum)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(338, 191)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtPreq
        '
        Me.txtPreq.Location = New System.Drawing.Point(104, 152)
        Me.txtPreq.Name = "txtPreq"
        Me.txtPreq.Size = New System.Drawing.Size(223, 23)
        Me.txtPreq.TabIndex = 11
        '
        'txtLabUnits
        '
        Me.txtLabUnits.Location = New System.Drawing.Point(256, 116)
        Me.txtLabUnits.Name = "txtLabUnits"
        Me.txtLabUnits.Size = New System.Drawing.Size(71, 23)
        Me.txtLabUnits.TabIndex = 10
        '
        'txtLecUnits
        '
        Me.txtLecUnits.Location = New System.Drawing.Point(104, 116)
        Me.txtLecUnits.Name = "txtLecUnits"
        Me.txtLecUnits.Size = New System.Drawing.Size(71, 23)
        Me.txtLecUnits.TabIndex = 9
        '
        'txtdescription
        '
        Me.txtdescription.Location = New System.Drawing.Point(104, 75)
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(223, 23)
        Me.txtdescription.TabIndex = 8
        '
        'txtSubjectCode
        '
        Me.txtSubjectCode.Location = New System.Drawing.Point(104, 45)
        Me.txtSubjectCode.Name = "txtSubjectCode"
        Me.txtSubjectCode.Size = New System.Drawing.Size(223, 23)
        Me.txtSubjectCode.TabIndex = 7
        '
        'cboCurriculum
        '
        Me.cboCurriculum.DataSource = Me.CurriculumBindingSource
        Me.cboCurriculum.DisplayMember = "CurriculumName"
        Me.cboCurriculum.FormattingEnabled = True
        Me.cboCurriculum.Location = New System.Drawing.Point(104, 13)
        Me.cboCurriculum.Name = "cboCurriculum"
        Me.cboCurriculum.Size = New System.Drawing.Size(223, 24)
        Me.cboCurriculum.TabIndex = 6
        '
        'CurriculumBindingSource
        '
        Me.CurriculumBindingSource.DataMember = "curriculum"
        Me.CurriculumBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Prerequisite"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(182, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Lab Units"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Lec Units"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Subject Code"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Curriculum"
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Location = New System.Drawing.Point(194, 256)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 13
        Me.btnEdit.Text = "Update"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Location = New System.Drawing.Point(275, 256)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(113, 256)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'CurriculumTableAdapter
        '
        Me.CurriculumTableAdapter.ClearBeforeFill = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgsubjects)
        Me.GroupBox2.Location = New System.Drawing.Point(356, 50)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(375, 229)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'dgsubjects
        '
        Me.dgsubjects.AllowUserToAddRows = False
        Me.dgsubjects.AllowUserToDeleteRows = False
        Me.dgsubjects.AutoGenerateColumns = False
        Me.dgsubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgsubjects.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SubjectidDataGridViewTextBoxColumn, Me.SubjectcodeDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.LecunitDataGridViewTextBoxColumn, Me.LabunitDataGridViewTextBoxColumn, Me.PrereqDataGridViewTextBoxColumn, Me.CurriculumDataGridViewTextBoxColumn})
        Me.dgsubjects.DataSource = Me.SubjectsBindingSource
        Me.dgsubjects.Location = New System.Drawing.Point(6, 16)
        Me.dgsubjects.Name = "dgsubjects"
        Me.dgsubjects.Size = New System.Drawing.Size(363, 207)
        Me.dgsubjects.TabIndex = 17
        '
        'SubjectidDataGridViewTextBoxColumn
        '
        Me.SubjectidDataGridViewTextBoxColumn.DataPropertyName = "subjectid"
        Me.SubjectidDataGridViewTextBoxColumn.HeaderText = "subjectid"
        Me.SubjectidDataGridViewTextBoxColumn.Name = "SubjectidDataGridViewTextBoxColumn"
        Me.SubjectidDataGridViewTextBoxColumn.Visible = False
        '
        'SubjectcodeDataGridViewTextBoxColumn
        '
        Me.SubjectcodeDataGridViewTextBoxColumn.DataPropertyName = "subjectcode"
        Me.SubjectcodeDataGridViewTextBoxColumn.HeaderText = "Code"
        Me.SubjectcodeDataGridViewTextBoxColumn.Name = "SubjectcodeDataGridViewTextBoxColumn"
        Me.SubjectcodeDataGridViewTextBoxColumn.Width = 50
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.Width = 180
        '
        'LecunitDataGridViewTextBoxColumn
        '
        Me.LecunitDataGridViewTextBoxColumn.DataPropertyName = "lecunit"
        Me.LecunitDataGridViewTextBoxColumn.HeaderText = "Lec. Unit"
        Me.LecunitDataGridViewTextBoxColumn.Name = "LecunitDataGridViewTextBoxColumn"
        Me.LecunitDataGridViewTextBoxColumn.Width = 40
        '
        'LabunitDataGridViewTextBoxColumn
        '
        Me.LabunitDataGridViewTextBoxColumn.DataPropertyName = "labunit"
        Me.LabunitDataGridViewTextBoxColumn.HeaderText = "Lab. Unit"
        Me.LabunitDataGridViewTextBoxColumn.Name = "LabunitDataGridViewTextBoxColumn"
        Me.LabunitDataGridViewTextBoxColumn.Width = 40
        '
        'PrereqDataGridViewTextBoxColumn
        '
        Me.PrereqDataGridViewTextBoxColumn.DataPropertyName = "prereq"
        Me.PrereqDataGridViewTextBoxColumn.HeaderText = "Prerequisite"
        Me.PrereqDataGridViewTextBoxColumn.Name = "PrereqDataGridViewTextBoxColumn"
        Me.PrereqDataGridViewTextBoxColumn.Width = 150
        '
        'CurriculumDataGridViewTextBoxColumn
        '
        Me.CurriculumDataGridViewTextBoxColumn.DataPropertyName = "curriculum"
        Me.CurriculumDataGridViewTextBoxColumn.HeaderText = "curriculum"
        Me.CurriculumDataGridViewTextBoxColumn.Name = "CurriculumDataGridViewTextBoxColumn"
        Me.CurriculumDataGridViewTextBoxColumn.Visible = False
        '
        'SubjectsBindingSource
        '
        Me.SubjectsBindingSource.DataMember = "subjects"
        Me.SubjectsBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtsearch
        '
        Me.txtsearch.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(356, 23)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(202, 26)
        Me.txtsearch.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(280, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 24)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Search"
        '
        'SubjectsTableAdapter
        '
        Me.SubjectsTableAdapter.ClearBeforeFill = True
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(215, 22)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(18, 13)
        Me.lblID.TabIndex = 8
        Me.lblID.Text = "ID"
        Me.lblID.Visible = False
        '
        'cbosearch
        '
        Me.cbosearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbosearch.FormattingEnabled = True
        Me.cbosearch.Items.AddRange(New Object() {"by Subject Code", "by Description"})
        Me.cbosearch.Location = New System.Drawing.Point(564, 22)
        Me.cbosearch.Name = "cbosearch"
        Me.cbosearch.Size = New System.Drawing.Size(167, 28)
        Me.cbosearch.TabIndex = 16
        Me.cbosearch.Text = "Category"
        '
        'frmSubjects
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 305)
        Me.Controls.Add(Me.cbosearch)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSubjects"
        Me.Text = "Subjects"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CurriculumBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgsubjects, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPreq As System.Windows.Forms.TextBox
    Friend WithEvents txtLabUnits As System.Windows.Forms.TextBox
    Friend WithEvents txtLecUnits As System.Windows.Forms.TextBox
    Friend WithEvents txtdescription As System.Windows.Forms.TextBox
    Friend WithEvents txtSubjectCode As System.Windows.Forms.TextBox
    Friend WithEvents cboCurriculum As System.Windows.Forms.ComboBox
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents DataSet As Enrollment.DataSet
    Friend WithEvents CurriculumBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CurriculumTableAdapter As Enrollment.DataSetTableAdapters.curriculumTableAdapter
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgsubjects As System.Windows.Forms.DataGridView
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As Enrollment.DataSet
    Friend WithEvents SubjectsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubjectsTableAdapter As Enrollment.DataSetTableAdapters.subjectsTableAdapter
    Friend WithEvents SubjectidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubjectcodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LecunitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LabunitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrereqDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurriculumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents cbosearch As System.Windows.Forms.ComboBox
End Class
