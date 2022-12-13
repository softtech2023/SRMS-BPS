<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPayment))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label9 = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.txtcheck = New System.Windows.Forms.TextBox
        Me.dtpPaymentDate = New System.Windows.Forms.DateTimePicker
        Me.RadioButtonCheck = New System.Windows.Forms.RadioButton
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.RadioButtonCash = New System.Windows.Forms.RadioButton
        Me.txtOR = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtTotalAccts = New System.Windows.Forms.TextBox
        Me.txtTotalPayments = New System.Windows.Forms.TextBox
        Me.txtCurrentPayments = New System.Windows.Forms.TextBox
        Me.txtBalance = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.lblID = New System.Windows.Forms.Label
        Me.mskStudentNumber = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.txtFname = New System.Windows.Forms.TextBox
        Me.txtMName = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtDescription = New System.Windows.Forms.ComboBox
        Me.txtFinalOR = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.btnSelect = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lblPaymentMode = New System.Windows.Forms.Label
        Me.lblCourseCode = New System.Windows.Forms.Label
        Me.lblYearLevel = New System.Windows.Forms.Label
        Me.lblEnrolled = New System.Windows.Forms.Label
        Me.lblCourse = New System.Windows.Forms.Label
        Me.lblSource = New System.Windows.Forms.Label
        Me.lblORStatus = New System.Windows.Forms.Label
        Me.lblPaymentID = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtBank = New System.Windows.Forms.TextBox
        Me.btnPrint = New System.Windows.Forms.Button
        Me.mainProfTS = New System.Windows.Forms.ToolStrip
        Me.tsSave = New System.Windows.Forms.ToolStripButton
        Me.tsUpdate = New System.Windows.Forms.ToolStripButton
        Me.tsView = New System.Windows.Forms.ToolStripButton
        Me.tsPrint = New System.Windows.Forms.ToolStripButton
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.dg1 = New System.Windows.Forms.DataGridView
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.txtDiscount = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.mainProfTS.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(61, 296)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 19)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Check No."
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(238, 78)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(44, 18)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.TabStop = False
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtcheck
        '
        Me.txtcheck.Enabled = False
        Me.txtcheck.ForeColor = System.Drawing.Color.Black
        Me.txtcheck.Location = New System.Drawing.Point(134, 293)
        Me.txtcheck.Name = "txtcheck"
        Me.txtcheck.Size = New System.Drawing.Size(151, 26)
        Me.txtcheck.TabIndex = 9
        '
        'dtpPaymentDate
        '
        Me.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPaymentDate.Location = New System.Drawing.Point(134, 168)
        Me.dtpPaymentDate.MaxDate = New Date(2099, 12, 31, 0, 0, 0, 0)
        Me.dtpPaymentDate.Name = "dtpPaymentDate"
        Me.dtpPaymentDate.Size = New System.Drawing.Size(151, 26)
        Me.dtpPaymentDate.TabIndex = 2
        '
        'RadioButtonCheck
        '
        Me.RadioButtonCheck.AutoSize = True
        Me.RadioButtonCheck.ForeColor = System.Drawing.Color.Black
        Me.RadioButtonCheck.Location = New System.Drawing.Point(224, 264)
        Me.RadioButtonCheck.Name = "RadioButtonCheck"
        Me.RadioButtonCheck.Size = New System.Drawing.Size(61, 23)
        Me.RadioButtonCheck.TabIndex = 8
        Me.RadioButtonCheck.TabStop = True
        Me.RadioButtonCheck.Text = "Check"
        Me.RadioButtonCheck.UseVisualStyleBackColor = True
        '
        'txtAmount
        '
        Me.txtAmount.ForeColor = System.Drawing.Color.Black
        Me.txtAmount.Location = New System.Drawing.Point(292, 200)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(80, 26)
        Me.txtAmount.TabIndex = 4
        Me.txtAmount.Text = "0.00"
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadioButtonCash
        '
        Me.RadioButtonCash.AutoSize = True
        Me.RadioButtonCash.ForeColor = System.Drawing.Color.Black
        Me.RadioButtonCash.Location = New System.Drawing.Point(134, 264)
        Me.RadioButtonCash.Name = "RadioButtonCash"
        Me.RadioButtonCash.Size = New System.Drawing.Size(55, 23)
        Me.RadioButtonCash.TabIndex = 7
        Me.RadioButtonCash.TabStop = True
        Me.RadioButtonCash.Text = "Cash"
        Me.RadioButtonCash.UseVisualStyleBackColor = True
        '
        'txtOR
        '
        Me.txtOR.ForeColor = System.Drawing.Color.Black
        Me.txtOR.Location = New System.Drawing.Point(134, 200)
        Me.txtOR.Name = "txtOR"
        Me.txtOR.Size = New System.Drawing.Size(91, 26)
        Me.txtOR.TabIndex = 3
        Me.txtOR.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(55, 235)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 19)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Description"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(233, 203)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 19)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Amount"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(82, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 19)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "OR No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(92, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Date"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(47, 41)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 19)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Total Account"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(234, 144)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 19)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Total Payments"
        '
        'txtTotalAccts
        '
        Me.txtTotalAccts.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAccts.Location = New System.Drawing.Point(139, 39)
        Me.txtTotalAccts.Name = "txtTotalAccts"
        Me.txtTotalAccts.ReadOnly = True
        Me.txtTotalAccts.Size = New System.Drawing.Size(80, 26)
        Me.txtTotalAccts.TabIndex = 16
        Me.txtTotalAccts.Text = "0.00"
        Me.txtTotalAccts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTotalPayments
        '
        Me.txtTotalPayments.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPayments.Location = New System.Drawing.Point(336, 143)
        Me.txtTotalPayments.Name = "txtTotalPayments"
        Me.txtTotalPayments.ReadOnly = True
        Me.txtTotalPayments.Size = New System.Drawing.Size(80, 26)
        Me.txtTotalPayments.TabIndex = 22
        Me.txtTotalPayments.Text = "0.00"
        Me.txtTotalPayments.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCurrentPayments
        '
        Me.txtCurrentPayments.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentPayments.Location = New System.Drawing.Point(139, 71)
        Me.txtCurrentPayments.Name = "txtCurrentPayments"
        Me.txtCurrentPayments.ReadOnly = True
        Me.txtCurrentPayments.Size = New System.Drawing.Size(80, 26)
        Me.txtCurrentPayments.TabIndex = 17
        Me.txtCurrentPayments.Text = "0.00"
        Me.txtCurrentPayments.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBalance
        '
        Me.txtBalance.BackColor = System.Drawing.Color.Navy
        Me.txtBalance.Font = New System.Drawing.Font("Segoe Condensed", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalance.ForeColor = System.Drawing.SystemColors.Window
        Me.txtBalance.Location = New System.Drawing.Point(238, 71)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.Size = New System.Drawing.Size(178, 45)
        Me.txtBalance.TabIndex = 18
        Me.txtBalance.Text = "0.00"
        Me.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(22, 75)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(111, 19)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Current Payments"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.Color.Black
        Me.lblID.Location = New System.Drawing.Point(24, 43)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(22, 19)
        Me.lblID.TabIndex = 11
        Me.lblID.Text = "ID"
        Me.lblID.Visible = False
        '
        'mskStudentNumber
        '
        Me.mskStudentNumber.Location = New System.Drawing.Point(134, 40)
        Me.mskStudentNumber.Name = "mskStudentNumber"
        Me.mskStudentNumber.ReadOnly = True
        Me.mskStudentNumber.Size = New System.Drawing.Size(83, 26)
        Me.mskStudentNumber.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(52, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Student No."
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.Color.Black
        Me.txtAddress.Location = New System.Drawing.Point(79, 123)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(96, 26)
        Me.txtAddress.TabIndex = 1
        Me.txtAddress.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(42, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 19)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Middle Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(56, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 19)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "First Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(57, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 19)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Last Name"
        '
        'txtLastName
        '
        Me.txtLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLastName.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.ForeColor = System.Drawing.Color.Black
        Me.txtLastName.Location = New System.Drawing.Point(134, 136)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.ReadOnly = True
        Me.txtLastName.Size = New System.Drawing.Size(151, 26)
        Me.txtLastName.TabIndex = 9
        '
        'txtFname
        '
        Me.txtFname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFname.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFname.ForeColor = System.Drawing.Color.Black
        Me.txtFname.Location = New System.Drawing.Point(134, 72)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.ReadOnly = True
        Me.txtFname.Size = New System.Drawing.Size(151, 26)
        Me.txtFname.TabIndex = 6
        '
        'txtMName
        '
        Me.txtMName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMName.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMName.ForeColor = System.Drawing.Color.Black
        Me.txtMName.Location = New System.Drawing.Point(134, 104)
        Me.txtMName.Name = "txtMName"
        Me.txtMName.ReadOnly = True
        Me.txtMName.Size = New System.Drawing.Size(151, 26)
        Me.txtMName.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(39, 264)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(89, 19)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "Payment Type"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(396, 332)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(82, 19)
        Me.btnSave.TabIndex = 26
        Me.btnSave.Text = "Accept Payment"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtDiscount)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtTotalPayments)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtBalance)
        Me.GroupBox1.Controls.Add(Me.txtCurrentPayments)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtTotalAccts)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(522, 100)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(432, 143)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Account Details"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtDescription)
        Me.GroupBox2.Controls.Add(Me.txtFinalOR)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.btnSelect)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtBank)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.lblID)
        Me.GroupBox2.Controls.Add(Me.mskStudentNumber)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtAmount)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.RadioButtonCash)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.RadioButtonCheck)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtLastName)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.dtpPaymentDate)
        Me.GroupBox2.Controls.Add(Me.txtOR)
        Me.GroupBox2.Controls.Add(Me.txtMName)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtFname)
        Me.GroupBox2.Controls.Add(Me.txtcheck)
        Me.GroupBox2.Controls.Add(Me.btnPrint)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.btnCancel)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 101)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(504, 364)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Payment Details"
        '
        'txtDescription
        '
        Me.txtDescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtDescription.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtDescription.FormattingEnabled = True
        Me.txtDescription.Location = New System.Drawing.Point(134, 232)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(344, 27)
        Me.txtDescription.TabIndex = 6
        '
        'txtFinalOR
        '
        Me.txtFinalOR.ForeColor = System.Drawing.Color.Black
        Me.txtFinalOR.Location = New System.Drawing.Point(422, 200)
        Me.txtFinalOR.Name = "txtFinalOR"
        Me.txtFinalOR.Size = New System.Drawing.Size(56, 26)
        Me.txtFinalOR.TabIndex = 5
        Me.txtFinalOR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtFinalOR.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(378, 203)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 19)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "OR #"
        Me.Label11.Visible = False
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(224, 40)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(61, 26)
        Me.btnSelect.TabIndex = 34
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblPaymentMode)
        Me.GroupBox3.Controls.Add(Me.lblCourseCode)
        Me.GroupBox3.Controls.Add(Me.lblYearLevel)
        Me.GroupBox3.Controls.Add(Me.lblEnrolled)
        Me.GroupBox3.Controls.Add(Me.lblCourse)
        Me.GroupBox3.Controls.Add(Me.lblSource)
        Me.GroupBox3.Controls.Add(Me.lblORStatus)
        Me.GroupBox3.Controls.Add(Me.txtAddress)
        Me.GroupBox3.Controls.Add(Me.lblPaymentID)
        Me.GroupBox3.Location = New System.Drawing.Point(314, 32)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(184, 155)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "HIdden Group"
        Me.GroupBox3.Visible = False
        '
        'lblPaymentMode
        '
        Me.lblPaymentMode.AutoSize = True
        Me.lblPaymentMode.Location = New System.Drawing.Point(81, 79)
        Me.lblPaymentMode.Name = "lblPaymentMode"
        Me.lblPaymentMode.Size = New System.Drawing.Size(94, 19)
        Me.lblPaymentMode.TabIndex = 25
        Me.lblPaymentMode.Text = "Payment Mode"
        '
        'lblCourseCode
        '
        Me.lblCourseCode.AutoSize = True
        Me.lblCourseCode.Location = New System.Drawing.Point(21, 114)
        Me.lblCourseCode.Name = "lblCourseCode"
        Me.lblCourseCode.Size = New System.Drawing.Size(82, 19)
        Me.lblCourseCode.TabIndex = 33
        Me.lblCourseCode.Text = "Course Code"
        Me.lblCourseCode.Visible = False
        '
        'lblYearLevel
        '
        Me.lblYearLevel.AutoSize = True
        Me.lblYearLevel.Location = New System.Drawing.Point(81, 50)
        Me.lblYearLevel.Name = "lblYearLevel"
        Me.lblYearLevel.Size = New System.Drawing.Size(68, 19)
        Me.lblYearLevel.TabIndex = 24
        Me.lblYearLevel.Text = "Year Level"
        '
        'lblEnrolled
        '
        Me.lblEnrolled.AutoSize = True
        Me.lblEnrolled.Location = New System.Drawing.Point(15, 69)
        Me.lblEnrolled.Name = "lblEnrolled"
        Me.lblEnrolled.Size = New System.Drawing.Size(55, 19)
        Me.lblEnrolled.TabIndex = 31
        Me.lblEnrolled.Text = "Enrolled"
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Location = New System.Drawing.Point(21, 91)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(49, 19)
        Me.lblCourse.TabIndex = 32
        Me.lblCourse.Text = "Course"
        Me.lblCourse.Visible = False
        '
        'lblSource
        '
        Me.lblSource.AutoSize = True
        Me.lblSource.Location = New System.Drawing.Point(21, 22)
        Me.lblSource.Name = "lblSource"
        Me.lblSource.Size = New System.Drawing.Size(110, 19)
        Me.lblSource.TabIndex = 30
        Me.lblSource.Text = "Student's Account"
        Me.lblSource.Visible = False
        '
        'lblORStatus
        '
        Me.lblORStatus.AutoSize = True
        Me.lblORStatus.Location = New System.Drawing.Point(15, 50)
        Me.lblORStatus.Name = "lblORStatus"
        Me.lblORStatus.Size = New System.Drawing.Size(37, 19)
        Me.lblORStatus.TabIndex = 30
        Me.lblORStatus.Text = "Valid"
        Me.lblORStatus.Visible = False
        '
        'lblPaymentID
        '
        Me.lblPaymentID.AutoSize = True
        Me.lblPaymentID.Location = New System.Drawing.Point(89, 126)
        Me.lblPaymentID.Name = "lblPaymentID"
        Me.lblPaymentID.Size = New System.Drawing.Size(75, 19)
        Me.lblPaymentID.TabIndex = 31
        Me.lblPaymentID.Text = "Payment ID"
        Me.lblPaymentID.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(46, 328)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(82, 19)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "Bank/Branch"
        '
        'txtBank
        '
        Me.txtBank.Location = New System.Drawing.Point(134, 325)
        Me.txtBank.Name = "txtBank"
        Me.txtBank.Size = New System.Drawing.Size(344, 26)
        Me.txtBank.TabIndex = 10
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(385, 235)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(82, 22)
        Me.btnPrint.TabIndex = 29
        Me.btnPrint.Text = "Reprint Receipts"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'mainProfTS
        '
        Me.mainProfTS.BackColor = System.Drawing.Color.Transparent
        Me.mainProfTS.Font = New System.Drawing.Font("Segoe Condensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainProfTS.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.mainProfTS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsSave, Me.tsUpdate, Me.tsView, Me.tsPrint})
        Me.mainProfTS.Location = New System.Drawing.Point(0, 0)
        Me.mainProfTS.Name = "mainProfTS"
        Me.mainProfTS.Padding = New System.Windows.Forms.Padding(10)
        Me.mainProfTS.Size = New System.Drawing.Size(966, 93)
        Me.mainProfTS.TabIndex = 30
        Me.mainProfTS.Text = "ts"
        '
        'tsSave
        '
        Me.tsSave.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsSave.Image = CType(resources.GetObject("tsSave.Image"), System.Drawing.Image)
        Me.tsSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSave.Name = "tsSave"
        Me.tsSave.Size = New System.Drawing.Size(96, 70)
        Me.tsSave.Text = "Accept Payment"
        Me.tsSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsSave.ToolTipText = "Ctrl+S"
        '
        'tsUpdate
        '
        Me.tsUpdate.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsUpdate.Image = CType(resources.GetObject("tsUpdate.Image"), System.Drawing.Image)
        Me.tsUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsUpdate.Name = "tsUpdate"
        Me.tsUpdate.Size = New System.Drawing.Size(99, 70)
        Me.tsUpdate.Text = "&Update Payment"
        Me.tsUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsUpdate.ToolTipText = "Ctrl+U"
        Me.tsUpdate.Visible = False
        '
        'tsView
        '
        Me.tsView.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsView.Image = CType(resources.GetObject("tsView.Image"), System.Drawing.Image)
        Me.tsView.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsView.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsView.Name = "tsView"
        Me.tsView.Size = New System.Drawing.Size(100, 70)
        Me.tsView.Text = "Search Payments"
        Me.tsView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsView.ToolTipText = "Ctrl+F"
        Me.tsView.Visible = False
        '
        'tsPrint
        '
        Me.tsPrint.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsPrint.Image = CType(resources.GetObject("tsPrint.Image"), System.Drawing.Image)
        Me.tsPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsPrint.Name = "tsPrint"
        Me.tsPrint.Size = New System.Drawing.Size(62, 70)
        Me.tsPrint.Text = "Print O.R."
        Me.tsPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dg1)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(522, 249)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(432, 216)
        Me.GroupBox4.TabIndex = 28
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Payment History"
        '
        'dg1
        '
        Me.dg1.AllowUserToAddRows = False
        Me.dg1.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dg1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg1.Location = New System.Drawing.Point(9, 25)
        Me.dg1.Name = "dg1"
        Me.dg1.ReadOnly = True
        Me.dg1.Size = New System.Drawing.Size(417, 185)
        Me.dg1.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Navy
        Me.TextBox1.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(238, 39)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(178, 30)
        Me.TextBox1.TabIndex = 37
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "CURRENT BALANCE"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDiscount
        '
        Me.txtDiscount.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.Location = New System.Drawing.Point(139, 103)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.ReadOnly = True
        Me.txtDiscount.Size = New System.Drawing.Size(80, 26)
        Me.txtDiscount.TabIndex = 38
        Me.txtDiscount.Text = "0.00"
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(75, 106)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 19)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Discount"
        '
        'frmPayment
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(966, 475)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.mainProfTS)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPayment"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.mainProfTS.ResumeLayout(False)
        Me.mainProfTS.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFname As System.Windows.Forms.TextBox
    Friend WithEvents txtMName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcheck As System.Windows.Forms.TextBox
    Friend WithEvents RadioButtonCheck As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonCash As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtOR As System.Windows.Forms.TextBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents dtpPaymentDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtBalance As System.Windows.Forms.TextBox
    Friend WithEvents txtCurrentPayments As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalAccts As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents mskStudentNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalPayments As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents lblSource As System.Windows.Forms.Label
    Friend WithEvents lblORStatus As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtBank As System.Windows.Forms.TextBox
    Friend WithEvents mainProfTS As System.Windows.Forms.ToolStrip
    Friend WithEvents tsSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsUpdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsView As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblPaymentID As System.Windows.Forms.Label
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents lblEnrolled As System.Windows.Forms.Label
    Friend WithEvents txtFinalOR As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblCourse As System.Windows.Forms.Label
    Friend WithEvents lblCourseCode As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dg1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblYearLevel As System.Windows.Forms.Label
    Friend WithEvents lblPaymentMode As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
End Class
