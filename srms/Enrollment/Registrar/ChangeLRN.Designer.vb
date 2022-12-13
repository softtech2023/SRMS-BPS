<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangeLRN
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
        Me.txtLRN = New System.Windows.Forms.TextBox
        Me.btnChange = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "New LRN"
        '
        'txtLRN
        '
        Me.txtLRN.Location = New System.Drawing.Point(95, 53)
        Me.txtLRN.Name = "txtLRN"
        Me.txtLRN.Size = New System.Drawing.Size(281, 26)
        Me.txtLRN.TabIndex = 1
        '
        'btnChange
        '
        Me.btnChange.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnChange.Location = New System.Drawing.Point(271, 95)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(105, 36)
        Me.btnChange.TabIndex = 2
        Me.btnChange.Text = "Change"
        Me.btnChange.UseVisualStyleBackColor = False
        '
        'frmChangeLRN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(398, 168)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.txtLRN)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChangeLRN"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change LRN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLRN As System.Windows.Forms.TextBox
    Friend WithEvents btnChange As System.Windows.Forms.Button
End Class
