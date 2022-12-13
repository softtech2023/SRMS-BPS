<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportViewer
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
        Me.CRViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.btnClose = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'CRViewer
        '
        Me.CRViewer.ActiveViewIndex = -1
        Me.CRViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRViewer.DisplayGroupTree = False
        Me.CRViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRViewer.Location = New System.Drawing.Point(0, 0)
        Me.CRViewer.Name = "CRViewer"
        Me.CRViewer.SelectionFormula = ""
        Me.CRViewer.Size = New System.Drawing.Size(927, 578)
        Me.CRViewer.TabIndex = 0
        Me.CRViewer.ViewTimeSelectionFormula = ""
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(724, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmReportViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(927, 578)
        Me.Controls.Add(Me.CRViewer)
        Me.Controls.Add(Me.btnClose)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmReportViewer"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Viewer"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
