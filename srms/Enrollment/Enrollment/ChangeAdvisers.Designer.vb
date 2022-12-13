<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangeAdvisers
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboDepartment = New System.Windows.Forms.ComboBox
        Me.cboYearLevel = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtAdviser = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtNewAdviser = New System.Windows.Forms.TextBox
        Me.btnSelect = New System.Windows.Forms.Button
        Me.btnChange = New System.Windows.Forms.Button
        Me.cboSemester = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtSY = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cboSection = New System.Windows.Forms.ComboBox
        Me.lblAdviserID = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Department"
        '
        'cboDepartment
        '
        Me.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDepartment.FormattingEnabled = True
        Me.cboDepartment.Location = New System.Drawing.Point(111, 45)
        Me.cboDepartment.Name = "cboDepartment"
        Me.cboDepartment.Size = New System.Drawing.Size(209, 27)
        Me.cboDepartment.TabIndex = 1
        '
        'cboYearLevel
        '
        Me.cboYearLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYearLevel.FormattingEnabled = True
        Me.cboYearLevel.Location = New System.Drawing.Point(111, 78)
        Me.cboYearLevel.Name = "cboYearLevel"
        Me.cboYearLevel.Size = New System.Drawing.Size(209, 27)
        Me.cboYearLevel.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Grade Level"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Adviser"
        '
        'txtAdviser
        '
        Me.txtAdviser.Location = New System.Drawing.Point(111, 145)
        Me.txtAdviser.Name = "txtAdviser"
        Me.txtAdviser.ReadOnly = True
        Me.txtAdviser.Size = New System.Drawing.Size(315, 26)
        Me.txtAdviser.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(504, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "---------------------------------------------------------------------------------" & _
            "------------------"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 19)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "New Adviser"
        '
        'txtNewAdviser
        '
        Me.txtNewAdviser.Location = New System.Drawing.Point(111, 205)
        Me.txtNewAdviser.Name = "txtNewAdviser"
        Me.txtNewAdviser.ReadOnly = True
        Me.txtNewAdviser.Size = New System.Drawing.Size(315, 26)
        Me.txtNewAdviser.TabIndex = 8
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(433, 205)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(60, 29)
        Me.btnSelect.TabIndex = 9
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'btnChange
        '
        Me.btnChange.Location = New System.Drawing.Point(285, 281)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(141, 31)
        Me.btnChange.TabIndex = 10
        Me.btnChange.Text = "Change"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'cboSemester
        '
        Me.cboSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSemester.FormattingEnabled = True
        Me.cboSemester.Items.AddRange(New Object() {"1st Sem.", "2nd Sem."})
        Me.cboSemester.Location = New System.Drawing.Point(111, 237)
        Me.cboSemester.Name = "cboSemester"
        Me.cboSemester.Size = New System.Drawing.Size(132, 27)
        Me.cboSemester.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 240)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 19)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Effectivity"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(256, 240)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 19)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "SY"
        '
        'txtSY
        '
        Me.txtSY.Location = New System.Drawing.Point(285, 237)
        Me.txtSY.Name = "txtSY"
        Me.txtSY.Size = New System.Drawing.Size(141, 26)
        Me.txtSY.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(55, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 19)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Section"
        '
        'cboSection
        '
        Me.cboSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSection.FormattingEnabled = True
        Me.cboSection.Location = New System.Drawing.Point(111, 111)
        Me.cboSection.Name = "cboSection"
        Me.cboSection.Size = New System.Drawing.Size(209, 27)
        Me.cboSection.TabIndex = 18
        '
        'lblAdviserID
        '
        Me.lblAdviserID.AutoSize = True
        Me.lblAdviserID.Location = New System.Drawing.Point(375, 48)
        Me.lblAdviserID.Name = "lblAdviserID"
        Me.lblAdviserID.Size = New System.Drawing.Size(64, 19)
        Me.lblAdviserID.TabIndex = 29
        Me.lblAdviserID.Text = "AdviserID"
        Me.lblAdviserID.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe Condensed", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 281)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(221, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Note: Semester is not required for JHS or Elementary"
        '
        'frmChangeAdvisers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(505, 331)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblAdviserID)
        Me.Controls.Add(Me.cboSection)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtSY)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboSemester)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.txtNewAdviser)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAdviser)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboYearLevel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboDepartment)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChangeAdvisers"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Adviser Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents cboYearLevel As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAdviser As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNewAdviser As System.Windows.Forms.TextBox
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents btnChange As System.Windows.Forms.Button
    Friend WithEvents cboSemester As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSY As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboSection As System.Windows.Forms.ComboBox
    Friend WithEvents lblAdviserID As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
