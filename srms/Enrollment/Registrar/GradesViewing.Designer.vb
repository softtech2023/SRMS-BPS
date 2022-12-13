<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGradesViewing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGradesViewing))
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.mskStudentNumber = New System.Windows.Forms.MaskedTextBox
        Me.btnStudeReport = New System.Windows.Forms.Button
        Me.btnReset = New System.Windows.Forms.Button
        Me.specialReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.mskStudentNumber)
        Me.Panel2.Controls.Add(Me.btnStudeReport)
        Me.Panel2.Controls.Add(Me.btnReset)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(2, 6)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(799, 42)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(9, 8)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student No."
        '
        'mskStudentNumber
        '
        Me.mskStudentNumber.Font = New System.Drawing.Font("Segoe Condensed", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskStudentNumber.ForeColor = System.Drawing.Color.Black
        Me.mskStudentNumber.Location = New System.Drawing.Point(105, 5)
        Me.mskStudentNumber.Name = "mskStudentNumber"
        Me.mskStudentNumber.Size = New System.Drawing.Size(253, 32)
        Me.mskStudentNumber.TabIndex = 1
        Me.mskStudentNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnStudeReport
        '
        Me.btnStudeReport.BackColor = System.Drawing.Color.Transparent
        Me.btnStudeReport.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudeReport.ForeColor = System.Drawing.Color.Black
        Me.btnStudeReport.Image = CType(resources.GetObject("btnStudeReport.Image"), System.Drawing.Image)
        Me.btnStudeReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStudeReport.Location = New System.Drawing.Point(297, 7)
        Me.btnStudeReport.Name = "btnStudeReport"
        Me.btnStudeReport.Size = New System.Drawing.Size(61, 29)
        Me.btnStudeReport.TabIndex = 3
        Me.btnStudeReport.Text = "&Preview"
        Me.btnStudeReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStudeReport.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReset.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(695, 4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(93, 34)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "Reset [ F3 ]"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'specialReportViewer
        '
        Me.specialReportViewer.ActiveViewIndex = -1
        Me.specialReportViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.specialReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.specialReportViewer.DisplayGroupTree = False
        Me.specialReportViewer.Location = New System.Drawing.Point(2, 54)
        Me.specialReportViewer.Name = "specialReportViewer"
        Me.specialReportViewer.SelectionFormula = ""
        Me.specialReportViewer.Size = New System.Drawing.Size(799, 388)
        Me.specialReportViewer.TabIndex = 7
        Me.specialReportViewer.TabStop = False
        Me.specialReportViewer.ViewTimeSelectionFormula = ""
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(802, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'frmGradesViewing
        '
        Me.AcceptButton = Me.btnStudeReport
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 451)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.specialReportViewer)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmGradesViewing"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grades Viewing"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnStudeReport As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mskStudentNumber As System.Windows.Forms.MaskedTextBox
    Friend WithEvents specialReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ResetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
