<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrevSchool
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrevSchool))
        Me.dg1 = New System.Windows.Forms.DataGridView
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblID = New System.Windows.Forms.Label
        Me.txtSchool = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.mainProfTS = New System.Windows.Forms.ToolStrip
        Me.tsSave = New System.Windows.Forms.ToolStripButton
        Me.tsUpdate = New System.Windows.Forms.ToolStripButton
        Me.tsDelete = New System.Windows.Forms.ToolStripButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtSearch = New System.Windows.Forms.TextBox
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.mainProfTS.SuspendLayout()
        Me.SuspendLayout()
        '
        'dg1
        '
        Me.dg1.AllowUserToAddRows = False
        Me.dg1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dg1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg1.Location = New System.Drawing.Point(0, 235)
        Me.dg1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dg1.Name = "dg1"
        Me.dg1.ReadOnly = True
        Me.dg1.Size = New System.Drawing.Size(498, 176)
        Me.dg1.TabIndex = 9
        Me.dg1.TabStop = False
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(106, 124)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtAddress.Size = New System.Drawing.Size(392, 62)
        Me.txtAddress.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(0, 194)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(498, 37)
        Me.Panel1.TabIndex = 5
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(16, 8)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(17, 15)
        Me.lblID.TabIndex = 7
        Me.lblID.Text = "ID"
        Me.lblID.Visible = False
        '
        'txtSchool
        '
        Me.txtSchool.Location = New System.Drawing.Point(106, 2)
        Me.txtSchool.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSchool.Name = "txtSchool"
        Me.txtSchool.Size = New System.Drawing.Size(389, 26)
        Me.txtSchool.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(36, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 19)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "School"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.lblID)
        Me.Panel3.Controls.Add(Me.txtSchool)
        Me.Panel3.Location = New System.Drawing.Point(0, 87)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(498, 29)
        Me.Panel3.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Location = New System.Drawing.Point(0, 122)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(498, 29)
        Me.Panel4.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(36, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 19)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Address"
        '
        'mainProfTS
        '
        Me.mainProfTS.BackColor = System.Drawing.Color.Transparent
        Me.mainProfTS.Font = New System.Drawing.Font("Segoe Condensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainProfTS.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.mainProfTS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsSave, Me.tsUpdate, Me.tsDelete})
        Me.mainProfTS.Location = New System.Drawing.Point(0, 0)
        Me.mainProfTS.Margin = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.mainProfTS.Name = "mainProfTS"
        Me.mainProfTS.Padding = New System.Windows.Forms.Padding(12, 15, 12, 15)
        Me.mainProfTS.Size = New System.Drawing.Size(499, 79)
        Me.mainProfTS.TabIndex = 37
        Me.mainProfTS.Text = "ts"
        '
        'tsSave
        '
        Me.tsSave.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsSave.Image = CType(resources.GetObject("tsSave.Image"), System.Drawing.Image)
        Me.tsSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSave.Name = "tsSave"
        Me.tsSave.Size = New System.Drawing.Size(36, 46)
        Me.tsSave.Text = "&Save"
        Me.tsSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsSave.ToolTipText = "Ctrl + S"
        '
        'tsUpdate
        '
        Me.tsUpdate.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsUpdate.Image = CType(resources.GetObject("tsUpdate.Image"), System.Drawing.Image)
        Me.tsUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsUpdate.Name = "tsUpdate"
        Me.tsUpdate.Size = New System.Drawing.Size(50, 46)
        Me.tsUpdate.Text = "&Update"
        Me.tsUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsUpdate.ToolTipText = "Ctrl + U"
        '
        'tsDelete
        '
        Me.tsDelete.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsDelete.Image = CType(resources.GetObject("tsDelete.Image"), System.Drawing.Image)
        Me.tsDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDelete.Name = "tsDelete"
        Me.tsDelete.Size = New System.Drawing.Size(46, 46)
        Me.tsDelete.Text = "&Delete"
        Me.tsDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsDelete.ToolTipText = "Del"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Search"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(66, 7)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(195, 26)
        Me.txtSearch.TabIndex = 1
        '
        'frmPrevSchool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(499, 411)
        Me.Controls.Add(Me.mainProfTS)
        Me.Controls.Add(Me.dg1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrevSchool"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "[  Previous School  ]"
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.mainProfTS.ResumeLayout(False)
        Me.mainProfTS.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dg1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents txtSchool As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mainProfTS As System.Windows.Forms.ToolStrip
    Friend WithEvents tsSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsUpdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
