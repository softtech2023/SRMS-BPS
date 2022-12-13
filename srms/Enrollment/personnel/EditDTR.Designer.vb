<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditDTR
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dg1 = New System.Windows.Forms.DataGridView
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker
        Me.dtpTo = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtEmployeeNo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtEmployeeName = New System.Windows.Forms.TextBox
        Me.btnView = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.btnBatchPrinting = New System.Windows.Forms.Button
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dg1
        '
        Me.dg1.AllowUserToAddRows = False
        Me.dg1.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dg1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg1.Location = New System.Drawing.Point(1, 119)
        Me.dg1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dg1.Name = "dg1"
        Me.dg1.Size = New System.Drawing.Size(711, 343)
        Me.dg1.TabIndex = 4
        '
        'dtpFrom
        '
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrom.Location = New System.Drawing.Point(138, 82)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(107, 26)
        Me.dtpFrom.TabIndex = 5
        '
        'dtpTo
        '
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTo.Location = New System.Drawing.Point(292, 82)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(107, 26)
        Me.dtpTo.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(260, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "to"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(96, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 19)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 19)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Employee No.:"
        '
        'txtEmployeeNo
        '
        Me.txtEmployeeNo.Location = New System.Drawing.Point(138, 18)
        Me.txtEmployeeNo.Name = "txtEmployeeNo"
        Me.txtEmployeeNo.Size = New System.Drawing.Size(142, 26)
        Me.txtEmployeeNo.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 19)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Employee Name:"
        '
        'txtEmployeeName
        '
        Me.txtEmployeeName.Location = New System.Drawing.Point(138, 50)
        Me.txtEmployeeName.Name = "txtEmployeeName"
        Me.txtEmployeeName.Size = New System.Drawing.Size(261, 26)
        Me.txtEmployeeName.TabIndex = 12
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(405, 83)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(113, 29)
        Me.btnView.TabIndex = 13
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(286, 16)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(113, 29)
        Me.btnSearch.TabIndex = 14
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(718, 119)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(113, 35)
        Me.btnUpdate.TabIndex = 15
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(718, 160)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(113, 35)
        Me.btnPrint.TabIndex = 16
        Me.btnPrint.Text = "Print DTR"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnBatchPrinting
        '
        Me.btnBatchPrinting.Location = New System.Drawing.Point(718, 201)
        Me.btnBatchPrinting.Name = "btnBatchPrinting"
        Me.btnBatchPrinting.Size = New System.Drawing.Size(113, 35)
        Me.btnBatchPrinting.TabIndex = 17
        Me.btnBatchPrinting.Text = "Batch Printing"
        Me.btnBatchPrinting.UseVisualStyleBackColor = True
        '
        'frmEditDTR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(837, 469)
        Me.Controls.Add(Me.btnBatchPrinting)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.txtEmployeeName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtEmployeeNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpTo)
        Me.Controls.Add(Me.dtpFrom)
        Me.Controls.Add(Me.dg1)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmEditDTR"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modify DTR ::"
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dg1 As System.Windows.Forms.DataGridView
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtEmployeeNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtEmployeeName As System.Windows.Forms.TextBox
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnBatchPrinting As System.Windows.Forms.Button
End Class
