<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCAVReq
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboPurpose = New System.Windows.Forms.ComboBox
        Me.txtControlNo = New System.Windows.Forms.TextBox
        Me.dtpApplicationDate = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtReleasedDate = New System.Windows.Forms.TextBox
        Me.dg1 = New System.Windows.Forms.DataGridView
        Me.Label5 = New System.Windows.Forms.Label
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(470, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Purpose"
        '
        'cboPurpose
        '
        Me.cboPurpose.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboPurpose.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPurpose.FormattingEnabled = True
        Me.cboPurpose.Items.AddRange(New Object() {"Employment Record", "Seaman''s Book/SRC Visa", "Migration Abroad/Allowance", "Fiance Visa", "Tourist Visa", "Student Visa", "Descendants", "Reimbursement of Educational Tuition Fees of OFWs", "Other Purpose as Maybe Required by the DFA"})
        Me.cboPurpose.Location = New System.Drawing.Point(578, 154)
        Me.cboPurpose.Name = "cboPurpose"
        Me.cboPurpose.Size = New System.Drawing.Size(297, 27)
        Me.cboPurpose.TabIndex = 4
        '
        'txtControlNo
        '
        Me.txtControlNo.Location = New System.Drawing.Point(578, 54)
        Me.txtControlNo.Name = "txtControlNo"
        Me.txtControlNo.Size = New System.Drawing.Size(129, 26)
        Me.txtControlNo.TabIndex = 0
        '
        'dtpApplicationDate
        '
        Me.dtpApplicationDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpApplicationDate.Location = New System.Drawing.Point(578, 90)
        Me.dtpApplicationDate.Name = "dtpApplicationDate"
        Me.dtpApplicationDate.Size = New System.Drawing.Size(129, 26)
        Me.dtpApplicationDate.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(470, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Control No."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(470, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Application Date"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(578, 187)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(109, 34)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(470, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Released Date"
        '
        'txtReleasedDate
        '
        Me.txtReleasedDate.Location = New System.Drawing.Point(578, 122)
        Me.txtReleasedDate.Name = "txtReleasedDate"
        Me.txtReleasedDate.Size = New System.Drawing.Size(129, 26)
        Me.txtReleasedDate.TabIndex = 3
        '
        'dg1
        '
        Me.dg1.AllowUserToAddRows = False
        Me.dg1.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dg1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg1.Location = New System.Drawing.Point(0, 54)
        Me.dg1.Name = "dg1"
        Me.dg1.ReadOnly = True
        Me.dg1.Size = New System.Drawing.Size(443, 261)
        Me.dg1.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(713, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 19)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "ex. 31-July-2018"
        '
        'frmCAVReq
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(895, 319)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dg1)
        Me.Controls.Add(Me.txtReleasedDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpApplicationDate)
        Me.Controls.Add(Me.txtControlNo)
        Me.Controls.Add(Me.cboPurpose)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCAVReq"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CAV Request Form"
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboPurpose As System.Windows.Forms.ComboBox
    Friend WithEvents txtControlNo As System.Windows.Forms.TextBox
    Friend WithEvents dtpApplicationDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtReleasedDate As System.Windows.Forms.TextBox
    Friend WithEvents dg1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
