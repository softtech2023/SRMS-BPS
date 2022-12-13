<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmByDescription
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboDescription = New System.Windows.Forms.ComboBox
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker
        Me.dtpTo = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnPreview = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "By Description"
        '
        'cboDescription
        '
        Me.cboDescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboDescription.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDescription.FormattingEnabled = True
        Me.cboDescription.Location = New System.Drawing.Point(137, 46)
        Me.cboDescription.Name = "cboDescription"
        Me.cboDescription.Size = New System.Drawing.Size(305, 27)
        Me.cboDescription.TabIndex = 1
        '
        'dtpFrom
        '
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrom.Location = New System.Drawing.Point(137, 79)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(130, 26)
        Me.dtpFrom.TabIndex = 2
        '
        'dtpTo
        '
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTo.Location = New System.Drawing.Point(312, 79)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(130, 26)
        Me.dtpTo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Collection Date"
        '
        'btnPreview
        '
        Me.btnPreview.Location = New System.Drawing.Point(312, 121)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(130, 33)
        Me.btnPreview.TabIndex = 5
        Me.btnPreview.Text = "&Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(287, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "-"
        '
        'frmByDescription
        '
        Me.AcceptButton = Me.btnPreview
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(487, 196)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpTo)
        Me.Controls.Add(Me.dtpFrom)
        Me.Controls.Add(Me.cboDescription)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmByDescription"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "By Description (All)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboDescription As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
