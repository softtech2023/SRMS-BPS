<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClassListByGradeLevel
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnPreview = New System.Windows.Forms.Button
        Me.cboGradeLevel = New System.Windows.Forms.ComboBox
        Me.cboSection = New System.Windows.Forms.ComboBox
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(633, 58)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(202, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CLASS LIST BY GRADE LEVEL"
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(544, 151)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(50, 19)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Button1"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "GRADE LEVEL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "SECTION"
        '
        'btnPreview
        '
        Me.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreview.Location = New System.Drawing.Point(474, 181)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(130, 32)
        Me.btnPreview.TabIndex = 7
        Me.btnPreview.Text = "PREVIEW"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'cboGradeLevel
        '
        Me.cboGradeLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGradeLevel.FormattingEnabled = True
        Me.cboGradeLevel.Location = New System.Drawing.Point(110, 123)
        Me.cboGradeLevel.Name = "cboGradeLevel"
        Me.cboGradeLevel.Size = New System.Drawing.Size(209, 23)
        Me.cboGradeLevel.TabIndex = 8
        '
        'cboSection
        '
        Me.cboSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSection.FormattingEnabled = True
        Me.cboSection.Location = New System.Drawing.Point(110, 152)
        Me.cboSection.Name = "cboSection"
        Me.cboSection.Size = New System.Drawing.Size(494, 23)
        Me.cboSection.TabIndex = 9
        '
        'frmClassListByGradeLevel
        '
        Me.AcceptButton = Me.btnPreview
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(633, 274)
        Me.Controls.Add(Me.cboSection)
        Me.Controls.Add(Me.cboGradeLevel)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmClassListByGradeLevel"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "::"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents cboGradeLevel As System.Windows.Forms.ComboBox
    Friend WithEvents cboSection As System.Windows.Forms.ComboBox
End Class
