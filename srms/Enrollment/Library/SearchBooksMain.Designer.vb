<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchBooksMain
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dg1 = New System.Windows.Forms.DataGridView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.chkSubject = New System.Windows.Forms.CheckBox
        Me.chkAuthor = New System.Windows.Forms.CheckBox
        Me.chkBookTitle = New System.Windows.Forms.CheckBox
        Me.lblSearch = New System.Windows.Forms.Label
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dg1)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(-4, -18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(769, 481)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'dg1
        '
        Me.dg1.AllowUserToAddRows = False
        Me.dg1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dg1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg1.Location = New System.Drawing.Point(6, 64)
        Me.dg1.Name = "dg1"
        Me.dg1.ReadOnly = True
        Me.dg1.Size = New System.Drawing.Size(757, 411)
        Me.dg1.TabIndex = 1
        Me.dg1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.chkSubject)
        Me.Panel1.Controls.Add(Me.chkAuthor)
        Me.Panel1.Controls.Add(Me.chkBookTitle)
        Me.Panel1.Controls.Add(Me.lblSearch)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Location = New System.Drawing.Point(6, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(757, 38)
        Me.Panel1.TabIndex = 0
        '
        'chkSubject
        '
        Me.chkSubject.AutoSize = True
        Me.chkSubject.ForeColor = System.Drawing.Color.White
        Me.chkSubject.Location = New System.Drawing.Point(393, 9)
        Me.chkSubject.Name = "chkSubject"
        Me.chkSubject.Size = New System.Drawing.Size(69, 21)
        Me.chkSubject.TabIndex = 4
        Me.chkSubject.Text = "Subject"
        Me.chkSubject.UseVisualStyleBackColor = True
        '
        'chkAuthor
        '
        Me.chkAuthor.AutoSize = True
        Me.chkAuthor.ForeColor = System.Drawing.Color.White
        Me.chkAuthor.Location = New System.Drawing.Point(321, 9)
        Me.chkAuthor.Name = "chkAuthor"
        Me.chkAuthor.Size = New System.Drawing.Size(66, 21)
        Me.chkAuthor.TabIndex = 3
        Me.chkAuthor.Text = "Author"
        Me.chkAuthor.UseVisualStyleBackColor = True
        '
        'chkBookTitle
        '
        Me.chkBookTitle.AutoSize = True
        Me.chkBookTitle.ForeColor = System.Drawing.Color.White
        Me.chkBookTitle.Location = New System.Drawing.Point(234, 9)
        Me.chkBookTitle.Name = "chkBookTitle"
        Me.chkBookTitle.Size = New System.Drawing.Size(84, 21)
        Me.chkBookTitle.TabIndex = 2
        Me.chkBookTitle.Text = "Book Title"
        Me.chkBookTitle.UseVisualStyleBackColor = True
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.ForeColor = System.Drawing.Color.White
        Me.lblSearch.Location = New System.Drawing.Point(9, 10)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(47, 17)
        Me.lblSearch.TabIndex = 1
        Me.lblSearch.Text = "Search"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(68, 7)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(160, 25)
        Me.txtSearch.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(153, 9)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmSearchBooksMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(762, 463)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSearchBooksMain"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Books"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dg1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents chkSubject As System.Windows.Forms.CheckBox
    Friend WithEvents chkAuthor As System.Windows.Forms.CheckBox
    Friend WithEvents chkBookTitle As System.Windows.Forms.CheckBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
