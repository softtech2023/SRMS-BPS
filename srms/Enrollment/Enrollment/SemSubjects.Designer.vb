<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSemSubjects
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSemSubjects))
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtInstructor = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtInstructorName = New System.Windows.Forms.TextBox
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtRoom = New System.Windows.Forms.ComboBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.lblID = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboSection = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtSlot = New System.Windows.Forms.TextBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.cboTime1 = New System.Windows.Forms.ComboBox
        Me.cboAM1 = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cboTime2 = New System.Windows.Forms.ComboBox
        Me.cboAM2 = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtDaysLec = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label19 = New System.Windows.Forms.Label
        Me.btnSelect = New System.Windows.Forms.Button
        Me.txtSubjectCode = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtSubjectDescription = New System.Windows.Forms.TextBox
        Me.dgsubjects = New System.Windows.Forms.DataGridView
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.chkDescription = New System.Windows.Forms.CheckBox
        Me.chkSubjectCode = New System.Windows.Forms.CheckBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtsearch = New System.Windows.Forms.TextBox
        Me.txtTime = New System.Windows.Forms.TextBox
        Me.txtLab = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cboCourse = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.cboYearLevel = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.RoomsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet2 = New SIMS.DataSet2
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.SectionsTableAdapter = New SIMS.Reports2TableAdapters.sectionsTableAdapter
        Me.RoomsTableAdapter = New SIMS.Reports2TableAdapters.roomsTableAdapter
        Me.RoomsTableAdapter1 = New SIMS.DataSet2TableAdapters.roomsTableAdapter
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtLabUnits = New System.Windows.Forms.TextBox
        Me.txtLecUnits = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cboTime3 = New System.Windows.Forms.ComboBox
        Me.cboAM3 = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.cboAM4 = New System.Windows.Forms.ComboBox
        Me.txtDaysLab = New System.Windows.Forms.TextBox
        Me.cboTime4 = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.lblSettingsID = New System.Windows.Forms.Label
        Me.tsSave = New System.Windows.Forms.ToolStripButton
        Me.tsUpdate = New System.Windows.Forms.ToolStripButton
        Me.tsDelete = New System.Windows.Forms.ToolStripButton
        Me.tsCopy = New System.Windows.Forms.ToolStripButton
        Me.btnSearchInstructor = New System.Windows.Forms.Button
        Me.SectionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RoomsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgsubjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.RoomsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.SectionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel7.Controls.Add(Me.Label8)
        Me.Panel7.Controls.Add(Me.txtInstructor)
        Me.Panel7.Controls.Add(Me.btnSearchInstructor)
        Me.Panel7.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel7.Location = New System.Drawing.Point(1, 329)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(355, 32)
        Me.Panel7.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(8, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 19)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Teacher's ID"
        '
        'txtInstructor
        '
        Me.txtInstructor.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtInstructor.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInstructor.ForeColor = System.Drawing.Color.Black
        Me.txtInstructor.Location = New System.Drawing.Point(93, 3)
        Me.txtInstructor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtInstructor.Name = "txtInstructor"
        Me.txtInstructor.ReadOnly = True
        Me.txtInstructor.Size = New System.Drawing.Size(225, 26)
        Me.txtInstructor.TabIndex = 18
        Me.txtInstructor.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(43, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 19)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Name"
        '
        'txtInstructorName
        '
        Me.txtInstructorName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtInstructorName.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInstructorName.ForeColor = System.Drawing.Color.Black
        Me.txtInstructorName.Location = New System.Drawing.Point(93, 3)
        Me.txtInstructorName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtInstructorName.Name = "txtInstructorName"
        Me.txtInstructorName.ReadOnly = True
        Me.txtInstructorName.Size = New System.Drawing.Size(257, 26)
        Me.txtInstructorName.TabIndex = 28
        Me.txtInstructorName.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.txtRoom)
        Me.Panel6.Controls.Add(Me.btnCancel)
        Me.Panel6.Controls.Add(Me.lblID)
        Me.Panel6.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(0, 286)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(355, 32)
        Me.Panel6.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(45, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Room"
        '
        'txtRoom
        '
        Me.txtRoom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtRoom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtRoom.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoom.FormattingEnabled = True
        Me.txtRoom.Location = New System.Drawing.Point(93, 2)
        Me.txtRoom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRoom.Name = "txtRoom"
        Me.txtRoom.Size = New System.Drawing.Size(257, 27)
        Me.txtRoom.TabIndex = 13
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(153, 3)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(68, 22)
        Me.btnCancel.TabIndex = 30
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.Color.Black
        Me.lblID.Location = New System.Drawing.Point(12, 6)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(22, 19)
        Me.lblID.TabIndex = 16
        Me.lblID.Text = "ID"
        Me.lblID.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(41, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 19)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Section"
        '
        'cboSection
        '
        Me.cboSection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSection.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSection.FormattingEnabled = True
        Me.cboSection.Location = New System.Drawing.Point(93, 2)
        Me.cboSection.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboSection.Name = "cboSection"
        Me.cboSection.Size = New System.Drawing.Size(259, 27)
        Me.cboSection.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(455, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 19)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Slot"
        Me.Label9.Visible = False
        '
        'txtSlot
        '
        Me.txtSlot.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtSlot.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSlot.ForeColor = System.Drawing.Color.Black
        Me.txtSlot.Location = New System.Drawing.Point(491, 79)
        Me.txtSlot.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSlot.Name = "txtSlot"
        Me.txtSlot.Size = New System.Drawing.Size(49, 26)
        Me.txtSlot.TabIndex = 6
        Me.txtSlot.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.cboTime1)
        Me.Panel3.Controls.Add(Me.cboAM1)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.cboTime2)
        Me.Panel3.Controls.Add(Me.cboAM2)
        Me.Panel3.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(0, 209)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(355, 32)
        Me.Panel3.TabIndex = 5
        Me.Panel3.TabStop = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(10, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Class Sched"
        '
        'cboTime1
        '
        Me.cboTime1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboTime1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTime1.FormattingEnabled = True
        Me.cboTime1.Items.AddRange(New Object() {"1:00", "1:30", "2:00", "2:30", "3:00", "3:30", "4:00", "4:30", "5:00", "5:30", "6:00", "6:30", "7:00", "7:30", "8:00", "8:30", "9:00", "9:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30"})
        Me.cboTime1.Location = New System.Drawing.Point(93, 1)
        Me.cboTime1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboTime1.Name = "cboTime1"
        Me.cboTime1.Size = New System.Drawing.Size(57, 27)
        Me.cboTime1.TabIndex = 6
        '
        'cboAM1
        '
        Me.cboAM1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboAM1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAM1.FormattingEnabled = True
        Me.cboAM1.Items.AddRange(New Object() {"AM", "PM"})
        Me.cboAM1.Location = New System.Drawing.Point(156, 2)
        Me.cboAM1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboAM1.Name = "cboAM1"
        Me.cboAM1.Size = New System.Drawing.Size(55, 27)
        Me.cboAM1.Sorted = True
        Me.cboAM1.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(215, 5)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(14, 19)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "-"
        '
        'cboTime2
        '
        Me.cboTime2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboTime2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTime2.FormattingEnabled = True
        Me.cboTime2.Items.AddRange(New Object() {"1:00", "1:30", "2:00", "2:30", "3:00", "3:30", "4:00", "4:30", "5:00", "5:30", "6:00", "6:30", "7:00", "7:30", "8:00", "8:30", "9:00", "9:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30"})
        Me.cboTime2.Location = New System.Drawing.Point(231, 1)
        Me.cboTime2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboTime2.Name = "cboTime2"
        Me.cboTime2.Size = New System.Drawing.Size(55, 27)
        Me.cboTime2.TabIndex = 8
        '
        'cboAM2
        '
        Me.cboAM2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboAM2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAM2.FormattingEnabled = True
        Me.cboAM2.Items.AddRange(New Object() {"AM", "PM"})
        Me.cboAM2.Location = New System.Drawing.Point(292, 2)
        Me.cboAM2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboAM2.Name = "cboAM2"
        Me.cboAM2.Size = New System.Drawing.Size(60, 27)
        Me.cboAM2.Sorted = True
        Me.cboAM2.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(50, 6)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 19)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Days"
        '
        'txtDaysLec
        '
        Me.txtDaysLec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDaysLec.Location = New System.Drawing.Point(93, 3)
        Me.txtDaysLec.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDaysLec.Name = "txtDaysLec"
        Me.txtDaysLec.Size = New System.Drawing.Size(257, 26)
        Me.txtDaysLec.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.btnSelect)
        Me.Panel2.Controls.Add(Me.txtSubjectCode)
        Me.Panel2.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 132)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(355, 32)
        Me.Panel2.TabIndex = 1
        Me.Panel2.TabStop = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(6, 5)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(83, 19)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "Subject Code"
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(282, 1)
        Me.btnSelect.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(70, 28)
        Me.btnSelect.TabIndex = 3
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'txtSubjectCode
        '
        Me.txtSubjectCode.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtSubjectCode.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubjectCode.ForeColor = System.Drawing.Color.Black
        Me.txtSubjectCode.Location = New System.Drawing.Point(93, 3)
        Me.txtSubjectCode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSubjectCode.Name = "txtSubjectCode"
        Me.txtSubjectCode.ReadOnly = True
        Me.txtSubjectCode.Size = New System.Drawing.Size(183, 26)
        Me.txtSubjectCode.TabIndex = 2
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(16, 5)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(73, 19)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Description"
        '
        'txtSubjectDescription
        '
        Me.txtSubjectDescription.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtSubjectDescription.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubjectDescription.ForeColor = System.Drawing.Color.Black
        Me.txtSubjectDescription.Location = New System.Drawing.Point(93, 2)
        Me.txtSubjectDescription.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSubjectDescription.Name = "txtSubjectDescription"
        Me.txtSubjectDescription.ReadOnly = True
        Me.txtSubjectDescription.Size = New System.Drawing.Size(259, 26)
        Me.txtSubjectDescription.TabIndex = 4
        '
        'dgsubjects
        '
        Me.dgsubjects.AllowUserToAddRows = False
        Me.dgsubjects.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgsubjects.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgsubjects.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgsubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgsubjects.Location = New System.Drawing.Point(364, 149)
        Me.dgsubjects.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgsubjects.Name = "dgsubjects"
        Me.dgsubjects.ReadOnly = True
        Me.dgsubjects.Size = New System.Drawing.Size(739, 343)
        Me.dgsubjects.TabIndex = 19
        Me.dgsubjects.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel5.Controls.Add(Me.chkDescription)
        Me.Panel5.Controls.Add(Me.chkSubjectCode)
        Me.Panel5.Controls.Add(Me.Button1)
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.Controls.Add(Me.txtsearch)
        Me.Panel5.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(364, 107)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(739, 34)
        Me.Panel5.TabIndex = 17
        '
        'chkDescription
        '
        Me.chkDescription.AutoSize = True
        Me.chkDescription.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDescription.ForeColor = System.Drawing.Color.White
        Me.chkDescription.Location = New System.Drawing.Point(512, 5)
        Me.chkDescription.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkDescription.Name = "chkDescription"
        Me.chkDescription.Size = New System.Drawing.Size(108, 26)
        Me.chkDescription.TabIndex = 26
        Me.chkDescription.TabStop = False
        Me.chkDescription.Text = "Description"
        Me.chkDescription.UseVisualStyleBackColor = True
        '
        'chkSubjectCode
        '
        Me.chkSubjectCode.AutoSize = True
        Me.chkSubjectCode.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSubjectCode.ForeColor = System.Drawing.Color.White
        Me.chkSubjectCode.Location = New System.Drawing.Point(397, 5)
        Me.chkSubjectCode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkSubjectCode.Name = "chkSubjectCode"
        Me.chkSubjectCode.Size = New System.Drawing.Size(118, 26)
        Me.chkSubjectCode.TabIndex = 25
        Me.chkSubjectCode.TabStop = False
        Me.chkSubjectCode.Text = "Subject Code"
        Me.chkSubjectCode.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button1.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(645, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 30)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "View"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(164, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 19)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Search"
        '
        'txtsearch
        '
        Me.txtsearch.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtsearch.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtsearch.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.ForeColor = System.Drawing.Color.Black
        Me.txtsearch.Location = New System.Drawing.Point(218, 5)
        Me.txtsearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(166, 26)
        Me.txtsearch.TabIndex = 18
        Me.txtsearch.TabStop = False
        '
        'txtTime
        '
        Me.txtTime.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtTime.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTime.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime.ForeColor = System.Drawing.Color.Black
        Me.txtTime.Location = New System.Drawing.Point(27, 16)
        Me.txtTime.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTime.Multiline = True
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(70, 36)
        Me.txtTime.TabIndex = 8
        Me.txtTime.Visible = False
        '
        'txtLab
        '
        Me.txtLab.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtLab.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLab.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLab.ForeColor = System.Drawing.Color.Black
        Me.txtLab.Location = New System.Drawing.Point(141, 16)
        Me.txtLab.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLab.Multiline = True
        Me.txtLab.Name = "txtLab"
        Me.txtLab.Size = New System.Drawing.Size(70, 36)
        Me.txtLab.TabIndex = 9
        Me.txtLab.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cboCourse)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(1, 21)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(355, 32)
        Me.Panel1.TabIndex = 13
        '
        'cboCourse
        '
        Me.cboCourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboCourse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCourse.FormattingEnabled = True
        Me.cboCourse.Location = New System.Drawing.Point(93, 2)
        Me.cboCourse.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboCourse.Name = "cboCourse"
        Me.cboCourse.Size = New System.Drawing.Size(259, 27)
        Me.cboCourse.TabIndex = 1
        Me.cboCourse.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(12, 6)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(77, 19)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Department"
        '
        'cboYearLevel
        '
        Me.cboYearLevel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboYearLevel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboYearLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYearLevel.FormattingEnabled = True
        Me.cboYearLevel.Location = New System.Drawing.Point(93, 2)
        Me.cboYearLevel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboYearLevel.Name = "cboYearLevel"
        Me.cboYearLevel.Size = New System.Drawing.Size(259, 27)
        Me.cboYearLevel.TabIndex = 3
        Me.cboYearLevel.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(10, 6)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(77, 19)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Grade Level"
        '
        'RoomsBindingSource1
        '
        Me.RoomsBindingSource1.DataMember = "rooms"
        Me.RoomsBindingSource1.DataSource = Me.DataSet2
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "DataSet2"
        Me.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsSave, Me.tsUpdate, Me.tsDelete, Me.tsCopy})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1103, 74)
        Me.ToolStrip1.TabIndex = 65
        '
        'SectionsTableAdapter
        '
        Me.SectionsTableAdapter.ClearBeforeFill = True
        '
        'RoomsTableAdapter
        '
        Me.RoomsTableAdapter.ClearBeforeFill = True
        '
        'RoomsTableAdapter1
        '
        Me.RoomsTableAdapter1.ClearBeforeFill = True
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel8.Controls.Add(Me.Label18)
        Me.Panel8.Controls.Add(Me.txtSubjectDescription)
        Me.Panel8.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel8.Location = New System.Drawing.Point(0, 169)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(355, 32)
        Me.Panel8.TabIndex = 36
        Me.Panel8.TabStop = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtTime)
        Me.GroupBox3.Controls.Add(Me.txtLab)
        Me.GroupBox3.Location = New System.Drawing.Point(240, -6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(111, 24)
        Me.GroupBox3.TabIndex = 66
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "hidden"
        Me.GroupBox3.Visible = False
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel9.Controls.Add(Me.Label5)
        Me.Panel9.Controls.Add(Me.txtInstructorName)
        Me.Panel9.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel9.Location = New System.Drawing.Point(1, 369)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(355, 32)
        Me.Panel9.TabIndex = 27
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtLabUnits)
        Me.GroupBox2.Controls.Add(Me.txtLecUnits)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Panel4)
        Me.GroupBox2.Location = New System.Drawing.Point(656, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(154, 134)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Hidden Controls"
        Me.GroupBox2.Visible = False
        '
        'txtLabUnits
        '
        Me.txtLabUnits.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtLabUnits.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLabUnits.ForeColor = System.Drawing.Color.Black
        Me.txtLabUnits.Location = New System.Drawing.Point(66, 73)
        Me.txtLabUnits.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLabUnits.Name = "txtLabUnits"
        Me.txtLabUnits.ReadOnly = True
        Me.txtLabUnits.Size = New System.Drawing.Size(46, 26)
        Me.txtLabUnits.TabIndex = 6
        '
        'txtLecUnits
        '
        Me.txtLecUnits.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtLecUnits.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLecUnits.ForeColor = System.Drawing.Color.Black
        Me.txtLecUnits.Location = New System.Drawing.Point(66, 101)
        Me.txtLecUnits.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLecUnits.Name = "txtLecUnits"
        Me.txtLecUnits.ReadOnly = True
        Me.txtLecUnits.Size = New System.Drawing.Size(46, 26)
        Me.txtLecUnits.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(22, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Units"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(21, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Lab"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label20)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.cboTime3)
        Me.Panel4.Controls.Add(Me.cboAM3)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.cboAM4)
        Me.Panel4.Controls.Add(Me.txtDaysLab)
        Me.Panel4.Controls.Add(Me.cboTime4)
        Me.Panel4.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(15, 26)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(650, 32)
        Me.Panel4.TabIndex = 14
        Me.Panel4.TabStop = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(458, 7)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(37, 19)
        Me.Label20.TabIndex = 35
        Me.Label20.Text = "Days"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(6, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Lab Sched "
        '
        'cboTime3
        '
        Me.cboTime3.FormattingEnabled = True
        Me.cboTime3.Items.AddRange(New Object() {"1:00", "1:30", "2:00", "2:30", "3:00", "3:30", "4:00", "4:30", "5:00", "5:30", "6:00", "6:30", "7:00", "7:30", "8:00", "8:30", "9:00", "9:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30"})
        Me.cboTime3.Location = New System.Drawing.Point(95, 2)
        Me.cboTime3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboTime3.Name = "cboTime3"
        Me.cboTime3.Size = New System.Drawing.Size(77, 27)
        Me.cboTime3.TabIndex = 15
        '
        'cboAM3
        '
        Me.cboAM3.FormattingEnabled = True
        Me.cboAM3.Items.AddRange(New Object() {"AM", "PM"})
        Me.cboAM3.Location = New System.Drawing.Point(178, 2)
        Me.cboAM3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboAM3.Name = "cboAM3"
        Me.cboAM3.Size = New System.Drawing.Size(77, 27)
        Me.cboAM3.Sorted = True
        Me.cboAM3.TabIndex = 16
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(261, 5)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(14, 19)
        Me.Label15.TabIndex = 54
        Me.Label15.Text = "-"
        '
        'cboAM4
        '
        Me.cboAM4.FormattingEnabled = True
        Me.cboAM4.Items.AddRange(New Object() {"AM", "PM"})
        Me.cboAM4.Location = New System.Drawing.Point(364, 4)
        Me.cboAM4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboAM4.Name = "cboAM4"
        Me.cboAM4.Size = New System.Drawing.Size(77, 27)
        Me.cboAM4.Sorted = True
        Me.cboAM4.TabIndex = 18
        '
        'txtDaysLab
        '
        Me.txtDaysLab.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDaysLab.Location = New System.Drawing.Point(501, 3)
        Me.txtDaysLab.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDaysLab.Name = "txtDaysLab"
        Me.txtDaysLab.Size = New System.Drawing.Size(145, 26)
        Me.txtDaysLab.TabIndex = 19
        '
        'cboTime4
        '
        Me.cboTime4.FormattingEnabled = True
        Me.cboTime4.Items.AddRange(New Object() {"1:00", "1:30", "2:00", "2:30", "3:00", "3:30", "4:00", "4:30", "5:00", "5:30", "6:00", "6:30", "7:00", "7:30", "8:00", "8:30", "9:00", "9:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30"})
        Me.cboTime4.Location = New System.Drawing.Point(281, 3)
        Me.cboTime4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboTime4.Name = "cboTime4"
        Me.cboTime4.Size = New System.Drawing.Size(77, 27)
        Me.cboTime4.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Panel12)
        Me.GroupBox1.Controls.Add(Me.Panel11)
        Me.GroupBox1.Controls.Add(Me.Panel10)
        Me.GroupBox1.Controls.Add(Me.Panel9)
        Me.GroupBox1.Controls.Add(Me.Panel8)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Panel7)
        Me.GroupBox1.Controls.Add(Me.Panel6)
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 85)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(358, 410)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel12.Controls.Add(Me.cboYearLevel)
        Me.Panel12.Controls.Add(Me.Label17)
        Me.Panel12.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel12.Location = New System.Drawing.Point(1, 58)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(355, 32)
        Me.Panel12.TabIndex = 14
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel11.Controls.Add(Me.txtDaysLec)
        Me.Panel11.Controls.Add(Me.Label13)
        Me.Panel11.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel11.Location = New System.Drawing.Point(0, 246)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(355, 32)
        Me.Panel11.TabIndex = 10
        Me.Panel11.TabStop = True
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel10.Controls.Add(Me.Label3)
        Me.Panel10.Controls.Add(Me.cboSection)
        Me.Panel10.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel10.Location = New System.Drawing.Point(1, 95)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(355, 32)
        Me.Panel10.TabIndex = 4
        '
        'lblSettingsID
        '
        Me.lblSettingsID.AutoSize = True
        Me.lblSettingsID.Location = New System.Drawing.Point(11, 499)
        Me.lblSettingsID.Name = "lblSettingsID"
        Me.lblSettingsID.Size = New System.Drawing.Size(67, 19)
        Me.lblSettingsID.TabIndex = 66
        Me.lblSettingsID.Text = "SettingsID"
        Me.lblSettingsID.Visible = False
        '
        'tsSave
        '
        Me.tsSave.Image = CType(resources.GetObject("tsSave.Image"), System.Drawing.Image)
        Me.tsSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSave.Name = "tsSave"
        Me.tsSave.Size = New System.Drawing.Size(52, 71)
        Me.tsSave.Text = "Save"
        Me.tsSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsUpdate
        '
        Me.tsUpdate.Image = CType(resources.GetObject("tsUpdate.Image"), System.Drawing.Image)
        Me.tsUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsUpdate.Name = "tsUpdate"
        Me.tsUpdate.Size = New System.Drawing.Size(54, 71)
        Me.tsUpdate.Text = "Update"
        Me.tsUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsDelete
        '
        Me.tsDelete.Image = CType(resources.GetObject("tsDelete.Image"), System.Drawing.Image)
        Me.tsDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDelete.Name = "tsDelete"
        Me.tsDelete.Size = New System.Drawing.Size(52, 71)
        Me.tsDelete.Text = "Delete"
        Me.tsDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsCopy
        '
        Me.tsCopy.Image = Global.SIMS.My.Resources.Resources.copy_icon
        Me.tsCopy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsCopy.Name = "tsCopy"
        Me.tsCopy.Size = New System.Drawing.Size(96, 71)
        Me.tsCopy.Text = "Copy Schedule"
        Me.tsCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnSearchInstructor
        '
        Me.btnSearchInstructor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearchInstructor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchInstructor.Image = CType(resources.GetObject("btnSearchInstructor.Image"), System.Drawing.Image)
        Me.btnSearchInstructor.Location = New System.Drawing.Point(324, 2)
        Me.btnSearchInstructor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSearchInstructor.Name = "btnSearchInstructor"
        Me.btnSearchInstructor.Size = New System.Drawing.Size(28, 29)
        Me.btnSearchInstructor.TabIndex = 26
        Me.btnSearchInstructor.UseVisualStyleBackColor = True
        '
        'frmSemSubjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(1103, 528)
        Me.Controls.Add(Me.lblSettingsID)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtSlot)
        Me.Controls.Add(Me.dgsubjects)
        Me.Controls.Add(Me.Panel5)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmSemSubjects"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "[  Scheduling Form  ]"
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgsubjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.RoomsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        CType(Me.SectionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtInstructor As System.Windows.Forms.TextBox
    Friend WithEvents txtSlot As System.Windows.Forms.TextBox
    Friend WithEvents txtLab As System.Windows.Forms.TextBox
    Friend WithEvents txtSubjectDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtSubjectCode As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchInstructor As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents dgsubjects As System.Windows.Forms.DataGridView
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents txtInstructorName As System.Windows.Forms.TextBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtDaysLec As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cboTime1 As System.Windows.Forms.ComboBox
    Friend WithEvents cboAM1 As System.Windows.Forms.ComboBox
    Friend WithEvents cboAM2 As System.Windows.Forms.ComboBox
    Friend WithEvents cboTime2 As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsUpdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cboYearLevel As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cboCourse As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents cboSection As System.Windows.Forms.ComboBox
    Friend WithEvents SectionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SectionsTableAdapter As SIMS.Reports2TableAdapters.sectionsTableAdapter
    Friend WithEvents txtRoom As System.Windows.Forms.ComboBox
    Friend WithEvents RoomsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RoomsTableAdapter As SIMS.Reports2TableAdapters.roomsTableAdapter
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataSet2 As SIMS.DataSet2
    Friend WithEvents RoomsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents RoomsTableAdapter1 As SIMS.DataSet2TableAdapters.roomsTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtLabUnits As System.Windows.Forms.TextBox
    Friend WithEvents txtLecUnits As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboTime3 As System.Windows.Forms.ComboBox
    Friend WithEvents cboAM3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cboAM4 As System.Windows.Forms.ComboBox
    Friend WithEvents txtDaysLab As System.Windows.Forms.TextBox
    Friend WithEvents cboTime4 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents chkDescription As System.Windows.Forms.CheckBox
    Friend WithEvents chkSubjectCode As System.Windows.Forms.CheckBox
    Friend WithEvents lblSettingsID As System.Windows.Forms.Label
    Friend WithEvents tsCopy As System.Windows.Forms.ToolStripButton
End Class
