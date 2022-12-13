<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOtherIncome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOtherIncome))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rdoCreditCard = New System.Windows.Forms.RadioButton
        Me.btnSelect = New System.Windows.Forms.Button
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtBank = New System.Windows.Forms.TextBox
        Me.lblSource = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.lblID = New System.Windows.Forms.Label
        Me.mskStudentNumber = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.RadioButtonCash = New System.Windows.Forms.RadioButton
        Me.RadioButtonCheck = New System.Windows.Forms.RadioButton
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.txtOR = New System.Windows.Forms.TextBox
        Me.txtMName = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtFname = New System.Windows.Forms.TextBox
        Me.txtcheck = New System.Windows.Forms.TextBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.txtDescription = New System.Windows.Forms.ComboBox
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtDescription)
        Me.GroupBox2.Controls.Add(Me.rdoCreditCard)
        Me.GroupBox2.Controls.Add(Me.btnSelect)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtBank)
        Me.GroupBox2.Controls.Add(Me.lblSource)
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
        Me.GroupBox2.Controls.Add(Me.RadioButtonCheck)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtLastName)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtAddress)
        Me.GroupBox2.Controls.Add(Me.txtOR)
        Me.GroupBox2.Controls.Add(Me.txtMName)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtFname)
        Me.GroupBox2.Controls.Add(Me.txtcheck)
        Me.GroupBox2.Controls.Add(Me.btnCancel)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(504, 378)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Payment Details"
        '
        'rdoCreditCard
        '
        Me.rdoCreditCard.AutoSize = True
        Me.rdoCreditCard.ForeColor = System.Drawing.Color.Black
        Me.rdoCreditCard.Location = New System.Drawing.Point(295, 266)
        Me.rdoCreditCard.Name = "rdoCreditCard"
        Me.rdoCreditCard.Size = New System.Drawing.Size(92, 23)
        Me.rdoCreditCard.TabIndex = 39
        Me.rdoCreditCard.TabStop = True
        Me.rdoCreditCard.Text = "Credit Card"
        Me.rdoCreditCard.UseVisualStyleBackColor = True
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(227, 40)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(58, 26)
        Me.btnSelect.TabIndex = 38
        Me.btnSelect.TabStop = False
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(79, 330)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(82, 19)
        Me.Label17.TabIndex = 37
        Me.Label17.Text = "Bank/Branch"
        '
        'txtBank
        '
        Me.txtBank.Location = New System.Drawing.Point(167, 327)
        Me.txtBank.Name = "txtBank"
        Me.txtBank.Size = New System.Drawing.Size(311, 26)
        Me.txtBank.TabIndex = 14
        '
        'lblSource
        '
        Me.lblSource.AutoSize = True
        Me.lblSource.Location = New System.Drawing.Point(346, 298)
        Me.lblSource.Name = "lblSource"
        Me.lblSource.Size = New System.Drawing.Size(56, 19)
        Me.lblSource.TabIndex = 30
        Me.lblSource.Text = "Services"
        Me.lblSource.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(39, 266)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(89, 19)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "Payment Type"
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
        Me.mskStudentNumber.Size = New System.Drawing.Size(87, 26)
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
        'txtAmount
        '
        Me.txtAmount.ForeColor = System.Drawing.Color.Black
        Me.txtAmount.Location = New System.Drawing.Point(350, 202)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(128, 26)
        Me.txtAmount.TabIndex = 8
        Me.txtAmount.Text = "0.00"
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(72, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 19)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "O.R. No."
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(291, 205)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 19)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Amount"
        '
        'RadioButtonCash
        '
        Me.RadioButtonCash.AutoSize = True
        Me.RadioButtonCash.ForeColor = System.Drawing.Color.Black
        Me.RadioButtonCash.Location = New System.Drawing.Point(134, 266)
        Me.RadioButtonCash.Name = "RadioButtonCash"
        Me.RadioButtonCash.Size = New System.Drawing.Size(55, 23)
        Me.RadioButtonCash.TabIndex = 10
        Me.RadioButtonCash.TabStop = True
        Me.RadioButtonCash.Text = "Cash"
        Me.RadioButtonCash.UseVisualStyleBackColor = True
        '
        'RadioButtonCheck
        '
        Me.RadioButtonCheck.AutoSize = True
        Me.RadioButtonCheck.ForeColor = System.Drawing.Color.Black
        Me.RadioButtonCheck.Location = New System.Drawing.Point(224, 266)
        Me.RadioButtonCheck.Name = "RadioButtonCheck"
        Me.RadioButtonCheck.Size = New System.Drawing.Size(61, 23)
        Me.RadioButtonCheck.TabIndex = 11
        Me.RadioButtonCheck.TabStop = True
        Me.RadioButtonCheck.Text = "Check"
        Me.RadioButtonCheck.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(24, 298)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 19)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Credit Card/Check No."
        '
        'txtLastName
        '
        Me.txtLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLastName.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.ForeColor = System.Drawing.Color.Black
        Me.txtLastName.Location = New System.Drawing.Point(134, 136)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(151, 26)
        Me.txtLastName.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(55, 237)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 19)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Description"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.Color.Black
        Me.txtAddress.Location = New System.Drawing.Point(134, 168)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(344, 26)
        Me.txtAddress.TabIndex = 5
        '
        'txtOR
        '
        Me.txtOR.ForeColor = System.Drawing.Color.Black
        Me.txtOR.Location = New System.Drawing.Point(134, 202)
        Me.txtOR.Name = "txtOR"
        Me.txtOR.ReadOnly = True
        Me.txtOR.Size = New System.Drawing.Size(151, 26)
        Me.txtOR.TabIndex = 7
        '
        'txtMName
        '
        Me.txtMName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMName.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMName.ForeColor = System.Drawing.Color.Black
        Me.txtMName.Location = New System.Drawing.Point(134, 104)
        Me.txtMName.Name = "txtMName"
        Me.txtMName.Size = New System.Drawing.Size(151, 26)
        Me.txtMName.TabIndex = 3
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
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(73, 171)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 19)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Address"
        '
        'txtFname
        '
        Me.txtFname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFname.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFname.ForeColor = System.Drawing.Color.Black
        Me.txtFname.Location = New System.Drawing.Point(134, 72)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(151, 26)
        Me.txtFname.TabIndex = 2
        '
        'txtcheck
        '
        Me.txtcheck.Enabled = False
        Me.txtcheck.ForeColor = System.Drawing.Color.Black
        Me.txtcheck.Location = New System.Drawing.Point(167, 295)
        Me.txtcheck.Name = "txtcheck"
        Me.txtcheck.Size = New System.Drawing.Size(177, 26)
        Me.txtcheck.TabIndex = 12
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(230, 75)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(44, 18)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.TabStop = False
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(522, 23)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 42)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "Accept Payment"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtDescription
        '
        Me.txtDescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtDescription.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtDescription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtDescription.FormattingEnabled = True
        Me.txtDescription.Location = New System.Drawing.Point(134, 234)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(344, 27)
        Me.txtDescription.TabIndex = 9
        '
        'frmOtherIncome
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(663, 401)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOtherIncome"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "[  Other Payments  ]"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblSource As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents mskStudentNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents RadioButtonCash As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonCheck As System.Windows.Forms.RadioButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtOR As System.Windows.Forms.TextBox
    Friend WithEvents txtMName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtFname As System.Windows.Forms.TextBox
    Friend WithEvents txtcheck As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtBank As System.Windows.Forms.TextBox
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents rdoCreditCard As System.Windows.Forms.RadioButton
    Friend WithEvents txtDescription As System.Windows.Forms.ComboBox
End Class
