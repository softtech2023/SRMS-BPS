<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhysicalCount
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
        Me.lblIDNumber = New System.Windows.Forms.Label
        Me.btnPreview = New System.Windows.Forms.Button
        Me.dtpAcquireDate = New System.Windows.Forms.DateTimePicker
        Me.lblAcquireDate = New System.Windows.Forms.Label
        Me.btnFind = New System.Windows.Forms.Button
        Me.txtAccountable = New System.Windows.Forms.TextBox
        Me.lblAccountableName = New System.Windows.Forms.Label
        Me.cboCategory = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblIDNumber
        '
        Me.lblIDNumber.AutoSize = True
        Me.lblIDNumber.Location = New System.Drawing.Point(169, 18)
        Me.lblIDNumber.Name = "lblIDNumber"
        Me.lblIDNumber.Size = New System.Drawing.Size(69, 19)
        Me.lblIDNumber.TabIndex = 52
        Me.lblIDNumber.Text = "IDNumber"
        Me.lblIDNumber.Visible = False
        '
        'btnPreview
        '
        Me.btnPreview.Location = New System.Drawing.Point(299, 148)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(98, 32)
        Me.btnPreview.TabIndex = 51
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'dtpAcquireDate
        '
        Me.dtpAcquireDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAcquireDate.Location = New System.Drawing.Point(121, 74)
        Me.dtpAcquireDate.Name = "dtpAcquireDate"
        Me.dtpAcquireDate.Size = New System.Drawing.Size(276, 26)
        Me.dtpAcquireDate.TabIndex = 49
        '
        'lblAcquireDate
        '
        Me.lblAcquireDate.AutoSize = True
        Me.lblAcquireDate.Location = New System.Drawing.Point(22, 80)
        Me.lblAcquireDate.Name = "lblAcquireDate"
        Me.lblAcquireDate.Size = New System.Drawing.Size(93, 19)
        Me.lblAcquireDate.TabIndex = 50
        Me.lblAcquireDate.Text = "Inventory Date"
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(345, 42)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(52, 26)
        Me.btnFind.TabIndex = 48
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        Me.btnFind.Visible = False
        '
        'txtAccountable
        '
        Me.txtAccountable.Location = New System.Drawing.Point(121, 42)
        Me.txtAccountable.Name = "txtAccountable"
        Me.txtAccountable.ReadOnly = True
        Me.txtAccountable.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtAccountable.Size = New System.Drawing.Size(217, 26)
        Me.txtAccountable.TabIndex = 46
        Me.txtAccountable.Visible = False
        '
        'lblAccountableName
        '
        Me.lblAccountableName.AutoSize = True
        Me.lblAccountableName.Location = New System.Drawing.Point(37, 46)
        Me.lblAccountableName.Name = "lblAccountableName"
        Me.lblAccountableName.Size = New System.Drawing.Size(78, 19)
        Me.lblAccountableName.TabIndex = 47
        Me.lblAccountableName.Text = "Accountable"
        Me.lblAccountableName.Visible = False
        '
        'cboCategory
        '
        Me.cboCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Items.AddRange(New Object() {"Furniture, Fixtures and Books", "Machinery and Equipment", "Transportation Equipment"})
        Me.cboCategory.Location = New System.Drawing.Point(121, 106)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(276, 27)
        Me.cboCategory.Sorted = True
        Me.cboCategory.TabIndex = 53
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(55, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 19)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Category"
        '
        'frmPhysicalCount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(424, 192)
        Me.Controls.Add(Me.cboCategory)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblIDNumber)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.dtpAcquireDate)
        Me.Controls.Add(Me.lblAcquireDate)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.txtAccountable)
        Me.Controls.Add(Me.lblAccountableName)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPhysicalCount"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Physical Count"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIDNumber As System.Windows.Forms.Label
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents dtpAcquireDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblAcquireDate As System.Windows.Forms.Label
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents txtAccountable As System.Windows.Forms.TextBox
    Friend WithEvents lblAccountableName As System.Windows.Forms.Label
    Friend WithEvents cboCategory As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
