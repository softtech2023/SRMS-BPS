<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPromissory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPromissory))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.mskPromisedDate = New System.Windows.Forms.DateTimePicker
        Me.mskDateApplied = New System.Windows.Forms.DateTimePicker
        Me.lblID = New System.Windows.Forms.Label
        Me.btnSelect = New System.Windows.Forms.Button
        Me.dgPromissory = New System.Windows.Forms.DataGridView
        Me.cboStatus = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.txtGuardian = New System.Windows.Forms.TextBox
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.txtStudentNumber = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgPromissory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.mskPromisedDate)
        Me.GroupBox1.Controls.Add(Me.mskDateApplied)
        Me.GroupBox1.Controls.Add(Me.lblID)
        Me.GroupBox1.Controls.Add(Me.btnSelect)
        Me.GroupBox1.Controls.Add(Me.dgPromissory)
        Me.GroupBox1.Controls.Add(Me.cboStatus)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtAmount)
        Me.GroupBox1.Controls.Add(Me.txtGuardian)
        Me.GroupBox1.Controls.Add(Me.txtLastName)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Controls.Add(Me.txtStudentNumber)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(604, 345)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(275, 299)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(85, 38)
        Me.btnSave.TabIndex = 34
        Me.btnSave.Text = "&Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Black
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Image)
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.Location = New System.Drawing.Point(366, 299)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(85, 38)
        Me.btnUpdate.TabIndex = 35
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(457, 299)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(85, 38)
        Me.btnDelete.TabIndex = 36
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'mskPromisedDate
        '
        Me.mskPromisedDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.mskPromisedDate.Location = New System.Drawing.Point(123, 274)
        Me.mskPromisedDate.MaxDate = New Date(2099, 12, 31, 0, 0, 0, 0)
        Me.mskPromisedDate.Name = "mskPromisedDate"
        Me.mskPromisedDate.Size = New System.Drawing.Size(138, 26)
        Me.mskPromisedDate.TabIndex = 21
        '
        'mskDateApplied
        '
        Me.mskDateApplied.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.mskDateApplied.Location = New System.Drawing.Point(125, 82)
        Me.mskDateApplied.MaxDate = New Date(2099, 12, 31, 0, 0, 0, 0)
        Me.mskDateApplied.Name = "mskDateApplied"
        Me.mskDateApplied.Size = New System.Drawing.Size(138, 26)
        Me.mskDateApplied.TabIndex = 20
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(6, 82)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(53, 19)
        Me.lblID.TabIndex = 19
        Me.lblID.Text = "Label11"
        Me.lblID.Visible = False
        '
        'btnSelect
        '
        Me.btnSelect.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSelect.Location = New System.Drawing.Point(226, 116)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(37, 23)
        Me.btnSelect.TabIndex = 1
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'dgPromissory
        '
        Me.dgPromissory.AllowUserToAddRows = False
        Me.dgPromissory.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgPromissory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgPromissory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPromissory.Location = New System.Drawing.Point(269, 82)
        Me.dgPromissory.Name = "dgPromissory"
        Me.dgPromissory.ReadOnly = True
        Me.dgPromissory.Size = New System.Drawing.Size(329, 211)
        Me.dgPromissory.TabIndex = 17
        '
        'cboStatus
        '
        Me.cboStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Complied", "For Compliance"})
        Me.cboStatus.Location = New System.Drawing.Point(123, 306)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(138, 27)
        Me.cboStatus.Sorted = True
        Me.cboStatus.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(73, 309)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 19)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Status"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(125, 242)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(138, 26)
        Me.txtAmount.TabIndex = 6
        Me.txtAmount.Text = "00.00"
        '
        'txtGuardian
        '
        Me.txtGuardian.Location = New System.Drawing.Point(124, 210)
        Me.txtGuardian.Name = "txtGuardian"
        Me.txtGuardian.Size = New System.Drawing.Size(138, 26)
        Me.txtGuardian.TabIndex = 5
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(123, 178)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(138, 26)
        Me.txtLastName.TabIndex = 4
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(123, 146)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(138, 26)
        Me.txtFirstName.TabIndex = 3
        '
        'txtStudentNumber
        '
        Me.txtStudentNumber.Location = New System.Drawing.Point(123, 114)
        Me.txtStudentNumber.Name = "txtStudentNumber"
        Me.txtStudentNumber.Size = New System.Drawing.Size(101, 26)
        Me.txtStudentNumber.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(24, 280)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 19)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Promised Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(64, 245)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Amount"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(56, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Guardian"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(46, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(45, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(53, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Student #"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(81, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Location = New System.Drawing.Point(6, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(592, 41)
        Me.Panel1.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(10, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 19)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Search"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(377, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PROMISSORY NOTE"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(64, 8)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(120, 26)
        Me.txtSearch.TabIndex = 2
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(119, 11)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(59, 22)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmPromissory
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(628, 372)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPromissory"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "[  Promissory Note  ]"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgPromissory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtGuardian As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtStudentNumber As System.Windows.Forms.TextBox
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dgPromissory As System.Windows.Forms.DataGridView
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents mskPromisedDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents mskDateApplied As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
