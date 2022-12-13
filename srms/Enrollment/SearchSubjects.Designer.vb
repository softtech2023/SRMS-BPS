<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchSubjects
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchSubjects))
        Me.cbosearch = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtsearch = New System.Windows.Forms.TextBox
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
        Me.DataSet = New Enrollment.DataSet
        Me.SubjectsTableAdapter = New Enrollment.DataSetTableAdapters.subjectsTableAdapter
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgsubjects, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbosearch
        '
        Me.cbosearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbosearch.FormattingEnabled = True
        Me.cbosearch.Items.AddRange(New Object() {"by Subject Code", "by Description"})
        Me.cbosearch.Location = New System.Drawing.Point(441, 45)
        Me.cbosearch.Name = "cbosearch"
        Me.cbosearch.Size = New System.Drawing.Size(167, 28)
        Me.cbosearch.TabIndex = 20
        Me.cbosearch.Text = "Category"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(157, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 24)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Search"
        '
        'txtsearch
        '
        Me.txtsearch.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(233, 44)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(202, 26)
        Me.txtsearch.TabIndex = 19
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgsubjects)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 72)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(596, 261)
        Me.GroupBox2.TabIndex = 17
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
        Me.dgsubjects.Size = New System.Drawing.Size(584, 239)
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
        Me.SubjectcodeDataGridViewTextBoxColumn.HeaderText = "Subject Code"
        Me.SubjectcodeDataGridViewTextBoxColumn.Name = "SubjectcodeDataGridViewTextBoxColumn"
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.Width = 250
        '
        'LecunitDataGridViewTextBoxColumn
        '
        Me.LecunitDataGridViewTextBoxColumn.DataPropertyName = "lecunit"
        Me.LecunitDataGridViewTextBoxColumn.HeaderText = "Lec"
        Me.LecunitDataGridViewTextBoxColumn.Name = "LecunitDataGridViewTextBoxColumn"
        Me.LecunitDataGridViewTextBoxColumn.Width = 50
        '
        'LabunitDataGridViewTextBoxColumn
        '
        Me.LabunitDataGridViewTextBoxColumn.DataPropertyName = "labunit"
        Me.LabunitDataGridViewTextBoxColumn.HeaderText = "Lab"
        Me.LabunitDataGridViewTextBoxColumn.Name = "LabunitDataGridViewTextBoxColumn"
        Me.LabunitDataGridViewTextBoxColumn.Width = 50
        '
        'PrereqDataGridViewTextBoxColumn
        '
        Me.PrereqDataGridViewTextBoxColumn.DataPropertyName = "prereq"
        Me.PrereqDataGridViewTextBoxColumn.HeaderText = "Prerequisite"
        Me.PrereqDataGridViewTextBoxColumn.Name = "PrereqDataGridViewTextBoxColumn"
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
        Me.SubjectsBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SubjectsTableAdapter
        '
        Me.SubjectsTableAdapter.ClearBeforeFill = True
        '
        'frmSearchSubjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 345)
        Me.Controls.Add(Me.cbosearch)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSearchSubjects"
        Me.Text = "Search Subjects"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgsubjects, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbosearch As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgsubjects As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet As Enrollment.DataSet
    Friend WithEvents SubjectsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubjectsTableAdapter As Enrollment.DataSetTableAdapters.subjectsTableAdapter
    Friend WithEvents SubjectidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubjectcodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LecunitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LabunitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrereqDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurriculumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
