<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVoidOR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVoidOR))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblID = New System.Windows.Forms.Label
        Me.txtReasons = New System.Windows.Forms.TextBox
        Me.txtCashier = New System.Windows.Forms.TextBox
        Me.txtParticulars = New System.Windows.Forms.TextBox
        Me.dtpDatePaid = New System.Windows.Forms.DateTimePicker
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.dtpVoidDate = New System.Windows.Forms.DateTimePicker
        Me.txtORNumber = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tsSave = New System.Windows.Forms.ToolStripButton
        Me.tsSearch = New System.Windows.Forms.ToolStripButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblStudentNumber = New System.Windows.Forms.Label
        Me.txtDiscount = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtTotalPayments = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtBalance = New System.Windows.Forms.TextBox
        Me.txtCurrentPayments = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtTotalAccts = New System.Windows.Forms.TextBox
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblID)
        Me.GroupBox2.Controls.Add(Me.txtReasons)
        Me.GroupBox2.Controls.Add(Me.txtCashier)
        Me.GroupBox2.Controls.Add(Me.txtParticulars)
        Me.GroupBox2.Controls.Add(Me.dtpDatePaid)
        Me.GroupBox2.Controls.Add(Me.txtAmount)
        Me.GroupBox2.Controls.Add(Me.dtpVoidDate)
        Me.GroupBox2.Controls.Add(Me.txtORNumber)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 87)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(540, 303)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(331, 30)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(22, 19)
        Me.lblID.TabIndex = 45
        Me.lblID.Text = "ID"
        Me.lblID.Visible = False
        '
        'txtReasons
        '
        Me.txtReasons.Location = New System.Drawing.Point(107, 236)
        Me.txtReasons.Multiline = True
        Me.txtReasons.Name = "txtReasons"
        Me.txtReasons.Size = New System.Drawing.Size(291, 61)
        Me.txtReasons.TabIndex = 7
        '
        'txtCashier
        '
        Me.txtCashier.Location = New System.Drawing.Point(107, 155)
        Me.txtCashier.Name = "txtCashier"
        Me.txtCashier.ReadOnly = True
        Me.txtCashier.Size = New System.Drawing.Size(291, 26)
        Me.txtCashier.TabIndex = 5
        '
        'txtParticulars
        '
        Me.txtParticulars.Location = New System.Drawing.Point(107, 123)
        Me.txtParticulars.Name = "txtParticulars"
        Me.txtParticulars.ReadOnly = True
        Me.txtParticulars.Size = New System.Drawing.Size(291, 26)
        Me.txtParticulars.TabIndex = 4
        '
        'dtpDatePaid
        '
        Me.dtpDatePaid.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDatePaid.Location = New System.Drawing.Point(107, 91)
        Me.dtpDatePaid.Name = "dtpDatePaid"
        Me.dtpDatePaid.Size = New System.Drawing.Size(149, 26)
        Me.dtpDatePaid.TabIndex = 3
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(107, 59)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.ReadOnly = True
        Me.txtAmount.Size = New System.Drawing.Size(114, 26)
        Me.txtAmount.TabIndex = 2
        Me.txtAmount.Text = "0.00"
        '
        'dtpVoidDate
        '
        Me.dtpVoidDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVoidDate.Location = New System.Drawing.Point(107, 204)
        Me.dtpVoidDate.Name = "dtpVoidDate"
        Me.dtpVoidDate.Size = New System.Drawing.Size(149, 26)
        Me.dtpVoidDate.TabIndex = 6
        '
        'txtORNumber
        '
        Me.txtORNumber.Location = New System.Drawing.Point(107, 27)
        Me.txtORNumber.Name = "txtORNumber"
        Me.txtORNumber.ReadOnly = True
        Me.txtORNumber.Size = New System.Drawing.Size(114, 26)
        Me.txtORNumber.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 19)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Amount"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 19)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Date Paid"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 19)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Particular"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 19)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Void Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(49, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 19)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Cashier"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(44, 239)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 19)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Reasons"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 19)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "O.R. No."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsSave, Me.tsSearch})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(10, 10, 1, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(564, 84)
        Me.ToolStrip1.TabIndex = 30
        '
        'tsSave
        '
        Me.tsSave.Image = CType(resources.GetObject("tsSave.Image"), System.Drawing.Image)
        Me.tsSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSave.Name = "tsSave"
        Me.tsSave.Size = New System.Drawing.Size(65, 71)
        Me.tsSave.Text = "Void O.R."
        Me.tsSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsSearch
        '
        Me.tsSearch.Image = CType(resources.GetObject("tsSearch.Image"), System.Drawing.Image)
        Me.tsSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSearch.Name = "tsSearch"
        Me.tsSearch.Size = New System.Drawing.Size(52, 71)
        Me.tsSearch.Text = "Search"
        Me.tsSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblStudentNumber)
        Me.GroupBox1.Controls.Add(Me.txtDiscount)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtTotalPayments)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtBalance)
        Me.GroupBox1.Controls.Add(Me.txtCurrentPayments)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtTotalAccts)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(449, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(100, 79)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Account Details"
        Me.GroupBox1.Visible = False
        '
        'lblStudentNumber
        '
        Me.lblStudentNumber.AutoSize = True
        Me.lblStudentNumber.Location = New System.Drawing.Point(66, 230)
        Me.lblStudentNumber.Name = "lblStudentNumber"
        Me.lblStudentNumber.Size = New System.Drawing.Size(103, 19)
        Me.lblStudentNumber.TabIndex = 46
        Me.lblStudentNumber.Text = "Student Number"
        '
        'txtDiscount
        '
        Me.txtDiscount.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.Location = New System.Drawing.Point(139, 103)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.ReadOnly = True
        Me.txtDiscount.Size = New System.Drawing.Size(91, 26)
        Me.txtDiscount.TabIndex = 25
        Me.txtDiscount.Text = "0.00"
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(24, 106)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 19)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Discount"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(24, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 19)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Total Account"
        '
        'txtTotalPayments
        '
        Me.txtTotalPayments.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPayments.Location = New System.Drawing.Point(139, 167)
        Me.txtTotalPayments.Name = "txtTotalPayments"
        Me.txtTotalPayments.ReadOnly = True
        Me.txtTotalPayments.Size = New System.Drawing.Size(91, 26)
        Me.txtTotalPayments.TabIndex = 22
        Me.txtTotalPayments.Text = "0.00"
        Me.txtTotalPayments.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(24, 138)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(101, 19)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Current Balance"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(24, 170)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 19)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Total Payments"
        '
        'txtBalance
        '
        Me.txtBalance.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalance.Location = New System.Drawing.Point(139, 135)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.Size = New System.Drawing.Size(91, 26)
        Me.txtBalance.TabIndex = 18
        Me.txtBalance.Text = "0.00"
        Me.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCurrentPayments
        '
        Me.txtCurrentPayments.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentPayments.Location = New System.Drawing.Point(139, 71)
        Me.txtCurrentPayments.Name = "txtCurrentPayments"
        Me.txtCurrentPayments.ReadOnly = True
        Me.txtCurrentPayments.Size = New System.Drawing.Size(91, 26)
        Me.txtCurrentPayments.TabIndex = 17
        Me.txtCurrentPayments.Text = "0.00"
        Me.txtCurrentPayments.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(24, 74)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(111, 19)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Current Payments"
        '
        'txtTotalAccts
        '
        Me.txtTotalAccts.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAccts.Location = New System.Drawing.Point(139, 39)
        Me.txtTotalAccts.Name = "txtTotalAccts"
        Me.txtTotalAccts.ReadOnly = True
        Me.txtTotalAccts.Size = New System.Drawing.Size(91, 26)
        Me.txtTotalAccts.TabIndex = 16
        Me.txtTotalAccts.Text = "0.00"
        Me.txtTotalAccts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmVoidOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(564, 402)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVoidOR"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Void Official Receipts"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpDatePaid As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents dtpVoidDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtORNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtReasons As System.Windows.Forms.TextBox
    Friend WithEvents txtCashier As System.Windows.Forms.TextBox
    Friend WithEvents txtParticulars As System.Windows.Forms.TextBox
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtTotalPayments As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtBalance As System.Windows.Forms.TextBox
    Friend WithEvents txtCurrentPayments As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtTotalAccts As System.Windows.Forms.TextBox
    Friend WithEvents lblStudentNumber As System.Windows.Forms.Label
End Class
