<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrevGrades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrevGrades))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtStudeNumber = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtSubjectCode = New System.Windows.Forms.TextBox
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtFinal = New System.Windows.Forms.TextBox
        Me.txtComplied = New System.Windows.Forms.TextBox
        Me.txtSY = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblSection = New System.Windows.Forms.Label
        Me.cboSemester = New System.Windows.Forms.ComboBox
        Me.lblInstructorID = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtSchool = New System.Windows.Forms.TextBox
        Me.mainProfTS = New System.Windows.Forms.ToolStrip
        Me.tsSave = New System.Windows.Forms.ToolStripButton
        Me.tsUpdate = New System.Windows.Forms.ToolStripButton
        Me.tsDelete = New System.Windows.Forms.ToolStripButton
        Me.tsClose = New System.Windows.Forms.ToolStripButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label9 = New System.Windows.Forms.Label
        Me.btnView = New System.Windows.Forms.Button
        Me.txtSearchStude = New System.Windows.Forms.TextBox
        Me.dg1 = New System.Windows.Forms.DataGridView
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.mainProfTS.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student No."
        '
        'txtStudeNumber
        '
        Me.txtStudeNumber.Location = New System.Drawing.Point(124, 25)
        Me.txtStudeNumber.Name = "txtStudeNumber"
        Me.txtStudeNumber.ReadOnly = True
        Me.txtStudeNumber.Size = New System.Drawing.Size(100, 26)
        Me.txtStudeNumber.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Subject Code"
        '
        'txtSubjectCode
        '
        Me.txtSubjectCode.Location = New System.Drawing.Point(124, 57)
        Me.txtSubjectCode.Name = "txtSubjectCode"
        Me.txtSubjectCode.ReadOnly = True
        Me.txtSubjectCode.Size = New System.Drawing.Size(100, 26)
        Me.txtSubjectCode.TabIndex = 2
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(124, 89)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(275, 26)
        Me.txtDescription.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Description"
        '
        'txtFinal
        '
        Me.txtFinal.Location = New System.Drawing.Point(124, 121)
        Me.txtFinal.Name = "txtFinal"
        Me.txtFinal.Size = New System.Drawing.Size(100, 26)
        Me.txtFinal.TabIndex = 4
        '
        'txtComplied
        '
        Me.txtComplied.Location = New System.Drawing.Point(299, 121)
        Me.txtComplied.Name = "txtComplied"
        Me.txtComplied.Size = New System.Drawing.Size(100, 26)
        Me.txtComplied.TabIndex = 5
        '
        'txtSY
        '
        Me.txtSY.Location = New System.Drawing.Point(658, 89)
        Me.txtSY.Name = "txtSY"
        Me.txtSY.Size = New System.Drawing.Size(100, 26)
        Me.txtSY.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(83, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 19)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Final"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(231, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 19)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Complied"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(414, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 19)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Semester"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(629, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 19)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "SY"
        '
        'lblSection
        '
        Me.lblSection.AutoSize = True
        Me.lblSection.Location = New System.Drawing.Point(418, 136)
        Me.lblSection.Name = "lblSection"
        Me.lblSection.Size = New System.Drawing.Size(43, 13)
        Me.lblSection.TabIndex = 17
        Me.lblSection.Text = "Section"
        Me.lblSection.Visible = False
        '
        'cboSemester
        '
        Me.cboSemester.FormattingEnabled = True
        Me.cboSemester.Items.AddRange(New Object() {"1st Sem.", "2nd Sem."})
        Me.cboSemester.Location = New System.Drawing.Point(483, 89)
        Me.cboSemester.Name = "cboSemester"
        Me.cboSemester.Size = New System.Drawing.Size(100, 27)
        Me.cboSemester.TabIndex = 6
        '
        'lblInstructorID
        '
        Me.lblInstructorID.AutoSize = True
        Me.lblInstructorID.Location = New System.Drawing.Point(474, 136)
        Me.lblInstructorID.Name = "lblInstructorID"
        Me.lblInstructorID.Size = New System.Drawing.Size(65, 13)
        Me.lblInstructorID.TabIndex = 22
        Me.lblInstructorID.Text = "Instructor ID"
        Me.lblInstructorID.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(431, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 19)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "School"
        '
        'txtSchool
        '
        Me.txtSchool.Location = New System.Drawing.Point(483, 122)
        Me.txtSchool.Name = "txtSchool"
        Me.txtSchool.Size = New System.Drawing.Size(275, 26)
        Me.txtSchool.TabIndex = 8
        '
        'mainProfTS
        '
        Me.mainProfTS.BackColor = System.Drawing.Color.Transparent
        Me.mainProfTS.Font = New System.Drawing.Font("Segoe Condensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainProfTS.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.mainProfTS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsSave, Me.tsUpdate, Me.tsDelete, Me.tsClose})
        Me.mainProfTS.Location = New System.Drawing.Point(0, 0)
        Me.mainProfTS.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.mainProfTS.Name = "mainProfTS"
        Me.mainProfTS.Padding = New System.Windows.Forms.Padding(10)
        Me.mainProfTS.Size = New System.Drawing.Size(828, 93)
        Me.mainProfTS.TabIndex = 25
        Me.mainProfTS.Text = "ts"
        '
        'tsSave
        '
        Me.tsSave.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsSave.Image = CType(resources.GetObject("tsSave.Image"), System.Drawing.Image)
        Me.tsSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSave.Name = "tsSave"
        Me.tsSave.Size = New System.Drawing.Size(52, 70)
        Me.tsSave.Text = "&Save"
        Me.tsSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsSave.ToolTipText = "Ctrl + S"
        '
        'tsUpdate
        '
        Me.tsUpdate.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsUpdate.Image = CType(resources.GetObject("tsUpdate.Image"), System.Drawing.Image)
        Me.tsUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsUpdate.Name = "tsUpdate"
        Me.tsUpdate.Size = New System.Drawing.Size(52, 70)
        Me.tsUpdate.Text = "&Update"
        Me.tsUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsUpdate.ToolTipText = "Ctrl + U"
        '
        'tsDelete
        '
        Me.tsDelete.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsDelete.Image = CType(resources.GetObject("tsDelete.Image"), System.Drawing.Image)
        Me.tsDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDelete.Name = "tsDelete"
        Me.tsDelete.Size = New System.Drawing.Size(52, 70)
        Me.tsDelete.Text = "&Delete"
        Me.tsDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsDelete.ToolTipText = "Del"
        '
        'tsClose
        '
        Me.tsClose.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsClose.Image = CType(resources.GetObject("tsClose.Image"), System.Drawing.Image)
        Me.tsClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsClose.Name = "tsClose"
        Me.tsClose.Size = New System.Drawing.Size(52, 70)
        Me.tsClose.Text = "Close"
        Me.tsClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.dg1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtStudeNumber)
        Me.GroupBox1.Controls.Add(Me.txtSchool)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtSubjectCode)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.cboSemester)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtFinal)
        Me.GroupBox1.Controls.Add(Me.txtComplied)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtSY)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(804, 374)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GrayText
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.btnView)
        Me.Panel1.Controls.Add(Me.txtSearchStude)
        Me.Panel1.Location = New System.Drawing.Point(6, 153)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(783, 32)
        Me.Panel1.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(460, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 19)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Student No."
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(674, 3)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(78, 26)
        Me.btnView.TabIndex = 1
        Me.btnView.TabStop = False
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'txtSearchStude
        '
        Me.txtSearchStude.Location = New System.Drawing.Point(542, 4)
        Me.txtSearchStude.Name = "txtSearchStude"
        Me.txtSearchStude.Size = New System.Drawing.Size(126, 26)
        Me.txtSearchStude.TabIndex = 0
        Me.txtSearchStude.TabStop = False
        '
        'dg1
        '
        Me.dg1.AllowUserToAddRows = False
        Me.dg1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray
        Me.dg1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg1.Location = New System.Drawing.Point(6, 191)
        Me.dg1.Name = "dg1"
        Me.dg1.ReadOnly = True
        Me.dg1.Size = New System.Drawing.Size(783, 168)
        Me.dg1.TabIndex = 25
        Me.dg1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(230, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 27)
        Me.Button1.TabIndex = 28
        Me.Button1.TabStop = False
        Me.Button1.Text = "Select"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(230, 56)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 27)
        Me.Button2.TabIndex = 27
        Me.Button2.TabStop = False
        Me.Button2.Text = "Select"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmPrevGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 482)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.mainProfTS)
        Me.Controls.Add(Me.lblSection)
        Me.Controls.Add(Me.lblInstructorID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrevGrades"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Previous Grades"
        Me.mainProfTS.ResumeLayout(False)
        Me.mainProfTS.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtStudeNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSubjectCode As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFinal As System.Windows.Forms.TextBox
    Friend WithEvents txtComplied As System.Windows.Forms.TextBox
    Friend WithEvents txtSY As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblSection As System.Windows.Forms.Label
    Friend WithEvents cboSemester As System.Windows.Forms.ComboBox
    Friend WithEvents lblInstructorID As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSchool As System.Windows.Forms.TextBox
    Friend WithEvents mainProfTS As System.Windows.Forms.ToolStrip
    Friend WithEvents tsSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsUpdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents txtSearchStude As System.Windows.Forms.TextBox
    Friend WithEvents dg1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
