<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchSemSubjects
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchSemSubjects))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgsubjects = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.frmID = New System.Windows.Forms.Label
        Me.DataSet = New Enrollment.DataSet
        Me.SemsubjectsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SemsubjectsTableAdapter = New Enrollment.DataSetTableAdapters.semsubjectsTableAdapter
        Me.SemsubjectsIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SubjectCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LecUnitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LabUnitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SectionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RoomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SlotDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IDNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgsubjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SemsubjectsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgsubjects)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(555, 246)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'dgsubjects
        '
        Me.dgsubjects.AllowUserToAddRows = False
        Me.dgsubjects.AllowUserToDeleteRows = False
        Me.dgsubjects.AutoGenerateColumns = False
        Me.dgsubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgsubjects.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SemsubjectsIDDataGridViewTextBoxColumn, Me.SubjectCodeDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.LecUnitDataGridViewTextBoxColumn, Me.LabUnitDataGridViewTextBoxColumn, Me.SectionDataGridViewTextBoxColumn, Me.DayDataGridViewTextBoxColumn, Me.TimeDataGridViewTextBoxColumn, Me.RoomDataGridViewTextBoxColumn, Me.SlotDataGridViewTextBoxColumn, Me.ClassDataGridViewTextBoxColumn, Me.IDNumberDataGridViewTextBoxColumn})
        Me.dgsubjects.DataSource = Me.SemsubjectsBindingSource
        Me.dgsubjects.Location = New System.Drawing.Point(6, 30)
        Me.dgsubjects.Name = "dgsubjects"
        Me.dgsubjects.Size = New System.Drawing.Size(543, 210)
        Me.dgsubjects.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtSearch)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(555, 64)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtSearch.Location = New System.Drawing.Point(83, 25)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(243, 26)
        Me.txtSearch.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search"
        '
        'frmID
        '
        Me.frmID.AutoSize = True
        Me.frmID.Location = New System.Drawing.Point(351, 8)
        Me.frmID.Name = "frmID"
        Me.frmID.Size = New System.Drawing.Size(18, 13)
        Me.frmID.TabIndex = 2
        Me.frmID.Text = "ID"
        Me.frmID.Visible = False
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SemsubjectsBindingSource
        '
        Me.SemsubjectsBindingSource.DataMember = "semsubjects"
        Me.SemsubjectsBindingSource.DataSource = Me.DataSet
        '
        'SemsubjectsTableAdapter
        '
        Me.SemsubjectsTableAdapter.ClearBeforeFill = True
        '
        'SemsubjectsIDDataGridViewTextBoxColumn
        '
        Me.SemsubjectsIDDataGridViewTextBoxColumn.DataPropertyName = "semsubjectsID"
        Me.SemsubjectsIDDataGridViewTextBoxColumn.HeaderText = "semsubjectsID"
        Me.SemsubjectsIDDataGridViewTextBoxColumn.Name = "SemsubjectsIDDataGridViewTextBoxColumn"
        Me.SemsubjectsIDDataGridViewTextBoxColumn.Visible = False
        '
        'SubjectCodeDataGridViewTextBoxColumn
        '
        Me.SubjectCodeDataGridViewTextBoxColumn.DataPropertyName = "SubjectCode"
        Me.SubjectCodeDataGridViewTextBoxColumn.HeaderText = "SubjectCode"
        Me.SubjectCodeDataGridViewTextBoxColumn.Name = "SubjectCodeDataGridViewTextBoxColumn"
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        '
        'LecUnitDataGridViewTextBoxColumn
        '
        Me.LecUnitDataGridViewTextBoxColumn.DataPropertyName = "LecUnit"
        Me.LecUnitDataGridViewTextBoxColumn.HeaderText = "LecUnit"
        Me.LecUnitDataGridViewTextBoxColumn.Name = "LecUnitDataGridViewTextBoxColumn"
        '
        'LabUnitDataGridViewTextBoxColumn
        '
        Me.LabUnitDataGridViewTextBoxColumn.DataPropertyName = "LabUnit"
        Me.LabUnitDataGridViewTextBoxColumn.HeaderText = "LabUnit"
        Me.LabUnitDataGridViewTextBoxColumn.Name = "LabUnitDataGridViewTextBoxColumn"
        '
        'SectionDataGridViewTextBoxColumn
        '
        Me.SectionDataGridViewTextBoxColumn.DataPropertyName = "Section"
        Me.SectionDataGridViewTextBoxColumn.HeaderText = "Section"
        Me.SectionDataGridViewTextBoxColumn.Name = "SectionDataGridViewTextBoxColumn"
        '
        'DayDataGridViewTextBoxColumn
        '
        Me.DayDataGridViewTextBoxColumn.DataPropertyName = "Day"
        Me.DayDataGridViewTextBoxColumn.HeaderText = "Day"
        Me.DayDataGridViewTextBoxColumn.Name = "DayDataGridViewTextBoxColumn"
        '
        'TimeDataGridViewTextBoxColumn
        '
        Me.TimeDataGridViewTextBoxColumn.DataPropertyName = "Time"
        Me.TimeDataGridViewTextBoxColumn.HeaderText = "Time"
        Me.TimeDataGridViewTextBoxColumn.Name = "TimeDataGridViewTextBoxColumn"
        '
        'RoomDataGridViewTextBoxColumn
        '
        Me.RoomDataGridViewTextBoxColumn.DataPropertyName = "Room"
        Me.RoomDataGridViewTextBoxColumn.HeaderText = "Room"
        Me.RoomDataGridViewTextBoxColumn.Name = "RoomDataGridViewTextBoxColumn"
        '
        'SlotDataGridViewTextBoxColumn
        '
        Me.SlotDataGridViewTextBoxColumn.DataPropertyName = "Slot"
        Me.SlotDataGridViewTextBoxColumn.HeaderText = "Slot"
        Me.SlotDataGridViewTextBoxColumn.Name = "SlotDataGridViewTextBoxColumn"
        '
        'ClassDataGridViewTextBoxColumn
        '
        Me.ClassDataGridViewTextBoxColumn.DataPropertyName = "Class"
        Me.ClassDataGridViewTextBoxColumn.HeaderText = "Class"
        Me.ClassDataGridViewTextBoxColumn.Name = "ClassDataGridViewTextBoxColumn"
        '
        'IDNumberDataGridViewTextBoxColumn
        '
        Me.IDNumberDataGridViewTextBoxColumn.DataPropertyName = "IDNumber"
        Me.IDNumberDataGridViewTextBoxColumn.HeaderText = "IDNumber"
        Me.IDNumberDataGridViewTextBoxColumn.Name = "IDNumberDataGridViewTextBoxColumn"
        '
        'frmSearchSemSubjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 332)
        Me.Controls.Add(Me.frmID)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSearchSemSubjects"
        Me.Text = "Search Subjects for the Current Semester"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgsubjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SemsubjectsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgsubjects As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents frmID As System.Windows.Forms.Label
    Friend WithEvents DataSet As Enrollment.DataSet
    Friend WithEvents SemsubjectsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SemsubjectsTableAdapter As Enrollment.DataSetTableAdapters.semsubjectsTableAdapter
    Friend WithEvents SemsubjectsIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubjectCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LecUnitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LabUnitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SectionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DayDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SlotDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClassDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
