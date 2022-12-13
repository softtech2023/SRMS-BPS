<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatSummary
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
        Me.cboOptions = New System.Windows.Forms.ComboBox
        Me.lblTitle = New System.Windows.Forms.Label
        Me.cboGradeLevel = New System.Windows.Forms.ComboBox
        Me.cboSection = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.ReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.btnClose = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.cboSection)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cboGradeLevel)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cboOptions)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(0, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(878, 34)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Option"
        '
        'cboOptions
        '
        Me.cboOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOptions.FormattingEnabled = True
        Me.cboOptions.Items.AddRange(New Object() {"4Ps", "Balik-aral", "IP", "Repeater", "Transferee"})
        Me.cboOptions.Location = New System.Drawing.Point(64, 3)
        Me.cboOptions.Name = "cboOptions"
        Me.cboOptions.Size = New System.Drawing.Size(190, 27)
        Me.cboOptions.Sorted = True
        Me.cboOptions.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe Condensed", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(0, 24)
        Me.lblTitle.TabIndex = 2
        '
        'cboGradeLevel
        '
        Me.cboGradeLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGradeLevel.FormattingEnabled = True
        Me.cboGradeLevel.Location = New System.Drawing.Point(342, 3)
        Me.cboGradeLevel.Name = "cboGradeLevel"
        Me.cboGradeLevel.Size = New System.Drawing.Size(84, 27)
        Me.cboGradeLevel.TabIndex = 5
        '
        'cboSection
        '
        Me.cboSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSection.FormattingEnabled = True
        Me.cboSection.Location = New System.Drawing.Point(493, 3)
        Me.cboSection.Name = "cboSection"
        Me.cboSection.Size = New System.Drawing.Size(216, 27)
        Me.cboSection.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(437, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Section"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(260, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Grade Level"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(715, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 32)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "&View"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ReportViewer
        '
        Me.ReportViewer.ActiveViewIndex = -1
        Me.ReportViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReportViewer.DisplayGroupTree = False
        Me.ReportViewer.Location = New System.Drawing.Point(0, 46)
        Me.ReportViewer.Name = "ReportViewer"
        Me.ReportViewer.Size = New System.Drawing.Size(878, 457)
        Me.ReportViewer.TabIndex = 5
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(794, 1)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(73, 32)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmStatSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(879, 504)
        Me.Controls.Add(Me.ReportViewer)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmStatSummary"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Statistics Summary"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboOptions As System.Windows.Forms.ComboBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboSection As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cboGradeLevel As System.Windows.Forms.ComboBox
    Friend WithEvents ReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
