<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccelerated
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
        Me.dtpDP = New System.Windows.Forms.DateTimePicker
        Me.txtS = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.txtPT = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'dtpDP
        '
        Me.dtpDP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDP.Location = New System.Drawing.Point(140, 93)
        Me.dtpDP.Name = "dtpDP"
        Me.dtpDP.Size = New System.Drawing.Size(122, 26)
        Me.dtpDP.TabIndex = 3
        '
        'txtS
        '
        Me.txtS.Location = New System.Drawing.Point(140, 61)
        Me.txtS.Name = "txtS"
        Me.txtS.Size = New System.Drawing.Size(397, 26)
        Me.txtS.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 19)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Processed Date "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Section"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(140, 145)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(122, 38)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtPT
        '
        Me.txtPT.Location = New System.Drawing.Point(140, 29)
        Me.txtPT.Name = "txtPT"
        Me.txtPT.Size = New System.Drawing.Size(397, 26)
        Me.txtPT.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 19)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Promoted to "
        '
        'frmAccelerated
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(556, 224)
        Me.Controls.Add(Me.dtpDP)
        Me.Controls.Add(Me.txtS)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtPT)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAccelerated"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accelerated"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpDP As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtS As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtPT As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
