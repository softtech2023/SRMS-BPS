<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoading
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoading))
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblInstructorID = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboInstructor = New System.Windows.Forms.ComboBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnStudeAccount = New System.Windows.Forms.Button
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Controls.Add(Me.lblInstructorID)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.cboInstructor)
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(1, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(438, 83)
        Me.Panel2.TabIndex = 0
        '
        'lblInstructorID
        '
        Me.lblInstructorID.AutoSize = True
        Me.lblInstructorID.Location = New System.Drawing.Point(63, 56)
        Me.lblInstructorID.Name = "lblInstructorID"
        Me.lblInstructorID.Size = New System.Drawing.Size(81, 19)
        Me.lblInstructorID.TabIndex = 46
        Me.lblInstructorID.Text = "Instructor ID"
        Me.lblInstructorID.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(327, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 28)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Select"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 19)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Teacher"
        '
        'cboInstructor
        '
        Me.cboInstructor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboInstructor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboInstructor.DisplayMember = "Course"
        Me.cboInstructor.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboInstructor.ForeColor = System.Drawing.Color.Black
        Me.cboInstructor.FormattingEnabled = True
        Me.cboInstructor.Location = New System.Drawing.Point(82, 26)
        Me.cboInstructor.Name = "cboInstructor"
        Me.cboInstructor.Size = New System.Drawing.Size(239, 27)
        Me.cboInstructor.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(246, 29)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 25)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnStudeAccount
        '
        Me.btnStudeAccount.BackColor = System.Drawing.Color.Transparent
        Me.btnStudeAccount.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudeAccount.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnStudeAccount.Image = CType(resources.GetObject("btnStudeAccount.Image"), System.Drawing.Image)
        Me.btnStudeAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStudeAccount.Location = New System.Drawing.Point(328, 101)
        Me.btnStudeAccount.Name = "btnStudeAccount"
        Me.btnStudeAccount.Size = New System.Drawing.Size(75, 31)
        Me.btnStudeAccount.TabIndex = 3
        Me.btnStudeAccount.Text = "&Preview"
        Me.btnStudeAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStudeAccount.UseVisualStyleBackColor = False
        '
        'frmLoading
        '
        Me.AcceptButton = Me.btnStudeAccount
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(438, 139)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnStudeAccount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLoading"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loading"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboInstructor As System.Windows.Forms.ComboBox
    Friend WithEvents btnStudeAccount As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblInstructorID As System.Windows.Forms.Label
End Class
