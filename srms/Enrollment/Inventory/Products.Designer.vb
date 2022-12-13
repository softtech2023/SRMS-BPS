<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProducts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProducts))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtItemName = New System.Windows.Forms.TextBox
        Me.txtAccountable = New System.Windows.Forms.TextBox
        Me.cboSub_category = New System.Windows.Forms.ComboBox
        Me.cboCategory = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtShortageValue = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtShortage = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.dtpProcessDate = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.cboUnit = New System.Windows.Forms.ComboBox
        Me.cboBrand = New System.Windows.Forms.ComboBox
        Me.lblItemID = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.dg1 = New System.Windows.Forms.DataGridView
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblSettingsID = New System.Windows.Forms.Label
        Me.btnFind = New System.Windows.Forms.Button
        Me.lblIDNumber = New System.Windows.Forms.Label
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSerialNo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtRemarks = New System.Windows.Forms.TextBox
        Me.txtPPrice = New System.Windows.Forms.TextBox
        Me.dtpAcquireDate = New System.Windows.Forms.DateTimePicker
        Me.lblAcquireDate = New System.Windows.Forms.Label
        Me.lblPurchasePrice = New System.Windows.Forms.Label
        Me.lblRemarks = New System.Windows.Forms.Label
        Me.cboCondition = New System.Windows.Forms.ComboBox
        Me.txtCapacity = New System.Windows.Forms.TextBox
        Me.lblAccountableName = New System.Windows.Forms.Label
        Me.txtModel = New System.Windows.Forms.TextBox
        Me.txtCtrlNo = New System.Windows.Forms.TextBox
        Me.lblBrand = New System.Windows.Forms.Label
        Me.lblCapacity = New System.Windows.Forms.Label
        Me.lblItemCodition = New System.Windows.Forms.Label
        Me.lblModel = New System.Windows.Forms.Label
        Me.lblControlNo = New System.Windows.Forms.Label
        Me.lblItemName = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnclose = New System.Windows.Forms.Button
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tsSave = New System.Windows.Forms.ToolStripButton
        Me.tsUpdate = New System.Windows.Forms.ToolStripButton
        Me.tsDelete = New System.Windows.Forms.ToolStripButton
        Me.tsPrintMR = New System.Windows.Forms.ToolStripButton
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.txtItemName)
        Me.GroupBox1.Controls.Add(Me.txtAccountable)
        Me.GroupBox1.Controls.Add(Me.cboSub_category)
        Me.GroupBox1.Controls.Add(Me.cboCategory)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtShortageValue)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtShortage)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.dtpProcessDate)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cboUnit)
        Me.GroupBox1.Controls.Add(Me.cboBrand)
        Me.GroupBox1.Controls.Add(Me.lblItemID)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.dg1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtQty)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblSettingsID)
        Me.GroupBox1.Controls.Add(Me.btnFind)
        Me.GroupBox1.Controls.Add(Me.lblIDNumber)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtSerialNo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtRemarks)
        Me.GroupBox1.Controls.Add(Me.txtPPrice)
        Me.GroupBox1.Controls.Add(Me.dtpAcquireDate)
        Me.GroupBox1.Controls.Add(Me.lblAcquireDate)
        Me.GroupBox1.Controls.Add(Me.lblPurchasePrice)
        Me.GroupBox1.Controls.Add(Me.lblRemarks)
        Me.GroupBox1.Controls.Add(Me.cboCondition)
        Me.GroupBox1.Controls.Add(Me.txtCapacity)
        Me.GroupBox1.Controls.Add(Me.lblAccountableName)
        Me.GroupBox1.Controls.Add(Me.txtModel)
        Me.GroupBox1.Controls.Add(Me.txtCtrlNo)
        Me.GroupBox1.Controls.Add(Me.lblBrand)
        Me.GroupBox1.Controls.Add(Me.lblCapacity)
        Me.GroupBox1.Controls.Add(Me.lblItemCodition)
        Me.GroupBox1.Controls.Add(Me.lblModel)
        Me.GroupBox1.Controls.Add(Me.lblControlNo)
        Me.GroupBox1.Controls.Add(Me.lblItemName)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnclose)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1052, 567)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtItemName
        '
        Me.txtItemName.Location = New System.Drawing.Point(116, 53)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(306, 26)
        Me.txtItemName.TabIndex = 2
        '
        'txtAccountable
        '
        Me.txtAccountable.Location = New System.Drawing.Point(116, 383)
        Me.txtAccountable.Name = "txtAccountable"
        Me.txtAccountable.ReadOnly = True
        Me.txtAccountable.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtAccountable.Size = New System.Drawing.Size(248, 26)
        Me.txtAccountable.TabIndex = 14
        '
        'cboSub_category
        '
        Me.cboSub_category.FormattingEnabled = True
        Me.cboSub_category.Location = New System.Drawing.Point(116, 351)
        Me.cboSub_category.Name = "cboSub_category"
        Me.cboSub_category.Size = New System.Drawing.Size(306, 27)
        Me.cboSub_category.TabIndex = 57
        '
        'cboCategory
        '
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Location = New System.Drawing.Point(116, 318)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(306, 27)
        Me.cboCategory.TabIndex = 56
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(24, 354)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 19)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "Sub-Category"
        '
        'txtShortageValue
        '
        Me.txtShortageValue.Location = New System.Drawing.Point(307, 185)
        Me.txtShortageValue.Name = "txtShortageValue"
        Me.txtShortageValue.Size = New System.Drawing.Size(115, 26)
        Me.txtShortageValue.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(260, 188)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 19)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Value"
        '
        'txtShortage
        '
        Me.txtShortage.Location = New System.Drawing.Point(116, 185)
        Me.txtShortage.Name = "txtShortage"
        Me.txtShortage.Size = New System.Drawing.Size(122, 26)
        Me.txtShortage.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(-3, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 19)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Shortage/Overage"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(50, 321)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 19)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Category"
        '
        'dtpProcessDate
        '
        Me.dtpProcessDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpProcessDate.Location = New System.Drawing.Point(116, 447)
        Me.dtpProcessDate.Name = "dtpProcessDate"
        Me.dtpProcessDate.Size = New System.Drawing.Size(306, 26)
        Me.dtpProcessDate.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 453)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 19)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Processed Date"
        '
        'cboUnit
        '
        Me.cboUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUnit.FormattingEnabled = True
        Me.cboUnit.Location = New System.Drawing.Point(307, 152)
        Me.cboUnit.Name = "cboUnit"
        Me.cboUnit.Size = New System.Drawing.Size(115, 27)
        Me.cboUnit.TabIndex = 5
        '
        'cboBrand
        '
        Me.cboBrand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboBrand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBrand.FormattingEnabled = True
        Me.cboBrand.Location = New System.Drawing.Point(116, 218)
        Me.cboBrand.Name = "cboBrand"
        Me.cboBrand.Size = New System.Drawing.Size(122, 27)
        Me.cboBrand.TabIndex = 8
        '
        'lblItemID
        '
        Me.lblItemID.AutoSize = True
        Me.lblItemID.Location = New System.Drawing.Point(6, 128)
        Me.lblItemID.Name = "lblItemID"
        Me.lblItemID.Size = New System.Drawing.Size(47, 19)
        Me.lblItemID.TabIndex = 45
        Me.lblItemID.Text = "itemID"
        Me.lblItemID.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Location = New System.Drawing.Point(458, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(585, 37)
        Me.Panel1.TabIndex = 44
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(239, 19)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Search by Item Name, Model, Serial No."
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(255, 5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(212, 26)
        Me.txtSearch.TabIndex = 0
        Me.txtSearch.TabStop = False
        '
        'dg1
        '
        Me.dg1.AllowUserToAddRows = False
        Me.dg1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dg1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dg1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg1.Location = New System.Drawing.Point(458, 53)
        Me.dg1.Name = "dg1"
        Me.dg1.ReadOnly = True
        Me.dg1.Size = New System.Drawing.Size(585, 506)
        Me.dg1.TabIndex = 43
        Me.dg1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(269, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 19)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Unit"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(116, 153)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(122, 26)
        Me.txtQty.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(82, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 19)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Qty"
        '
        'lblSettingsID
        '
        Me.lblSettingsID.AutoSize = True
        Me.lblSettingsID.Location = New System.Drawing.Point(5, 109)
        Me.lblSettingsID.Name = "lblSettingsID"
        Me.lblSettingsID.Size = New System.Drawing.Size(71, 19)
        Me.lblSettingsID.TabIndex = 39
        Me.lblSettingsID.Text = "Settings ID"
        Me.lblSettingsID.Visible = False
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(370, 383)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(52, 26)
        Me.btnFind.TabIndex = 15
        Me.btnFind.TabStop = False
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'lblIDNumber
        '
        Me.lblIDNumber.AutoSize = True
        Me.lblIDNumber.Location = New System.Drawing.Point(7, 155)
        Me.lblIDNumber.Name = "lblIDNumber"
        Me.lblIDNumber.Size = New System.Drawing.Size(69, 19)
        Me.lblIDNumber.TabIndex = 37
        Me.lblIDNumber.Text = "IDNumber"
        Me.lblIDNumber.Visible = False
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(116, 87)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDescription.Size = New System.Drawing.Size(306, 60)
        Me.txtDescription.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 19)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Description"
        '
        'txtSerialNo
        '
        Me.txtSerialNo.Location = New System.Drawing.Point(116, 251)
        Me.txtSerialNo.Name = "txtSerialNo"
        Me.txtSerialNo.Size = New System.Drawing.Size(122, 26)
        Me.txtSerialNo.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 254)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 19)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Serial No."
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(116, 511)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtRemarks.Size = New System.Drawing.Size(306, 42)
        Me.txtRemarks.TabIndex = 19
        '
        'txtPPrice
        '
        Me.txtPPrice.Location = New System.Drawing.Point(116, 479)
        Me.txtPPrice.Name = "txtPPrice"
        Me.txtPPrice.Size = New System.Drawing.Size(158, 26)
        Me.txtPPrice.TabIndex = 18
        Me.txtPPrice.Text = "00.00"
        Me.txtPPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtpAcquireDate
        '
        Me.dtpAcquireDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAcquireDate.Location = New System.Drawing.Point(116, 415)
        Me.dtpAcquireDate.Name = "dtpAcquireDate"
        Me.dtpAcquireDate.Size = New System.Drawing.Size(306, 26)
        Me.dtpAcquireDate.TabIndex = 16
        '
        'lblAcquireDate
        '
        Me.lblAcquireDate.AutoSize = True
        Me.lblAcquireDate.Location = New System.Drawing.Point(20, 421)
        Me.lblAcquireDate.Name = "lblAcquireDate"
        Me.lblAcquireDate.Size = New System.Drawing.Size(90, 19)
        Me.lblAcquireDate.TabIndex = 31
        Me.lblAcquireDate.Text = "Acquired Date"
        '
        'lblPurchasePrice
        '
        Me.lblPurchasePrice.AutoSize = True
        Me.lblPurchasePrice.Location = New System.Drawing.Point(17, 482)
        Me.lblPurchasePrice.Name = "lblPurchasePrice"
        Me.lblPurchasePrice.Size = New System.Drawing.Size(93, 19)
        Me.lblPurchasePrice.TabIndex = 30
        Me.lblPurchasePrice.Text = "Purchase Price"
        '
        'lblRemarks
        '
        Me.lblRemarks.AutoSize = True
        Me.lblRemarks.Location = New System.Drawing.Point(51, 514)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(59, 19)
        Me.lblRemarks.TabIndex = 29
        Me.lblRemarks.Text = "Remarks"
        '
        'cboCondition
        '
        Me.cboCondition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboCondition.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCondition.FormattingEnabled = True
        Me.cboCondition.Items.AddRange(New Object() {"Good", "Defective", "Disposed"})
        Me.cboCondition.Location = New System.Drawing.Point(116, 285)
        Me.cboCondition.Name = "cboCondition"
        Me.cboCondition.Size = New System.Drawing.Size(306, 27)
        Me.cboCondition.TabIndex = 12
        '
        'txtCapacity
        '
        Me.txtCapacity.Location = New System.Drawing.Point(307, 251)
        Me.txtCapacity.Name = "txtCapacity"
        Me.txtCapacity.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtCapacity.Size = New System.Drawing.Size(115, 26)
        Me.txtCapacity.TabIndex = 11
        '
        'lblAccountableName
        '
        Me.lblAccountableName.AutoSize = True
        Me.lblAccountableName.Location = New System.Drawing.Point(32, 386)
        Me.lblAccountableName.Name = "lblAccountableName"
        Me.lblAccountableName.Size = New System.Drawing.Size(78, 19)
        Me.lblAccountableName.TabIndex = 23
        Me.lblAccountableName.Text = "Accountable"
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(307, 217)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(115, 26)
        Me.txtModel.TabIndex = 9
        '
        'txtCtrlNo
        '
        Me.txtCtrlNo.Location = New System.Drawing.Point(116, 21)
        Me.txtCtrlNo.Name = "txtCtrlNo"
        Me.txtCtrlNo.Size = New System.Drawing.Size(218, 26)
        Me.txtCtrlNo.TabIndex = 1
        '
        'lblBrand
        '
        Me.lblBrand.AutoSize = True
        Me.lblBrand.Location = New System.Drawing.Point(67, 221)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(43, 19)
        Me.lblBrand.TabIndex = 20
        Me.lblBrand.Text = "Brand"
        '
        'lblCapacity
        '
        Me.lblCapacity.AutoSize = True
        Me.lblCapacity.Location = New System.Drawing.Point(244, 254)
        Me.lblCapacity.Name = "lblCapacity"
        Me.lblCapacity.Size = New System.Drawing.Size(57, 19)
        Me.lblCapacity.TabIndex = 15
        Me.lblCapacity.Text = "Capacity"
        '
        'lblItemCodition
        '
        Me.lblItemCodition.AutoSize = True
        Me.lblItemCodition.Location = New System.Drawing.Point(48, 288)
        Me.lblItemCodition.Name = "lblItemCodition"
        Me.lblItemCodition.Size = New System.Drawing.Size(62, 19)
        Me.lblItemCodition.TabIndex = 13
        Me.lblItemCodition.Text = "Condition"
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Location = New System.Drawing.Point(257, 220)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(44, 19)
        Me.lblModel.TabIndex = 11
        Me.lblModel.Text = "Model"
        '
        'lblControlNo
        '
        Me.lblControlNo.AutoSize = True
        Me.lblControlNo.Location = New System.Drawing.Point(29, 22)
        Me.lblControlNo.Name = "lblControlNo"
        Me.lblControlNo.Size = New System.Drawing.Size(81, 19)
        Me.lblControlNo.TabIndex = 9
        Me.lblControlNo.Text = "Property No."
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Location = New System.Drawing.Point(36, 56)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(74, 19)
        Me.lblItemName.TabIndex = 0
        Me.lblItemName.Text = "Item Name"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(248, 27)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(26, 14)
        Me.btnCancel.TabIndex = 32
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnclose.Location = New System.Drawing.Point(298, 109)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 23)
        Me.btnclose.TabIndex = 58
        Me.btnclose.Text = "close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsSave, Me.tsUpdate, Me.tsDelete, Me.tsPrintMR})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1076, 39)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsSave
        '
        Me.tsSave.Image = CType(resources.GetObject("tsSave.Image"), System.Drawing.Image)
        Me.tsSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSave.Name = "tsSave"
        Me.tsSave.Size = New System.Drawing.Size(72, 36)
        Me.tsSave.Text = "Save"
        '
        'tsUpdate
        '
        Me.tsUpdate.Image = CType(resources.GetObject("tsUpdate.Image"), System.Drawing.Image)
        Me.tsUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsUpdate.Name = "tsUpdate"
        Me.tsUpdate.Size = New System.Drawing.Size(86, 36)
        Me.tsUpdate.Text = "Update"
        '
        'tsDelete
        '
        Me.tsDelete.Enabled = False
        Me.tsDelete.Image = CType(resources.GetObject("tsDelete.Image"), System.Drawing.Image)
        Me.tsDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDelete.Name = "tsDelete"
        Me.tsDelete.Size = New System.Drawing.Size(82, 36)
        Me.tsDelete.Text = "Delete"
        '
        'tsPrintMR
        '
        Me.tsPrintMR.Image = CType(resources.GetObject("tsPrintMR.Image"), System.Drawing.Image)
        Me.tsPrintMR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsPrintMR.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsPrintMR.Name = "tsPrintMR"
        Me.tsPrintMR.Size = New System.Drawing.Size(98, 36)
        Me.tsPrintMR.Text = "Print PAR"
        '
        'frmProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnclose
        Me.ClientSize = New System.Drawing.Size(1076, 623)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmProducts"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Equipments and Machinery"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSerialNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents txtPPrice As System.Windows.Forms.TextBox
    Friend WithEvents dtpAcquireDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblAcquireDate As System.Windows.Forms.Label
    Friend WithEvents lblPurchasePrice As System.Windows.Forms.Label
    Friend WithEvents lblRemarks As System.Windows.Forms.Label
    Friend WithEvents cboCondition As System.Windows.Forms.ComboBox
    Friend WithEvents txtCapacity As System.Windows.Forms.TextBox
    Friend WithEvents lblAccountableName As System.Windows.Forms.Label
    Friend WithEvents txtModel As System.Windows.Forms.TextBox
    Friend WithEvents txtCtrlNo As System.Windows.Forms.TextBox
    Friend WithEvents lblBrand As System.Windows.Forms.Label
    Friend WithEvents lblCapacity As System.Windows.Forms.Label
    Friend WithEvents lblItemCodition As System.Windows.Forms.Label
    Friend WithEvents lblModel As System.Windows.Forms.Label
    Friend WithEvents lblControlNo As System.Windows.Forms.Label
    Friend WithEvents txtItemName As System.Windows.Forms.TextBox
    Friend WithEvents lblItemName As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAccountable As System.Windows.Forms.TextBox
    Friend WithEvents lblIDNumber As System.Windows.Forms.Label
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents lblSettingsID As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dg1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblItemID As System.Windows.Forms.Label
    Friend WithEvents cboBrand As System.Windows.Forms.ComboBox
    Friend WithEvents cboUnit As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpProcessDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtShortage As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtShortageValue As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboCategory As System.Windows.Forms.ComboBox
    Friend WithEvents cboSub_category As System.Windows.Forms.ComboBox
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsUpdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsPrintMR As System.Windows.Forms.ToolStripButton

    
End Class
