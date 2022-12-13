<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmbyauthor
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
        Me.btnPreview = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtAuthor = New System.Windows.Forms.TextBox
        Me.dg1 = New System.Windows.Forms.DataGridView
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.Search = New System.Windows.Forms.Label
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPreview
        '
        Me.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPreview.Location = New System.Drawing.Point(191, 204)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(65, 30)
        Me.btnPreview.TabIndex = 1
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(105, 178)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(65, 16)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Preview"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Author Name"
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(105, 172)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(151, 26)
        Me.txtAuthor.TabIndex = 4
        '
        'dg1
        '
        Me.dg1.AllowUserToAddRows = False
        Me.dg1.AllowUserToDeleteRows = False
        Me.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg1.Location = New System.Drawing.Point(12, 38)
        Me.dg1.Name = "dg1"
        Me.dg1.ReadOnly = True
        Me.dg1.Size = New System.Drawing.Size(244, 123)
        Me.dg1.TabIndex = 5
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(74, 7)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(168, 26)
        Me.txtSearch.TabIndex = 7
        '
        'Search
        '
        Me.Search.AutoSize = True
        Me.Search.Location = New System.Drawing.Point(19, 10)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(48, 19)
        Me.Search.TabIndex = 6
        Me.Search.Text = "Search"
        '
        'frmbyauthor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(268, 242)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.dg1)
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.btnClose)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmbyauthor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAuthor As System.Windows.Forms.TextBox
    Friend WithEvents dg1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Search As System.Windows.Forms.Label
End Class
