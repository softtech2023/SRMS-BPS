Imports MySql.Data.MySqlClient
Public Class frmVW
    Dim str As String
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            str = "insert into hris_vw values(0,'" & txtOrgName.Text & "','" & txtAddress.Text & "','" & Convert.ToDateTime(dtpStarted.Text).ToString("yyyy-MM-dd") & "','" & Convert.ToDateTime(dtpEnded.Text).ToString("yyyy-MM-dd") & "','" & txtHours.Text & "','" & txtPosition.Text & "','" & frmStaff.mskIDNumber.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(Str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()
            MsgBox("New record added!", MsgBoxStyle.Information)
            FormLoad()
            frmStaff.getVW()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Public Sub FormLoad()

        txtOrgName.Clear()
        txtAddress.Clear()
        dtpStarted.Text = Today
        dtpEnded.Text = Today
        txtHours.Clear()
        txtPosition.Clear()



    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from hris_vw where vwID='" & lblID.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()
                MsgBox("1 record deleted successfully!", MsgBoxStyle.Information)
                FormLoad()

                Me.Close()
                frmStaff.getVW()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            str = "update hris_vw set orgName='" & txtOrgName.Text & "',orgAddress='" & txtAddress.Text & "',dateStarted='" & Convert.ToDateTime(dtpStarted.Text).ToString("yyyy-MM-dd") & "',dateEnded='" & Convert.ToDateTime(dtpEnded.Text).ToString("yyyy-MM-dd") & "',noHours='" & txtHours.Text & "',position='" & txtPosition.Text & "' where vwID='" & lblID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()
            MsgBox("Updated successfully!", MsgBoxStyle.Information)
            FormLoad()
            frmStaff.getVW()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class