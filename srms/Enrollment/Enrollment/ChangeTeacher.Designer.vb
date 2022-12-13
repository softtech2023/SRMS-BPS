<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangeTeacher
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
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtSY = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cboSemester = New System.Windows.Forms.ComboBox
        Me.btnChange = New System.Windows.Forms.Button
        Me.btnSelect = New System.Windows.Forms.Button
        Me.txtNewTeacher = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtOldTeacher = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSubjectCode = New System.Windows.Forms.TextBox
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.txtSection = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe Condensed", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 268)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(221, 13)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Note: Semester is not required for JHS or Elementary"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(58, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 19)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Section"
        '
        'txtSY
        '
        Me.txtSY.Location = New System.Drawing.Point(282, 224)
        Me.txtSY.Name = "txtSY"
        Me.txtSY.Size = New System.Drawing.Size(141, 26)
        Me.txtSY.TabIndex = 45
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(253, 227)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 19)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "SY"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 19)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Effectivity"
        '
        'cboSemester
        '
        Me.cboSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSemester.FormattingEnabled = True
        Me.cboSemester.Items.AddRange(New Object() {"1st Sem.", "2nd Sem."})
        Me.cboSemester.Location = New System.Drawing.Point(108, 224)
        Me.cboSemester.Name = "cboSemester"
        Me.cboSemester.Size = New System.Drawing.Size(132, 27)
        Me.cboSemester.TabIndex = 42
        '
        'btnChange
        '
        Me.btnChange.Location = New System.Drawing.Point(282, 268)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(141, 31)
        Me.btnChange.TabIndex = 41
        Me.btnChange.Text = "Change"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(430, 192)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(60, 29)
        Me.btnSelect.TabIndex = 40
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'txtNewTeacher
        '
        Me.txtNewTeacher.Location = New System.Drawing.Point(108, 192)
        Me.txtNewTeacher.Name = "txtNewTeacher"
        Me.txtNewTeacher.ReadOnly = True
        Me.txtNewTeacher.Size = New System.Drawing.Size(315, 26)
        Me.txtNewTeacher.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 19)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "New Teacher"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(0, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(504, 19)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "---------------------------------------------------------------------------------" & _
            "------------------"
        '
        'txtOldTeacher
        '
        Me.txtOldTeacher.Location = New System.Drawing.Point(114, 130)
        Me.txtOldTeacher.Name = "txtOldTeacher"
        Me.txtOldTeacher.ReadOnly = True
        Me.txtOldTeacher.Size = New System.Drawing.Size(309, 26)
        Me.txtOldTeacher.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 19)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Teacher"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 19)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Description"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 19)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Subject Code"
        '
        'txtSubjectCode
        '
        Me.txtSubjectCode.Location = New System.Drawing.Point(114, 32)
        Me.txtSubjectCode.Name = "txtSubjectCode"
        Me.txtSubjectCode.ReadOnly = True
        Me.txtSubjectCode.Size = New System.Drawing.Size(126, 26)
        Me.txtSubjectCode.TabIndex = 50
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(114, 65)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(309, 26)
        Me.txtDescription.TabIndex = 51
        '
        'txtSection
        '
        Me.txtSection.Location = New System.Drawing.Point(114, 98)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.ReadOnly = True
        Me.txtSection.Size = New System.Drawing.Size(309, 26)
        Me.txtSection.TabIndex = 52
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(314, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 28)
        Me.Button1.TabIndex = 53
        Me.Button1.TabStop = False
        Me.Button1.Text = "Select Subject"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmChangeTeacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(505, 331)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtSection)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtSubjectCode)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtSY)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboSemester)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.txtNewTeacher)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtOldTeacher)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChangeTeacher"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Teacher"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSY As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboSemester As System.Windows.Forms.ComboBox
    Friend WithEvents btnChange As System.Windows.Forms.Button
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents txtNewTeacher As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtOldTeacher As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSubjectCode As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtSection As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
