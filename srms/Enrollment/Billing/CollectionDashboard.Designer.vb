<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCollectionDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCollectionDashboard))
        Me.dtpReport = New System.Windows.Forms.DateTimePicker
        Me.btnPreview = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cboPaymentMode = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboSource = New System.Windows.Forms.ComboBox
        Me.lblORStatus = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpReport
        '
        Me.dtpReport.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpReport.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpReport.Location = New System.Drawing.Point(132, 29)
        Me.dtpReport.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpReport.Name = "dtpReport"
        Me.dtpReport.Size = New System.Drawing.Size(148, 26)
        Me.dtpReport.TabIndex = 1
        '
        'btnPreview
        '
        Me.btnPreview.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPreview.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreview.Location = New System.Drawing.Point(132, 129)
        Me.btnPreview.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(148, 37)
        Me.btnPreview.TabIndex = 4
        Me.btnPreview.Text = "&Preview"
        Me.btnPreview.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Date"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.cboPaymentMode)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cboSource)
        Me.Panel1.Controls.Add(Me.lblORStatus)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnPreview)
        Me.Panel1.Controls.Add(Me.dtpReport)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(425, 182)
        Me.Panel1.TabIndex = 0
        '
        'cboPaymentMode
        '
        Me.cboPaymentMode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboPaymentMode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPaymentMode.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPaymentMode.FormattingEnabled = True
        Me.cboPaymentMode.Items.AddRange(New Object() {"All", "Cash", "Check"})
        Me.cboPaymentMode.Location = New System.Drawing.Point(132, 95)
        Me.cboPaymentMode.Name = "cboPaymentMode"
        Me.cboPaymentMode.Size = New System.Drawing.Size(148, 27)
        Me.cboPaymentMode.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 19)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Payment Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 19)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Collection Source"
        '
        'cboSource
        '
        Me.cboSource.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSource.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSource.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSource.FormattingEnabled = True
        Me.cboSource.Items.AddRange(New Object() {"All", "Student's Account", "Services"})
        Me.cboSource.Location = New System.Drawing.Point(132, 62)
        Me.cboSource.Name = "cboSource"
        Me.cboSource.Size = New System.Drawing.Size(148, 27)
        Me.cboSource.TabIndex = 2
        '
        'lblORStatus
        '
        Me.lblORStatus.AutoSize = True
        Me.lblORStatus.Location = New System.Drawing.Point(99, 5)
        Me.lblORStatus.Name = "lblORStatus"
        Me.lblORStatus.Size = New System.Drawing.Size(30, 13)
        Me.lblORStatus.TabIndex = 14
        Me.lblORStatus.Text = "Valid"
        Me.lblORStatus.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(136, 32)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(50, 12)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'frmCollectionDashboard
        '
        Me.AcceptButton = Me.btnPreview
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(449, 206)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCollectionDashboard"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "[ Daily Collections ]"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtpReport As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblORStatus As System.Windows.Forms.Label
    Friend WithEvents cboSource As System.Windows.Forms.ComboBox
    Friend WithEvents cboPaymentMode As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
