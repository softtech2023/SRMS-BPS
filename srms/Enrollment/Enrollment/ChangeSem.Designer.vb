<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangeSem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangeSem))
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtSYfrom = New System.Windows.Forms.TextBox
        Me.txtSYto = New System.Windows.Forms.TextBox
        Me.cboSem = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(26, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "School Year"
        '
        'txtSYfrom
        '
        Me.txtSYfrom.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtSYfrom.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSYfrom.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txtSYfrom.Location = New System.Drawing.Point(123, 3)
        Me.txtSYfrom.Name = "txtSYfrom"
        Me.txtSYfrom.Size = New System.Drawing.Size(90, 30)
        Me.txtSYfrom.TabIndex = 2
        Me.txtSYfrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSYto
        '
        Me.txtSYto.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtSYto.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSYto.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txtSYto.Location = New System.Drawing.Point(239, 3)
        Me.txtSYto.Name = "txtSYto"
        Me.txtSYto.ReadOnly = True
        Me.txtSYto.Size = New System.Drawing.Size(90, 30)
        Me.txtSYto.TabIndex = 3
        Me.txtSYto.TabStop = False
        Me.txtSYto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboSem
        '
        Me.cboSem.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cboSem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSem.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSem.ForeColor = System.Drawing.SystemColors.MenuText
        Me.cboSem.FormattingEnabled = True
        Me.cboSem.Items.AddRange(New Object() {"", "1st Sem.", "2nd Sem.", "Summer"})
        Me.cboSem.Location = New System.Drawing.Point(123, 39)
        Me.cboSem.Name = "cboSem"
        Me.cboSem.Size = New System.Drawing.Size(206, 30)
        Me.cboSem.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(44, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 22)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Semester"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(218, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 22)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "-"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cboSem)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtSYto)
        Me.Panel1.Controls.Add(Me.txtSYfrom)
        Me.Panel1.Location = New System.Drawing.Point(0, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(367, 72)
        Me.Panel1.TabIndex = 7
        '
        'ChangeSem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(369, 161)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ChangeSem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Semester"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSYfrom As System.Windows.Forms.TextBox
    Friend WithEvents txtSYto As System.Windows.Forms.TextBox
    Friend WithEvents cboSem As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
