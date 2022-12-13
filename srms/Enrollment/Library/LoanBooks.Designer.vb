<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoanBooks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoanBooks))
        Me.txtCourse = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtStudentNo = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnselectbook = New System.Windows.Forms.Button
        Me.lblBookID = New System.Windows.Forms.Label
        Me.txtreturndate = New System.Windows.Forms.TextBox
        Me.txtprocby = New System.Windows.Forms.TextBox
        Me.dtpduedate = New System.Windows.Forms.DateTimePicker
        Me.dtpborroweddate = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblReturnedDate = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtbookno = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txttitle = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnSelectStaff = New System.Windows.Forms.Button
        Me.lblNo = New System.Windows.Forms.Label
        Me.lblYes = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtYearLevel = New System.Windows.Forms.TextBox
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tsSave = New System.Windows.Forms.ToolStripButton
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCourse
        '
        Me.txtCourse.Location = New System.Drawing.Point(89, 130)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.ReadOnly = True
        Me.txtCourse.Size = New System.Drawing.Size(284, 26)
        Me.txtCourse.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Student No."
        '
        'txtStudentNo
        '
        Me.txtStudentNo.Location = New System.Drawing.Point(89, 56)
        Me.txtStudentNo.Name = "txtStudentNo"
        Me.txtStudentNo.ReadOnly = True
        Me.txtStudentNo.Size = New System.Drawing.Size(210, 26)
        Me.txtStudentNo.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnselectbook)
        Me.GroupBox2.Controls.Add(Me.lblBookID)
        Me.GroupBox2.Controls.Add(Me.txtreturndate)
        Me.GroupBox2.Controls.Add(Me.txtprocby)
        Me.GroupBox2.Controls.Add(Me.dtpduedate)
        Me.GroupBox2.Controls.Add(Me.dtpborroweddate)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.lblReturnedDate)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtbookno)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txttitle)
        Me.GroupBox2.Location = New System.Drawing.Point(394, 70)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(350, 270)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Book's Information"
        '
        'btnselectbook
        '
        Me.btnselectbook.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnselectbook.Location = New System.Drawing.Point(275, 56)
        Me.btnselectbook.Name = "btnselectbook"
        Me.btnselectbook.Size = New System.Drawing.Size(68, 26)
        Me.btnselectbook.TabIndex = 17
        Me.btnselectbook.Text = "Select" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Book"
        Me.btnselectbook.UseVisualStyleBackColor = True
        '
        'lblBookID
        '
        Me.lblBookID.AutoSize = True
        Me.lblBookID.Location = New System.Drawing.Point(160, 22)
        Me.lblBookID.Name = "lblBookID"
        Me.lblBookID.Size = New System.Drawing.Size(49, 19)
        Me.lblBookID.TabIndex = 16
        Me.lblBookID.Text = "bookID"
        Me.lblBookID.Visible = False
        '
        'txtreturndate
        '
        Me.txtreturndate.Location = New System.Drawing.Point(114, 232)
        Me.txtreturndate.Name = "txtreturndate"
        Me.txtreturndate.ReadOnly = True
        Me.txtreturndate.Size = New System.Drawing.Size(151, 26)
        Me.txtreturndate.TabIndex = 15
        Me.txtreturndate.Visible = False
        '
        'txtprocby
        '
        Me.txtprocby.Location = New System.Drawing.Point(114, 200)
        Me.txtprocby.Name = "txtprocby"
        Me.txtprocby.ReadOnly = True
        Me.txtprocby.Size = New System.Drawing.Size(151, 26)
        Me.txtprocby.TabIndex = 14
        Me.txtprocby.Visible = False
        '
        'dtpduedate
        '
        Me.dtpduedate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpduedate.Location = New System.Drawing.Point(114, 168)
        Me.dtpduedate.Name = "dtpduedate"
        Me.dtpduedate.Size = New System.Drawing.Size(151, 26)
        Me.dtpduedate.TabIndex = 13
        '
        'dtpborroweddate
        '
        Me.dtpborroweddate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpborroweddate.Location = New System.Drawing.Point(114, 130)
        Me.dtpborroweddate.Name = "dtpborroweddate"
        Me.dtpborroweddate.Size = New System.Drawing.Size(151, 26)
        Me.dtpborroweddate.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 133)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 19)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Borrowed Date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(41, 171)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 19)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Due Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 203)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 19)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Proccessed By"
        Me.Label8.Visible = False
        '
        'lblReturnedDate
        '
        Me.lblReturnedDate.AutoSize = True
        Me.lblReturnedDate.Location = New System.Drawing.Point(12, 235)
        Me.lblReturnedDate.Name = "lblReturnedDate"
        Me.lblReturnedDate.Size = New System.Drawing.Size(92, 19)
        Me.lblReturnedDate.TabIndex = 8
        Me.lblReturnedDate.Text = "Returned Date"
        Me.lblReturnedDate.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(43, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 19)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Book No."
        '
        'txtbookno
        '
        Me.txtbookno.Location = New System.Drawing.Point(114, 56)
        Me.txtbookno.Name = "txtbookno"
        Me.txtbookno.ReadOnly = True
        Me.txtbookno.Size = New System.Drawing.Size(151, 26)
        Me.txtbookno.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(71, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Title"
        '
        'txttitle
        '
        Me.txttitle.Location = New System.Drawing.Point(114, 94)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.ReadOnly = True
        Me.txttitle.Size = New System.Drawing.Size(151, 26)
        Me.txttitle.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Course"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSelectStaff)
        Me.GroupBox1.Controls.Add(Me.lblNo)
        Me.GroupBox1.Controls.Add(Me.lblYes)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtYearLevel)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCourse)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtStudentNo)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(379, 270)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student's Information"
        '
        'btnSelectStaff
        '
        Me.btnSelectStaff.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectStaff.Location = New System.Drawing.Point(305, 56)
        Me.btnSelectStaff.Name = "btnSelectStaff"
        Me.btnSelectStaff.Size = New System.Drawing.Size(68, 26)
        Me.btnSelectStaff.TabIndex = 12
        Me.btnSelectStaff.Text = "Select" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Borrower"
        Me.btnSelectStaff.UseVisualStyleBackColor = True
        '
        'lblNo
        '
        Me.lblNo.AutoSize = True
        Me.lblNo.Location = New System.Drawing.Point(301, 227)
        Me.lblNo.Name = "lblNo"
        Me.lblNo.Size = New System.Drawing.Size(26, 19)
        Me.lblNo.TabIndex = 11
        Me.lblNo.Text = "No"
        Me.lblNo.Visible = False
        '
        'lblYes
        '
        Me.lblYes.AutoSize = True
        Me.lblYes.Location = New System.Drawing.Point(231, 227)
        Me.lblYes.Name = "lblYes"
        Me.lblYes.Size = New System.Drawing.Size(29, 19)
        Me.lblYes.TabIndex = 10
        Me.lblYes.Text = "Yes"
        Me.lblYes.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(89, 94)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(210, 26)
        Me.txtName.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Year Level"
        '
        'txtYearLevel
        '
        Me.txtYearLevel.Location = New System.Drawing.Point(89, 168)
        Me.txtYearLevel.Name = "txtYearLevel"
        Me.txtYearLevel.ReadOnly = True
        Me.txtYearLevel.Size = New System.Drawing.Size(210, 26)
        Me.txtYearLevel.TabIndex = 5
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsSave})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(751, 58)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsSave
        '
        Me.tsSave.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsSave.Image = CType(resources.GetObject("tsSave.Image"), System.Drawing.Image)
        Me.tsSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSave.Name = "tsSave"
        Me.tsSave.Size = New System.Drawing.Size(54, 55)
        Me.tsSave.Text = "&Borrow"
        Me.tsSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'frmLoanBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 350)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmLoanBooks"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loan Books"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCourse As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtStudentNo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtreturndate As System.Windows.Forms.TextBox
    Friend WithEvents txtprocby As System.Windows.Forms.TextBox
    Friend WithEvents dtpduedate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpborroweddate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblReturnedDate As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtbookno As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txttitle As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtYearLevel As System.Windows.Forms.TextBox
    Friend WithEvents lblBookID As System.Windows.Forms.Label
    Friend WithEvents lblNo As System.Windows.Forms.Label
    Friend WithEvents lblYes As System.Windows.Forms.Label
    Friend WithEvents btnSelectStaff As System.Windows.Forms.Button
    Friend WithEvents btnselectbook As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsSave As System.Windows.Forms.ToolStripButton
End Class
