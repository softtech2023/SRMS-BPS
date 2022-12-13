<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNutStatForm
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
        Me.txtHFA = New System.Windows.Forms.TextBox
        Me.txtNutStatus = New System.Windows.Forms.TextBox
        Me.txtBMI = New System.Windows.Forms.TextBox
        Me.txtHeightSquared = New System.Windows.Forms.TextBox
        Me.txtHeight = New System.Windows.Forms.TextBox
        Me.txtWeight = New System.Windows.Forms.TextBox
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpWeighingDate = New System.Windows.Forms.DateTimePicker
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtHFA
        '
        Me.txtHFA.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHFA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtHFA.Location = New System.Drawing.Point(427, 154)
        Me.txtHFA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtHFA.Name = "txtHFA"
        Me.txtHFA.ReadOnly = True
        Me.txtHFA.Size = New System.Drawing.Size(216, 26)
        Me.txtHFA.TabIndex = 23
        '
        'txtNutStatus
        '
        Me.txtNutStatus.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNutStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtNutStatus.Location = New System.Drawing.Point(427, 120)
        Me.txtNutStatus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNutStatus.Name = "txtNutStatus"
        Me.txtNutStatus.ReadOnly = True
        Me.txtNutStatus.Size = New System.Drawing.Size(216, 26)
        Me.txtNutStatus.TabIndex = 22
        '
        'txtBMI
        '
        Me.txtBMI.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBMI.ForeColor = System.Drawing.Color.Maroon
        Me.txtBMI.Location = New System.Drawing.Point(427, 86)
        Me.txtBMI.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBMI.Name = "txtBMI"
        Me.txtBMI.Size = New System.Drawing.Size(116, 26)
        Me.txtBMI.TabIndex = 21
        Me.txtBMI.Text = "0.00"
        Me.txtBMI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHeightSquared
        '
        Me.txtHeightSquared.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeightSquared.ForeColor = System.Drawing.Color.Maroon
        Me.txtHeightSquared.Location = New System.Drawing.Point(427, 52)
        Me.txtHeightSquared.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtHeightSquared.Name = "txtHeightSquared"
        Me.txtHeightSquared.ReadOnly = True
        Me.txtHeightSquared.Size = New System.Drawing.Size(116, 26)
        Me.txtHeightSquared.TabIndex = 20
        Me.txtHeightSquared.Text = "0.00"
        Me.txtHeightSquared.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHeight
        '
        Me.txtHeight.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeight.Location = New System.Drawing.Point(132, 86)
        Me.txtHeight.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(116, 26)
        Me.txtHeight.TabIndex = 19
        Me.txtHeight.Text = "0.0"
        Me.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtWeight
        '
        Me.txtWeight.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight.Location = New System.Drawing.Point(132, 52)
        Me.txtWeight.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(116, 26)
        Me.txtWeight.TabIndex = 18
        Me.txtWeight.Text = "0.0"
        Me.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(325, 157)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(96, 19)
        Me.Label35.TabIndex = 17
        Me.Label35.Text = "Height-For-Age"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(313, 123)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(108, 19)
        Me.Label34.TabIndex = 16
        Me.Label34.Text = "Nutritional Status"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(389, 89)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(32, 19)
        Me.Label33.TabIndex = 15
        Me.Label33.Text = "BMI"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(317, 55)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(104, 19)
        Me.Label32.TabIndex = 14
        Me.Label32.Text = "Height (squared)"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(28, 89)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(98, 19)
        Me.Label31.TabIndex = 13
        Me.Label31.Text = "Height (meters)"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(52, 55)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(74, 19)
        Me.Label30.TabIndex = 12
        Me.Label30.Text = "Weight (kg)"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(131, 2)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 30)
        Me.btnSave.TabIndex = 24
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Location = New System.Drawing.Point(4, 211)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(660, 34)
        Me.Panel1.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 19)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Weighing Date"
        '
        'dtpWeighingDate
        '
        Me.dtpWeighingDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpWeighingDate.Location = New System.Drawing.Point(132, 120)
        Me.dtpWeighingDate.Name = "dtpWeighingDate"
        Me.dtpWeighingDate.Size = New System.Drawing.Size(116, 26)
        Me.dtpWeighingDate.TabIndex = 27
        '
        'frmNutStatForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(667, 251)
        Me.Controls.Add(Me.dtpWeighingDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtHFA)
        Me.Controls.Add(Me.txtNutStatus)
        Me.Controls.Add(Me.txtBMI)
        Me.Controls.Add(Me.txtHeightSquared)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label30)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNutStatForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Weighing Date"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtHFA As System.Windows.Forms.TextBox
    Friend WithEvents txtNutStatus As System.Windows.Forms.TextBox
    Friend WithEvents txtBMI As System.Windows.Forms.TextBox
    Friend WithEvents txtHeightSquared As System.Windows.Forms.TextBox
    Friend WithEvents txtHeight As System.Windows.Forms.TextBox
    Friend WithEvents txtWeight As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpWeighingDate As System.Windows.Forms.DateTimePicker
End Class
