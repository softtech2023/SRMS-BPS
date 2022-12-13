Imports MySql.Data.MySqlClient
Public Class frmTrainings
    Dim str As String
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            str = "insert into hris_trainings values(0,'" & txtTrainingTitle.Text & "','" & Convert.ToDateTime(dtpStarted.Text).ToString("yyyy-MM-dd") & "','" & Convert.ToDateTime(dtpEnded.Text).ToString("yyyy-MM-dd") & "','" & txtHours.Text & "','" & cboType.Text & "','" & txtSponsor.Text & "','" & frmStaff.mskIDNumber.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()
            MsgBox("New record added!", MsgBoxStyle.Information)
            FormLoad()
            frmStaff.getTrainings()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub FormLoad()
        txtTrainingTitle.Clear()
        dtpEnded.Text = Today
        dtpStarted.Text = Today
        txtHours.Clear()
        cboType.ResetText()
        txtSponsor.Clear()

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from hris_trainings where trainingID='" & lblID.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()
                MsgBox("1 record deleted successfully!", MsgBoxStyle.Information)
                FormLoad()

                Me.Close()
                frmStaff.getTrainings()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            str = "update hris_trainings set trainingTitle='" & txtTrainingTitle.Text & "',dateStarted='" & Convert.ToDateTime(dtpStarted.Text).ToString("yyyy-MM-dd") & "',dateFinished='" & Convert.ToDateTime(dtpEnded.Text).ToString("yyyy-MM-dd") & "',noHours='" & txtHours.Text & "',ldType='" & cboType.Text & "',sponsor='" & txtSponsor.Text & "' where trainingID='" & lblID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()
            MsgBox("Updated successfully!", MsgBoxStyle.Information)
            FormLoad()
            frmStaff.getTrainings()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub


End Class