<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettingsForm
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.Brand = New System.Windows.Forms.TabPage
        Me.dg1 = New System.Windows.Forms.DataGridView
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.txtBrand = New System.Windows.Forms.TextBox
        Me.Unit = New System.Windows.Forms.TabPage
        Me.dg2 = New System.Windows.Forms.DataGridView
        Me.btnUpdateU = New System.Windows.Forms.Button
        Me.btnDeleteU = New System.Windows.Forms.Button
        Me.btnAddU = New System.Windows.Forms.Button
        Me.txtUnit = New System.Windows.Forms.TextBox
        Me.lblUnitID = New System.Windows.Forms.Label
        Me.lblBrandID = New System.Windows.Forms.Label
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.btnexit = New System.Windows.Forms.Button
        Me.TabControl1.SuspendLayout()
        Me.Brand.SuspendLayout()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Unit.SuspendLayout()
        CType(Me.dg2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Brand)
        Me.TabControl1.Controls.Add(Me.Unit)
        Me.TabControl1.Location = New System.Drawing.Point(1, 18)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(457, 283)
        Me.TabControl1.TabIndex = 0
        '
        'Brand
        '
        Me.Brand.Controls.Add(Me.dg1)
        Me.Brand.Controls.Add(Me.btnUpdate)
        Me.Brand.Controls.Add(Me.btnDelete)
        Me.Brand.Controls.Add(Me.btnAdd)
        Me.Brand.Controls.Add(Me.txtBrand)
        Me.Brand.Controls.Add(Me.btnexit)
        Me.Brand.Location = New System.Drawing.Point(4, 28)
        Me.Brand.Name = "Brand"
        Me.Brand.Padding = New System.Windows.Forms.Padding(3)
        Me.Brand.Size = New System.Drawing.Size(449, 251)
        Me.Brand.TabIndex = 0
        Me.Brand.Text = "Brands"
        Me.Brand.UseVisualStyleBackColor = True
        '
        'dg1
        '
        Me.dg1.AllowUserToAddRows = False
        Me.dg1.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro
        Me.dg1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dg1.Location = New System.Drawing.Point(7, 69)
        Me.dg1.Name = "dg1"
        Me.dg1.ReadOnly = True
        Me.dg1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dg1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dg1.Size = New System.Drawing.Size(429, 176)
        Me.dg1.TabIndex = 4
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(288, 16)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(71, 26)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(365, 16)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(71, 26)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(211, 16)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(71, 26)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtBrand
        '
        Me.txtBrand.Location = New System.Drawing.Point(7, 16)
        Me.txtBrand.Name = "txtBrand"
        Me.txtBrand.Size = New System.Drawing.Size(186, 26)
        Me.txtBrand.TabIndex = 0
        '
        'Unit
        '
        Me.Unit.Controls.Add(Me.dg2)
        Me.Unit.Controls.Add(Me.btnUpdateU)
        Me.Unit.Controls.Add(Me.btnDeleteU)
        Me.Unit.Controls.Add(Me.btnAddU)
        Me.Unit.Controls.Add(Me.txtUnit)
        Me.Unit.Location = New System.Drawing.Point(4, 28)
        Me.Unit.Name = "Unit"
        Me.Unit.Padding = New System.Windows.Forms.Padding(3)
        Me.Unit.Size = New System.Drawing.Size(449, 251)
        Me.Unit.TabIndex = 1
        Me.Unit.Text = "Units"
        Me.Unit.UseVisualStyleBackColor = True
        '
        'dg2
        '
        Me.dg2.AllowUserToAddRows = False
        Me.dg2.AllowUserToDeleteRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dg2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg2.Location = New System.Drawing.Point(7, 69)
        Me.dg2.Name = "dg2"
        Me.dg2.ReadOnly = True
        Me.dg2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dg2.Size = New System.Drawing.Size(429, 176)
        Me.dg2.TabIndex = 4
        '
        'btnUpdateU
        '
        Me.btnUpdateU.Location = New System.Drawing.Point(288, 16)
        Me.btnUpdateU.Name = "btnUpdateU"
        Me.btnUpdateU.Size = New System.Drawing.Size(71, 26)
        Me.btnUpdateU.TabIndex = 3
        Me.btnUpdateU.Text = "Update"
        Me.btnUpdateU.UseVisualStyleBackColor = True
        '
        'btnDeleteU
        '
        Me.btnDeleteU.Location = New System.Drawing.Point(365, 16)
        Me.btnDeleteU.Name = "btnDeleteU"
        Me.btnDeleteU.Size = New System.Drawing.Size(71, 26)
        Me.btnDeleteU.TabIndex = 2
        Me.btnDeleteU.Text = "Delete"
        Me.btnDeleteU.UseVisualStyleBackColor = True
        '
        'btnAddU
        '
        Me.btnAddU.Location = New System.Drawing.Point(211, 16)
        Me.btnAddU.Name = "btnAddU"
        Me.btnAddU.Size = New System.Drawing.Size(71, 26)
        Me.btnAddU.TabIndex = 1
        Me.btnAddU.Text = "Add"
        Me.btnAddU.UseVisualStyleBackColor = True
        '
        'txtUnit
        '
        Me.txtUnit.Location = New System.Drawing.Point(7, 16)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(186, 26)
        Me.txtUnit.TabIndex = 0
        '
        'lblUnitID
        '
        Me.lblUnitID.AutoSize = True
        Me.lblUnitID.Location = New System.Drawing.Point(401, 312)
        Me.lblUnitID.Name = "lblUnitID"
        Me.lblUnitID.Size = New System.Drawing.Size(45, 19)
        Me.lblUnitID.TabIndex = 7
        Me.lblUnitID.Text = "UnitID"
        Me.lblUnitID.Visible = False
        '
        'lblBrandID
        '
        Me.lblBrandID.AutoSize = True
        Me.lblBrandID.Location = New System.Drawing.Point(339, 312)
        Me.lblBrandID.Name = "lblBrandID"
        Me.lblBrandID.Size = New System.Drawing.Size(56, 19)
        Me.lblBrandID.TabIndex = 1
        Me.lblBrandID.Text = "BrandID"
        Me.lblBrandID.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 305)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(458, 24)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(57, 19)
        Me.ToolStripStatusLabel1.Text = "Exit [Esc]"
        '
        'btnexit
        '
        Me.btnexit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnexit.Location = New System.Drawing.Point(315, 104)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 23)
        Me.btnexit.TabIndex = 9
        Me.btnexit.Text = "exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'frmSettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnexit
        Me.ClientSize = New System.Drawing.Size(458, 329)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lblUnitID)
        Me.Controls.Add(Me.lblBrandID)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettingsForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Brands and Units"
        Me.TabControl1.ResumeLayout(False)
        Me.Brand.ResumeLayout(False)
        Me.Brand.PerformLayout()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Unit.ResumeLayout(False)
        Me.Unit.PerformLayout()
        CType(Me.dg2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Brand As System.Windows.Forms.TabPage
    Friend WithEvents Unit As System.Windows.Forms.TabPage
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtBrand As System.Windows.Forms.TextBox
    Friend WithEvents dg1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblBrandID As System.Windows.Forms.Label
    Friend WithEvents txtUnit As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdateU As System.Windows.Forms.Button
    Friend WithEvents btnDeleteU As System.Windows.Forms.Button
    Friend WithEvents btnAddU As System.Windows.Forms.Button
    Friend WithEvents dg2 As System.Windows.Forms.DataGridView
    Friend WithEvents lblUnitID As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnexit As System.Windows.Forms.Button
End Class
