Imports MySql.Data.MySqlClient
Public Class frmOtherInfo
    Dim str As String
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from hris_oi where oiID='" & lblID.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(Str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()
                MsgBox("1 record deleted successfully!", MsgBoxStyle.Information)
                FormLoad()

                Me.Close()
                frmStaff.getOtherInfo()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Public Sub FormLoad()
        cboType.ResetText()
        txtTitle.Clear()


    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            str = "insert into hris_oi values(0,'" & cboType.Text & "','" & txtTitle.Text & "','" & frmStaff.mskIDNumber.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()
            MsgBox("New record added!", MsgBoxStyle.Information)
            FormLoad()
            frmStaff.getOtherInfo()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            str = "update hris_oi set infoType='" & cboType.Text & "',infoDetails='" & txtTitle.Text & "' where oiID='" & lblID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()
            MsgBox("Updated successfully!", MsgBoxStyle.Information)
            FormLoad()
            frmStaff.getOtherInfo()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class