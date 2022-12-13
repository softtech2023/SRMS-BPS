<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgesReport
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnView = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboGradeLevel = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtAge = New System.Windows.Forms.TextBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.ReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboSection
        '
        Me.cboSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSection.FormattingEnabled = True
        Me.cboSection.Location = New System.Drawing.Point(423, 3)
        Me.cboSection.Name = "cboSection"
        Me.cboSection.Size = New System.Drawing.Size(230, 27)
        Me.cboSection.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(367, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Section"
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(659, 1)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(82, 32)
        Me.btnView.TabIndex = 9
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(182, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Grade Level"
        '
        'cboGradeLevel
        '
        Me.cboGradeLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGradeLevel.FormattingEnabled = True
        Me.cboGradeLevel.Location = New System.Drawing.Point(265, 3)
        Me.cboGradeLevel.Name = "cboGradeLevel"
        Me.cboGradeLevel.Size = New System.Drawing.Size(88, 27)
        Me.cboGradeLevel.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Age"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnView)
        Me.Panel1.Controls.Add(Me.cboGradeLevel)
        Me.Panel1.Controls.Add(Me.txtAge)
        Me.Panel1.Controls.Add(Me.cboSection)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(1, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(878, 34)
        Me.Panel1.TabIndex = 5
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(89, 4)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(76, 26)
        Me.txtAge.TabIndex = 2
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(747, 1)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(82, 32)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'ReportViewer
        '
        Me.ReportViewer.ActiveViewIndex = -1
        Me.ReportViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReportViewer.DisplayGroupTree = False
        Me.ReportViewer.Location = New System.Drawing.Point(1, 41)
        Me.ReportViewer.Name = "ReportViewer"
        Me.ReportViewer.SelectionFormula = ""
        Me.ReportViewer.Size = New System.Drawing.Size(878, 460)
        Me.ReportViewer.TabIndex = 6
        Me.ReportViewer.ViewTimeSelectionFormula = ""
        '
        'frmAgesReport
        '
        Me.AcceptButton = Me.btnView
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(879, 504)
        Me.Controls.Add(Me.ReportViewer)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmAgesReport"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ages Report"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboSection As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents cboGradeLevel As System.Windows.Forms.ComboBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents ReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
