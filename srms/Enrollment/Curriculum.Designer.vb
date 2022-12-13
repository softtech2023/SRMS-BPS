<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCurriculum
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCurriculum))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.mskDate = New System.Windows.Forms.MaskedTextBox
        Me.txtCurriculumName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dgcurr = New System.Windows.Forms.DataGridView
        Me.CurriculumIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CurriculumNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EffectivityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CurriculumBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Enrollment.DataSet
        Me.CurriculumTableAdapter = New Enrollment.DataSetTableAdapters.curriculumTableAdapter
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.lblID = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgcurr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurriculumBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mskDate)
        Me.GroupBox1.Controls.Add(Me.txtCurriculumName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(515, 110)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'mskDate
        '
        Me.mskDate.Location = New System.Drawing.Point(179, 70)
        Me.mskDate.Mask = "00/00/0000"
        Me.mskDate.Name = "mskDate"
        Me.mskDate.Size = New System.Drawing.Size(247, 29)
        Me.mskDate.TabIndex = 3
        Me.mskDate.ValidatingType = GetType(Date)
        '
        'txtCurriculumName
        '
        Me.txtCurriculumName.Location = New System.Drawing.Point(179, 25)
        Me.txtCurriculumName.Name = "txtCurriculumName"
        Me.txtCurriculumName.Size = New System.Drawing.Size(247, 29)
        Me.txtCurriculumName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Effectivity Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Curriculum Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgcurr)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 164)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(515, 150)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'dgcurr
        '
        Me.dgcurr.AllowUserToAddRows = False
        Me.dgcurr.AllowUserToDeleteRows = False
        Me.dgcurr.AutoGenerateColumns = False
        Me.dgcurr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgcurr.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CurriculumIDDataGridViewTextBoxColumn, Me.CurriculumNameDataGridViewTextBoxColumn, Me.EffectivityDataGridViewTextBoxColumn})
        Me.dgcurr.DataSource = Me.CurriculumBindingSource
        Me.dgcurr.Location = New System.Drawing.Point(8, 16)
        Me.dgcurr.Name = "dgcurr"
        Me.dgcurr.Size = New System.Drawing.Size(499, 125)
        Me.dgcurr.TabIndex = 0
        '
        'CurriculumIDDataGridViewTextBoxColumn
        '
        Me.CurriculumIDDataGridViewTextBoxColumn.DataPropertyName = "curriculumID"
        Me.CurriculumIDDataGridViewTextBoxColumn.HeaderText = "curriculumID"
        Me.CurriculumIDDataGridViewTextBoxColumn.Name = "CurriculumIDDataGridViewTextBoxColumn"
        Me.CurriculumIDDataGridViewTextBoxColumn.Visible = False
        '
        'CurriculumNameDataGridViewTextBoxColumn
        '
        Me.CurriculumNameDataGridViewTextBoxColumn.DataPropertyName = "CurriculumName"
        Me.CurriculumNameDataGridViewTextBoxColumn.HeaderText = "Curriculum Name"
        Me.CurriculumNameDataGridViewTextBoxColumn.Name = "CurriculumNameDataGridViewTextBoxColumn"
        Me.CurriculumNameDataGridViewTextBoxColumn.Width = 300
        '
        'EffectivityDataGridViewTextBoxColumn
        '
        Me.EffectivityDataGridViewTextBoxColumn.DataPropertyName = "Effectivity"
        Me.EffectivityDataGridViewTextBoxColumn.HeaderText = "Effectivity"
        Me.EffectivityDataGridViewTextBoxColumn.Name = "EffectivityDataGridViewTextBoxColumn"
        Me.EffectivityDataGridViewTextBoxColumn.Width = 150
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
        'CurriculumTableAdapter
        '
        Me.CurriculumTableAdapter.ClearBeforeFill = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnSave)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(146, 53)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(8, 11)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(39, 37)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Tag = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(98, 11)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(39, 37)
        Me.Button2.TabIndex = 17
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(53, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 37)
        Me.Button1.TabIndex = 16
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(309, 21)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(37, 13)
        Me.lblID.TabIndex = 20
        Me.lblID.Text = "CurrID"
        Me.lblID.Visible = False
        '
        'frmCurriculum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 326)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCurriculum"
        Me.Text = "Curriculum"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgcurr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurriculumBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCurriculumName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mskDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgcurr As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet As Enrollment.DataSet
    Friend WithEvents CurriculumBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CurriculumTableAdapter As Enrollment.DataSetTableAdapters.curriculumTableAdapter
    Friend WithEvents CurriculumIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurriculumNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EffectivityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblID As System.Windows.Forms.Label
End Class
