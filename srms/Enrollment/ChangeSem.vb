Public Class ChangeSem

    Private Sub ChangeSem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtSYfrom_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSYfrom.KeyDown
        If e.KeyCode = Keys.Enter Then
            changesem()
        End If

     

        
    End Sub

    Private Sub txtSYfrom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSYfrom.TextChanged
        txtSYto.Text = Val(txtSYfrom.Text) + 1

    End Sub
    Public Sub changesem()


        frmMain.lblSem.Text = cboSem.Text
        frmMain.lblSY.Text = txtSYfrom.Text + "-" + txtSYto.Text
        frmMain.lblSem.Visible = True
        frmMain.lblSY.Visible = True

        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GroupBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            changesem()
        End If
    End Sub

    Private Sub txtSYto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSYto.KeyDown
        If e.KeyCode = Keys.Enter Then
            changesem()
        End If
    End Sub

    Private Sub txtSYto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSYto.TextChanged

    End Sub

    Private Sub cboSem_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboSem.KeyDown
        If e.KeyCode = Keys.Enter Then
            changesem()
        End If
    End Sub

    Private Sub cboSem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSem.SelectedIndexChanged

    End Sub
End Class