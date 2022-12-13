<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditSemStudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditSemStudent))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cboSearch = New System.Windows.Forms.ComboBox
        Me.dgsemstudent = New System.Windows.Forms.DataGridView
        Me.SemstudentidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StudentNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CourseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SemesterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Semesterstude1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Enrollment.DataSet
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Semesterstude1TableAdapter = New Enrollment.DataSetTableAdapters.semesterstude1TableAdapter
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgsemstudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Semesterstude1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboSearch)
        Me.GroupBox1.Controls.Add(Me.dgsemstudent)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(572, 241)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'cboSearch
        '
        Me.cboSearch.FormattingEnabled = True
        Me.cboSearch.Items.AddRange(New Object() {"by Student Number", "by Lastname"})
        Me.cboSearch.Location = New System.Drawing.Point(274, 27)
        Me.cboSearch.Name = "cboSearch"
        Me.cboSearch.Size = New System.Drawing.Size(157, 24)
        Me.cboSearch.TabIndex = 3
        Me.cboSearch.Text = "Search Category"
        '
        'dgsemstudent
        '
        Me.dgsemstudent.AllowUserToAddRows = False
        Me.dgsemstudent.AllowUserToDeleteRows = False
        Me.dgsemstudent.AutoGenerateColumns = False
        Me.dgsemstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgsemstudent.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SemstudentidDataGridViewTextBoxColumn, Me.StudentNumberDataGridViewTextBoxColumn, Me.FNameDataGridViewTextBoxColumn, Me.MNameDataGridViewTextBoxColumn, Me.LNameDataGridViewTextBoxColumn, Me.CourseDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.SemesterDataGridViewTextBoxColumn, Me.SYDataGridViewTextBoxColumn})
        Me.dgsemstudent.DataSource = Me.Semesterstude1BindingSource
        Me.dgsemstudent.Location = New System.Drawing.Point(6, 57)
        Me.dgsemstudent.Name = "dgsemstudent"
        Me.dgsemstudent.Size = New System.Drawing.Size(560, 171)
        Me.dgsemstudent.TabIndex = 0
        '
        'SemstudentidDataGridViewTextBoxColumn
        '
        Me.SemstudentidDataGridViewTextBoxColumn.DataPropertyName = "semstudentid"
        Me.SemstudentidDataGridViewTextBoxColumn.HeaderText = "semstudentid"
        Me.SemstudentidDataGridViewTextBoxColumn.Name = "SemstudentidDataGridViewTextBoxColumn"
        Me.SemstudentidDataGridViewTextBoxColumn.Visible = False
        '
        'StudentNumberDataGridViewTextBoxColumn
        '
        Me.StudentNumberDataGridViewTextBoxColumn.DataPropertyName = "StudentNumber"
        Me.StudentNumberDataGridViewTextBoxColumn.HeaderText = "StudentNumber"
        Me.StudentNumberDataGridViewTextBoxColumn.Name = "StudentNumberDataGridViewTextBoxColumn"
        '
        'FNameDataGridViewTextBoxColumn
        '
        Me.FNameDataGridViewTextBoxColumn.DataPropertyName = "FName"
        Me.FNameDataGridViewTextBoxColumn.HeaderText = "FName"
        Me.FNameDataGridViewTextBoxColumn.Name = "FNameDataGridViewTextBoxColumn"
        '
        'MNameDataGridViewTextBoxColumn
        '
        Me.MNameDataGridViewTextBoxColumn.DataPropertyName = "MName"
        Me.MNameDataGridViewTextBoxColumn.HeaderText = "MName"
        Me.MNameDataGridViewTextBoxColumn.Name = "MNameDataGridViewTextBoxColumn"
        '
        'LNameDataGridViewTextBoxColumn
        '
        Me.LNameDataGridViewTextBoxColumn.DataPropertyName = "LName"
        Me.LNameDataGridViewTextBoxColumn.HeaderText = "LName"
        Me.LNameDataGridViewTextBoxColumn.Name = "LNameDataGridViewTextBoxColumn"
        '
        'CourseDataGridViewTextBoxColumn
        '
        Me.CourseDataGridViewTextBoxColumn.DataPropertyName = "Course"
        Me.CourseDataGridViewTextBoxColumn.HeaderText = "Course"
        Me.CourseDataGridViewTextBoxColumn.Name = "CourseDataGridViewTextBoxColumn"
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        '
        'SemesterDataGridViewTextBoxColumn
        '
        Me.SemesterDataGridViewTextBoxColumn.DataPropertyName = "Semester"
        Me.SemesterDataGridViewTextBoxColumn.HeaderText = "Semester"
        Me.SemesterDataGridViewTextBoxColumn.Name = "SemesterDataGridViewTextBoxColumn"
        '
        'SYDataGridViewTextBoxColumn
        '
        Me.SYDataGridViewTextBoxColumn.DataPropertyName = "SY"
        Me.SYDataGridViewTextBoxColumn.HeaderText = "SY"
        Me.SYDataGridViewTextBoxColumn.Name = "SYDataGridViewTextBoxColumn"
        '
        'Semesterstude1BindingSource
        '
        Me.Semesterstude1BindingSource.DataMember = "semesterstude1"
        Me.Semesterstude1BindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(65, 28)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(203, 23)
        Me.txtSearch.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search"
        '
        'Semesterstude1TableAdapter
        '
        Me.Semesterstude1TableAdapter.ClearBeforeFill = True
        '
        'frmEditSemStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 257)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmEditSemStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Semester Student"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgsemstudent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Semesterstude1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboSearch As System.Windows.Forms.ComboBox
    Friend WithEvents dgsemstudent As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SemstudentidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudentNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CourseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SemesterDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SYDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataSet As Enrollment.DataSet
    Friend WithEvents Semesterstude1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Semesterstude1TableAdapter As Enrollment.DataSetTableAdapters.semesterstude1TableAdapter
End Class
