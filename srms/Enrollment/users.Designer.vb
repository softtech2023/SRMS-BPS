<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmuseraccounts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmuseraccounts))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtusername = New System.Windows.Forms.TextBox
        Me.txtpassword1 = New System.Windows.Forms.TextBox
        Me.cboposition = New System.Windows.Forms.ComboBox
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtConfirm = New System.Windows.Forms.TextBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblID = New System.Windows.Forms.Label
        Me.dgUser = New System.Windows.Forms.DataGridView
        Me.mainProfTS = New System.Windows.Forms.ToolStrip
        Me.tsSave = New System.Windows.Forms.ToolStripButton
        Me.tsUpdate = New System.Windows.Forms.ToolStripButton
        Me.tsDelete = New System.Windows.Forms.ToolStripButton
        Me.tsResetPassword = New System.Windows.Forms.ToolStripButton
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mainProfTS.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 4)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 7)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "System Access"
        '
        'txtusername
        '
        Me.txtusername.ForeColor = System.Drawing.Color.Black
        Me.txtusername.Location = New System.Drawing.Point(84, 3)
        Me.txtusername.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(190, 26)
        Me.txtusername.TabIndex = 2
        '
        'txtpassword1
        '
        Me.txtpassword1.ForeColor = System.Drawing.Color.Black
        Me.txtpassword1.Location = New System.Drawing.Point(84, 3)
        Me.txtpassword1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtpassword1.Name = "txtpassword1"
        Me.txtpassword1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword1.Size = New System.Drawing.Size(190, 26)
        Me.txtpassword1.TabIndex = 4
        '
        'cboposition
        '
        Me.cboposition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboposition.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboposition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboposition.ForeColor = System.Drawing.Color.Black
        Me.cboposition.FormattingEnabled = True
        Me.cboposition.Items.AddRange(New Object() {"Accounting", "Admin", "Registrar", "Security Guard", "Student", "Teacher", "Teacher/Adviser"})
        Me.cboposition.Location = New System.Drawing.Point(116, 215)
        Me.cboposition.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboposition.Name = "cboposition"
        Me.cboposition.Size = New System.Drawing.Size(158, 27)
        Me.cboposition.Sorted = True
        Me.cboposition.TabIndex = 8
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Controls.Add(Me.txtEmail)
        Me.Panel6.Location = New System.Drawing.Point(0, 254)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(276, 33)
        Me.Panel6.TabIndex = 9
        Me.Panel6.TabStop = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(9, 6)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 19)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.Location = New System.Drawing.Point(84, 3)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(190, 26)
        Me.txtEmail.TabIndex = 10
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Location = New System.Drawing.Point(0, 212)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(276, 33)
        Me.Panel5.TabIndex = 7
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.txtConfirm)
        Me.Panel4.Location = New System.Drawing.Point(0, 172)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(277, 33)
        Me.Panel4.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(8, 5)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Confirm"
        '
        'txtConfirm
        '
        Me.txtConfirm.ForeColor = System.Drawing.Color.Black
        Me.txtConfirm.Location = New System.Drawing.Point(84, 3)
        Me.txtConfirm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtConfirm.Name = "txtConfirm"
        Me.txtConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirm.Size = New System.Drawing.Size(189, 26)
        Me.txtConfirm.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.txtpassword1)
        Me.Panel3.Location = New System.Drawing.Point(0, 132)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(276, 33)
        Me.Panel3.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(8, 4)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 19)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Password"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtusername)
        Me.Panel2.Location = New System.Drawing.Point(0, 91)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(276, 33)
        Me.Panel2.TabIndex = 1
        '
        'txtSearch
        '
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.Location = New System.Drawing.Point(642, 60)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(212, 26)
        Me.txtSearch.TabIndex = 9
        Me.txtSearch.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(588, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 19)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Search"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(228, 304)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(46, 19)
        Me.lblID.TabIndex = 6
        Me.lblID.Text = "Label4"
        Me.lblID.Visible = False
        '
        'dgUser
        '
        Me.dgUser.AllowUserToAddRows = False
        Me.dgUser.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgUser.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUser.Location = New System.Drawing.Point(282, 91)
        Me.dgUser.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgUser.Name = "dgUser"
        Me.dgUser.ReadOnly = True
        Me.dgUser.Size = New System.Drawing.Size(572, 356)
        Me.dgUser.TabIndex = 10
        Me.dgUser.TabStop = False
        '
        'mainProfTS
        '
        Me.mainProfTS.BackColor = System.Drawing.Color.Transparent
        Me.mainProfTS.Font = New System.Drawing.Font("Segoe Condensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainProfTS.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.mainProfTS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsSave, Me.tsUpdate, Me.tsDelete, Me.tsResetPassword})
        Me.mainProfTS.Location = New System.Drawing.Point(0, 0)
        Me.mainProfTS.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.mainProfTS.Name = "mainProfTS"
        Me.mainProfTS.Padding = New System.Windows.Forms.Padding(10)
        Me.mainProfTS.Size = New System.Drawing.Size(859, 59)
        Me.mainProfTS.TabIndex = 17
        Me.mainProfTS.Text = "ts"
        '
        'tsSave
        '
        Me.tsSave.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsSave.Image = CType(resources.GetObject("tsSave.Image"), System.Drawing.Image)
        Me.tsSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSave.Name = "tsSave"
        Me.tsSave.Size = New System.Drawing.Size(60, 36)
        Me.tsSave.Text = "&Save"
        Me.tsSave.ToolTipText = "Ctrl + S"
        '
        'tsUpdate
        '
        Me.tsUpdate.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsUpdate.Image = CType(resources.GetObject("tsUpdate.Image"), System.Drawing.Image)
        Me.tsUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsUpdate.Name = "tsUpdate"
        Me.tsUpdate.Size = New System.Drawing.Size(74, 36)
        Me.tsUpdate.Text = "&Update"
        Me.tsUpdate.ToolTipText = "Ctrl + U"
        '
        'tsDelete
        '
        Me.tsDelete.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsDelete.Image = CType(resources.GetObject("tsDelete.Image"), System.Drawing.Image)
        Me.tsDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDelete.Name = "tsDelete"
        Me.tsDelete.Size = New System.Drawing.Size(70, 36)
        Me.tsDelete.Text = "&Delete"
        Me.tsDelete.ToolTipText = "Del"
        Me.tsDelete.Visible = False
        '
        'tsResetPassword
        '
        Me.tsResetPassword.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsResetPassword.Image = Global.SIMS.My.Resources.Resources.Reset_icon
        Me.tsResetPassword.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsResetPassword.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsResetPassword.Name = "tsResetPassword"
        Me.tsResetPassword.Size = New System.Drawing.Size(135, 36)
        Me.tsResetPassword.Text = "Reset Password"
        '
        'frmuseraccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(859, 453)
        Me.Controls.Add(Me.mainProfTS)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.cboposition)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.dgUser)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmuseraccounts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ":: Manage User Accounts"
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mainProfTS.ResumeLayout(False)
        Me.mainProfTS.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword1 As System.Windows.Forms.TextBox
    Friend WithEvents cboposition As System.Windows.Forms.ComboBox
    Friend WithEvents dgUser As System.Windows.Forms.DataGridView
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtConfirm As System.Windows.Forms.TextBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents mainProfTS As System.Windows.Forms.ToolStrip
    Friend WithEvents tsSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsUpdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsResetPassword As System.Windows.Forms.ToolStripButton
End Class
