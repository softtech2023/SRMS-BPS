<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLockUnlockGrades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLockUnlockGrades))
        Me.btnSelectSubject = New System.Windows.Forms.Button
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtInstructor = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtSection = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtsubjectcode = New System.Windows.Forms.TextBox
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tsReceive = New System.Windows.Forms.ToolStripButton
        Me.tsPreview = New System.Windows.Forms.ToolStripButton
        Me.txtGradeStatus = New System.Windows.Forms.TextBox
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSelectSubject
        '
        Me.btnSelectSubject.BackColor = System.Drawing.Color.Transparent
        Me.btnSelectSubject.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSelectSubject.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectSubject.ForeColor = System.Drawing.Color.Black
        Me.btnSelectSubject.Location = New System.Drawing.Point(256, 1)
        Me.btnSelectSubject.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSelectSubject.Name = "btnSelectSubject"
        Me.btnSelectSubject.Size = New System.Drawing.Size(75, 28)
        Me.btnSelectSubject.TabIndex = 53
        Me.btnSelectSubject.TabStop = False
        Me.btnSelectSubject.Text = "Select"
        Me.btnSelectSubject.UseVisualStyleBackColor = False
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(-3, 127)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(927, 341)
        Me.CrystalReportViewer1.TabIndex = 66
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel5.Controls.Add(Me.txtGradeStatus)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.txtInstructor)
        Me.Panel5.Location = New System.Drawing.Point(-3, 92)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(927, 31)
        Me.Panel5.TabIndex = 65
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(32, 5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 19)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Teacher"
        '
        'txtInstructor
        '
        Me.txtInstructor.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInstructor.ForeColor = System.Drawing.Color.Black
        Me.txtInstructor.Location = New System.Drawing.Point(129, 2)
        Me.txtInstructor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtInstructor.Name = "txtInstructor"
        Me.txtInstructor.ReadOnly = True
        Me.txtInstructor.Size = New System.Drawing.Size(281, 26)
        Me.txtInstructor.TabIndex = 46
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtSection)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txtDescription)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtsubjectcode)
        Me.Panel2.Controls.Add(Me.btnSelectSubject)
        Me.Panel2.Location = New System.Drawing.Point(-3, 56)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(927, 32)
        Me.Panel2.TabIndex = 64
        '
        'txtSection
        '
        Me.txtSection.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSection.ForeColor = System.Drawing.Color.Black
        Me.txtSection.Location = New System.Drawing.Point(801, 3)
        Me.txtSection.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.ReadOnly = True
        Me.txtSection.Size = New System.Drawing.Size(113, 26)
        Me.txtSection.TabIndex = 45
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(745, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 19)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Section"
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.ForeColor = System.Drawing.Color.Black
        Me.txtDescription.Location = New System.Drawing.Point(416, 3)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(323, 26)
        Me.txtDescription.TabIndex = 52
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(337, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 19)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Description"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(32, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 19)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Subject Code"
        '
        'txtsubjectcode
        '
        Me.txtsubjectcode.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsubjectcode.ForeColor = System.Drawing.Color.Black
        Me.txtsubjectcode.Location = New System.Drawing.Point(129, 3)
        Me.txtsubjectcode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtsubjectcode.Name = "txtsubjectcode"
        Me.txtsubjectcode.ReadOnly = True
        Me.txtsubjectcode.Size = New System.Drawing.Size(125, 26)
        Me.txtsubjectcode.TabIndex = 44
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsReceive, Me.tsPreview})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(920, 55)
        Me.ToolStrip1.TabIndex = 68
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsReceive
        '
        Me.tsReceive.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsReceive.Image = CType(resources.GetObject("tsReceive.Image"), System.Drawing.Image)
        Me.tsReceive.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsReceive.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsReceive.Name = "tsReceive"
        Me.tsReceive.Size = New System.Drawing.Size(102, 52)
        Me.tsReceive.Text = "Update"
        '
        'tsPreview
        '
        Me.tsPreview.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsPreview.Image = CType(resources.GetObject("tsPreview.Image"), System.Drawing.Image)
        Me.tsPreview.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsPreview.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsPreview.Name = "tsPreview"
        Me.tsPreview.Size = New System.Drawing.Size(190, 52)
        Me.tsPreview.Text = "Preview Grading Sheet"
        '
        'txtGradeStatus
        '
        Me.txtGradeStatus.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGradeStatus.ForeColor = System.Drawing.Color.Black
        Me.txtGradeStatus.Location = New System.Drawing.Point(416, 1)
        Me.txtGradeStatus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtGradeStatus.Name = "txtGradeStatus"
        Me.txtGradeStatus.ReadOnly = True
        Me.txtGradeStatus.Size = New System.Drawing.Size(113, 26)
        Me.txtGradeStatus.TabIndex = 54
        Me.txtGradeStatus.Visible = False
        '
        'frmLockUnlockGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 469)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmLockUnlockGrades"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lock/Unlock Grades"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSelectSubject As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtInstructor As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtSection As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtsubjectcode As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsReceive As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsPreview As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtGradeStatus As System.Windows.Forms.TextBox
End Class
