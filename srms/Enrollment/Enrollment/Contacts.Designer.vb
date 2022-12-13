<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContacts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContacts))
        Me.dgcontacts = New System.Windows.Forms.DataGridView
        Me.lblID = New System.Windows.Forms.Label
        CType(Me.dgcontacts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgcontacts
        '
        Me.dgcontacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgcontacts.Location = New System.Drawing.Point(12, 71)
        Me.dgcontacts.Name = "dgcontacts"
        Me.dgcontacts.Size = New System.Drawing.Size(512, 222)
        Me.dgcontacts.TabIndex = 0
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(399, 10)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(39, 13)
        Me.lblID.TabIndex = 1
        Me.lblID.Text = "Label1"
        '
        'frmContacts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 305)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.dgcontacts)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmContacts"
        Me.Text = "Contacts"
        CType(Me.dgcontacts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgcontacts As System.Windows.Forms.DataGridView
    Friend WithEvents lblID As System.Windows.Forms.Label
End Class
