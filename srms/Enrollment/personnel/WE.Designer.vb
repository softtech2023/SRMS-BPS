<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWE
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
        Me.lblID = New System.Windows.Forms.Label
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.cboGovService = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtAppointStatus = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.txtSalaryGrade = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtSalary = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtOffice = New System.Windows.Forms.TextBox
        Me.txtPosition = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtTo = New System.Windows.Forms.TextBox
        Me.txtFrom = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(12, 218)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(35, 19)
        Me.lblID.TabIndex = 17
        Me.lblID.Text = "lblID"
        Me.lblID.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(422, 218)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(73, 30)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(343, 218)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(73, 30)
        Me.btnUpdate.TabIndex = 13
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(264, 218)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(73, 30)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel4.Controls.Add(Me.cboGovService)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.txtAppointStatus)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Location = New System.Drawing.Point(3, 171)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(495, 32)
        Me.Panel4.TabIndex = 9
        '
        'cboGovService
        '
        Me.cboGovService.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboGovService.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboGovService.FormattingEnabled = True
        Me.cboGovService.Items.AddRange(New Object() {"Yes", "No"})
        Me.cboGovService.Location = New System.Drawing.Point(360, 3)
        Me.cboGovService.Name = "cboGovService"
        Me.cboGovService.Size = New System.Drawing.Size(132, 27)
        Me.cboGovService.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(263, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 19)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Gov't. Service?"
        '
        'txtAppointStatus
        '
        Me.txtAppointStatus.Location = New System.Drawing.Point(135, 3)
        Me.txtAppointStatus.Name = "txtAppointStatus"
        Me.txtAppointStatus.Size = New System.Drawing.Size(122, 26)
        Me.txtAppointStatus.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 19)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Appointment Status"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.Controls.Add(Me.txtSalaryGrade)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.txtSalary)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(3, 117)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(495, 33)
        Me.Panel3.TabIndex = 6
        '
        'txtSalaryGrade
        '
        Me.txtSalaryGrade.Location = New System.Drawing.Point(324, 3)
        Me.txtSalaryGrade.Name = "txtSalaryGrade"
        Me.txtSalaryGrade.Size = New System.Drawing.Size(168, 26)
        Me.txtSalaryGrade.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(231, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 19)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Salary Grade "
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(109, 3)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(118, 26)
        Me.txtSalary.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(59, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Salary"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtOffice)
        Me.Panel2.Controls.Add(Me.txtPosition)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(3, 79)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(495, 32)
        Me.Panel2.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(233, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Office"
        '
        'txtOffice
        '
        Me.txtOffice.Location = New System.Drawing.Point(281, 3)
        Me.txtOffice.Name = "txtOffice"
        Me.txtOffice.Size = New System.Drawing.Size(211, 26)
        Me.txtOffice.TabIndex = 5
        '
        'txtPosition
        '
        Me.txtPosition.Location = New System.Drawing.Point(109, 3)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(118, 26)
        Me.txtPosition.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Position"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "From"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtTo)
        Me.Panel1.Controls.Add(Me.txtFrom)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(3, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(495, 32)
        Me.Panel1.TabIndex = 0
        '
        'txtTo
        '
        Me.txtTo.Location = New System.Drawing.Point(281, 2)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(118, 26)
        Me.txtTo.TabIndex = 2
        '
        'txtFrom
        '
        Me.txtFrom.Location = New System.Drawing.Point(109, 2)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(118, 26)
        Me.txtFrom.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(242, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "To"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(234, 153)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(195, 15)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Salary Grade/Step (11-1), (Format ""00-0"")"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(135, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 15)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "yyyy-MM-dd"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(308, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 15)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "yyyy-MM-dd"
        '
        'frmWE
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(500, 278)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmWE"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Work Experience"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAppointStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtSalary As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPosition As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtOffice As System.Windows.Forms.TextBox
    Friend WithEvents txtSalaryGrade As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboGovService As System.Windows.Forms.ComboBox
    Friend WithEvents txtTo As System.Windows.Forms.TextBox
    Friend WithEvents txtFrom As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
