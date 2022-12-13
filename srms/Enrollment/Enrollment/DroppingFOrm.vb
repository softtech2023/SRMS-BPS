Imports MySql.Data.MySqlClient
Public Class frmDroppingFOrm
    Dim str As String
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            str = "insert into studestat values(0,'" & frmSemStudent.lblID.Text & "','" & frmSemStudent.mskStudentNumber.Text & "','Dropped','" & txtReason.Text & "','','" & Convert.ToDateTime(dtpProcessedDate.Text).ToString("yyyy-MM-dd") & "','" & frmParent.lblSem.Text & "','" & frmParent.lblSY.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()

            'update semesterstude status
            str = "update semesterstude set Status='Dropped' where semstudentid='" & frmSemStudent.lblID.Text & "'"
            conn.Open()
            Dim mysc1 As New MySqlCommand(str, conn)
            mysc1.ExecuteNonQuery()
            conn.Close()

            MsgBox("Record saved!", MsgBoxStyle.Information)
            txtReason.Clear()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class