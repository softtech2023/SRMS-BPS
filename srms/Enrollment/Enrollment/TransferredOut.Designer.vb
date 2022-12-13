<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransferredOut
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
        Me.txtSchoolName = New System.Windows.Forms.TextBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.txtSchoolAddress = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpProcessedDate = New System.Windows.Forms.DateTimePicker
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name of School"
        '
        'txtSchoolName
        '
        Me.txtSchoolName.Location = New System.Drawing.Point(140, 35)
        Me.txtSchoolName.Name = "txtSchoolName"
        Me.txtSchoolName.Size = New System.Drawing.Size(397, 26)
        Me.txtSchoolName.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(140, 163)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(122, 38)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtSchoolAddress
        '
        Me.txtSchoolAddress.Location = New System.Drawing.Point(140, 77)
        Me.txtSchoolAddress.Name = "txtSchoolAddress"
        Me.txtSchoolAddress.Size = New System.Drawing.Size(397, 26)
        Me.txtSchoolAddress.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "School Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Processed Date"
        '
        'dtpProcessedDate
        '
        Me.dtpProcessedDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpProcessedDate.Location = New System.Drawing.Point(140, 119)
        Me.dtpProcessedDate.Name = "dtpProcessedDate"
        Me.dtpProcessedDate.Size = New System.Drawing.Size(122, 26)
        Me.dtpProcessedDate.TabIndex = 3
        '
        'frmTransferredOut
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(556, 224)
        Me.Controls.Add(Me.dtpProcessedDate)
        Me.Controls.Add(Me.txtSchoolAddress)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtSchoolName)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTransferredOut"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transferred Out"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSchoolName As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtSchoolAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpProcessedDate As System.Windows.Forms.DateTimePicker
End Class
