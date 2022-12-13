<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudeSpecialReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudeSpecialReport))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cboEthnicity = New System.Windows.Forms.ComboBox
        Me.EthnicityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet2 = New SIMS.DataSet2
        Me.cboProvince = New System.Windows.Forms.ComboBox
        Me.ProvinceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cboReligion = New System.Windows.Forms.ComboBox
        Me.ReligionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboCity = New System.Windows.Forms.ComboBox
        Me.CityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.specialReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.btnPreviewProv = New System.Windows.Forms.Button
        Me.btnPreviewCity = New System.Windows.Forms.Button
        Me.btnPreviewEthnicity = New System.Windows.Forms.Button
        Me.ProvinceTableAdapter = New SIMS.DataSet2TableAdapters.provinceTableAdapter
        Me.CityTableAdapter = New SIMS.DataSet2TableAdapters.CityTableAdapter
        Me.btnPreviewReligion = New System.Windows.Forms.Button
        Me.EthnicityTableAdapter = New SIMS.DataSet2TableAdapters.ethnicityTableAdapter
        Me.ReligionTableAdapter = New SIMS.DataSet2TableAdapters.ReligionTableAdapter
        Me.Panel1.SuspendLayout()
        CType(Me.EthnicityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProvinceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.ReligionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cboEthnicity)
        Me.Panel1.Controls.Add(Me.cboProvince)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(1, 21)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1059, 28)
        Me.Panel1.TabIndex = 1
        '
        'cboEthnicity
        '
        Me.cboEthnicity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboEthnicity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboEthnicity.DataSource = Me.EthnicityBindingSource
        Me.cboEthnicity.DisplayMember = "Ethnicity"
        Me.cboEthnicity.FormattingEnabled = True
        Me.cboEthnicity.Location = New System.Drawing.Point(679, 1)
        Me.cboEthnicity.Name = "cboEthnicity"
        Me.cboEthnicity.Size = New System.Drawing.Size(177, 27)
        Me.cboEthnicity.TabIndex = 4
        '
        'EthnicityBindingSource
        '
        Me.EthnicityBindingSource.DataMember = "ethnicity"
        Me.EthnicityBindingSource.DataSource = Me.DataSet2
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "DataSet2"
        Me.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboProvince
        '
        Me.cboProvince.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboProvince.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboProvince.DataSource = Me.ProvinceBindingSource
        Me.cboProvince.DisplayMember = "Province"
        Me.cboProvince.FormattingEnabled = True
        Me.cboProvince.Location = New System.Drawing.Point(152, 1)
        Me.cboProvince.Name = "cboProvince"
        Me.cboProvince.Size = New System.Drawing.Size(177, 27)
        Me.cboProvince.TabIndex = 2
        '
        'ProvinceBindingSource
        '
        Me.ProvinceBindingSource.DataMember = "province"
        Me.ProvinceBindingSource.DataSource = Me.DataSet2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(600, 5)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "By Ethnicity"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(27, 4)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "By Province"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.cboReligion)
        Me.Panel2.Controls.Add(Me.cboCity)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(1, 55)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1059, 28)
        Me.Panel2.TabIndex = 2
        '
        'cboReligion
        '
        Me.cboReligion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboReligion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboReligion.DataSource = Me.ReligionBindingSource
        Me.cboReligion.DisplayMember = "Religion"
        Me.cboReligion.FormattingEnabled = True
        Me.cboReligion.Location = New System.Drawing.Point(679, 1)
        Me.cboReligion.Name = "cboReligion"
        Me.cboReligion.Size = New System.Drawing.Size(177, 27)
        Me.cboReligion.TabIndex = 4
        '
        'ReligionBindingSource
        '
        Me.ReligionBindingSource.DataMember = "Religion"
        Me.ReligionBindingSource.DataSource = Me.DataSet2
        '
        'cboCity
        '
        Me.cboCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCity.DataSource = Me.CityBindingSource
        Me.cboCity.DisplayMember = "City"
        Me.cboCity.FormattingEnabled = True
        Me.cboCity.Location = New System.Drawing.Point(152, 1)
        Me.cboCity.Name = "cboCity"
        Me.cboCity.Size = New System.Drawing.Size(177, 27)
        Me.cboCity.TabIndex = 1
        '
        'CityBindingSource
        '
        Me.CityBindingSource.DataMember = "City"
        Me.CityBindingSource.DataSource = Me.DataSet2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(600, 5)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "By Religion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(27, 4)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "By City/Municipality"
        '
        'specialReportViewer
        '
        Me.specialReportViewer.ActiveViewIndex = -1
        Me.specialReportViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.specialReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.specialReportViewer.DisplayGroupTree = False
        Me.specialReportViewer.Location = New System.Drawing.Point(1, 89)
        Me.specialReportViewer.Name = "specialReportViewer"
        Me.specialReportViewer.SelectionFormula = ""
        Me.specialReportViewer.Size = New System.Drawing.Size(1059, 420)
        Me.specialReportViewer.TabIndex = 4
        Me.specialReportViewer.ViewTimeSelectionFormula = ""
        '
        'btnPreviewProv
        '
        Me.btnPreviewProv.BackColor = System.Drawing.Color.Transparent
        Me.btnPreviewProv.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreviewProv.ForeColor = System.Drawing.Color.Black
        Me.btnPreviewProv.Image = CType(resources.GetObject("btnPreviewProv.Image"), System.Drawing.Image)
        Me.btnPreviewProv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPreviewProv.Location = New System.Drawing.Point(336, 21)
        Me.btnPreviewProv.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPreviewProv.Name = "btnPreviewProv"
        Me.btnPreviewProv.Size = New System.Drawing.Size(90, 28)
        Me.btnPreviewProv.TabIndex = 6
        Me.btnPreviewProv.Text = "&Preview"
        Me.btnPreviewProv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPreviewProv.UseVisualStyleBackColor = False
        '
        'btnPreviewCity
        '
        Me.btnPreviewCity.BackColor = System.Drawing.Color.Transparent
        Me.btnPreviewCity.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreviewCity.ForeColor = System.Drawing.Color.Black
        Me.btnPreviewCity.Image = CType(resources.GetObject("btnPreviewCity.Image"), System.Drawing.Image)
        Me.btnPreviewCity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPreviewCity.Location = New System.Drawing.Point(336, 55)
        Me.btnPreviewCity.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPreviewCity.Name = "btnPreviewCity"
        Me.btnPreviewCity.Size = New System.Drawing.Size(90, 28)
        Me.btnPreviewCity.TabIndex = 7
        Me.btnPreviewCity.Text = "&Preview"
        Me.btnPreviewCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPreviewCity.UseVisualStyleBackColor = False
        '
        'btnPreviewEthnicity
        '
        Me.btnPreviewEthnicity.BackColor = System.Drawing.Color.Transparent
        Me.btnPreviewEthnicity.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreviewEthnicity.ForeColor = System.Drawing.Color.Black
        Me.btnPreviewEthnicity.Image = CType(resources.GetObject("btnPreviewEthnicity.Image"), System.Drawing.Image)
        Me.btnPreviewEthnicity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPreviewEthnicity.Location = New System.Drawing.Point(863, 22)
        Me.btnPreviewEthnicity.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPreviewEthnicity.Name = "btnPreviewEthnicity"
        Me.btnPreviewEthnicity.Size = New System.Drawing.Size(90, 28)
        Me.btnPreviewEthnicity.TabIndex = 8
        Me.btnPreviewEthnicity.Text = "&Preview"
        Me.btnPreviewEthnicity.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPreviewEthnicity.UseVisualStyleBackColor = False
        '
        'ProvinceTableAdapter
        '
        Me.ProvinceTableAdapter.ClearBeforeFill = True
        '
        'CityTableAdapter
        '
        Me.CityTableAdapter.ClearBeforeFill = True
        '
        'btnPreviewReligion
        '
        Me.btnPreviewReligion.BackColor = System.Drawing.Color.Transparent
        Me.btnPreviewReligion.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreviewReligion.ForeColor = System.Drawing.Color.Black
        Me.btnPreviewReligion.Image = CType(resources.GetObject("btnPreviewReligion.Image"), System.Drawing.Image)
        Me.btnPreviewReligion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPreviewReligion.Location = New System.Drawing.Point(863, 56)
        Me.btnPreviewReligion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPreviewReligion.Name = "btnPreviewReligion"
        Me.btnPreviewReligion.Size = New System.Drawing.Size(90, 28)
        Me.btnPreviewReligion.TabIndex = 10
        Me.btnPreviewReligion.Text = "&Preview"
        Me.btnPreviewReligion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPreviewReligion.UseVisualStyleBackColor = False
        '
        'EthnicityTableAdapter
        '
        Me.EthnicityTableAdapter.ClearBeforeFill = True
        '
        'ReligionTableAdapter
        '
        Me.ReligionTableAdapter.ClearBeforeFill = True
        '
        'frmStudeSpecialReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1059, 510)
        Me.Controls.Add(Me.btnPreviewReligion)
        Me.Controls.Add(Me.btnPreviewEthnicity)
        Me.Controls.Add(Me.btnPreviewCity)
        Me.Controls.Add(Me.btnPreviewProv)
        Me.Controls.Add(Me.specialReportViewer)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmStudeSpecialReport"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OTHER REPORTS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.EthnicityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProvinceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ReligionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboProvince As System.Windows.Forms.ComboBox
    Friend WithEvents cboCity As System.Windows.Forms.ComboBox
    Friend WithEvents specialReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnPreviewProv As System.Windows.Forms.Button
    Friend WithEvents btnPreviewCity As System.Windows.Forms.Button
    Friend WithEvents btnPreviewEthnicity As System.Windows.Forms.Button
    Friend WithEvents DataSet2 As SIMS.DataSet2
    Friend WithEvents ProvinceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProvinceTableAdapter As SIMS.DataSet2TableAdapters.provinceTableAdapter
    Friend WithEvents CityBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CityTableAdapter As SIMS.DataSet2TableAdapters.CityTableAdapter
    Friend WithEvents btnPreviewReligion As System.Windows.Forms.Button
    Friend WithEvents cboReligion As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboEthnicity As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents EthnicityBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EthnicityTableAdapter As SIMS.DataSet2TableAdapters.ethnicityTableAdapter
    Friend WithEvents ReligionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReligionTableAdapter As SIMS.DataSet2TableAdapters.ReligionTableAdapter
End Class
