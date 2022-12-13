<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterlistDashboardbyCourse
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMasterlistDashboardbyCourse))
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboYearStat = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSection = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cboStatus = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cboCourse = New System.Windows.Forms.ComboBox
        Me.btnStudentList = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.cboYearStat)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtSection)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.cboStatus)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(1, 93)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(328, 29)
        Me.Panel2.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(161, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 18)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Status"
        Me.Label2.Visible = False
        '
        'cboYearStat
        '
        Me.cboYearStat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboYearStat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboYearStat.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYearStat.ForeColor = System.Drawing.Color.Black
        Me.cboYearStat.FormattingEnabled = True
        Me.cboYearStat.Items.AddRange(New Object() {"Regular", "Irregular"})
        Me.cboYearStat.Location = New System.Drawing.Point(207, 51)
        Me.cboYearStat.Name = "cboYearStat"
        Me.cboYearStat.Size = New System.Drawing.Size(146, 27)
        Me.cboYearStat.TabIndex = 3
        Me.cboYearStat.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Condensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(408, 14)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Note: Leave the Department and Grade Level combo box empty to generate the comple" & _
            "te list"
        '
        'txtSection
        '
        Me.txtSection.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSection.ForeColor = System.Drawing.Color.Black
        Me.txtSection.Location = New System.Drawing.Point(235, 3)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.Size = New System.Drawing.Size(82, 25)
        Me.txtSection.TabIndex = 23
        Me.txtSection.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(150, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 18)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Batch/Section"
        Me.Label10.Visible = False
        '
        'cboStatus
        '
        Me.cboStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboStatus.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatus.ForeColor = System.Drawing.Color.Black
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Assessed", "Cancelled", "Enrolled"})
        Me.cboStatus.Location = New System.Drawing.Point(80, 3)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(64, 26)
        Me.cboStatus.Sorted = True
        Me.cboStatus.TabIndex = 18
        Me.cboStatus.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(34, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 18)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Status"
        Me.Label7.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(17, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 19)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Deparment"
        '
        'cboCourse
        '
        Me.cboCourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboCourse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCourse.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCourse.ForeColor = System.Drawing.Color.Black
        Me.cboCourse.FormattingEnabled = True
        Me.cboCourse.Location = New System.Drawing.Point(96, 12)
        Me.cboCourse.Name = "cboCourse"
        Me.cboCourse.Size = New System.Drawing.Size(201, 27)
        Me.cboCourse.TabIndex = 1
        '
        'btnStudentList
        '
        Me.btnStudentList.BackColor = System.Drawing.Color.Transparent
        Me.btnStudentList.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudentList.ForeColor = System.Drawing.Color.Black
        Me.btnStudentList.Image = CType(resources.GetObject("btnStudentList.Image"), System.Drawing.Image)
        Me.btnStudentList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStudentList.Location = New System.Drawing.Point(303, 9)
        Me.btnStudentList.Name = "btnStudentList"
        Me.btnStudentList.Size = New System.Drawing.Size(77, 31)
        Me.btnStudentList.TabIndex = 4
        Me.btnStudentList.Text = "Preview"
        Me.btnStudentList.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStudentList.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cboCourse)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.btnStudentList)
        Me.Panel1.Location = New System.Drawing.Point(1, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(401, 50)
        Me.Panel1.TabIndex = 1
        '
        'frmMasterlistDashboardbyCourse
        '
        Me.AcceptButton = Me.btnStudentList
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(401, 124)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMasterlistDashboardbyCourse"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "[  Department Masterlist  ]"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtSection As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboCourse As System.Windows.Forms.ComboBox
    Friend WithEvents btnStudentList As System.Windows.Forms.Button
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboYearStat As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
