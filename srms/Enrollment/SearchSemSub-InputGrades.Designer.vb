<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchSemSub_InputGrades
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
        Me.dg1 = New System.Windows.Forms.DataGridView
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
        Me.SemsubjectsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Enrollment.DataSet
        Me.SemsubjectsTableAdapter = New Enrollment.DataSetTableAdapters.semsubjectsTableAdapter
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SemsubjectsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dg1
        '
        Me.dg1.AllowUserToAddRows = False
        Me.dg1.AllowUserToDeleteRows = False
        Me.dg1.AllowUserToOrderColumns = True
        Me.dg1.AutoGenerateColumns = False
        Me.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SemsubjectsIDDataGridViewTextBoxColumn, Me.SubjectCodeDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.LecUnitDataGridViewTextBoxColumn, Me.LabUnitDataGridViewTextBoxColumn, Me.SectionDataGridViewTextBoxColumn, Me.DayDataGridViewTextBoxColumn, Me.TimeDataGridViewTextBoxColumn, Me.RoomDataGridViewTextBoxColumn, Me.SlotDataGridViewTextBoxColumn, Me.ClassDataGridViewTextBoxColumn, Me.IDNumberDataGridViewTextBoxColumn})
        Me.dg1.DataSource = Me.SemsubjectsBindingSource
        Me.dg1.Location = New System.Drawing.Point(12, 87)
        Me.dg1.Name = "dg1"
        Me.dg1.Size = New System.Drawing.Size(488, 213)
        Me.dg1.TabIndex = 0
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
        'SemsubjectsBindingSource
        '
        Me.SemsubjectsBindingSource.DataMember = "semsubjects"
        Me.SemsubjectsBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SemsubjectsTableAdapter
        '
        Me.SemsubjectsTableAdapter.ClearBeforeFill = True
        '
        'frmSearchSemSub_InputGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 312)
        Me.Controls.Add(Me.dg1)
        Me.Name = "frmSearchSemSub_InputGrades"
        Me.Text = "Search Semester Subjects"
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SemsubjectsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dg1 As System.Windows.Forms.DataGridView
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
