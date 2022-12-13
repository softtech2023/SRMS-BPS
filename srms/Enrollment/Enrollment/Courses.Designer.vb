<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCourses
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCourses))
        Me.cboDuration = New System.Windows.Forms.ComboBox
        Me.txtCourseCode = New System.Windows.Forms.TextBox
        Me.lblID = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.dgcourse = New System.Windows.Forms.DataGridView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCourse = New System.Windows.Forms.TextBox
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtMajor = New System.Windows.Forms.TextBox
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.mainProfTS = New System.Windows.Forms.ToolStrip
        Me.tsSave = New System.Windows.Forms.ToolStripButton
        Me.tsUpdate = New System.Windows.Forms.ToolStripButton
        Me.tsDelete = New System.Windows.Forms.ToolStripButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Panel2.SuspendLayout()
        CType(Me.dgcourse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.mainProfTS.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboDuration
        '
        Me.cboDuration.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboDuration.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDuration.FormattingEnabled = True
        Me.cboDuration.Items.AddRange(New Object() {"1 Year", "2 Years", "4 Years", "5 Years"})
        Me.cboDuration.Location = New System.Drawing.Point(152, 0)
        Me.cboDuration.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboDuration.Name = "cboDuration"
        Me.cboDuration.Size = New System.Drawing.Size(145, 27)
        Me.cboDuration.TabIndex = 7
        '
        'txtCourseCode
        '
        Me.txtCourseCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCourseCode.Location = New System.Drawing.Point(109, 0)
        Me.txtCourseCode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCourseCode.Name = "txtCourseCode"
        Me.txtCourseCode.Size = New System.Drawing.Size(145, 26)
        Me.txtCourseCode.TabIndex = 1
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(474, 65)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(22, 19)
        Me.lblID.TabIndex = 4
        Me.lblID.Text = "ID"
        Me.lblID.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel2.Controls.Add(Me.dgcourse)
        Me.Panel2.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(-1, 188)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(489, 150)
        Me.Panel2.TabIndex = 5
        '
        'dgcourse
        '
        Me.dgcourse.AllowUserToAddRows = False
        Me.dgcourse.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver
        Me.dgcourse.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgcourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgcourse.Location = New System.Drawing.Point(0, 4)
        Me.dgcourse.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgcourse.Name = "dgcourse"
        Me.dgcourse.ReadOnly = True
        Me.dgcourse.Size = New System.Drawing.Size(489, 146)
        Me.dgcourse.TabIndex = 7
        Me.dgcourse.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtCourseCode)
        Me.Panel1.Location = New System.Drawing.Point(-1, 94)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(256, 28)
        Me.Panel1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(27, 4)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Code"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.txtCourse)
        Me.Panel3.Location = New System.Drawing.Point(-1, 128)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(489, 28)
        Me.Panel3.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(27, 4)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Department"
        '
        'txtCourse
        '
        Me.txtCourse.Location = New System.Drawing.Point(109, 1)
        Me.txtCourse.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(377, 26)
        Me.txtCourse.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.txtMajor)
        Me.Panel4.Location = New System.Drawing.Point(0, 161)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(488, 28)
        Me.Panel4.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(27, 4)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 19)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Grade Level"
        '
        'txtMajor
        '
        Me.txtMajor.Location = New System.Drawing.Point(108, 1)
        Me.txtMajor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMajor.Name = "txtMajor"
        Me.txtMajor.Size = New System.Drawing.Size(377, 26)
        Me.txtMajor.TabIndex = 5
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Silver
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.cboDuration)
        Me.Panel5.Location = New System.Drawing.Point(19, 59)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(300, 28)
        Me.Panel5.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(27, 4)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Duration"
        '
        'mainProfTS
        '
        Me.mainProfTS.BackColor = System.Drawing.Color.Transparent
        Me.mainProfTS.Font = New System.Drawing.Font("Segoe Condensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainProfTS.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.mainProfTS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsSave, Me.tsUpdate, Me.tsDelete})
        Me.mainProfTS.Location = New System.Drawing.Point(0, 0)
        Me.mainProfTS.Margin = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.mainProfTS.Name = "mainProfTS"
        Me.mainProfTS.Padding = New System.Windows.Forms.Padding(13, 14, 13, 14)
        Me.mainProfTS.Size = New System.Drawing.Size(489, 85)
        Me.mainProfTS.TabIndex = 22
        Me.mainProfTS.Text = "ts"
        '
        'tsSave
        '
        Me.tsSave.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsSave.Image = CType(resources.GetObject("tsSave.Image"), System.Drawing.Image)
        Me.tsSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSave.Name = "tsSave"
        Me.tsSave.Size = New System.Drawing.Size(36, 54)
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
        Me.tsUpdate.Size = New System.Drawing.Size(50, 54)
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
        Me.tsDelete.Size = New System.Drawing.Size(46, 54)
        Me.tsDelete.Text = "&Delete"
        Me.tsDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsDelete.ToolTipText = "Del"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel5)
        Me.GroupBox1.Location = New System.Drawing.Point(328, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(59, 34)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Hidden"
        Me.GroupBox1.Visible = False
        '
        'frmCourses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(489, 340)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.mainProfTS)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblID)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCourses"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "[ DEPARTMENT  ]"
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgcourse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.mainProfTS.ResumeLayout(False)
        Me.mainProfTS.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgcourse As System.Windows.Forms.DataGridView
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtCourseCode As System.Windows.Forms.TextBox
    Friend WithEvents cboDuration As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCourse As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMajor As System.Windows.Forms.TextBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mainProfTS As System.Windows.Forms.ToolStrip
    Friend WithEvents tsSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsUpdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
