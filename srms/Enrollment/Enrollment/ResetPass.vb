Imports MySql.Data.MySqlClient
Public Class frmResetPass
    Dim str As String
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            Dim pass As String
            pass = getSHA1Hash(txtPassword.Text)

            str = "update users set password='" & pass & "' where username='" & frmuseraccounts.txtusername.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()
            MsgBox("The password of the selected has been changed.", MsgBoxStyle.Information)
            txtPassword.Clear()
            Me.Close()
            frmuseraccounts.FormLoad()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
End Class