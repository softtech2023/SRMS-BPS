<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInputGrades
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInputGrades))
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtSection = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.dg1 = New System.Windows.Forms.DataGridView
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.txtInstructor = New System.Windows.Forms.TextBox
        Me.txtSubjectcode = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tsSave = New System.Windows.Forms.ToolStripButton
        Me.tsSearch = New System.Windows.Forms.ToolStripButton
        Me.tsDelete = New System.Windows.Forms.ToolStripButton
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.GradesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SelectSubjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblLab = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.lblLec = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblSubjectStatus = New System.Windows.Forms.Label
        Me.lblInstructorID = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.tsSchoolName = New System.Windows.Forms.ToolStripStatusLabel
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(31, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 19)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Section"
        '
        'txtSection
        '
        Me.txtSection.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSection.ForeColor = System.Drawing.Color.Black
        Me.txtSection.Location = New System.Drawing.Point(120, 3)
        Me.txtSection.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.Size = New System.Drawing.Size(122, 26)
        Me.txtSection.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(248, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Description"
        '
        'dg1
        '
        Me.dg1.AllowUserToAddRows = False
        Me.dg1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dg1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg1.Location = New System.Drawing.Point(0, 136)
        Me.dg1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dg1.Name = "dg1"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        Me.dg1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dg1.Size = New System.Drawing.Size(838, 408)
        Me.dg1.TabIndex = 1
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.ForeColor = System.Drawing.Color.Black
        Me.txtDescription.Location = New System.Drawing.Point(326, 4)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(323, 26)
        Me.txtDescription.TabIndex = 7
        '
        'txtInstructor
        '
        Me.txtInstructor.BackColor = System.Drawing.Color.White
        Me.txtInstructor.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInstructor.ForeColor = System.Drawing.Color.Black
        Me.txtInstructor.Location = New System.Drawing.Point(326, 4)
        Me.txtInstructor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtInstructor.Name = "txtInstructor"
        Me.txtInstructor.ReadOnly = True
        Me.txtInstructor.Size = New System.Drawing.Size(323, 26)
        Me.txtInstructor.TabIndex = 4
        '
        'txtSubjectcode
        '
        Me.txtSubjectcode.BackColor = System.Drawing.Color.White
        Me.txtSubjectcode.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubjectcode.ForeColor = System.Drawing.Color.Black
        Me.txtSubjectcode.Location = New System.Drawing.Point(120, 4)
        Me.txtSubjectcode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSubjectcode.Name = "txtSubjectcode"
        Me.txtSubjectcode.ReadOnly = True
        Me.txtSubjectcode.Size = New System.Drawing.Size(122, 26)
        Me.txtSubjectcode.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(248, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Teacher"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(31, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Subject Code"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Navy
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsSave, Me.tsSearch, Me.tsDelete})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(838, 39)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsSave
        '
        Me.tsSave.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsSave.ForeColor = System.Drawing.Color.White
        Me.tsSave.Image = CType(resources.GetObject("tsSave.Image"), System.Drawing.Image)
        Me.tsSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSave.Name = "tsSave"
        Me.tsSave.Size = New System.Drawing.Size(107, 36)
        Me.tsSave.Text = "Save Grades"
        '
        'tsSearch
        '
        Me.tsSearch.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsSearch.ForeColor = System.Drawing.Color.White
        Me.tsSearch.Image = CType(resources.GetObject("tsSearch.Image"), System.Drawing.Image)
        Me.tsSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSearch.Name = "tsSearch"
        Me.tsSearch.Size = New System.Drawing.Size(115, 36)
        Me.tsSearch.Text = "Select Subject"
        '
        'tsDelete
        '
        Me.tsDelete.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsDelete.ForeColor = System.Drawing.Color.White
        Me.tsDelete.Image = CType(resources.GetObject("tsDelete.Image"), System.Drawing.Image)
        Me.tsDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDelete.Name = "tsDelete"
        Me.tsDelete.Size = New System.Drawing.Size(127, 36)
        Me.tsDelete.Text = "Delete Grades"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GradesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(670, 35)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'GradesToolStripMenuItem
        '
        Me.GradesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.SelectSubjectToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.GradesToolStripMenuItem.Name = "GradesToolStripMenuItem"
        Me.GradesToolStripMenuItem.Size = New System.Drawing.Size(55, 29)
        Me.GradesToolStripMenuItem.Text = "Grades"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SelectSubjectToolStripMenuItem
        '
        Me.SelectSubjectToolStripMenuItem.Name = "SelectSubjectToolStripMenuItem"
        Me.SelectSubjectToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.SelectSubjectToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.SelectSubjectToolStripMenuItem.Text = "Select Subject"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblLab)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.lblLec)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.lblSubjectStatus)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(656, 43)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(170, 30)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Notes"
        Me.GroupBox2.Visible = False
        '
        'lblLab
        '
        Me.lblLab.AutoSize = True
        Me.lblLab.Location = New System.Drawing.Point(110, 231)
        Me.lblLab.Name = "lblLab"
        Me.lblLab.Size = New System.Drawing.Size(50, 15)
        Me.lblLab.TabIndex = 14
        Me.lblLab.Text = "Lab Units"
        Me.lblLab.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(9, 146)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(178, 15)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "INC. instead of I.N.C. for incomplete"
        '
        'lblLec
        '
        Me.lblLec.AutoSize = True
        Me.lblLec.Location = New System.Drawing.Point(20, 231)
        Me.lblLec.Name = "lblLec"
        Me.lblLec.Size = New System.Drawing.Size(49, 15)
        Me.lblLec.TabIndex = 13
        Me.lblLec.Text = "Lec Units"
        Me.lblLec.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(9, 95)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 15)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "1.00 instead of 1.0 or 1"
        '
        'lblSubjectStatus
        '
        Me.lblSubjectStatus.AutoSize = True
        Me.lblSubjectStatus.Location = New System.Drawing.Point(110, 186)
        Me.lblSubjectStatus.Name = "lblSubjectStatus"
        Me.lblSubjectStatus.Size = New System.Drawing.Size(32, 15)
        Me.lblSubjectStatus.TabIndex = 11
        Me.lblSubjectStatus.Text = "Open"
        Me.lblSubjectStatus.Visible = False
        '
        'lblInstructorID
        '
        Me.lblInstructorID.AutoSize = True
        Me.lblInstructorID.Location = New System.Drawing.Point(676, 98)
        Me.lblInstructorID.Name = "lblInstructorID"
        Me.lblInstructorID.Size = New System.Drawing.Size(81, 19)
        Me.lblInstructorID.TabIndex = 12
        Me.lblInstructorID.Text = "Instructor ID"
        Me.lblInstructorID.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(17, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(165, 15)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Use the following grades format:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtSubjectcode)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtDescription)
        Me.Panel2.Location = New System.Drawing.Point(0, 60)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(650, 34)
        Me.Panel2.TabIndex = 14
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.txtSection)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.txtInstructor)
        Me.Panel3.Location = New System.Drawing.Point(0, 98)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(650, 33)
        Me.Panel3.TabIndex = 15
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.tsSchoolName})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 548)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(838, 22)
        Me.StatusStrip1.TabIndex = 17
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.AutoSize = False
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(150, 17)
        Me.ToolStripStatusLabel1.Text = "Save (CTRL + S)"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.AutoSize = False
        Me.ToolStripStatusLabel2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(150, 17)
        Me.ToolStripStatusLabel2.Text = "Select Subject (CTRL + F)"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.AutoSize = False
        Me.ToolStripStatusLabel3.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(150, 17)
        Me.ToolStripStatusLabel3.Text = "Reset (F3)"
        '
        'tsSchoolName
        '
        Me.tsSchoolName.Name = "tsSchoolName"
        Me.tsSchoolName.Size = New System.Drawing.Size(198, 17)
        Me.tsSchoolName.Text = "Joji Ilagan Career Center Foundation"
        Me.tsSchoolName.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(676, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 19)
        Me.Label3.TabIndex = 18
        '
        'frmInputGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(838, 570)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblInstructorID)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dg1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmInputGrades"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "[  Input Grades  ]"
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtInstructor As System.Windows.Forms.TextBox
    Friend WithEvents txtSubjectcode As System.Windows.Forms.TextBox
    Friend WithEvents dg1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSection As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GradesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectSubjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblSubjectStatus As System.Windows.Forms.Label
    Friend WithEvents lblInstructorID As System.Windows.Forms.Label
    Friend WithEvents lblLec As System.Windows.Forms.Label
    Friend WithEvents lblLab As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsSchoolName As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tsDelete As System.Windows.Forms.ToolStripButton
End Class
