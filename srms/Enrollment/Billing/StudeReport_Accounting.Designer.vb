<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudeReport_Accounting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudeReport_Accounting))
        Me.btnStudeReport = New System.Windows.Forms.Button
        Me.specialReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboStudeReport = New System.Windows.Forms.ComboBox
        Me.mskStudentNumber = New System.Windows.Forms.MaskedTextBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStudeReport
        '
        Me.btnStudeReport.BackColor = System.Drawing.Color.Transparent
        Me.btnStudeReport.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudeReport.ForeColor = System.Drawing.Color.Black
        Me.btnStudeReport.Image = CType(resources.GetObject("btnStudeReport.Image"), System.Drawing.Image)
        Me.btnStudeReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStudeReport.Location = New System.Drawing.Point(399, 0)
        Me.btnStudeReport.Name = "btnStudeReport"
        Me.btnStudeReport.Size = New System.Drawing.Size(88, 28)
        Me.btnStudeReport.TabIndex = 3
        Me.btnStudeReport.Text = "&Preview"
        Me.btnStudeReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStudeReport.UseVisualStyleBackColor = False
        '
        'specialReportViewer
        '
        Me.specialReportViewer.ActiveViewIndex = -1
        Me.specialReportViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.specialReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.specialReportViewer.DisplayGroupTree = False
        Me.specialReportViewer.Location = New System.Drawing.Point(2, 40)
        Me.specialReportViewer.Name = "specialReportViewer"
        Me.specialReportViewer.SelectionFormula = ""
        Me.specialReportViewer.Size = New System.Drawing.Size(697, 372)
        Me.specialReportViewer.TabIndex = 7
        Me.specialReportViewer.TabStop = False
        Me.specialReportViewer.ViewTimeSelectionFormula = ""
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnStudeReport)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.cboStudeReport)
        Me.Panel2.Controls.Add(Me.mskStudentNumber)
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(2, 9)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(697, 28)
        Me.Panel2.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(9, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student No."
        '
        'cboStudeReport
        '
        Me.cboStudeReport.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboStudeReport.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboStudeReport.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStudeReport.ForeColor = System.Drawing.Color.Black
        Me.cboStudeReport.FormattingEnabled = True
        Me.cboStudeReport.Items.AddRange(New Object() {"Account Tracking", "Ledger (Student's Accounts)", "Ledger (Other Fees and Services)", "Statement of Accounts", "Statement of Accounts V2"})
        Me.cboStudeReport.Location = New System.Drawing.Point(195, 2)
        Me.cboStudeReport.Name = "cboStudeReport"
        Me.cboStudeReport.Size = New System.Drawing.Size(198, 26)
        Me.cboStudeReport.TabIndex = 2
        '
        'mskStudentNumber
        '
        Me.mskStudentNumber.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskStudentNumber.ForeColor = System.Drawing.Color.Black
        Me.mskStudentNumber.Location = New System.Drawing.Point(90, 2)
        Me.mskStudentNumber.Name = "mskStudentNumber"
        Me.mskStudentNumber.ReadOnly = True
        Me.mskStudentNumber.Size = New System.Drawing.Size(99, 25)
        Me.mskStudentNumber.TabIndex = 1
        Me.mskStudentNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(330, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(56, 19)
        Me.btnClose.TabIndex = 34
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmStudeReport_Accounting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 420)
        Me.Controls.Add(Me.specialReportViewer)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmStudeReport_Accounting"
        Me.ShowIcon = False
        Me.Text = "Student Report - Accounting"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnStudeReport As System.Windows.Forms.Button
    Friend WithEvents specialReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboStudeReport As System.Windows.Forms.ComboBox
    Friend WithEvents mskStudentNumber As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
