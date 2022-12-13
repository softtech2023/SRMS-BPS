<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainViewer))
        Me.ReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.btnClose = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ReportViewer
        '
        Me.ReportViewer.ActiveViewIndex = -1
        Me.ReportViewer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReportViewer.DisplayGroupTree = False
        Me.ReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.ReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer.Name = "ReportViewer"
        Me.ReportViewer.SelectionFormula = ""
        Me.ReportViewer.ShowCloseButton = False
        Me.ReportViewer.ShowGroupTreeButton = False
        Me.ReportViewer.Size = New System.Drawing.Size(962, 685)
        Me.ReportViewer.TabIndex = 1
        Me.ReportViewer.ViewTimeSelectionFormula = ""
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(369, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmMainViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(962, 685)
        Me.Controls.Add(Me.ReportViewer)
        Me.Controls.Add(Me.btnClose)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMainViewer"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Report Viewer"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
