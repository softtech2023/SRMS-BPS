<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsumable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsumable))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblsettingsID = New System.Windows.Forms.Label
        Me.lblconsumableID = New System.Windows.Forms.Label
        Me.lbltotal = New System.Windows.Forms.Label
        Me.lblqty = New System.Windows.Forms.Label
        Me.txtProductNAme = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cboUnit = New System.Windows.Forms.ComboBox
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.btnSelect = New System.Windows.Forms.Button
        Me.txtProductCode = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNotes = New System.Windows.Forms.TextBox
        Me.btnok = New System.Windows.Forms.Button
        Me.txtProductDescription = New System.Windows.Forms.TextBox
        Me.btnclose = New System.Windows.Forms.Button
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnSave = New System.Windows.Forms.ToolStripButton
        Me.btnUpdate = New System.Windows.Forms.ToolStripButton
        Me.btnDelete = New System.Windows.Forms.ToolStripButton
        Me.btnSearch = New System.Windows.Forms.ToolStripButton
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblsettingsID)
        Me.GroupBox1.Controls.Add(Me.lblconsumableID)
        Me.GroupBox1.Controls.Add(Me.lbltotal)
        Me.GroupBox1.Controls.Add(Me.lblqty)
        Me.GroupBox1.Controls.Add(Me.txtProductNAme)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cboUnit)
        Me.GroupBox1.Controls.Add(Me.txtQty)
        Me.GroupBox1.Controls.Add(Me.btnSelect)
        Me.GroupBox1.Controls.Add(Me.txtProductCode)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNotes)
        Me.GroupBox1.Controls.Add(Me.btnok)
        Me.GroupBox1.Controls.Add(Me.txtProductDescription)
        Me.GroupBox1.Controls.Add(Me.btnclose)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(547, 280)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'lblsettingsID
        '
        Me.lblsettingsID.AutoSize = True
        Me.lblsettingsID.Location = New System.Drawing.Point(20, 244)
        Me.lblsettingsID.Name = "lblsettingsID"
        Me.lblsettingsID.Size = New System.Drawing.Size(71, 19)
        Me.lblsettingsID.TabIndex = 12
        Me.lblsettingsID.Text = "Settings ID"
        Me.lblsettingsID.Visible = False
        '
        'lblconsumableID
        '
        Me.lblconsumableID.AutoSize = True
        Me.lblconsumableID.Location = New System.Drawing.Point(24, 244)
        Me.lblconsumableID.Name = "lblconsumableID"
        Me.lblconsumableID.Size = New System.Drawing.Size(90, 19)
        Me.lblconsumableID.TabIndex = 11
        Me.lblconsumableID.Text = "consumableID"
        Me.lblconsumableID.Visible = False
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(70, 244)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(16, 19)
        Me.lbltotal.TabIndex = 10
        Me.lbltotal.Text = "0"
        Me.lbltotal.Visible = False
        '
        'lblqty
        '
        Me.lblqty.AutoSize = True
        Me.lblqty.Location = New System.Drawing.Point(20, 244)
        Me.lblqty.Name = "lblqty"
        Me.lblqty.Size = New System.Drawing.Size(16, 19)
        Me.lblqty.TabIndex = 9
        Me.lblqty.Text = "0"
        Me.lblqty.Visible = False
        '
        'txtProductNAme
        '
        Me.txtProductNAme.Location = New System.Drawing.Point(165, 65)
        Me.txtProductNAme.Name = "txtProductNAme"
        Me.txtProductNAme.ReadOnly = True
        Me.txtProductNAme.Size = New System.Drawing.Size(273, 26)
        Me.txtProductNAme.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 19)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Product Name"
        '
        'cboUnit
        '
        Me.cboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUnit.FormattingEnabled = True
        Me.cboUnit.Location = New System.Drawing.Point(376, 164)
        Me.cboUnit.Name = "cboUnit"
        Me.cboUnit.Size = New System.Drawing.Size(148, 27)
        Me.cboUnit.TabIndex = 6
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(165, 164)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(167, 26)
        Me.txtQty.TabIndex = 5
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(333, 33)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(80, 25)
        Me.btnSelect.TabIndex = 2
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'txtProductCode
        '
        Me.txtProductCode.Location = New System.Drawing.Point(165, 33)
        Me.txtProductCode.Name = "txtProductCode"
        Me.txtProductCode.ReadOnly = True
        Me.txtProductCode.Size = New System.Drawing.Size(162, 26)
        Me.txtProductCode.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Notes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(338, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Unit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Qty. Delivered"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Product Description"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product Code"
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(165, 197)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotes.Size = New System.Drawing.Size(377, 66)
        Me.txtNotes.TabIndex = 7
        '
        'btnok
        '
        Me.btnok.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnok.Location = New System.Drawing.Point(194, 221)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(75, 23)
        Me.btnok.TabIndex = 13
        Me.btnok.Text = "Button1"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'txtProductDescription
        '
        Me.txtProductDescription.Location = New System.Drawing.Point(165, 97)
        Me.txtProductDescription.Multiline = True
        Me.txtProductDescription.Name = "txtProductDescription"
        Me.txtProductDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtProductDescription.Size = New System.Drawing.Size(377, 61)
        Me.txtProductDescription.TabIndex = 4
        '
        'btnclose
        '
        Me.btnclose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnclose.Location = New System.Drawing.Point(395, 102)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(66, 25)
        Me.btnclose.TabIndex = 14
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 319)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(554, 24)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(58, 19)
        Me.ToolStripStatusLabel1.Text = "Exit [Esc]"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(123, 19)
        Me.ToolStripStatusLabel3.Text = "Clear Information [F6]"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(554, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "menu"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.ClearToolStripMenuItem.Text = "clear"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(123, 17)
        Me.ToolStripStatusLabel2.Text = "Clear Information [F6]"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSave, Me.btnUpdate, Me.btnDelete, Me.btnSearch})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(554, 39)
        Me.ToolStrip1.TabIndex = 9
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
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(93, 36)
        Me.btnSearch.Text = "Search"
        '
        'frmConsumable
        '
        Me.AcceptButton = Me.btnok
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnclose
        Me.ClientSize = New System.Drawing.Size(554, 343)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConsumable"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Input"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboUnit As System.Windows.Forms.ComboBox
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents txtProductCode As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtProductDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents txtProductNAme As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents lblqty As System.Windows.Forms.Label
    Friend WithEvents lblconsumableID As System.Windows.Forms.Label
    Friend WithEvents lblsettingsID As System.Windows.Forms.Label
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnUpdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSearch As System.Windows.Forms.ToolStripButton


End Class
