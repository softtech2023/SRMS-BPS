<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintGradingSheet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintGradingSheet))
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnPreview = New System.Windows.Forms.Button
        Me.txtInstructor = New System.Windows.Forms.TextBox
        Me.txtSection = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnSelect = New System.Windows.Forms.Button
        Me.lblUserLevel = New System.Windows.Forms.Label
        Me.lblSection = New System.Windows.Forms.Label
        Me.lblYearLevel = New System.Windows.Forms.Label
        Me.cboPeriod = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtsubjectcode = New System.Windows.Forms.TextBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.ForeColor = System.Drawing.Color.Black
        Me.txtDescription.Location = New System.Drawing.Point(111, 120)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(361, 26)
        Me.txtDescription.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(32, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 19)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Description"
        '
        'btnPreview
        '
        Me.btnPreview.BackColor = System.Drawing.Color.Transparent
        Me.btnPreview.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreview.ForeColor = System.Drawing.Color.Black
        Me.btnPreview.Image = CType(resources.GetObject("btnPreview.Image"), System.Drawing.Image)
        Me.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPreview.Location = New System.Drawing.Point(371, 255)
        Me.btnPreview.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(101, 45)
        Me.btnPreview.TabIndex = 5
        Me.btnPreview.Text = "&Preview"
        Me.btnPreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPreview.UseVisualStyleBackColor = False
        '
        'txtInstructor
        '
        Me.txtInstructor.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInstructor.ForeColor = System.Drawing.Color.Black
        Me.txtInstructor.Location = New System.Drawing.Point(111, 188)
        Me.txtInstructor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtInstructor.Name = "txtInstructor"
        Me.txtInstructor.ReadOnly = True
        Me.txtInstructor.Size = New System.Drawing.Size(361, 26)
        Me.txtInstructor.TabIndex = 4
        '
        'txtSection
        '
        Me.txtSection.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSection.ForeColor = System.Drawing.Color.Black
        Me.txtSection.Location = New System.Drawing.Point(111, 154)
        Me.txtSection.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.ReadOnly = True
        Me.txtSection.Size = New System.Drawing.Size(361, 26)
        Me.txtSection.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.btnSelect)
        Me.Panel1.Controls.Add(Me.lblUserLevel)
        Me.Panel1.Controls.Add(Me.lblSection)
        Me.Panel1.Controls.Add(Me.lblYearLevel)
        Me.Panel1.Controls.Add(Me.cboPeriod)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.txtDescription)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnPreview)
        Me.Panel1.Controls.Add(Me.txtInstructor)
        Me.Panel1.Controls.Add(Me.txtSection)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtsubjectcode)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(2, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(496, 322)
        Me.Panel1.TabIndex = 2
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(229, 86)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(75, 27)
        Me.btnSelect.TabIndex = 52
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'lblUserLevel
        '
        Me.lblUserLevel.AutoSize = True
        Me.lblUserLevel.Location = New System.Drawing.Point(24, 77)
        Me.lblUserLevel.Name = "lblUserLevel"
        Me.lblUserLevel.Size = New System.Drawing.Size(64, 12)
        Me.lblUserLevel.TabIndex = 51
        Me.lblUserLevel.Text = "User Level"
        Me.lblUserLevel.Visible = False
        '
        'lblSection
        '
        Me.lblSection.AutoSize = True
        Me.lblSection.Location = New System.Drawing.Point(425, 77)
        Me.lblSection.Name = "lblSection"
        Me.lblSection.Size = New System.Drawing.Size(47, 12)
        Me.lblSection.TabIndex = 50
        Me.lblSection.Text = "Section"
        Me.lblSection.Visible = False
        '
        'lblYearLevel
        '
        Me.lblYearLevel.AutoSize = True
        Me.lblYearLevel.Location = New System.Drawing.Point(324, 77)
        Me.lblYearLevel.Name = "lblYearLevel"
        Me.lblYearLevel.Size = New System.Drawing.Size(64, 12)
        Me.lblYearLevel.TabIndex = 49
        Me.lblYearLevel.Text = "Year Level"
        Me.lblYearLevel.Visible = False
        '
        'cboPeriod
        '
        Me.cboPeriod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboPeriod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPeriod.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPeriod.FormattingEnabled = True
        Me.cboPeriod.Items.AddRange(New Object() {"1st Grading", "2nd Grading", "3rd Grading", "4th Grading"})
        Me.cboPeriod.Location = New System.Drawing.Point(111, 221)
        Me.cboPeriod.Name = "cboPeriod"
        Me.cboPeriod.Size = New System.Drawing.Size(361, 27)
        Me.cboPeriod.TabIndex = 46
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(60, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 19)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Period"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(-11, -13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(507, 73)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(99, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(314, 40)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "GRADING SHEET"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(50, 191)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 19)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Teacher"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(55, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 19)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Section"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(22, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 19)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Subject Code"
        '
        'txtsubjectcode
        '
        Me.txtsubjectcode.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsubjectcode.ForeColor = System.Drawing.Color.Black
        Me.txtsubjectcode.Location = New System.Drawing.Point(111, 86)
        Me.txtsubjectcode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtsubjectcode.Name = "txtsubjectcode"
        Me.txtsubjectcode.ReadOnly = True
        Me.txtsubjectcode.Size = New System.Drawing.Size(112, 26)
        Me.txtsubjectcode.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(239, 191)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(52, 23)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'frmPrintGradingSheet
        '
        Me.AcceptButton = Me.btnPreview
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 323)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrintGradingSheet"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Grading Sheet"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents txtInstructor As System.Windows.Forms.TextBox
    Friend WithEvents txtSection As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtsubjectcode As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents cboPeriod As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblSection As System.Windows.Forms.Label
    Friend WithEvents lblYearLevel As System.Windows.Forms.Label
    Friend WithEvents lblUserLevel As System.Windows.Forms.Label
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
