<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudeRefund
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudeRefund))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtReasons = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblID = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtAmountRefunded = New System.Windows.Forms.TextBox
        Me.txtPercentage = New System.Windows.Forms.TextBox
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.dtpDateIssued = New System.Windows.Forms.DateTimePicker
        Me.txtOR = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dg = New System.Windows.Forms.DataGridView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.btnRefund = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtReasons)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblID)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtAmountRefunded)
        Me.GroupBox1.Controls.Add(Me.txtPercentage)
        Me.GroupBox1.Controls.Add(Me.txtAmount)
        Me.GroupBox1.Controls.Add(Me.dtpDateIssued)
        Me.GroupBox1.Controls.Add(Me.txtOR)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dg)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(593, 267)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'txtReasons
        '
        Me.txtReasons.Location = New System.Drawing.Point(290, 51)
        Me.txtReasons.Multiline = True
        Me.txtReasons.Name = "txtReasons"
        Me.txtReasons.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtReasons.Size = New System.Drawing.Size(277, 58)
        Me.txtReasons.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(227, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 19)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Reasons"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(6, 68)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(22, 19)
        Me.lblID.TabIndex = 15
        Me.lblID.Text = "ID"
        Me.lblID.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(338, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 19)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "%"
        '
        'txtAmountRefunded
        '
        Me.txtAmountRefunded.Location = New System.Drawing.Point(480, 19)
        Me.txtAmountRefunded.Name = "txtAmountRefunded"
        Me.txtAmountRefunded.Size = New System.Drawing.Size(87, 26)
        Me.txtAmountRefunded.TabIndex = 12
        '
        'txtPercentage
        '
        Me.txtPercentage.Location = New System.Drawing.Point(290, 19)
        Me.txtPercentage.Name = "txtPercentage"
        Me.txtPercentage.Size = New System.Drawing.Size(42, 26)
        Me.txtPercentage.TabIndex = 11
        Me.txtPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(80, 51)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.ReadOnly = True
        Me.txtAmount.Size = New System.Drawing.Size(114, 26)
        Me.txtAmount.TabIndex = 10
        '
        'dtpDateIssued
        '
        Me.dtpDateIssued.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateIssued.Location = New System.Drawing.Point(80, 83)
        Me.dtpDateIssued.Name = "dtpDateIssued"
        Me.dtpDateIssued.Size = New System.Drawing.Size(114, 26)
        Me.dtpDateIssued.TabIndex = 9
        '
        'txtOR
        '
        Me.txtOR.Location = New System.Drawing.Point(80, 19)
        Me.txtOR.Name = "txtOR"
        Me.txtOR.ReadOnly = True
        Me.txtOR.Size = New System.Drawing.Size(114, 26)
        Me.txtOR.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(363, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 19)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Amount Refunded"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(211, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Percentage"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Amount"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "O.R. No."
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(6, 157)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.Size = New System.Drawing.Size(581, 104)
        Me.dg.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.btnRefund)
        Me.Panel1.Location = New System.Drawing.Point(6, 124)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(581, 32)
        Me.Panel1.TabIndex = 1
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(94, 3)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(118, 26)
        Me.txtSearch.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label10.Location = New System.Drawing.Point(13, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 19)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Search O.R."
        '
        'btnRefund
        '
        Me.btnRefund.Location = New System.Drawing.Point(474, 2)
        Me.btnRefund.Name = "btnRefund"
        Me.btnRefund.Size = New System.Drawing.Size(87, 27)
        Me.btnRefund.TabIndex = 13
        Me.btnRefund.Text = "Refund"
        Me.btnRefund.UseVisualStyleBackColor = True
        '
        'frmRefund
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(617, 302)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRefund"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "[  Refund Form  ]"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAmountRefunded As System.Windows.Forms.TextBox
    Friend WithEvents txtPercentage As System.Windows.Forms.TextBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents dtpDateIssued As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtOR As System.Windows.Forms.TextBox
    Friend WithEvents btnRefund As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents txtReasons As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
