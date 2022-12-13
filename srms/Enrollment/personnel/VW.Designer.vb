<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVW
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
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblID = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.txtHours = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.txtPosition = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtpStarted = New System.Windows.Forms.DateTimePicker
        Me.dtpEnded = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtOrgName = New System.Windows.Forms.TextBox
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(414, 215)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(73, 30)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.dtpEnded)
        Me.Panel3.Controls.Add(Me.dtpStarted)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(1, 97)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(489, 32)
        Me.Panel3.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(77, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Date Started"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(335, 215)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(73, 30)
        Me.btnUpdate.TabIndex = 12
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(256, 215)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(73, 30)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtAddress)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(1, 59)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(489, 32)
        Me.Panel2.TabIndex = 2
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(164, 3)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(322, 26)
        Me.txtAddress.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(103, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Address"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtOrgName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(489, 32)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Organization Name"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(28, 212)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(35, 19)
        Me.lblID.TabIndex = 33
        Me.lblID.Text = "lblID"
        Me.lblID.Visible = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel5.Controls.Add(Me.txtHours)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Location = New System.Drawing.Point(1, 135)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(489, 32)
        Me.Panel5.TabIndex = 7
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(164, 3)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(322, 26)
        Me.txtHours.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(54, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "No. of Hours"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel6.Controls.Add(Me.txtPosition)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Location = New System.Drawing.Point(1, 173)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(489, 32)
        Me.Panel6.TabIndex = 9
        '
        'txtPosition
        '
        Me.txtPosition.Location = New System.Drawing.Point(164, 3)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(322, 26)
        Me.txtPosition.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 19)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Position/Nature of Work"
        '
        'dtpStarted
        '
        Me.dtpStarted.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStarted.Location = New System.Drawing.Point(164, 4)
        Me.dtpStarted.Name = "dtpStarted"
        Me.dtpStarted.Size = New System.Drawing.Size(105, 26)
        Me.dtpStarted.TabIndex = 5
        '
        'dtpEnded
        '
        Me.dtpEnded.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEnded.Location = New System.Drawing.Point(381, 4)
        Me.dtpEnded.Name = "dtpEnded"
        Me.dtpEnded.Size = New System.Drawing.Size(105, 26)
        Me.dtpEnded.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(300, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 19)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Date Ended"
        '
        'txtOrgName
        '
        Me.txtOrgName.Location = New System.Drawing.Point(164, 2)
        Me.txtOrgName.Name = "txtOrgName"
        Me.txtOrgName.Size = New System.Drawing.Size(322, 26)
        Me.txtOrgName.TabIndex = 1
        '
        'frmVW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(490, 264)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Panel3)
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
        Me.Name = "frmVW"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Voluntary Work"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents txtHours As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents txtPosition As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpEnded As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpStarted As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtOrgName As System.Windows.Forms.TextBox
End Class
