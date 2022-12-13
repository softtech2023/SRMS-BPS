Imports MySql.Data.MySqlClient
Public Class frmChangePassword
    Dim str As String
 
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim pass As String

        If txtNewPassword.Text <> txtConfirm.Text Then
            MsgBox("Password not matched!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        pass = getSHA1Hash(txtConfirm.Text)

        str = "update users set password='" & pass & "' where username='" & frmParent.lblUser.Text & "'"
        conn.Open()
        Dim mysc As New MySqlCommand(str, conn)
        mysc.ExecuteNonQuery()
        conn.Close()
        MsgBox("Your password has been updated!", MsgBoxStyle.Information)

    End Sub
End Class