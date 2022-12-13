Imports MySql.Data.MySqlClient
Public Class frmCAVReq
    Dim str As String
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            str = "insert into cavreq values ('" & txtControlNo.Text & "','" & Convert.ToDateTime(dtpApplicationDate.Text).ToString("yyyy-MM-dd") & "','" & cboPurpose.Text & "','" & txtReleasedDate.Text & "','" & frmStudeProfile.mskStudentNumber.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()
            MsgBox("Record saved!", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub getControNo()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select * from cavreq order by ctrlNo desc limit 1"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                txtControlNo.Text = dtReader.Item(0).ToString
                txtControlNo.Text = txtControlNo.Text + 1
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub frmCAVReq_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getControNo()
    End Sub
End Class