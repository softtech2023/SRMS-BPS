<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMRDashboard
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
        Me.btnFind = New System.Windows.Forms.Button
        Me.txtAccountable = New System.Windows.Forms.TextBox
        Me.lblAccountableName = New System.Windows.Forms.Label
        Me.lblAcquireDate = New System.Windows.Forms.Label
        Me.btnPreview = New System.Windows.Forms.Button
        Me.lblIDNumber = New System.Windows.Forms.Label
        Me.cboAcquiredate = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(351, 33)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(52, 26)
        Me.btnFind.TabIndex = 41
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'txtAccountable
        '
        Me.txtAccountable.Location = New System.Drawing.Point(108, 33)
        Me.txtAccountable.Name = "txtAccountable"
        Me.txtAccountable.ReadOnly = True
        Me.txtAccountable.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtAccountable.Size = New System.Drawing.Size(236, 26)
        Me.txtAccountable.TabIndex = 39
        '
        'lblAccountableName
        '
        Me.lblAccountableName.AutoSize = True
        Me.lblAccountableName.Location = New System.Drawing.Point(12, 36)
        Me.lblAccountableName.Name = "lblAccountableName"
        Me.lblAccountableName.Size = New System.Drawing.Size(78, 19)
        Me.lblAccountableName.TabIndex = 40
        Me.lblAccountableName.Text = "Accountable"
        '
        'lblAcquireDate
        '
        Me.lblAcquireDate.AutoSize = True
        Me.lblAcquireDate.Location = New System.Drawing.Point(12, 69)
        Me.lblAcquireDate.Name = "lblAcquireDate"
        Me.lblAcquireDate.Size = New System.Drawing.Size(90, 19)
        Me.lblAcquireDate.TabIndex = 43
        Me.lblAcquireDate.Text = "Acquired Date"
        '
        'btnPreview
        '
        Me.btnPreview.Location = New System.Drawing.Point(305, 65)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(98, 26)
        Me.btnPreview.TabIndex = 44
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'lblIDNumber
        '
        Me.lblIDNumber.AutoSize = True
        Me.lblIDNumber.Location = New System.Drawing.Point(12, 9)
        Me.lblIDNumber.Name = "lblIDNumber"
        Me.lblIDNumber.Size = New System.Drawing.Size(69, 19)
        Me.lblIDNumber.TabIndex = 45
        Me.lblIDNumber.Text = "IDNumber"
        Me.lblIDNumber.Visible = False
        '
        'cboAcquiredate
        '
        Me.cboAcquiredate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAcquiredate.FormattingEnabled = True
        Me.cboAcquiredate.Location = New System.Drawing.Point(108, 63)
        Me.cboAcquiredate.Name = "cboAcquiredate"
        Me.cboAcquiredate.Size = New System.Drawing.Size(191, 27)
        Me.cboAcquiredate.TabIndex = 46
        '
        'frmMRDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(424, 127)
        Me.Controls.Add(Me.cboAcquiredate)
        Me.Controls.Add(Me.lblIDNumber)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.lblAcquireDate)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.txtAccountable)
        Me.Controls.Add(Me.lblAccountableName)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMRDashboard"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PAR Dashboard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents txtAccountable As System.Windows.Forms.TextBox
    Friend WithEvents lblAccountableName As System.Windows.Forms.Label
    Friend WithEvents lblAcquireDate As System.Windows.Forms.Label
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents lblIDNumber As System.Windows.Forms.Label
    Friend WithEvents cboAcquiredate As System.Windows.Forms.ComboBox
End Class
