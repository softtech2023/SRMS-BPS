<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmbycat
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
        Me.btnPreview = New System.Windows.Forms.Button
        Me.cboAuthor = New System.Windows.Forms.ComboBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Category"
        '
        'btnPreview
        '
        Me.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPreview.Location = New System.Drawing.Point(173, 48)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(65, 30)
        Me.btnPreview.TabIndex = 5
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'cboAuthor
        '
        Me.cboAuthor.FormattingEnabled = True
        Me.cboAuthor.Location = New System.Drawing.Point(68, 13)
        Me.cboAuthor.Name = "cboAuthor"
        Me.cboAuthor.Size = New System.Drawing.Size(186, 27)
        Me.cboAuthor.TabIndex = 4
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(148, 17)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(65, 16)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Preview"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmbycat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(266, 91)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.cboAuthor)
        Me.Controls.Add(Me.btnClose)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmbycat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents cboAuthor As System.Windows.Forms.ComboBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
