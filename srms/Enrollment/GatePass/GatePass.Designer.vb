<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGatePass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGatePass))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtFeedback = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtOfficeAddress = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtOffice = New System.Windows.Forms.TextBox
        Me.lblID = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtRemarks = New System.Windows.Forms.TextBox
        Me.txtPurpose = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtPersonsToMeet = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtVisitorNo = New System.Windows.Forms.TextBox
        Me.dtpTime = New System.Windows.Forms.DateTimePicker
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.btnSave = New System.Windows.Forms.Button
        Me.mainProfTS = New System.Windows.Forms.ToolStrip
        Me.tsSave = New System.Windows.Forms.ToolStripButton
        Me.tsUpdate = New System.Windows.Forms.ToolStripButton
        Me.tsDelete = New System.Windows.Forms.ToolStripButton
        Me.tsSearch = New System.Windows.Forms.ToolStripButton
        Me.tsClose = New System.Windows.Forms.ToolStripButton
        Me.GroupBox1.SuspendLayout()
        Me.mainProfTS.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtFeedback)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtOfficeAddress)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtOffice)
        Me.GroupBox1.Controls.Add(Me.lblID)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtRemarks)
        Me.GroupBox1.Controls.Add(Me.txtPurpose)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtPersonsToMeet)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtVisitorNo)
        Me.GroupBox1.Controls.Add(Me.dtpTime)
        Me.GroupBox1.Controls.Add(Me.dtpDate)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 102)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(783, 293)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(60, 182)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 19)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Feedback"
        '
        'txtFeedback
        '
        Me.txtFeedback.Location = New System.Drawing.Point(124, 179)
        Me.txtFeedback.Multiline = True
        Me.txtFeedback.Name = "txtFeedback"
        Me.txtFeedback.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtFeedback.Size = New System.Drawing.Size(263, 62)
        Me.txtFeedback.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(398, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 19)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Office Address"
        '
        'txtOfficeAddress
        '
        Me.txtOfficeAddress.Location = New System.Drawing.Point(498, 117)
        Me.txtOfficeAddress.Name = "txtOfficeAddress"
        Me.txtOfficeAddress.Size = New System.Drawing.Size(263, 26)
        Me.txtOfficeAddress.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(76, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 19)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Office"
        '
        'txtOffice
        '
        Me.txtOffice.Location = New System.Drawing.Point(124, 117)
        Me.txtOffice.Name = "txtOffice"
        Me.txtOffice.Size = New System.Drawing.Size(263, 26)
        Me.txtOffice.TabIndex = 6
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(474, 61)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(22, 19)
        Me.lblID.TabIndex = 16
        Me.lblID.Text = "ID"
        Me.lblID.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(434, 182)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 19)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Remarks"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(436, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 19)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Purpose"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(498, 179)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRemarks.Size = New System.Drawing.Size(263, 62)
        Me.txtRemarks.TabIndex = 11
        '
        'txtPurpose
        '
        Me.txtPurpose.Location = New System.Drawing.Point(498, 148)
        Me.txtPurpose.Name = "txtPurpose"
        Me.txtPurpose.Size = New System.Drawing.Size(263, 26)
        Me.txtPurpose.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 19)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Persons to Meet"
        '
        'txtPersonsToMeet
        '
        Me.txtPersonsToMeet.Location = New System.Drawing.Point(124, 148)
        Me.txtPersonsToMeet.Name = "txtPersonsToMeet"
        Me.txtPersonsToMeet.Size = New System.Drawing.Size(263, 26)
        Me.txtPersonsToMeet.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(436, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Address"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(498, 86)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(263, 26)
        Me.txtAddress.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Visitor's Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(124, 86)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(263, 26)
        Me.txtName.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(242, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Time"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Visit Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Visitor No."
        '
        'txtVisitorNo
        '
        Me.txtVisitorNo.Location = New System.Drawing.Point(124, 24)
        Me.txtVisitorNo.Name = "txtVisitorNo"
        Me.txtVisitorNo.Size = New System.Drawing.Size(103, 26)
        Me.txtVisitorNo.TabIndex = 1
        '
        'dtpTime
        '
        Me.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpTime.Location = New System.Drawing.Point(284, 55)
        Me.dtpTime.Name = "dtpTime"
        Me.dtpTime.Size = New System.Drawing.Size(103, 26)
        Me.dtpTime.TabIndex = 3
        '
        'dtpDate
        '
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(124, 55)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(103, 26)
        Me.dtpDate.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(320, 90)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(57, 14)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'mainProfTS
        '
        Me.mainProfTS.BackColor = System.Drawing.Color.Transparent
        Me.mainProfTS.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainProfTS.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.mainProfTS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsSave, Me.tsUpdate, Me.tsDelete, Me.tsSearch, Me.tsClose})
        Me.mainProfTS.Location = New System.Drawing.Point(0, 0)
        Me.mainProfTS.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.mainProfTS.Name = "mainProfTS"
        Me.mainProfTS.Padding = New System.Windows.Forms.Padding(10)
        Me.mainProfTS.Size = New System.Drawing.Size(812, 93)
        Me.mainProfTS.TabIndex = 22
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
        'tsSearch
        '
        Me.tsSearch.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsSearch.Image = CType(resources.GetObject("tsSearch.Image"), System.Drawing.Image)
        Me.tsSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSearch.Name = "tsSearch"
        Me.tsSearch.Size = New System.Drawing.Size(52, 70)
        Me.tsSearch.Text = "S&earch"
        Me.tsSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsSearch.ToolTipText = "Ctrl + F"
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
        'frmGatePass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 401)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.mainProfTS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGatePass"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gate Pass - Visitor's Details"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.mainProfTS.ResumeLayout(False)
        Me.mainProfTS.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtFeedback As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtOfficeAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtOffice As System.Windows.Forms.TextBox
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents txtPurpose As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPersonsToMeet As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtVisitorNo As System.Windows.Forms.TextBox
    Friend WithEvents dtpTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents mainProfTS As System.Windows.Forms.ToolStrip
    Friend WithEvents tsSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsUpdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsClose As System.Windows.Forms.ToolStripButton
End Class
