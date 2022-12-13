<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiploma
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dg1 = New System.Windows.Forms.DataGridView
        Me.btnPrintAll = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtStudentNumber = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtFName = New System.Windows.Forms.TextBox
        Me.txtMName = New System.Windows.Forms.TextBox
        Me.txtLName = New System.Windows.Forms.TextBox
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dg1
        '
        Me.dg1.AllowUserToAddRows = False
        Me.dg1.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dg1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg1.Location = New System.Drawing.Point(3, 36)
        Me.dg1.Name = "dg1"
        Me.dg1.Size = New System.Drawing.Size(666, 322)
        Me.dg1.TabIndex = 11
        '
        'btnPrintAll
        '
        Me.btnPrintAll.Location = New System.Drawing.Point(572, 0)
        Me.btnPrintAll.Name = "btnPrintAll"
        Me.btnPrintAll.Size = New System.Drawing.Size(86, 32)
        Me.btnPrintAll.TabIndex = 13
        Me.btnPrintAll.Text = "Print"
        Me.btnPrintAll.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(3, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(666, 35)
        Me.Panel1.TabIndex = 15
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(63, 5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(213, 26)
        Me.txtSearch.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search"
        '
        'txtStudentNumber
        '
        Me.txtStudentNumber.Location = New System.Drawing.Point(3, 3)
        Me.txtStudentNumber.Name = "txtStudentNumber"
        Me.txtStudentNumber.ReadOnly = True
        Me.txtStudentNumber.Size = New System.Drawing.Size(100, 26)
        Me.txtStudentNumber.TabIndex = 16
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtLName)
        Me.Panel2.Controls.Add(Me.txtMName)
        Me.Panel2.Controls.Add(Me.txtFName)
        Me.Panel2.Controls.Add(Me.txtStudentNumber)
        Me.Panel2.Controls.Add(Me.btnPrintAll)
        Me.Panel2.Location = New System.Drawing.Point(3, 364)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(666, 32)
        Me.Panel2.TabIndex = 17
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(109, 4)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.ReadOnly = True
        Me.txtFName.Size = New System.Drawing.Size(143, 26)
        Me.txtFName.TabIndex = 17
        '
        'txtMName
        '
        Me.txtMName.Location = New System.Drawing.Point(258, 4)
        Me.txtMName.Name = "txtMName"
        Me.txtMName.ReadOnly = True
        Me.txtMName.Size = New System.Drawing.Size(143, 26)
        Me.txtMName.TabIndex = 18
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(407, 3)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.ReadOnly = True
        Me.txtLName.Size = New System.Drawing.Size(143, 26)
        Me.txtLName.TabIndex = 19
        '
        'frmDiploma
        '
        Me.AcceptButton = Me.btnPrintAll
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(672, 408)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dg1)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmDiploma"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Diploma"
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dg1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnPrintAll As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtStudentNumber As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents txtMName As System.Windows.Forms.TextBox
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
End Class
