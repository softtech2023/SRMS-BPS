Public Class ChangeSem

   

    Private Sub txtSYfrom_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSYfrom.KeyDown
        If e.KeyCode = Keys.Enter Then
            changesem()
        End If

    End Sub

    Private Sub txtSYfrom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSYfrom.TextChanged
        txtSYto.Text = Val(txtSYfrom.Text) + 1

    End Sub
    Public Sub changesem()
        Try
            If txtSYfrom.Text = "" Then
                MsgBox("Please enter CALENDAR YEAR!", MsgBoxStyle.Information)
                Exit Sub
            End If

            frmParent.lblSem.Text = cboSem.Text
            frmParent.lblSY.Text = txtSYfrom.Text + "-" + txtSYto.Text
            frmParent.lblSem.Visible = True
            frmParent.lblSY.Visible = True
            frmParent.lblTerm.Visible = False

            frmParent.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

    End Sub

    Private Sub GroupBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            changesem()
        End If
    End Sub

    Private Sub txtSYto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSYto.KeyDown
        If e.KeyCode = Keys.Enter Then
            changesem()
        End If
    End Sub

    Private Sub cboSem_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboSem.KeyDown
        If e.KeyCode = Keys.Enter Then
            changesem()
        End If
    End Sub


    Private Sub cboTerm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            changesem()
        End If
    End Sub

    Private Sub ChangeSem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class