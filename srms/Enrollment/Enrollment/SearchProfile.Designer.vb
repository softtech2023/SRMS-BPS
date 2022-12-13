<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchProfile
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchProfile))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.cboSearch = New System.Windows.Forms.ComboBox
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.dgstudentsearch = New System.Windows.Forms.DataGridView
        Me.DataSet = New Enrollment.DataSet
        Me.StudeprofileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudeprofileTableAdapter = New Enrollment.DataSetTableAdapters.studeprofileTableAdapter
        Me.StudentNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MiddleNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BPlaceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CivilStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContactNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GuardianDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RelationshipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GuardianContactDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CourseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RemarksDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NationalityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ElementaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ElementaryDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SecondaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SecondaryDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LastSchoolAttendedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AdmissionDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AdmissionCredentialsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GraduationDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SONumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgstudentsearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudeprofileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.dgstudentsearch)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(529, 346)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cboSearch)
        Me.GroupBox4.Controls.Add(Me.txtSearch)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox4.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(517, 60)
        Me.GroupBox4.TabIndex = 24
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Search"
        '
        'cboSearch
        '
        Me.cboSearch.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cboSearch.FormattingEnabled = True
        Me.cboSearch.Items.AddRange(New Object() {"by Student Number", "by Lastname", " by Course"})
        Me.cboSearch.Location = New System.Drawing.Point(324, 19)
        Me.cboSearch.Name = "cboSearch"
        Me.cboSearch.Size = New System.Drawing.Size(187, 32)
        Me.cboSearch.TabIndex = 1
        Me.cboSearch.Text = "Search Category"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(67, 22)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(251, 29)
        Me.txtSearch.TabIndex = 0
        '
        'dgstudentsearch
        '
        Me.dgstudentsearch.AllowUserToAddRows = False
        Me.dgstudentsearch.AllowUserToDeleteRows = False
        Me.dgstudentsearch.AutoGenerateColumns = False
        Me.dgstudentsearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgstudentsearch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentNumberDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.MiddleNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.BDateDataGridViewTextBoxColumn, Me.BPlaceDataGridViewTextBoxColumn, Me.SexDataGridViewTextBoxColumn, Me.CivilStatusDataGridViewTextBoxColumn, Me.ContactNumberDataGridViewTextBoxColumn, Me.GuardianDataGridViewTextBoxColumn, Me.RelationshipDataGridViewTextBoxColumn, Me.GuardianContactDataGridViewTextBoxColumn, Me.CourseDataGridViewTextBoxColumn, Me.RemarksDataGridViewTextBoxColumn, Me.NationalityDataGridViewTextBoxColumn, Me.ElementaryDataGridViewTextBoxColumn, Me.ElementaryDateDataGridViewTextBoxColumn, Me.SecondaryDataGridViewTextBoxColumn, Me.SecondaryDateDataGridViewTextBoxColumn, Me.LastSchoolAttendedDataGridViewTextBoxColumn, Me.AdmissionDateDataGridViewTextBoxColumn, Me.AdmissionCredentialsDataGridViewTextBoxColumn, Me.GraduationDateDataGridViewTextBoxColumn, Me.SONumberDataGridViewTextBoxColumn})
        Me.dgstudentsearch.DataSource = Me.StudeprofileBindingSource
        Me.dgstudentsearch.Location = New System.Drawing.Point(6, 85)
        Me.dgstudentsearch.Name = "dgstudentsearch"
        Me.dgstudentsearch.Size = New System.Drawing.Size(517, 261)
        Me.dgstudentsearch.TabIndex = 0
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudeprofileBindingSource
        '
        Me.StudeprofileBindingSource.DataMember = "studeprofile"
        Me.StudeprofileBindingSource.DataSource = Me.DataSet
        '
        'StudeprofileTableAdapter
        '
        Me.StudeprofileTableAdapter.ClearBeforeFill = True
        '
        'StudentNumberDataGridViewTextBoxColumn
        '
        Me.StudentNumberDataGridViewTextBoxColumn.DataPropertyName = "StudentNumber"
        Me.StudentNumberDataGridViewTextBoxColumn.HeaderText = "StudentNumber"
        Me.StudentNumberDataGridViewTextBoxColumn.Name = "StudentNumberDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'MiddleNameDataGridViewTextBoxColumn
        '
        Me.MiddleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName"
        Me.MiddleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName"
        Me.MiddleNameDataGridViewTextBoxColumn.Name = "MiddleNameDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'BDateDataGridViewTextBoxColumn
        '
        Me.BDateDataGridViewTextBoxColumn.DataPropertyName = "BDate"
        Me.BDateDataGridViewTextBoxColumn.HeaderText = "BDate"
        Me.BDateDataGridViewTextBoxColumn.Name = "BDateDataGridViewTextBoxColumn"
        '
        'BPlaceDataGridViewTextBoxColumn
        '
        Me.BPlaceDataGridViewTextBoxColumn.DataPropertyName = "BPlace"
        Me.BPlaceDataGridViewTextBoxColumn.HeaderText = "BPlace"
        Me.BPlaceDataGridViewTextBoxColumn.Name = "BPlaceDataGridViewTextBoxColumn"
        '
        'SexDataGridViewTextBoxColumn
        '
        Me.SexDataGridViewTextBoxColumn.DataPropertyName = "Sex"
        Me.SexDataGridViewTextBoxColumn.HeaderText = "Sex"
        Me.SexDataGridViewTextBoxColumn.Name = "SexDataGridViewTextBoxColumn"
        '
        'CivilStatusDataGridViewTextBoxColumn
        '
        Me.CivilStatusDataGridViewTextBoxColumn.DataPropertyName = "CivilStatus"
        Me.CivilStatusDataGridViewTextBoxColumn.HeaderText = "CivilStatus"
        Me.CivilStatusDataGridViewTextBoxColumn.Name = "CivilStatusDataGridViewTextBoxColumn"
        '
        'ContactNumberDataGridViewTextBoxColumn
        '
        Me.ContactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber"
        Me.ContactNumberDataGridViewTextBoxColumn.HeaderText = "ContactNumber"
        Me.ContactNumberDataGridViewTextBoxColumn.Name = "ContactNumberDataGridViewTextBoxColumn"
        '
        'GuardianDataGridViewTextBoxColumn
        '
        Me.GuardianDataGridViewTextBoxColumn.DataPropertyName = "Guardian"
        Me.GuardianDataGridViewTextBoxColumn.HeaderText = "Guardian"
        Me.GuardianDataGridViewTextBoxColumn.Name = "GuardianDataGridViewTextBoxColumn"
        '
        'RelationshipDataGridViewTextBoxColumn
        '
        Me.RelationshipDataGridViewTextBoxColumn.DataPropertyName = "Relationship"
        Me.RelationshipDataGridViewTextBoxColumn.HeaderText = "Relationship"
        Me.RelationshipDataGridViewTextBoxColumn.Name = "RelationshipDataGridViewTextBoxColumn"
        '
        'GuardianContactDataGridViewTextBoxColumn
        '
        Me.GuardianContactDataGridViewTextBoxColumn.DataPropertyName = "GuardianContact"
        Me.GuardianContactDataGridViewTextBoxColumn.HeaderText = "GuardianContact"
        Me.GuardianContactDataGridViewTextBoxColumn.Name = "GuardianContactDataGridViewTextBoxColumn"
        '
        'CourseDataGridViewTextBoxColumn
        '
        Me.CourseDataGridViewTextBoxColumn.DataPropertyName = "Course"
        Me.CourseDataGridViewTextBoxColumn.HeaderText = "Course"
        Me.CourseDataGridViewTextBoxColumn.Name = "CourseDataGridViewTextBoxColumn"
        '
        'RemarksDataGridViewTextBoxColumn
        '
        Me.RemarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks"
        Me.RemarksDataGridViewTextBoxColumn.HeaderText = "Remarks"
        Me.RemarksDataGridViewTextBoxColumn.Name = "RemarksDataGridViewTextBoxColumn"
        '
        'NationalityDataGridViewTextBoxColumn
        '
        Me.NationalityDataGridViewTextBoxColumn.DataPropertyName = "Nationality"
        Me.NationalityDataGridViewTextBoxColumn.HeaderText = "Nationality"
        Me.NationalityDataGridViewTextBoxColumn.Name = "NationalityDataGridViewTextBoxColumn"
        '
        'ElementaryDataGridViewTextBoxColumn
        '
        Me.ElementaryDataGridViewTextBoxColumn.DataPropertyName = "Elementary"
        Me.ElementaryDataGridViewTextBoxColumn.HeaderText = "Elementary"
        Me.ElementaryDataGridViewTextBoxColumn.Name = "ElementaryDataGridViewTextBoxColumn"
        '
        'ElementaryDateDataGridViewTextBoxColumn
        '
        Me.ElementaryDateDataGridViewTextBoxColumn.DataPropertyName = "ElementaryDate"
        Me.ElementaryDateDataGridViewTextBoxColumn.HeaderText = "ElementaryDate"
        Me.ElementaryDateDataGridViewTextBoxColumn.Name = "ElementaryDateDataGridViewTextBoxColumn"
        '
        'SecondaryDataGridViewTextBoxColumn
        '
        Me.SecondaryDataGridViewTextBoxColumn.DataPropertyName = "Secondary"
        Me.SecondaryDataGridViewTextBoxColumn.HeaderText = "Secondary"
        Me.SecondaryDataGridViewTextBoxColumn.Name = "SecondaryDataGridViewTextBoxColumn"
        '
        'SecondaryDateDataGridViewTextBoxColumn
        '
        Me.SecondaryDateDataGridViewTextBoxColumn.DataPropertyName = "SecondaryDate"
        Me.SecondaryDateDataGridViewTextBoxColumn.HeaderText = "SecondaryDate"
        Me.SecondaryDateDataGridViewTextBoxColumn.Name = "SecondaryDateDataGridViewTextBoxColumn"
        '
        'LastSchoolAttendedDataGridViewTextBoxColumn
        '
        Me.LastSchoolAttendedDataGridViewTextBoxColumn.DataPropertyName = "LastSchoolAttended"
        Me.LastSchoolAttendedDataGridViewTextBoxColumn.HeaderText = "LastSchoolAttended"
        Me.LastSchoolAttendedDataGridViewTextBoxColumn.Name = "LastSchoolAttendedDataGridViewTextBoxColumn"
        '
        'AdmissionDateDataGridViewTextBoxColumn
        '
        Me.AdmissionDateDataGridViewTextBoxColumn.DataPropertyName = "AdmissionDate"
        Me.AdmissionDateDataGridViewTextBoxColumn.HeaderText = "AdmissionDate"
        Me.AdmissionDateDataGridViewTextBoxColumn.Name = "AdmissionDateDataGridViewTextBoxColumn"
        '
        'AdmissionCredentialsDataGridViewTextBoxColumn
        '
        Me.AdmissionCredentialsDataGridViewTextBoxColumn.DataPropertyName = "AdmissionCredentials"
        Me.AdmissionCredentialsDataGridViewTextBoxColumn.HeaderText = "AdmissionCredentials"
        Me.AdmissionCredentialsDataGridViewTextBoxColumn.Name = "AdmissionCredentialsDataGridViewTextBoxColumn"
        '
        'GraduationDateDataGridViewTextBoxColumn
        '
        Me.GraduationDateDataGridViewTextBoxColumn.DataPropertyName = "GraduationDate"
        Me.GraduationDateDataGridViewTextBoxColumn.HeaderText = "GraduationDate"
        Me.GraduationDateDataGridViewTextBoxColumn.Name = "GraduationDateDataGridViewTextBoxColumn"
        '
        'SONumberDataGridViewTextBoxColumn
        '
        Me.SONumberDataGridViewTextBoxColumn.DataPropertyName = "SONumber"
        Me.SONumberDataGridViewTextBoxColumn.HeaderText = "SONumber"
        Me.SONumberDataGridViewTextBoxColumn.Name = "SONumberDataGridViewTextBoxColumn"
        '
        'frmSearchProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 370)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmSearchProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Students Profile"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgstudentsearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudeprofileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cboSearch As System.Windows.Forms.ComboBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents dgstudentsearch As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet As Enrollment.DataSet
    Friend WithEvents StudeprofileBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudeprofileTableAdapter As Enrollment.DataSetTableAdapters.studeprofileTableAdapter
    Friend WithEvents StudentNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MiddleNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BPlaceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SexDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CivilStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GuardianDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RelationshipDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GuardianContactDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CourseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RemarksDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NationalityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ElementaryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ElementaryDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SecondaryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SecondaryDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastSchoolAttendedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdmissionDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdmissionCredentialsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GraduationDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SONumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
