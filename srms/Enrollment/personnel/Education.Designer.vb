<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEducation
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
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtSchoolName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblID = New System.Windows.Forms.Label
        Me.cboLevel = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.txtCourse = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.txtFrom = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtTo = New System.Windows.Forms.TextBox
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.txtHigestLevel = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.txtScholarship = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtYearGraduated = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(414, 266)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(73, 30)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(335, 266)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(73, 30)
        Me.btnUpdate.TabIndex = 15
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(256, 266)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(73, 30)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtSchoolName)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(1, 71)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(489, 32)
        Me.Panel2.TabIndex = 2
        '
        'txtSchoolName
        '
        Me.txtSchoolName.Location = New System.Drawing.Point(109, 3)
        Me.txtSchoolName.Name = "txtSchoolName"
        Me.txtSchoolName.Size = New System.Drawing.Size(377, 26)
        Me.txtSchoolName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "School Name"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cboLevel)
        Me.Panel1.Location = New System.Drawing.Point(1, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(489, 32)
        Me.Panel1.TabIndex = 0
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(20, 272)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(35, 19)
        Me.lblID.TabIndex = 23
        Me.lblID.Text = "lblID"
        Me.lblID.Visible = False
        '
        'cboLevel
        '
        Me.cboLevel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboLevel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboLevel.FormattingEnabled = True
        Me.cboLevel.Items.AddRange(New Object() {"Elementary", "Secondary", "Vocational/Trade Course", "College", "Graduate Studies"})
        Me.cboLevel.Location = New System.Drawing.Point(109, 3)
        Me.cboLevel.Name = "cboLevel"
        Me.cboLevel.Size = New System.Drawing.Size(377, 27)
        Me.cboLevel.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Level"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.Controls.Add(Me.txtCourse)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(1, 109)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(489, 32)
        Me.Panel3.TabIndex = 4
        '
        'txtCourse
        '
        Me.txtCourse.Location = New System.Drawing.Point(109, 3)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(377, 26)
        Me.txtCourse.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Course"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel4.Controls.Add(Me.txtTo)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.txtFrom)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Location = New System.Drawing.Point(1, 147)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(489, 32)
        Me.Panel4.TabIndex = 6
        '
        'txtFrom
        '
        Me.txtFrom.Location = New System.Drawing.Point(250, 4)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(93, 26)
        Me.txtFrom.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(195, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Period of Attendance (Year Only)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(349, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 19)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "To"
        '
        'txtTo
        '
        Me.txtTo.Location = New System.Drawing.Point(378, 3)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(108, 26)
        Me.txtTo.TabIndex = 8
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel5.Controls.Add(Me.txtHigestLevel)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Location = New System.Drawing.Point(1, 185)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(489, 32)
        Me.Panel5.TabIndex = 9
        '
        'txtHigestLevel
        '
        Me.txtHigestLevel.Location = New System.Drawing.Point(187, 3)
        Me.txtHigestLevel.Name = "txtHigestLevel"
        Me.txtHigestLevel.Size = New System.Drawing.Size(299, 26)
        Me.txtHigestLevel.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(163, 19)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Highest Level/Units Earned"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel6.Controls.Add(Me.txtScholarship)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Controls.Add(Me.txtYearGraduated)
        Me.Panel6.Controls.Add(Me.Label8)
        Me.Panel6.Location = New System.Drawing.Point(1, 223)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(489, 32)
        Me.Panel6.TabIndex = 11
        '
        'txtScholarship
        '
        Me.txtScholarship.Location = New System.Drawing.Point(283, 3)
        Me.txtScholarship.Name = "txtScholarship"
        Me.txtScholarship.Size = New System.Drawing.Size(203, 26)
        Me.txtScholarship.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(205, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 19)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Scholarship"
        '
        'txtYearGraduated
        '
        Me.txtYearGraduated.Location = New System.Drawing.Point(123, 3)
        Me.txtYearGraduated.Name = "txtYearGraduated"
        Me.txtYearGraduated.Size = New System.Drawing.Size(74, 26)
        Me.txtYearGraduated.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 19)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Year Graduated"
        '
        'frmEducation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(490, 308)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblID)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEducation"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Education"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtSchoolName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboLevel As System.Windows.Forms.ComboBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtCourse As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txtTo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFrom As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents txtHigestLevel As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents txtScholarship As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtYearGraduated As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
