<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddSubjects
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.chkDescription = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.chkSection = New System.Windows.Forms.CheckBox
        Me.chkSubjectCode = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.frmID = New System.Windows.Forms.Label
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.dgsubjects = New System.Windows.Forms.DataGridView
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgsubjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkDescription
        '
        Me.chkDescription.AutoSize = True
        Me.chkDescription.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDescription.ForeColor = System.Drawing.Color.White
        Me.chkDescription.Location = New System.Drawing.Point(335, 9)
        Me.chkDescription.Name = "chkDescription"
        Me.chkDescription.Size = New System.Drawing.Size(92, 23)
        Me.chkDescription.TabIndex = 25
        Me.chkDescription.Text = "Description"
        Me.chkDescription.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.dgsubjects)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(-4, -5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(609, 254)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.chkSection)
        Me.Panel1.Controls.Add(Me.chkDescription)
        Me.Panel1.Controls.Add(Me.chkSubjectCode)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.frmID)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Location = New System.Drawing.Point(6, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(603, 35)
        Me.Panel1.TabIndex = 1
        '
        'chkSection
        '
        Me.chkSection.AutoSize = True
        Me.chkSection.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSection.ForeColor = System.Drawing.Color.White
        Me.chkSection.Location = New System.Drawing.Point(437, 9)
        Me.chkSection.Name = "chkSection"
        Me.chkSection.Size = New System.Drawing.Size(69, 23)
        Me.chkSection.TabIndex = 26
        Me.chkSection.Text = "Section"
        Me.chkSection.UseVisualStyleBackColor = True
        '
        'chkSubjectCode
        '
        Me.chkSubjectCode.AutoSize = True
        Me.chkSubjectCode.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSubjectCode.ForeColor = System.Drawing.Color.White
        Me.chkSubjectCode.Location = New System.Drawing.Point(236, 9)
        Me.chkSubjectCode.Name = "chkSubjectCode"
        Me.chkSubjectCode.Size = New System.Drawing.Size(102, 23)
        Me.chkSubjectCode.TabIndex = 24
        Me.chkSubjectCode.Text = "Subject Code"
        Me.chkSubjectCode.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(27, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Search"
        '
        'frmID
        '
        Me.frmID.AutoSize = True
        Me.frmID.Location = New System.Drawing.Point(527, 10)
        Me.frmID.Name = "frmID"
        Me.frmID.Size = New System.Drawing.Size(17, 15)
        Me.frmID.TabIndex = 2
        Me.frmID.Text = "ID"
        Me.frmID.Visible = False
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.White
        Me.txtSearch.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.Location = New System.Drawing.Point(75, 7)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(155, 26)
        Me.txtSearch.TabIndex = 2
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(166, 12)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(64, 18)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'dgsubjects
        '
        Me.dgsubjects.AllowUserToAddRows = False
        Me.dgsubjects.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.dgsubjects.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgsubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgsubjects.Location = New System.Drawing.Point(6, 51)
        Me.dgsubjects.Name = "dgsubjects"
        Me.dgsubjects.ReadOnly = True
        Me.dgsubjects.Size = New System.Drawing.Size(603, 200)
        Me.dgsubjects.TabIndex = 4
        '
        'frmAddSubjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(600, 244)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddSubjects"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Subjects"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgsubjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chkDescription As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents chkSection As System.Windows.Forms.CheckBox
    Friend WithEvents chkSubjectCode As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents frmID As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents dgsubjects As System.Windows.Forms.DataGridView
End Class
