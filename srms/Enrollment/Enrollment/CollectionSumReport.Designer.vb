<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCollectionSumReport
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
        Me.summary = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'summary
        '
        Me.summary.ActiveViewIndex = -1
        Me.summary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.summary.DisplayGroupTree = False
        Me.summary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.summary.Location = New System.Drawing.Point(0, 0)
        Me.summary.Name = "summary"
        Me.summary.SelectionFormula = ""
        Me.summary.Size = New System.Drawing.Size(766, 437)
        Me.summary.TabIndex = 0
        Me.summary.ViewTimeSelectionFormula = ""
        '
        'frmCollectionSumReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 437)
        Me.Controls.Add(Me.summary)
        Me.Name = "frmCollectionSumReport"
        Me.Text = "CollectionSumReport"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents summary As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
