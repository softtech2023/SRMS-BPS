<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCertification
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCertification))
        Me.btnStudeReport = New System.Windows.Forms.Button
        Me.mskStudentNumber = New System.Windows.Forms.MaskedTextBox
        Me.cboStudeReport = New System.Windows.Forms.ComboBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.specialReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblDepartment = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.MaskedTextBox
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
        Me.btnStudeReport.Location = New System.Drawing.Point(604, 0)
        Me.btnStudeReport.Name = "btnStudeReport"
        Me.btnStudeReport.Size = New System.Drawing.Size(88, 28)
        Me.btnStudeReport.TabIndex = 3
        Me.btnStudeReport.Text = "&Preview"
        Me.btnStudeReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStudeReport.UseVisualStyleBackColor = False
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
        'cboStudeReport
        '
        Me.cboStudeReport.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboStudeReport.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboStudeReport.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStudeReport.ForeColor = System.Drawing.Color.Black
        Me.cboStudeReport.FormattingEnabled = True
        Me.cboStudeReport.Items.AddRange(New Object() {"Certificate of Enrollment", "Certificate of Enrollment (v2)", "Certificate of GMC", "Clearance", "Report of Grades", "Report Card", "Scholastic Record", "Student's Profile", "Registration Form"})
        Me.cboStudeReport.Location = New System.Drawing.Point(400, 1)
        Me.cboStudeReport.Name = "cboStudeReport"
        Me.cboStudeReport.Size = New System.Drawing.Size(198, 26)
        Me.cboStudeReport.TabIndex = 2
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(414, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(56, 19)
        Me.btnClose.TabIndex = 34
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(9, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student No."
        '
        'specialReportViewer
        '
        Me.specialReportViewer.ActiveViewIndex = -1
        Me.specialReportViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.specialReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.specialReportViewer.DisplayGroupTree = False
        Me.specialReportViewer.Location = New System.Drawing.Point(2, 43)
        Me.specialReportViewer.Name = "specialReportViewer"
        Me.specialReportViewer.SelectionFormula = ""
        Me.specialReportViewer.Size = New System.Drawing.Size(799, 403)
        Me.specialReportViewer.TabIndex = 5
        Me.specialReportViewer.TabStop = False
        Me.specialReportViewer.ViewTimeSelectionFormula = ""
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblDepartment)
        Me.Panel2.Controls.Add(Me.txtName)
        Me.Panel2.Controls.Add(Me.btnStudeReport)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.cboStudeReport)
        Me.Panel2.Controls.Add(Me.mskStudentNumber)
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(2, 12)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(799, 28)
        Me.Panel2.TabIndex = 0
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Location = New System.Drawing.Point(713, 7)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(77, 19)
        Me.lblDepartment.TabIndex = 36
        Me.lblDepartment.Text = "Department"
        Me.lblDepartment.Visible = False
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.Location = New System.Drawing.Point(194, 2)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(200, 25)
        Me.txtName.TabIndex = 35
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmCertification
        '
        Me.AcceptButton = Me.btnStudeReport
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(802, 451)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.specialReportViewer)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmCertification"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STUDENTS' REPORT"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnStudeReport As System.Windows.Forms.Button
    Friend WithEvents mskStudentNumber As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboStudeReport As System.Windows.Forms.ComboBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents specialReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtName As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblDepartment As System.Windows.Forms.Label
End Class
