<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCapture
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PicBox = New System.Windows.Forms.PictureBox
        Me.lstDevices = New System.Windows.Forms.ListBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnStop = New System.Windows.Forms.Button
        Me.btnStart = New System.Windows.Forms.Button
        Me.SaveFile = New System.Windows.Forms.SaveFileDialog
        Me.GroupBox1.SuspendLayout()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.PicBox)
        Me.GroupBox1.Controls.Add(Me.lstDevices)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(516, 294)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'PicBox
        '
        Me.PicBox.BackColor = System.Drawing.Color.Black
        Me.PicBox.Location = New System.Drawing.Point(324, 71)
        Me.PicBox.Name = "PicBox"
        Me.PicBox.Size = New System.Drawing.Size(183, 206)
        Me.PicBox.TabIndex = 1
        Me.PicBox.TabStop = False
        '
        'lstDevices
        '
        Me.lstDevices.FormattingEnabled = True
        Me.lstDevices.ItemHeight = 15
        Me.lstDevices.Location = New System.Drawing.Point(6, 71)
        Me.lstDevices.Name = "lstDevices"
        Me.lstDevices.Size = New System.Drawing.Size(220, 214)
        Me.lstDevices.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnStop)
        Me.Panel1.Controls.Add(Me.btnStart)
        Me.Panel1.Location = New System.Drawing.Point(6, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(501, 41)
        Me.Panel1.TabIndex = 13
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(393, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(91, 30)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save Image"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(293, 5)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(91, 30)
        Me.btnStop.TabIndex = 6
        Me.btnStop.Text = "Stop Preview"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(188, 5)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(91, 30)
        Me.btnStart.TabIndex = 5
        Me.btnStart.Text = "Start Preview"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'SaveFile
        '
        Me.SaveFile.Filter = "JPEG |*.jpg"
        '
        'frmCapture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 305)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCapture"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "[  Capture Image  ]"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PicBox As System.Windows.Forms.PictureBox
    Friend WithEvents lstDevices As System.Windows.Forms.ListBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents SaveFile As System.Windows.Forms.SaveFileDialog
End Class
