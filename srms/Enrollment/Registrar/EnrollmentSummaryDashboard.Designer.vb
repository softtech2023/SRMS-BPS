<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnrollmentSummaryDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEnrollmentSummaryDashboard))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboStatus = New System.Windows.Forms.ComboBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.txtSY = New System.Windows.Forms.TextBox
        Me.cboSem = New System.Windows.Forms.ComboBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnPreview = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cboStatus)
        Me.Panel1.Controls.Add(Me.Label33)
        Me.Panel1.Controls.Add(Me.txtSY)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(12, 13)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(425, 70)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(274, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 18)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Status"
        '
        'cboStatus
        '
        Me.cboStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboStatus.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cboStatus.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatus.ForeColor = System.Drawing.SystemColors.MenuText
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Assessed", "Cancelled", "Enrolled"})
        Me.cboStatus.Location = New System.Drawing.Point(320, 22)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(83, 26)
        Me.cboStatus.Sorted = True
        Me.cboStatus.TabIndex = 3
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(152, 25)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(21, 18)
        Me.Label33.TabIndex = 21
        Me.Label33.Text = "SY"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(31, 98)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(30, 18)
        Me.Label32.TabIndex = 20
        Me.Label32.Text = "Sem"
        '
        'txtSY
        '
        Me.txtSY.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSY.Location = New System.Drawing.Point(179, 22)
        Me.txtSY.Name = "txtSY"
        Me.txtSY.Size = New System.Drawing.Size(83, 25)
        Me.txtSY.TabIndex = 2
        Me.txtSY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboSem
        '
        Me.cboSem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSem.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cboSem.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSem.ForeColor = System.Drawing.SystemColors.MenuText
        Me.cboSem.FormattingEnabled = True
        Me.cboSem.Items.AddRange(New Object() {"1st Sem.", "2nd Sem.", "Summer"})
        Me.cboSem.Location = New System.Drawing.Point(67, 95)
        Me.cboSem.Name = "cboSem"
        Me.cboSem.Size = New System.Drawing.Size(84, 26)
        Me.cboSem.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(321, 23)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 22)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnPreview
        '
        Me.btnPreview.BackColor = System.Drawing.Color.Transparent
        Me.btnPreview.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreview.ForeColor = System.Drawing.Color.Black
        Me.btnPreview.Image = CType(resources.GetObject("btnPreview.Image"), System.Drawing.Image)
        Me.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPreview.Location = New System.Drawing.Point(340, 91)
        Me.btnPreview.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(75, 31)
        Me.btnPreview.TabIndex = 4
        Me.btnPreview.Text = "&Preview"
        Me.btnPreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPreview.UseVisualStyleBackColor = False
        '
        'frmEnrollmentSummaryDashboard
        '
        Me.AcceptButton = Me.btnPreview
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(445, 128)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.cboSem)
        Me.Controls.Add(Me.Label32)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEnrollmentSummaryDashboard"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enrollment Summary"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtSY As System.Windows.Forms.TextBox
    Friend WithEvents cboSem As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
End Class
