<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompleteList
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompleteList))
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.chkLastName = New System.Windows.Forms.CheckBox
        Me.chkStudentNumber = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.dgstudentsearch = New System.Windows.Forms.DataGridView
        Me.GroupBox6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgstudentsearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Panel1)
        Me.GroupBox6.Controls.Add(Me.dgstudentsearch)
        Me.GroupBox6.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Black
        Me.GroupBox6.Location = New System.Drawing.Point(-5, -5)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(625, 328)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.chkLastName)
        Me.Panel1.Controls.Add(Me.chkStudentNumber)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Location = New System.Drawing.Point(6, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(613, 38)
        Me.Panel1.TabIndex = 1
        '
        'chkLastName
        '
        Me.chkLastName.AutoSize = True
        Me.chkLastName.ForeColor = System.Drawing.Color.White
        Me.chkLastName.Location = New System.Drawing.Point(373, 10)
        Me.chkLastName.Name = "chkLastName"
        Me.chkLastName.Size = New System.Drawing.Size(82, 22)
        Me.chkLastName.TabIndex = 29
        Me.chkLastName.Text = "Last Name"
        Me.chkLastName.UseVisualStyleBackColor = True
        '
        'chkStudentNumber
        '
        Me.chkStudentNumber.AutoSize = True
        Me.chkStudentNumber.ForeColor = System.Drawing.Color.White
        Me.chkStudentNumber.Location = New System.Drawing.Point(291, 10)
        Me.chkStudentNumber.Name = "chkStudentNumber"
        Me.chkStudentNumber.Size = New System.Drawing.Size(49, 22)
        Me.chkStudentNumber.TabIndex = 28
        Me.chkStudentNumber.Text = "LRN"
        Me.chkStudentNumber.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(19, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 18)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Search"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.Location = New System.Drawing.Point(67, 8)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(218, 25)
        Me.txtSearch.TabIndex = 2
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(224, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(61, 24)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'dgstudentsearch
        '
        Me.dgstudentsearch.AllowUserToAddRows = False
        Me.dgstudentsearch.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgstudentsearch.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgstudentsearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgstudentsearch.Location = New System.Drawing.Point(6, 52)
        Me.dgstudentsearch.Name = "dgstudentsearch"
        Me.dgstudentsearch.ReadOnly = True
        Me.dgstudentsearch.Size = New System.Drawing.Size(613, 276)
        Me.dgstudentsearch.TabIndex = 4
        '
        'frmCompleteList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(617, 323)
        Me.Controls.Add(Me.GroupBox6)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCompleteList"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "[  Complete List  ]"
        Me.GroupBox6.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgstudentsearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents dgstudentsearch As System.Windows.Forms.DataGridView
    Friend WithEvents CourseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents chkLastName As System.Windows.Forms.CheckBox
    Friend WithEvents chkStudentNumber As System.Windows.Forms.CheckBox
End Class
