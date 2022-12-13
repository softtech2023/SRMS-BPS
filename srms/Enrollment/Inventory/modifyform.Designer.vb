<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmodifyform
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnSearhItem = New System.Windows.Forms.Button
        Me.txtTransNo = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.txtDesc = New System.Windows.Forms.TextBox
        Me.txtItemName = New System.Windows.Forms.TextBox
        Me.txtProdCode = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtLName = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnsearch = New System.Windows.Forms.Button
        Me.txtIDNo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtEmpName = New System.Windows.Forms.TextBox
        Me.btnClear = New System.Windows.Forms.Button
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.lblqty = New System.Windows.Forms.Label
        Me.lbltotalqty = New System.Windows.Forms.Label
        Me.lbldistID = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.btnSearhItem)
        Me.GroupBox1.Controls.Add(Me.txtTransNo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtQty)
        Me.GroupBox1.Controls.Add(Me.txtDesc)
        Me.GroupBox1.Controls.Add(Me.txtItemName)
        Me.GroupBox1.Controls.Add(Me.txtProdCode)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(357, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(347, 194)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Item Information"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(244, 154)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(99, 25)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Return"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnSearhItem
        '
        Me.btnSearhItem.Location = New System.Drawing.Point(268, 25)
        Me.btnSearhItem.Name = "btnSearhItem"
        Me.btnSearhItem.Size = New System.Drawing.Size(75, 26)
        Me.btnSearhItem.TabIndex = 6
        Me.btnSearhItem.Text = "Search"
        Me.btnSearhItem.UseVisualStyleBackColor = True
        '
        'txtTransNo
        '
        Me.txtTransNo.Location = New System.Drawing.Point(103, 25)
        Me.txtTransNo.Name = "txtTransNo"
        Me.txtTransNo.ReadOnly = True
        Me.txtTransNo.Size = New System.Drawing.Size(159, 26)
        Me.txtTransNo.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 19)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Transaction No"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(103, 153)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.ReadOnly = True
        Me.txtQty.Size = New System.Drawing.Size(98, 26)
        Me.txtQty.TabIndex = 7
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(103, 121)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.ReadOnly = True
        Me.txtDesc.Size = New System.Drawing.Size(240, 26)
        Me.txtDesc.TabIndex = 6
        '
        'txtItemName
        '
        Me.txtItemName.Location = New System.Drawing.Point(103, 89)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.ReadOnly = True
        Me.txtItemName.Size = New System.Drawing.Size(240, 26)
        Me.txtItemName.TabIndex = 5
        '
        'txtProdCode
        '
        Me.txtProdCode.Location = New System.Drawing.Point(103, 57)
        Me.txtProdCode.Name = "txtProdCode"
        Me.txtProdCode.ReadOnly = True
        Me.txtProdCode.Size = New System.Drawing.Size(240, 26)
        Me.txtProdCode.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 19)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Qty"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 19)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Description"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Product Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Product Code"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtLName)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.btnsearch)
        Me.GroupBox2.Controls.Add(Me.txtIDNo)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtEmpName)
        Me.GroupBox2.Controls.Add(Me.btnClear)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(339, 194)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Personnel Information"
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(97, 89)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.ReadOnly = True
        Me.txtLName.Size = New System.Drawing.Size(200, 26)
        Me.txtLName.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 19)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Last Name"
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(258, 25)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(75, 26)
        Me.btnsearch.TabIndex = 4
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'txtIDNo
        '
        Me.txtIDNo.Location = New System.Drawing.Point(97, 25)
        Me.txtIDNo.Name = "txtIDNo"
        Me.txtIDNo.ReadOnly = True
        Me.txtIDNo.Size = New System.Drawing.Size(155, 26)
        Me.txtIDNo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee No"
        '
        'txtEmpName
        '
        Me.txtEmpName.Location = New System.Drawing.Point(97, 57)
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.ReadOnly = True
        Me.txtEmpName.Size = New System.Drawing.Size(200, 26)
        Me.txtEmpName.TabIndex = 3
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Location = New System.Drawing.Point(132, 64)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(31, 19)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 209)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(727, 24)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(57, 19)
        Me.ToolStripStatusLabel2.Text = "Exit [Esc]"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(127, 19)
        Me.ToolStripStatusLabel1.Text = "Clear Information [F6]"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(727, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearInformationToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'ClearInformationToolStripMenuItem
        '
        Me.ClearInformationToolStripMenuItem.Name = "ClearInformationToolStripMenuItem"
        Me.ClearInformationToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.ClearInformationToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ClearInformationToolStripMenuItem.Text = "Clear Information"
        '
        'lblqty
        '
        Me.lblqty.AutoSize = True
        Me.lblqty.Location = New System.Drawing.Point(522, 9)
        Me.lblqty.Name = "lblqty"
        Me.lblqty.Size = New System.Drawing.Size(16, 19)
        Me.lblqty.TabIndex = 4
        Me.lblqty.Text = "0"
        Me.lblqty.Visible = False
        '
        'lbltotalqty
        '
        Me.lbltotalqty.AutoSize = True
        Me.lbltotalqty.Location = New System.Drawing.Point(544, 9)
        Me.lbltotalqty.Name = "lbltotalqty"
        Me.lbltotalqty.Size = New System.Drawing.Size(16, 19)
        Me.lbltotalqty.TabIndex = 5
        Me.lbltotalqty.Text = "0"
        Me.lbltotalqty.Visible = False
        '
        'lbldistID
        '
        Me.lbldistID.AutoSize = True
        Me.lbldistID.Location = New System.Drawing.Point(573, 9)
        Me.lbldistID.Name = "lbldistID"
        Me.lbldistID.Size = New System.Drawing.Size(42, 19)
        Me.lbldistID.TabIndex = 6
        Me.lbldistID.Text = "distID"
        Me.lbldistID.Visible = False
        '
        'frmmodifyform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(727, 233)
        Me.Controls.Add(Me.lbldistID)
        Me.Controls.Add(Me.lbltotalqty)
        Me.Controls.Add(Me.lblqty)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmmodifyform"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Return Item"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents txtEmpName As System.Windows.Forms.TextBox
    Friend WithEvents txtIDNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtItemName As System.Windows.Forms.TextBox
    Friend WithEvents txtProdCode As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtTransNo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnSearhItem As System.Windows.Forms.Button
    Friend WithEvents lblqty As System.Windows.Forms.Label
    Friend WithEvents lbltotalqty As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbldistID As System.Windows.Forms.Label
End Class
