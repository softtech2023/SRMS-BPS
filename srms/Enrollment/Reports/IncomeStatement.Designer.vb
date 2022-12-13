<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIncomeStatement
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtIncome = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnLoad = New System.Windows.Forms.Button
        Me.dtpTo = New System.Windows.Forms.DateTimePicker
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnPrintPreview = New System.Windows.Forms.Button
        Me.txtExpenses = New System.Windows.Forms.TextBox
        Me.txtStudeAccts = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblIncome = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblIncome)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtIncome)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.txtExpenses)
        Me.GroupBox1.Controls.Add(Me.txtStudeAccts)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(493, 241)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(34, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 19)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Net Income/Loss"
        '
        'txtIncome
        '
        Me.txtIncome.AutoSize = True
        Me.txtIncome.Font = New System.Drawing.Font("Segoe Condensed", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIncome.ForeColor = System.Drawing.Color.Black
        Me.txtIncome.Location = New System.Drawing.Point(290, 135)
        Me.txtIncome.Name = "txtIncome"
        Me.txtIncome.Size = New System.Drawing.Size(61, 34)
        Me.txtIncome.TabIndex = 14
        Me.txtIncome.Text = "0.00"
        Me.txtIncome.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtIncome.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnLoad)
        Me.Panel1.Controls.Add(Me.dtpTo)
        Me.Panel1.Controls.Add(Me.dtpFrom)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.btnPrintPreview)
        Me.Panel1.Location = New System.Drawing.Point(6, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(481, 41)
        Me.Panel1.TabIndex = 1
        '
        'btnLoad
        '
        Me.btnLoad.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.Location = New System.Drawing.Point(318, 6)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 31)
        Me.btnLoad.TabIndex = 4
        Me.btnLoad.Text = "&View"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'dtpTo
        '
        Me.dtpTo.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTo.Location = New System.Drawing.Point(201, 6)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(111, 26)
        Me.dtpTo.TabIndex = 3
        '
        'dtpFrom
        '
        Me.dtpFrom.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrom.Location = New System.Drawing.Point(58, 6)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(111, 26)
        Me.dtpFrom.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(175, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 19)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "to"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(14, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 19)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "From"
        '
        'btnPrintPreview
        '
        Me.btnPrintPreview.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintPreview.ForeColor = System.Drawing.Color.Black
        Me.btnPrintPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrintPreview.Location = New System.Drawing.Point(399, 6)
        Me.btnPrintPreview.Name = "btnPrintPreview"
        Me.btnPrintPreview.Size = New System.Drawing.Size(75, 31)
        Me.btnPrintPreview.TabIndex = 5
        Me.btnPrintPreview.Text = "&Print"
        Me.btnPrintPreview.UseVisualStyleBackColor = True
        '
        'txtExpenses
        '
        Me.txtExpenses.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtExpenses.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpenses.ForeColor = System.Drawing.Color.Black
        Me.txtExpenses.Location = New System.Drawing.Point(146, 153)
        Me.txtExpenses.Name = "txtExpenses"
        Me.txtExpenses.ReadOnly = True
        Me.txtExpenses.Size = New System.Drawing.Size(111, 26)
        Me.txtExpenses.TabIndex = 3
        Me.txtExpenses.TabStop = False
        Me.txtExpenses.Text = "0.00"
        Me.txtExpenses.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStudeAccts
        '
        Me.txtStudeAccts.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtStudeAccts.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudeAccts.ForeColor = System.Drawing.Color.Black
        Me.txtStudeAccts.Location = New System.Drawing.Point(146, 107)
        Me.txtStudeAccts.Name = "txtStudeAccts"
        Me.txtStudeAccts.ReadOnly = True
        Me.txtStudeAccts.Size = New System.Drawing.Size(111, 26)
        Me.txtStudeAccts.TabIndex = 1
        Me.txtStudeAccts.TabStop = False
        Me.txtStudeAccts.Text = "0.00"
        Me.txtStudeAccts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(78, 156)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 19)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Expenses"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(89, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Income"
        '
        'lblIncome
        '
        Me.lblIncome.AutoSize = True
        Me.lblIncome.Font = New System.Drawing.Font("Segoe Condensed", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncome.Location = New System.Drawing.Point(146, 194)
        Me.lblIncome.Name = "lblIncome"
        Me.lblIncome.Size = New System.Drawing.Size(61, 34)
        Me.lblIncome.TabIndex = 16
        Me.lblIncome.Text = "0.00"
        '
        'frmIncomeStatement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 269)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmIncomeStatement"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "[  Income Statement  ]"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnPrintPreview As System.Windows.Forms.Button
    Friend WithEvents txtExpenses As System.Windows.Forms.TextBox
    Friend WithEvents txtStudeAccts As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtIncome As System.Windows.Forms.Label
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblIncome As System.Windows.Forms.Label
End Class
