<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBilling
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBilling))
        Me.lblID = New System.Windows.Forms.Label
        Me.txtOldAccount = New System.Windows.Forms.TextBox
        Me.txtLabRate = New System.Windows.Forms.TextBox
        Me.txtLecRate = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtPayments = New System.Windows.Forms.TextBox
        Me.txtTotalLabUnits = New System.Windows.Forms.TextBox
        Me.txtTotalLecUnits = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtTotalAcct = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtTuition = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtLab = New System.Windows.Forms.TextBox
        Me.btnCompute = New System.Windows.Forms.Button
        Me.cboYear = New System.Windows.Forms.ComboBox
        Me.cboStatus = New System.Windows.Forms.ComboBox
        Me.cboCourse = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.txtFname = New System.Windows.Forms.TextBox
        Me.txtMName = New System.Windows.Forms.TextBox
        Me.txtTotalFees = New System.Windows.Forms.TextBox
        Me.txtBalance = New System.Windows.Forms.TextBox
        Me.lvAccts = New System.Windows.Forms.ListView
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.btnRemoveFees = New System.Windows.Forms.Button
        Me.btnAddFees = New System.Windows.Forms.Button
        Me.mskStudentNumber = New System.Windows.Forms.TextBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lblSettingsID = New System.Windows.Forms.Label
        Me.Panel20 = New System.Windows.Forms.Panel
        Me.Label28 = New System.Windows.Forms.Label
        Me.Panel15 = New System.Windows.Forms.Panel
        Me.btnOldAcct = New System.Windows.Forms.Button
        Me.Panel14 = New System.Windows.Forms.Panel
        Me.Label15 = New System.Windows.Forms.Label
        Me.Panel13 = New System.Windows.Forms.Panel
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.Label19 = New System.Windows.Forms.Label
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtDiscount = New System.Windows.Forms.TextBox
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.cboPaymentMode = New System.Windows.Forms.ComboBox
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.txtSection = New System.Windows.Forms.TextBox
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtDiscountPercentage = New System.Windows.Forms.TextBox
        Me.lblMajor = New System.Windows.Forms.Label
        Me.lblEnrolled = New System.Windows.Forms.Label
        Me.txtInstallmentFee = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtRegFee = New System.Windows.Forms.TextBox
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.txtTotalAdditional = New System.Windows.Forms.Label
        Me.Panel19 = New System.Windows.Forms.Panel
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.txtAmount5 = New System.Windows.Forms.TextBox
        Me.txtDesc5 = New System.Windows.Forms.TextBox
        Me.Panel18 = New System.Windows.Forms.Panel
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtDesc4 = New System.Windows.Forms.TextBox
        Me.txtAmount4 = New System.Windows.Forms.TextBox
        Me.Panel17 = New System.Windows.Forms.Panel
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtDesc3 = New System.Windows.Forms.TextBox
        Me.txtAmount3 = New System.Windows.Forms.TextBox
        Me.Panel16 = New System.Windows.Forms.Panel
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtDesc2 = New System.Windows.Forms.TextBox
        Me.txtAmount2 = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtDesc1 = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtAmount1 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblDiscTotal = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.txtDiscAmount5 = New System.Windows.Forms.TextBox
        Me.Label37 = New System.Windows.Forms.Label
        Me.txtDisc5 = New System.Windows.Forms.TextBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.txtDiscAmount4 = New System.Windows.Forms.TextBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.txtDisc4 = New System.Windows.Forms.TextBox
        Me.Label40 = New System.Windows.Forms.Label
        Me.txtDiscAmount3 = New System.Windows.Forms.TextBox
        Me.Label41 = New System.Windows.Forms.Label
        Me.txtDisc3 = New System.Windows.Forms.TextBox
        Me.Label42 = New System.Windows.Forms.Label
        Me.txtDiscAmount2 = New System.Windows.Forms.TextBox
        Me.Label43 = New System.Windows.Forms.Label
        Me.txtDisc2 = New System.Windows.Forms.TextBox
        Me.Label44 = New System.Windows.Forms.Label
        Me.txtDiscAmount1 = New System.Windows.Forms.TextBox
        Me.Label45 = New System.Windows.Forms.Label
        Me.txtDisc1 = New System.Windows.Forms.TextBox
        Me.Panel21 = New System.Windows.Forms.Panel
        Me.Label46 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tsNew = New System.Windows.Forms.ToolStripButton
        Me.tsSave = New System.Windows.Forms.ToolStripButton
        Me.tsUpdate = New System.Windows.Forms.ToolStripButton
        Me.tsDelete = New System.Windows.Forms.ToolStripButton
        Me.tsViewAccounts = New System.Windows.Forms.ToolStripButton
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.BillingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel6.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel19.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel21.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.Color.Black
        Me.lblID.Location = New System.Drawing.Point(281, 28)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(22, 19)
        Me.lblID.TabIndex = 17
        Me.lblID.Text = "ID"
        Me.lblID.Visible = False
        '
        'txtOldAccount
        '
        Me.txtOldAccount.BackColor = System.Drawing.Color.Chartreuse
        Me.txtOldAccount.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOldAccount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtOldAccount.Location = New System.Drawing.Point(191, 0)
        Me.txtOldAccount.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtOldAccount.Multiline = True
        Me.txtOldAccount.Name = "txtOldAccount"
        Me.txtOldAccount.Size = New System.Drawing.Size(118, 31)
        Me.txtOldAccount.TabIndex = 32
        Me.txtOldAccount.TabStop = False
        Me.txtOldAccount.Text = "0"
        Me.txtOldAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLabRate
        '
        Me.txtLabRate.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtLabRate.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLabRate.ForeColor = System.Drawing.Color.Black
        Me.txtLabRate.Location = New System.Drawing.Point(232, 3)
        Me.txtLabRate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLabRate.Name = "txtLabRate"
        Me.txtLabRate.ReadOnly = True
        Me.txtLabRate.Size = New System.Drawing.Size(77, 26)
        Me.txtLabRate.TabIndex = 29
        Me.txtLabRate.TabStop = False
        Me.txtLabRate.Text = "0"
        Me.txtLabRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLecRate
        '
        Me.txtLecRate.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtLecRate.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLecRate.ForeColor = System.Drawing.Color.Black
        Me.txtLecRate.Location = New System.Drawing.Point(232, 4)
        Me.txtLecRate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLecRate.Name = "txtLecRate"
        Me.txtLecRate.ReadOnly = True
        Me.txtLecRate.Size = New System.Drawing.Size(77, 26)
        Me.txtLecRate.TabIndex = 28
        Me.txtLecRate.TabStop = False
        Me.txtLecRate.Text = "0"
        Me.txtLecRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(174, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 19)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Rate"
        '
        'txtPayments
        '
        Me.txtPayments.BackColor = System.Drawing.Color.DarkOrange
        Me.txtPayments.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPayments.ForeColor = System.Drawing.Color.Black
        Me.txtPayments.Location = New System.Drawing.Point(191, 1)
        Me.txtPayments.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPayments.Name = "txtPayments"
        Me.txtPayments.ReadOnly = True
        Me.txtPayments.Size = New System.Drawing.Size(118, 30)
        Me.txtPayments.TabIndex = 19
        Me.txtPayments.TabStop = False
        Me.txtPayments.Text = "0"
        Me.txtPayments.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTotalLabUnits
        '
        Me.txtTotalLabUnits.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtTotalLabUnits.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalLabUnits.ForeColor = System.Drawing.Color.Black
        Me.txtTotalLabUnits.Location = New System.Drawing.Point(91, 4)
        Me.txtTotalLabUnits.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTotalLabUnits.Name = "txtTotalLabUnits"
        Me.txtTotalLabUnits.Size = New System.Drawing.Size(78, 26)
        Me.txtTotalLabUnits.TabIndex = 10
        Me.txtTotalLabUnits.TabStop = False
        Me.txtTotalLabUnits.Text = "0"
        Me.txtTotalLabUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTotalLecUnits
        '
        Me.txtTotalLecUnits.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtTotalLecUnits.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalLecUnits.ForeColor = System.Drawing.Color.Black
        Me.txtTotalLecUnits.Location = New System.Drawing.Point(91, 4)
        Me.txtTotalLecUnits.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTotalLecUnits.Name = "txtTotalLecUnits"
        Me.txtTotalLecUnits.Size = New System.Drawing.Size(77, 26)
        Me.txtTotalLecUnits.TabIndex = 9
        Me.txtTotalLecUnits.TabStop = False
        Me.txtTotalLecUnits.Text = "0"
        Me.txtTotalLecUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(12, 10)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(62, 19)
        Me.Label24.TabIndex = 23
        Me.Label24.Text = "Lab Units"
        '
        'txtTotalAcct
        '
        Me.txtTotalAcct.BackColor = System.Drawing.Color.Chartreuse
        Me.txtTotalAcct.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAcct.ForeColor = System.Drawing.Color.Black
        Me.txtTotalAcct.Location = New System.Drawing.Point(191, 1)
        Me.txtTotalAcct.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTotalAcct.Name = "txtTotalAcct"
        Me.txtTotalAcct.Size = New System.Drawing.Size(118, 30)
        Me.txtTotalAcct.TabIndex = 18
        Me.txtTotalAcct.TabStop = False
        Me.txtTotalAcct.Text = "0"
        Me.txtTotalAcct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(14, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 19)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Tuition Fee"
        '
        'txtTuition
        '
        Me.txtTuition.BackColor = System.Drawing.Color.White
        Me.txtTuition.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTuition.ForeColor = System.Drawing.Color.Black
        Me.txtTuition.Location = New System.Drawing.Point(91, 1)
        Me.txtTuition.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTuition.Name = "txtTuition"
        Me.txtTuition.Size = New System.Drawing.Size(77, 30)
        Me.txtTuition.TabIndex = 11
        Me.txtTuition.TabStop = False
        Me.txtTuition.Text = "0"
        Me.txtTuition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(174, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 19)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Lab Fee"
        '
        'txtLab
        '
        Me.txtLab.BackColor = System.Drawing.Color.White
        Me.txtLab.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLab.ForeColor = System.Drawing.Color.Black
        Me.txtLab.Location = New System.Drawing.Point(232, 1)
        Me.txtLab.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLab.Name = "txtLab"
        Me.txtLab.Size = New System.Drawing.Size(77, 30)
        Me.txtLab.TabIndex = 12
        Me.txtLab.TabStop = False
        Me.txtLab.Text = "0"
        Me.txtLab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCompute
        '
        Me.btnCompute.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.ForeColor = System.Drawing.Color.Black
        Me.btnCompute.Location = New System.Drawing.Point(406, 2)
        Me.btnCompute.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(122, 42)
        Me.btnCompute.TabIndex = 21
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'cboYear
        '
        Me.cboYear.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.cboYear.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYear.ForeColor = System.Drawing.Color.Black
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Location = New System.Drawing.Point(99, 3)
        Me.cboYear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(139, 27)
        Me.cboYear.TabIndex = 6
        Me.cboYear.TabStop = False
        '
        'cboStatus
        '
        Me.cboStatus.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.cboStatus.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatus.ForeColor = System.Drawing.Color.Black
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Paying", "Scholar"})
        Me.cboStatus.Location = New System.Drawing.Point(66, 98)
        Me.cboStatus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(61, 27)
        Me.cboStatus.TabIndex = 7
        Me.cboStatus.TabStop = False
        '
        'cboCourse
        '
        Me.cboCourse.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.cboCourse.DisplayMember = "coursedescription"
        Me.cboCourse.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCourse.ForeColor = System.Drawing.Color.Black
        Me.cboCourse.FormattingEnabled = True
        Me.cboCourse.Location = New System.Drawing.Point(99, 4)
        Me.cboCourse.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboCourse.Name = "cboCourse"
        Me.cboCourse.Size = New System.Drawing.Size(429, 27)
        Me.cboCourse.TabIndex = 5
        Me.cboCourse.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(8, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 19)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Status"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(17, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Student No."
        '
        'txtLastName
        '
        Me.txtLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLastName.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.ForeColor = System.Drawing.Color.Black
        Me.txtLastName.Location = New System.Drawing.Point(389, 4)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.ReadOnly = True
        Me.txtLastName.Size = New System.Drawing.Size(139, 26)
        Me.txtLastName.TabIndex = 4
        Me.txtLastName.TabStop = False
        '
        'txtFname
        '
        Me.txtFname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFname.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFname.ForeColor = System.Drawing.Color.Black
        Me.txtFname.Location = New System.Drawing.Point(99, 4)
        Me.txtFname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.ReadOnly = True
        Me.txtFname.Size = New System.Drawing.Size(139, 26)
        Me.txtFname.TabIndex = 2
        Me.txtFname.TabStop = False
        '
        'txtMName
        '
        Me.txtMName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMName.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMName.ForeColor = System.Drawing.Color.Black
        Me.txtMName.Location = New System.Drawing.Point(244, 4)
        Me.txtMName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMName.Name = "txtMName"
        Me.txtMName.ReadOnly = True
        Me.txtMName.Size = New System.Drawing.Size(139, 26)
        Me.txtMName.TabIndex = 3
        Me.txtMName.TabStop = False
        '
        'txtTotalFees
        '
        Me.txtTotalFees.BackColor = System.Drawing.Color.Chartreuse
        Me.txtTotalFees.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalFees.ForeColor = System.Drawing.Color.Black
        Me.txtTotalFees.Location = New System.Drawing.Point(191, 2)
        Me.txtTotalFees.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTotalFees.Name = "txtTotalFees"
        Me.txtTotalFees.Size = New System.Drawing.Size(118, 30)
        Me.txtTotalFees.TabIndex = 23
        Me.txtTotalFees.TabStop = False
        Me.txtTotalFees.Text = "0"
        Me.txtTotalFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBalance
        '
        Me.txtBalance.BackColor = System.Drawing.Color.Chartreuse
        Me.txtBalance.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalance.ForeColor = System.Drawing.Color.Black
        Me.txtBalance.Location = New System.Drawing.Point(191, 1)
        Me.txtBalance.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.Size = New System.Drawing.Size(118, 30)
        Me.txtBalance.TabIndex = 39
        Me.txtBalance.TabStop = False
        Me.txtBalance.Text = "0"
        Me.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lvAccts
        '
        Me.lvAccts.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvAccts.ForeColor = System.Drawing.Color.Black
        Me.lvAccts.Location = New System.Drawing.Point(0, 228)
        Me.lvAccts.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lvAccts.Name = "lvAccts"
        Me.lvAccts.Size = New System.Drawing.Size(532, 267)
        Me.lvAccts.TabIndex = 20
        Me.lvAccts.TabStop = False
        Me.lvAccts.UseCompatibleStateImageBehavior = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel6.Controls.Add(Me.btnRemoveFees)
        Me.Panel6.Controls.Add(Me.btnAddFees)
        Me.Panel6.Controls.Add(Me.btnCompute)
        Me.Panel6.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.ForeColor = System.Drawing.Color.Black
        Me.Panel6.Location = New System.Drawing.Point(0, 177)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(532, 47)
        Me.Panel6.TabIndex = 19
        '
        'btnRemoveFees
        '
        Me.btnRemoveFees.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveFees.Location = New System.Drawing.Point(278, 2)
        Me.btnRemoveFees.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRemoveFees.Name = "btnRemoveFees"
        Me.btnRemoveFees.Size = New System.Drawing.Size(122, 42)
        Me.btnRemoveFees.TabIndex = 2
        Me.btnRemoveFees.Text = "Remove Fees"
        Me.btnRemoveFees.UseVisualStyleBackColor = True
        '
        'btnAddFees
        '
        Me.btnAddFees.Location = New System.Drawing.Point(150, 2)
        Me.btnAddFees.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAddFees.Name = "btnAddFees"
        Me.btnAddFees.Size = New System.Drawing.Size(122, 42)
        Me.btnAddFees.TabIndex = 1
        Me.btnAddFees.Text = "Add Fees"
        Me.btnAddFees.UseVisualStyleBackColor = True
        '
        'mskStudentNumber
        '
        Me.mskStudentNumber.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskStudentNumber.Location = New System.Drawing.Point(99, 3)
        Me.mskStudentNumber.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.mskStudentNumber.Name = "mskStudentNumber"
        Me.mskStudentNumber.ReadOnly = True
        Me.mskStudentNumber.Size = New System.Drawing.Size(139, 26)
        Me.mskStudentNumber.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(2, 64)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(873, 532)
        Me.TabControl1.TabIndex = 22
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.Panel9)
        Me.TabPage1.Controls.Add(Me.Panel5)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.Panel8)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.lblID)
        Me.TabPage1.Controls.Add(Me.lvAccts)
        Me.TabPage1.Controls.Add(Me.Panel6)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage1.Size = New System.Drawing.Size(865, 500)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Account Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblSettingsID)
        Me.GroupBox3.Controls.Add(Me.Panel20)
        Me.GroupBox3.Controls.Add(Me.Panel15)
        Me.GroupBox3.Controls.Add(Me.Panel14)
        Me.GroupBox3.Controls.Add(Me.Panel13)
        Me.GroupBox3.Controls.Add(Me.Label36)
        Me.GroupBox3.Controls.Add(Me.Panel12)
        Me.GroupBox3.Controls.Add(Me.Panel11)
        Me.GroupBox3.Controls.Add(Me.Panel4)
        Me.GroupBox3.Controls.Add(Me.cboPaymentMode)
        Me.GroupBox3.Controls.Add(Me.Panel7)
        Me.GroupBox3.Controls.Add(Me.Panel3)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(538, 17)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(321, 478)
        Me.GroupBox3.TabIndex = 61
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Account Summary"
        '
        'lblSettingsID
        '
        Me.lblSettingsID.AutoSize = True
        Me.lblSettingsID.Location = New System.Drawing.Point(167, 16)
        Me.lblSettingsID.Name = "lblSettingsID"
        Me.lblSettingsID.Size = New System.Drawing.Size(67, 19)
        Me.lblSettingsID.TabIndex = 60
        Me.lblSettingsID.Text = "SettingsID"
        Me.lblSettingsID.Visible = False
        '
        'Panel20
        '
        Me.Panel20.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel20.Controls.Add(Me.Label28)
        Me.Panel20.Controls.Add(Me.txtTotalFees)
        Me.Panel20.Location = New System.Drawing.Point(9, 80)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(312, 33)
        Me.Panel20.TabIndex = 58
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(14, 7)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(77, 19)
        Me.Label28.TabIndex = 1
        Me.Label28.Text = "TOTAL FEES"
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel15.Controls.Add(Me.txtOldAccount)
        Me.Panel15.Controls.Add(Me.btnOldAcct)
        Me.Panel15.Location = New System.Drawing.Point(9, 43)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(312, 33)
        Me.Panel15.TabIndex = 58
        '
        'btnOldAcct
        '
        Me.btnOldAcct.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOldAcct.ForeColor = System.Drawing.Color.Black
        Me.btnOldAcct.Location = New System.Drawing.Point(98, 0)
        Me.btnOldAcct.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnOldAcct.Name = "btnOldAcct"
        Me.btnOldAcct.Size = New System.Drawing.Size(87, 30)
        Me.btnOldAcct.TabIndex = 22
        Me.btnOldAcct.TabStop = False
        Me.btnOldAcct.Text = "View Old Acct."
        Me.ToolTip1.SetToolTip(Me.btnOldAcct, "Old Account")
        Me.btnOldAcct.UseVisualStyleBackColor = True
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel14.Controls.Add(Me.Label15)
        Me.Panel14.Controls.Add(Me.txtBalance)
        Me.Panel14.Location = New System.Drawing.Point(6, 441)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(312, 33)
        Me.Panel14.TabIndex = 61
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(14, 7)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(125, 19)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "CURRENT BALANCE"
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel13.Controls.Add(Me.Label12)
        Me.Panel13.Controls.Add(Me.txtPayments)
        Me.Panel13.Location = New System.Drawing.Point(6, 403)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(312, 33)
        Me.Panel13.TabIndex = 60
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(14, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(114, 19)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "TOTAL PAYMENTS"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(22, 249)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(94, 19)
        Me.Label36.TabIndex = 52
        Me.Label36.Text = "Payment Mode"
        Me.Label36.Visible = False
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel12.Controls.Add(Me.Label19)
        Me.Panel12.Controls.Add(Me.txtTotalAcct)
        Me.Panel12.Location = New System.Drawing.Point(6, 325)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(312, 33)
        Me.Panel12.TabIndex = 59
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(14, 7)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(109, 19)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "TOTAL ACCOUNT"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel11.Controls.Add(Me.Label22)
        Me.Panel11.Controls.Add(Me.txtDiscount)
        Me.Panel11.Location = New System.Drawing.Point(6, 364)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(312, 33)
        Me.Panel11.TabIndex = 58
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(14, 7)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 19)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "DISCOUNT"
        '
        'txtDiscount
        '
        Me.txtDiscount.BackColor = System.Drawing.Color.White
        Me.txtDiscount.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.ForeColor = System.Drawing.Color.Black
        Me.txtDiscount.Location = New System.Drawing.Point(191, 1)
        Me.txtDiscount.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(118, 30)
        Me.txtDiscount.TabIndex = 40
        Me.txtDiscount.TabStop = False
        Me.txtDiscount.Text = "0"
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label26)
        Me.Panel4.Controls.Add(Me.Label32)
        Me.Panel4.Controls.Add(Me.txtTotalLecUnits)
        Me.Panel4.Controls.Add(Me.txtLecRate)
        Me.Panel4.Location = New System.Drawing.Point(7, 127)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(312, 33)
        Me.Panel4.TabIndex = 57
        Me.Panel4.Visible = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(14, 7)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(61, 19)
        Me.Label26.TabIndex = 1
        Me.Label26.Text = "Lec Units"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(174, 7)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(35, 19)
        Me.Label32.TabIndex = 2
        Me.Label32.Text = "Rate"
        '
        'cboPaymentMode
        '
        Me.cboPaymentMode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboPaymentMode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPaymentMode.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPaymentMode.FormattingEnabled = True
        Me.cboPaymentMode.Items.AddRange(New Object() {"Full Payment", "Installment"})
        Me.cboPaymentMode.Location = New System.Drawing.Point(135, 243)
        Me.cboPaymentMode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboPaymentMode.Name = "cboPaymentMode"
        Me.cboPaymentMode.Size = New System.Drawing.Size(182, 27)
        Me.cboPaymentMode.TabIndex = 51
        Me.cboPaymentMode.TabStop = False
        Me.cboPaymentMode.Visible = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel7.Controls.Add(Me.Label24)
        Me.Panel7.Controls.Add(Me.txtTotalLabUnits)
        Me.Panel7.Controls.Add(Me.Label8)
        Me.Panel7.Controls.Add(Me.txtLabRate)
        Me.Panel7.Location = New System.Drawing.Point(7, 165)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(312, 33)
        Me.Panel7.TabIndex = 58
        Me.Panel7.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.txtTuition)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.txtLab)
        Me.Panel3.Location = New System.Drawing.Point(7, 204)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(312, 33)
        Me.Panel3.TabIndex = 56
        Me.Panel3.Visible = False
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel9.Controls.Add(Me.Label6)
        Me.Panel9.Controls.Add(Me.cboYear)
        Me.Panel9.Controls.Add(Me.Label34)
        Me.Panel9.Controls.Add(Me.txtSection)
        Me.Panel9.Location = New System.Drawing.Point(0, 137)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(532, 33)
        Me.Panel9.TabIndex = 59
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(17, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 19)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Grade Level"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(333, 7)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(50, 19)
        Me.Label34.TabIndex = 42
        Me.Label34.Text = "Section"
        '
        'txtSection
        '
        Me.txtSection.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSection.Location = New System.Drawing.Point(389, 4)
        Me.txtSection.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.ReadOnly = True
        Me.txtSection.Size = New System.Drawing.Size(139, 26)
        Me.txtSection.TabIndex = 43
        Me.txtSection.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.cboCourse)
        Me.Panel5.Location = New System.Drawing.Point(0, 99)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(532, 33)
        Me.Panel5.TabIndex = 60
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(17, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Department"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtDiscountPercentage)
        Me.GroupBox2.Controls.Add(Me.lblMajor)
        Me.GroupBox2.Controls.Add(Me.lblEnrolled)
        Me.GroupBox2.Controls.Add(Me.txtInstallmentFee)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Panel10)
        Me.GroupBox2.Controls.Add(Me.cboStatus)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(337, 8)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(183, 42)
        Me.GroupBox2.TabIndex = 55
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Hidden Controls"
        Me.GroupBox2.Visible = False
        '
        'txtDiscountPercentage
        '
        Me.txtDiscountPercentage.Location = New System.Drawing.Point(98, 18)
        Me.txtDiscountPercentage.Name = "txtDiscountPercentage"
        Me.txtDiscountPercentage.Size = New System.Drawing.Size(100, 26)
        Me.txtDiscountPercentage.TabIndex = 57
        Me.txtDiscountPercentage.Text = "0"
        '
        'lblMajor
        '
        Me.lblMajor.AutoSize = True
        Me.lblMajor.Location = New System.Drawing.Point(29, 53)
        Me.lblMajor.Name = "lblMajor"
        Me.lblMajor.Size = New System.Drawing.Size(48, 20)
        Me.lblMajor.TabIndex = 56
        Me.lblMajor.Text = "Major"
        '
        'lblEnrolled
        '
        Me.lblEnrolled.AutoSize = True
        Me.lblEnrolled.Location = New System.Drawing.Point(29, 80)
        Me.lblEnrolled.Name = "lblEnrolled"
        Me.lblEnrolled.Size = New System.Drawing.Size(67, 20)
        Me.lblEnrolled.TabIndex = 50
        Me.lblEnrolled.Text = "Enrolled"
        Me.lblEnrolled.Visible = False
        '
        'txtInstallmentFee
        '
        Me.txtInstallmentFee.BackColor = System.Drawing.Color.Chartreuse
        Me.txtInstallmentFee.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInstallmentFee.Location = New System.Drawing.Point(7, 253)
        Me.txtInstallmentFee.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtInstallmentFee.Name = "txtInstallmentFee"
        Me.txtInstallmentFee.Size = New System.Drawing.Size(142, 30)
        Me.txtInstallmentFee.TabIndex = 54
        Me.txtInstallmentFee.TabStop = False
        Me.txtInstallmentFee.Text = "0.00"
        Me.txtInstallmentFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(7, 219)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(96, 19)
        Me.Label17.TabIndex = 53
        Me.Label17.Text = "Installment Fee"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel10.Controls.Add(Me.Label2)
        Me.Panel10.Controls.Add(Me.txtRegFee)
        Me.Panel10.Location = New System.Drawing.Point(11, 304)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(174, 33)
        Me.Panel10.TabIndex = 57
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(14, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Registration Fee"
        '
        'txtRegFee
        '
        Me.txtRegFee.BackColor = System.Drawing.Color.White
        Me.txtRegFee.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegFee.ForeColor = System.Drawing.Color.Black
        Me.txtRegFee.Location = New System.Drawing.Point(191, 1)
        Me.txtRegFee.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRegFee.Name = "txtRegFee"
        Me.txtRegFee.Size = New System.Drawing.Size(118, 30)
        Me.txtRegFee.TabIndex = 45
        Me.txtRegFee.TabStop = False
        Me.txtRegFee.Text = "00.00"
        Me.txtRegFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel8.Controls.Add(Me.Label11)
        Me.Panel8.Controls.Add(Me.txtFname)
        Me.Panel8.Controls.Add(Me.txtMName)
        Me.Panel8.Controls.Add(Me.txtLastName)
        Me.Panel8.Location = New System.Drawing.Point(0, 60)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(532, 33)
        Me.Panel8.TabIndex = 59
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(17, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 19)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Name"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.mskStudentNumber)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(0, 21)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(242, 33)
        Me.Panel2.TabIndex = 58
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtTotalAdditional)
        Me.TabPage2.Controls.Add(Me.Panel19)
        Me.TabPage2.Controls.Add(Me.Panel18)
        Me.TabPage2.Controls.Add(Me.Panel17)
        Me.TabPage2.Controls.Add(Me.Panel16)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(865, 500)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Other Fees"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtTotalAdditional
        '
        Me.txtTotalAdditional.AutoSize = True
        Me.txtTotalAdditional.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAdditional.ForeColor = System.Drawing.Color.Blue
        Me.txtTotalAdditional.Location = New System.Drawing.Point(411, 243)
        Me.txtTotalAdditional.Name = "txtTotalAdditional"
        Me.txtTotalAdditional.Size = New System.Drawing.Size(206, 55)
        Me.txtTotalAdditional.TabIndex = 20
        Me.txtTotalAdditional.Tag = ""
        Me.txtTotalAdditional.Text = "0000.00"
        '
        'Panel19
        '
        Me.Panel19.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel19.Controls.Add(Me.Label25)
        Me.Panel19.Controls.Add(Me.Label27)
        Me.Panel19.Controls.Add(Me.txtAmount5)
        Me.Panel19.Controls.Add(Me.txtDesc5)
        Me.Panel19.Location = New System.Drawing.Point(6, 203)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(611, 33)
        Me.Panel19.TabIndex = 63
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(17, 7)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(84, 19)
        Me.Label25.TabIndex = 2
        Me.Label25.Text = "Description 5"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(463, 7)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(53, 19)
        Me.Label27.TabIndex = 3
        Me.Label27.Text = "Amount"
        '
        'txtAmount5
        '
        Me.txtAmount5.Location = New System.Drawing.Point(522, 4)
        Me.txtAmount5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAmount5.Name = "txtAmount5"
        Me.txtAmount5.Size = New System.Drawing.Size(85, 26)
        Me.txtAmount5.TabIndex = 18
        Me.txtAmount5.Text = "00.00"
        Me.txtAmount5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDesc5
        '
        Me.txtDesc5.Location = New System.Drawing.Point(107, 4)
        Me.txtDesc5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDesc5.Name = "txtDesc5"
        Me.txtDesc5.Size = New System.Drawing.Size(350, 26)
        Me.txtDesc5.TabIndex = 16
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel18.Controls.Add(Me.Label21)
        Me.Panel18.Controls.Add(Me.Label23)
        Me.Panel18.Controls.Add(Me.txtDesc4)
        Me.Panel18.Controls.Add(Me.txtAmount4)
        Me.Panel18.Location = New System.Drawing.Point(6, 166)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(611, 33)
        Me.Panel18.TabIndex = 62
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(17, 7)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(84, 19)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "Description 4"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(463, 7)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(53, 19)
        Me.Label23.TabIndex = 3
        Me.Label23.Text = "Amount"
        '
        'txtDesc4
        '
        Me.txtDesc4.Location = New System.Drawing.Point(107, 4)
        Me.txtDesc4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDesc4.Name = "txtDesc4"
        Me.txtDesc4.Size = New System.Drawing.Size(350, 26)
        Me.txtDesc4.TabIndex = 12
        '
        'txtAmount4
        '
        Me.txtAmount4.Location = New System.Drawing.Point(522, 4)
        Me.txtAmount4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAmount4.Name = "txtAmount4"
        Me.txtAmount4.Size = New System.Drawing.Size(85, 26)
        Me.txtAmount4.TabIndex = 14
        Me.txtAmount4.Text = "00.00"
        Me.txtAmount4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel17.Controls.Add(Me.Label16)
        Me.Panel17.Controls.Add(Me.Label18)
        Me.Panel17.Controls.Add(Me.txtDesc3)
        Me.Panel17.Controls.Add(Me.txtAmount3)
        Me.Panel17.Location = New System.Drawing.Point(6, 127)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(611, 33)
        Me.Panel17.TabIndex = 61
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(17, 7)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 19)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Description 3"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(463, 7)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(53, 19)
        Me.Label18.TabIndex = 3
        Me.Label18.Text = "Amount"
        '
        'txtDesc3
        '
        Me.txtDesc3.Location = New System.Drawing.Point(107, 4)
        Me.txtDesc3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDesc3.Name = "txtDesc3"
        Me.txtDesc3.Size = New System.Drawing.Size(350, 26)
        Me.txtDesc3.TabIndex = 8
        '
        'txtAmount3
        '
        Me.txtAmount3.Location = New System.Drawing.Point(522, 4)
        Me.txtAmount3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAmount3.Name = "txtAmount3"
        Me.txtAmount3.Size = New System.Drawing.Size(85, 26)
        Me.txtAmount3.TabIndex = 10
        Me.txtAmount3.Text = "00.00"
        Me.txtAmount3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel16.Controls.Add(Me.Label13)
        Me.Panel16.Controls.Add(Me.Label20)
        Me.Panel16.Controls.Add(Me.txtDesc2)
        Me.Panel16.Controls.Add(Me.txtAmount2)
        Me.Panel16.Location = New System.Drawing.Point(6, 88)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(611, 33)
        Me.Panel16.TabIndex = 60
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(17, 7)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 19)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Description 2"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(463, 7)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(53, 19)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "Amount"
        '
        'txtDesc2
        '
        Me.txtDesc2.Location = New System.Drawing.Point(107, 4)
        Me.txtDesc2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDesc2.Name = "txtDesc2"
        Me.txtDesc2.Size = New System.Drawing.Size(350, 26)
        Me.txtDesc2.TabIndex = 4
        '
        'txtAmount2
        '
        Me.txtAmount2.Location = New System.Drawing.Point(522, 4)
        Me.txtAmount2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAmount2.Name = "txtAmount2"
        Me.txtAmount2.Size = New System.Drawing.Size(85, 26)
        Me.txtAmount2.TabIndex = 6
        Me.txtAmount2.Text = "00.00"
        Me.txtAmount2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtDesc1)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.txtAmount1)
        Me.Panel1.Location = New System.Drawing.Point(6, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(611, 33)
        Me.Panel1.TabIndex = 59
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(17, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 19)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Description 1"
        '
        'txtDesc1
        '
        Me.txtDesc1.Location = New System.Drawing.Point(107, 3)
        Me.txtDesc1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDesc1.Name = "txtDesc1"
        Me.txtDesc1.Size = New System.Drawing.Size(350, 26)
        Me.txtDesc1.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(463, 7)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 19)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Amount"
        '
        'txtAmount1
        '
        Me.txtAmount1.Location = New System.Drawing.Point(522, 3)
        Me.txtAmount1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAmount1.Name = "txtAmount1"
        Me.txtAmount1.Size = New System.Drawing.Size(85, 26)
        Me.txtAmount1.TabIndex = 2
        Me.txtAmount1.Text = "00.00"
        Me.txtAmount1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(6, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 22)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "OTHER FEES"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Controls.Add(Me.Panel21)
        Me.TabPage3.Location = New System.Drawing.Point(4, 28)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(865, 500)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Discounts"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblDiscTotal)
        Me.GroupBox1.Controls.Add(Me.Label33)
        Me.GroupBox1.Controls.Add(Me.txtDiscAmount5)
        Me.GroupBox1.Controls.Add(Me.Label37)
        Me.GroupBox1.Controls.Add(Me.txtDisc5)
        Me.GroupBox1.Controls.Add(Me.Label38)
        Me.GroupBox1.Controls.Add(Me.txtDiscAmount4)
        Me.GroupBox1.Controls.Add(Me.Label39)
        Me.GroupBox1.Controls.Add(Me.txtDisc4)
        Me.GroupBox1.Controls.Add(Me.Label40)
        Me.GroupBox1.Controls.Add(Me.txtDiscAmount3)
        Me.GroupBox1.Controls.Add(Me.Label41)
        Me.GroupBox1.Controls.Add(Me.txtDisc3)
        Me.GroupBox1.Controls.Add(Me.Label42)
        Me.GroupBox1.Controls.Add(Me.txtDiscAmount2)
        Me.GroupBox1.Controls.Add(Me.Label43)
        Me.GroupBox1.Controls.Add(Me.txtDisc2)
        Me.GroupBox1.Controls.Add(Me.Label44)
        Me.GroupBox1.Controls.Add(Me.txtDiscAmount1)
        Me.GroupBox1.Controls.Add(Me.Label45)
        Me.GroupBox1.Controls.Add(Me.txtDisc1)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(630, 322)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'lblDiscTotal
        '
        Me.lblDiscTotal.AutoSize = True
        Me.lblDiscTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscTotal.ForeColor = System.Drawing.Color.Blue
        Me.lblDiscTotal.Location = New System.Drawing.Point(386, 252)
        Me.lblDiscTotal.Name = "lblDiscTotal"
        Me.lblDiscTotal.Size = New System.Drawing.Size(206, 55)
        Me.lblDiscTotal.TabIndex = 20
        Me.lblDiscTotal.Tag = ""
        Me.lblDiscTotal.Text = "0000.00"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(432, 211)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(53, 19)
        Me.Label33.TabIndex = 19
        Me.Label33.Text = "Amount"
        '
        'txtDiscAmount5
        '
        Me.txtDiscAmount5.Location = New System.Drawing.Point(504, 208)
        Me.txtDiscAmount5.Name = "txtDiscAmount5"
        Me.txtDiscAmount5.Size = New System.Drawing.Size(109, 26)
        Me.txtDiscAmount5.TabIndex = 18
        Me.txtDiscAmount5.Text = "0.0"
        Me.txtDiscAmount5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(16, 211)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(69, 19)
        Me.Label37.TabIndex = 17
        Me.Label37.Text = "Discount 5"
        '
        'txtDisc5
        '
        Me.txtDisc5.Location = New System.Drawing.Point(92, 208)
        Me.txtDisc5.Name = "txtDisc5"
        Me.txtDisc5.Size = New System.Drawing.Size(301, 26)
        Me.txtDisc5.TabIndex = 16
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(432, 168)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(53, 19)
        Me.Label38.TabIndex = 15
        Me.Label38.Text = "Amount"
        '
        'txtDiscAmount4
        '
        Me.txtDiscAmount4.Location = New System.Drawing.Point(504, 165)
        Me.txtDiscAmount4.Name = "txtDiscAmount4"
        Me.txtDiscAmount4.Size = New System.Drawing.Size(109, 26)
        Me.txtDiscAmount4.TabIndex = 14
        Me.txtDiscAmount4.Text = "0.0"
        Me.txtDiscAmount4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(16, 168)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(69, 19)
        Me.Label39.TabIndex = 13
        Me.Label39.Text = "Discount 4"
        '
        'txtDisc4
        '
        Me.txtDisc4.Location = New System.Drawing.Point(92, 165)
        Me.txtDisc4.Name = "txtDisc4"
        Me.txtDisc4.Size = New System.Drawing.Size(301, 26)
        Me.txtDisc4.TabIndex = 12
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(432, 126)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(53, 19)
        Me.Label40.TabIndex = 11
        Me.Label40.Text = "Amount"
        '
        'txtDiscAmount3
        '
        Me.txtDiscAmount3.Location = New System.Drawing.Point(504, 123)
        Me.txtDiscAmount3.Name = "txtDiscAmount3"
        Me.txtDiscAmount3.Size = New System.Drawing.Size(109, 26)
        Me.txtDiscAmount3.TabIndex = 10
        Me.txtDiscAmount3.Text = "0.0"
        Me.txtDiscAmount3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(16, 126)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(69, 19)
        Me.Label41.TabIndex = 9
        Me.Label41.Text = "Discount 3"
        '
        'txtDisc3
        '
        Me.txtDisc3.Location = New System.Drawing.Point(92, 123)
        Me.txtDisc3.Name = "txtDisc3"
        Me.txtDisc3.Size = New System.Drawing.Size(301, 26)
        Me.txtDisc3.TabIndex = 8
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(432, 84)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(53, 19)
        Me.Label42.TabIndex = 7
        Me.Label42.Text = "Amount"
        '
        'txtDiscAmount2
        '
        Me.txtDiscAmount2.Location = New System.Drawing.Point(504, 81)
        Me.txtDiscAmount2.Name = "txtDiscAmount2"
        Me.txtDiscAmount2.Size = New System.Drawing.Size(109, 26)
        Me.txtDiscAmount2.TabIndex = 6
        Me.txtDiscAmount2.Text = "0.0"
        Me.txtDiscAmount2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(16, 84)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(69, 19)
        Me.Label43.TabIndex = 5
        Me.Label43.Text = "Discount 2"
        '
        'txtDisc2
        '
        Me.txtDisc2.Location = New System.Drawing.Point(92, 81)
        Me.txtDisc2.Name = "txtDisc2"
        Me.txtDisc2.Size = New System.Drawing.Size(301, 26)
        Me.txtDisc2.TabIndex = 4
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(432, 42)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(53, 19)
        Me.Label44.TabIndex = 3
        Me.Label44.Text = "Amount"
        '
        'txtDiscAmount1
        '
        Me.txtDiscAmount1.Location = New System.Drawing.Point(504, 39)
        Me.txtDiscAmount1.Name = "txtDiscAmount1"
        Me.txtDiscAmount1.Size = New System.Drawing.Size(109, 26)
        Me.txtDiscAmount1.TabIndex = 2
        Me.txtDiscAmount1.Text = "0.0"
        Me.txtDiscAmount1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(16, 42)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(69, 19)
        Me.Label45.TabIndex = 1
        Me.Label45.Text = "Discount 1"
        '
        'txtDisc1
        '
        Me.txtDisc1.Location = New System.Drawing.Point(92, 39)
        Me.txtDisc1.Name = "txtDisc1"
        Me.txtDisc1.Size = New System.Drawing.Size(301, 26)
        Me.txtDisc1.TabIndex = 0
        '
        'Panel21
        '
        Me.Panel21.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel21.Controls.Add(Me.Label46)
        Me.Panel21.Location = New System.Drawing.Point(29, 42)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(630, 42)
        Me.Panel21.TabIndex = 13
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.White
        Me.Label46.Location = New System.Drawing.Point(208, 7)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(185, 31)
        Me.Label46.TabIndex = 0
        Me.Label46.Text = "DISCOUNTS"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsNew, Me.tsSave, Me.tsUpdate, Me.tsDelete, Me.tsViewAccounts})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(875, 54)
        Me.ToolStrip1.TabIndex = 42
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsNew
        '
        Me.tsNew.Image = CType(resources.GetObject("tsNew.Image"), System.Drawing.Image)
        Me.tsNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsNew.Name = "tsNew"
        Me.tsNew.Size = New System.Drawing.Size(36, 51)
        Me.tsNew.Text = "New"
        Me.tsNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsNew.ToolTipText = "New (Ctrl + N)"
        '
        'tsSave
        '
        Me.tsSave.Image = CType(resources.GetObject("tsSave.Image"), System.Drawing.Image)
        Me.tsSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSave.Name = "tsSave"
        Me.tsSave.Size = New System.Drawing.Size(36, 51)
        Me.tsSave.Text = "Save"
        Me.tsSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsSave.ToolTipText = "Save (Ctrl + S)"
        '
        'tsUpdate
        '
        Me.tsUpdate.Image = CType(resources.GetObject("tsUpdate.Image"), System.Drawing.Image)
        Me.tsUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsUpdate.Name = "tsUpdate"
        Me.tsUpdate.Size = New System.Drawing.Size(49, 51)
        Me.tsUpdate.Text = "Update"
        Me.tsUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsUpdate.ToolTipText = "Update (Ctrl + U)"
        '
        'tsDelete
        '
        Me.tsDelete.Image = CType(resources.GetObject("tsDelete.Image"), System.Drawing.Image)
        Me.tsDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDelete.Name = "tsDelete"
        Me.tsDelete.Size = New System.Drawing.Size(44, 51)
        Me.tsDelete.Text = "Delete"
        Me.tsDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsViewAccounts
        '
        Me.tsViewAccounts.Image = CType(resources.GetObject("tsViewAccounts.Image"), System.Drawing.Image)
        Me.tsViewAccounts.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsViewAccounts.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsViewAccounts.Name = "tsViewAccounts"
        Me.tsViewAccounts.Size = New System.Drawing.Size(89, 51)
        Me.tsViewAccounts.Text = "View Accounts"
        Me.tsViewAccounts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsViewAccounts.ToolTipText = "View Accounts (Ctrl + F)"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BillingToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1144, 35)
        Me.MenuStrip1.TabIndex = 43
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'BillingToolStripMenuItem
        '
        Me.BillingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.SaveToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.BillingToolStripMenuItem.Name = "BillingToolStripMenuItem"
        Me.BillingToolStripMenuItem.Size = New System.Drawing.Size(52, 29)
        Me.BillingToolStripMenuItem.Text = "Billing"
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
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'frmBilling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(875, 598)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmBilling"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "[ Student's Accounts  ]"
        Me.Panel6.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel20.ResumeLayout(False)
        Me.Panel20.PerformLayout()
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel19.ResumeLayout(False)
        Me.Panel19.PerformLayout()
        Me.Panel18.ResumeLayout(False)
        Me.Panel18.PerformLayout()
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel21.ResumeLayout(False)
        Me.Panel21.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents cboYear As System.Windows.Forms.ComboBox
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cboCourse As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFname As System.Windows.Forms.TextBox
    Friend WithEvents txtMName As System.Windows.Forms.TextBox
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents txtPayments As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalAcct As System.Windows.Forms.TextBox
    Friend WithEvents txtLab As System.Windows.Forms.TextBox
    Friend WithEvents txtTuition As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTotalLabUnits As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalLecUnits As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents lvAccts As System.Windows.Forms.ListView
    Friend WithEvents btnAddFees As System.Windows.Forms.Button
    Friend WithEvents btnRemoveFees As System.Windows.Forms.Button
    Friend WithEvents txtTotalFees As System.Windows.Forms.TextBox
    Friend WithEvents txtLabRate As System.Windows.Forms.TextBox
    Friend WithEvents txtLecRate As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtOldAccount As System.Windows.Forms.TextBox
    Friend WithEvents txtBalance As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtAmount1 As System.Windows.Forms.TextBox
    Friend WithEvents txtDesc1 As System.Windows.Forms.TextBox
    Friend WithEvents txtAmount2 As System.Windows.Forms.TextBox
    Friend WithEvents txtDesc2 As System.Windows.Forms.TextBox
    Friend WithEvents txtAmount5 As System.Windows.Forms.TextBox
    Friend WithEvents txtDesc5 As System.Windows.Forms.TextBox
    Friend WithEvents txtAmount4 As System.Windows.Forms.TextBox
    Friend WithEvents txtDesc4 As System.Windows.Forms.TextBox
    Friend WithEvents txtAmount3 As System.Windows.Forms.TextBox
    Friend WithEvents txtDesc3 As System.Windows.Forms.TextBox
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnOldAcct As System.Windows.Forms.Button
    Friend WithEvents txtSection As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtRegFee As System.Windows.Forms.TextBox
    Friend WithEvents mskStudentNumber As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsUpdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsViewAccounts As System.Windows.Forms.ToolStripButton
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BillingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblEnrolled As System.Windows.Forms.Label
    Friend WithEvents tsDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtInstallmentFee As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents cboPaymentMode As System.Windows.Forms.ComboBox
    Friend WithEvents lblMajor As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtDiscountPercentage As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtTotalAdditional As System.Windows.Forms.Label
    Friend WithEvents Panel18 As System.Windows.Forms.Panel
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Panel19 As System.Windows.Forms.Panel
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Panel20 As System.Windows.Forms.Panel
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblDiscTotal As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtDiscAmount5 As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents txtDisc5 As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents txtDiscAmount4 As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents txtDisc4 As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents txtDiscAmount3 As System.Windows.Forms.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents txtDisc3 As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents txtDiscAmount2 As System.Windows.Forms.TextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents txtDisc2 As System.Windows.Forms.TextBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents txtDiscAmount1 As System.Windows.Forms.TextBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents txtDisc1 As System.Windows.Forms.TextBox
    Friend WithEvents Panel21 As System.Windows.Forms.Panel
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents lblSettingsID As System.Windows.Forms.Label
End Class
