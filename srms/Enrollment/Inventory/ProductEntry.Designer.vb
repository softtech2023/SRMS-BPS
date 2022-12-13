<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductEntry))
        Me.dg1 = New System.Windows.Forms.DataGridView
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.lblProductCode = New System.Windows.Forms.Label
        Me.txtProductCode = New System.Windows.Forms.TextBox
        Me.txtProductName = New System.Windows.Forms.TextBox
        Me.txtProductDescription = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboBrand = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnok = New System.Windows.Forms.Button
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.btnexit = New System.Windows.Forms.Button
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnSave = New System.Windows.Forms.ToolStripButton
        Me.btnUpdate = New System.Windows.Forms.ToolStripButton
        Me.btnDelete = New System.Windows.Forms.ToolStripButton
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dg1
        '
        Me.dg1.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dg1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg1.Location = New System.Drawing.Point(412, 87)
        Me.dg1.Name = "dg1"
        Me.dg1.ReadOnly = True
        Me.dg1.Size = New System.Drawing.Size(374, 213)
        Me.dg1.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(412, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 19)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Search"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(466, 55)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(230, 26)
        Me.txtSearch.TabIndex = 5
        '
        'lblProductCode
        '
        Me.lblProductCode.AutoSize = True
        Me.lblProductCode.Location = New System.Drawing.Point(399, 18)
        Me.lblProductCode.Name = "lblProductCode"
        Me.lblProductCode.Size = New System.Drawing.Size(46, 19)
        Me.lblProductCode.TabIndex = 7
        Me.lblProductCode.Text = "Label6"
        Me.lblProductCode.Visible = False
        '
        'txtProductCode
        '
        Me.txtProductCode.Location = New System.Drawing.Point(140, 42)
        Me.txtProductCode.Name = "txtProductCode"
        Me.txtProductCode.Size = New System.Drawing.Size(155, 26)
        Me.txtProductCode.TabIndex = 1
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(140, 78)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(233, 26)
        Me.txtProductName.TabIndex = 2
        '
        'txtProductDescription
        '
        Me.txtProductDescription.Location = New System.Drawing.Point(140, 115)
        Me.txtProductDescription.Multiline = True
        Me.txtProductDescription.Name = "txtProductDescription"
        Me.txtProductDescription.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtProductDescription.Size = New System.Drawing.Size(233, 71)
        Me.txtProductDescription.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Product Code"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(83, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Brand"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Product Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Product Description"
        '
        'cboBrand
        '
        Me.cboBrand.AutoCompleteCustomSource.AddRange(New String() {"", "Epson", "Union", "Acer", "Asus", "Canon", "Coby", "Sun Star", "Dell", "Gemma", "Eco Power", "Camel", "Standard", "Pixpro", "TP-Link", "Zebra", "Creston", "A4Tech", "ZTE", "Wheeler", "Shivtech"})
        Me.cboBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBrand.FormattingEnabled = True
        Me.cboBrand.Location = New System.Drawing.Point(140, 195)
        Me.cboBrand.Name = "cboBrand"
        Me.cboBrand.Size = New System.Drawing.Size(155, 27)
        Me.cboBrand.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtProductDescription)
        Me.GroupBox1.Controls.Add(Me.cboBrand)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtProductName)
        Me.GroupBox1.Controls.Add(Me.txtProductCode)
        Me.GroupBox1.Controls.Add(Me.btnok)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(394, 255)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'btnok
        '
        Me.btnok.Location = New System.Drawing.Point(252, 199)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(10, 23)
        Me.btnok.TabIndex = 5
        Me.btnok.Text = "ok"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 303)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(54, 17)
        Me.ToolStripStatusLabel1.Text = "Exit [Esc]"
        '
        'btnexit
        '
        Me.btnexit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnexit.Location = New System.Drawing.Point(599, 56)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 23)
        Me.btnexit.TabIndex = 10
        Me.btnexit.Text = "exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSave, Me.btnUpdate, Me.btnDelete})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 39)
        Me.ToolStrip1.TabIndex = 11
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(79, 36)
        Me.btnSave.Text = "Save"
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Image)
        Me.btnUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(96, 36)
        Me.btnUpdate.Text = "Update"
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(90, 36)
        Me.btnDelete.Text = "Delete"
        '
        'frmProductEntry
        '
        Me.AcceptButton = Me.btnok
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnexit
        Me.ClientSize = New System.Drawing.Size(800, 325)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lblProductCode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dg1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnexit)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProductEntry"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consumables"
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dg1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblProductCode As System.Windows.Forms.Label
    Friend WithEvents txtProductCode As System.Windows.Forms.TextBox
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents txtProductDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboBrand As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnUpdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
End Class
