<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSemStudent
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSemStudent))
        Me.cboYearStat = New System.Windows.Forms.ComboBox
        Me.lblID = New System.Windows.Forms.Label
        Me.cboSection = New System.Windows.Forms.ComboBox
        Me.mskStudentNumber = New System.Windows.Forms.MaskedTextBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.cboAssessmentResult = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.mskAssessmentDate = New System.Windows.Forms.MaskedTextBox
        Me.mskTo = New System.Windows.Forms.MaskedTextBox
        Me.mskFrom = New System.Windows.Forms.MaskedTextBox
        Me.cboStudeStatus = New System.Windows.Forms.ComboBox
        Me.cboCourse = New System.Windows.Forms.ComboBox
        Me.cboYear = New System.Windows.Forms.ComboBox
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.txtFname = New System.Windows.Forms.TextBox
        Me.txtMName = New System.Windows.Forms.TextBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.EnrollmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.tsSave = New System.Windows.Forms.ToolStripButton
        Me.tsUpdate = New System.Windows.Forms.ToolStripButton
        Me.tsDelete = New System.Windows.Forms.ToolStripButton
        Me.mainProfTS = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.cboMajor = New System.Windows.Forms.ComboBox
        Me.GetmajorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet2 = New SIMS.DataSet2
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.tsNew = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Label24 = New System.Windows.Forms.Label
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.cboScholarship = New System.Windows.Forms.ComboBox
        Me.txtGrantAmount = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.cboAccountStatus = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblSettingsID = New System.Windows.Forms.Label
        Me.cboStatus = New System.Windows.Forms.ComboBox
        Me.CourseListTableAdapter = New SIMS.DataSetTableAdapters.CourseListTableAdapter
        Me.Get_majorTableAdapter = New SIMS.DataSet2TableAdapters.get_majorTableAdapter
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.cboQualification = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cboTrack = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.cbo4Ps = New System.Windows.Forms.ComboBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.cboIP = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.cboBalikAral = New System.Windows.Forms.ComboBox
        Me.cboRepeater = New System.Windows.Forms.ComboBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.cboTransferee = New System.Windows.Forms.ComboBox
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.lblAdviser = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.lblAdviserID = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.btnAccecelrated = New System.Windows.Forms.Button
        Me.btnDropped = New System.Windows.Forms.Button
        Me.btnTransferredOut = New System.Windows.Forms.Button
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.txtTotalUnits = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.txtTotalLab = New System.Windows.Forms.TextBox
        Me.txtTotalLecUnits = New System.Windows.Forms.TextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.btnLoadSubjects = New System.Windows.Forms.Button
        Me.btnAddSubject = New System.Windows.Forms.Button
        Me.btnRemoveSubjects = New System.Windows.Forms.Button
        Me.lvCOR = New System.Windows.Forms.ListView
        Me.Label36 = New System.Windows.Forms.Label
        Me.btnAdd = New System.Windows.Forms.Button
        Me.lblSem = New System.Windows.Forms.Label
        Me.lblSY = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        Me.mainProfTS.SuspendLayout()
        CType(Me.GetmajorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboYearStat
        '
        Me.cboYearStat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboYearStat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboYearStat.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYearStat.ForeColor = System.Drawing.Color.Black
        Me.cboYearStat.FormattingEnabled = True
        Me.cboYearStat.Items.AddRange(New Object() {"Regular", "Irregular"})
        Me.cboYearStat.Location = New System.Drawing.Point(293, 81)
        Me.cboYearStat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboYearStat.Name = "cboYearStat"
        Me.cboYearStat.Size = New System.Drawing.Size(107, 27)
        Me.cboYearStat.TabIndex = 11
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(467, 17)
        Me.lblID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(17, 15)
        Me.lblID.TabIndex = 7
        Me.lblID.Text = "ID"
        Me.lblID.Visible = False
        '
        'cboSection
        '
        Me.cboSection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSection.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSection.FormattingEnabled = True
        Me.cboSection.Location = New System.Drawing.Point(590, 0)
        Me.cboSection.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboSection.Name = "cboSection"
        Me.cboSection.Size = New System.Drawing.Size(184, 27)
        Me.cboSection.TabIndex = 13
        '
        'mskStudentNumber
        '
        Me.mskStudentNumber.BackColor = System.Drawing.Color.White
        Me.mskStudentNumber.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskStudentNumber.ForeColor = System.Drawing.Color.Black
        Me.mskStudentNumber.Location = New System.Drawing.Point(114, 0)
        Me.mskStudentNumber.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mskStudentNumber.Name = "mskStudentNumber"
        Me.mskStudentNumber.ReadOnly = True
        Me.mskStudentNumber.Size = New System.Drawing.Size(119, 26)
        Me.mskStudentNumber.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(193, 5)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(38, 17)
        Me.btnClose.TabIndex = 22
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'cboAssessmentResult
        '
        Me.cboAssessmentResult.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboAssessmentResult.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAssessmentResult.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAssessmentResult.ForeColor = System.Drawing.Color.Black
        Me.cboAssessmentResult.FormattingEnabled = True
        Me.cboAssessmentResult.Items.AddRange(New Object() {"Competent", "For Assessment", "Not Yet Competent"})
        Me.cboAssessmentResult.Location = New System.Drawing.Point(352, 0)
        Me.cboAssessmentResult.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboAssessmentResult.Name = "cboAssessmentResult"
        Me.cboAssessmentResult.Size = New System.Drawing.Size(120, 27)
        Me.cboAssessmentResult.Sorted = True
        Me.cboAssessmentResult.TabIndex = 20
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(242, 4)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(14, 19)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "-"
        '
        'mskAssessmentDate
        '
        Me.mskAssessmentDate.ForeColor = System.Drawing.Color.Black
        Me.mskAssessmentDate.Location = New System.Drawing.Point(113, 1)
        Me.mskAssessmentDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mskAssessmentDate.Mask = "00/00/0000"
        Me.mskAssessmentDate.Name = "mskAssessmentDate"
        Me.mskAssessmentDate.Size = New System.Drawing.Size(121, 26)
        Me.mskAssessmentDate.TabIndex = 19
        Me.mskAssessmentDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mskAssessmentDate.ValidatingType = GetType(Date)
        '
        'mskTo
        '
        Me.mskTo.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskTo.ForeColor = System.Drawing.Color.Black
        Me.mskTo.Location = New System.Drawing.Point(264, 1)
        Me.mskTo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mskTo.Mask = "00/00/0000"
        Me.mskTo.Name = "mskTo"
        Me.mskTo.Size = New System.Drawing.Size(127, 26)
        Me.mskTo.TabIndex = 17
        Me.mskTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mskTo.ValidatingType = GetType(Date)
        '
        'mskFrom
        '
        Me.mskFrom.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskFrom.ForeColor = System.Drawing.Color.Black
        Me.mskFrom.Location = New System.Drawing.Point(113, 1)
        Me.mskFrom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mskFrom.Mask = "00/00/0000"
        Me.mskFrom.Name = "mskFrom"
        Me.mskFrom.Size = New System.Drawing.Size(121, 26)
        Me.mskFrom.TabIndex = 16
        Me.mskFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mskFrom.ValidatingType = GetType(Date)
        '
        'cboStudeStatus
        '
        Me.cboStudeStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboStudeStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboStudeStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStudeStatus.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStudeStatus.ForeColor = System.Drawing.Color.Black
        Me.cboStudeStatus.FormattingEnabled = True
        Me.cboStudeStatus.Items.AddRange(New Object() {"New", "Old"})
        Me.cboStudeStatus.Location = New System.Drawing.Point(590, 3)
        Me.cboStudeStatus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboStudeStatus.Name = "cboStudeStatus"
        Me.cboStudeStatus.Size = New System.Drawing.Size(181, 27)
        Me.cboStudeStatus.Sorted = True
        Me.cboStudeStatus.TabIndex = 14
        '
        'cboCourse
        '
        Me.cboCourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboCourse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCourse.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCourse.ForeColor = System.Drawing.Color.Black
        Me.cboCourse.FormattingEnabled = True
        Me.cboCourse.Location = New System.Drawing.Point(114, 0)
        Me.cboCourse.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboCourse.Name = "cboCourse"
        Me.cboCourse.Size = New System.Drawing.Size(149, 27)
        Me.cboCourse.TabIndex = 11
        '
        'cboYear
        '
        Me.cboYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYear.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYear.ForeColor = System.Drawing.Color.Black
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Location = New System.Drawing.Point(352, 0)
        Me.cboYear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(119, 27)
        Me.cboYear.TabIndex = 12
        '
        'txtLastName
        '
        Me.txtLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLastName.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.ForeColor = System.Drawing.Color.Black
        Me.txtLastName.Location = New System.Drawing.Point(590, 1)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.ReadOnly = True
        Me.txtLastName.Size = New System.Drawing.Size(182, 26)
        Me.txtLastName.TabIndex = 5
        '
        'txtFname
        '
        Me.txtFname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFname.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFname.ForeColor = System.Drawing.Color.Black
        Me.txtFname.Location = New System.Drawing.Point(114, 1)
        Me.txtFname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.ReadOnly = True
        Me.txtFname.Size = New System.Drawing.Size(119, 26)
        Me.txtFname.TabIndex = 3
        '
        'txtMName
        '
        Me.txtMName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMName.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMName.ForeColor = System.Drawing.Color.Black
        Me.txtMName.Location = New System.Drawing.Point(352, 1)
        Me.txtMName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMName.Name = "txtMName"
        Me.txtMName.ReadOnly = True
        Me.txtMName.Size = New System.Drawing.Size(119, 26)
        Me.txtMName.TabIndex = 4
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnrollmentToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(711, 25)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'EnrollmentToolStripMenuItem
        '
        Me.EnrollmentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.SaveToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.EnrollmentToolStripMenuItem.Name = "EnrollmentToolStripMenuItem"
        Me.EnrollmentToolStripMenuItem.Size = New System.Drawing.Size(77, 19)
        Me.EnrollmentToolStripMenuItem.Text = "Enrollment"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'tsSave
        '
        Me.tsSave.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsSave.Image = CType(resources.GetObject("tsSave.Image"), System.Drawing.Image)
        Me.tsSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSave.Name = "tsSave"
        Me.tsSave.Size = New System.Drawing.Size(36, 55)
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
        Me.tsUpdate.Size = New System.Drawing.Size(50, 55)
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
        Me.tsDelete.Size = New System.Drawing.Size(46, 55)
        Me.tsDelete.Text = "&Delete"
        Me.tsDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsDelete.ToolTipText = "Del"
        '
        'mainProfTS
        '
        Me.mainProfTS.BackColor = System.Drawing.Color.Transparent
        Me.mainProfTS.Font = New System.Drawing.Font("Segoe Condensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainProfTS.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.mainProfTS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsSave, Me.tsUpdate, Me.tsDelete, Me.ToolStripButton1})
        Me.mainProfTS.Location = New System.Drawing.Point(0, 0)
        Me.mainProfTS.Margin = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.mainProfTS.Name = "mainProfTS"
        Me.mainProfTS.Padding = New System.Windows.Forms.Padding(13, 14, 13, 14)
        Me.mainProfTS.Size = New System.Drawing.Size(794, 86)
        Me.mainProfTS.TabIndex = 15
        Me.mainProfTS.Text = "ts"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(52, 55)
        Me.ToolStripButton1.Text = "Search"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cboMajor
        '
        Me.cboMajor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboMajor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboMajor.DataSource = Me.GetmajorBindingSource
        Me.cboMajor.DisplayMember = "Major"
        Me.cboMajor.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMajor.FormattingEnabled = True
        Me.cboMajor.Location = New System.Drawing.Point(451, 16)
        Me.cboMajor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboMajor.Name = "cboMajor"
        Me.cboMajor.Size = New System.Drawing.Size(248, 27)
        Me.cboMajor.TabIndex = 8
        '
        'GetmajorBindingSource
        '
        Me.GetmajorBindingSource.DataMember = "get_major"
        Me.GetmajorBindingSource.DataSource = Me.DataSet2
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "DataSet2"
        Me.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.mskStudentNumber)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(5, 11)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(234, 28)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(76, 4)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LRN"
        '
        'tsNew
        '
        Me.tsNew.Location = New System.Drawing.Point(243, 11)
        Me.tsNew.Name = "tsNew"
        Me.tsNew.Size = New System.Drawing.Size(118, 28)
        Me.tsNew.TabIndex = 23
        Me.tsNew.TabStop = False
        Me.tsNew.Text = "&New (Alt + N)"
        Me.tsNew.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtLastName)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.txtMName)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.txtFname)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(5, 45)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(779, 28)
        Me.Panel2.TabIndex = 2
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(513, 5)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(71, 19)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Last Name"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(260, 4)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(86, 19)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Middle Name"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(37, 4)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 19)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "First Name"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(633, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 52
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel5.Controls.Add(Me.cboSection)
        Me.Panel5.Controls.Add(Me.Label22)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.cboCourse)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.cboYear)
        Me.Panel5.ForeColor = System.Drawing.Color.Black
        Me.Panel5.Location = New System.Drawing.Point(5, 80)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(779, 28)
        Me.Panel5.TabIndex = 10
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(534, 5)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(50, 19)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Section"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(32, 5)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Department"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(269, 5)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Grade Level"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(484, 6)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 19)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Student's Status"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(404, 20)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Major"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(226, 84)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 19)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "YL Status"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe Condensed", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(18, 108)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(209, 28)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "FOR TESDA PROGRAM"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel9.Controls.Add(Me.mskFrom)
        Me.Panel9.Controls.Add(Me.mskTo)
        Me.Panel9.Controls.Add(Me.Label14)
        Me.Panel9.Controls.Add(Me.Label24)
        Me.Panel9.ForeColor = System.Drawing.Color.Black
        Me.Panel9.Location = New System.Drawing.Point(9, 139)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(392, 28)
        Me.Panel9.TabIndex = 15
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(27, 4)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(58, 19)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Duration"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel10.Controls.Add(Me.Label10)
        Me.Panel10.Controls.Add(Me.Label11)
        Me.Panel10.Controls.Add(Me.mskAssessmentDate)
        Me.Panel10.Controls.Add(Me.cboAssessmentResult)
        Me.Panel10.ForeColor = System.Drawing.Color.Black
        Me.Panel10.Location = New System.Drawing.Point(9, 165)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(472, 28)
        Me.Panel10.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(247, 4)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 19)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Exam Result"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(27, 4)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 19)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Exam Date"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(20, 51)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 15)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Scholarship"
        '
        'cboScholarship
        '
        Me.cboScholarship.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboScholarship.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboScholarship.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboScholarship.ForeColor = System.Drawing.Color.Black
        Me.cboScholarship.FormattingEnabled = True
        Me.cboScholarship.Location = New System.Drawing.Point(100, 48)
        Me.cboScholarship.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboScholarship.Name = "cboScholarship"
        Me.cboScholarship.Size = New System.Drawing.Size(298, 23)
        Me.cboScholarship.TabIndex = 10
        '
        'txtGrantAmount
        '
        Me.txtGrantAmount.ForeColor = System.Drawing.Color.Black
        Me.txtGrantAmount.Location = New System.Drawing.Point(523, 142)
        Me.txtGrantAmount.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtGrantAmount.Name = "txtGrantAmount"
        Me.txtGrantAmount.Size = New System.Drawing.Size(77, 26)
        Me.txtGrantAmount.TabIndex = 9
        Me.txtGrantAmount.Text = "0.00"
        Me.txtGrantAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(395, 146)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(90, 15)
        Me.Label17.TabIndex = 40
        Me.Label17.Text = "Scholarship Value"
        '
        'cboAccountStatus
        '
        Me.cboAccountStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboAccountStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAccountStatus.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAccountStatus.ForeColor = System.Drawing.Color.Black
        Me.cboAccountStatus.FormattingEnabled = True
        Me.cboAccountStatus.Items.AddRange(New Object() {"Paying", "Scholar"})
        Me.cboAccountStatus.Location = New System.Drawing.Point(100, 20)
        Me.cboAccountStatus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboAccountStatus.Name = "cboAccountStatus"
        Me.cboAccountStatus.Size = New System.Drawing.Size(94, 23)
        Me.cboAccountStatus.TabIndex = 8
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(332, 33)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 15)
        Me.Label16.TabIndex = 36
        Me.Label16.Text = "Result/Status"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(6, 28)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 15)
        Me.Label18.TabIndex = 42
        Me.Label18.Text = "Account Status"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblSettingsID)
        Me.GroupBox1.Controls.Add(Me.cboMajor)
        Me.GroupBox1.Controls.Add(Me.cboStatus)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Panel10)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.cboYearStat)
        Me.GroupBox1.Controls.Add(Me.Panel9)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cboAccountStatus)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtGrantAmount)
        Me.GroupBox1.Controls.Add(Me.cboScholarship)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Location = New System.Drawing.Point(247, 19)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(314, 49)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Hidden Controls"
        Me.GroupBox1.Visible = False
        '
        'lblSettingsID
        '
        Me.lblSettingsID.AutoSize = True
        Me.lblSettingsID.Location = New System.Drawing.Point(215, 20)
        Me.lblSettingsID.Name = "lblSettingsID"
        Me.lblSettingsID.Size = New System.Drawing.Size(72, 19)
        Me.lblSettingsID.TabIndex = 25
        Me.lblSettingsID.Text = "SettingsID"
        Me.lblSettingsID.Visible = False
        '
        'cboStatus
        '
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Location = New System.Drawing.Point(100, 78)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(121, 27)
        Me.cboStatus.TabIndex = 43
        Me.cboStatus.Text = "Enrolled"
        '
        'CourseListTableAdapter
        '
        Me.CourseListTableAdapter.ClearBeforeFill = True
        '
        'Get_majorTableAdapter
        '
        Me.Get_majorTableAdapter.ClearBeforeFill = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.Controls.Add(Me.cboQualification)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.cboTrack)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.cboStudeStatus)
        Me.Panel3.ForeColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(6, 228)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(778, 63)
        Me.Panel3.TabIndex = 21
        '
        'cboQualification
        '
        Me.cboQualification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboQualification.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboQualification.FormattingEnabled = True
        Me.cboQualification.Location = New System.Drawing.Point(114, 31)
        Me.cboQualification.Name = "cboQualification"
        Me.cboQualification.Size = New System.Drawing.Size(657, 27)
        Me.cboQualification.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(69, 6)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 19)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Track"
        '
        'cboTrack
        '
        Me.cboTrack.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboTrack.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTrack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTrack.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTrack.ForeColor = System.Drawing.Color.Black
        Me.cboTrack.FormattingEnabled = True
        Me.cboTrack.Location = New System.Drawing.Point(114, 1)
        Me.cboTrack.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboTrack.Name = "cboTrack"
        Me.cboTrack.Size = New System.Drawing.Size(356, 27)
        Me.cboTrack.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(63, 34)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 19)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Strand"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel4.Controls.Add(Me.cbo4Ps)
        Me.Panel4.Controls.Add(Me.Label25)
        Me.Panel4.Controls.Add(Me.Label23)
        Me.Panel4.Controls.Add(Me.cboIP)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.cboBalikAral)
        Me.Panel4.ForeColor = System.Drawing.Color.Black
        Me.Panel4.Location = New System.Drawing.Point(6, 154)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(778, 31)
        Me.Panel4.TabIndex = 15
        '
        'cbo4Ps
        '
        Me.cbo4Ps.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbo4Ps.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo4Ps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo4Ps.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo4Ps.ForeColor = System.Drawing.Color.Black
        Me.cbo4Ps.FormattingEnabled = True
        Me.cbo4Ps.Items.AddRange(New Object() {"Yes", "No"})
        Me.cbo4Ps.Location = New System.Drawing.Point(590, 3)
        Me.cbo4Ps.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbo4Ps.Name = "cbo4Ps"
        Me.cbo4Ps.Size = New System.Drawing.Size(183, 27)
        Me.cbo4Ps.TabIndex = 18
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(483, 6)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(101, 19)
        Me.Label25.TabIndex = 18
        Me.Label25.Text = "4Ps Beneficiary?"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(269, 6)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(77, 19)
        Me.Label23.TabIndex = 16
        Me.Label23.Text = "IP Member?"
        '
        'cboIP
        '
        Me.cboIP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboIP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboIP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIP.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboIP.ForeColor = System.Drawing.Color.Black
        Me.cboIP.FormattingEnabled = True
        Me.cboIP.Items.AddRange(New Object() {"Yes", "No"})
        Me.cboIP.Location = New System.Drawing.Point(352, 2)
        Me.cboIP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboIP.Name = "cboIP"
        Me.cboIP.Size = New System.Drawing.Size(118, 27)
        Me.cboIP.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(41, 4)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 19)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Balik Aral?"
        '
        'cboBalikAral
        '
        Me.cboBalikAral.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboBalikAral.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboBalikAral.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBalikAral.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBalikAral.ForeColor = System.Drawing.Color.Black
        Me.cboBalikAral.FormattingEnabled = True
        Me.cboBalikAral.Items.AddRange(New Object() {"Yes", "No"})
        Me.cboBalikAral.Location = New System.Drawing.Point(114, 1)
        Me.cboBalikAral.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboBalikAral.Name = "cboBalikAral"
        Me.cboBalikAral.Size = New System.Drawing.Size(149, 27)
        Me.cboBalikAral.TabIndex = 16
        '
        'cboRepeater
        '
        Me.cboRepeater.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboRepeater.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboRepeater.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRepeater.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRepeater.ForeColor = System.Drawing.Color.Black
        Me.cboRepeater.FormattingEnabled = True
        Me.cboRepeater.Items.AddRange(New Object() {"Yes", "No"})
        Me.cboRepeater.Location = New System.Drawing.Point(352, 2)
        Me.cboRepeater.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboRepeater.Name = "cboRepeater"
        Me.cboRepeater.Size = New System.Drawing.Size(118, 27)
        Me.cboRepeater.TabIndex = 20
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(280, 5)
        Me.Label26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(66, 19)
        Me.Label26.TabIndex = 26
        Me.Label26.Text = "Repeater?"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(33, 5)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 19)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Transferee?"
        '
        'cboTransferee
        '
        Me.cboTransferee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboTransferee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTransferee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTransferee.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTransferee.ForeColor = System.Drawing.Color.Black
        Me.cboTransferee.FormattingEnabled = True
        Me.cboTransferee.Items.AddRange(New Object() {"Yes", "No"})
        Me.cboTransferee.Location = New System.Drawing.Point(114, 2)
        Me.cboTransferee.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboTransferee.Name = "cboTransferee"
        Me.cboTransferee.Size = New System.Drawing.Size(148, 27)
        Me.cboTransferee.TabIndex = 19
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel6.Controls.Add(Me.lblAdviser)
        Me.Panel6.Controls.Add(Me.Label28)
        Me.Panel6.ForeColor = System.Drawing.Color.Black
        Me.Panel6.Location = New System.Drawing.Point(5, 115)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(471, 33)
        Me.Panel6.TabIndex = 24
        '
        'lblAdviser
        '
        Me.lblAdviser.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdviser.Location = New System.Drawing.Point(114, 3)
        Me.lblAdviser.Name = "lblAdviser"
        Me.lblAdviser.ReadOnly = True
        Me.lblAdviser.Size = New System.Drawing.Size(354, 26)
        Me.lblAdviser.TabIndex = 1
        Me.lblAdviser.TabStop = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(58, 6)
        Me.Label28.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(51, 19)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "Adviser"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel7.Controls.Add(Me.cboRepeater)
        Me.Panel7.Controls.Add(Me.cboTransferee)
        Me.Panel7.Controls.Add(Me.Label15)
        Me.Panel7.Controls.Add(Me.Label26)
        Me.Panel7.ForeColor = System.Drawing.Color.Black
        Me.Panel7.Location = New System.Drawing.Point(6, 191)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(778, 31)
        Me.Panel7.TabIndex = 27
        '
        'lblAdviserID
        '
        Me.lblAdviserID.AutoSize = True
        Me.lblAdviserID.Location = New System.Drawing.Point(281, 49)
        Me.lblAdviserID.Name = "lblAdviserID"
        Me.lblAdviserID.Size = New System.Drawing.Size(68, 19)
        Me.lblAdviserID.TabIndex = 28
        Me.lblAdviserID.Text = "AdviserID"
        Me.lblAdviserID.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 98)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(794, 370)
        Me.TabControl1.TabIndex = 29
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblSem)
        Me.TabPage1.Controls.Add(Me.Label30)
        Me.TabPage1.Controls.Add(Me.lblSY)
        Me.TabPage1.Controls.Add(Me.btnAccecelrated)
        Me.TabPage1.Controls.Add(Me.btnDropped)
        Me.TabPage1.Controls.Add(Me.lblID)
        Me.TabPage1.Controls.Add(Me.btnTransferredOut)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.Panel7)
        Me.TabPage1.Controls.Add(Me.Panel5)
        Me.TabPage1.Controls.Add(Me.Panel6)
        Me.TabPage1.Controls.Add(Me.tsNew)
        Me.TabPage1.Controls.Add(Me.Panel4)
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(786, 338)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Enrollment Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnAccecelrated
        '
        Me.btnAccecelrated.Location = New System.Drawing.Point(403, 297)
        Me.btnAccecelrated.Name = "btnAccecelrated"
        Me.btnAccecelrated.Size = New System.Drawing.Size(121, 35)
        Me.btnAccecelrated.TabIndex = 30
        Me.btnAccecelrated.Text = "Accelerated"
        Me.btnAccecelrated.UseVisualStyleBackColor = True
        '
        'btnDropped
        '
        Me.btnDropped.Location = New System.Drawing.Point(657, 297)
        Me.btnDropped.Name = "btnDropped"
        Me.btnDropped.Size = New System.Drawing.Size(121, 35)
        Me.btnDropped.TabIndex = 29
        Me.btnDropped.Text = "Drop"
        Me.btnDropped.UseVisualStyleBackColor = True
        '
        'btnTransferredOut
        '
        Me.btnTransferredOut.Location = New System.Drawing.Point(530, 297)
        Me.btnTransferredOut.Name = "btnTransferredOut"
        Me.btnTransferredOut.Size = New System.Drawing.Size(121, 35)
        Me.btnTransferredOut.TabIndex = 28
        Me.btnTransferredOut.Text = "Transferred Out"
        Me.btnTransferredOut.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtTotalUnits)
        Me.TabPage2.Controls.Add(Me.Label27)
        Me.TabPage2.Controls.Add(Me.txtTotalLab)
        Me.TabPage2.Controls.Add(Me.txtTotalLecUnits)
        Me.TabPage2.Controls.Add(Me.Label29)
        Me.TabPage2.Controls.Add(Me.btnLoadSubjects)
        Me.TabPage2.Controls.Add(Me.btnAddSubject)
        Me.TabPage2.Controls.Add(Me.btnRemoveSubjects)
        Me.TabPage2.Controls.Add(Me.lvCOR)
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(786, 338)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Subjects"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtTotalUnits
        '
        Me.txtTotalUnits.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalUnits.Location = New System.Drawing.Point(347, 307)
        Me.txtTotalUnits.Name = "txtTotalUnits"
        Me.txtTotalUnits.ReadOnly = True
        Me.txtTotalUnits.Size = New System.Drawing.Size(82, 30)
        Me.txtTotalUnits.TabIndex = 77
        Me.txtTotalUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTotalUnits.Visible = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(9, 310)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(105, 22)
        Me.Label27.TabIndex = 76
        Me.Label27.Text = "Lec/Lab Units"
        Me.Label27.Visible = False
        '
        'txtTotalLab
        '
        Me.txtTotalLab.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalLab.Location = New System.Drawing.Point(179, 307)
        Me.txtTotalLab.Name = "txtTotalLab"
        Me.txtTotalLab.ReadOnly = True
        Me.txtTotalLab.Size = New System.Drawing.Size(51, 30)
        Me.txtTotalLab.TabIndex = 75
        Me.txtTotalLab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTotalLab.Visible = False
        '
        'txtTotalLecUnits
        '
        Me.txtTotalLecUnits.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalLecUnits.Location = New System.Drawing.Point(120, 307)
        Me.txtTotalLecUnits.Name = "txtTotalLecUnits"
        Me.txtTotalLecUnits.ReadOnly = True
        Me.txtTotalLecUnits.Size = New System.Drawing.Size(53, 30)
        Me.txtTotalLecUnits.TabIndex = 74
        Me.txtTotalLecUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTotalLecUnits.Visible = False
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(241, 310)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(104, 22)
        Me.Label29.TabIndex = 73
        Me.Label29.Text = "TOTAL UNITS"
        Me.Label29.Visible = False
        '
        'btnLoadSubjects
        '
        Me.btnLoadSubjects.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadSubjects.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnLoadSubjects.Location = New System.Drawing.Point(435, 303)
        Me.btnLoadSubjects.Name = "btnLoadSubjects"
        Me.btnLoadSubjects.Size = New System.Drawing.Size(111, 32)
        Me.btnLoadSubjects.TabIndex = 33
        Me.btnLoadSubjects.Text = "Load Subjects"
        Me.btnLoadSubjects.UseVisualStyleBackColor = True
        Me.btnLoadSubjects.Visible = False
        '
        'btnAddSubject
        '
        Me.btnAddSubject.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSubject.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAddSubject.Location = New System.Drawing.Point(552, 303)
        Me.btnAddSubject.Name = "btnAddSubject"
        Me.btnAddSubject.Size = New System.Drawing.Size(111, 32)
        Me.btnAddSubject.TabIndex = 32
        Me.btnAddSubject.Text = "&Add Subjects"
        Me.btnAddSubject.UseVisualStyleBackColor = True
        Me.btnAddSubject.Visible = False
        '
        'btnRemoveSubjects
        '
        Me.btnRemoveSubjects.BackColor = System.Drawing.Color.Transparent
        Me.btnRemoveSubjects.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveSubjects.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnRemoveSubjects.Location = New System.Drawing.Point(669, 303)
        Me.btnRemoveSubjects.Name = "btnRemoveSubjects"
        Me.btnRemoveSubjects.Size = New System.Drawing.Size(111, 32)
        Me.btnRemoveSubjects.TabIndex = 31
        Me.btnRemoveSubjects.Text = "&Remove Subject"
        Me.btnRemoveSubjects.UseVisualStyleBackColor = False
        Me.btnRemoveSubjects.Visible = False
        '
        'lvCOR
        '
        Me.lvCOR.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvCOR.ForeColor = System.Drawing.Color.Black
        Me.lvCOR.FullRowSelect = True
        Me.lvCOR.Location = New System.Drawing.Point(6, 3)
        Me.lvCOR.Name = "lvCOR"
        Me.lvCOR.Size = New System.Drawing.Size(774, 298)
        Me.lvCOR.TabIndex = 1
        Me.lvCOR.UseCompatibleStateImageBehavior = False
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Segoe Condensed", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(29, 5)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(209, 28)
        Me.Label36.TabIndex = 13
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(618, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(148, 32)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "Add Data"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblSem
        '
        Me.lblSem.AutoSize = True
        Me.lblSem.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSem.Location = New System.Drawing.Point(547, 9)
        Me.lblSem.Name = "lblSem"
        Me.lblSem.Size = New System.Drawing.Size(0, 23)
        Me.lblSem.TabIndex = 30
        '
        'lblSY
        '
        Me.lblSY.AutoSize = True
        Me.lblSY.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSY.Location = New System.Drawing.Point(678, 9)
        Me.lblSY.Name = "lblSY"
        Me.lblSY.Size = New System.Drawing.Size(0, 23)
        Me.lblSY.TabIndex = 31
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(646, 9)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(32, 23)
        Me.Label30.TabIndex = 32
        Me.Label30.Text = "SY"
        '
        'frmSemStudent
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(794, 470)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lblAdviserID)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.mainProfTS)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "frmSemStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enrollment Form"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.mainProfTS.ResumeLayout(False)
        Me.mainProfTS.PerformLayout()
        CType(Me.GetmajorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mskStudentNumber As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFname As System.Windows.Forms.TextBox
    Friend WithEvents txtMName As System.Windows.Forms.TextBox
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents cboYear As System.Windows.Forms.ComboBox
    Friend WithEvents cboCourse As System.Windows.Forms.ComboBox
    Friend WithEvents cboStudeStatus As System.Windows.Forms.ComboBox
    Friend WithEvents mskTo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskFrom As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents mskAssessmentDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboAssessmentResult As System.Windows.Forms.ComboBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents EnrollmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsUpdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents mainProfTS As System.Windows.Forms.ToolStrip
    Friend WithEvents cboSection As System.Windows.Forms.ComboBox
    Friend WithEvents cboYearStat As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents cboMajor As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cboScholarship As System.Windows.Forms.ComboBox
    Friend WithEvents txtGrantAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cboAccountStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents tsNew As System.Windows.Forms.Button
    Friend WithEvents CourseListTableAdapter As SIMS.DataSetTableAdapters.CourseListTableAdapter
    Friend WithEvents DataSet2 As SIMS.DataSet2
    Friend WithEvents GetmajorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Get_majorTableAdapter As SIMS.DataSet2TableAdapters.get_majorTableAdapter
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboTrack As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboBalikAral As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cbo4Ps As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cboIP As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cboTransferee As System.Windows.Forms.ComboBox
    Friend WithEvents cboRepeater As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents cboQualification As System.Windows.Forms.ComboBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents lblAdviser As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents lblSettingsID As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents lblAdviserID As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lvCOR As System.Windows.Forms.ListView
    Friend WithEvents btnAddSubject As System.Windows.Forms.Button
    Friend WithEvents btnRemoveSubjects As System.Windows.Forms.Button
    Friend WithEvents btnLoadSubjects As System.Windows.Forms.Button
    Friend WithEvents txtTotalUnits As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtTotalLab As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalLecUnits As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents btnDropped As System.Windows.Forms.Button
    Friend WithEvents btnTransferredOut As System.Windows.Forms.Button
    Friend WithEvents btnAccecelrated As System.Windows.Forms.Button
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lblSem As System.Windows.Forms.Label
    Friend WithEvents lblSY As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
End Class
