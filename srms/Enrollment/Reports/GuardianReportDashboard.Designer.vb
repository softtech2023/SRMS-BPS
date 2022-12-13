<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGuardianReportDashboard
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
        Me.cboSection = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboCourse = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cboYear = New System.Windows.Forms.ComboBox
        Me.btnPreview = New System.Windows.Forms.Button
        Me.btnAll = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cboSection
        '
        Me.cboSection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSection.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSection.FormattingEnabled = True
        Me.cboSection.Location = New System.Drawing.Point(175, 143)
        Me.cboSection.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboSection.Name = "cboSection"
        Me.cboSection.Size = New System.Drawing.Size(233, 27)
        Me.cboSection.TabIndex = 13
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(119, 146)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(50, 19)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Section"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(92, 72)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Department"
        '
        'cboCourse
        '
        Me.cboCourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboCourse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCourse.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCourse.ForeColor = System.Drawing.Color.Black
        Me.cboCourse.FormattingEnabled = True
        Me.cboCourse.Location = New System.Drawing.Point(175, 69)
        Me.cboCourse.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboCourse.Name = "cboCourse"
        Me.cboCourse.Size = New System.Drawing.Size(233, 27)
        Me.cboCourse.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(92, 109)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Grade Level"
        '
        'cboYear
        '
        Me.cboYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYear.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYear.ForeColor = System.Drawing.Color.Black
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Location = New System.Drawing.Point(175, 106)
        Me.cboYear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(233, 27)
        Me.cboYear.TabIndex = 12
        '
        'btnPreview
        '
        Me.btnPreview.Location = New System.Drawing.Point(204, 178)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(99, 32)
        Me.btnPreview.TabIndex = 14
        Me.btnPreview.Text = "By Section"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'btnAll
        '
        Me.btnAll.Location = New System.Drawing.Point(309, 178)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(99, 32)
        Me.btnAll.TabIndex = 15
        Me.btnAll.Text = "All"
        Me.btnAll.UseVisualStyleBackColor = True
        '
        'frmGuardianReportDashboard
        '
        Me.AcceptButton = Me.btnPreview
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 260)
        Me.Controls.Add(Me.btnAll)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.cboSection)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboYear)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboCourse)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGuardianReportDashboard"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ":: Guardian Masterlist"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboSection As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboCourse As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboYear As System.Windows.Forms.ComboBox
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents btnAll As System.Windows.Forms.Button
End Class
