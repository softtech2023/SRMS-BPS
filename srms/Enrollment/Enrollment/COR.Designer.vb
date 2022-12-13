<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCOR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCOR))
        Me.lvCOR = New System.Windows.Forms.ListView
        Me.btnRemoveSubjects = New System.Windows.Forms.Button
        Me.btnAddSubject = New System.Windows.Forms.Button
        Me.btnAddStudent = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblSection = New System.Windows.Forms.Label
        Me.txtTotalUnits = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtTotalLab = New System.Windows.Forms.TextBox
        Me.txtTotalLecUnits = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtYearLevel = New System.Windows.Forms.TextBox
        Me.txtCourse = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblSettingsID = New System.Windows.Forms.Label
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.txtMiddleName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.mskStudentNumber = New System.Windows.Forms.MaskedTextBox
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tsSave = New System.Windows.Forms.ToolStripButton
        Me.tsUpdate = New System.Windows.Forms.ToolStripButton
        Me.tsDelete = New System.Windows.Forms.ToolStripButton
        Me.tsFind = New System.Windows.Forms.ToolStripButton
        Me.tsClear = New System.Windows.Forms.ToolStripButton
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.CORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddSubjectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvCOR
        '
        Me.lvCOR.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvCOR.ForeColor = System.Drawing.Color.Black
        Me.lvCOR.FullRowSelect = True
        Me.lvCOR.Location = New System.Drawing.Point(6, 102)
        Me.lvCOR.Name = "lvCOR"
        Me.lvCOR.Size = New System.Drawing.Size(813, 277)
        Me.lvCOR.TabIndex = 0
        Me.lvCOR.UseCompatibleStateImageBehavior = False
        '
        'btnRemoveSubjects
        '
        Me.btnRemoveSubjects.BackColor = System.Drawing.Color.Transparent
        Me.btnRemoveSubjects.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveSubjects.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnRemoveSubjects.Location = New System.Drawing.Point(696, 6)
        Me.btnRemoveSubjects.Name = "btnRemoveSubjects"
        Me.btnRemoveSubjects.Size = New System.Drawing.Size(111, 35)
        Me.btnRemoveSubjects.TabIndex = 3
        Me.btnRemoveSubjects.Text = "&Remove Subjects"
        Me.btnRemoveSubjects.UseVisualStyleBackColor = False
        '
        'btnAddSubject
        '
        Me.btnAddSubject.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSubject.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAddSubject.Location = New System.Drawing.Point(579, 6)
        Me.btnAddSubject.Name = "btnAddSubject"
        Me.btnAddSubject.Size = New System.Drawing.Size(111, 35)
        Me.btnAddSubject.TabIndex = 8
        Me.btnAddSubject.Text = "&Add Subjects (F3)"
        Me.btnAddSubject.UseVisualStyleBackColor = True
        '
        'btnAddStudent
        '
        Me.btnAddStudent.BackColor = System.Drawing.Color.Transparent
        Me.btnAddStudent.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddStudent.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAddStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddStudent.Location = New System.Drawing.Point(462, 6)
        Me.btnAddStudent.Name = "btnAddStudent"
        Me.btnAddStudent.Size = New System.Drawing.Size(111, 35)
        Me.btnAddStudent.TabIndex = 7
        Me.btnAddStudent.Text = "A&dd Student (F2)"
        Me.btnAddStudent.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblSection)
        Me.GroupBox2.Controls.Add(Me.txtTotalUnits)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtTotalLab)
        Me.GroupBox2.Controls.Add(Me.txtTotalLecUnits)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtYearLevel)
        Me.GroupBox2.Controls.Add(Me.txtCourse)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Controls.Add(Me.txtLastName)
        Me.GroupBox2.Controls.Add(Me.lvCOR)
        Me.GroupBox2.Controls.Add(Me.txtMiddleName)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtFirstName)
        Me.GroupBox2.Controls.Add(Me.mskStudentNumber)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(0, 55)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(819, 419)
        Me.GroupBox2.TabIndex = 63
        Me.GroupBox2.TabStop = False
        '
        'lblSection
        '
        Me.lblSection.AutoSize = True
        Me.lblSection.Location = New System.Drawing.Point(16, 395)
        Me.lblSection.Name = "lblSection"
        Me.lblSection.Size = New System.Drawing.Size(43, 13)
        Me.lblSection.TabIndex = 73
        Me.lblSection.Text = "Section"
        Me.lblSection.Visible = False
        '
        'txtTotalUnits
        '
        Me.txtTotalUnits.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalUnits.Location = New System.Drawing.Point(659, 385)
        Me.txtTotalUnits.Name = "txtTotalUnits"
        Me.txtTotalUnits.ReadOnly = True
        Me.txtTotalUnits.Size = New System.Drawing.Size(123, 30)
        Me.txtTotalUnits.TabIndex = 72
        Me.txtTotalUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTotalUnits.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(173, 388)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 22)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Lec/Lab Units"
        Me.Label3.Visible = False
        '
        'txtTotalLab
        '
        Me.txtTotalLab.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalLab.Location = New System.Drawing.Point(413, 385)
        Me.txtTotalLab.Name = "txtTotalLab"
        Me.txtTotalLab.ReadOnly = True
        Me.txtTotalLab.Size = New System.Drawing.Size(123, 30)
        Me.txtTotalLab.TabIndex = 70
        Me.txtTotalLab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTotalLab.Visible = False
        '
        'txtTotalLecUnits
        '
        Me.txtTotalLecUnits.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalLecUnits.Location = New System.Drawing.Point(284, 385)
        Me.txtTotalLecUnits.Name = "txtTotalLecUnits"
        Me.txtTotalLecUnits.ReadOnly = True
        Me.txtTotalLecUnits.Size = New System.Drawing.Size(123, 30)
        Me.txtTotalLecUnits.TabIndex = 69
        Me.txtTotalLecUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTotalLecUnits.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(549, 388)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 22)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "TOTAL UNITS"
        Me.Label2.Visible = False
        '
        'txtYearLevel
        '
        Me.txtYearLevel.Location = New System.Drawing.Point(633, 102)
        Me.txtYearLevel.Name = "txtYearLevel"
        Me.txtYearLevel.Size = New System.Drawing.Size(150, 20)
        Me.txtYearLevel.TabIndex = 67
        Me.txtYearLevel.Visible = False
        Me.txtYearLevel.WordWrap = False
        '
        'txtCourse
        '
        Me.txtCourse.Location = New System.Drawing.Point(478, 102)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(149, 20)
        Me.txtCourse.TabIndex = 66
        Me.txtCourse.Visible = False
        Me.txtCourse.WordWrap = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel2.Controls.Add(Me.lblSettingsID)
        Me.Panel2.Controls.Add(Me.btnAddSubject)
        Me.Panel2.Controls.Add(Me.btnRemoveSubjects)
        Me.Panel2.Controls.Add(Me.btnAddStudent)
        Me.Panel2.Location = New System.Drawing.Point(6, 19)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(813, 46)
        Me.Panel2.TabIndex = 65
        '
        'lblSettingsID
        '
        Me.lblSettingsID.AutoSize = True
        Me.lblSettingsID.Location = New System.Drawing.Point(378, 17)
        Me.lblSettingsID.Name = "lblSettingsID"
        Me.lblSettingsID.Size = New System.Drawing.Size(56, 13)
        Me.lblSettingsID.TabIndex = 59
        Me.lblSettingsID.Text = "SettingsID"
        Me.lblSettingsID.Visible = False
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.ForeColor = System.Drawing.Color.Black
        Me.txtLastName.Location = New System.Drawing.Point(670, 71)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.ReadOnly = True
        Me.txtLastName.Size = New System.Drawing.Size(149, 25)
        Me.txtLastName.TabIndex = 5
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddleName.ForeColor = System.Drawing.Color.Black
        Me.txtMiddleName.Location = New System.Drawing.Point(515, 71)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.ReadOnly = True
        Me.txtMiddleName.Size = New System.Drawing.Size(149, 25)
        Me.txtMiddleName.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(96, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Student Number"
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.ForeColor = System.Drawing.Color.Black
        Me.txtFirstName.Location = New System.Drawing.Point(360, 71)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.ReadOnly = True
        Me.txtFirstName.Size = New System.Drawing.Size(149, 25)
        Me.txtFirstName.TabIndex = 3
        '
        'mskStudentNumber
        '
        Me.mskStudentNumber.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.mskStudentNumber.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskStudentNumber.ForeColor = System.Drawing.Color.Black
        Me.mskStudentNumber.Location = New System.Drawing.Point(197, 71)
        Me.mskStudentNumber.Name = "mskStudentNumber"
        Me.mskStudentNumber.Size = New System.Drawing.Size(157, 25)
        Me.mskStudentNumber.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsSave, Me.tsUpdate, Me.tsDelete, Me.tsFind, Me.tsClear})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(819, 55)
        Me.ToolStrip1.TabIndex = 64
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsSave
        '
        Me.tsSave.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsSave.Image = CType(resources.GetObject("tsSave.Image"), System.Drawing.Image)
        Me.tsSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSave.Name = "tsSave"
        Me.tsSave.Size = New System.Drawing.Size(88, 52)
        Me.tsSave.Text = "Save"
        '
        'tsUpdate
        '
        Me.tsUpdate.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsUpdate.Image = CType(resources.GetObject("tsUpdate.Image"), System.Drawing.Image)
        Me.tsUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsUpdate.Name = "tsUpdate"
        Me.tsUpdate.Size = New System.Drawing.Size(102, 52)
        Me.tsUpdate.Text = "Update"
        '
        'tsDelete
        '
        Me.tsDelete.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsDelete.Image = CType(resources.GetObject("tsDelete.Image"), System.Drawing.Image)
        Me.tsDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDelete.Name = "tsDelete"
        Me.tsDelete.Size = New System.Drawing.Size(98, 52)
        Me.tsDelete.Text = "Delete"
        '
        'tsFind
        '
        Me.tsFind.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsFind.Image = CType(resources.GetObject("tsFind.Image"), System.Drawing.Image)
        Me.tsFind.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsFind.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsFind.Name = "tsFind"
        Me.tsFind.Size = New System.Drawing.Size(191, 52)
        Me.tsFind.Text = "Search Existing Record"
        '
        'tsClear
        '
        Me.tsClear.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsClear.Image = CType(resources.GetObject("tsClear.Image"), System.Drawing.Image)
        Me.tsClear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsClear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsClear.Name = "tsClear"
        Me.tsClear.Size = New System.Drawing.Size(127, 52)
        Me.tsClear.Text = "Clear Fields"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CORToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(819, 24)
        Me.MenuStrip1.TabIndex = 65
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'CORToolStripMenuItem
        '
        Me.CORToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.SearchToolStripMenuItem, Me.AddStudentToolStripMenuItem, Me.AddSubjectsToolStripMenuItem})
        Me.CORToolStripMenuItem.Name = "CORToolStripMenuItem"
        Me.CORToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.CORToolStripMenuItem.Text = "COR"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'AddStudentToolStripMenuItem
        '
        Me.AddStudentToolStripMenuItem.Name = "AddStudentToolStripMenuItem"
        Me.AddStudentToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.AddStudentToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.AddStudentToolStripMenuItem.Text = "Add Student"
        '
        'AddSubjectsToolStripMenuItem
        '
        Me.AddSubjectsToolStripMenuItem.Name = "AddSubjectsToolStripMenuItem"
        Me.AddSubjectsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.AddSubjectsToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.AddSubjectsToolStripMenuItem.Text = "Add Subjects"
        '
        'frmCOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(819, 496)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmCOR"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student's Subjects"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvCOR As System.Windows.Forms.ListView
    Friend WithEvents btnRemoveSubjects As System.Windows.Forms.Button
    Friend WithEvents btnAddSubject As System.Windows.Forms.Button
    Friend WithEvents btnAddStudent As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtMiddleName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents mskStudentNumber As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsUpdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsFind As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsClear As System.Windows.Forms.ToolStripButton
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CORToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddStudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddSubjectsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtYearLevel As System.Windows.Forms.TextBox
    Friend WithEvents txtCourse As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalLecUnits As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTotalLab As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalUnits As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblSection As System.Windows.Forms.Label
    Friend WithEvents tsDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblSettingsID As System.Windows.Forms.Label
End Class
