Imports MySql.Data.MySqlClient
Public Class frmChangeLRN
    Dim str As String
    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click
        Try
            'Change LRN Number under studeprofile
            str = "update studeprofile set StudentNumber='" & txtLRN.Text & "' where FirstName='" & frmStudeProfile.txtFName.Text & "' and LastName='" & frmStudeProfile.txtLName.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()

            'update Student Number on enrollment table
            str = "update semesterstude set StudentNumber='" & txtLRN.Text & "' where FName='" & frmStudeProfile.txtFName.Text & "' and LName='" & frmStudeProfile.txtLName.Text & "'"
            conn.Open()
            Dim mysc1 As New MySqlCommand(str, conn)
            mysc1.ExecuteNonQuery()
            conn.Close()

            'update Student Number on studenent's account table
            str = "update studeaccount set StudentNumber='" & txtLRN.Text & "' where FirstName='" & frmStudeProfile.txtFName.Text & "' and LastName='" & frmStudeProfile.txtLName.Text & "'"
            conn.Open()
            Dim mysc2 As New MySqlCommand(str, conn)
            mysc2.ExecuteNonQuery()
            conn.Close()

            'update Student Number on registration table
            str = "update studeaccount set StudentNumber='" & txtLRN.Text & "' where FirstName='" & frmStudeProfile.txtFName.Text & "' and LastName='" & frmStudeProfile.txtLName.Text & "'"
            conn.Open()
            Dim mysc3 As New MySqlCommand(str, conn)
            mysc3.ExecuteNonQuery()
            conn.Close()

            'update Student Number on promissory table
            str = "update promissory set StudentNumber='" & txtLRN.Text & "' where FirstName='" & frmStudeProfile.txtFName.Text & "' and LastName='" & frmStudeProfile.txtLName.Text & "'"
            conn.Open()
            Dim mysc4 As New MySqlCommand(str, conn)
            mysc4.ExecuteNonQuery()
            conn.Close()

            'update Student Number on payments table
            str = "update paymentsaccounts set StudentNumber='" & txtLRN.Text & "' where FirstName='" & frmStudeProfile.txtFName.Text & "' and LastName='" & frmStudeProfile.txtLName.Text & "'"
            conn.Open()
            Dim mysc5 As New MySqlCommand(str, conn)
            mysc5.ExecuteNonQuery()
            conn.Close()

            'update Student Number on grades table
            str = "update grades set StudentNumber='" & txtLRN.Text & "' where StudentNumber='" & frmStudeProfile.mskStudentNumber.Text & "'"
            conn.Open()
            Dim mysc6 As New MySqlCommand(str, conn)
            mysc6.ExecuteNonQuery()
            conn.Close()

            'update Student Number on grades table
            str = "update docs set StudentNumber='" & txtLRN.Text & "' where StudentNumber='" & frmStudeProfile.mskStudentNumber.Text & "'"
            conn.Open()
            Dim mysc7 As New MySqlCommand(str, conn)
            mysc7.ExecuteNonQuery()
            conn.Close()

            'update Student Requirements
            str = "update docs set StudentNumber='" & txtLRN.Text & "' where StudentNumber='" & frmStudeProfile.mskStudentNumber.Text & "'"
            conn.Open()
            Dim mysc9 As New MySqlCommand(str, conn)
            mysc9.ExecuteNonQuery()
            conn.Close()

            'update users
            str = "update users set username='" & txtLRN.Text & "' where username='" & frmStudeProfile.mskStudentNumber.Text & "'"
            conn.Open()
            Dim mysc8 As New MySqlCommand(str, conn)
            mysc8.ExecuteNonQuery()
            conn.Close()

            MsgBox("LRN has been changed successfully!", MsgBoxStyle.Information)
            txtLRN.Clear()
            Me.Close()
            frmStudeProfile.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Exit Sub
        End Try
    End Sub
End Class