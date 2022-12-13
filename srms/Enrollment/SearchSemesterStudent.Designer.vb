<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchSemesterStudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchSemesterStudent))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cboSearch = New System.Windows.Forms.ComboBox
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgsemstudent = New System.Windows.Forms.DataGridView
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgsemstudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboSearch)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 183)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(572, 74)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cboSearch
        '
        Me.cboSearch.FormattingEnabled = True
        Me.cboSearch.Items.AddRange(New Object() {"by Student Number", "by Lastname"})
        Me.cboSearch.Location = New System.Drawing.Point(285, 27)
        Me.cboSearch.Name = "cboSearch"
        Me.cboSearch.Size = New System.Drawing.Size(157, 24)
        Me.cboSearch.TabIndex = 3
        Me.cboSearch.Text = "Search Category"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(76, 27)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(203, 23)
        Me.txtSearch.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search"
        '
        'dgsemstudent
        '
        Me.dgsemstudent.AllowUserToAddRows = False
        Me.dgsemstudent.AllowUserToDeleteRows = False
        Me.dgsemstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgsemstudent.Location = New System.Drawing.Point(18, 12)
        Me.dgsemstudent.Name = "dgsemstudent"
        Me.dgsemstudent.Size = New System.Drawing.Size(560, 165)
        Me.dgsemstudent.TabIndex = 0
        '
        'frmSearchSemesterStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 282)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgsemstudent)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSearchSemesterStudent"
        Me.Text = "Search Semester Student"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgsemstudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgsemstudent As System.Windows.Forms.DataGridView
    Friend WithEvents cboSearch As System.Windows.Forms.ComboBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataSet As Enrollment.DataSet
    Friend WithEvents SemesterstudentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SemesterstudentTableAdapter As Enrollment.DataSetTableAdapters.semesterstudeTableAdapter
End Class
