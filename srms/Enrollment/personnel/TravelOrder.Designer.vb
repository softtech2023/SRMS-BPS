<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTravelOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTravelOrder))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtEmployeeID = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtPosition = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.txtStation = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.txtPurpose = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.lblNoOfDays = New System.Windows.Forms.Label
        Me.txtDestination = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.dtpTo = New System.Windows.Forms.DateTimePicker
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.cboRemarks = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.dg1 = New System.Windows.Forms.DataGridView
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtATTNo = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tsSave = New System.Windows.Forms.ToolStripButton
        Me.tsUpdate = New System.Windows.Forms.ToolStripButton
        Me.tsDelete = New System.Windows.Forms.ToolStripButton
        Me.tsPrint = New System.Windows.Forms.ToolStripButton
        Me.tsClose = New System.Windows.Forms.ToolStripButton
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.cboLocation = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.dtpApprovedDate = New System.Windows.Forms.DateTimePicker
        Me.Label15 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.txtEmployeeID)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(3, 99)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(467, 33)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(362, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 27)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Select"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.Location = New System.Drawing.Point(135, 3)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.ReadOnly = True
        Me.txtEmployeeID.Size = New System.Drawing.Size(221, 26)
        Me.txtEmployeeID.TabIndex = 1
        Me.txtEmployeeID.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee ID"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtPosition)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(3, 172)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(467, 33)
        Me.Panel2.TabIndex = 4
        '
        'txtPosition
        '
        Me.txtPosition.Location = New System.Drawing.Point(135, 3)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.ReadOnly = True
        Me.txtPosition.Size = New System.Drawing.Size(329, 26)
        Me.txtPosition.TabIndex = 5
        Me.txtPosition.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(76, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Position"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.Controls.Add(Me.txtName)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(3, 136)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(467, 33)
        Me.Panel3.TabIndex = 4
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(135, 3)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(329, 26)
        Me.txtName.TabIndex = 3
        Me.txtName.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(85, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Name"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel4.Controls.Add(Me.txtStation)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(3, 208)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(467, 68)
        Me.Panel4.TabIndex = 6
        Me.Panel4.TabStop = True
        '
        'txtStation
        '
        Me.txtStation.Location = New System.Drawing.Point(135, 3)
        Me.txtStation.Multiline = True
        Me.txtStation.Name = "txtStation"
        Me.txtStation.Size = New System.Drawing.Size(329, 62)
        Me.txtStation.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Official Station"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel5.Controls.Add(Me.txtPurpose)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Location = New System.Drawing.Point(3, 352)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(467, 68)
        Me.Panel5.TabIndex = 10
        '
        'txtPurpose
        '
        Me.txtPurpose.Location = New System.Drawing.Point(135, 3)
        Me.txtPurpose.Multiline = True
        Me.txtPurpose.Name = "txtPurpose"
        Me.txtPurpose.Size = New System.Drawing.Size(329, 62)
        Me.txtPurpose.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Purpose(s)"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel6.Controls.Add(Me.lblNoOfDays)
        Me.Panel6.Controls.Add(Me.txtDestination)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Location = New System.Drawing.Point(3, 280)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(467, 68)
        Me.Panel6.TabIndex = 8
        '
        'lblNoOfDays
        '
        Me.lblNoOfDays.AutoSize = True
        Me.lblNoOfDays.Location = New System.Drawing.Point(13, 36)
        Me.lblNoOfDays.Name = "lblNoOfDays"
        Me.lblNoOfDays.Size = New System.Drawing.Size(16, 19)
        Me.lblNoOfDays.TabIndex = 7
        Me.lblNoOfDays.Text = "0"
        Me.lblNoOfDays.Visible = False
        '
        'txtDestination
        '
        Me.txtDestination.Location = New System.Drawing.Point(135, 3)
        Me.txtDestination.Multiline = True
        Me.txtDestination.Name = "txtDestination"
        Me.txtDestination.Size = New System.Drawing.Size(329, 62)
        Me.txtDestination.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(56, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 19)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Destination"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel7.Controls.Add(Me.Label8)
        Me.Panel7.Controls.Add(Me.dtpTo)
        Me.Panel7.Controls.Add(Me.dtpFrom)
        Me.Panel7.Controls.Add(Me.Label7)
        Me.Panel7.Location = New System.Drawing.Point(3, 424)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(467, 31)
        Me.Panel7.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(293, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(14, 19)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "-"
        '
        'dtpTo
        '
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTo.Location = New System.Drawing.Point(315, 3)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(149, 26)
        Me.dtpTo.TabIndex = 14
        '
        'dtpFrom
        '
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrom.Location = New System.Drawing.Point(135, 3)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(149, 26)
        Me.dtpFrom.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(34, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 19)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Inclusive Dates"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel8.Controls.Add(Me.cboRemarks)
        Me.Panel8.Controls.Add(Me.Label10)
        Me.Panel8.Location = New System.Drawing.Point(3, 460)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(467, 31)
        Me.Panel8.TabIndex = 15
        Me.Panel8.TabStop = True
        '
        'cboRemarks
        '
        Me.cboRemarks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboRemarks.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboRemarks.FormattingEnabled = True
        Me.cboRemarks.Items.AddRange(New Object() {"Chargeable against School MOOE", "Official Time"})
        Me.cboRemarks.Location = New System.Drawing.Point(135, 1)
        Me.cboRemarks.Name = "cboRemarks"
        Me.cboRemarks.Size = New System.Drawing.Size(329, 27)
        Me.cboRemarks.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(70, 4)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 19)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Remarks"
        '
        'dg1
        '
        Me.dg1.AllowUserToAddRows = False
        Me.dg1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dg1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dg1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg1.Location = New System.Drawing.Point(476, 99)
        Me.dg1.Name = "dg1"
        Me.dg1.ReadOnly = True
        Me.dg1.Size = New System.Drawing.Size(596, 466)
        Me.dg1.TabIndex = 22
        Me.dg1.TabStop = False
        '
        'Panel9
        '
        Me.Panel9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel9.Controls.Add(Me.txtSearch)
        Me.Panel9.Controls.Add(Me.Label9)
        Me.Panel9.Location = New System.Drawing.Point(476, 62)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(596, 31)
        Me.Panel9.TabIndex = 11
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtSearch.Location = New System.Drawing.Point(395, 2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(198, 26)
        Me.txtSearch.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(341, 6)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 19)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Search"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel10.Controls.Add(Me.Label13)
        Me.Panel10.Controls.Add(Me.txtATTNo)
        Me.Panel10.Controls.Add(Me.Label12)
        Me.Panel10.Location = New System.Drawing.Point(3, 62)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(467, 33)
        Me.Panel10.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(364, 7)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 19)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "(Ex. 20180001)"
        '
        'txtATTNo
        '
        Me.txtATTNo.Location = New System.Drawing.Point(135, 3)
        Me.txtATTNo.Name = "txtATTNo"
        Me.txtATTNo.Size = New System.Drawing.Size(221, 26)
        Me.txtATTNo.TabIndex = 1
        Me.txtATTNo.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(74, 6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 19)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "ATT No."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsSave, Me.tsUpdate, Me.tsDelete, Me.tsPrint, Me.tsClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1074, 39)
        Me.ToolStrip1.TabIndex = 20
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsSave
        '
        Me.tsSave.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsSave.Image = CType(resources.GetObject("tsSave.Image"), System.Drawing.Image)
        Me.tsSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSave.Name = "tsSave"
        Me.tsSave.Size = New System.Drawing.Size(72, 36)
        Me.tsSave.Text = "Save"
        '
        'tsUpdate
        '
        Me.tsUpdate.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsUpdate.Image = CType(resources.GetObject("tsUpdate.Image"), System.Drawing.Image)
        Me.tsUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsUpdate.Name = "tsUpdate"
        Me.tsUpdate.Size = New System.Drawing.Size(86, 36)
        Me.tsUpdate.Text = "Update"
        '
        'tsDelete
        '
        Me.tsDelete.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsDelete.Image = CType(resources.GetObject("tsDelete.Image"), System.Drawing.Image)
        Me.tsDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDelete.Name = "tsDelete"
        Me.tsDelete.Size = New System.Drawing.Size(82, 36)
        Me.tsDelete.Text = "Delete"
        '
        'tsPrint
        '
        Me.tsPrint.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsPrint.Image = CType(resources.GetObject("tsPrint.Image"), System.Drawing.Image)
        Me.tsPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsPrint.Name = "tsPrint"
        Me.tsPrint.Size = New System.Drawing.Size(71, 36)
        Me.tsPrint.Text = "Print"
        '
        'tsClose
        '
        Me.tsClose.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsClose.Image = CType(resources.GetObject("tsClose.Image"), System.Drawing.Image)
        Me.tsClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsClose.Name = "tsClose"
        Me.tsClose.Size = New System.Drawing.Size(76, 36)
        Me.tsClose.Text = "Close"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel11.Controls.Add(Me.cboLocation)
        Me.Panel11.Controls.Add(Me.Label11)
        Me.Panel11.Location = New System.Drawing.Point(3, 495)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(467, 31)
        Me.Panel11.TabIndex = 17
        '
        'cboLocation
        '
        Me.cboLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboLocation.FormattingEnabled = True
        Me.cboLocation.Items.AddRange(New Object() {"Within the Division", "Outside the Division"})
        Me.cboLocation.Location = New System.Drawing.Point(135, 1)
        Me.cboLocation.Name = "cboLocation"
        Me.cboLocation.Size = New System.Drawing.Size(329, 27)
        Me.cboLocation.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(34, 4)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 19)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Travel Location"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel12.Controls.Add(Me.dtpApprovedDate)
        Me.Panel12.Controls.Add(Me.Label15)
        Me.Panel12.Location = New System.Drawing.Point(3, 534)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(467, 31)
        Me.Panel12.TabIndex = 19
        '
        'dtpApprovedDate
        '
        Me.dtpApprovedDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpApprovedDate.Location = New System.Drawing.Point(135, 2)
        Me.dtpApprovedDate.Name = "dtpApprovedDate"
        Me.dtpApprovedDate.Size = New System.Drawing.Size(329, 26)
        Me.dtpApprovedDate.TabIndex = 20
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(35, 6)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(94, 19)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Approved Date"
        '
        'frmTravelOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1074, 571)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.dg1)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmTravelOrder"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Authority to Travel Order"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtEmployeeID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtPosition As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txtStation As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents txtPurpose As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents txtDestination As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents cboRemarks As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dg1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents txtATTNo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblNoOfDays As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsUpdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents cboLocation As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents dtpApprovedDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
