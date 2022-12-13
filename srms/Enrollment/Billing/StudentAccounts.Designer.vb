<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentAccounts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudentAccounts))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnCompute = New System.Windows.Forms.Button
        Me.txtPayments = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtDiscount = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtCurrentBalance = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtTotalAcct = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtMisc = New System.Windows.Forms.TextBox
        Me.txtLab = New System.Windows.Forms.TextBox
        Me.txtTuition = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtPBalance = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cboYear = New System.Windows.Forms.ComboBox
        Me.cboStatus = New System.Windows.Forms.ComboBox
        Me.cboCourse = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.mskStudentNumber = New System.Windows.Forms.MaskedTextBox
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.txtFname = New System.Windows.Forms.TextBox
        Me.txtMName = New System.Windows.Forms.TextBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.lblID = New System.Windows.Forms.Label
        Me.btnSearch = New System.Windows.Forms.Button
        Me.btnupdate = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnPay = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCompute)
        Me.GroupBox2.Controls.Add(Me.txtPayments)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtDiscount)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtCurrentBalance)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtTotalAcct)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtMisc)
        Me.GroupBox2.Controls.Add(Me.txtLab)
        Me.GroupBox2.Controls.Add(Me.txtTuition)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtPBalance)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(68, 265)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(547, 173)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Account Info"
        '
        'btnCompute
        '
        Me.btnCompute.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCompute.Location = New System.Drawing.Point(413, 136)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(117, 30)
        Me.btnCompute.TabIndex = 16
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'txtPayments
        '
        Me.txtPayments.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtPayments.Location = New System.Drawing.Point(283, 108)
        Me.txtPayments.Name = "txtPayments"
        Me.txtPayments.Size = New System.Drawing.Size(115, 23)
        Me.txtPayments.TabIndex = 15
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(280, 88)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(106, 17)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Total Payments"
        '
        'txtDiscount
        '
        Me.txtDiscount.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDiscount.Location = New System.Drawing.Point(9, 108)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(115, 23)
        Me.txtDiscount.TabIndex = 13
        Me.txtDiscount.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(6, 88)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 17)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Discount"
        '
        'txtCurrentBalance
        '
        Me.txtCurrentBalance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCurrentBalance.Location = New System.Drawing.Point(413, 107)
        Me.txtCurrentBalance.Name = "txtCurrentBalance"
        Me.txtCurrentBalance.ReadOnly = True
        Me.txtCurrentBalance.Size = New System.Drawing.Size(115, 23)
        Me.txtCurrentBalance.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(410, 88)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(110, 17)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Current Balance"
        '
        'txtTotalAcct
        '
        Me.txtTotalAcct.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtTotalAcct.Location = New System.Drawing.Point(148, 108)
        Me.txtTotalAcct.Name = "txtTotalAcct"
        Me.txtTotalAcct.ReadOnly = True
        Me.txtTotalAcct.Size = New System.Drawing.Size(115, 23)
        Me.txtTotalAcct.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(145, 88)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 17)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Total Acct."
        '
        'txtMisc
        '
        Me.txtMisc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtMisc.Location = New System.Drawing.Point(413, 49)
        Me.txtMisc.Name = "txtMisc"
        Me.txtMisc.Size = New System.Drawing.Size(115, 23)
        Me.txtMisc.TabIndex = 7
        Me.txtMisc.Text = "0"
        '
        'txtLab
        '
        Me.txtLab.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtLab.Location = New System.Drawing.Point(283, 49)
        Me.txtLab.Name = "txtLab"
        Me.txtLab.Size = New System.Drawing.Size(115, 23)
        Me.txtLab.TabIndex = 6
        Me.txtLab.Text = "0"
        '
        'txtTuition
        '
        Me.txtTuition.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtTuition.Location = New System.Drawing.Point(148, 49)
        Me.txtTuition.Name = "txtTuition"
        Me.txtTuition.Size = New System.Drawing.Size(115, 23)
        Me.txtTuition.TabIndex = 5
        Me.txtTuition.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(410, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 17)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Misc. Fee"
        '
        'txtPBalance
        '
        Me.txtPBalance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtPBalance.Location = New System.Drawing.Point(9, 49)
        Me.txtPBalance.Name = "txtPBalance"
        Me.txtPBalance.Size = New System.Drawing.Size(115, 23)
        Me.txtPBalance.TabIndex = 3
        Me.txtPBalance.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(280, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 17)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Lab Fee"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(145, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 17)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Tuition Fee"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(6, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Previous Balance"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboYear)
        Me.GroupBox1.Controls.Add(Me.cboStatus)
        Me.GroupBox1.Controls.Add(Me.cboCourse)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.mskStudentNumber)
        Me.GroupBox1.Controls.Add(Me.txtLastName)
        Me.GroupBox1.Controls.Add(Me.txtFname)
        Me.GroupBox1.Controls.Add(Me.txtMName)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(68, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(547, 186)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Profile"
        '
        'cboYear
        '
        Me.cboYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Items.AddRange(New Object() {"1st", "2nd", "3rd", "4th"})
        Me.cboYear.Location = New System.Drawing.Point(181, 148)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(166, 28)
        Me.cboYear.TabIndex = 19
        '
        'cboStatus
        '
        Me.cboStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Paying", "Scholar"})
        Me.cboStatus.Location = New System.Drawing.Point(362, 148)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(166, 28)
        Me.cboStatus.TabIndex = 18
        '
        'cboCourse
        '
        Me.cboCourse.DisplayMember = "coursedescription"
        Me.cboCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCourse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cboCourse.FormattingEnabled = True
        Me.cboCourse.Location = New System.Drawing.Point(9, 148)
        Me.cboCourse.Name = "cboCourse"
        Me.cboCourse.Size = New System.Drawing.Size(166, 28)
        Me.cboCourse.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(178, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 17)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Year"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(6, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Course"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(359, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Status"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(178, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Middle Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(164, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Student Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(6, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Firstname"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(359, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Lastname"
        '
        'mskStudentNumber
        '
        Me.mskStudentNumber.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.mskStudentNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskStudentNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.mskStudentNumber.Location = New System.Drawing.Point(318, 16)
        Me.mskStudentNumber.Name = "mskStudentNumber"
        Me.mskStudentNumber.ReadOnly = True
        Me.mskStudentNumber.Size = New System.Drawing.Size(212, 30)
        Me.mskStudentNumber.TabIndex = 1
        '
        'txtLastName
        '
        Me.txtLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtLastName.Location = New System.Drawing.Point(363, 81)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.ReadOnly = True
        Me.txtLastName.Size = New System.Drawing.Size(166, 26)
        Me.txtLastName.TabIndex = 9
        '
        'txtFname
        '
        Me.txtFname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtFname.Location = New System.Drawing.Point(9, 81)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.ReadOnly = True
        Me.txtFname.Size = New System.Drawing.Size(166, 26)
        Me.txtFname.TabIndex = 6
        '
        'txtMName
        '
        Me.txtMName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtMName.Location = New System.Drawing.Point(181, 81)
        Me.txtMName.Name = "txtMName"
        Me.txtMName.ReadOnly = True
        Me.txtMName.Size = New System.Drawing.Size(166, 26)
        Me.txtMName.TabIndex = 7
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(533, 25)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(82, 33)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "Search Billing"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(478, 29)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(45, 13)
        Me.lblID.TabIndex = 18
        Me.lblID.Text = "Label16"
        Me.lblID.Visible = False
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(68, 13)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(42, 45)
        Me.btnSearch.TabIndex = 17
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Image = CType(resources.GetObject("btnupdate.Image"), System.Drawing.Image)
        Me.btnupdate.Location = New System.Drawing.Point(164, 13)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(42, 45)
        Me.btnupdate.TabIndex = 16
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(116, 13)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(42, 45)
        Me.btnSave.TabIndex = 15
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnPay
        '
        Me.btnPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.Location = New System.Drawing.Point(212, 14)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(42, 45)
        Me.btnPay.TabIndex = 14
        Me.btnPay.Text = "Pay"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'frmStudentAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 492)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmStudentAccounts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student's Accounts"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents txtPayments As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtCurrentBalance As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtTotalAcct As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtMisc As System.Windows.Forms.TextBox
    Friend WithEvents txtLab As System.Windows.Forms.TextBox
    Friend WithEvents txtTuition As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtPBalance As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboYear As System.Windows.Forms.ComboBox
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cboCourse As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents mskStudentNumber As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFname As System.Windows.Forms.TextBox
    Friend WithEvents txtMName As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnPay As System.Windows.Forms.Button
End Class
