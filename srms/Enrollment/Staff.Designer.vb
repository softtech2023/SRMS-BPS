<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStaff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStaff))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.tbEmployeeDetails = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.dtpBirthDate = New System.Windows.Forms.DateTimePicker
        Me.Label21 = New System.Windows.Forms.Label
        Me.dtpHiredDate = New System.Windows.Forms.DateTimePicker
        Me.Label20 = New System.Windows.Forms.Label
        Me.mskIDNumber = New System.Windows.Forms.MaskedTextBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.btnDelete = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.dgProfile = New System.Windows.Forms.DataGridView
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.cboEmpStatus = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtContact = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cboMStatus = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtDepartment = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtPosition = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.txtPositionHistory = New System.Windows.Forms.TextBox
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.txtEducationAndTrainings = New System.Windows.Forms.TextBox
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.txtCertificatesAndLicenses = New System.Windows.Forms.TextBox
        Me.tbECInfo = New System.Windows.Forms.TabPage
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtMobile = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtRelationship = New System.Windows.Forms.TextBox
        Me.mskPhoneNumber = New System.Windows.Forms.MaskedTextBox
        Me.txtAddress2 = New System.Windows.Forms.TextBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtSSS = New System.Windows.Forms.TextBox
        Me.txtPhilHealth = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPagibig = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtRPay = New System.Windows.Forms.TextBox
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.txtNotes = New System.Windows.Forms.TextBox
        Me.Panel2.SuspendLayout()
        Me.tbEmployeeDetails.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.tbECInfo.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.tbEmployeeDetails)
        Me.Panel2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(747, 433)
        Me.Panel2.TabIndex = 0
        '
        'tbEmployeeDetails
        '
        Me.tbEmployeeDetails.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.tbEmployeeDetails.Controls.Add(Me.TabPage1)
        Me.tbEmployeeDetails.Controls.Add(Me.TabPage2)
        Me.tbEmployeeDetails.Controls.Add(Me.TabPage3)
        Me.tbEmployeeDetails.Controls.Add(Me.TabPage4)
        Me.tbEmployeeDetails.Controls.Add(Me.tbECInfo)
        Me.tbEmployeeDetails.Controls.Add(Me.TabPage5)
        Me.tbEmployeeDetails.Controls.Add(Me.TabPage6)
        Me.tbEmployeeDetails.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmployeeDetails.Location = New System.Drawing.Point(3, 17)
        Me.tbEmployeeDetails.Name = "tbEmployeeDetails"
        Me.tbEmployeeDetails.SelectedIndex = 0
        Me.tbEmployeeDetails.Size = New System.Drawing.Size(741, 413)
        Me.tbEmployeeDetails.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.dtpBirthDate)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.dtpHiredDate)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.mskIDNumber)
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Controls.Add(Me.dgProfile)
        Me.TabPage1.Controls.Add(Me.txtAddress)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.cboEmpStatus)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.txtContact)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.cboMStatus)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.txtDepartment)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txtPosition)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtFirstName)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.ForeColor = System.Drawing.Color.Black
        Me.TabPage1.Location = New System.Drawing.Point(4, 30)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(733, 379)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Employee Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dtpBirthDate
        '
        Me.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBirthDate.Location = New System.Drawing.Point(117, 111)
        Me.dtpBirthDate.Name = "dtpBirthDate"
        Me.dtpBirthDate.Size = New System.Drawing.Size(120, 25)
        Me.dtpBirthDate.TabIndex = 9
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(47, 116)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(64, 18)
        Me.Label21.TabIndex = 36
        Me.Label21.Text = "Birth Date:"
        '
        'dtpHiredDate
        '
        Me.dtpHiredDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHiredDate.Location = New System.Drawing.Point(117, 80)
        Me.dtpHiredDate.Name = "dtpHiredDate"
        Me.dtpHiredDate.Size = New System.Drawing.Size(120, 25)
        Me.dtpHiredDate.TabIndex = 6
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(43, 85)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(68, 18)
        Me.Label20.TabIndex = 34
        Me.Label20.Text = "Date Hired:"
        '
        'mskIDNumber
        '
        Me.mskIDNumber.Location = New System.Drawing.Point(117, 18)
        Me.mskIDNumber.Name = "mskIDNumber"
        Me.mskIDNumber.Size = New System.Drawing.Size(120, 25)
        Me.mskIDNumber.TabIndex = 1
        Me.mskIDNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel3.Controls.Add(Me.txtSearch)
        Me.Panel3.Controls.Add(Me.btnDelete)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.btnUpdate)
        Me.Panel3.Controls.Add(Me.btnSave)
        Me.Panel3.Location = New System.Drawing.Point(3, 182)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(724, 35)
        Me.Panel3.TabIndex = 12
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.White
        Me.txtSearch.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.Location = New System.Drawing.Point(114, 5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(120, 25)
        Me.txtSearch.TabIndex = 15
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(630, 1)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 32)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(66, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 18)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Search"
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Black
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Image)
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.Location = New System.Drawing.Point(549, 1)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 32)
        Me.btnUpdate.TabIndex = 14
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(468, 1)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 32)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "&Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'dgProfile
        '
        Me.dgProfile.AllowUserToAddRows = False
        Me.dgProfile.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgProfile.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgProfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProfile.Location = New System.Drawing.Point(3, 220)
        Me.dgProfile.Name = "dgProfile"
        Me.dgProfile.ReadOnly = True
        Me.dgProfile.Size = New System.Drawing.Size(724, 154)
        Me.dgProfile.TabIndex = 15
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(357, 113)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtAddress.Size = New System.Drawing.Size(351, 45)
        Me.txtAddress.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(298, 116)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 18)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Address:"
        '
        'cboEmpStatus
        '
        Me.cboEmpStatus.FormattingEnabled = True
        Me.cboEmpStatus.Location = New System.Drawing.Point(357, 80)
        Me.cboEmpStatus.Name = "cboEmpStatus"
        Me.cboEmpStatus.Size = New System.Drawing.Size(120, 26)
        Me.cboEmpStatus.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(279, 85)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 18)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Emp. Status:"
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(117, 142)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(120, 25)
        Me.txtContact.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(50, 145)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 18)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Contact #:"
        '
        'cboMStatus
        '
        Me.cboMStatus.FormattingEnabled = True
        Me.cboMStatus.Items.AddRange(New Object() {"Single", "Married"})
        Me.cboMStatus.Location = New System.Drawing.Point(588, 82)
        Me.cboMStatus.Name = "cboMStatus"
        Me.cboMStatus.Size = New System.Drawing.Size(120, 26)
        Me.cboMStatus.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(499, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 18)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Marital Status:"
        '
        'txtDepartment
        '
        Me.txtDepartment.Location = New System.Drawing.Point(357, 49)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Size = New System.Drawing.Size(351, 25)
        Me.txtDepartment.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(277, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 18)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Department:"
        '
        'txtPosition
        '
        Me.txtPosition.Location = New System.Drawing.Point(117, 49)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(120, 25)
        Me.txtPosition.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(57, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Position:"
        '
        'txtFirstName
        '
        Me.txtFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFirstName.Location = New System.Drawing.Point(357, 18)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(351, 25)
        Me.txtFirstName.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(41, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ID Number:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(309, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtPositionHistory)
        Me.TabPage2.Location = New System.Drawing.Point(4, 30)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(733, 379)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Position History"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtPositionHistory
        '
        Me.txtPositionHistory.Location = New System.Drawing.Point(13, 3)
        Me.txtPositionHistory.Multiline = True
        Me.txtPositionHistory.Name = "txtPositionHistory"
        Me.txtPositionHistory.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtPositionHistory.Size = New System.Drawing.Size(717, 374)
        Me.txtPositionHistory.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txtEducationAndTrainings)
        Me.TabPage3.Location = New System.Drawing.Point(4, 30)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(733, 379)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Educ. & Trainings"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txtEducationAndTrainings
        '
        Me.txtEducationAndTrainings.Location = New System.Drawing.Point(12, 3)
        Me.txtEducationAndTrainings.Multiline = True
        Me.txtEducationAndTrainings.Name = "txtEducationAndTrainings"
        Me.txtEducationAndTrainings.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtEducationAndTrainings.Size = New System.Drawing.Size(718, 374)
        Me.txtEducationAndTrainings.TabIndex = 1
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.txtCertificatesAndLicenses)
        Me.TabPage4.Location = New System.Drawing.Point(4, 30)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(733, 379)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Certificates/Licenses"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'txtCertificatesAndLicenses
        '
        Me.txtCertificatesAndLicenses.Location = New System.Drawing.Point(12, 3)
        Me.txtCertificatesAndLicenses.Multiline = True
        Me.txtCertificatesAndLicenses.Name = "txtCertificatesAndLicenses"
        Me.txtCertificatesAndLicenses.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtCertificatesAndLicenses.Size = New System.Drawing.Size(718, 374)
        Me.txtCertificatesAndLicenses.TabIndex = 1
        '
        'tbECInfo
        '
        Me.tbECInfo.Controls.Add(Me.txtEmail)
        Me.tbECInfo.Controls.Add(Me.Label19)
        Me.tbECInfo.Controls.Add(Me.txtMobile)
        Me.tbECInfo.Controls.Add(Me.Label18)
        Me.tbECInfo.Controls.Add(Me.txtRelationship)
        Me.tbECInfo.Controls.Add(Me.mskPhoneNumber)
        Me.tbECInfo.Controls.Add(Me.txtAddress2)
        Me.tbECInfo.Controls.Add(Me.txtName)
        Me.tbECInfo.Controls.Add(Me.Label17)
        Me.tbECInfo.Controls.Add(Me.Label16)
        Me.tbECInfo.Controls.Add(Me.Label15)
        Me.tbECInfo.Controls.Add(Me.Label14)
        Me.tbECInfo.Controls.Add(Me.Label13)
        Me.tbECInfo.ForeColor = System.Drawing.Color.Black
        Me.tbECInfo.Location = New System.Drawing.Point(4, 30)
        Me.tbECInfo.Name = "tbECInfo"
        Me.tbECInfo.Size = New System.Drawing.Size(733, 379)
        Me.tbECInfo.TabIndex = 4
        Me.tbECInfo.Text = "Emergency Contact Info"
        Me.tbECInfo.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(316, 162)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(126, 25)
        Me.txtEmail.TabIndex = 5
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(262, 165)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(44, 18)
        Me.Label19.TabIndex = 11
        Me.Label19.Text = "E-mail:"
        '
        'txtMobile
        '
        Me.txtMobile.Location = New System.Drawing.Point(316, 87)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(126, 25)
        Me.txtMobile.TabIndex = 2
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(261, 90)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(48, 18)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "Mobile:"
        '
        'txtRelationship
        '
        Me.txtRelationship.Location = New System.Drawing.Point(129, 162)
        Me.txtRelationship.Name = "txtRelationship"
        Me.txtRelationship.Size = New System.Drawing.Size(126, 25)
        Me.txtRelationship.TabIndex = 4
        '
        'mskPhoneNumber
        '
        Me.mskPhoneNumber.Location = New System.Drawing.Point(129, 87)
        Me.mskPhoneNumber.Mask = "(999) 000-0000"
        Me.mskPhoneNumber.Name = "mskPhoneNumber"
        Me.mskPhoneNumber.Size = New System.Drawing.Size(126, 25)
        Me.mskPhoneNumber.TabIndex = 1
        '
        'txtAddress2
        '
        Me.txtAddress2.Location = New System.Drawing.Point(129, 122)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(313, 25)
        Me.txtAddress2.TabIndex = 3
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(129, 55)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(313, 25)
        Me.txtName.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(41, 165)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(76, 18)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Relationship:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(64, 125)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 18)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Address:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(26, 90)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 18)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Phone Number:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(77, 58)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 18)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Name:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(14, 26)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(270, 16)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Person to be contacted in case of emergency:"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.GroupBox2)
        Me.TabPage5.Controls.Add(Me.GroupBox1)
        Me.TabPage5.Location = New System.Drawing.Point(4, 30)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(733, 379)
        Me.TabPage5.TabIndex = 6
        Me.TabPage5.Text = "Deductions"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtSSS)
        Me.GroupBox2.Controls.Add(Me.txtPhilHealth)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtPagibig)
        Me.GroupBox2.Location = New System.Drawing.Point(281, 18)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(257, 162)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Deductions"
        '
        'txtSSS
        '
        Me.txtSSS.Location = New System.Drawing.Point(95, 103)
        Me.txtSSS.Name = "txtSSS"
        Me.txtSSS.Size = New System.Drawing.Size(86, 25)
        Me.txtSSS.TabIndex = 16
        Me.txtSSS.Text = "0.00"
        Me.txtSSS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPhilHealth
        '
        Me.txtPhilHealth.Location = New System.Drawing.Point(95, 72)
        Me.txtPhilHealth.Name = "txtPhilHealth"
        Me.txtPhilHealth.Size = New System.Drawing.Size(86, 25)
        Me.txtPhilHealth.TabIndex = 15
        Me.txtPhilHealth.Text = "0.00"
        Me.txtPhilHealth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(60, 106)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(26, 18)
        Me.Label22.TabIndex = 14
        Me.Label22.Text = "SSS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(23, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 18)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "PhilHealth"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(32, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 18)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Pag-Ibig"
        '
        'txtPagibig
        '
        Me.txtPagibig.Location = New System.Drawing.Point(95, 41)
        Me.txtPagibig.Name = "txtPagibig"
        Me.txtPagibig.Size = New System.Drawing.Size(86, 25)
        Me.txtPagibig.TabIndex = 11
        Me.txtPagibig.Text = "0.00"
        Me.txtPagibig.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtRPay)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(257, 162)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Earnings"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(27, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 18)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Regular Pay"
        '
        'txtRPay
        '
        Me.txtRPay.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRPay.Location = New System.Drawing.Point(106, 41)
        Me.txtRPay.Name = "txtRPay"
        Me.txtRPay.Size = New System.Drawing.Size(105, 30)
        Me.txtRPay.TabIndex = 11
        Me.txtRPay.Text = "0.00"
        Me.txtRPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.txtNotes)
        Me.TabPage6.Location = New System.Drawing.Point(4, 30)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(733, 379)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Notes"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(12, 3)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtNotes.Size = New System.Drawing.Size(721, 374)
        Me.txtNotes.TabIndex = 1
        '
        'frmStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(771, 457)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStaff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Faculty and Staff Data Entry"
        Me.Panel2.ResumeLayout(False)
        Me.tbEmployeeDetails.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.tbECInfo.ResumeLayout(False)
        Me.tbECInfo.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents tbEmployeeDetails As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents mskIDNumber As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents dgProfile As System.Windows.Forms.DataGridView
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboEmpStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboMStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDepartment As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPosition As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents tbECInfo As System.Windows.Forms.TabPage
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtRelationship As System.Windows.Forms.TextBox
    Friend WithEvents mskPhoneNumber As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents dtpHiredDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents dtpBirthDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtPositionHistory As System.Windows.Forms.TextBox
    Friend WithEvents txtEducationAndTrainings As System.Windows.Forms.TextBox
    Friend WithEvents txtCertificatesAndLicenses As System.Windows.Forms.TextBox
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents txtRPay As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPagibig As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSSS As System.Windows.Forms.TextBox
    Friend WithEvents txtPhilHealth As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
