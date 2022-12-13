<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBooksInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBooksInfo))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cboAuthor = New System.Windows.Forms.TextBox
        Me.txtAccNo = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.btnSelect = New System.Windows.Forms.Button
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtStatus = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtDeweyNum = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.cboCategory = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtCallNum = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtCoAuthors = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.txtPrice = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtEdition = New System.Windows.Forms.TextBox
        Me.txtISBN = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtSubject = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.cboPublisher = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtYPublished = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtAuthorNum = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtTitle = New System.Windows.Forms.TextBox
        Me.cboLocation = New System.Windows.Forms.ComboBox
        Me.txtBookNum = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblCopies = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnOK = New System.Windows.Forms.Button
        Me.lblID = New System.Windows.Forms.Label
        Me.mainProfTS = New System.Windows.Forms.ToolStrip
        Me.tsSave = New System.Windows.Forms.ToolStripButton
        Me.tsDuplicate = New System.Windows.Forms.ToolStripButton
        Me.tsUpdate = New System.Windows.Forms.ToolStripButton
        Me.tsDelete = New System.Windows.Forms.ToolStripButton
        Me.tsSearch = New System.Windows.Forms.ToolStripButton
        Me.tsClose = New System.Windows.Forms.ToolStripButton
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.mainProfTS.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboAuthor)
        Me.GroupBox1.Controls.Add(Me.txtAccNo)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.btnSelect)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txtStatus)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txtDeweyNum)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.cboCategory)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtCallNum)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtCoAuthors)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.dtpDate)
        Me.GroupBox1.Controls.Add(Me.txtPrice)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtEdition)
        Me.GroupBox1.Controls.Add(Me.txtISBN)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtSubject)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cboPublisher)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtYPublished)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtAuthorNum)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtTitle)
        Me.GroupBox1.Controls.Add(Me.cboLocation)
        Me.GroupBox1.Controls.Add(Me.txtBookNum)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.btnOK)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 78)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(738, 452)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cboAuthor
        '
        Me.cboAuthor.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAuthor.Location = New System.Drawing.Point(345, 166)
        Me.cboAuthor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboAuthor.Name = "cboAuthor"
        Me.cboAuthor.ReadOnly = True
        Me.cboAuthor.Size = New System.Drawing.Size(230, 26)
        Me.cboAuthor.TabIndex = 48
        '
        'txtAccNo
        '
        Me.txtAccNo.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccNo.Location = New System.Drawing.Point(143, 314)
        Me.txtAccNo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAccNo.Name = "txtAccNo"
        Me.txtAccNo.Size = New System.Drawing.Size(123, 26)
        Me.txtAccNo.TabIndex = 10
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(84, 317)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 19)
        Me.Label16.TabIndex = 43
        Me.Label16.Text = "Acc No."
        '
        'btnSelect
        '
        Me.btnSelect.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.Location = New System.Drawing.Point(581, 166)
        Me.btnSelect.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(63, 27)
        Me.btnSelect.TabIndex = 41
        Me.btnSelect.TabStop = False
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(291, 420)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(44, 19)
        Me.Label20.TabIndex = 40
        Me.Label20.Text = "Status"
        '
        'txtStatus
        '
        Me.txtStatus.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.Location = New System.Drawing.Point(341, 417)
        Me.txtStatus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(111, 26)
        Me.txtStatus.TabIndex = 17
        Me.txtStatus.TabStop = False
        Me.txtStatus.Text = "In"
        Me.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(81, 420)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(56, 19)
        Me.Label19.TabIndex = 38
        Me.Label19.Text = "Location"
        '
        'txtDeweyNum
        '
        Me.txtDeweyNum.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeweyNum.Location = New System.Drawing.Point(520, 132)
        Me.txtDeweyNum.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDeweyNum.Name = "txtDeweyNum"
        Me.txtDeweyNum.Size = New System.Drawing.Size(124, 26)
        Me.txtDeweyNum.TabIndex = 4
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(455, 135)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(59, 19)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = "Dewey #"
        '
        'cboCategory
        '
        Me.cboCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCategory.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Location = New System.Drawing.Point(143, 382)
        Me.cboCategory.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(123, 27)
        Me.cboCategory.TabIndex = 13
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(77, 385)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 19)
        Me.Label17.TabIndex = 34
        Me.Label17.Text = "Category"
        '
        'txtCallNum
        '
        Me.txtCallNum.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCallNum.Location = New System.Drawing.Point(345, 98)
        Me.txtCallNum.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCallNum.Name = "txtCallNum"
        Me.txtCallNum.Size = New System.Drawing.Size(299, 26)
        Me.txtCallNum.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(297, 101)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 19)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Call #"
        '
        'txtCoAuthors
        '
        Me.txtCoAuthors.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCoAuthors.Location = New System.Drawing.Point(143, 201)
        Me.txtCoAuthors.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCoAuthors.Multiline = True
        Me.txtCoAuthors.Name = "txtCoAuthors"
        Me.txtCoAuthors.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtCoAuthors.Size = New System.Drawing.Size(501, 71)
        Me.txtCoAuthors.TabIndex = 7
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(64, 204)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(73, 19)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Co-Authors"
        '
        'dtpDate
        '
        Me.dtpDate.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(527, 417)
        Me.dtpDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(117, 26)
        Me.dtpDate.TabIndex = 18
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(528, 382)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(116, 26)
        Me.txtPrice.TabIndex = 15
        Me.txtPrice.Text = "0.00"
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(469, 420)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 19)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Date"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(468, 385)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 19)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Price"
        '
        'txtEdition
        '
        Me.txtEdition.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEdition.Location = New System.Drawing.Point(341, 382)
        Me.txtEdition.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEdition.Name = "txtEdition"
        Me.txtEdition.Size = New System.Drawing.Size(116, 26)
        Me.txtEdition.TabIndex = 14
        '
        'txtISBN
        '
        Me.txtISBN.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtISBN.Location = New System.Drawing.Point(143, 348)
        Me.txtISBN.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(187, 26)
        Me.txtISBN.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(288, 385)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 19)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Edition"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(99, 351)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 19)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "ISBN"
        '
        'txtSubject
        '
        Me.txtSubject.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubject.Location = New System.Drawing.Point(341, 314)
        Me.txtSubject.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSubject.Multiline = True
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtSubject.Size = New System.Drawing.Size(303, 60)
        Me.txtSubject.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(285, 317)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 19)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Subject"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(292, 169)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 19)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Author"
        '
        'cboPublisher
        '
        Me.cboPublisher.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboPublisher.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPublisher.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPublisher.FormattingEnabled = True
        Me.cboPublisher.Location = New System.Drawing.Point(341, 280)
        Me.cboPublisher.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboPublisher.Name = "cboPublisher"
        Me.cboPublisher.Size = New System.Drawing.Size(303, 27)
        Me.cboPublisher.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(274, 283)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 19)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Publisher"
        '
        'txtYPublished
        '
        Me.txtYPublished.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYPublished.Location = New System.Drawing.Point(143, 280)
        Me.txtYPublished.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtYPublished.Name = "txtYPublished"
        Me.txtYPublished.Size = New System.Drawing.Size(123, 26)
        Me.txtYPublished.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(44, 283)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 19)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Copyright Year"
        '
        'txtAuthorNum
        '
        Me.txtAuthorNum.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthorNum.Location = New System.Drawing.Point(143, 166)
        Me.txtAuthorNum.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAuthorNum.Name = "txtAuthorNum"
        Me.txtAuthorNum.ReadOnly = True
        Me.txtAuthorNum.Size = New System.Drawing.Size(123, 26)
        Me.txtAuthorNum.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(66, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 19)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Author No."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(104, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Title"
        '
        'txtTitle
        '
        Me.txtTitle.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(143, 132)
        Me.txtTitle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(294, 26)
        Me.txtTitle.TabIndex = 3
        '
        'cboLocation
        '
        Me.cboLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboLocation.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLocation.FormattingEnabled = True
        Me.cboLocation.Location = New System.Drawing.Point(143, 417)
        Me.cboLocation.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboLocation.Name = "cboLocation"
        Me.cboLocation.Size = New System.Drawing.Size(123, 27)
        Me.cboLocation.TabIndex = 16
        '
        'txtBookNum
        '
        Me.txtBookNum.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookNum.Location = New System.Drawing.Point(143, 98)
        Me.txtBookNum.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBookNum.Name = "txtBookNum"
        Me.txtBookNum.Size = New System.Drawing.Size(123, 26)
        Me.txtBookNum.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(76, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Book No."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblCopies)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(7, 20)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(731, 48)
        Me.Panel1.TabIndex = 0
        '
        'lblCopies
        '
        Me.lblCopies.AutoSize = True
        Me.lblCopies.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopies.ForeColor = System.Drawing.Color.White
        Me.lblCopies.Location = New System.Drawing.Point(617, 18)
        Me.lblCopies.Name = "lblCopies"
        Me.lblCopies.Size = New System.Drawing.Size(16, 19)
        Me.lblCopies.TabIndex = 42
        Me.lblCopies.Text = "1"
        Me.lblCopies.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(522, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 19)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "No. of Copies:"
        Me.Label3.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Condensed", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(5, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(299, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BOOKS ENTRY FORM"
        '
        'btnOK
        '
        Me.btnOK.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(557, 101)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(87, 23)
        Me.btnOK.TabIndex = 44
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(569, 33)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(19, 19)
        Me.lblID.TabIndex = 18
        Me.lblID.Text = "id"
        Me.lblID.Visible = False
        '
        'mainProfTS
        '
        Me.mainProfTS.BackColor = System.Drawing.Color.Transparent
        Me.mainProfTS.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainProfTS.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.mainProfTS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsSave, Me.tsDuplicate, Me.tsUpdate, Me.tsDelete, Me.tsSearch, Me.tsClose})
        Me.mainProfTS.Location = New System.Drawing.Point(0, 0)
        Me.mainProfTS.Margin = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.mainProfTS.Name = "mainProfTS"
        Me.mainProfTS.Padding = New System.Windows.Forms.Padding(0)
        Me.mainProfTS.Size = New System.Drawing.Size(738, 74)
        Me.mainProfTS.TabIndex = 19
        Me.mainProfTS.Text = "ts"
        '
        'tsSave
        '
        Me.tsSave.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsSave.Image = CType(resources.GetObject("tsSave.Image"), System.Drawing.Image)
        Me.tsSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSave.Name = "tsSave"
        Me.tsSave.Size = New System.Drawing.Size(52, 71)
        Me.tsSave.Text = "&Save"
        Me.tsSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsSave.ToolTipText = "Ctrl + S"
        '
        'tsDuplicate
        '
        Me.tsDuplicate.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsDuplicate.Image = CType(resources.GetObject("tsDuplicate.Image"), System.Drawing.Image)
        Me.tsDuplicate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsDuplicate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDuplicate.Name = "tsDuplicate"
        Me.tsDuplicate.Size = New System.Drawing.Size(66, 71)
        Me.tsDuplicate.Text = "Duplicate"
        Me.tsDuplicate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsUpdate
        '
        Me.tsUpdate.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsUpdate.Image = CType(resources.GetObject("tsUpdate.Image"), System.Drawing.Image)
        Me.tsUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsUpdate.Name = "tsUpdate"
        Me.tsUpdate.Size = New System.Drawing.Size(54, 71)
        Me.tsUpdate.Text = "&Update"
        Me.tsUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsUpdate.ToolTipText = "Ctrl + U"
        '
        'tsDelete
        '
        Me.tsDelete.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsDelete.Image = CType(resources.GetObject("tsDelete.Image"), System.Drawing.Image)
        Me.tsDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDelete.Name = "tsDelete"
        Me.tsDelete.Size = New System.Drawing.Size(52, 71)
        Me.tsDelete.Text = "&Delete"
        Me.tsDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsDelete.ToolTipText = "Del"
        '
        'tsSearch
        '
        Me.tsSearch.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsSearch.Image = CType(resources.GetObject("tsSearch.Image"), System.Drawing.Image)
        Me.tsSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSearch.Name = "tsSearch"
        Me.tsSearch.Size = New System.Drawing.Size(52, 71)
        Me.tsSearch.Text = "S&earch"
        Me.tsSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsSearch.ToolTipText = "Ctrl + F"
        '
        'tsClose
        '
        Me.tsClose.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsClose.Image = CType(resources.GetObject("tsClose.Image"), System.Drawing.Image)
        Me.tsClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsClose.Name = "tsClose"
        Me.tsClose.Size = New System.Drawing.Size(52, 71)
        Me.tsClose.Text = "Close"
        Me.tsClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'frmBooksInfo
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 534)
        Me.Controls.Add(Me.mainProfTS)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmBooksInfo"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.mainProfTS.ResumeLayout(False)
        Me.mainProfTS.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboLocation As System.Windows.Forms.ComboBox
    Friend WithEvents txtBookNum As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboPublisher As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtYPublished As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAuthorNum As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtEdition As System.Windows.Forms.TextBox
    Friend WithEvents txtISBN As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtSubject As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtCoAuthors As System.Windows.Forms.TextBox
    Friend WithEvents txtCallNum As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboCategory As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtDeweyNum As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label

    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblCopies As System.Windows.Forms.Label
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents txtAccNo As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents cboAuthor As System.Windows.Forms.TextBox
    Friend WithEvents mainProfTS As System.Windows.Forms.ToolStrip
    Friend WithEvents tsSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsDuplicate As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsUpdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsClose As System.Windows.Forms.ToolStripButton
End Class
