<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDroppingFOrm
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
        Me.txtReason = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpProcessedDate = New System.Windows.Forms.DateTimePicker
        Me.btnSave = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtReason
        '
        Me.txtReason.Location = New System.Drawing.Point(145, 48)
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(397, 26)
        Me.txtReason.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Reason"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Processed Date"
        '
        'dtpProcessedDate
        '
        Me.dtpProcessedDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpProcessedDate.Location = New System.Drawing.Point(145, 85)
        Me.dtpProcessedDate.Name = "dtpProcessedDate"
        Me.dtpProcessedDate.Size = New System.Drawing.Size(122, 26)
        Me.dtpProcessedDate.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(145, 131)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(122, 38)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmDroppingFOrm
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(556, 224)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dtpProcessedDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtReason)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDroppingFOrm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dropping Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtReason As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpProcessedDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
