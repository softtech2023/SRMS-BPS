<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsolidatedAverageSHS
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
        Me.rdoFemale = New System.Windows.Forms.RadioButton
        Me.rdoMale = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cboSection = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboYearLevelAccount = New System.Windows.Forms.ComboBox
        Me.btnStudeAccount = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoFemale
        '
        Me.rdoFemale.AutoSize = True
        Me.rdoFemale.Location = New System.Drawing.Point(192, 83)
        Me.rdoFemale.Name = "rdoFemale"
        Me.rdoFemale.Size = New System.Drawing.Size(68, 23)
        Me.rdoFemale.TabIndex = 52
        Me.rdoFemale.TabStop = True
        Me.rdoFemale.Text = "Female"
        Me.rdoFemale.UseVisualStyleBackColor = True
        '
        'rdoMale
        '
        Me.rdoMale.AutoSize = True
        Me.rdoMale.Location = New System.Drawing.Point(106, 83)
        Me.rdoMale.Name = "rdoMale"
        Me.rdoMale.Size = New System.Drawing.Size(55, 23)
        Me.rdoMale.TabIndex = 51
        Me.rdoMale.TabStop = True
        Me.rdoMale.Text = "Male"
        Me.rdoMale.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(267, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 19)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Section"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.rdoFemale)
        Me.Panel1.Controls.Add(Me.rdoMale)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cboSection)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cboYearLevelAccount)
        Me.Panel1.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(4, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(479, 127)
        Me.Panel1.TabIndex = 22
        '
        'cboSection
        '
        Me.cboSection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSection.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSection.ForeColor = System.Drawing.Color.Black
        Me.cboSection.FormattingEnabled = True
        Me.cboSection.Location = New System.Drawing.Point(323, 43)
        Me.cboSection.Name = "cboSection"
        Me.cboSection.Size = New System.Drawing.Size(141, 27)
        Me.cboSection.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(23, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 19)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Grade Level"
        '
        'cboYearLevelAccount
        '
        Me.cboYearLevelAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboYearLevelAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboYearLevelAccount.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYearLevelAccount.ForeColor = System.Drawing.Color.Black
        Me.cboYearLevelAccount.FormattingEnabled = True
        Me.cboYearLevelAccount.Location = New System.Drawing.Point(106, 43)
        Me.cboYearLevelAccount.Name = "cboYearLevelAccount"
        Me.cboYearLevelAccount.Size = New System.Drawing.Size(141, 27)
        Me.cboYearLevelAccount.TabIndex = 18
        '
        'btnStudeAccount
        '
        Me.btnStudeAccount.BackColor = System.Drawing.Color.Transparent
        Me.btnStudeAccount.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudeAccount.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnStudeAccount.Location = New System.Drawing.Point(327, 146)
        Me.btnStudeAccount.Name = "btnStudeAccount"
        Me.btnStudeAccount.Size = New System.Drawing.Size(115, 35)
        Me.btnStudeAccount.TabIndex = 23
        Me.btnStudeAccount.Text = "Preview"
        Me.btnStudeAccount.UseVisualStyleBackColor = False
        '
        'frmConsolidatedAverageSHS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 194)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnStudeAccount)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConsolidatedAverageSHS"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consolidated Average"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rdoFemale As System.Windows.Forms.RadioButton
    Friend WithEvents rdoMale As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cboSection As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboYearLevelAccount As System.Windows.Forms.ComboBox
    Friend WithEvents btnStudeAccount As System.Windows.Forms.Button
End Class
